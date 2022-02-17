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
    public partial class AddDepForm : Form
    {
        private readonly model.FirmContext _Firm;
        public AddDepForm(model.FirmContext Firm)
        {
            _Firm = Firm;
            InitializeComponent();
        }       

        private void AddDepForm_Load(object sender, EventArgs e)
        {
            if (_Firm == null)
                throw new ArgumentNullException("_Firm is null");
        }
        
        private void add_name_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            if (name.Equals(String.Empty))
            {
                MessageBox.Show("Enter the name: ");
                return;
            }
          
            _Firm.Departments.Add(
                new model.Department
                {
                    Name = name                   
                });
            _Firm.SaveChanges();
            MessageBox.Show("Added successfully");
        }
    }
}
