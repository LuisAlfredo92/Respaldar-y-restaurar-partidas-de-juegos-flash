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
            this.dir_textBox.AllowDrop = true;
            this.dir_textBox.Location = new System.Drawing.Point(65, 50);
            this.dir_textBox.Name = "dir_textBox";
            this.dir_textBox.ReadOnly = true;
            this.dir_textBox.Size = new System.Drawing.Size(235, 20);
            this.dir_textBox.TabIndex = 1;
            // 
            // examin_btn
            // 
            this.examin_btn.Location = new System.Drawing.Point(320, 47);
            this.examin_btn.Name = "examin_btn";
            this.examin_btn.Size = new System.Drawing.Size(75, 25);
            this.examin_btn.TabIndex = 0;
            this.examin_btn.Text = "Examinar";
            this.examin_btn.UseMnemonic = false;
            this.examin_btn.UseVisualStyleBackColor = true;
            this.examin_btn.Click += new System.EventHandler(this.examin_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(100, 100);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 2;
            this.save_btn.Text = "Respaldar";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // load_btn
            // 
            this.load_btn.Location = new System.Drawing.Point(200, 100);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(75, 23);
            this.load_btn.TabIndex = 3;
            this.load_btn.Text = "Restaurar";
            this.load_btn.UseVisualStyleBackColor = true;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // icon
            // 
            this.icon.Image = global::Respaldar_y_restaurar_partidas_de_juegos_flash.Properties.Resources.Folder;
            this.icon.Location = new System.Drawing.Point(40, 50);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(20, 20);
            this.icon.TabIndex = 4;
            this.icon.TabStop = false;
            // 
            // browserDialog
            // 
            this.browserDialog.Description = "Selecciona la carpeta donde se creará el respaldo o de donde se cargará el mismo";
            // 
            // combine_checkBox
            // 
            this.combine_checkBox.AutoSize = true;
            this.combine_checkBox.Checked = true;
            this.combine_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.combine_checkBox.Location = new System.Drawing.Point(298, 83);
            this.combine_checkBox.Name = "combine_checkBox";
            this.combine_checkBox.Size = new System.Drawing.Size(114, 17);
            this.combine_checkBox.TabIndex = 5;
            this.combine_checkBox.Text = "Combinar carpetas";
            this.combine_checkBox.UseVisualStyleBackColor = true;
            // 
            // overwrite_chechBox
            // 
            this.overwrite_chechBox.AutoSize = true;
            this.overwrite_chechBox.Checked = true;
            this.overwrite_chechBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.overwrite_chechBox.Location = new System.Drawing.Point(298, 106);
            this.overwrite_chechBox.Name = "overwrite_chechBox";
            this.overwrite_chechBox.Size = new System.Drawing.Size(130, 17);
            this.overwrite_chechBox.TabIndex = 6;
            this.overwrite_chechBox.Text = "Sobreescribir archivos";
            this.overwrite_chechBox.UseVisualStyleBackColor = true;
            // 
            // information_btn
            // 
            this.information_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.information_btn.Image = global::Respaldar_y_restaurar_partidas_de_juegos_flash.Properties.Resources.Information;
            this.information_btn.Location = new System.Drawing.Point(0, 128);
            this.information_btn.Name = "information_btn";
            this.information_btn.Size = new System.Drawing.Size(32, 32);
            this.information_btn.TabIndex = 7;
            this.information_btn.TabStop = false;
            this.information_btn.Click += new System.EventHandler(this.information_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 161);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Respaldar y restaurar partidas de juegos flash";
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

