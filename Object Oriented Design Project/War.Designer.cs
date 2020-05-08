namespace Object_Oriented_Design_Project
{
    partial class War
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
            this.CardsInHand = new System.Windows.Forms.TextBox();
            this.WarExit = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeDeckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eyesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goldenFlowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.owlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snakesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redSnakesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerCard = new System.Windows.Forms.PictureBox();
            this.dealerCard = new System.Windows.Forms.PictureBox();
            this.pWar1 = new System.Windows.Forms.PictureBox();
            this.pWar2 = new System.Windows.Forms.PictureBox();
            this.pWar3 = new System.Windows.Forms.PictureBox();
            this.pWarBattle = new System.Windows.Forms.PictureBox();
            this.dWar1 = new System.Windows.Forms.PictureBox();
            this.dWar2 = new System.Windows.Forms.PictureBox();
            this.dWar3 = new System.Windows.Forms.PictureBox();
            this.dWarBattle = new System.Windows.Forms.PictureBox();
            this.btnBattle = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pWar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pWar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pWar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pWarBattle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dWar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dWar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dWar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dWarBattle)).BeginInit();
            this.SuspendLayout();
            // 
            // CardsInHand
            // 
            this.CardsInHand.BackColor = System.Drawing.Color.OliveDrab;
            this.CardsInHand.Location = new System.Drawing.Point(17, 806);
            this.CardsInHand.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CardsInHand.Name = "CardsInHand";
            this.CardsInHand.Size = new System.Drawing.Size(257, 39);
            this.CardsInHand.TabIndex = 0;
            this.CardsInHand.TabStop = false;
            this.CardsInHand.Text = "Cards in hand:";
            // 
            // WarExit
            // 
            this.WarExit.BackColor = System.Drawing.Color.OliveDrab;
            this.WarExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.WarExit.Location = new System.Drawing.Point(1502, 806);
            this.WarExit.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.WarExit.Name = "WarExit";
            this.WarExit.Size = new System.Drawing.Size(65, 39);
            this.WarExit.TabIndex = 1;
            this.WarExit.TabStop = false;
            this.WarExit.Text = "EXIT";
            this.WarExit.Click += new System.EventHandler(this.WarExit_Click);
            this.WarExit.MouseEnter += new System.EventHandler(this.WarExit_MouseEnter);
            this.WarExit.MouseLeave += new System.EventHandler(this.WarExit_MouseLeave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1584, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem1,
            this.changeDeckToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.newGameToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem1
            // 
            this.newGameToolStripMenuItem1.Name = "newGameToolStripMenuItem1";
            this.newGameToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.newGameToolStripMenuItem1.Text = "New Game";
            this.newGameToolStripMenuItem1.Click += new System.EventHandler(this.newGameToolStripMenuItem1_Click);
            // 
            // changeDeckToolStripMenuItem
            // 
            this.changeDeckToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.eyesToolStripMenuItem,
            this.goldenFlowerToolStripMenuItem,
            this.owlsToolStripMenuItem,
            this.snakesToolStripMenuItem,
            this.redSnakesToolStripMenuItem});
            this.changeDeckToolStripMenuItem.Name = "changeDeckToolStripMenuItem";
            this.changeDeckToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.changeDeckToolStripMenuItem.Text = "Change Deck";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // eyesToolStripMenuItem
            // 
            this.eyesToolStripMenuItem.Name = "eyesToolStripMenuItem";
            this.eyesToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.eyesToolStripMenuItem.Text = "Eyes";
            this.eyesToolStripMenuItem.Click += new System.EventHandler(this.eyesToolStripMenuItem_Click);
            // 
            // goldenFlowerToolStripMenuItem
            // 
            this.goldenFlowerToolStripMenuItem.Name = "goldenFlowerToolStripMenuItem";
            this.goldenFlowerToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.goldenFlowerToolStripMenuItem.Text = "Golden Flower";
            this.goldenFlowerToolStripMenuItem.Click += new System.EventHandler(this.goldenFlowerToolStripMenuItem_Click);
            // 
            // owlsToolStripMenuItem
            // 
            this.owlsToolStripMenuItem.Name = "owlsToolStripMenuItem";
            this.owlsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.owlsToolStripMenuItem.Text = "Owls";
            this.owlsToolStripMenuItem.Click += new System.EventHandler(this.owlsToolStripMenuItem_Click);
            // 
            // snakesToolStripMenuItem
            // 
            this.snakesToolStripMenuItem.Name = "snakesToolStripMenuItem";
            this.snakesToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.snakesToolStripMenuItem.Text = "Snakes";
            this.snakesToolStripMenuItem.Click += new System.EventHandler(this.snakesToolStripMenuItem_Click);
            // 
            // redSnakesToolStripMenuItem
            // 
            this.redSnakesToolStripMenuItem.Name = "redSnakesToolStripMenuItem";
            this.redSnakesToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.redSnakesToolStripMenuItem.Text = "Red Snakes";
            this.redSnakesToolStripMenuItem.Click += new System.EventHandler(this.redSnakesToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.WarExit_Click);
            // 
            // playerCard
            // 
            this.playerCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerCard.BackColor = System.Drawing.Color.White;
            this.playerCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerCard.Location = new System.Drawing.Point(489, 202);
            this.playerCard.Name = "playerCard";
            this.playerCard.Size = new System.Drawing.Size(222, 323);
            this.playerCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerCard.TabIndex = 3;
            this.playerCard.TabStop = false;
            // 
            // dealerCard
            // 
            this.dealerCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dealerCard.BackColor = System.Drawing.Color.White;
            this.dealerCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dealerCard.Location = new System.Drawing.Point(827, 202);
            this.dealerCard.Name = "dealerCard";
            this.dealerCard.Size = new System.Drawing.Size(222, 323);
            this.dealerCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dealerCard.TabIndex = 4;
            this.dealerCard.TabStop = false;
            // 
            // pWar1
            // 
            this.pWar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pWar1.BackColor = System.Drawing.Color.White;
            this.pWar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pWar1.Location = new System.Drawing.Point(12, 404);
            this.pWar1.Name = "pWar1";
            this.pWar1.Size = new System.Drawing.Size(222, 323);
            this.pWar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pWar1.TabIndex = 5;
            this.pWar1.TabStop = false;
            this.pWar1.Visible = false;
            // 
            // pWar2
            // 
            this.pWar2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pWar2.BackColor = System.Drawing.Color.White;
            this.pWar2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pWar2.Location = new System.Drawing.Point(52, 327);
            this.pWar2.Name = "pWar2";
            this.pWar2.Size = new System.Drawing.Size(222, 323);
            this.pWar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pWar2.TabIndex = 6;
            this.pWar2.TabStop = false;
            this.pWar2.Visible = false;
            // 
            // pWar3
            // 
            this.pWar3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pWar3.BackColor = System.Drawing.Color.White;
            this.pWar3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pWar3.Location = new System.Drawing.Point(105, 248);
            this.pWar3.Name = "pWar3";
            this.pWar3.Size = new System.Drawing.Size(222, 323);
            this.pWar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pWar3.TabIndex = 7;
            this.pWar3.TabStop = false;
            this.pWar3.Visible = false;
            // 
            // pWarBattle
            // 
            this.pWarBattle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pWarBattle.BackColor = System.Drawing.Color.White;
            this.pWarBattle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pWarBattle.Location = new System.Drawing.Point(164, 157);
            this.pWarBattle.Name = "pWarBattle";
            this.pWarBattle.Size = new System.Drawing.Size(222, 323);
            this.pWarBattle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pWarBattle.TabIndex = 8;
            this.pWarBattle.TabStop = false;
            this.pWarBattle.Visible = false;
            // 
            // dWar1
            // 
            this.dWar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dWar1.BackColor = System.Drawing.Color.White;
            this.dWar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dWar1.Location = new System.Drawing.Point(1350, 404);
            this.dWar1.Name = "dWar1";
            this.dWar1.Size = new System.Drawing.Size(222, 323);
            this.dWar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dWar1.TabIndex = 9;
            this.dWar1.TabStop = false;
            this.dWar1.Visible = false;
            // 
            // dWar2
            // 
            this.dWar2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dWar2.BackColor = System.Drawing.Color.White;
            this.dWar2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dWar2.Location = new System.Drawing.Point(1312, 327);
            this.dWar2.Name = "dWar2";
            this.dWar2.Size = new System.Drawing.Size(222, 323);
            this.dWar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dWar2.TabIndex = 10;
            this.dWar2.TabStop = false;
            this.dWar2.Visible = false;
            // 
            // dWar3
            // 
            this.dWar3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dWar3.BackColor = System.Drawing.Color.White;
            this.dWar3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dWar3.Location = new System.Drawing.Point(1248, 248);
            this.dWar3.Name = "dWar3";
            this.dWar3.Size = new System.Drawing.Size(222, 323);
            this.dWar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dWar3.TabIndex = 11;
            this.dWar3.TabStop = false;
            this.dWar3.Visible = false;
            // 
            // dWarBattle
            // 
            this.dWarBattle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dWarBattle.BackColor = System.Drawing.Color.White;
            this.dWarBattle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dWarBattle.Location = new System.Drawing.Point(1179, 157);
            this.dWarBattle.Name = "dWarBattle";
            this.dWarBattle.Size = new System.Drawing.Size(222, 323);
            this.dWarBattle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dWarBattle.TabIndex = 12;
            this.dWarBattle.TabStop = false;
            this.dWarBattle.Visible = false;
            // 
            // btnBattle
            // 
            this.btnBattle.BackColor = System.Drawing.Color.OliveDrab;
            this.btnBattle.Location = new System.Drawing.Point(674, 638);
            this.btnBattle.Name = "btnBattle";
            this.btnBattle.Size = new System.Drawing.Size(207, 54);
            this.btnBattle.TabIndex = 13;
            this.btnBattle.Text = "Battle!";
            this.btnBattle.UseVisualStyleBackColor = false;
            this.btnBattle.Click += new System.EventHandler(this.battleClick);
            this.btnBattle.MouseEnter += new System.EventHandler(this.btnBattle_MouseEnter);
            this.btnBattle.MouseLeave += new System.EventHandler(this.btnBattle_MouseLeave);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.titleLabel.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(707, 42);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(128, 57);
            this.titleLabel.TabIndex = 14;
            this.titleLabel.Text = "WAR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Player:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(880, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Dealer:";
            // 
            // War
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.btnBattle);
            this.Controls.Add(this.dWarBattle);
            this.Controls.Add(this.dWar3);
            this.Controls.Add(this.dWar2);
            this.Controls.Add(this.dWar1);
            this.Controls.Add(this.pWarBattle);
            this.Controls.Add(this.pWar3);
            this.Controls.Add(this.pWar2);
            this.Controls.Add(this.pWar1);
            this.Controls.Add(this.dealerCard);
            this.Controls.Add(this.playerCard);
            this.Controls.Add(this.WarExit);
            this.Controls.Add(this.CardsInHand);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "War";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "War: The Card Game";
            this.Load += new System.EventHandler(this.War_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pWar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pWar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pWar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pWarBattle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dWar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dWar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dWar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dWarBattle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CardsInHand;
        private System.Windows.Forms.TextBox WarExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changeDeckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eyesToolStripMenuItem;
        private System.Windows.Forms.PictureBox playerCard;
        private System.Windows.Forms.PictureBox dealerCard;
        private System.Windows.Forms.PictureBox pWar1;
        private System.Windows.Forms.PictureBox pWar2;
        private System.Windows.Forms.PictureBox pWar3;
        private System.Windows.Forms.PictureBox pWarBattle;
        private System.Windows.Forms.PictureBox dWar1;
        private System.Windows.Forms.PictureBox dWar2;
        private System.Windows.Forms.PictureBox dWar3;
        private System.Windows.Forms.PictureBox dWarBattle;
        private System.Windows.Forms.Button btnBattle;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goldenFlowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem owlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snakesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redSnakesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}