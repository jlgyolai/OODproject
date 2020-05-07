namespace Object_Oriented_Design_Project
{
    partial class TicTacToe
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
            this.TTTExit = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valleyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dirtRoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.p1w = new System.Windows.Forms.Label();
            this.p2w = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TTTExit
            // 
            this.TTTExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.TTTExit.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTTExit.Location = new System.Drawing.Point(1514, 809);
            this.TTTExit.Name = "TTTExit";
            this.TTTExit.Size = new System.Drawing.Size(58, 40);
            this.TTTExit.TabIndex = 0;
            this.TTTExit.TabStop = false;
            this.TTTExit.Text = "Exit";
            this.TTTExit.Click += new System.EventHandler(this.TTTExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.changeThemeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // changeThemeToolStripMenuItem
            // 
            this.changeThemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.lakeToolStripMenuItem,
            this.valleyToolStripMenuItem,
            this.cityToolStripMenuItem,
            this.dirtRoadToolStripMenuItem,
            this.parkToolStripMenuItem});
            this.changeThemeToolStripMenuItem.Name = "changeThemeToolStripMenuItem";
            this.changeThemeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeThemeToolStripMenuItem.Text = "Change Theme";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // lakeToolStripMenuItem
            // 
            this.lakeToolStripMenuItem.Name = "lakeToolStripMenuItem";
            this.lakeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.lakeToolStripMenuItem.Text = "Lake";
            this.lakeToolStripMenuItem.Click += new System.EventHandler(this.lakeToolStripMenuItem_Click);
            // 
            // valleyToolStripMenuItem
            // 
            this.valleyToolStripMenuItem.Name = "valleyToolStripMenuItem";
            this.valleyToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.valleyToolStripMenuItem.Text = "Valley";
            this.valleyToolStripMenuItem.Click += new System.EventHandler(this.valleyToolStripMenuItem_Click);
            // 
            // cityToolStripMenuItem
            // 
            this.cityToolStripMenuItem.Name = "cityToolStripMenuItem";
            this.cityToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.cityToolStripMenuItem.Text = "City";
            this.cityToolStripMenuItem.Click += new System.EventHandler(this.cityToolStripMenuItem_Click);
            // 
            // dirtRoadToolStripMenuItem
            // 
            this.dirtRoadToolStripMenuItem.Name = "dirtRoadToolStripMenuItem";
            this.dirtRoadToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.dirtRoadToolStripMenuItem.Text = "Dirt Road";
            this.dirtRoadToolStripMenuItem.Click += new System.EventHandler(this.dirtRoadToolStripMenuItem_Click);
            // 
            // parkToolStripMenuItem
            // 
            this.parkToolStripMenuItem.Name = "parkToolStripMenuItem";
            this.parkToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.parkToolStripMenuItem.Text = "Park";
            this.parkToolStripMenuItem.Click += new System.EventHandler(this.parkToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.TTTExit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.button9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(303, 59);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(920, 765);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.NavajoWhite;
            this.button9.Font = new System.Drawing.Font("Sitka Text", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Sienna;
            this.button9.Location = new System.Drawing.Point(615, 513);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(300, 248);
            this.button9.TabIndex = 8;
            this.button9.TabStop = false;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.btnClick);
            this.button9.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button9.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.NavajoWhite;
            this.button8.Font = new System.Drawing.Font("Sitka Text", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Sienna;
            this.button8.Location = new System.Drawing.Point(309, 513);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(300, 248);
            this.button8.TabIndex = 7;
            this.button8.TabStop = false;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.btnClick);
            this.button8.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button8.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.NavajoWhite;
            this.button7.Font = new System.Drawing.Font("Sitka Text", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Sienna;
            this.button7.Location = new System.Drawing.Point(3, 513);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(300, 248);
            this.button7.TabIndex = 6;
            this.button7.TabStop = false;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.btnClick);
            this.button7.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button7.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.NavajoWhite;
            this.button6.Font = new System.Drawing.Font("Sitka Text", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Sienna;
            this.button6.Location = new System.Drawing.Point(615, 258);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(300, 248);
            this.button6.TabIndex = 5;
            this.button6.TabStop = false;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btnClick);
            this.button6.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button6.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.NavajoWhite;
            this.button5.Font = new System.Drawing.Font("Sitka Text", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Sienna;
            this.button5.Location = new System.Drawing.Point(309, 258);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(300, 248);
            this.button5.TabIndex = 4;
            this.button5.TabStop = false;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btnClick);
            this.button5.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button5.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.NavajoWhite;
            this.button4.Font = new System.Drawing.Font("Sitka Text", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Sienna;
            this.button4.Location = new System.Drawing.Point(3, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(300, 248);
            this.button4.TabIndex = 3;
            this.button4.TabStop = false;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnClick);
            this.button4.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button4.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.NavajoWhite;
            this.button3.Font = new System.Drawing.Font("Sitka Text", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Sienna;
            this.button3.Location = new System.Drawing.Point(615, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(300, 248);
            this.button3.TabIndex = 2;
            this.button3.TabStop = false;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnClick);
            this.button3.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.NavajoWhite;
            this.button2.Font = new System.Drawing.Font("Sitka Text", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Sienna;
            this.button2.Location = new System.Drawing.Point(309, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 248);
            this.button2.TabIndex = 1;
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnClick);
            this.button2.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.NavajoWhite;
            this.button1.Font = new System.Drawing.Font("Sitka Text", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Sienna;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 248);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnClick);
            this.button1.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // p1w
            // 
            this.p1w.AutoSize = true;
            this.p1w.Font = new System.Drawing.Font("Sitka Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1w.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.p1w.Location = new System.Drawing.Point(15, 304);
            this.p1w.Name = "p1w";
            this.p1w.Size = new System.Drawing.Size(208, 39);
            this.p1w.TabIndex = 3;
            this.p1w.Text = "Player 1 Wins:";
            // 
            // p2w
            // 
            this.p2w.AutoSize = true;
            this.p2w.Font = new System.Drawing.Font("Sitka Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2w.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.p2w.Location = new System.Drawing.Point(12, 572);
            this.p2w.Name = "p2w";
            this.p2w.Size = new System.Drawing.Size(211, 39);
            this.p2w.TabIndex = 4;
            this.p2w.Text = "Player 2 Wins:";
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.p2w);
            this.Controls.Add(this.p1w);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.TTTExit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TTTExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label p1w;
        private System.Windows.Forms.Label p2w;
        private System.Windows.Forms.ToolStripMenuItem valleyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dirtRoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parkToolStripMenuItem;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}