namespace MailImport
{
    partial class MailData
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
            this.lblMail = new System.Windows.Forms.Label();
            this.lstAccount = new System.Windows.Forms.ListBox();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnSocks = new System.Windows.Forms.Button();
            this.lstSocks = new System.Windows.Forms.ListBox();
            this.lblSocks = new System.Windows.Forms.Label();
            this.btnUserAgent = new System.Windows.Forms.Button();
            this.lstUserAgent = new System.Windows.Forms.ListBox();
            this.lblUserAgent = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.lstProfile = new System.Windows.Forms.ListBox();
            this.lblProfile = new System.Windows.Forms.Label();
            this.dgInfo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThreadNumber = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(5, 35);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(124, 18);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "Mail|PassWord";
            // 
            // lstAccount
            // 
            this.lstAccount.FormattingEnabled = true;
            this.lstAccount.ItemHeight = 16;
            this.lstAccount.Location = new System.Drawing.Point(8, 58);
            this.lstAccount.Name = "lstAccount";
            this.lstAccount.Size = new System.Drawing.Size(430, 100);
            this.lstAccount.TabIndex = 1;
            // 
            // btnAccount
            // 
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.Location = new System.Drawing.Point(348, 20);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(90, 33);
            this.btnAccount.TabIndex = 2;
            this.btnAccount.Text = "Import";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnSocks
            // 
            this.btnSocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSocks.Location = new System.Drawing.Point(845, 19);
            this.btnSocks.Name = "btnSocks";
            this.btnSocks.Size = new System.Drawing.Size(90, 33);
            this.btnSocks.TabIndex = 5;
            this.btnSocks.Text = "Import";
            this.btnSocks.UseVisualStyleBackColor = true;
            this.btnSocks.Click += new System.EventHandler(this.btnSocks_Click);
            // 
            // lstSocks
            // 
            this.lstSocks.FormattingEnabled = true;
            this.lstSocks.ItemHeight = 16;
            this.lstSocks.Location = new System.Drawing.Point(505, 58);
            this.lstSocks.Name = "lstSocks";
            this.lstSocks.Size = new System.Drawing.Size(430, 100);
            this.lstSocks.TabIndex = 4;
            // 
            // lblSocks
            // 
            this.lblSocks.AutoSize = true;
            this.lblSocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocks.Location = new System.Drawing.Point(502, 30);
            this.lblSocks.Name = "lblSocks";
            this.lblSocks.Size = new System.Drawing.Size(56, 18);
            this.lblSocks.TabIndex = 3;
            this.lblSocks.Text = "Socks";
            // 
            // btnUserAgent
            // 
            this.btnUserAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserAgent.Location = new System.Drawing.Point(350, 177);
            this.btnUserAgent.Name = "btnUserAgent";
            this.btnUserAgent.Size = new System.Drawing.Size(90, 33);
            this.btnUserAgent.TabIndex = 8;
            this.btnUserAgent.Text = "Import";
            this.btnUserAgent.UseVisualStyleBackColor = true;
            this.btnUserAgent.Click += new System.EventHandler(this.btnUserAgent_Click);
            // 
            // lstUserAgent
            // 
            this.lstUserAgent.FormattingEnabled = true;
            this.lstUserAgent.ItemHeight = 16;
            this.lstUserAgent.Location = new System.Drawing.Point(10, 215);
            this.lstUserAgent.Name = "lstUserAgent";
            this.lstUserAgent.Size = new System.Drawing.Size(430, 100);
            this.lstUserAgent.TabIndex = 7;
            // 
            // lblUserAgent
            // 
            this.lblUserAgent.AutoSize = true;
            this.lblUserAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserAgent.Location = new System.Drawing.Point(7, 192);
            this.lblUserAgent.Name = "lblUserAgent";
            this.lblUserAgent.Size = new System.Drawing.Size(91, 18);
            this.lblUserAgent.TabIndex = 6;
            this.lblUserAgent.Text = "User Agent";
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(845, 176);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(90, 33);
            this.btnProfile.TabIndex = 11;
            this.btnProfile.Text = "Import";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // lstProfile
            // 
            this.lstProfile.FormattingEnabled = true;
            this.lstProfile.ItemHeight = 16;
            this.lstProfile.Location = new System.Drawing.Point(505, 215);
            this.lstProfile.Name = "lstProfile";
            this.lstProfile.Size = new System.Drawing.Size(430, 100);
            this.lstProfile.TabIndex = 10;
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.Location = new System.Drawing.Point(502, 192);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(57, 18);
            this.lblProfile.TabIndex = 9;
            this.lblProfile.Text = "Profile";
            // 
            // dgInfo
            // 
            this.dgInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInfo.Location = new System.Drawing.Point(-2, 392);
            this.dgInfo.Name = "dgInfo";
            this.dgInfo.RowHeadersWidth = 51;
            this.dgInfo.RowTemplate.Height = 24;
            this.dgInfo.Size = new System.Drawing.Size(950, 286);
            this.dgInfo.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Số luồng:";
            // 
            // txtThreadNumber
            // 
            this.txtThreadNumber.Location = new System.Drawing.Point(97, 345);
            this.txtThreadNumber.Name = "txtThreadNumber";
            this.txtThreadNumber.Size = new System.Drawing.Size(52, 22);
            this.txtThreadNumber.TabIndex = 14;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(709, 335);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(159, 43);
            this.btnStop.TabIndex = 15;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(505, 335);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(156, 43);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // MailData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 680);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.txtThreadNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgInfo);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.lstProfile);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.btnUserAgent);
            this.Controls.Add(this.lstUserAgent);
            this.Controls.Add(this.lblUserAgent);
            this.Controls.Add(this.btnSocks);
            this.Controls.Add(this.lstSocks);
            this.Controls.Add(this.lblSocks);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.lstAccount);
            this.Controls.Add(this.lblMail);
            this.Name = "MailData";
            this.Text = "MailData";
            this.Load += new System.EventHandler(this.MailData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.ListBox lstAccount;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnSocks;
        private System.Windows.Forms.ListBox lstSocks;
        private System.Windows.Forms.Label lblSocks;
        private System.Windows.Forms.Button btnUserAgent;
        private System.Windows.Forms.ListBox lstUserAgent;
        private System.Windows.Forms.Label lblUserAgent;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.ListBox lstProfile;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.DataGridView dgInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThreadNumber;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
    }
}