using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Practices.Unity;
using Microsoft.Extensions.Configuration;

namespace Ado
{
    static class Program
    {

        public static UnityContainer DiContainer;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DiContainer = new UnityContainer();
            DiContainer.RegisterInstance(
                typeof(IConfiguration),
                new ConfigurationBuilder()
                .AddJsonFile(@"D:\ADO.NET\Ado\appsettings.json").Build()
                );
            DiContainer.RegisterType(typeof(AppContext));
         
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }
    }
}
