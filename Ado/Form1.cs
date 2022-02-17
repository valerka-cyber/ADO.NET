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

namespace Ado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            model.Firm firm = Program.DiContainer.Resolve<model.Firm>();
            var query = from d in firm.Departments
                        join m in firm.Managers
                        on d.Id equals m.Id_main_dep
                        where m.SurName.Contains('а')
                                || m.SurName.Contains('А')
                        orderby m.SurName
                        select new model.ManDep { Departmen = d, Manager = m };

            //var list = query.ToList();

            foreach (model.ManDep obj in query)
            {
                listBox1.Items.Add(
                    obj.Manager.SurName + "  "
                    + obj.Departmen.Name);
            }
            //* Реализовать в виде кнопок, нажатие на которые
            //* обновляет listBox
            //*/
            //MessageBox.Show("Dep / Man:" + query.Count());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
          //  Написать LINQ выражения для выборки данных:
            // *Отделы по алфавиту названий(по убыванию)
              model.Firm firm = Program.DiContainer.Resolve<model.Firm>();
            var query = from d in firm.Departments
                        orderby d.Name descending
                        select new model.ManDep
                        { Departmen = d };

            foreach (model.ManDep obj in query)
            {
                listBox1.Items.Add(
                     obj.Departmen.Name);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //    * Сотрудников бухгалтерии
            //    * а) основных
            // *Отделы по алфавиту названий(по убыванию)
            listBox1.Items.Clear();
            model.Firm firm = Program.DiContainer.Resolve<model.Firm>();
            var query = from d in firm.Departments
                        join m in firm.Managers
                        on d.Id equals m.Id_main_dep
                        where d.Name.Contains("Бухгалтерия")
                        orderby m.Name
                        select new model.ManDep
                        { Departmen = d, Manager = m };
            foreach (model.ManDep obj in query)
            {
                listBox1.Items.Add(
                     obj.Departmen.Name + " "
                     + obj.Manager.Name + " "
                     + obj.Manager.SurName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //   * б) всех
            listBox1.Items.Clear();
            model.Firm firm = Program.DiContainer.Resolve<model.Firm>();
            var query = from d in firm.Departments
                        join m in firm.Managers
                        on d.Id equals m.Id_main_dep
                        join m1 in firm.Managers
                        on d.Id equals m1.Id_sec_dep
                        where d.Name.Contains("Бухгалтерия")
                        orderby m.Name
                        select new model.ManDep
                        { Departmen = d, Manager = m };
            foreach (model.ManDep obj in query)
            {
                listBox1.Items.Add(
                     obj.Departmen.Name + " "
                     + obj.Manager.Name + " "
                     + obj.Manager.SurName);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            ////  * Строкового представления ФИО сотрудника -
            ////  *ФИО Шефа(не объект, а только строка)
            listBox1.Items.Clear();
            model.Firm firm = Program.DiContainer.Resolve<model.Firm>();
            var query = from d in firm.Departments
                        join m in firm.Managers
                        on d.Id equals m.Id_main_dep
                        join chief in firm.Managers
                        on m.Id_chief equals chief.Id
                        orderby m.Name
                        select m.Name + "  " + m.SurName + "   CHIEF: " + chief.Name +" " + chief.SurName;

            foreach (var obj in query)
            {
                listBox1.Items.Add(obj);
            }
        }
    }
}
