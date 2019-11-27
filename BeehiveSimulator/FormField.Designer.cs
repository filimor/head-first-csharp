namespace BeehiveSimulator
{
    partial class FormField
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
            this.picHive = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHive)).BeginInit();
            this.SuspendLayout();
            // 
            // picHive
            // 
            this.picHive.BackgroundImage = global::BeehiveSimulator.Properties.Resources.Hive__outside_;
            this.picHive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHive.Location = new System.Drawing.Point(608, 12);
            this.picHive.Name = "picHive";
            this.picHive.Size = new System.Drawing.Size(108, 120);
            this.picHive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHive.TabIndex = 0;
            this.picHive.TabStop = false;
            // 
            // FormField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 452);
            this.ControlBox = false;
            this.Controls.Add(this.picHive);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormField";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "O Campo";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormField_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picHive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picHive;
    }
}