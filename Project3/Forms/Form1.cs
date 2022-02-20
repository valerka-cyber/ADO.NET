using Project3.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Practices.Unity;
using System.Data.Entity;

namespace Project3
{
    public partial class Form1 : Form
    {
        [Dependency] public model.FirmContext Firm { get; set; }
        //private Random random = new Random();
        [Dependency] public Random random { get; set; }
        public Form1()
        {
            InitializeComponent();
           // Firm = new model.FirmContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            grou_dep.Text = Firm.Departments.Count().ToString();
            grou_man.Text = Firm.Managers.Count().ToString();
            grou_prod.Text = Firm.Products.Count().ToString();
            grou_sale.Text = Firm.Sales.Count().ToString();

        }     


        private void Button1_Click(object sender, EventArgs e)
        {
            //departmen
            listBox1.Items.Clear();

            foreach (var dep in
                Firm.Departments.OrderBy(d => d.Name))
            {
                listBox1.Items.Add(dep);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //manager
            listBox1.Items.Clear();

            foreach (var man in
                     Firm.Managers.OrderBy(d => d.Name))
            {
                listBox1.Items.Add(man);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //product
            var query = Firm.Products
              .Where(p => p.Price > 0)
              .OrderByDescending(p => p.Price);

            listBox1.Items.Clear();
            foreach (model.Product p in query)
            {
                listBox1.Items.Add(p);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            #region Генерация и обновления статистики
            //Count:
            int n = 0;
            try {
                n = Convert.ToInt32(genCnt.Text);
            }
            catch
            {
                MessageBox.Show("Количество не распознано");
                return;
            }
            // Generation
            
            while (n>0)
            {
                Firm.Sales.Add(new model.Sale
                {
                    Id = Guid.NewGuid(),                                 //Случайная выборка - вар. 1
                    Id_Manager = Firm.Managers                    //Упорядочиваем по Id (можно любое поле)
                        .OrderBy(m=>m.Id)                                 //Пропускаем первые элементы результата
                        .Skip(random.                                        //ы количестве - случайное число
                        Next(Firm.Managers.Count()))               //в пределах размера исходной кололекции
                        .First()                                                     //выбираем первый элемент (после отступа)  
                        .Id,                                                          // Берем из него Id


                    Id_Product = Firm.Products                                         //Случайная выборка - вар.2
                        .OrderBy                                                                    //Используем тот факт, что запрос будет переведен
                        (p => Guid.NewGuid())                                               //здесь получится order by newid - вся таблица сортируется в случайном порядке
                        .First()                                                                        //выбирается первый элемент (из всей результат)
                        .Id,                                                                            //берем из него ид
                    Cnt = random.Next(10) + 1,                                             
                    Moment = DateTime.Parse($"2021-01-01")
                                .AddSeconds(random.Next(60*60*24*365))
                });
                --n;
            }
            Firm.SaveChanges();

            //Displaying
            grou_sale.Text = Firm.Sales.Count().ToString();
            #endregion
            button4.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (var sal in
                     Firm.Sales.OrderBy(d => d.Cnt))
            {
                listBox1.Items.Add(sal);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(var item in
            Firm.Sales
                .Join(Firm.Managers, s=> s.Id_Manager, m=>m.Id, 
                (Sale, Manager) => new { Sale,Manager})
                .Join(Firm.Products, SM=> SM.Sale.Id_Product, p=>p.Id,
                (SM,Product) => new { SM.Sale, SM.Manager,Product}))
            {
                listBox1.Items.Add(item.Sale.Moment.ToShortDateString()
                    + " " + item.Manager.Surname
                    + " " + item.Manager.Name.Substring(0, 1) + "."
                    + " " + item.Manager.SecName.Substring(0, 1) + ".");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //new qery
            //соединить продажи с другими данными, вывести 
           // дата - сотрудник - товар - кол - во(сумма)
            listBox1.Items.Clear();
            foreach(var item in 
                Firm.Sales
                .Join(Firm.Managers, s => s.Id_Manager, m=>m.Id,
                (Sale,Manager) => new { Sale, Manager})
                .Join(Firm.Products, SM => SM.Sale.Id_Product, p => p.Id,
                (SM, Product) => new { SM.Sale, SM.Manager, Product }))
            {
                listBox1.Items.Add(item.Sale.Moment.ToShortDateString()
                  + " " + item.Manager.Surname
                  + " " + item.Manager.Name.Substring(0, 1) + "."
                  + " " + item.Manager.SecName.Substring(0, 1) + ".\t"
                  + " " + item.Product.Name + "\t"
                  + " " + item.Sale.Cnt * item.Product.Price + "UAH"
                  );
            }

        }

        private void Form2_Click(object sender, EventArgs e)
        {
            // new Form2().ShowDialog(this);
            Program.Container.Resolve<Form2>()
                .ShowDialog(this);
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
     
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in
                Firm.Sales.Where(
                    s => DbFunctions.TruncateTime(s.Moment)
               == dateTimePicker1.Value.Date)
              
                )
            {
                listBox1.Items.Add(item.Moment + "  " + item.Cnt);
            }
        }

        private void add_product_Click(object sender, EventArgs e)
        {
            Program.Container.Resolve<Forms.Form3>()
             .ShowDialog(this);
            grou_prod.Text = Firm.Products.Count().ToString();
        }

        private void add_dep_Click(object sender, EventArgs e)
        {
            Program.Container.Resolve<Forms.AddDepForm>()
           .ShowDialog(this);
            grou_dep.Text = Firm.Departments.Count().ToString();
        }

        private void add_managers_Click(object sender, EventArgs e)
        {
            Program.Container.Resolve<Forms.AddManForm>()
          .ShowDialog(this);
            grou_man.Text = Firm.Managers.Count().ToString();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button_sale_Click(object sender, EventArgs e)
        {
            Program.Container.Resolve<Forms.SaleForm>()
          .ShowDialog(this);     
            grou_sale.Text = Firm.Sales.Count().ToString();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Program.Container.Resolve<Forms.ManagerForm>()
          .ShowDialog(this);
            grou_man.Text = Firm.Managers.Count().ToString();
        }

      

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex == -1) return;

            if(listBox1.SelectedItem is model.Product)
            {
                Forms.EditedProductForms editedProductForm =
                    Program.Container.Resolve<Forms.EditedProductForms>();
                editedProductForm.EditedProduct =
                listBox1.SelectedItem as model.Product;

                editedProductForm.ShowDialog(this);
                //String str = editedProductForm.EditedProduct.ToString()
                //        + "  " + Firm.Products.Find(
                //          editedProductForm.EditedProduct.Id).ToString();

                if (editedProductForm.DialogResult == DialogResult.OK)
                {
                    Firm.SaveChanges();
                    MessageBox.Show("Изменения внесены");
                }
                else
                {
                    MessageBox.Show("Изменения отменены");
                }

            }
           else if (listBox1.SelectedItem is model.Department)
            {
                Forms.EditedDepartment editedDepartmen =
                    Program.Container.Resolve<Forms.EditedDepartment>();
                editedDepartmen.EditDepartment =
                listBox1.SelectedItem as model.Department;

                editedDepartmen.ShowDialog(this);            

                if (editedDepartmen.DialogResult == DialogResult.OK)
                {
                    Firm.SaveChanges();
                    MessageBox.Show("Изменения внесены");
                }
                else
                {
                    MessageBox.Show("Изменения отменены");
                }
            }

            else if (listBox1.SelectedItem is model.Manager)
            {
                Forms.EditManager editedManager =
                    Program.Container.Resolve<Forms.EditManager>();
                editedManager.EditedManager =
                listBox1.SelectedItem as model.Manager;

                editedManager.ShowDialog(this);

                if (editedManager.DialogResult == DialogResult.OK)
                {
                    Firm.SaveChanges();
                    MessageBox.Show("Изменения внесены");
                }
                else
                {
                    MessageBox.Show("Изменения отменены");
                }
            }

            else if (listBox1.SelectedItem is model.Sale)
            {
                Forms.EditedSale editSale =
                    Program.Container.Resolve<Forms.EditedSale>();
                editSale.EditSale =
                listBox1.SelectedItem as model.Sale;

                editSale.ShowDialog(this);

                if (editSale.DialogResult == DialogResult.OK)
                {
                    Firm.SaveChanges();
                    MessageBox.Show("Изменения внесены");
                }
                else
                {
                    MessageBox.Show("Изменения отменены");
                }
            }
        }
    
    }
}
