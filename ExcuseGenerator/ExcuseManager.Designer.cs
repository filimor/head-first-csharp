namespace ExcuseManager
{
    partial class FormExcuseManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExcuseManager));
            this.lblExcuse = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblLastUsed = new System.Windows.Forms.Label();
            this.lblFileDate = new System.Windows.Forms.Label();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblFileDateDescription = new System.Windows.Forms.Label();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnRandomExcuse = new System.Windows.Forms.Button();
            this.dtpLastUsed = new System.Windows.Forms.DateTimePicker();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblExcuse
            // 
            this.lblExcuse.AutoSize = true;
            this.lblExcuse.Location = new System.Drawing.Point(12, 9);
            this.lblExcuse.Name = "lblExcuse";
            this.lblExcuse.Size = new System.Drawing.Size(52, 13);
            this.lblExcuse.TabIndex = 0;
            this.lblExcuse.Text = "Desculpa";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(12, 41);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(60, 13);
            this.lblResults.TabIndex = 1;
            this.lblResults.Text = "Resultados";
            // 
            // lblLastUsed
            // 
            this.lblLastUsed.AutoSize = true;
            this.lblLastUsed.Location = new System.Drawing.Point(12, 73);
            this.lblLastUsed.Name = "lblLastUsed";
            this.lblLastUsed.Size = new System.Drawing.Size(130, 13);
            this.lblLastUsed.TabIndex = 2;
            this.lblLastUsed.Text = "Usada pela Última vez em";
            // 
            // lblFileDate
            // 
            this.lblFileDate.AutoSize = true;
            this.lblFileDate.Location = new System.Drawing.Point(12, 105);
            this.lblFileDate.Name = "lblFileDate";
            this.lblFileDate.Size = new System.Drawing.Size(84, 13);
            this.lblFileDate.TabIndex = 3;
            this.lblFileDate.Text = "Data do Arquivo";
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(148, 38);
            this.txtResults.MaxLength = 200;
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(284, 20);
            this.txtResults.TabIndex = 5;
            this.txtResults.Text = "Não funcionou - o chefe sabe que não tenho cachorro.";
            this.txtResults.TextChanged += new System.EventHandler(this.TxtResults_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(148, 6);
            this.txtDescription.MaxLength = 200;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(284, 20);
            this.txtDescription.TabIndex = 6;
            this.txtDescription.Text = "Meu cachorro está com dor de cabeça.";
            this.txtDescription.TextChanged += new System.EventHandler(this.TxtDescription_TextChanged);
            // 
            // lblFileDateDescription
            // 
            this.lblFileDateDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFileDateDescription.Location = new System.Drawing.Point(148, 102);
            this.lblFileDateDescription.Name = "lblFileDateDescription";
            this.lblFileDateDescription.Size = new System.Drawing.Size(284, 21);
            this.lblFileDateDescription.TabIndex = 8;
            this.lblFileDateDescription.Text = "26/07/2007 9:48:27";
            this.lblFileDateDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(15, 141);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(75, 23);
            this.btnFolder.TabIndex = 9;
            this.btnFolder.Text = "Pasta";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.BtnFolder_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(117, 141);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Enabled = false;
            this.btnOpen.Location = new System.Drawing.Point(219, 141);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 11;
            this.btnOpen.Text = "Abrir";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // btnRandomExcuse
            // 
            this.btnRandomExcuse.Enabled = false;
            this.btnRandomExcuse.Location = new System.Drawing.Point(321, 141);
            this.btnRandomExcuse.Name = "btnRandomExcuse";
            this.btnRandomExcuse.Size = new System.Drawing.Size(110, 23);
            this.btnRandomExcuse.TabIndex = 12;
            this.btnRandomExcuse.Text = "Desculpa Aleatória";
            this.btnRandomExcuse.UseVisualStyleBackColor = true;
            this.btnRandomExcuse.Click += new System.EventHandler(this.BtnRandomExcuse_Click);
            // 
            // dtpLastUsed
            // 
            this.dtpLastUsed.Location = new System.Drawing.Point(148, 70);
            this.dtpLastUsed.Name = "dtpLastUsed";
            this.dtpLastUsed.Size = new System.Drawing.Size(284, 20);
            this.dtpLastUsed.TabIndex = 13;
            this.dtpLastUsed.ValueChanged += new System.EventHandler(this.DtpLastUsed_ValueChanged);
            // 
            // FormExcuseManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 170);
            this.Controls.Add(this.dtpLastUsed);
            this.Controls.Add(this.btnRandomExcuse);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.lblFileDateDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.lblFileDate);
            this.Controls.Add(this.lblLastUsed);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblExcuse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormExcuseManager";
            this.Text = "Gerenciador de Desculpas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExcuse;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblLastUsed;
        private System.Windows.Forms.Label lblFileDate;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblFileDateDescription;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnRandomExcuse;
        private System.Windows.Forms.DateTimePicker dtpLastUsed;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

