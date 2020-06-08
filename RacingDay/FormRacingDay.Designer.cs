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
            resources.ApplyResources(this.picDog1, "picDog1");
            this.picDog1.Name = "picDog1";
            this.picDog1.TabStop = false;
            // 
            // picRaceTrack
            // 
            this.picRaceTrack.Image = global::RacingDay.Properties.Resources.racetrack;
            resources.ApplyResources(this.picRaceTrack, "picRaceTrack");
            this.picRaceTrack.Name = "picRaceTrack";
            this.picRaceTrack.TabStop = false;
            // 
            // picDog2
            // 
            this.picDog2.Image = global::RacingDay.Properties.Resources.dog;
            resources.ApplyResources(this.picDog2, "picDog2");
            this.picDog2.Name = "picDog2";
            this.picDog2.TabStop = false;
            // 
            // picDog3
            // 
            this.picDog3.Image = global::RacingDay.Properties.Resources.dog;
            resources.ApplyResources(this.picDog3, "picDog3");
            this.picDog3.Name = "picDog3";
            this.picDog3.TabStop = false;
            // 
            // picDog4
            // 
            this.picDog4.Image = global::RacingDay.Properties.Resources.dog;
            resources.ApplyResources(this.picDog4, "picDog4");
            this.picDog4.Name = "picDog4";
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
            resources.ApplyResources(this.grpCounter, "grpCounter");
            this.grpCounter.Name = "grpCounter";
            this.grpCounter.TabStop = false;
            // 
            // btnRun
            // 
            resources.ApplyResources(this.btnRun, "btnRun");
            this.btnRun.Name = "btnRun";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // nudDog
            // 
            resources.ApplyResources(this.nudDog, "nudDog");
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
            this.nudDog.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblBet
            // 
            resources.ApplyResources(this.lblBet, "lblBet");
            this.lblBet.Name = "lblBet";
            // 
            // nudAmount
            // 
            resources.ApplyResources(this.nudAmount, "nudAmount");
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
            this.nudAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnBet
            // 
            resources.ApplyResources(this.btnBet, "btnBet");
            this.btnBet.Name = "btnBet";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.BtnBet_Click);
            // 
            // lblBettor
            // 
            resources.ApplyResources(this.lblBettor, "lblBettor");
            this.lblBettor.Name = "lblBettor";
            // 
            // lblAlfredo
            // 
            this.lblAlfredo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.lblAlfredo, "lblAlfredo");
            this.lblAlfredo.Name = "lblAlfredo";
            // 
            // lblBeto
            // 
            this.lblBeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.lblBeto, "lblBeto");
            this.lblBeto.Name = "lblBeto";
            // 
            // lblJoao
            // 
            this.lblJoao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.lblJoao, "lblJoao");
            this.lblJoao.Name = "lblJoao";
            // 
            // lblBets
            // 
            resources.ApplyResources(this.lblBets, "lblBets");
            this.lblBets.Name = "lblBets";
            // 
            // rdoAlfredo
            // 
            resources.ApplyResources(this.rdoAlfredo, "rdoAlfredo");
            this.rdoAlfredo.Name = "rdoAlfredo";
            this.rdoAlfredo.UseVisualStyleBackColor = true;
            this.rdoAlfredo.CheckedChanged += new System.EventHandler(this.RdoAlfredo_CheckedChanged);
            // 
            // rdoBeto
            // 
            resources.ApplyResources(this.rdoBeto, "rdoBeto");
            this.rdoBeto.Name = "rdoBeto";
            this.rdoBeto.UseVisualStyleBackColor = true;
            this.rdoBeto.CheckedChanged += new System.EventHandler(this.RdoBeto_CheckedChanged);
            // 
            // rdoJoao
            // 
            resources.ApplyResources(this.rdoJoao, "rdoJoao");
            this.rdoJoao.Checked = true;
            this.rdoJoao.Name = "rdoJoao";
            this.rdoJoao.TabStop = true;
            this.rdoJoao.UseVisualStyleBackColor = true;
            this.rdoJoao.CheckedChanged += new System.EventHandler(this.RdoJoao_CheckedChanged);
            // 
            // lblMinimumBet
            // 
            resources.ApplyResources(this.lblMinimumBet, "lblMinimumBet");
            this.lblMinimumBet.Name = "lblMinimumBet";
            // 
            // FormRacingDay
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpCounter);
            this.Controls.Add(this.picDog4);
            this.Controls.Add(this.picDog3);
            this.Controls.Add(this.picDog2);
            this.Controls.Add(this.picDog1);
            this.Controls.Add(this.picRaceTrack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormRacingDay";
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

