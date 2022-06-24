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
    public partial class frmNewCategory : Form
    {
        private Category cat;

        public frmNewCategory()
        {
            InitializeComponent();
        }

        public frmNewCategory(int i)
        {
            InitializeComponent();

            cat = frmItauTrades.categories.First(x => x.ID == i);

            txtName.Text = cat.Name;
            txtBaseValue.Text = cat.BaseValue.ToString();
        }

        private void frmNewCategory_Load(object sender, EventArgs e)
        {
            cmbOperator.Items.Add("Select...");
            cmbOperator.Items.Add(OperatorType.EqualTo);
            cmbOperator.Items.Add(OperatorType.GratherEqualTo);
            cmbOperator.Items.Add(OperatorType.GratherThan);
            cmbOperator.Items.Add(OperatorType.LessEqualTo);
            cmbOperator.Items.Add(OperatorType.LessThan);
            cmbOperator.SelectedIndex = 0;

            cmbSector.Items.Add("Select...");
            cmbSector.Items.Add(SectorType.Public);
            cmbSector.Items.Add(SectorType.Private);
            cmbSector.Items.Add(SectorType.Any);
            cmbSector.SelectedIndex = 0;

            if (cat != null)
            {
                cmbOperator.SelectedItem = cat.Operator;
                cmbSector.SelectedItem = cat.Sector;
                this.Text = "Update Category";
                btnCreate.Text = "Update";
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cat == null)
            {
                frmItauTrades.categories.Add(
                    new Category
                    {
                        ID = (frmItauTrades.categories.Count == 0 ? 0 : frmItauTrades.categories.Max(x => x.ID) + 1),
                        Name = txtName.Text,
                        Operator = (OperatorType)Enum.Parse(typeof(OperatorType), cmbOperator.Text, true),
                        BaseValue = Convert.ToDouble(txtBaseValue.Text),
                        Sector = (SectorType)Enum.Parse(typeof(SectorType), cmbSector.Text, true)
                    }
                    );
            }
            else
            {
                foreach (Category tmpCat in frmItauTrades.categories.Where(x => x.ID == cat.ID))
                {
                    tmpCat.ID = cat.ID;
                    tmpCat.Name = txtName.Text;
                    tmpCat.Operator = (OperatorType)Enum.Parse(typeof(OperatorType), cmbOperator.Text, true);
                    tmpCat.BaseValue = Convert.ToDouble(txtBaseValue.Text);
                    tmpCat.Sector = (SectorType)Enum.Parse(typeof(SectorType), cmbSector.Text, true);
                }
                
            }

            Close();
        }

        private void txtBaseValue_KeyPress(object sender, KeyPressEventArgs e)
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
