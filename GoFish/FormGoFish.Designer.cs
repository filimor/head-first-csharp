namespace GoFish
{
    partial class FormGoFish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGoFish));
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblProgress = new System.Windows.Forms.Label();
            this.txtProgress = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblBooks = new System.Windows.Forms.Label();
            this.txtBooks = new System.Windows.Forms.TextBox();
            this.lblHand = new System.Windows.Forms.Label();
            this.lstHand = new System.Windows.Forms.ListBox();
            this.btnAsk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Seu nome";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(142, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(12, 48);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(95, 13);
            this.lblProgress.TabIndex = 2;
            this.lblProgress.Text = "Progresso do Jogo";
            // 
            // txtProgress
            // 
            this.txtProgress.Location = new System.Drawing.Point(15, 64);
            this.txtProgress.Multiline = true;
            this.txtProgress.Name = "txtProgress";
            this.txtProgress.Size = new System.Drawing.Size(291, 205);
            this.txtProgress.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(174, 24);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(132, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Começar o jogo";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Location = new System.Drawing.Point(12, 272);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(35, 13);
            this.lblBooks.TabIndex = 5;
            this.lblBooks.Text = "Livros";
            // 
            // txtBooks
            // 
            this.txtBooks.Location = new System.Drawing.Point(15, 288);
            this.txtBooks.Multiline = true;
            this.txtBooks.Name = "txtBooks";
            this.txtBooks.Size = new System.Drawing.Size(291, 85);
            this.txtBooks.TabIndex = 3;
            // 
            // lblHand
            // 
            this.lblHand.AutoSize = true;
            this.lblHand.Location = new System.Drawing.Point(330, 9);
            this.lblHand.Name = "lblHand";
            this.lblHand.Size = new System.Drawing.Size(49, 13);
            this.lblHand.TabIndex = 6;
            this.lblHand.Text = "Sua mão";
            // 
            // lstHand
            // 
            this.lstHand.FormattingEnabled = true;
            this.lstHand.Location = new System.Drawing.Point(333, 26);
            this.lstHand.Name = "lstHand";
            this.lstHand.Size = new System.Drawing.Size(135, 316);
            this.lstHand.TabIndex = 7;
            // 
            // btnAsk
            // 
            this.btnAsk.Enabled = false;
            this.btnAsk.Location = new System.Drawing.Point(333, 350);
            this.btnAsk.Name = "btnAsk";
            this.btnAsk.Size = new System.Drawing.Size(135, 23);
            this.btnAsk.TabIndex = 8;
            this.btnAsk.Text = "Pergunta por uma carta";
            this.btnAsk.UseVisualStyleBackColor = true;
            this.btnAsk.Click += new System.EventHandler(this.BtnAsk_Click);
            // 
            // FormGoFish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 389);
            this.Controls.Add(this.btnAsk);
            this.Controls.Add(this.lstHand);
            this.Controls.Add(this.lblHand);
            this.Controls.Add(this.lblBooks);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtBooks);
            this.Controls.Add(this.txtProgress);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormGoFish";
            this.Text = "Vá Pescar!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.TextBox txtProgress;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.TextBox txtBooks;
        private System.Windows.Forms.Label lblHand;
        private System.Windows.Forms.ListBox lstHand;
        private System.Windows.Forms.Button btnAsk;
    }
}

