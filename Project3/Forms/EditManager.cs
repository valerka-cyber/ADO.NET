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
    public partial class EditManager : Form
    {
        public model.Manager EditedManager { get; set; }
        private readonly model.FirmContext _firm;
        public EditManager(model.FirmContext firm)
        {
            _firm = firm;
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditManager_Load(object sender, EventArgs e)
        {
            labelID.Text = EditedManager.Id.ToString();
            labelName.Text = EditedManager.Name;
            labelSecName.Text = EditedManager.SecName;
            labelSurname.Text = EditedManager.Surname;
            //labelMainDep.Text = EditedManager.Id_main_dep.ToString();
          //  labelSecDep.Text = EditedManager.Id_sec_dep.ToString();
           // labelCheifDep.Text = EditedManager.Id_chief.ToString();
          
            if (_firm == null)
                throw new ArgumentNullException("_Firm is null");

           CBMain.Items.Clear();           
            foreach (var item in
               _firm.Departments
               .Join(_firm.Managers, d => d.Id, m => m.Id_main_dep,
               (Department, Manager) => new { Department, Manager }))
            {
                CBMain.Items.Add(item.Department.Name).ToString();
            }

            CBSec.Items.Clear();
            foreach(var item in
                _firm.Departments
                .Join(_firm.Managers, d => d.Id, m => m.Id_sec_dep,
               (Department, Manager) => new { Department, Manager }))
            {
                CBSec.Items.Add(item.Department.Name).ToString();
            }

            CBCheif.Items.Clear();
            foreach (var item in
               _firm.Managers
               .Join(_firm.Managers, m=> m.Id_chief, cheif => cheif.Id,
              (Department, Manager) => new { Department, Manager })              
               )
            {
                CBCheif.Items.Add(item.Manager.Name + item.Manager.Surname + item.Manager.SecName).ToString();
            }

        }

        private void Save_Click(object sender, EventArgs e)
        {
            EditedManager.Name = Nametxt.Text;
            String name = Nametxt.Text;
            if (name.Equals(String.Empty))
            {
                MessageBox.Show("Enter the name: ");
                return;
            }

            var nameExists = _firm.Departments.FirstOrDefault(p => p.Name == EditedManager.Name);

            if (nameExists != null)
            {
                MessageBox.Show("Такой отдел уже есть");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();

            String secname = Secnametxt.Text;
            if (secname.Equals(String.Empty))
            {
                MessageBox.Show("Enter the Secname: ");
                return;
            }
            String surname = Surnametxt.Text;
            if (surname.Equals(String.Empty))
            {
                MessageBox.Show("Enter the surname: ");
                return;
            }
            _firm.Managers.Add(
                new model.Manager
                {
                    Name = name,
                    Surname = surname,
                    SecName = secname,
                    Id_main_dep = (CBMain.SelectedItem as model.Manager).Id_main_dep,
                    Id_sec_dep = (CBSec.SelectedItem as model.Manager).Id_sec_dep,
                    Id_chief = (CBCheif.SelectedItem as model.Manager).Id_chief
                });
            _firm.SaveChanges();

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void labelSecDep_Click(object sender, EventArgs e)
        {

        }

        private void labelMainDep_Click(object sender, EventArgs e)
        {

        }

        private void CBMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectedIndex = CBMain.SelectedIndex;
            if (SelectedIndex == -1)//если ничего не выбрали
            {
                return;
            }
            model.Manager manager = CBMain.SelectedItem
                as model.Manager;
        }

        private void CBSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectedIndex = CBSec.SelectedIndex;
            if (SelectedIndex == -1)//если ничего не выбрали
            {
                return;
            }
            model.Manager manager = CBSec.SelectedItem
                as model.Manager;
        }

        private void CBCheif_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectedIndex = CBCheif.SelectedIndex;
            if (SelectedIndex == -1)//если ничего не выбрали
            {
                return;
            }
            model.Manager manager = CBCheif.SelectedItem
                as model.Manager;
        }
    }
}
