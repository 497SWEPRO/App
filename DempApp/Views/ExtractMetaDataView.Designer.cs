namespace DempApp.Views
{
    partial class ExtractMetaDataView
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
            this.DGV_Result = new System.Windows.Forms.DataGridView();
            this.Btn_Extract = new System.Windows.Forms.Button();
            this.PBar1 = new System.Windows.Forms.ProgressBar();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.Btn_Back);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 37);
            this.panel2.TabIndex = 23;
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
            this.panel1.Location = new System.Drawing.Point(-1, 427);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 29);
            this.panel1.TabIndex = 22;
            // 
            // DGV_Result
            // 
            this.DGV_Result.AllowUserToAddRows = false;
            this.DGV_Result.AllowUserToDeleteRows = false;
            this.DGV_Result.AllowUserToResizeColumns = false;
            this.DGV_Result.AllowUserToResizeRows = false;
            this.DGV_Result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Result.Location = new System.Drawing.Point(0, 220);
            this.DGV_Result.Name = "DGV_Result";
            this.DGV_Result.ReadOnly = true;
            this.DGV_Result.Size = new System.Drawing.Size(538, 209);
            this.DGV_Result.TabIndex = 25;
            // 
            // Btn_Extract
            // 
            this.Btn_Extract.Location = new System.Drawing.Point(201, 90);
            this.Btn_Extract.Name = "Btn_Extract";
            this.Btn_Extract.Size = new System.Drawing.Size(125, 29);
            this.Btn_Extract.TabIndex = 24;
            this.Btn_Extract.Text = "Extract";
            this.Btn_Extract.UseVisualStyleBackColor = true;
            this.Btn_Extract.Click += new System.EventHandler(this.Btn_Extract_Click);
            // 
            // PBar1
            // 
            this.PBar1.Location = new System.Drawing.Point(33, 153);
            this.PBar1.Name = "PBar1";
            this.PBar1.Size = new System.Drawing.Size(446, 23);
            this.PBar1.TabIndex = 26;
            // 
            // ExtractMetaDataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 457);
            this.Controls.Add(this.PBar1);
            this.Controls.Add(this.DGV_Result);
            this.Controls.Add(this.Btn_Extract);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ExtractMetaDataView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExtractMetaDataView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExtractMetaDataView_FormClosing);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGV_Result;
        private System.Windows.Forms.Button Btn_Extract;
        private System.Windows.Forms.ProgressBar PBar1;
        private System.Windows.Forms.Button Btn_Back;
    }
}