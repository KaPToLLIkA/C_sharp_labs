using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAB5_SERVICE_UI.SpellService1;

namespace LAB5_SERVICE_UI
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

            SpellServiceSoapClient client = new SpellServiceSoapClient();
            SpellError[] err = client.checkText("", "ru", 0, "plain");




            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
