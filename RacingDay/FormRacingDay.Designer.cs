namespace RacingDay
{
    partial class FormRacingDay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRacingDay));
            this.picDog1 = new System.Windows.Forms.PictureBox();
            this.picRaceTrack = new System.Windows.Forms.PictureBox();
            this.picDog2 = new System.Windows.Forms.PictureBox();
            this.picDog3 = new System.Windows.Forms.PictureBox();
            this.picDog4 = new System.Windows.Forms.PictureBox();
            this.grpCounter = new System.Windows.Forms.GroupBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.nudDog = new System.Windows.Forms.NumericUpDown();
            this.lblBet = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.btnBet = new System.Windows.Forms.Button();
            this.lblBettor = new System.Windows.Forms.Label();
            this.lblAlfredo = new System.Windows.Forms.Label();
            this.lblBeto = new System.Windows.Forms.Label();
            this.lblJoao = new System.Windows.Forms.Label();
            this.lblBets = new System.Windows.Forms.Label();
            this.rdoAlfredo = new System.Windows.Forms.RadioButton();
            this.rdoBeto = new System.Windows.Forms.RadioButton();
            this.rdoJoao = new System.Windows.Forms.RadioButton();
            this.lblMinimumBet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRaceTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDog4)).BeginInit();
            this.grpCounter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // picDog1
            // 
            this.picDog1.Image = global::RacingDay.Properties.Resources.dog;
            this.picDog1.Location = new System.Drawing.Point(21, 21);
            this.picDog1.Name = "picDog1";
            this.picDog1.Size = new System.Drawing.Size(75, 20);
            this.picDog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDog1.TabIndex = 1;
            this.picDog1.TabStop = false;
            // 
            // picRaceTrack
            // 
            this.picRaceTrack.Image = global::RacingDay.Properties.Resources.racetrack;
            this.picRaceTrack.Location = new System.Drawing.Point(12, 12);
            this.picRaceTrack.Name = "picRaceTrack";
            this.picRaceTrack.Size = new System.Drawing.Size(600, 200);
            this.picRaceTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picRaceTrack.TabIndex = 0;
            this.picRaceTrack.TabStop = false;
            // 
            // picDog2
            // 
            this.picDog2.Image = global::RacingDay.Properties.Resources.dog;
            this.picDog2.Location = new System.Drawing.Point(22, 72);
            this.picDog2.Name = "picDog2";
            this.picDog2.Size = new System.Drawing.Size(75, 20);
            this.picDog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDog2.TabIndex = 2;
            this.picDog2.TabStop = false;
            // 
            // picDog3
            // 
            this.picDog3.Image = global::RacingDay.Properties.Resources.dog;
            this.picDog3.Location = new System.Drawing.Point(22, 125);
            this.picDog3.Name = "picDog3";
            this.picDog3.Size = new System.Drawing.Size(75, 20);
            this.picDog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDog3.TabIndex = 3;
            this.picDog3.TabStop = false;
            // 
            // picDog4
            // 
            this.picDog4.Image = global::RacingDay.Properties.Resources.dog;
            this.picDog4.Location = new System.Drawing.Point(22, 179);
            this.picDog4.Name = "picDog4";
            this.picDog4.Size = new System.Drawing.Size(75, 20);
            this.picDog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDog4.TabIndex = 4;
            this.picDog4.TabStop = false;
            // 
            // grpCounter
            // 
            this.grpCounter.Controls.Add(this.btnRun);
            this.grpCounter.Controls.Add(this.nudDog);
            this.grpCounter.Controls.Add(this.lblBet);
            this.grpCounter.Controls.Add(this.nudAmount);
            this.grpCounter.Controls.Add(this.btnBet);
            this.grpCounter.Controls.Add(this.lblBettor);
            this.grpCounter.Controls.Add(this.lblAlfredo);
            this.grpCounter.Controls.Add(this.lblBeto);
            this.grpCounter.Controls.Add(this.lblJoao);
            this.grpCounter.Controls.Add(this.lblBets);
            this.grpCounter.Controls.Add(this.rdoAlfredo);
            this.grpCounter.Controls.Add(this.rdoBeto);
            this.grpCounter.Controls.Add(this.rdoJoao);
            this.grpCounter.Controls.Add(this.lblMinimumBet);
            this.grpCounter.Location = new System.Drawing.Point(12, 218);
            this.grpCounter.Name = "grpCounter";
            this.grpCounter.Size = new System.Drawing.Size(600, 171);
            this.grpCounter.TabIndex = 5;
            this.grpCounter.TabStop = false;
            this.grpCounter.Text = "Balcão de Apostas";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(519, 139);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 20);
            this.btnRun.TabIndex = 13;
            this.btnRun.Text = "Corram!";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // nudDog
            // 
            this.nudDog.Location = new System.Drawing.Point(335, 139);
            this.nudDog.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudDog.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDog.Name = "nudDog";
            this.nudDog.Size = new System.Drawing.Size(55, 20);
            this.nudDog.TabIndex = 12;
            this.nudDog.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.Location = new System.Drawing.Point(223, 143);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(103, 13);
            this.lblBet.TabIndex = 11;
            this.lblBet.Text = "reais no cão número";
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(157, 139);
            this.nudAmount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(55, 20);
            this.nudAmount.TabIndex = 10;
            this.nudAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(69, 139);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(75, 20);
            this.btnBet.TabIndex = 9;
            this.btnBet.Text = "Aposta";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.BtnBet_Click);
            // 
            // lblBettor
            // 
            this.lblBettor.AutoSize = true;
            this.lblBettor.Location = new System.Drawing.Point(20, 143);
            this.lblBettor.Name = "lblBettor";
            this.lblBettor.Size = new System.Drawing.Size(30, 13);
            this.lblBettor.TabIndex = 8;
            this.lblBettor.Text = "João";
            // 
            // lblAlfredo
            // 
            this.lblAlfredo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAlfredo.Location = new System.Drawing.Point(335, 111);
            this.lblAlfredo.Name = "lblAlfredo";
            this.lblAlfredo.Size = new System.Drawing.Size(259, 19);
            this.lblAlfredo.TabIndex = 7;
            this.lblAlfredo.Text = "Alfredo ainda não apostou";
            this.lblAlfredo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBeto
            // 
            this.lblBeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBeto.Location = new System.Drawing.Point(335, 83);
            this.lblBeto.Name = "lblBeto";
            this.lblBeto.Size = new System.Drawing.Size(259, 19);
            this.lblBeto.TabIndex = 6;
            this.lblBeto.Text = "Beto ainda não apostou";
            this.lblBeto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblJoao
            // 
            this.lblJoao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJoao.Location = new System.Drawing.Point(335, 54);
            this.lblJoao.Name = "lblJoao";
            this.lblJoao.Size = new System.Drawing.Size(259, 19);
            this.lblJoao.TabIndex = 5;
            this.lblJoao.Text = "João ainda não apostou";
            this.lblJoao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBets
            // 
            this.lblBets.AutoSize = true;
            this.lblBets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBets.Location = new System.Drawing.Point(332, 29);
            this.lblBets.Name = "lblBets";
            this.lblBets.Size = new System.Drawing.Size(52, 13);
            this.lblBets.TabIndex = 4;
            this.lblBets.Text = "Apostas";
            // 
            // rdoAlfredo
            // 
            this.rdoAlfredo.AutoSize = true;
            this.rdoAlfredo.Location = new System.Drawing.Point(23, 112);
            this.rdoAlfredo.Name = "rdoAlfredo";
            this.rdoAlfredo.Size = new System.Drawing.Size(123, 17);
            this.rdoAlfredo.TabIndex = 3;
            this.rdoAlfredo.Text = "Alfredo tem 45 Reais";
            this.rdoAlfredo.UseVisualStyleBackColor = true;
            this.rdoAlfredo.CheckedChanged += new System.EventHandler(this.RdoAlfredo_CheckedChanged);
            // 
            // rdoBeto
            // 
            this.rdoBeto.AutoSize = true;
            this.rdoBeto.Location = new System.Drawing.Point(23, 84);
            this.rdoBeto.Name = "rdoBeto";
            this.rdoBeto.Size = new System.Drawing.Size(112, 17);
            this.rdoBeto.TabIndex = 2;
            this.rdoBeto.Text = "Beto tem 75 Reais";
            this.rdoBeto.UseVisualStyleBackColor = true;
            this.rdoBeto.CheckedChanged += new System.EventHandler(this.RdoBeto_CheckedChanged);
            // 
            // rdoJoao
            // 
            this.rdoJoao.AutoSize = true;
            this.rdoJoao.Checked = true;
            this.rdoJoao.Location = new System.Drawing.Point(23, 55);
            this.rdoJoao.Name = "rdoJoao";
            this.rdoJoao.Size = new System.Drawing.Size(113, 17);
            this.rdoJoao.TabIndex = 1;
            this.rdoJoao.TabStop = true;
            this.rdoJoao.Text = "João tem 50 Reais";
            this.rdoJoao.UseVisualStyleBackColor = true;
            this.rdoJoao.CheckedChanged += new System.EventHandler(this.RdoJoao_CheckedChanged);
            // 
            // lblMinimumBet
            // 
            this.lblMinimumBet.AutoSize = true;
            this.lblMinimumBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimumBet.Location = new System.Drawing.Point(9, 29);
            this.lblMinimumBet.Name = "lblMinimumBet";
            this.lblMinimumBet.Size = new System.Drawing.Size(137, 13);
            this.lblMinimumBet.TabIndex = 0;
            this.lblMinimumBet.Text = "Aposta Mínima: 5 reais";
            // 
            // FormRacingDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 400);
            this.Controls.Add(this.grpCounter);
            this.Controls.Add(this.picDog4);
            this.Controls.Add(this.picDog3);
            this.Controls.Add(this.picDog2);
            this.Controls.Add(this.picDog1);
            this.Controls.Add(this.picRaceTrack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormRacingDay";
            this.Text = "Um dia de corrida";
            ((System.ComponentModel.ISupportInitialize)(this.picDog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRaceTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDog4)).EndInit();
            this.grpCounter.ResumeLayout(false);
            this.grpCounter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picRaceTrack;
        private System.Windows.Forms.PictureBox picDog1;
        private System.Windows.Forms.PictureBox picDog2;
        private System.Windows.Forms.PictureBox picDog3;
        private System.Windows.Forms.PictureBox picDog4;
        private System.Windows.Forms.GroupBox grpCounter;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.NumericUpDown nudDog;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Label lblBettor;
        private System.Windows.Forms.Label lblAlfredo;
        private System.Windows.Forms.Label lblBeto;
        private System.Windows.Forms.Label lblJoao;
        private System.Windows.Forms.Label lblBets;
        private System.Windows.Forms.RadioButton rdoAlfredo;
        private System.Windows.Forms.RadioButton rdoBeto;
        private System.Windows.Forms.RadioButton rdoJoao;
        private System.Windows.Forms.Label lblMinimumBet;
    }
}

