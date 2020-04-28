namespace DBXML
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.bttn_save = new System.Windows.Forms.Button();
            this.bttn_load = new System.Windows.Forms.Button();
            this.bttn_clear = new System.Windows.Forms.Button();
            this.lbl_ide = new System.Windows.Forms.Label();
            this.txt_ide = new System.Windows.Forms.TextBox();
            this.txt_prog = new System.Windows.Forms.TextBox();
            this.lbl_sprache = new System.Windows.Forms.Label();
            this.lb_dbName = new System.Windows.Forms.Label();
            this.txt_dbName = new System.Windows.Forms.TextBox();
            this.lbl_pktXls = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(40, 55);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(312, 20);
            this.txt_name.TabIndex = 0;
            this.txt_name.Text = "Karl Mustermann";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(37, 39);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(38, 13);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name:";
            this.lbl_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // bttn_save
            // 
            this.bttn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_save.Location = new System.Drawing.Point(475, 94);
            this.bttn_save.Name = "bttn_save";
            this.bttn_save.Size = new System.Drawing.Size(204, 63);
            this.bttn_save.TabIndex = 2;
            this.bttn_save.Text = "Speichern";
            this.bttn_save.UseVisualStyleBackColor = true;
            this.bttn_save.Click += new System.EventHandler(this.bttn_save_Click);
            // 
            // bttn_load
            // 
            this.bttn_load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_load.Location = new System.Drawing.Point(475, 181);
            this.bttn_load.Name = "bttn_load";
            this.bttn_load.Size = new System.Drawing.Size(204, 63);
            this.bttn_load.TabIndex = 3;
            this.bttn_load.Text = "Laden";
            this.bttn_load.UseVisualStyleBackColor = true;
            this.bttn_load.Click += new System.EventHandler(this.bttn_load_Click);
            // 
            // bttn_clear
            // 
            this.bttn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_clear.Location = new System.Drawing.Point(475, 266);
            this.bttn_clear.Name = "bttn_clear";
            this.bttn_clear.Size = new System.Drawing.Size(204, 63);
            this.bttn_clear.TabIndex = 4;
            this.bttn_clear.Text = "Löschen";
            this.bttn_clear.UseVisualStyleBackColor = true;
            this.bttn_clear.Click += new System.EventHandler(this.bttn_clear_Click);
            // 
            // lbl_ide
            // 
            this.lbl_ide.AutoSize = true;
            this.lbl_ide.Location = new System.Drawing.Point(37, 121);
            this.lbl_ide.Name = "lbl_ide";
            this.lbl_ide.Size = new System.Drawing.Size(28, 13);
            this.lbl_ide.TabIndex = 5;
            this.lbl_ide.Text = "IDE:";
            this.lbl_ide.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txt_ide
            // 
            this.txt_ide.Location = new System.Drawing.Point(40, 137);
            this.txt_ide.Name = "txt_ide";
            this.txt_ide.Size = new System.Drawing.Size(312, 20);
            this.txt_ide.TabIndex = 6;
            this.txt_ide.Text = "99999999";
            // 
            // txt_prog
            // 
            this.txt_prog.Location = new System.Drawing.Point(40, 225);
            this.txt_prog.Name = "txt_prog";
            this.txt_prog.Size = new System.Drawing.Size(312, 20);
            this.txt_prog.TabIndex = 7;
            this.txt_prog.Text = "Klingonisch";
            // 
            // lbl_sprache
            // 
            this.lbl_sprache.AutoSize = true;
            this.lbl_sprache.Location = new System.Drawing.Point(37, 209);
            this.lbl_sprache.Name = "lbl_sprache";
            this.lbl_sprache.Size = new System.Drawing.Size(50, 13);
            this.lbl_sprache.TabIndex = 8;
            this.lbl_sprache.Text = "Sprache:";
            // 
            // lb_dbName
            // 
            this.lb_dbName.AutoSize = true;
            this.lb_dbName.Location = new System.Drawing.Point(37, 291);
            this.lb_dbName.Name = "lb_dbName";
            this.lb_dbName.Size = new System.Drawing.Size(89, 13);
            this.lb_dbName.TabIndex = 9;
            this.lb_dbName.Text = "Datenbankname:";
            // 
            // txt_dbName
            // 
            this.txt_dbName.Location = new System.Drawing.Point(40, 309);
            this.txt_dbName.Name = "txt_dbName";
            this.txt_dbName.Size = new System.Drawing.Size(312, 20);
            this.txt_dbName.TabIndex = 10;
            this.txt_dbName.Text = "Datenbank";
            // 
            // lbl_pktXls
            // 
            this.lbl_pktXls.AutoSize = true;
            this.lbl_pktXls.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pktXls.Location = new System.Drawing.Point(358, 309);
            this.lbl_pktXls.Name = "lbl_pktXls";
            this.lbl_pktXls.Size = new System.Drawing.Size(31, 20);
            this.lbl_pktXls.TabIndex = 11;
            this.lbl_pktXls.Text = ".xls";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_pktXls);
            this.Controls.Add(this.txt_dbName);
            this.Controls.Add(this.lb_dbName);
            this.Controls.Add(this.lbl_sprache);
            this.Controls.Add(this.txt_prog);
            this.Controls.Add(this.txt_ide);
            this.Controls.Add(this.lbl_ide);
            this.Controls.Add(this.bttn_clear);
            this.Controls.Add(this.bttn_load);
            this.Controls.Add(this.bttn_save);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_name);
            this.Name = "Form1";
            this.Text = "Datenbank erzeugen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button bttn_save;
        private System.Windows.Forms.Button bttn_load;
        private System.Windows.Forms.Button bttn_clear;
        private System.Windows.Forms.Label lbl_ide;
        private System.Windows.Forms.TextBox txt_ide;
        private System.Windows.Forms.TextBox txt_prog;
        private System.Windows.Forms.Label lbl_sprache;
        private System.Windows.Forms.Label lb_dbName;
        private System.Windows.Forms.TextBox txt_dbName;
        private System.Windows.Forms.Label lbl_pktXls;
    }
}

