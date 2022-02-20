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
    public partial class EditedProductForms : Form
    {
        public model.Product EditedProduct { get; set; }
        private readonly model.FirmContext _firm;
        public EditedProductForms(model.FirmContext firm)
        {
            _firm = firm;
            InitializeComponent();
        }

        private void ProForms_Load(object sender, EventArgs e)
        {
            labelID.Text = EditedProduct.Id.ToString();
            labelName.Text = EditedProduct.Name;
            labelPrice.Text = EditedProduct.Price.ToString();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            EditedProduct.Name = Name_txt.Text;

            String name = Name_txt.Text;
            if (name.Equals(String.Empty))
            {
                MessageBox.Show("Enter the name: ");
                return;
            }

            if (price_txt.Text == string.Empty)
            {
                MessageBox.Show("Имя пустое");
                return;
            }

            var nameExists = _firm.Products.FirstOrDefault(p => p.Name == EditedProduct.Name);

            if (nameExists != null)
            {
                MessageBox.Show("Такой товар уже есть");
                return;
            }
            try
            {             
                EditedProduct.Price = Convert.ToDouble(price_txt.Text);
                this.DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {               
                MessageBox.Show(ex.Message);
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
