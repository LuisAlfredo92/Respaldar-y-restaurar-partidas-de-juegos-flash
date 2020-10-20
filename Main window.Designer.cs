namespace Respaldar_y_restaurar_partidas_de_juegos_flash
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dir_textBox = new System.Windows.Forms.TextBox();
            this.examin_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.load_btn = new System.Windows.Forms.Button();
            this.icon = new System.Windows.Forms.PictureBox();
            this.browserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.combine_checkBox = new System.Windows.Forms.CheckBox();
            this.overwrite_chechBox = new System.Windows.Forms.CheckBox();
            this.information_btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.information_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // dir_textBox
            // 
            resources.ApplyResources(this.dir_textBox, "dir_textBox");
            this.dir_textBox.AllowDrop = true;
            this.dir_textBox.Name = "dir_textBox";
            this.dir_textBox.ReadOnly = true;
            // 
            // examin_btn
            // 
            resources.ApplyResources(this.examin_btn, "examin_btn");
            this.examin_btn.Name = "examin_btn";
            this.examin_btn.UseMnemonic = false;
            this.examin_btn.UseVisualStyleBackColor = true;
            this.examin_btn.Click += new System.EventHandler(this.examin_btn_Click);
            // 
            // save_btn
            // 
            resources.ApplyResources(this.save_btn, "save_btn");
            this.save_btn.Name = "save_btn";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // load_btn
            // 
            resources.ApplyResources(this.load_btn, "load_btn");
            this.load_btn.Name = "load_btn";
            this.load_btn.UseVisualStyleBackColor = true;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // icon
            // 
            resources.ApplyResources(this.icon, "icon");
            this.icon.Image = global::Respaldar_y_restaurar_partidas_de_juegos_flash.Properties.Resources.Folder;
            this.icon.Name = "icon";
            this.icon.TabStop = false;
            // 
            // browserDialog
            // 
            resources.ApplyResources(this.browserDialog, "browserDialog");
            // 
            // combine_checkBox
            // 
            resources.ApplyResources(this.combine_checkBox, "combine_checkBox");
            this.combine_checkBox.Checked = true;
            this.combine_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.combine_checkBox.Name = "combine_checkBox";
            this.combine_checkBox.UseVisualStyleBackColor = true;
            // 
            // overwrite_chechBox
            // 
            resources.ApplyResources(this.overwrite_chechBox, "overwrite_chechBox");
            this.overwrite_chechBox.Checked = true;
            this.overwrite_chechBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.overwrite_chechBox.Name = "overwrite_chechBox";
            this.overwrite_chechBox.UseVisualStyleBackColor = true;
            // 
            // information_btn
            // 
            resources.ApplyResources(this.information_btn, "information_btn");
            this.information_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.information_btn.Image = global::Respaldar_y_restaurar_partidas_de_juegos_flash.Properties.Resources.Information;
            this.information_btn.Name = "information_btn";
            this.information_btn.TabStop = false;
            this.information_btn.Click += new System.EventHandler(this.information_btn_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.information_btn);
            this.Controls.Add(this.overwrite_chechBox);
            this.Controls.Add(this.combine_checkBox);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.examin_btn);
            this.Controls.Add(this.dir_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.information_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dir_textBox;
        private System.Windows.Forms.Button examin_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.FolderBrowserDialog browserDialog;
        private System.Windows.Forms.CheckBox combine_checkBox;
        private System.Windows.Forms.CheckBox overwrite_chechBox;
        private System.Windows.Forms.PictureBox information_btn;
    }
}

