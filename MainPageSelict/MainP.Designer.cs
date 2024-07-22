namespace MainPageSelict
{
    partial class MainP
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelLibrary = new System.Windows.Forms.Label();
            this.buttonEnglish = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLibrary
            // 
            this.labelLibrary.AutoSize = true;
            this.labelLibrary.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLibrary.Location = new System.Drawing.Point(424, 182);
            this.labelLibrary.Name = "labelLibrary";
            this.labelLibrary.Size = new System.Drawing.Size(392, 135);
            this.labelLibrary.TabIndex = 1;
            this.labelLibrary.Text = "Library";
            this.labelLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLibrary.Click += new System.EventHandler(this.labelLibrary_Click);
            // 
            // buttonEnglish
            // 
            this.buttonEnglish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.buttonEnglish.Location = new System.Drawing.Point(424, 457);
            this.buttonEnglish.Name = "buttonEnglish";
            this.buttonEnglish.Size = new System.Drawing.Size(336, 75);
            this.buttonEnglish.TabIndex = 6;
            this.buttonEnglish.Text = "English Game";
            this.buttonEnglish.UseVisualStyleBackColor = false;
            this.buttonEnglish.Click += new System.EventHandler(this.buttonEnglish_Click);
            this.buttonEnglish.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.buttonEnglish.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.button1.Location = new System.Drawing.Point(424, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(336, 75);
            this.button1.TabIndex = 6;
            this.button1.Text = "Math Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.button2.Location = new System.Drawing.Point(424, 650);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(336, 75);
            this.button2.TabIndex = 7;
            this.button2.Text = "Hebrew Game";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // MainP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 1073);
            this.Controls.Add(this.buttonEnglish);
            this.Controls.Add(this.labelLibrary);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MainP";
            this.Text = "Main Page Select";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelLibrary;
        private System.Windows.Forms.Button buttonEnglish;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
