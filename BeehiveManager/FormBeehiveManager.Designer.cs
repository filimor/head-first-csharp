namespace BeehiveManager
{
    partial class FormBeehiveManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBeehiveManager));
            this.grpAssignments = new System.Windows.Forms.GroupBox();
            this.nudShifts = new System.Windows.Forms.NumericUpDown();
            this.lblShifts = new System.Windows.Forms.Label();
            this.btnAssignTask = new System.Windows.Forms.Button();
            this.cboTasks = new System.Windows.Forms.ComboBox();
            this.lblBeeTask = new System.Windows.Forms.Label();
            this.btnNextShift = new System.Windows.Forms.Button();
            this.txtReport = new System.Windows.Forms.TextBox();
            this.grpAssignments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShifts)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAssignments
            // 
            this.grpAssignments.Controls.Add(this.nudShifts);
            this.grpAssignments.Controls.Add(this.lblShifts);
            this.grpAssignments.Controls.Add(this.btnAssignTask);
            this.grpAssignments.Controls.Add(this.cboTasks);
            this.grpAssignments.Controls.Add(this.lblBeeTask);
            this.grpAssignments.Location = new System.Drawing.Point(12, 12);
            this.grpAssignments.Name = "grpAssignments";
            this.grpAssignments.Size = new System.Drawing.Size(329, 89);
            this.grpAssignments.TabIndex = 0;
            this.grpAssignments.TabStop = false;
            this.grpAssignments.Text = "Atribuições de Tarefas de Operárias";
            // 
            // nudShifts
            // 
            this.nudShifts.Location = new System.Drawing.Point(258, 32);
            this.nudShifts.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudShifts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudShifts.Name = "nudShifts";
            this.nudShifts.Size = new System.Drawing.Size(65, 20);
            this.nudShifts.TabIndex = 4;
            this.nudShifts.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblShifts
            // 
            this.lblShifts.AutoSize = true;
            this.lblShifts.Location = new System.Drawing.Point(255, 16);
            this.lblShifts.Name = "lblShifts";
            this.lblShifts.Size = new System.Drawing.Size(40, 13);
            this.lblShifts.TabIndex = 3;
            this.lblShifts.Text = "Turnos";
            // 
            // btnAssignTask
            // 
            this.btnAssignTask.Location = new System.Drawing.Point(9, 59);
            this.btnAssignTask.Name = "btnAssignTask";
            this.btnAssignTask.Size = new System.Drawing.Size(227, 23);
            this.btnAssignTask.TabIndex = 2;
            this.btnAssignTask.Text = "Atribuir essa tarefa a uma abelha";
            this.btnAssignTask.UseVisualStyleBackColor = true;
            this.btnAssignTask.Click += new System.EventHandler(this.BtnAssignTask_Click);
            // 
            // cboTasks
            // 
            this.cboTasks.BackColor = System.Drawing.Color.White;
            this.cboTasks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTasks.FormattingEnabled = true;
            this.cboTasks.Items.AddRange(new object[] {
            "Coletar néctar",
            "Produção de mel",
            "Cuidar dos ovos",
            "Ensinar às abelhas bebês",
            "Manutenção da colméia",
            "Patrulha"});
            this.cboTasks.Location = new System.Drawing.Point(9, 32);
            this.cboTasks.MaxDropDownItems = 6;
            this.cboTasks.Name = "cboTasks";
            this.cboTasks.Size = new System.Drawing.Size(227, 21);
            this.cboTasks.TabIndex = 1;
            // 
            // lblBeeTask
            // 
            this.lblBeeTask.AutoSize = true;
            this.lblBeeTask.Location = new System.Drawing.Point(6, 16);
            this.lblBeeTask.Name = "lblBeeTask";
            this.lblBeeTask.Size = new System.Drawing.Size(94, 13);
            this.lblBeeTask.TabIndex = 0;
            this.lblBeeTask.Text = "Tarefa da operária";
            // 
            // btnNextShift
            // 
            this.btnNextShift.Location = new System.Drawing.Point(347, 19);
            this.btnNextShift.Name = "btnNextShift";
            this.btnNextShift.Size = new System.Drawing.Size(81, 82);
            this.btnNextShift.TabIndex = 1;
            this.btnNextShift.Text = "Próximo turno";
            this.btnNextShift.UseVisualStyleBackColor = true;
            this.btnNextShift.Click += new System.EventHandler(this.BtnNextShift_Click);
            // 
            // txtReport
            // 
            this.txtReport.Location = new System.Drawing.Point(12, 107);
            this.txtReport.Multiline = true;
            this.txtReport.Name = "txtReport";
            this.txtReport.Size = new System.Drawing.Size(416, 195);
            this.txtReport.TabIndex = 2;
            // 
            // FormBeehiveManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 312);
            this.Controls.Add(this.txtReport);
            this.Controls.Add(this.btnNextShift);
            this.Controls.Add(this.grpAssignments);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormBeehiveManager";
            this.Text = "Sistema de Gerenciamento de Colméia";
            this.grpAssignments.ResumeLayout(false);
            this.grpAssignments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAssignments;
        private System.Windows.Forms.NumericUpDown nudShifts;
        private System.Windows.Forms.Label lblShifts;
        private System.Windows.Forms.Button btnAssignTask;
        private System.Windows.Forms.ComboBox cboTasks;
        private System.Windows.Forms.Label lblBeeTask;
        private System.Windows.Forms.Button btnNextShift;
        private System.Windows.Forms.TextBox txtReport;
    }
}

