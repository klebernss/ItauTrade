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
    public partial class frmNewTrade : Form
    {
        private Trade trade;

        public frmNewTrade()
        {
            InitializeComponent();
        }

        public frmNewTrade(double val, SectorType sec)
        {
            InitializeComponent();
            trade = frmItauTrades.trades.First(x => x.Value == val && x.ClientSector == sec);
        }

        private void frmNewTrade_Load(object sender, EventArgs e)
        {
            cmbSector.Items.Add("Select...");
            cmbSector.Items.Add(SectorType.Public);
            cmbSector.Items.Add(SectorType.Private);
            cmbSector.SelectedIndex = 0;

            if (trade != null)
            {
                txtValue.Text = trade.Value.ToString();
                cmbSector.SelectedItem = trade.ClientSector;
                this.Text = "Update Trade";
                btnCreate.Text = "Update";
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (trade == null)
            {
                frmItauTrades.trades.Add(
                    new Trade
                    {
                        Value = Convert.ToDouble(txtValue.Text),
                        ClientSector = (SectorType)Enum.Parse(typeof(SectorType), cmbSector.Text, true)
                    }
                    );
            }
            else
            {
                foreach (Trade tmpTrade in frmItauTrades.trades.Where(x => x.Value == trade.Value && x.ClientSector == trade.ClientSector))
                {
                    tmpTrade.Value = Convert.ToDouble(txtValue.Text);
                    tmpTrade.ClientSector = (SectorType)Enum.Parse(typeof(SectorType), cmbSector.Text, true);
                }
                
            }

            Close();
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
