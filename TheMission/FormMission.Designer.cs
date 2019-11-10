namespace TheMission
{
    partial class FormMission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMission));
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picSword = new System.Windows.Forms.PictureBox();
            this.picBat = new System.Windows.Forms.PictureBox();
            this.picGhoul = new System.Windows.Forms.PictureBox();
            this.picGhost = new System.Windows.Forms.PictureBox();
            this.picBow = new System.Windows.Forms.PictureBox();
            this.picBluePotion = new System.Windows.Forms.PictureBox();
            this.picRedPotion = new System.Windows.Forms.PictureBox();
            this.picMace = new System.Windows.Forms.PictureBox();
            this.picMaceWeapon = new System.Windows.Forms.PictureBox();
            this.picRedPotionWeapon = new System.Windows.Forms.PictureBox();
            this.picBluePotionWeapon = new System.Windows.Forms.PictureBox();
            this.picBowWeapon = new System.Windows.Forms.PictureBox();
            this.picSwordWeapon = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblGhoulHitPoints = new System.Windows.Forms.Label();
            this.lblGhoul = new System.Windows.Forms.Label();
            this.lblGhostHitPoints = new System.Windows.Forms.Label();
            this.lblGhost = new System.Windows.Forms.Label();
            this.lblBatHitPoints = new System.Windows.Forms.Label();
            this.lblBat = new System.Windows.Forms.Label();
            this.lblPlayerHitPoints = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblMove = new System.Windows.Forms.Label();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnAttackDown = new System.Windows.Forms.Button();
            this.btnAttackRight = new System.Windows.Forms.Button();
            this.btnAttackLeft = new System.Windows.Forms.Button();
            this.btnAttackUp = new System.Windows.Forms.Button();
            this.lblAttack = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGhoul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaceWeapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedPotionWeapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBluePotionWeapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBowWeapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSwordWeapon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.Image = global::TheMission.Properties.Resources.player;
            this.picPlayer.Location = new System.Drawing.Point(81, 61);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(30, 30);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // picSword
            // 
            this.picSword.BackColor = System.Drawing.Color.Transparent;
            this.picSword.Image = global::TheMission.Properties.Resources.sword;
            this.picSword.Location = new System.Drawing.Point(117, 61);
            this.picSword.Name = "picSword";
            this.picSword.Size = new System.Drawing.Size(30, 30);
            this.picSword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSword.TabIndex = 1;
            this.picSword.TabStop = false;
            this.picSword.Visible = false;
            // 
            // picBat
            // 
            this.picBat.BackColor = System.Drawing.Color.Transparent;
            this.picBat.Image = global::TheMission.Properties.Resources.bat;
            this.picBat.Location = new System.Drawing.Point(153, 61);
            this.picBat.Name = "picBat";
            this.picBat.Size = new System.Drawing.Size(30, 30);
            this.picBat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBat.TabIndex = 2;
            this.picBat.TabStop = false;
            this.picBat.Visible = false;
            // 
            // picGhoul
            // 
            this.picGhoul.BackColor = System.Drawing.Color.Transparent;
            this.picGhoul.Image = global::TheMission.Properties.Resources.ghoul;
            this.picGhoul.Location = new System.Drawing.Point(189, 61);
            this.picGhoul.Name = "picGhoul";
            this.picGhoul.Size = new System.Drawing.Size(30, 30);
            this.picGhoul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGhoul.TabIndex = 3;
            this.picGhoul.TabStop = false;
            this.picGhoul.Visible = false;
            // 
            // picGhost
            // 
            this.picGhost.BackColor = System.Drawing.Color.Transparent;
            this.picGhost.Image = global::TheMission.Properties.Resources.ghost;
            this.picGhost.Location = new System.Drawing.Point(225, 61);
            this.picGhost.Name = "picGhost";
            this.picGhost.Size = new System.Drawing.Size(30, 30);
            this.picGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGhost.TabIndex = 4;
            this.picGhost.TabStop = false;
            this.picGhost.Visible = false;
            // 
            // picBow
            // 
            this.picBow.BackColor = System.Drawing.Color.Transparent;
            this.picBow.Image = global::TheMission.Properties.Resources.bow;
            this.picBow.Location = new System.Drawing.Point(261, 61);
            this.picBow.Name = "picBow";
            this.picBow.Size = new System.Drawing.Size(30, 30);
            this.picBow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBow.TabIndex = 5;
            this.picBow.TabStop = false;
            this.picBow.Visible = false;
            // 
            // picBluePotion
            // 
            this.picBluePotion.BackColor = System.Drawing.Color.Transparent;
            this.picBluePotion.Image = global::TheMission.Properties.Resources.potion_blue;
            this.picBluePotion.Location = new System.Drawing.Point(297, 61);
            this.picBluePotion.Name = "picBluePotion";
            this.picBluePotion.Size = new System.Drawing.Size(30, 30);
            this.picBluePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBluePotion.TabIndex = 6;
            this.picBluePotion.TabStop = false;
            this.picBluePotion.Visible = false;
            // 
            // picRedPotion
            // 
            this.picRedPotion.BackColor = System.Drawing.Color.Transparent;
            this.picRedPotion.Image = global::TheMission.Properties.Resources.potion_red;
            this.picRedPotion.Location = new System.Drawing.Point(333, 61);
            this.picRedPotion.Name = "picRedPotion";
            this.picRedPotion.Size = new System.Drawing.Size(30, 30);
            this.picRedPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRedPotion.TabIndex = 7;
            this.picRedPotion.TabStop = false;
            this.picRedPotion.Visible = false;
            // 
            // picMace
            // 
            this.picMace.BackColor = System.Drawing.Color.Transparent;
            this.picMace.Image = global::TheMission.Properties.Resources.mace;
            this.picMace.Location = new System.Drawing.Point(369, 61);
            this.picMace.Name = "picMace";
            this.picMace.Size = new System.Drawing.Size(30, 30);
            this.picMace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMace.TabIndex = 8;
            this.picMace.TabStop = false;
            this.picMace.Visible = false;
            // 
            // picMaceWeapon
            // 
            this.picMaceWeapon.BackColor = System.Drawing.Color.Transparent;
            this.picMaceWeapon.Image = global::TheMission.Properties.Resources.mace;
            this.picMaceWeapon.Location = new System.Drawing.Point(305, 319);
            this.picMaceWeapon.Name = "picMaceWeapon";
            this.picMaceWeapon.Size = new System.Drawing.Size(50, 50);
            this.picMaceWeapon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMaceWeapon.TabIndex = 13;
            this.picMaceWeapon.TabStop = false;
            this.picMaceWeapon.Visible = false;
            this.picMaceWeapon.Click += new System.EventHandler(this.PicMaceWeapon_Click);
            // 
            // picRedPotionWeapon
            // 
            this.picRedPotionWeapon.BackColor = System.Drawing.Color.Transparent;
            this.picRedPotionWeapon.Image = global::TheMission.Properties.Resources.potion_red;
            this.picRedPotionWeapon.Location = new System.Drawing.Point(249, 319);
            this.picRedPotionWeapon.Name = "picRedPotionWeapon";
            this.picRedPotionWeapon.Size = new System.Drawing.Size(50, 50);
            this.picRedPotionWeapon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRedPotionWeapon.TabIndex = 12;
            this.picRedPotionWeapon.TabStop = false;
            this.picRedPotionWeapon.Visible = false;
            this.picRedPotionWeapon.Click += new System.EventHandler(this.PicRedPotionWeapon_Click);
            // 
            // picBluePotionWeapon
            // 
            this.picBluePotionWeapon.BackColor = System.Drawing.Color.Transparent;
            this.picBluePotionWeapon.Image = global::TheMission.Properties.Resources.potion_blue;
            this.picBluePotionWeapon.Location = new System.Drawing.Point(193, 319);
            this.picBluePotionWeapon.Name = "picBluePotionWeapon";
            this.picBluePotionWeapon.Size = new System.Drawing.Size(50, 50);
            this.picBluePotionWeapon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBluePotionWeapon.TabIndex = 11;
            this.picBluePotionWeapon.TabStop = false;
            this.picBluePotionWeapon.Visible = false;
            this.picBluePotionWeapon.Click += new System.EventHandler(this.PicBluePotionWeapon_Click);
            // 
            // picBowWeapon
            // 
            this.picBowWeapon.BackColor = System.Drawing.Color.Transparent;
            this.picBowWeapon.Image = global::TheMission.Properties.Resources.bow;
            this.picBowWeapon.Location = new System.Drawing.Point(137, 319);
            this.picBowWeapon.Name = "picBowWeapon";
            this.picBowWeapon.Size = new System.Drawing.Size(50, 50);
            this.picBowWeapon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBowWeapon.TabIndex = 10;
            this.picBowWeapon.TabStop = false;
            this.picBowWeapon.Visible = false;
            this.picBowWeapon.Click += new System.EventHandler(this.PicBowWeapon_Click);
            // 
            // picSwordWeapon
            // 
            this.picSwordWeapon.BackColor = System.Drawing.Color.Transparent;
            this.picSwordWeapon.Image = global::TheMission.Properties.Resources.sword;
            this.picSwordWeapon.Location = new System.Drawing.Point(81, 319);
            this.picSwordWeapon.Name = "picSwordWeapon";
            this.picSwordWeapon.Size = new System.Drawing.Size(50, 50);
            this.picSwordWeapon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSwordWeapon.TabIndex = 9;
            this.picSwordWeapon.TabStop = false;
            this.picSwordWeapon.Visible = false;
            this.picSwordWeapon.Click += new System.EventHandler(this.PicSwordWeapon_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.lblGhoulHitPoints, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblGhoul, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblGhostHitPoints, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblGhost, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblBatHitPoints, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBat, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPlayerHitPoints, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPlayer, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(615, 225);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(173, 160);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // lblGhoulHitPoints
            // 
            this.lblGhoulHitPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGhoulHitPoints.AutoSize = true;
            this.lblGhoulHitPoints.Location = new System.Drawing.Point(63, 133);
            this.lblGhoulHitPoints.Name = "lblGhoulHitPoints";
            this.lblGhoulHitPoints.Size = new System.Drawing.Size(56, 13);
            this.lblGhoulHitPoints.TabIndex = 7;
            this.lblGhoulHitPoints.Text = "vidaZumbi";
            // 
            // lblGhoul
            // 
            this.lblGhoul.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGhoul.AutoSize = true;
            this.lblGhoul.Location = new System.Drawing.Point(21, 133);
            this.lblGhoul.Name = "lblGhoul";
            this.lblGhoul.Size = new System.Drawing.Size(36, 13);
            this.lblGhoul.TabIndex = 6;
            this.lblGhoul.Text = "Zumbi";
            this.lblGhoul.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGhostHitPoints
            // 
            this.lblGhostHitPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGhostHitPoints.AutoSize = true;
            this.lblGhostHitPoints.Location = new System.Drawing.Point(63, 93);
            this.lblGhostHitPoints.Name = "lblGhostHitPoints";
            this.lblGhostHitPoints.Size = new System.Drawing.Size(73, 13);
            this.lblGhostHitPoints.TabIndex = 5;
            this.lblGhostHitPoints.Text = "vidaFantasma";
            // 
            // lblGhost
            // 
            this.lblGhost.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGhost.AutoSize = true;
            this.lblGhost.Location = new System.Drawing.Point(4, 93);
            this.lblGhost.Name = "lblGhost";
            this.lblGhost.Size = new System.Drawing.Size(53, 13);
            this.lblGhost.TabIndex = 4;
            this.lblGhost.Text = "Fantasma";
            this.lblGhost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBatHitPoints
            // 
            this.lblBatHitPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBatHitPoints.AutoSize = true;
            this.lblBatHitPoints.Location = new System.Drawing.Point(63, 53);
            this.lblBatHitPoints.Name = "lblBatHitPoints";
            this.lblBatHitPoints.Size = new System.Drawing.Size(69, 13);
            this.lblBatHitPoints.TabIndex = 3;
            this.lblBatHitPoints.Text = "vidaMorcego";
            // 
            // lblBat
            // 
            this.lblBat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBat.AutoSize = true;
            this.lblBat.Location = new System.Drawing.Point(8, 53);
            this.lblBat.Name = "lblBat";
            this.lblBat.Size = new System.Drawing.Size(49, 13);
            this.lblBat.TabIndex = 2;
            this.lblBat.Text = "Morcego";
            this.lblBat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlayerHitPoints
            // 
            this.lblPlayerHitPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPlayerHitPoints.AutoSize = true;
            this.lblPlayerHitPoints.Location = new System.Drawing.Point(63, 13);
            this.lblPlayerHitPoints.Name = "lblPlayerHitPoints";
            this.lblPlayerHitPoints.Size = new System.Drawing.Size(65, 13);
            this.lblPlayerHitPoints.TabIndex = 1;
            this.lblPlayerHitPoints.Text = "vidaJogador";
            // 
            // lblPlayer
            // 
            this.lblPlayer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(12, 13);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(45, 13);
            this.lblPlayer.TabIndex = 0;
            this.lblPlayer.Text = "Jogador";
            this.lblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMove
            // 
            this.lblMove.AutoSize = true;
            this.lblMove.Location = new System.Drawing.Point(622, 9);
            this.lblMove.Name = "lblMove";
            this.lblMove.Size = new System.Drawing.Size(62, 13);
            this.lblMove.TabIndex = 15;
            this.lblMove.Text = "Movimento:";
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(665, 25);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(75, 23);
            this.btnMoveUp.TabIndex = 16;
            this.btnMoveUp.Text = "Para cima";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.BtnMoveUp_Click);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(625, 54);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(75, 23);
            this.btnMoveLeft.TabIndex = 17;
            this.btnMoveLeft.Text = "Esquerda";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.BtnMoveLeft_Click);
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(706, 54);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(75, 23);
            this.btnMoveRight.TabIndex = 18;
            this.btnMoveRight.Text = "Direita";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.BtnMoveRight_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(665, 83);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(75, 23);
            this.btnMoveDown.TabIndex = 19;
            this.btnMoveDown.Text = "Para baixo";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.BtnMoveDown_Click);
            // 
            // btnAttackDown
            // 
            this.btnAttackDown.Location = new System.Drawing.Point(665, 196);
            this.btnAttackDown.Name = "btnAttackDown";
            this.btnAttackDown.Size = new System.Drawing.Size(75, 23);
            this.btnAttackDown.TabIndex = 24;
            this.btnAttackDown.Text = "Para baixo";
            this.btnAttackDown.UseVisualStyleBackColor = true;
            this.btnAttackDown.Click += new System.EventHandler(this.BtnAttackDown_Click);
            // 
            // btnAttackRight
            // 
            this.btnAttackRight.Location = new System.Drawing.Point(706, 167);
            this.btnAttackRight.Name = "btnAttackRight";
            this.btnAttackRight.Size = new System.Drawing.Size(75, 23);
            this.btnAttackRight.TabIndex = 23;
            this.btnAttackRight.Text = "Direita";
            this.btnAttackRight.UseVisualStyleBackColor = true;
            this.btnAttackRight.Click += new System.EventHandler(this.BtnAttackRight_Click);
            // 
            // btnAttackLeft
            // 
            this.btnAttackLeft.Location = new System.Drawing.Point(625, 167);
            this.btnAttackLeft.Name = "btnAttackLeft";
            this.btnAttackLeft.Size = new System.Drawing.Size(75, 23);
            this.btnAttackLeft.TabIndex = 22;
            this.btnAttackLeft.Text = "Esquerda";
            this.btnAttackLeft.UseVisualStyleBackColor = true;
            this.btnAttackLeft.Click += new System.EventHandler(this.BtnAttackLeft_Click);
            // 
            // btnAttackUp
            // 
            this.btnAttackUp.Location = new System.Drawing.Point(665, 138);
            this.btnAttackUp.Name = "btnAttackUp";
            this.btnAttackUp.Size = new System.Drawing.Size(75, 23);
            this.btnAttackUp.TabIndex = 21;
            this.btnAttackUp.Text = "Para cima";
            this.btnAttackUp.UseVisualStyleBackColor = true;
            this.btnAttackUp.Click += new System.EventHandler(this.BtnAttackUp_Click);
            // 
            // lblAttack
            // 
            this.lblAttack.AutoSize = true;
            this.lblAttack.Location = new System.Drawing.Point(622, 122);
            this.lblAttack.Name = "lblAttack";
            this.lblAttack.Size = new System.Drawing.Size(44, 13);
            this.lblAttack.TabIndex = 20;
            this.lblAttack.Text = "Ataque:";
            // 
            // FormMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheMission.Properties.Resources.dungeon600x400;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 399);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.btnAttackDown);
            this.Controls.Add(this.btnAttackRight);
            this.Controls.Add(this.btnAttackLeft);
            this.Controls.Add(this.btnAttackUp);
            this.Controls.Add(this.lblAttack);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.lblMove);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.picMaceWeapon);
            this.Controls.Add(this.picRedPotionWeapon);
            this.Controls.Add(this.picBluePotionWeapon);
            this.Controls.Add(this.picBowWeapon);
            this.Controls.Add(this.picSwordWeapon);
            this.Controls.Add(this.picRedPotion);
            this.Controls.Add(this.picBluePotion);
            this.Controls.Add(this.picGhost);
            this.Controls.Add(this.picGhoul);
            this.Controls.Add(this.picBat);
            this.Controls.Add(this.picMace);
            this.Controls.Add(this.picBow);
            this.Controls.Add(this.picSword);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMission";
            this.Text = "A Missão";
            this.Load += new System.EventHandler(this.FormMission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGhoul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaceWeapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedPotionWeapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBluePotionWeapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBowWeapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSwordWeapon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picSword;
        private System.Windows.Forms.PictureBox picBat;
        private System.Windows.Forms.PictureBox picGhoul;
        private System.Windows.Forms.PictureBox picGhost;
        private System.Windows.Forms.PictureBox picBow;
        private System.Windows.Forms.PictureBox picBluePotion;
        private System.Windows.Forms.PictureBox picRedPotion;
        private System.Windows.Forms.PictureBox picMace;
        private System.Windows.Forms.PictureBox picMaceWeapon;
        private System.Windows.Forms.PictureBox picRedPotionWeapon;
        private System.Windows.Forms.PictureBox picBluePotionWeapon;
        private System.Windows.Forms.PictureBox picBowWeapon;
        private System.Windows.Forms.PictureBox picSwordWeapon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMove;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnAttackDown;
        private System.Windows.Forms.Button btnAttackRight;
        private System.Windows.Forms.Button btnAttackLeft;
        private System.Windows.Forms.Button btnAttackUp;
        private System.Windows.Forms.Label lblAttack;
        private System.Windows.Forms.Label lblGhoulHitPoints;
        private System.Windows.Forms.Label lblGhoul;
        private System.Windows.Forms.Label lblGhostHitPoints;
        private System.Windows.Forms.Label lblGhost;
        private System.Windows.Forms.Label lblBatHitPoints;
        private System.Windows.Forms.Label lblBat;
        private System.Windows.Forms.Label lblPlayerHitPoints;
        private System.Windows.Forms.Label lblPlayer;
    }
}

