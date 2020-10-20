using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Respaldar_y_restaurar_partidas_de_juegos_flash
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void lang_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lang;
            switch (lang_comboBox.SelectedIndex)
            {
                case 0:
                    lang = "es";
                    break;
                case 1:
                    lang = "en";
                    break;
                default:
                    lang = "es";
                    break;
            }
            Properties.Settings.Default.lang = lang;
            Properties.Settings.Default.Save();
            if (!System.Threading.Thread.CurrentThread.CurrentUICulture.Name.StartsWith(lang))
                if (MessageBox.Show("To apply changes you have to restart the program\nRestart now?", "Please restart", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    Application.Restart();

        }
    }
}
