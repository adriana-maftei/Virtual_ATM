namespace Virtual_ATM
{
    partial class Transactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transactions));
            this.panel1 = new System.Windows.Forms.Panel();
            this.loggedAccount_lbl = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.balance_btn = new System.Windows.Forms.Button();
            this.statement_btn = new System.Windows.Forms.Button();
            this.withdraw_btn = new System.Windows.Forms.Button();
            this.changePIN_btn = new System.Windows.Forms.Button();
            this.cash_btn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.deposit_btn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.loggedAccount_lbl);
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.balance_btn);
            this.panel1.Controls.Add(this.statement_btn);
            this.panel1.Controls.Add(this.withdraw_btn);
            this.panel1.Controls.Add(this.changePIN_btn);
            this.panel1.Controls.Add(this.cash_btn);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.deposit_btn);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 365);
            this.panel1.TabIndex = 5;
            // 
            // loggedAccount_lbl
            // 
            this.loggedAccount_lbl.AutoSize = true;
            this.loggedAccount_lbl.BackColor = System.Drawing.Color.Transparent;
            this.loggedAccount_lbl.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedAccount_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loggedAccount_lbl.Location = new System.Drawing.Point(12, 92);
            this.loggedAccount_lbl.Name = "loggedAccount_lbl";
            this.loggedAccount_lbl.Size = new System.Drawing.Size(333, 40);
            this.loggedAccount_lbl.TabIndex = 22;
            this.loggedAccount_lbl.Text = "LOGGED AS ..............";
            this.loggedAccount_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.DarkRed;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_logout.Location = new System.Drawing.Point(458, 91);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(197, 50);
            this.btn_logout.TabIndex = 21;
            this.btn_logout.Text = "LOG OUT";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // balance_btn
            // 
            this.balance_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.balance_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.balance_btn.Location = new System.Drawing.Point(458, 295);
            this.balance_btn.Name = "balance_btn";
            this.balance_btn.Size = new System.Drawing.Size(194, 50);
            this.balance_btn.TabIndex = 19;
            this.balance_btn.Text = "BALANCE";
            this.balance_btn.UseVisualStyleBackColor = false;
            this.balance_btn.Click += new System.EventHandler(this.balance_btn_Click);
            // 
            // statement_btn
            // 
            this.statement_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statement_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statement_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statement_btn.Location = new System.Drawing.Point(458, 229);
            this.statement_btn.Name = "statement_btn";
            this.statement_btn.Size = new System.Drawing.Size(194, 50);
            this.statement_btn.TabIndex = 18;
            this.statement_btn.Text = "STATEMENT";
            this.statement_btn.UseVisualStyleBackColor = false;
            this.statement_btn.Click += new System.EventHandler(this.statement_btn_Click);
            // 
            // withdraw_btn
            // 
            this.withdraw_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.withdraw_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdraw_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.withdraw_btn.Location = new System.Drawing.Point(458, 161);
            this.withdraw_btn.Name = "withdraw_btn";
            this.withdraw_btn.Size = new System.Drawing.Size(194, 50);
            this.withdraw_btn.TabIndex = 17;
            this.withdraw_btn.Text = "WITHDRAW";
            this.withdraw_btn.UseVisualStyleBackColor = false;
            this.withdraw_btn.Click += new System.EventHandler(this.withdraw_btn_Click);
            // 
            // changePIN_btn
            // 
            this.changePIN_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.changePIN_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePIN_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changePIN_btn.Location = new System.Drawing.Point(13, 295);
            this.changePIN_btn.Name = "changePIN_btn";
            this.changePIN_btn.Size = new System.Drawing.Size(194, 50);
            this.changePIN_btn.TabIndex = 15;
            this.changePIN_btn.Text = "CHANGE PIN";
            this.changePIN_btn.UseVisualStyleBackColor = false;
            this.changePIN_btn.Click += new System.EventHandler(this.changePIN_btn_Click);
            // 
            // cash_btn
            // 
            this.cash_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cash_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cash_btn.Location = new System.Drawing.Point(13, 229);
            this.cash_btn.Name = "cash_btn";
            this.cash_btn.Size = new System.Drawing.Size(194, 50);
            this.cash_btn.TabIndex = 14;
            this.cash_btn.Text = "FAST CASH";
            this.cash_btn.UseVisualStyleBackColor = false;
            this.cash_btn.Click += new System.EventHandler(this.cash_btn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(668, 69);
            this.panel4.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(37, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "T R A N S A C T I O N S";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // deposit_btn
            // 
            this.deposit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deposit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deposit_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deposit_btn.Location = new System.Drawing.Point(13, 161);
            this.deposit_btn.Name = "deposit_btn";
            this.deposit_btn.Size = new System.Drawing.Size(194, 50);
            this.deposit_btn.TabIndex = 10;
            this.deposit_btn.Text = "DEPOSIT";
            this.deposit_btn.UseVisualStyleBackColor = false;
            this.deposit_btn.Click += new System.EventHandler(this.deposit_btn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Virtual_ATM.Properties.Resources.icons8_atm_64;
            this.pictureBox3.Location = new System.Drawing.Point(236, 161);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(197, 184);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(668, 365);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Transactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRANSACTIONS";
            this.Load += new System.EventHandler(this.Transactions_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deposit_btn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button balance_btn;
        private System.Windows.Forms.Button statement_btn;
        private System.Windows.Forms.Button withdraw_btn;
        private System.Windows.Forms.Button changePIN_btn;
        private System.Windows.Forms.Button cash_btn;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label loggedAccount_lbl;
    }
}