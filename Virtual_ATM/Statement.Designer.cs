namespace Virtual_ATM
{
    partial class Statement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statement));
            this.label1 = new System.Windows.Forms.Label();
            this.statementDGV = new System.Windows.Forms.DataGridView();
            this.back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.statementDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "S T A T E M E N T";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // statementDGV
            // 
            this.statementDGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.statementDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statementDGV.Location = new System.Drawing.Point(0, 49);
            this.statementDGV.Name = "statementDGV";
            this.statementDGV.RowHeadersWidth = 51;
            this.statementDGV.RowTemplate.Height = 24;
            this.statementDGV.Size = new System.Drawing.Size(748, 345);
            this.statementDGV.TabIndex = 18;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.DarkRed;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_btn.Location = new System.Drawing.Point(296, 400);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(156, 41);
            this.back_btn.TabIndex = 49;
            this.back_btn.Text = "BACK";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // Statement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(746, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.statementDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Statement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STATEMENT";
            this.Load += new System.EventHandler(this.Statement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statementDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView statementDGV;
        private System.Windows.Forms.Button back_btn;
    }
}