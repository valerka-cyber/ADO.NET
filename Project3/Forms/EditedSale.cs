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
    public partial class EditedSale : Form
    {
        public model.Sale EditSale { get; set; }
        private readonly model.FirmContext _firm;
        public EditedSale(model.FirmContext firm)
        {
            _firm = firm;
            InitializeComponent();
        }

        private void EditedSale_Load(object sender, EventArgs e)
        {
            labelID.Text = EditSale.Id.ToString();
          
            if (_firm == null)
                throw new ArgumentNullException("_Firm is null");

            CBManagers.Items.Clear();
            foreach (var item in
               _firm.Sales
               .Join(_firm.Managers, s => s.Id_Manager, m => m.Id,
               (Sale, Manager) => new { Sale, Manager }))
            {
                CBManagers.Items.Add(item.Manager.Name + item.Manager.Surname);
            }

            CBProduct.Items.Clear();
            foreach (var item in
              _firm.Sales
              .Join(_firm.Products, s => s.Id_Product, p => p.Id,
              (Sale, Product) => new { Sale, Product }))
            {
                CBProduct.Items.Add(item.Product.Name);
            }

            TBCnt.Clear();
            
        }

        private void CBManagers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectedIndex = CBManagers.SelectedIndex;
            if (SelectedIndex == -1)//если ничего не выбрали
            {
                MessageBox.Show("Выберите менеджера");
                return;
            }
            model.Sale sale = CBManagers.SelectedItem
                as model.Sale;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (TBCnt.Text == string.Empty)
            {
                MessageBox.Show("Кол-во пустое");
                return;
            }
             try
            {             
                EditSale.Cnt = Convert.ToInt32(TBCnt.Text);
                this.DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {               
                MessageBox.Show(ex.Message);
            }

            DialogResult = DialogResult.OK;
            Close();
            
            _firm.Sales.Add(
               new model.Sale
               {
                 Id_Manager = (CBManagers.SelectedItem as model.Sale).Id_Manager,
                 Id_Product = (CBProduct.SelectedItem as model.Sale).Id_Product                 
               });
           _firm.SaveChanges();

        }

        private void CBProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectedIndex = CBProduct.SelectedIndex;
            if (SelectedIndex == -1)//если ничего не выбрали
            {
                MessageBox.Show("Выберите продукт");
                return;
            }
            model.Sale sale = CBProduct.SelectedItem
                as model.Sale;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
