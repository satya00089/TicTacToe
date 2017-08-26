namespace TicTacToe__
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton3 = new MetroFramework.Controls.MetroRadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroRadioButton1.Location = new System.Drawing.Point(7, 6);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(46, 15);
            this.metroRadioButton1.TabIndex = 0;
            this.metroRadioButton1.TabStop = true;
            this.metroRadioButton1.Text = "Easy";
            this.metroRadioButton1.UseVisualStyleBackColor = true;
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroRadioButton2.Location = new System.Drawing.Point(7, 25);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(68, 15);
            this.metroRadioButton2.TabIndex = 1;
            this.metroRadioButton2.TabStop = true;
            this.metroRadioButton2.Text = "Medium";
            this.metroRadioButton2.UseVisualStyleBackColor = true;
            // 
            // metroRadioButton3
            // 
            this.metroRadioButton3.AutoSize = true;
            this.metroRadioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroRadioButton3.Location = new System.Drawing.Point(7, 44);
            this.metroRadioButton3.Name = "metroRadioButton3";
            this.metroRadioButton3.Size = new System.Drawing.Size(49, 15);
            this.metroRadioButton3.TabIndex = 2;
            this.metroRadioButton3.TabStop = true;
            this.metroRadioButton3.Text = "Hard";
            this.metroRadioButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(25, 62);
            this.button1.MaximumSize = new System.Drawing.Size(50, 21);
            this.button1.MinimumSize = new System.Drawing.Size(50, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 21);
            this.button1.TabIndex = 3;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(79, 86);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metroRadioButton3);
            this.Controls.Add(this.metroRadioButton2);
            this.Controls.Add(this.metroRadioButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(830, 220);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(95, 125);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(95, 125);
            this.Name = "Form7";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Level";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton3;
        private System.Windows.Forms.Button button1;
    }
}