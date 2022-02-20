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
    public partial class EditedDepartment : Form
    {
        public model.Department EditDepartment { get; set; }
        private readonly model.FirmContext _firm; 
        public EditedDepartment(model.FirmContext firm)
        {
            _firm = firm;
            InitializeComponent();
        }

        private void EditedDepartment_Load(object sender, EventArgs e)
        {
            labelID.Text = EditDepartment.Id.ToString();
            labelName.Text = EditDepartment.Name;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            EditDepartment.Name = Nametxt.Text;
            String name = Nametxt.Text;
            if (name.Equals(String.Empty))
            {
                MessageBox.Show("Enter the name: ");
                return;
            }

            var nameExists = _firm.Departments.FirstOrDefault(p => p.Name == EditDepartment.Name);

            if (nameExists != null)
            {
                MessageBox.Show("Такой отдел уже есть");
                return;
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
