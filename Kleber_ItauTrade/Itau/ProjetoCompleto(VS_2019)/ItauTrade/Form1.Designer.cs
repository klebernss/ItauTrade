namespace ItauTrade
{
    partial class frmItauTrades
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.del = new System.Windows.Forms.DataGridViewImageColumn();
            this.upd = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvTrades = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOutPut = new System.Windows.Forms.Label();
            this.btnInsertCategory = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnInsertTrade = new System.Windows.Forms.Button();
            this.DelTrade = new System.Windows.Forms.DataGridViewImageColumn();
            this.UpdTrade = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrades)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categories";
            // 
            // dgvCategory
            // 
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.del,
            this.upd});
            this.dgvCategory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvCategory.Location = new System.Drawing.Point(53, 35);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.Size = new System.Drawing.Size(648, 175);
            this.dgvCategory.TabIndex = 2;
            this.dgvCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellContentClick);
            // 
            // del
            // 
            this.del.HeaderText = "";
            this.del.Image = global::ItauTrade.Properties.Resources.del;
            this.del.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.del.Name = "del";
            this.del.ReadOnly = true;
            this.del.Width = 30;
            // 
            // upd
            // 
            this.upd.HeaderText = "";
            this.upd.Image = global::ItauTrade.Properties.Resources.upd;
            this.upd.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.upd.Name = "upd";
            this.upd.ReadOnly = true;
            this.upd.Width = 30;
            // 
            // dgvTrades
            // 
            this.dgvTrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DelTrade,
            this.UpdTrade});
            this.dgvTrades.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvTrades.Location = new System.Drawing.Point(53, 264);
            this.dgvTrades.MultiSelect = false;
            this.dgvTrades.Name = "dgvTrades";
            this.dgvTrades.ReadOnly = true;
            this.dgvTrades.Size = new System.Drawing.Size(648, 148);
            this.dgvTrades.TabIndex = 4;
            this.dgvTrades.CancelRowEdit += new System.Windows.Forms.QuestionEventHandler(this.dgvTrades_CancelRowEdit);
            this.dgvTrades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrades_CellContentClick);
            this.dgvTrades.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrades_CellEndEdit);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trades";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "tradeCategories = ";
            // 
            // lblOutPut
            // 
            this.lblOutPut.AutoSize = true;
            this.lblOutPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutPut.Location = new System.Drawing.Point(149, 464);
            this.lblOutPut.Name = "lblOutPut";
            this.lblOutPut.Size = new System.Drawing.Size(54, 13);
            this.lblOutPut.TabIndex = 6;
            this.lblOutPut.Text = "[OutPut]";
            // 
            // btnInsertCategory
            // 
            this.btnInsertCategory.Location = new System.Drawing.Point(594, 8);
            this.btnInsertCategory.Name = "btnInsertCategory";
            this.btnInsertCategory.Size = new System.Drawing.Size(107, 24);
            this.btnInsertCategory.TabIndex = 8;
            this.btnInsertCategory.Text = "Insert Category";
            this.btnInsertCategory.UseVisualStyleBackColor = true;
            this.btnInsertCategory.Click += new System.EventHandler(this.btnInsertCategory_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::ItauTrade.Properties.Resources.del;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::ItauTrade.Properties.Resources.upd;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 30;
            // 
            // btnInsertTrade
            // 
            this.btnInsertTrade.Location = new System.Drawing.Point(594, 237);
            this.btnInsertTrade.Name = "btnInsertTrade";
            this.btnInsertTrade.Size = new System.Drawing.Size(107, 24);
            this.btnInsertTrade.TabIndex = 9;
            this.btnInsertTrade.Text = "Insert Trade";
            this.btnInsertTrade.UseVisualStyleBackColor = true;
            this.btnInsertTrade.Click += new System.EventHandler(this.btnInsertTrade_Click);
            // 
            // DelTrade
            // 
            this.DelTrade.HeaderText = "";
            this.DelTrade.Image = global::ItauTrade.Properties.Resources.del;
            this.DelTrade.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.DelTrade.Name = "DelTrade";
            this.DelTrade.ReadOnly = true;
            this.DelTrade.Width = 30;
            // 
            // UpdTrade
            // 
            this.UpdTrade.HeaderText = "";
            this.UpdTrade.Image = global::ItauTrade.Properties.Resources.upd;
            this.UpdTrade.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.UpdTrade.Name = "UpdTrade";
            this.UpdTrade.ReadOnly = true;
            this.UpdTrade.Width = 30;
            // 
            // frmItauTrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 513);
            this.Controls.Add(this.btnInsertTrade);
            this.Controls.Add(this.btnInsertCategory);
            this.Controls.Add(this.lblOutPut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTrades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCategory);
            this.Controls.Add(this.label1);
            this.Name = "frmItauTrades";
            this.Text = "Itau - Trades";
            this.Activated += new System.EventHandler(this.frmItauTrades_Activated);
            this.Load += new System.EventHandler(this.frmItauTrades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.DataGridView dgvTrades;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOutPut;
        private System.Windows.Forms.Button btnInsertCategory;
        private System.Windows.Forms.DataGridViewImageColumn del;
        private System.Windows.Forms.DataGridViewImageColumn upd;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Button btnInsertTrade;
        private System.Windows.Forms.DataGridViewImageColumn DelTrade;
        private System.Windows.Forms.DataGridViewImageColumn UpdTrade;
    }
}

