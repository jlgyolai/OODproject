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
            this.changeThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeholderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CardsInHand
            // 
            this.CardsInHand.BackColor = System.Drawing.Color.OliveDrab;
            this.CardsInHand.Location = new System.Drawing.Point(8, 683);
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
            this.WarExit.Location = new System.Drawing.Point(939, 683);
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
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem1,
            this.changeDeckToolStripMenuItem,
            this.changeThemeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.newGameToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem1
            // 
            this.newGameToolStripMenuItem1.Name = "newGameToolStripMenuItem1";
            this.newGameToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem1.Text = "New Game";
            // 
            // changeDeckToolStripMenuItem
            // 
            this.changeDeckToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.placeholderToolStripMenuItem});
            this.changeDeckToolStripMenuItem.Name = "changeDeckToolStripMenuItem";
            this.changeDeckToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeDeckToolStripMenuItem.Text = "Change Deck";
            // 
            // changeThemeToolStripMenuItem
            // 
            this.changeThemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultThemeToolStripMenuItem,
            this.darkModeToolStripMenuItem});
            this.changeThemeToolStripMenuItem.Name = "changeThemeToolStripMenuItem";
            this.changeThemeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeThemeToolStripMenuItem.Text = "Change Theme";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.WarExit_Click);
            // 
            // defaultThemeToolStripMenuItem
            // 
            this.defaultThemeToolStripMenuItem.Name = "defaultThemeToolStripMenuItem";
            this.defaultThemeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.defaultThemeToolStripMenuItem.Text = "Default Theme";
            // 
            // darkModeToolStripMenuItem
            // 
            this.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            this.darkModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.darkModeToolStripMenuItem.Text = "Dark Mode";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            // 
            // placeholderToolStripMenuItem
            // 
            this.placeholderToolStripMenuItem.Name = "placeholderToolStripMenuItem";
            this.placeholderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.placeholderToolStripMenuItem.Text = "Placeholder";
            // 
            // War
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.WarExit);
            this.Controls.Add(this.CardsInHand);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "War";
            this.Text = "War: The Card Game";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem changeThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeholderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkModeToolStripMenuItem;
    }
}