using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItauTrade
{
    public partial class frmItauTrades : Form
    {
        public frmItauTrades()
        {
            InitializeComponent();
        }

        public static List<Category> categories = new List<Category>();
        public static List<Trade> trades = new List<Trade>();

        private void frmItauTrades_Load(object sender, EventArgs e)
        {
            #region Categories
            Category cat = new Category
            {
                ID = 1,
                Name = "LOWRISK",
                Operator = OperatorType.LessThan,
                BaseValue = 1000000,
                Sector = SectorType.Public
            };
            categories.Add(cat);

            cat = new Category
            {
                ID = 2,
                Name = "MEDIUMRISK",
                Operator = OperatorType.GratherThan,
                BaseValue = 1000000,
                Sector = SectorType.Public
            };
            categories.Add(cat);

            cat = new Category
            {
                ID = 3,
                Name = "HIGHRISK",
                Operator = OperatorType.GratherThan,
                BaseValue = 1000000,
                Sector = SectorType.Private
            };
            categories.Add(cat);

            dgvCategory.DataSource = categories;
            #endregion

            #region Trades
            Trade trade = new Trade
            {
                Value = 20000000,
                ClientSector = SectorType.Private
            };
            trades.Add(trade);

            trade = new Trade
            {
                Value = 400000,
                ClientSector = SectorType.Public
            };
            trades.Add(trade);

            trade = new Trade
            {
                Value = 500000,
                ClientSector = SectorType.Public
            };
            trades.Add(trade);

            trade = new Trade
            {
                Value = 3000000,
                ClientSector = SectorType.Public
            };
            trades.Add(trade);

            dgvTrades.DataSource = trades;
            #endregion

            UpdateOutPUt();
        }

        private void UpdateOutPUt()
        {
            dgvCategory.DataSource = null;
            dgvCategory.DataSource = categories;

            dgvTrades.DataSource = null;
            dgvTrades.DataSource = trades;
            
            lblOutPut.Text = "";

            foreach (Trade tr in trades)
            {
                foreach (Category cat in categories)
                {
                    if (tr.ClientSector == cat.Sector || cat.Sector == SectorType.Any)
                    {
                        switch (cat.Operator)
                        {
                            case OperatorType.EqualTo:
                                if (tr.Value == cat.BaseValue)
                                lblOutPut.Text += " " + cat.Name;
                            break;

                            case OperatorType.GratherEqualTo:
                                if (tr.Value >= cat.BaseValue)
                                lblOutPut.Text += " " + cat.Name;
                            break;

                            case OperatorType.GratherThan:
                                if (tr.Value > cat.BaseValue)
                                lblOutPut.Text += " " + cat.Name;
                            break;

                            case OperatorType.LessEqualTo:
                                if (tr.Value <= cat.BaseValue)
                                lblOutPut.Text += " " + cat.Name;
                            break;

                            case OperatorType.LessThan:
                                if (tr.Value < cat.BaseValue)
                                lblOutPut.Text += " " + cat.Name;
                            break;
                        }
                    }
                }
            }
        }

        private void dgvTrades_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvTrades_CancelRowEdit(object sender, QuestionEventArgs e)
        {

        }

        private void btnInsertCategory_Click(object sender, EventArgs e)
        {
            frmNewCategory frm = new frmNewCategory();
            frm.ShowDialog();
        }

        private void frmItauTrades_Activated(object sender, EventArgs e)
        {
            UpdateOutPUt();
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                dgvCategory.DataSource = null;
                categories.RemoveAt(e.RowIndex);
                dgvCategory.DataSource = categories;
                UpdateOutPUt();
            }
            else if (e.ColumnIndex == 1)
            {
                frmNewCategory frm = new frmNewCategory(Convert.ToInt32(dgvCategory[2, e.RowIndex].Value));
                frm.ShowDialog();
            }
        }

        private void btnInsertTrade_Click(object sender, EventArgs e)
        {
            frmNewTrade frm = new frmNewTrade();
            frm.ShowDialog();
        }

        private void dgvTrades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                dgvTrades.DataSource = null;
                trades.RemoveAt(e.RowIndex);
                dgvTrades.DataSource = trades;
                UpdateOutPUt();
            }
            else if (e.ColumnIndex == 1)
            {
                frmNewTrade frm = new frmNewTrade(Convert.ToDouble(dgvTrades[2, e.RowIndex].Value), (SectorType)Enum.Parse(typeof(SectorType), dgvTrades[3, e.RowIndex].Value.ToString(), true));
                frm.ShowDialog();
            }
        }
    }
}
