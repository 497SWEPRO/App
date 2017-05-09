namespace DempApp.Views
{
    partial class CheckIncompatibilityView
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PBar1 = new System.Windows.Forms.ProgressBar();
            this.Btn_Detect = new System.Windows.Forms.Button();
            this.Lbl_Message = new System.Windows.Forms.Label();
            this.Btn_Correct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.Btn_Back);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 37);
            this.panel2.TabIndex = 25;
            // 
            // Btn_Back
            // 
            this.Btn_Back.Location = new System.Drawing.Point(13, 3);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(87, 30);
            this.Btn_Back.TabIndex = 1;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(0, 424);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 29);
            this.panel1.TabIndex = 24;
            // 
            // PBar1
            // 
            this.PBar1.Location = new System.Drawing.Point(47, 248);
            this.PBar1.Name = "PBar1";
            this.PBar1.Size = new System.Drawing.Size(446, 23);
            this.PBar1.TabIndex = 28;
            // 
            // Btn_Detect
            // 
            this.Btn_Detect.Location = new System.Drawing.Point(94, 160);
            this.Btn_Detect.Name = "Btn_Detect";
            this.Btn_Detect.Size = new System.Drawing.Size(125, 29);
            this.Btn_Detect.TabIndex = 27;
            this.Btn_Detect.Text = "Detect Errors";
            this.Btn_Detect.UseVisualStyleBackColor = true;
            this.Btn_Detect.Click += new System.EventHandler(this.Btn_Detect_Click);
            // 
            // Lbl_Message
            // 
            this.Lbl_Message.AutoSize = true;
            this.Lbl_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Message.Location = new System.Drawing.Point(90, 357);
            this.Lbl_Message.Name = "Lbl_Message";
            this.Lbl_Message.Size = new System.Drawing.Size(0, 20);
            this.Lbl_Message.TabIndex = 29;
            // 
            // Btn_Correct
            // 
            this.Btn_Correct.Enabled = false;
            this.Btn_Correct.Location = new System.Drawing.Point(299, 160);
            this.Btn_Correct.Name = "Btn_Correct";
            this.Btn_Correct.Size = new System.Drawing.Size(125, 29);
            this.Btn_Correct.TabIndex = 30;
            this.Btn_Correct.Text = "Correct Errors";
            this.Btn_Correct.UseVisualStyleBackColor = true;
            this.Btn_Correct.Click += new System.EventHandler(this.Btn_Correct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Schema Detection & Correction";
            this.label2.UseMnemonic = false;
            // 
            // CheckIncompatibilityView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 457);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Correct);
            this.Controls.Add(this.Lbl_Message);
            this.Controls.Add(this.PBar1);
            this.Controls.Add(this.Btn_Detect);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CheckIncompatibilityView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckIncompatibilityView";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar PBar1;
        private System.Windows.Forms.Button Btn_Detect;
        private System.Windows.Forms.Label Lbl_Message;
        private System.Windows.Forms.Button Btn_Correct;
        private System.Windows.Forms.Label label2;
    }
}