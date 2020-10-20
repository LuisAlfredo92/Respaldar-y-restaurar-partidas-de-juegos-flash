using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Respaldar_y_restaurar_partidas_de_juegos_flash
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CultureInfo cultureInfo = new CultureInfo(Properties.Settings.Default.lang);
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
