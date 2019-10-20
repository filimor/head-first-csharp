namespace PartyPlanner
{
    partial class FormPartyPlanner
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
            this.lblNumberOfPeople = new System.Windows.Forms.Label();
            this.nudNumberOfPeople = new System.Windows.Forms.NumericUpDown();
            this.chkFancyDecoration = new System.Windows.Forms.CheckBox();
            this.chkHealthyOption = new System.Windows.Forms.CheckBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumberOfPeople
            // 
            this.lblNumberOfPeople.AutoSize = true;
            this.lblNumberOfPeople.Location = new System.Drawing.Point(23, 9);
            this.lblNumberOfPeople.Name = "lblNumberOfPeople";
            this.lblNumberOfPeople.Size = new System.Drawing.Size(104, 13);
            this.lblNumberOfPeople.TabIndex = 0;
            this.lblNumberOfPeople.Text = "Número de pessoas:";
            // 
            // nudNumberOfPeople
            // 
            this.nudNumberOfPeople.Location = new System.Drawing.Point(26, 25);
            this.nudNumberOfPeople.Name = "nudNumberOfPeople";
            this.nudNumberOfPeople.Size = new System.Drawing.Size(101, 20);
            this.nudNumberOfPeople.TabIndex = 1;
            // 
            // chkFancyDecoration
            // 
            this.chkFancyDecoration.AutoSize = true;
            this.chkFancyDecoration.Location = new System.Drawing.Point(26, 51);
            this.chkFancyDecoration.Name = "chkFancyDecoration";
            this.chkFancyDecoration.Size = new System.Drawing.Size(114, 17);
            this.chkFancyDecoration.TabIndex = 2;
            this.chkFancyDecoration.Text = "Decoração chique";
            this.chkFancyDecoration.UseVisualStyleBackColor = true;
            // 
            // chkHealthyOption
            // 
            this.chkHealthyOption.AutoSize = true;
            this.chkHealthyOption.Location = new System.Drawing.Point(26, 74);
            this.chkHealthyOption.Name = "chkHealthyOption";
            this.chkHealthyOption.Size = new System.Drawing.Size(104, 17);
            this.chkHealthyOption.TabIndex = 3;
            this.chkHealthyOption.Text = "Opção saudável";
            this.chkHealthyOption.UseVisualStyleBackColor = true;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(23, 104);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(34, 13);
            this.lblCost.TabIndex = 4;
            this.lblCost.Text = "Custo";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCost.Location = new System.Drawing.Point(63, 104);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(67, 16);
            this.lblTotalCost.TabIndex = 5;
            this.lblTotalCost.Text = "R$";
            // 
            // FormPartyPlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 137);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.chkHealthyOption);
            this.Controls.Add(this.chkFancyDecoration);
            this.Controls.Add(this.nudNumberOfPeople);
            this.Controls.Add(this.lblNumberOfPeople);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPartyPlanner";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planejador de Festas";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberOfPeople;
        private System.Windows.Forms.NumericUpDown nudNumberOfPeople;
        private System.Windows.Forms.CheckBox chkFancyDecoration;
        private System.Windows.Forms.CheckBox chkHealthyOption;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblTotalCost;
    }
}

