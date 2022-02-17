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
    public partial class ManagerForm : Form
    {
        private readonly model.FirmContext _Firm;
        public ManagerForm(model.FirmContext Firm)
        {
            _Firm = Firm;
            InitializeComponent();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            comboBoxProduct.Items.Clear();
            foreach (model.Product product in _Firm.Products)
            {
                comboBoxProduct.Items.Add(product);
            }
            textBoxCnt.Clear();
            comboBoxOff.Items.Clear();
            foreach(model.Manager manager in _Firm.Managers)
            {
                comboBoxOff.Items.Add(manager);
            }         
        }

        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectedIndex = comboBoxProduct.SelectedIndex;
            if (SelectedIndex == -1)//если ничего не выбрали
            {
                MessageBox.Show("Выберите товар");
                return;
            }

            model.Product product = comboBoxProduct.SelectedItem
                as model.Product;
            labelProductID.Text = product.Id.ToString();                     
        }

        private void textBoxCnt_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            try
            {
                cnt = Convert.ToInt32(textBoxCnt.Text);
            }
            catch
            {
                MessageBox.Show("Введите кол-во товара");
                return;
            }
            if(cnt <= 0)
            {
                MessageBox.Show("Кол-во должно быть больше нуля");
                return;
            }
            _Firm.Sales.Add(new model.Sale
            {
                Id = Guid.NewGuid(),
                Id_Manager = (comboBoxOff.SelectedItem as model.Manager).Id,
                Id_Product = (comboBoxProduct.SelectedItem as model.Product).Id,
                Cnt = cnt,
                Moment = DateTime.Now
            });
           
            _Firm.SaveChanges();
            MessageBox.Show("Added successfully");
            comboBoxProduct.SelectedIndex = -1;
            comboBoxOff.SelectedIndex = -1;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxOff_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectedIndex = comboBoxOff.SelectedIndex;
            if (SelectedIndex == -1)//если ничего не выбрали
            {
                MessageBox.Show("Выберите сотрудника");
                return;
            }

            model.Manager manager = comboBoxOff.SelectedItem
              as model.Manager;
            labelManagerID.Text = manager.Id.ToString();
        }

       
    }
}
