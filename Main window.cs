using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Respaldar_y_restaurar_partidas_de_juegos_flash
{
    public partial class Form1 : Form
    {
        // This variable contains the route to %APPDATA%\Macromedia\Flash Player, where the saved games are stored
        string path;
        // This variable contains the route to the folder where the backup of the saved games will be stored
        string new_path;

        public Form1()
        {
            InitializeComponent();
            path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Macromedia";
            equalize_values(Properties.Settings.Default.new_path);
        }

        // This method is used to equalize all the values that store the new path for the files
        private void equalize_values(string value)
        {
            dir_textBox.Text = value;
            new_path = value;
            Properties.Settings.Default.new_path = value;
            Properties.Settings.Default.Save();
        }

        // This method is the base of the program, this to copy all the files of the Flash player folder to a
        // new one in the specified route
        private void copy_files(string path, string new_path)
        {
            if (!(this.new_path.Length == 0))
            {
                if (Directory.Exists(path + "\\Flash Player"))
                {
                    ArrayList directories = new ArrayList();
                    directories.Add(path + "\\Flash Player");

                    for (int i = 0; i < directories.Count; i++)
                        directories.AddRange(Directory.GetDirectories(directories[i].ToString()));
                    try
                    {
                        if (!combine_checkBox.Checked && Directory.Exists(new_path + "\\Flash Player"))
                        {
                            Directory.Delete(new_path + "\\Flash Player", true);
                            Directory.CreateDirectory(new_path + "\\Flash Player");
                        }
                        else if (!Directory.Exists(new_path + "\\Flash Player"))
                            Directory.CreateDirectory(new_path + "\\Flash Player");
                        foreach (string folder in directories)
                        {
                            Directory.CreateDirectory(folder.Replace(path, new_path));
                            foreach (string file in Directory.GetFiles(folder))
                                if (!(File.Exists(file.Replace(path, new_path)) && !overwrite_chechBox.Checked))
                                    File.Copy(file, file.Replace(path, new_path), true);
                        }
                    }
                    catch (UnauthorizedAccessException e)
                    {
                        MessageBox.Show(Properties.Resources.UnauthorizedAccess + "\n" + e.Message, Properties.Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                    catch (PathTooLongException e)
                    {
                        MessageBox.Show(Properties.Resources.PathTooLong + "\n" + e.Message, Properties.Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                    catch (DirectoryNotFoundException e)
                    {
                        MessageBox.Show(Properties.Resources.DirectoryNotFound + "\n" + e.Message, Properties.Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                    catch (IOException e)
                    {
                        MessageBox.Show(Properties.Resources.GeneralError + "\n" + e.Message, Properties.Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }

                }
                else
                    MessageBox.Show(Properties.Resources.NoSavedFiles, Properties.Resources.NoSavedFilesTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show(Properties.Resources.SelectARoute, Properties.Resources.EmptyRoute, MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void examin_btn_Click(object sender, EventArgs e)
        {
            browserDialog.ShowDialog();
            equalize_values(browserDialog.SelectedPath);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            copy_files(path, new_path);
        }


        private void load_btn_Click(object sender, EventArgs e)
        {
            copy_files(new_path, path);
        }

        private void information_btn_Click(object sender, EventArgs e)
        {
            Information info = new Information();
            info.Show();
        }
    }
}
