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

namespace Project3
{
    public partial class Form1 : Form
    {
        private model.FirmContext Firm;
        public Form1()
        {
            InitializeComponent();
            Firm = new model.FirmContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Firm.Departments.Count().ToString());
            MessageBox.Show(Firm.Managers.Count().ToString());
            // AddDepartments();
            //FirmContext firm = new FirmContext();
            //firm.AddManagers();
        }     


        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (var dep in
            Firm.Departments.OrderBy(d => Name))
            {
                listBox1.Items.Add(dep.Id + "\t " + dep.Name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (var man in
            Firm.Managers.OrderBy(a => Name))
            {
                listBox1.Items.Add(man.Id + "\t " + man.Name + " " + man.Surname + " " +  man.SecName + " " + man.Id_main_dep + "\t " + man.Id_sec_dep + "\t " + man.Id_chief);
            }
        }
    }
}
