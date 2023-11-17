namespace MailImport
{
    partial class Form1
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
            this.lblFristName = new System.Windows.Forms.Label();
            this.txtFristName = new System.Windows.Forms.TextBox();
            this.btnFristName = new System.Windows.Forms.Button();
            this.btnLastName = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblUserAgent = new System.Windows.Forms.Label();
            this.btnUserAgentImport = new System.Windows.Forms.Button();
            this.lstUserAgent = new System.Windows.Forms.ListBox();
            this.lstSock = new System.Windows.Forms.ListBox();
            this.btnSockImport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFristName
            // 
            this.lblFristName.AutoSize = true;
            this.lblFristName.Location = new System.Drawing.Point(51, 23);
            this.lblFristName.Name = "lblFristName";
            this.lblFristName.Size = new System.Drawing.Size(54, 13);
            this.lblFristName.TabIndex = 0;
            this.lblFristName.Text = "FristName";
            // 
            // txtFristName
            // 
            this.txtFristName.Location = new System.Drawing.Point(120, 23);
            this.txtFristName.Name = "txtFristName";
            this.txtFristName.Size = new System.Drawing.Size(185, 20);
            this.txtFristName.TabIndex = 1;
            // 
            // btnFristName
            // 
            this.btnFristName.Location = new System.Drawing.Point(326, 23);
            this.btnFristName.Name = "btnFristName";
            this.btnFristName.Size = new System.Drawing.Size(75, 23);
            this.btnFristName.TabIndex = 2;
            this.btnFristName.Text = "Import";
            this.btnFristName.UseVisualStyleBackColor = true;
            this.btnFristName.Click += new System.EventHandler(this.btnFristName_Click);
            // 
            // btnLastName
            // 
            this.btnLastName.Location = new System.Drawing.Point(326, 66);
            this.btnLastName.Name = "btnLastName";
            this.btnLastName.Size = new System.Drawing.Size(75, 23);
            this.btnLastName.TabIndex = 5;
            this.btnLastName.Text = "Import";
            this.btnLastName.UseVisualStyleBackColor = true;
            this.btnLastName.Click += new System.EventHandler(this.btnLastName_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(120, 66);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(185, 20);
            this.txtLastName.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(51, 66);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(55, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "LastName";
            // 
            // lblUserAgent
            // 
            this.lblUserAgent.AutoSize = true;
            this.lblUserAgent.Location = new System.Drawing.Point(51, 117);
            this.lblUserAgent.Name = "lblUserAgent";
            this.lblUserAgent.Size = new System.Drawing.Size(60, 13);
            this.lblUserAgent.TabIndex = 6;
            this.lblUserAgent.Text = "User Agent";
            // 
            // btnUserAgentImport
            // 
            this.btnUserAgentImport.Location = new System.Drawing.Point(326, 112);
            this.btnUserAgentImport.Name = "btnUserAgentImport";
            this.btnUserAgentImport.Size = new System.Drawing.Size(75, 23);
            this.btnUserAgentImport.TabIndex = 8;
            this.btnUserAgentImport.Text = "Import";
            this.btnUserAgentImport.UseVisualStyleBackColor = true;
            this.btnUserAgentImport.Click += new System.EventHandler(this.btnUserAgentImport_Click);
            // 
            // lstUserAgent
            // 
            this.lstUserAgent.FormattingEnabled = true;
            this.lstUserAgent.Location = new System.Drawing.Point(54, 159);
            this.lstUserAgent.Name = "lstUserAgent";
            this.lstUserAgent.Size = new System.Drawing.Size(347, 95);
            this.lstUserAgent.TabIndex = 9;
            this.lstUserAgent.SelectedIndexChanged += new System.EventHandler(this.lstUserAgent_SelectedIndexChanged);
            // 
            // lstSock
            // 
            this.lstSock.FormattingEnabled = true;
            this.lstSock.Location = new System.Drawing.Point(54, 309);
            this.lstSock.Name = "lstSock";
            this.lstSock.Size = new System.Drawing.Size(347, 95);
            this.lstSock.TabIndex = 12;
            this.lstSock.SelectedIndexChanged += new System.EventHandler(this.lstSock_SelectedIndexChanged);
            // 
            // btnSockImport
            // 
            this.btnSockImport.Location = new System.Drawing.Point(326, 262);
            this.btnSockImport.Name = "btnSockImport";
            this.btnSockImport.Size = new System.Drawing.Size(75, 26);
            this.btnSockImport.TabIndex = 11;
            this.btnSockImport.Text = "Import";
            this.btnSockImport.UseVisualStyleBackColor = true;
            this.btnSockImport.Click += new System.EventHandler(this.btnSockImport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "List Sock 5";
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(54, 423);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(347, 147);
            this.dgvData.TabIndex = 13;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(168, 591);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(127, 23);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 626);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.lstSock);
            this.Controls.Add(this.btnSockImport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstUserAgent);
            this.Controls.Add(this.btnUserAgentImport);
            this.Controls.Add(this.lblUserAgent);
            this.Controls.Add(this.btnLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.btnFristName);
            this.Controls.Add(this.txtFristName);
            this.Controls.Add(this.lblFristName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFristName;
        private System.Windows.Forms.TextBox txtFristName;
        private System.Windows.Forms.Button btnFristName;
        private System.Windows.Forms.Button btnLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblUserAgent;
        private System.Windows.Forms.Button btnUserAgentImport;
        private System.Windows.Forms.ListBox lstUserAgent;
        private System.Windows.Forms.ListBox lstSock;
        private System.Windows.Forms.Button btnSockImport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnExport;
    }
}

