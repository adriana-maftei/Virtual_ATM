namespace Virtual_ATM
{
    partial class Withdraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Withdraw));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.amountMoney_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.withdraw_btn = new System.Windows.Forms.Button();
            this.availableMoney_lbl = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(566, 57);
            this.panel4.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "W I T H D R A W";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.DarkRed;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_btn.Location = new System.Drawing.Point(132, 188);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(156, 41);
            this.back_btn.TabIndex = 45;
            this.back_btn.Text = "BACK";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // amountMoney_txt
            // 
            this.amountMoney_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountMoney_txt.Location = new System.Drawing.Point(132, 147);
            this.amountMoney_txt.Name = "amountMoney_txt";
            this.amountMoney_txt.Size = new System.Drawing.Size(318, 30);
            this.amountMoney_txt.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(139, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(289, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "ENTER AMOUNT OF MONEY:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // withdraw_btn
            // 
            this.withdraw_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.withdraw_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdraw_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.withdraw_btn.Location = new System.Drawing.Point(294, 188);
            this.withdraw_btn.Name = "withdraw_btn";
            this.withdraw_btn.Size = new System.Drawing.Size(156, 41);
            this.withdraw_btn.TabIndex = 44;
            this.withdraw_btn.Text = "WITHDRAW";
            this.withdraw_btn.UseVisualStyleBackColor = false;
            this.withdraw_btn.Click += new System.EventHandler(this.withdraw_btn_Click);
            // 
            // availableMoney_lbl
            // 
            this.availableMoney_lbl.AutoSize = true;
            this.availableMoney_lbl.Font = new System.Drawing.Font("PMingLiU-ExtB", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableMoney_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.availableMoney_lbl.Location = new System.Drawing.Point(152, 75);
            this.availableMoney_lbl.Name = "availableMoney_lbl";
            this.availableMoney_lbl.Size = new System.Drawing.Size(309, 23);
            this.availableMoney_lbl.TabIndex = 46;
            this.availableMoney_lbl.Text = "AVAILABLE MONEY: 00000";
            this.availableMoney_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(566, 241);
            this.Controls.Add(this.availableMoney_lbl);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.withdraw_btn);
            this.Controls.Add(this.amountMoney_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WITHDRAW";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.TextBox amountMoney_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button withdraw_btn;
        private System.Windows.Forms.Label availableMoney_lbl;
    }
}