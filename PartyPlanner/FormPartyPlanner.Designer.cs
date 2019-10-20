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
            this.tabEvents = new System.Windows.Forms.TabControl();
            this.tpDinner = new System.Windows.Forms.TabPage();
            this.lblDinnerCost = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.chkHealthyOption = new System.Windows.Forms.CheckBox();
            this.chkFancyDinner = new System.Windows.Forms.CheckBox();
            this.nudDinner = new System.Windows.Forms.NumericUpDown();
            this.lblNumberOfPeople = new System.Windows.Forms.Label();
            this.tpBirthday = new System.Windows.Forms.TabPage();
            this.lblBirthdayCost = new System.Windows.Forms.Label();
            this.lblCost2 = new System.Windows.Forms.Label();
            this.txtCakeWriting = new System.Windows.Forms.TextBox();
            this.lblCakeWriting = new System.Windows.Forms.Label();
            this.chkFancyBirthday = new System.Windows.Forms.CheckBox();
            this.nudBirthday = new System.Windows.Forms.NumericUpDown();
            this.lblNumberOfPeople2 = new System.Windows.Forms.Label();
            this.tabEvents.SuspendLayout();
            this.tpDinner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDinner)).BeginInit();
            this.tpBirthday.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // tabEvents
            // 
            this.tabEvents.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabEvents.Controls.Add(this.tpDinner);
            this.tabEvents.Controls.Add(this.tpBirthday);
            this.tabEvents.Location = new System.Drawing.Point(12, 12);
            this.tabEvents.Name = "tabEvents";
            this.tabEvents.SelectedIndex = 0;
            this.tabEvents.Size = new System.Drawing.Size(188, 179);
            this.tabEvents.TabIndex = 6;
            // 
            // tpDinner
            // 
            this.tpDinner.Controls.Add(this.lblDinnerCost);
            this.tpDinner.Controls.Add(this.lblCost);
            this.tpDinner.Controls.Add(this.chkHealthyOption);
            this.tpDinner.Controls.Add(this.chkFancyDinner);
            this.tpDinner.Controls.Add(this.nudDinner);
            this.tpDinner.Controls.Add(this.lblNumberOfPeople);
            this.tpDinner.Location = new System.Drawing.Point(4, 25);
            this.tpDinner.Name = "tpDinner";
            this.tpDinner.Padding = new System.Windows.Forms.Padding(3);
            this.tpDinner.Size = new System.Drawing.Size(180, 150);
            this.tpDinner.TabIndex = 0;
            this.tpDinner.Text = "Jantar";
            this.tpDinner.UseVisualStyleBackColor = true;
            // 
            // lblDinnerCost
            // 
            this.lblDinnerCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDinnerCost.Location = new System.Drawing.Point(56, 109);
            this.lblDinnerCost.Name = "lblDinnerCost";
            this.lblDinnerCost.Size = new System.Drawing.Size(67, 16);
            this.lblDinnerCost.TabIndex = 11;
            this.lblDinnerCost.Text = "R$";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(16, 109);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(34, 13);
            this.lblCost.TabIndex = 10;
            this.lblCost.Text = "Custo";
            // 
            // chkHealthyOption
            // 
            this.chkHealthyOption.AutoSize = true;
            this.chkHealthyOption.Location = new System.Drawing.Point(19, 79);
            this.chkHealthyOption.Name = "chkHealthyOption";
            this.chkHealthyOption.Size = new System.Drawing.Size(104, 17);
            this.chkHealthyOption.TabIndex = 9;
            this.chkHealthyOption.Text = "Opção saudável";
            this.chkHealthyOption.UseVisualStyleBackColor = true;
            this.chkHealthyOption.CheckedChanged += new System.EventHandler(this.ChkHealthyOption_CheckedChanged);
            // 
            // chkFancyDinner
            // 
            this.chkFancyDinner.AutoSize = true;
            this.chkFancyDinner.Checked = true;
            this.chkFancyDinner.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFancyDinner.Location = new System.Drawing.Point(19, 56);
            this.chkFancyDinner.Name = "chkFancyDinner";
            this.chkFancyDinner.Size = new System.Drawing.Size(114, 17);
            this.chkFancyDinner.TabIndex = 8;
            this.chkFancyDinner.Text = "Decoração chique";
            this.chkFancyDinner.UseVisualStyleBackColor = true;
            this.chkFancyDinner.CheckedChanged += new System.EventHandler(this.ChkFancyDinner_CheckedChanged);
            // 
            // nudDinner
            // 
            this.nudDinner.Location = new System.Drawing.Point(19, 30);
            this.nudDinner.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudDinner.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDinner.Name = "nudDinner";
            this.nudDinner.Size = new System.Drawing.Size(101, 20);
            this.nudDinner.TabIndex = 7;
            this.nudDinner.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudDinner.ValueChanged += new System.EventHandler(this.NudDinner_ValueChanged);
            // 
            // lblNumberOfPeople
            // 
            this.lblNumberOfPeople.AutoSize = true;
            this.lblNumberOfPeople.Location = new System.Drawing.Point(16, 14);
            this.lblNumberOfPeople.Name = "lblNumberOfPeople";
            this.lblNumberOfPeople.Size = new System.Drawing.Size(104, 13);
            this.lblNumberOfPeople.TabIndex = 6;
            this.lblNumberOfPeople.Text = "Número de pessoas:";
            // 
            // tpBirthday
            // 
            this.tpBirthday.Controls.Add(this.lblBirthdayCost);
            this.tpBirthday.Controls.Add(this.lblCost2);
            this.tpBirthday.Controls.Add(this.txtCakeWriting);
            this.tpBirthday.Controls.Add(this.lblCakeWriting);
            this.tpBirthday.Controls.Add(this.chkFancyBirthday);
            this.tpBirthday.Controls.Add(this.nudBirthday);
            this.tpBirthday.Controls.Add(this.lblNumberOfPeople2);
            this.tpBirthday.Location = new System.Drawing.Point(4, 25);
            this.tpBirthday.Name = "tpBirthday";
            this.tpBirthday.Padding = new System.Windows.Forms.Padding(3);
            this.tpBirthday.Size = new System.Drawing.Size(180, 150);
            this.tpBirthday.TabIndex = 1;
            this.tpBirthday.Text = "Aniversário";
            this.tpBirthday.UseVisualStyleBackColor = true;
            // 
            // lblBirthdayCost
            // 
            this.lblBirthdayCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBirthdayCost.Location = new System.Drawing.Point(61, 114);
            this.lblBirthdayCost.Name = "lblBirthdayCost";
            this.lblBirthdayCost.Size = new System.Drawing.Size(59, 19);
            this.lblBirthdayCost.TabIndex = 6;
            this.lblBirthdayCost.Text = "R$";
            // 
            // lblCost2
            // 
            this.lblCost2.AutoSize = true;
            this.lblCost2.Location = new System.Drawing.Point(18, 115);
            this.lblCost2.Name = "lblCost2";
            this.lblCost2.Size = new System.Drawing.Size(37, 13);
            this.lblCost2.TabIndex = 5;
            this.lblCost2.Text = "Custo:";
            // 
            // txtCakeWriting
            // 
            this.txtCakeWriting.Location = new System.Drawing.Point(20, 91);
            this.txtCakeWriting.Name = "txtCakeWriting";
            this.txtCakeWriting.Size = new System.Drawing.Size(141, 20);
            this.txtCakeWriting.TabIndex = 4;
            this.txtCakeWriting.Text = "Feliz Aniversário";
            this.txtCakeWriting.TextChanged += new System.EventHandler(this.TxtCakeWriting_TextChanged);
            // 
            // lblCakeWriting
            // 
            this.lblCakeWriting.AutoSize = true;
            this.lblCakeWriting.Location = new System.Drawing.Point(16, 75);
            this.lblCakeWriting.Name = "lblCakeWriting";
            this.lblCakeWriting.Size = new System.Drawing.Size(80, 13);
            this.lblCakeWriting.TabIndex = 3;
            this.lblCakeWriting.Text = "Escrita do bolo:";
            // 
            // chkFancyBirthday
            // 
            this.chkFancyBirthday.AutoSize = true;
            this.chkFancyBirthday.Checked = true;
            this.chkFancyBirthday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFancyBirthday.Location = new System.Drawing.Point(19, 55);
            this.chkFancyBirthday.Name = "chkFancyBirthday";
            this.chkFancyBirthday.Size = new System.Drawing.Size(114, 17);
            this.chkFancyBirthday.TabIndex = 2;
            this.chkFancyBirthday.Text = "Decoração chique";
            this.chkFancyBirthday.UseVisualStyleBackColor = true;
            this.chkFancyBirthday.CheckedChanged += new System.EventHandler(this.ChkFancyBirthday_CheckedChanged);
            // 
            // nudBirthday
            // 
            this.nudBirthday.Location = new System.Drawing.Point(19, 29);
            this.nudBirthday.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudBirthday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBirthday.Name = "nudBirthday";
            this.nudBirthday.Size = new System.Drawing.Size(101, 20);
            this.nudBirthday.TabIndex = 1;
            this.nudBirthday.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudBirthday.ValueChanged += new System.EventHandler(this.NudBirthday_ValueChanged);
            // 
            // lblNumberOfPeople2
            // 
            this.lblNumberOfPeople2.AutoSize = true;
            this.lblNumberOfPeople2.Location = new System.Drawing.Point(16, 13);
            this.lblNumberOfPeople2.Name = "lblNumberOfPeople2";
            this.lblNumberOfPeople2.Size = new System.Drawing.Size(104, 13);
            this.lblNumberOfPeople2.TabIndex = 0;
            this.lblNumberOfPeople2.Text = "Número de pessoas:";
            // 
            // FormPartyPlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 203);
            this.Controls.Add(this.tabEvents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPartyPlanner";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planejador de Festas";
            this.tabEvents.ResumeLayout(false);
            this.tpDinner.ResumeLayout(false);
            this.tpDinner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDinner)).EndInit();
            this.tpBirthday.ResumeLayout(false);
            this.tpBirthday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEvents;
        private System.Windows.Forms.TabPage tpDinner;
        private System.Windows.Forms.Label lblDinnerCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.CheckBox chkHealthyOption;
        private System.Windows.Forms.CheckBox chkFancyDinner;
        private System.Windows.Forms.NumericUpDown nudDinner;
        private System.Windows.Forms.Label lblNumberOfPeople;
        private System.Windows.Forms.TabPage tpBirthday;
        private System.Windows.Forms.NumericUpDown nudBirthday;
        private System.Windows.Forms.Label lblNumberOfPeople2;
        private System.Windows.Forms.Label lblBirthdayCost;
        private System.Windows.Forms.Label lblCost2;
        private System.Windows.Forms.TextBox txtCakeWriting;
        private System.Windows.Forms.Label lblCakeWriting;
        private System.Windows.Forms.CheckBox chkFancyBirthday;
    }
}

