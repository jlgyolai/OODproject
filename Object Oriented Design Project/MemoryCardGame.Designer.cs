namespace Object_Oriented_Design_Project
{
    partial class MemoryCardGame
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
            this.MCGExit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MCGExit
            // 
            this.MCGExit.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCGExit.Location = new System.Drawing.Point(720, 398);
            this.MCGExit.Name = "MCGExit";
            this.MCGExit.Size = new System.Drawing.Size(68, 40);
            this.MCGExit.TabIndex = 0;
            this.MCGExit.Text = "Exit";
            this.MCGExit.Click += new System.EventHandler(this.MCGExit_Click);
            // 
            // MemoryCardGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MCGExit);
            this.Name = "MemoryCardGame";
            this.Text = "MemoryCardGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MCGExit;
    }
}