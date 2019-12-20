namespace SpaceInvaders
{
    partial class FormInvaders
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
            this.components = new System.ComponentModel.Container();
            this.tmrAnimator = new System.Windows.Forms.Timer(this.components);
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmrAnimator
            // 
            this.tmrAnimator.Enabled = true;
            this.tmrAnimator.Interval = 33;
            this.tmrAnimator.Tick += new System.EventHandler(this.TmrAnimator_Tick);
            // 
            // tmrGame
            // 
            this.tmrGame.Enabled = true;
            this.tmrGame.Interval = 10;
            this.tmrGame.Tick += new System.EventHandler(this.TmrGame_Tick);
            // 
            // FormInvaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(932, 534);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInvaders";
            this.Text = "Invasores";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormInvaders_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormInvaders_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormInvaders_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrAnimator;
        private System.Windows.Forms.Timer tmrGame;
    }
}

