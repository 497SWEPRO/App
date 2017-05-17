namespace DempApp.Views
{
    partial class ExcuteSchemaView
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_SchemaName = new System.Windows.Forms.Label();
            this.Btn_Excute = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PBar1 = new System.Windows.Forms.ProgressBar();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.Btn_Back);
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 37);
            this.panel2.TabIndex = 27;
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
            this.panel1.Location = new System.Drawing.Point(1, 426);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 29);
            this.panel1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Your Schema:";
            // 
            // lbl_SchemaName
            // 
            this.lbl_SchemaName.AutoSize = true;
            this.lbl_SchemaName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_SchemaName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_SchemaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SchemaName.Location = new System.Drawing.Point(150, 105);
            this.lbl_SchemaName.Name = "lbl_SchemaName";
            this.lbl_SchemaName.Size = new System.Drawing.Size(117, 22);
            this.lbl_SchemaName.TabIndex = 29;
            this.lbl_SchemaName.Text = "ResortBooking";
            // 
            // Btn_Excute
            // 
            this.Btn_Excute.Location = new System.Drawing.Point(116, 230);
            this.Btn_Excute.Name = "Btn_Excute";
            this.Btn_Excute.Size = new System.Drawing.Size(307, 49);
            this.Btn_Excute.TabIndex = 30;
            this.Btn_Excute.Text = "Excute";
            this.Btn_Excute.UseVisualStyleBackColor = true;
            this.Btn_Excute.Click += new System.EventHandler(this.Btn_Excute_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15F);
            this.label3.Location = new System.Drawing.Point(46, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Excte Data warehouse Schema on Azure";
            // 
            // PBar1
            // 
            this.PBar1.Location = new System.Drawing.Point(50, 304);
            this.PBar1.Name = "PBar1";
            this.PBar1.Size = new System.Drawing.Size(446, 23);
            this.PBar1.TabIndex = 32;
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Location = new System.Drawing.Point(8, 381);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(115, 39);
            this.Btn_Reset.TabIndex = 33;
            this.Btn_Reset.Text = "Reset";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            // 
            // ExcuteSchemaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 455);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.PBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_Excute);
            this.Controls.Add(this.lbl_SchemaName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ExcuteSchemaView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExcuteSchemaView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExcuteSchemaView_FormClosing);
            this.Load += new System.EventHandler(this.ExcuteSchemaView_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_SchemaName;
        private System.Windows.Forms.Button Btn_Excute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar PBar1;
        private System.Windows.Forms.Button Btn_Reset;
    }
}