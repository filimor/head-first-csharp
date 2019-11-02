namespace DeckOfCards
{
    partial class FormDeck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeck));
            this.lblDeck1 = new System.Windows.Forms.Label();
            this.lblDeck2 = new System.Windows.Forms.Label();
            this.lstDeck1 = new System.Windows.Forms.ListBox();
            this.lstDeck2 = new System.Windows.Forms.ListBox();
            this.btnSortDeck1 = new System.Windows.Forms.Button();
            this.btnShuffleDeck2 = new System.Windows.Forms.Button();
            this.btnShuffleDeck1 = new System.Windows.Forms.Button();
            this.btnMoveToDeck2 = new System.Windows.Forms.Button();
            this.btnMoveToDeck1 = new System.Windows.Forms.Button();
            this.btnSortDeck2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDeck1
            // 
            this.lblDeck1.AutoSize = true;
            this.lblDeck1.Location = new System.Drawing.Point(12, 9);
            this.lblDeck1.Name = "lblDeck1";
            this.lblDeck1.Size = new System.Drawing.Size(105, 13);
            this.lblDeck1.TabIndex = 0;
            this.lblDeck1.Text = "Baralho 1 (10 cartas)";
            // 
            // lblDeck2
            // 
            this.lblDeck2.AutoSize = true;
            this.lblDeck2.Location = new System.Drawing.Point(216, 9);
            this.lblDeck2.Name = "lblDeck2";
            this.lblDeck2.Size = new System.Drawing.Size(105, 13);
            this.lblDeck2.TabIndex = 1;
            this.lblDeck2.Text = "Baralho 2 (52 cartas)";
            // 
            // lstDeck1
            // 
            this.lstDeck1.FormattingEnabled = true;
            this.lstDeck1.Location = new System.Drawing.Point(15, 25);
            this.lstDeck1.Name = "lstDeck1";
            this.lstDeck1.Size = new System.Drawing.Size(144, 212);
            this.lstDeck1.TabIndex = 2;
            // 
            // lstDeck2
            // 
            this.lstDeck2.FormattingEnabled = true;
            this.lstDeck2.Location = new System.Drawing.Point(219, 25);
            this.lstDeck2.Name = "lstDeck2";
            this.lstDeck2.Size = new System.Drawing.Size(144, 212);
            this.lstDeck2.TabIndex = 2;
            // 
            // btnSortDeck1
            // 
            this.btnSortDeck1.Location = new System.Drawing.Point(15, 243);
            this.btnSortDeck1.Name = "btnSortDeck1";
            this.btnSortDeck1.Size = new System.Drawing.Size(144, 23);
            this.btnSortDeck1.TabIndex = 3;
            this.btnSortDeck1.Text = "Organizar Baralho 1";
            this.btnSortDeck1.UseVisualStyleBackColor = true;
            this.btnSortDeck1.Click += new System.EventHandler(this.BtnSortDeck1_Click);
            // 
            // btnShuffleDeck2
            // 
            this.btnShuffleDeck2.Location = new System.Drawing.Point(219, 243);
            this.btnShuffleDeck2.Name = "btnShuffleDeck2";
            this.btnShuffleDeck2.Size = new System.Drawing.Size(144, 23);
            this.btnShuffleDeck2.TabIndex = 3;
            this.btnShuffleDeck2.Text = "Embaralhar 2";
            this.btnShuffleDeck2.UseVisualStyleBackColor = true;
            this.btnShuffleDeck2.Click += new System.EventHandler(this.btnShuffleDeck2_Click);
            // 
            // btnShuffleDeck1
            // 
            this.btnShuffleDeck1.Location = new System.Drawing.Point(15, 272);
            this.btnShuffleDeck1.Name = "btnShuffleDeck1";
            this.btnShuffleDeck1.Size = new System.Drawing.Size(144, 23);
            this.btnShuffleDeck1.TabIndex = 3;
            this.btnShuffleDeck1.Text = "Embaralhar 1";
            this.btnShuffleDeck1.UseVisualStyleBackColor = true;
            this.btnShuffleDeck1.Click += new System.EventHandler(this.BtnShuffleDeck1_Click);
            // 
            // btnMoveToDeck2
            // 
            this.btnMoveToDeck2.Location = new System.Drawing.Point(165, 58);
            this.btnMoveToDeck2.Name = "btnMoveToDeck2";
            this.btnMoveToDeck2.Size = new System.Drawing.Size(48, 24);
            this.btnMoveToDeck2.TabIndex = 3;
            this.btnMoveToDeck2.Text = ">>";
            this.btnMoveToDeck2.UseVisualStyleBackColor = true;
            // 
            // btnMoveToDeck1
            // 
            this.btnMoveToDeck1.Location = new System.Drawing.Point(165, 88);
            this.btnMoveToDeck1.Name = "btnMoveToDeck1";
            this.btnMoveToDeck1.Size = new System.Drawing.Size(48, 24);
            this.btnMoveToDeck1.TabIndex = 3;
            this.btnMoveToDeck1.Text = "<<";
            this.btnMoveToDeck1.UseVisualStyleBackColor = true;
            // 
            // btnSortDeck2
            // 
            this.btnSortDeck2.Location = new System.Drawing.Point(219, 272);
            this.btnSortDeck2.Name = "btnSortDeck2";
            this.btnSortDeck2.Size = new System.Drawing.Size(144, 23);
            this.btnSortDeck2.TabIndex = 3;
            this.btnSortDeck2.Text = "Organizar Baralho 2";
            this.btnSortDeck2.UseVisualStyleBackColor = true;
            this.btnSortDeck2.Click += new System.EventHandler(this.BtnSortDeck2_Click);
            // 
            // FormDeck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 305);
            this.Controls.Add(this.btnMoveToDeck1);
            this.Controls.Add(this.btnMoveToDeck2);
            this.Controls.Add(this.btnShuffleDeck1);
            this.Controls.Add(this.btnSortDeck2);
            this.Controls.Add(this.btnShuffleDeck2);
            this.Controls.Add(this.btnSortDeck1);
            this.Controls.Add(this.lstDeck2);
            this.Controls.Add(this.lstDeck1);
            this.Controls.Add(this.lblDeck2);
            this.Controls.Add(this.lblDeck1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormDeck";
            this.Text = "Dois Baralhos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeck1;
        private System.Windows.Forms.Label lblDeck2;
        private System.Windows.Forms.ListBox lstDeck1;
        private System.Windows.Forms.ListBox lstDeck2;
        private System.Windows.Forms.Button btnSortDeck1;
        private System.Windows.Forms.Button btnShuffleDeck2;
        private System.Windows.Forms.Button btnShuffleDeck1;
        private System.Windows.Forms.Button btnMoveToDeck2;
        private System.Windows.Forms.Button btnMoveToDeck1;
        private System.Windows.Forms.Button btnSortDeck2;
    }
}

