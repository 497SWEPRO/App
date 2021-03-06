﻿namespace DempApp.Views
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
            this.Lbl_GoodMessage = new System.Windows.Forms.Label();
            this.Btn_Correct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_BadMessage = new System.Windows.Forms.Label();
            this.lbl_BadMessageNumber = new System.Windows.Forms.Label();
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
            // Lbl_GoodMessage
            // 
            this.Lbl_GoodMessage.AutoSize = true;
            this.Lbl_GoodMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_GoodMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Lbl_GoodMessage.Location = new System.Drawing.Point(158, 321);
            this.Lbl_GoodMessage.Name = "Lbl_GoodMessage";
            this.Lbl_GoodMessage.Size = new System.Drawing.Size(231, 20);
            this.Lbl_GoodMessage.TabIndex = 29;
            this.Lbl_GoodMessage.Text = "No Error Found in your Schema";
            this.Lbl_GoodMessage.Visible = false;
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
            // lbl_BadMessage
            // 
            this.lbl_BadMessage.AutoSize = true;
            this.lbl_BadMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BadMessage.ForeColor = System.Drawing.Color.Red;
            this.lbl_BadMessage.Location = new System.Drawing.Point(119, 362);
            this.lbl_BadMessage.Name = "lbl_BadMessage";
            this.lbl_BadMessage.Size = new System.Drawing.Size(346, 20);
            this.lbl_BadMessage.TabIndex = 32;
            this.lbl_BadMessage.Text = "There are        Data Type Errors in Your Schema";
            this.lbl_BadMessage.Visible = false;
            // 
            // lbl_BadMessageNumber
            // 
            this.lbl_BadMessageNumber.AutoSize = true;
            this.lbl_BadMessageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BadMessageNumber.Location = new System.Drawing.Point(190, 362);
            this.lbl_BadMessageNumber.Name = "lbl_BadMessageNumber";
            this.lbl_BadMessageNumber.Size = new System.Drawing.Size(29, 20);
            this.lbl_BadMessageNumber.TabIndex = 33;
            this.lbl_BadMessageNumber.Text = "15";
            this.lbl_BadMessageNumber.Visible = false;
            // 
            // CheckIncompatibilityView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 457);
            this.Controls.Add(this.lbl_BadMessageNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Correct);
            this.Controls.Add(this.Lbl_GoodMessage);
            this.Controls.Add(this.PBar1);
            this.Controls.Add(this.Btn_Detect);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_BadMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CheckIncompatibilityView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckIncompatibilityView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckIncompatibilityView_FormClosing);
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
        private System.Windows.Forms.Label Lbl_GoodMessage;
        private System.Windows.Forms.Button Btn_Correct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_BadMessage;
        private System.Windows.Forms.Label lbl_BadMessageNumber;
    }
}