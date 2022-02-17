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
    public partial class AddManForm : Form
    {
        private readonly model.FirmContext _Firm;
        public AddManForm(model.FirmContext Firm)
        {
            _Firm = Firm;
            InitializeComponent();
        }
       
        private void AddManForm_Load(object sender, EventArgs e)
        {
            if (_Firm == null)
                throw new ArgumentNullException("_Firm is null");
        }
        private void add_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String surname = textBox2.Text;
            String secname = textBox3.Text;
            if (name.Equals(String.Empty))
            {
                MessageBox.Show("Enter the name: ");
                return;
            } 
            if (surname.Equals(String.Empty))
            {
                MessageBox.Show("Enter the surname: ");
                return;
            }
            if (secname.Equals(String.Empty))
            {
                MessageBox.Show("Enter the secname: ");
                return;
            }

            _Firm.Managers.Add(
                new model.Manager
                {
                    Name = name,
                    Surname = surname,
                    SecName = secname
                });
            _Firm.SaveChanges();
            MessageBox.Show("Added successfully");
        }

    }
}
