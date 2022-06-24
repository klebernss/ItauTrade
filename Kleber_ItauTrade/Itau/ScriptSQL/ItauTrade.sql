IF exists (select * from sysobjects where name='Category' and type='U')
DROP TABLE Category
GO

CREATE TABLE [dbo].[Category](
	[ID] int NOT NULL identity,
	[Name] varchar(100) NOT NULL,
	[Operator] varchar(100) NOT NULL,
    [BaseValue] bigint NOT NULL,
    [Sector] varchar(100) NOT NULL

	CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED ([ID] ASC)
) ON [PRIMARY]
GO

IF exists (select * from sysobjects where name='Trade' and type='U')
DROP TABLE Trade
GO

CREATE TABLE [dbo].[Trade](
	[Value] bigint NOT NULL,
    [ClientSector] varchar(100) NOT NULL
)

GO

IF exists (select * from sysobjects where name='PRD_INS_Category' and xtype='P') 
DROP PROCEDURE PRD_INS_Category
GO

CREATE PROCEDURE PRD_INS_Category
	@Name varchar(100),
	@Operator varchar(100),
    @BaseValue bigint,
    @Sector varchar(100)
AS
BEGIN
	insert into Category values (@Name, @Operator, @BaseValue, @Sector)
END
GO

IF exists (select * from sysobjects where name='PRD_INS_Trade' and xtype='P') 
DROP PROCEDURE PRD_INS_Trade
GO

CREATE PROCEDURE PRD_INS_Trade
    @Value bigint,
    @ClientSector varchar(100)
AS
BEGIN
	insert into Trade values (@Value, @ClientSector)
END
GO

IF exists (select * from sysobjects where name='PRD_SEL_ItauTradeOutput' and xtype='P') 
DROP PROCEDURE PRD_SEL_ItauTradeOutput
GO

CREATE PROCEDURE PRD_SEL_ItauTradeOutput
AS
BEGIN
	DECLARE @Value bigint, @ClientSector varchar(100), @result varchar(100), 
			@Output varchar(1000) = 'tradeCategories = {',
			@Contador int = 0
			declare @tmpCategory table (result varchar(100))

	DECLARE trade_cursor CURSOR FOR select Value, ClientSector from Trade 
	OPEN trade_cursor;  
	FETCH NEXT FROM trade_cursor into @value, @ClientSector;  
	WHILE @@FETCH_STATUS = 0  
	BEGIN  
		insert into @tmpCategory
		select case 
									when Sector = @ClientSector and Operator = 'EqualTo' and @Value = BaseValue then Name
									when Sector = @ClientSector and Operator = 'GratherEqualTo' and @Value >= BaseValue then Name
									when Sector = @ClientSector and Operator = 'GratherThan' and @Value > BaseValue then Name
									when Sector = @ClientSector and Operator = 'LessEqualTo' and @Value <= BaseValue then Name
									when Sector = @ClientSector and Operator = 'LessThan' and @Value < BaseValue then Name
								end
				from Category 
	FETCH NEXT FROM trade_cursor into @value, @ClientSector;  
	END  
  
	CLOSE trade_cursor;  
	DEALLOCATE trade_cursor;

	DECLARE trade_cursor CURSOR FOR select result from @tmpCategory where result is not null
	OPEN trade_cursor;  
	FETCH NEXT FROM trade_cursor into @result;  
	WHILE @@FETCH_STATUS = 0  
	BEGIN  
		
		set @Output = Concat(@Output, (case when @Contador = 0 then '"' else ', "' end), @result, '"')
		set @Contador = @Contador + 1
	FETCH NEXT FROM trade_cursor into @result;  
	END  
  
	CLOSE trade_cursor;  
	DEALLOCATE trade_cursor;

	set @Output = Concat(@Output, '}')

	select @Output
END
GO

EXEC PRD_INS_Category 'LOWRISK', 'LessThan', 1000000, 'Public'
EXEC PRD_INS_Category 'MEDIUMRISK', 'GratherThan', 1000000, 'Public'
EXEC PRD_INS_Category 'HIGHRISK', 'GratherThan', 1000000, 'Private'
GO

EXEC PRD_INS_Trade 2000000, 'Private'
EXEC PRD_INS_Trade 400000, 'Public'
EXEC PRD_INS_Trade 500000, 'Public'
EXEC PRD_INS_Trade 3000000, 'Public'
GO

EXEC PRD_SEL_ItauTradeOutput
GO
		