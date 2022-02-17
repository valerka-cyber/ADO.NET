using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3.Forms
{
    public partial class SaleForm : Form
    {
        private readonly model.FirmContext _Firm;
        public SaleForm(model.FirmContext Firm)
        {
            _Firm = Firm;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            comboBoxProducts.Items.Clear();
            foreach(model.Product product in _Firm.Products)
            {
                comboBoxProducts.Items.Add(product);
            }
        }

        private void comboBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectedIndex = comboBoxProducts.SelectedIndex;
            if(SelectedIndex == -1)//если ничего не выбрали
            {
                return;
            }
            model.Product product = comboBoxProducts.SelectedItem
                as model.Product;
            labelProductID.Text = product.Id.ToString();
        }
    }
}
