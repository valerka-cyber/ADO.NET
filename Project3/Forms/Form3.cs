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
  
    public partial class Form3 : Form
    { 
        private readonly model.FirmContext _Firm;
        public Form3(model.FirmContext Firm)
        {
            _Firm = Firm;

            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (_Firm == null)
                throw new ArgumentNullException("_Firm is null");
          }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            if (name.Equals(String.Empty))
            {
                MessageBox.Show("enter the name: ");
                return;
            }
            double price;
            try
            {
                price = Convert.ToDouble(textBox1
                    .Text.Replace(".",","));
            }
            catch
            {
                MessageBox.Show("No price");
                return;
            }
            _Firm.Products.Add(
                new model.Product
                {
                    Name = name,
                    Price = price
                });
            _Firm.SaveChanges();
            MessageBox.Show("Added successfully");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
