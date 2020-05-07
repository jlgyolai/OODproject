namespace Object_Oriented_Design_Project
{
    partial class MainMenu
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
            this.textBoxWar = new System.Windows.Forms.TextBox();
            this.textBoxMemory = new System.Windows.Forms.TextBox();
            this.textBoxTTT = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBoxExit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxWar
            // 
            this.textBoxWar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxWar.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxWar.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWar.Location = new System.Drawing.Point(205, 151);
            this.textBoxWar.Name = "textBoxWar";
            this.textBoxWar.Size = new System.Drawing.Size(392, 51);
            this.textBoxWar.TabIndex = 0;
            this.textBoxWar.TabStop = false;
            this.textBoxWar.Text = "WAR";
            this.textBoxWar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxWar.Click += new System.EventHandler(this.textBoxWar_Click);
            this.textBoxWar.MouseEnter += new System.EventHandler(this.textBoxWar_MouseEnter);
            this.textBoxWar.MouseLeave += new System.EventHandler(this.textBoxWar_MouseLeave);
            // 
            // textBoxMemory
            // 
            this.textBoxMemory.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxMemory.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxMemory.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMemory.Location = new System.Drawing.Point(205, 221);
            this.textBoxMemory.Name = "textBoxMemory";
            this.textBoxMemory.Size = new System.Drawing.Size(392, 51);
            this.textBoxMemory.TabIndex = 1;
            this.textBoxMemory.TabStop = false;
            this.textBoxMemory.Text = "Memory Matching";
            this.textBoxMemory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxMemory.Click += new System.EventHandler(this.textBoxMemory_Click);
            this.textBoxMemory.MouseEnter += new System.EventHandler(this.textBoxMemory_MouseEnter);
            this.textBoxMemory.MouseLeave += new System.EventHandler(this.textBoxMemory_MouseLeave);
            // 
            // textBoxTTT
            // 
            this.textBoxTTT.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxTTT.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxTTT.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTTT.Location = new System.Drawing.Point(205, 292);
            this.textBoxTTT.Name = "textBoxTTT";
            this.textBoxTTT.Size = new System.Drawing.Size(392, 51);
            this.textBoxTTT.TabIndex = 2;
            this.textBoxTTT.TabStop = false;
            this.textBoxTTT.Text = "Tic-Tac-Toe";
            this.textBoxTTT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTTT.Click += new System.EventHandler(this.textBoxTTT_Click);
            this.textBoxTTT.MouseEnter += new System.EventHandler(this.textBoxTTT_MouseEnter);
            this.textBoxTTT.MouseLeave += new System.EventHandler(this.textBoxTTT_MouseLeave);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(56, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(679, 44);
            this.textBox3.TabIndex = 3;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Choose your game!";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxExit
            // 
            this.textBoxExit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBoxExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxExit.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExit.Location = new System.Drawing.Point(205, 363);
            this.textBoxExit.Name = "textBoxExit";
            this.textBoxExit.Size = new System.Drawing.Size(392, 51);
            this.textBoxExit.TabIndex = 4;
            this.textBoxExit.TabStop = false;
            this.textBoxExit.Text = "Exit";
            this.textBoxExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxExit.Click += new System.EventHandler(this.textBoxExit_Click);
            this.textBoxExit.MouseEnter += new System.EventHandler(this.textBoxExit_MouseEnter);
            this.textBoxExit.MouseLeave += new System.EventHandler(this.textBoxExit_MouseLeave);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxExit);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxTTT);
            this.Controls.Add(this.textBoxMemory);
            this.Controls.Add(this.textBoxWar);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxWar;
        private System.Windows.Forms.TextBox textBoxMemory;
        private System.Windows.Forms.TextBox textBoxTTT;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBoxExit;
    }
}

