namespace BeehiveSimulator
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tsToolbar = new System.Windows.Forms.ToolStrip();
            this.ssStatusbar = new System.Windows.Forms.StatusStrip();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBeesLabel = new System.Windows.Forms.Label();
            this.lblFlowersLabel = new System.Windows.Forms.Label();
            this.lblHoneyInHiveLabel = new System.Windows.Forms.Label();
            this.lblNectarInFlowersLabel = new System.Windows.Forms.Label();
            this.lblFramesRunLabel = new System.Windows.Forms.Label();
            this.lblFrameRateLabel = new System.Windows.Forms.Label();
            this.lblBees = new System.Windows.Forms.Label();
            this.lblFlowers = new System.Windows.Forms.Label();
            this.lblHoneyInHive = new System.Windows.Forms.Label();
            this.lblNectarInFlowers = new System.Windows.Forms.Label();
            this.lblFramesRun = new System.Windows.Forms.Label();
            this.lblFrameRate = new System.Windows.Forms.Label();
            this.tsToolbar.SuspendLayout();
            this.ssStatusbar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsToolbar
            // 
            this.tsToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.tsToolbar.Location = new System.Drawing.Point(0, 0);
            this.tsToolbar.Name = "tsToolbar";
            this.tsToolbar.Size = new System.Drawing.Size(397, 25);
            this.tsToolbar.TabIndex = 0;
            this.tsToolbar.Text = "toolStrip1";
            // 
            // ssStatusbar
            // 
            this.ssStatusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.ssStatusbar.Location = new System.Drawing.Point(0, 201);
            this.ssStatusbar.Name = "ssStatusbar";
            this.ssStatusbar.Size = new System.Drawing.Size(397, 22);
            this.ssStatusbar.TabIndex = 1;
            this.ssStatusbar.Text = "statusStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(101, 22);
            this.toolStripButton1.Text = "Iniciar Simulação";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(56, 22);
            this.toolStripButton2.Text = "Reiniciar";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(119, 17);
            this.toolStripStatusLabel1.Text = "Simulação em Pausa.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblBeesLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFlowersLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblHoneyInHiveLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblNectarInFlowersLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblFramesRunLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblFrameRateLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblBees, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFlowers, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblHoneyInHive, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblNectarInFlowers, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblFramesRun, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblFrameRate, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(397, 176);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblBeesLabel
            // 
            this.lblBeesLabel.AutoSize = true;
            this.lblBeesLabel.Location = new System.Drawing.Point(3, 0);
            this.lblBeesLabel.Name = "lblBeesLabel";
            this.lblBeesLabel.Size = new System.Drawing.Size(103, 13);
            this.lblBeesLabel.TabIndex = 0;
            this.lblBeesLabel.Text = "Número de Abelhas:";
            // 
            // lblFlowersLabel
            // 
            this.lblFlowersLabel.AutoSize = true;
            this.lblFlowersLabel.Location = new System.Drawing.Point(3, 29);
            this.lblFlowersLabel.Name = "lblFlowersLabel";
            this.lblFlowersLabel.Size = new System.Drawing.Size(93, 13);
            this.lblFlowersLabel.TabIndex = 1;
            this.lblFlowersLabel.Text = "Número de Flores:";
            // 
            // lblHoneyInHiveLabel
            // 
            this.lblHoneyInHiveLabel.AutoSize = true;
            this.lblHoneyInHiveLabel.Location = new System.Drawing.Point(3, 58);
            this.lblHoneyInHiveLabel.Name = "lblHoneyInHiveLabel";
            this.lblHoneyInHiveLabel.Size = new System.Drawing.Size(122, 13);
            this.lblHoneyInHiveLabel.TabIndex = 2;
            this.lblHoneyInHiveLabel.Text = "Total de mel na colméia:";
            // 
            // lblNectarInFlowersLabel
            // 
            this.lblNectarInFlowersLabel.AutoSize = true;
            this.lblNectarInFlowersLabel.Location = new System.Drawing.Point(3, 87);
            this.lblNectarInFlowersLabel.Name = "lblNectarInFlowersLabel";
            this.lblNectarInFlowersLabel.Size = new System.Drawing.Size(132, 13);
            this.lblNectarInFlowersLabel.TabIndex = 3;
            this.lblNectarInFlowersLabel.Text = "Total de néctar no campo:";
            // 
            // lblFramesRunLabel
            // 
            this.lblFramesRunLabel.AutoSize = true;
            this.lblFramesRunLabel.Location = new System.Drawing.Point(3, 116);
            this.lblFramesRunLabel.Name = "lblFramesRunLabel";
            this.lblFramesRunLabel.Size = new System.Drawing.Size(160, 13);
            this.lblFramesRunLabel.TabIndex = 4;
            this.lblFramesRunLabel.Text = "Quadros de tempo transcorridos:";
            // 
            // lblFrameRateLabel
            // 
            this.lblFrameRateLabel.AutoSize = true;
            this.lblFrameRateLabel.Location = new System.Drawing.Point(3, 145);
            this.lblFrameRateLabel.Name = "lblFrameRateLabel";
            this.lblFrameRateLabel.Size = new System.Drawing.Size(169, 13);
            this.lblFrameRateLabel.TabIndex = 5;
            this.lblFrameRateLabel.Text = "Taxa de Passagem de Quadros/s:";
            // 
            // lblBees
            // 
            this.lblBees.AutoSize = true;
            this.lblBees.Location = new System.Drawing.Point(201, 0);
            this.lblBees.Name = "lblBees";
            this.lblBees.Size = new System.Drawing.Size(31, 13);
            this.lblBees.TabIndex = 6;
            this.lblBees.Text = "Bees";
            // 
            // lblFlowers
            // 
            this.lblFlowers.AutoSize = true;
            this.lblFlowers.Location = new System.Drawing.Point(201, 29);
            this.lblFlowers.Name = "lblFlowers";
            this.lblFlowers.Size = new System.Drawing.Size(43, 13);
            this.lblFlowers.TabIndex = 7;
            this.lblFlowers.Text = "Flowers";
            // 
            // lblHoneyInHive
            // 
            this.lblHoneyInHive.AutoSize = true;
            this.lblHoneyInHive.Location = new System.Drawing.Point(201, 58);
            this.lblHoneyInHive.Name = "lblHoneyInHive";
            this.lblHoneyInHive.Size = new System.Drawing.Size(69, 13);
            this.lblHoneyInHive.TabIndex = 8;
            this.lblHoneyInHive.Text = "HoneyInHive";
            // 
            // lblNectarInFlowers
            // 
            this.lblNectarInFlowers.AutoSize = true;
            this.lblNectarInFlowers.Location = new System.Drawing.Point(201, 87);
            this.lblNectarInFlowers.Name = "lblNectarInFlowers";
            this.lblNectarInFlowers.Size = new System.Drawing.Size(84, 13);
            this.lblNectarInFlowers.TabIndex = 9;
            this.lblNectarInFlowers.Text = "NectarInFlowers";
            // 
            // lblFramesRun
            // 
            this.lblFramesRun.AutoSize = true;
            this.lblFramesRun.Location = new System.Drawing.Point(201, 116);
            this.lblFramesRun.Name = "lblFramesRun";
            this.lblFramesRun.Size = new System.Drawing.Size(61, 13);
            this.lblFramesRun.TabIndex = 10;
            this.lblFramesRun.Text = "FramesRun";
            // 
            // lblFrameRate
            // 
            this.lblFrameRate.AutoSize = true;
            this.lblFrameRate.Location = new System.Drawing.Point(201, 145);
            this.lblFrameRate.Name = "lblFrameRate";
            this.lblFrameRate.Size = new System.Drawing.Size(59, 13);
            this.lblFrameRate.TabIndex = 11;
            this.lblFrameRate.Text = "FrameRate";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 223);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ssStatusbar);
            this.Controls.Add(this.tsToolbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Simulador de Colméia";
            this.tsToolbar.ResumeLayout(false);
            this.tsToolbar.PerformLayout();
            this.ssStatusbar.ResumeLayout(false);
            this.ssStatusbar.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsToolbar;
        private System.Windows.Forms.StatusStrip ssStatusbar;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblBeesLabel;
        private System.Windows.Forms.Label lblFlowersLabel;
        private System.Windows.Forms.Label lblHoneyInHiveLabel;
        private System.Windows.Forms.Label lblNectarInFlowersLabel;
        private System.Windows.Forms.Label lblFramesRunLabel;
        private System.Windows.Forms.Label lblFrameRateLabel;
        private System.Windows.Forms.Label lblBees;
        private System.Windows.Forms.Label lblFlowers;
        private System.Windows.Forms.Label lblHoneyInHive;
        private System.Windows.Forms.Label lblNectarInFlowers;
        private System.Windows.Forms.Label lblFramesRun;
        private System.Windows.Forms.Label lblFrameRate;
    }
}

