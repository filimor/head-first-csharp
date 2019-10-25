namespace ExploreTheHouse
{
    partial class FormExplore
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnGoHere = new System.Windows.Forms.Button();
            this.cboExits = new System.Windows.Forms.ComboBox();
            this.btnPassThroughTheDoor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 12);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(272, 141);
            this.txtDescription.TabIndex = 0;
            // 
            // btnGoHere
            // 
            this.btnGoHere.Location = new System.Drawing.Point(12, 159);
            this.btnGoHere.Name = "btnGoHere";
            this.btnGoHere.Size = new System.Drawing.Size(75, 21);
            this.btnGoHere.TabIndex = 1;
            this.btnGoHere.Text = "Vá para:";
            this.btnGoHere.UseVisualStyleBackColor = true;
            this.btnGoHere.Click += new System.EventHandler(this.BtnGoHere_Click);
            // 
            // cboExits
            // 
            this.cboExits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExits.FormattingEnabled = true;
            this.cboExits.Location = new System.Drawing.Point(93, 159);
            this.cboExits.Name = "cboExits";
            this.cboExits.Size = new System.Drawing.Size(191, 21);
            this.cboExits.TabIndex = 2;
            // 
            // btnPassThroughTheDoor
            // 
            this.btnPassThroughTheDoor.Location = new System.Drawing.Point(12, 186);
            this.btnPassThroughTheDoor.Name = "btnPassThroughTheDoor";
            this.btnPassThroughTheDoor.Size = new System.Drawing.Size(272, 23);
            this.btnPassThroughTheDoor.TabIndex = 3;
            this.btnPassThroughTheDoor.Text = "Passe pela porta";
            this.btnPassThroughTheDoor.UseVisualStyleBackColor = true;
            this.btnPassThroughTheDoor.Click += new System.EventHandler(this.BtnPassThroughTheDoor_Click);
            // 
            // FormExplore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 220);
            this.Controls.Add(this.btnPassThroughTheDoor);
            this.Controls.Add(this.cboExits);
            this.Controls.Add(this.btnGoHere);
            this.Controls.Add(this.txtDescription);
            this.Name = "FormExplore";
            this.Text = "Explore The House";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnGoHere;
        private System.Windows.Forms.ComboBox cboExits;
        private System.Windows.Forms.Button btnPassThroughTheDoor;
    }
}

