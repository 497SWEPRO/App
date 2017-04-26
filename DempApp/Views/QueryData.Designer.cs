namespace DempApp.Views
{
    partial class QueryData
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
            this.DGV_Result = new System.Windows.Forms.DataGridView();
            this.Btn_Excute = new System.Windows.Forms.Button();
            this.txt_Query = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Result)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Result
            // 
            this.DGV_Result.AllowUserToAddRows = false;
            this.DGV_Result.AllowUserToDeleteRows = false;
            this.DGV_Result.AllowUserToResizeColumns = false;
            this.DGV_Result.AllowUserToResizeRows = false;
            this.DGV_Result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGV_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Result.Location = new System.Drawing.Point(-1, 221);
            this.DGV_Result.Name = "DGV_Result";
            this.DGV_Result.Size = new System.Drawing.Size(548, 209);
            this.DGV_Result.TabIndex = 16;
            // 
            // Btn_Excute
            // 
            this.Btn_Excute.Location = new System.Drawing.Point(203, 186);
            this.Btn_Excute.Name = "Btn_Excute";
            this.Btn_Excute.Size = new System.Drawing.Size(125, 29);
            this.Btn_Excute.TabIndex = 15;
            this.Btn_Excute.Text = "Excute";
            this.Btn_Excute.UseVisualStyleBackColor = true;
            this.Btn_Excute.Click += new System.EventHandler(this.Btn_Excute_Click);
            // 
            // txt_Query
            // 
            this.txt_Query.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Query.Location = new System.Drawing.Point(12, 98);
            this.txt_Query.Multiline = true;
            this.txt_Query.Name = "txt_Query";
            this.txt_Query.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Query.Size = new System.Drawing.Size(522, 82);
            this.txt_Query.TabIndex = 14;
            this.txt_Query.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Migration System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.Btn_Back);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 37);
            this.panel2.TabIndex = 12;
            // 
            // Btn_Back
            // 
            this.Btn_Back.Location = new System.Drawing.Point(13, 4);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(87, 30);
            this.Btn_Back.TabIndex = 0;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(-1, 427);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 29);
            this.panel1.TabIndex = 11;
            // 
            // QueryData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 457);
            this.Controls.Add(this.DGV_Result);
            this.Controls.Add(this.Btn_Excute);
            this.Controls.Add(this.txt_Query);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QueryData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QueryData";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QueryData_FormClosing);
            this.Load += new System.EventHandler(this.QueryData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Result)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Result;
        private System.Windows.Forms.Button Btn_Excute;
        private System.Windows.Forms.TextBox txt_Query;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Panel panel1;
    }
}