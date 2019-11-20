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
            this.tsbtnOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnStartSimulation = new System.Windows.Forms.ToolStripButton();
            this.tsbtnReset = new System.Windows.Forms.ToolStripButton();
            this.ssStatusbar = new System.Windows.Forms.StatusStrip();
            this.sslblSimulationStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
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
            this.lstReport = new System.Windows.Forms.ListBox();
            this.sfdSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.tsToolbar.SuspendLayout();
            this.ssStatusbar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsToolbar
            // 
            this.tsToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnOpen,
            this.tsbtnSave,
            this.toolStripSeparator1,
            this.tsbtnStartSimulation,
            this.tsbtnReset});
            this.tsToolbar.Location = new System.Drawing.Point(0, 0);
            this.tsToolbar.Name = "tsToolbar";
            this.tsToolbar.Size = new System.Drawing.Size(386, 25);
            this.tsToolbar.TabIndex = 0;
            this.tsToolbar.Text = "toolStrip1";
            // 
            // tsbtnOpen
            // 
            this.tsbtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnOpen.Image")));
            this.tsbtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnOpen.Name = "tsbtnOpen";
            this.tsbtnOpen.Size = new System.Drawing.Size(23, 22);
            this.tsbtnOpen.Text = "toolStripButton2";
            this.tsbtnOpen.ToolTipText = "Abrir";
            this.tsbtnOpen.Click += new System.EventHandler(this.TsbtnOpen_Click);
            // 
            // tsbtnSave
            // 
            this.tsbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSave.Image")));
            this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSave.Name = "tsbtnSave";
            this.tsbtnSave.Size = new System.Drawing.Size(23, 22);
            this.tsbtnSave.Text = "toolStripButton1";
            this.tsbtnSave.ToolTipText = "Salvar";
            this.tsbtnSave.Click += new System.EventHandler(this.TsbtnSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnStartSimulation
            // 
            this.tsbtnStartSimulation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnStartSimulation.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnStartSimulation.Image")));
            this.tsbtnStartSimulation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStartSimulation.Name = "tsbtnStartSimulation";
            this.tsbtnStartSimulation.Size = new System.Drawing.Size(101, 22);
            this.tsbtnStartSimulation.Text = "Iniciar Simulação";
            this.tsbtnStartSimulation.Click += new System.EventHandler(this.TsbtnStartSimulation_Click);
            // 
            // tsbtnReset
            // 
            this.tsbtnReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnReset.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnReset.Image")));
            this.tsbtnReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnReset.Name = "tsbtnReset";
            this.tsbtnReset.Size = new System.Drawing.Size(56, 22);
            this.tsbtnReset.Text = "Reiniciar";
            this.tsbtnReset.Click += new System.EventHandler(this.TsbtnReset_Click);
            // 
            // ssStatusbar
            // 
            this.ssStatusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslblSimulationStatus});
            this.ssStatusbar.Location = new System.Drawing.Point(0, 346);
            this.ssStatusbar.Name = "ssStatusbar";
            this.ssStatusbar.Size = new System.Drawing.Size(386, 22);
            this.ssStatusbar.TabIndex = 1;
            this.ssStatusbar.Text = "statusStrip1";
            // 
            // sslblSimulationStatus
            // 
            this.sslblSimulationStatus.Name = "sslblSimulationStatus";
            this.sslblSimulationStatus.Size = new System.Drawing.Size(119, 17);
            this.sslblSimulationStatus.Text = "Simulação em Pausa.";
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(386, 176);
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
            this.lblBees.Location = new System.Drawing.Point(196, 0);
            this.lblBees.Name = "lblBees";
            this.lblBees.Size = new System.Drawing.Size(31, 13);
            this.lblBees.TabIndex = 6;
            this.lblBees.Text = "Bees";
            // 
            // lblFlowers
            // 
            this.lblFlowers.AutoSize = true;
            this.lblFlowers.Location = new System.Drawing.Point(196, 29);
            this.lblFlowers.Name = "lblFlowers";
            this.lblFlowers.Size = new System.Drawing.Size(43, 13);
            this.lblFlowers.TabIndex = 7;
            this.lblFlowers.Text = "Flowers";
            // 
            // lblHoneyInHive
            // 
            this.lblHoneyInHive.AutoSize = true;
            this.lblHoneyInHive.Location = new System.Drawing.Point(196, 58);
            this.lblHoneyInHive.Name = "lblHoneyInHive";
            this.lblHoneyInHive.Size = new System.Drawing.Size(69, 13);
            this.lblHoneyInHive.TabIndex = 8;
            this.lblHoneyInHive.Text = "HoneyInHive";
            // 
            // lblNectarInFlowers
            // 
            this.lblNectarInFlowers.AutoSize = true;
            this.lblNectarInFlowers.Location = new System.Drawing.Point(196, 87);
            this.lblNectarInFlowers.Name = "lblNectarInFlowers";
            this.lblNectarInFlowers.Size = new System.Drawing.Size(84, 13);
            this.lblNectarInFlowers.TabIndex = 9;
            this.lblNectarInFlowers.Text = "NectarInFlowers";
            // 
            // lblFramesRun
            // 
            this.lblFramesRun.AutoSize = true;
            this.lblFramesRun.Location = new System.Drawing.Point(196, 116);
            this.lblFramesRun.Name = "lblFramesRun";
            this.lblFramesRun.Size = new System.Drawing.Size(61, 13);
            this.lblFramesRun.TabIndex = 10;
            this.lblFramesRun.Text = "FramesRun";
            // 
            // lblFrameRate
            // 
            this.lblFrameRate.AutoSize = true;
            this.lblFrameRate.Location = new System.Drawing.Point(196, 145);
            this.lblFrameRate.Name = "lblFrameRate";
            this.lblFrameRate.Size = new System.Drawing.Size(59, 13);
            this.lblFrameRate.TabIndex = 11;
            this.lblFrameRate.Text = "FrameRate";
            // 
            // lstReport
            // 
            this.lstReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstReport.FormattingEnabled = true;
            this.lstReport.Location = new System.Drawing.Point(0, 199);
            this.lstReport.Margin = new System.Windows.Forms.Padding(10);
            this.lstReport.Name = "lstReport";
            this.lstReport.Size = new System.Drawing.Size(386, 147);
            this.lstReport.TabIndex = 3;
            // 
            // sfdSaveFile
            // 
            this.sfdSaveFile.FileName = "Colmeia.bee";
            this.sfdSaveFile.Filter = "Arquivos de colméia (*.bee)|*.bee|Todos os arquivos (*.*)|*.*";
            this.sfdSaveFile.Title = "Salvar Colméia";
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "Colmeia.bee";
            this.ofdOpenFile.Filter = "Arquivos de colméia (*.bee)|*.bee|Todos os arquivos (*.*)|*.*";
            this.ofdOpenFile.Title = "Carregar Colméia";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 368);
            this.Controls.Add(this.lstReport);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ssStatusbar);
            this.Controls.Add(this.tsToolbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
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
        private System.Windows.Forms.ToolStripButton tsbtnStartSimulation;
        private System.Windows.Forms.ToolStripButton tsbtnReset;
        private System.Windows.Forms.ToolStripStatusLabel sslblSimulationStatus;
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
        private System.Windows.Forms.ListBox lstReport;
        private System.Windows.Forms.SaveFileDialog sfdSaveFile;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.ToolStripButton tsbtnOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

