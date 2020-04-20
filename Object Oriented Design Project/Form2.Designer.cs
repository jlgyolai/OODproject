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
            this.WarExit.Text = "EXIT";
            this.WarExit.Click += new System.EventHandler(this.WarExit_Click);
            // 
            // War
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.WarExit);
            this.Controls.Add(this.CardsInHand);
            this.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "War";
            this.Text = "War: The Card Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CardsInHand;
        private System.Windows.Forms.TextBox WarExit;
    }
}