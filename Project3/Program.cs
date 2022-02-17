using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Practices.Unity;

namespace Project3
{
    static class Program
    {
        public static UnityContainer Container;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Container = new UnityContainer();
            Container.RegisterType<model.FirmContext>();
            var random = new Random();
            Container.RegisterInstance<Random>(random);
               var form1 = Container.Resolve<Form1>();

            Application.Run(form1);
        }
    }
}
