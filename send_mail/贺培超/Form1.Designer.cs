namespace 贺培超
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbxMailboxInfo = new System.Windows.Forms.TextBox();
            this.btnRefreshMailList = new System.Windows.Forms.Button();
            this.btnReadMail = new System.Windows.Forms.Button();
            this.btnDeleteMail = new System.Windows.Forms.Button();
            this.btnDownLoad = new System.Windows.Forms.Button();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageWriteLetter = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.cmbAttachment = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.richtbxBody = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbSubject = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbSendTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstViewMailList = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsttbxStatus = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxPOP3Server = new System.Windows.Forms.TextBox();
            this.tbxSmtpServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.logingroupbox = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxUserMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControlMyMailbox = new System.Windows.Forms.TabControl();
            this.tabPageInbox = new System.Windows.Forms.TabPage();
            this.tb_popPort = new System.Windows.Forms.TextBox();
            this.tb_smtpPort = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPageWriteLetter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.logingroupbox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControlMyMailbox.SuspendLayout();
            this.tabPageInbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "主题";
            // 
            // tbxMailboxInfo
            // 
            this.tbxMailboxInfo.Location = new System.Drawing.Point(3, 299);
            this.tbxMailboxInfo.Name = "tbxMailboxInfo";
            this.tbxMailboxInfo.Size = new System.Drawing.Size(352, 21);
            this.tbxMailboxInfo.TabIndex = 5;
            // 
            // btnRefreshMailList
            // 
            this.btnRefreshMailList.Location = new System.Drawing.Point(318, 329);
            this.btnRefreshMailList.Name = "btnRefreshMailList";
            this.btnRefreshMailList.Size = new System.Drawing.Size(37, 23);
            this.btnRefreshMailList.TabIndex = 4;
            this.btnRefreshMailList.Text = "刷新";
            this.btnRefreshMailList.UseVisualStyleBackColor = true;
            this.btnRefreshMailList.Click += new System.EventHandler(this.btnRefreshMailList_Click);
            // 
            // btnReadMail
            // 
            this.btnReadMail.Location = new System.Drawing.Point(3, 329);
            this.btnReadMail.Name = "btnReadMail";
            this.btnReadMail.Size = new System.Drawing.Size(61, 23);
            this.btnReadMail.TabIndex = 1;
            this.btnReadMail.Text = "阅读邮件";
            this.btnReadMail.UseVisualStyleBackColor = true;
            this.btnReadMail.Click += new System.EventHandler(this.btnReadMail_Click);
            // 
            // btnDeleteMail
            // 
            this.btnDeleteMail.Location = new System.Drawing.Point(265, 329);
            this.btnDeleteMail.Name = "btnDeleteMail";
            this.btnDeleteMail.Size = new System.Drawing.Size(47, 23);
            this.btnDeleteMail.TabIndex = 3;
            this.btnDeleteMail.Text = "删除";
            this.btnDeleteMail.UseVisualStyleBackColor = true;
            this.btnDeleteMail.Click += new System.EventHandler(this.btnDeleteMail_Click);
            // 
            // btnDownLoad
            // 
            this.btnDownLoad.Location = new System.Drawing.Point(70, 329);
            this.btnDownLoad.Name = "btnDownLoad";
            this.btnDownLoad.Size = new System.Drawing.Size(61, 23);
            this.btnDownLoad.TabIndex = 2;
            this.btnDownLoad.Text = "附件下载";
            this.btnDownLoad.UseVisualStyleBackColor = true;
            this.btnDownLoad.Click += new System.EventHandler(this.btnDownLoad_Click);
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 3;
            this.columnHeader4.Text = "时间";
            // 
            // tabPageWriteLetter
            // 
            this.tabPageWriteLetter.Controls.Add(this.btnCancel);
            this.tabPageWriteLetter.Controls.Add(this.btnSend);
            this.tabPageWriteLetter.Controls.Add(this.btnDeleteFile);
            this.tabPageWriteLetter.Controls.Add(this.btnAddFile);
            this.tabPageWriteLetter.Controls.Add(this.cmbAttachment);
            this.tabPageWriteLetter.Controls.Add(this.label8);
            this.tabPageWriteLetter.Controls.Add(this.richtbxBody);
            this.tabPageWriteLetter.Controls.Add(this.label7);
            this.tabPageWriteLetter.Controls.Add(this.txbSubject);
            this.tabPageWriteLetter.Controls.Add(this.label6);
            this.tabPageWriteLetter.Controls.Add(this.txbSendTo);
            this.tabPageWriteLetter.Controls.Add(this.label5);
            this.tabPageWriteLetter.Location = new System.Drawing.Point(4, 22);
            this.tabPageWriteLetter.Name = "tabPageWriteLetter";
            this.tabPageWriteLetter.Size = new System.Drawing.Size(358, 364);
            this.tabPageWriteLetter.TabIndex = 1;
            this.tabPageWriteLetter.Text = "写信";
            this.tabPageWriteLetter.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(292, 333);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(63, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(57, 334);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(68, 23);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Location = new System.Drawing.Point(313, 304);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(42, 23);
            this.btnDeleteFile.TabIndex = 9;
            this.btnDeleteFile.Text = "删除";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(263, 304);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(48, 23);
            this.btnAddFile.TabIndex = 8;
            this.btnAddFile.Text = "添加";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // cmbAttachment
            // 
            this.cmbAttachment.FormattingEnabled = true;
            this.cmbAttachment.Location = new System.Drawing.Point(57, 307);
            this.cmbAttachment.Name = "cmbAttachment";
            this.cmbAttachment.Size = new System.Drawing.Size(200, 20);
            this.cmbAttachment.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "附件";
            // 
            // richtbxBody
            // 
            this.richtbxBody.Location = new System.Drawing.Point(57, 67);
            this.richtbxBody.Name = "richtbxBody";
            this.richtbxBody.Size = new System.Drawing.Size(298, 231);
            this.richtbxBody.TabIndex = 5;
            this.richtbxBody.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "内  容：";
            // 
            // txbSubject
            // 
            this.txbSubject.Location = new System.Drawing.Point(57, 36);
            this.txbSubject.Name = "txbSubject";
            this.txbSubject.Size = new System.Drawing.Size(298, 21);
            this.txbSubject.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "主  题：";
            // 
            // txbSendTo
            // 
            this.txbSendTo.Location = new System.Drawing.Point(57, 8);
            this.txbSendTo.Name = "txbSendTo";
            this.txbSendTo.Size = new System.Drawing.Size(298, 21);
            this.txbSendTo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "收件人：";
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "附件";
            // 
            // lstViewMailList
            // 
            this.lstViewMailList.BackColor = System.Drawing.SystemColors.Window;
            this.lstViewMailList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstViewMailList.Location = new System.Drawing.Point(3, 5);
            this.lstViewMailList.Name = "lstViewMailList";
            this.lstViewMailList.Size = new System.Drawing.Size(352, 288);
            this.lstViewMailList.TabIndex = 0;
            this.lstViewMailList.UseCompatibleStateImageBehavior = false;
            this.lstViewMailList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 4;
            this.columnHeader5.Text = "";
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 0;
            this.columnHeader1.Text = "发件人";
            // 
            // lsttbxStatus
            // 
            this.lsttbxStatus.FormattingEnabled = true;
            this.lsttbxStatus.ItemHeight = 12;
            this.lsttbxStatus.Location = new System.Drawing.Point(12, 156);
            this.lsttbxStatus.Name = "lsttbxStatus";
            this.lsttbxStatus.Size = new System.Drawing.Size(327, 148);
            this.lsttbxStatus.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_popPort);
            this.groupBox1.Controls.Add(this.tb_smtpPort);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbxPOP3Server);
            this.groupBox1.Controls.Add(this.tbxSmtpServer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 96);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置";
            // 
            // tbxPOP3Server
            // 
            this.tbxPOP3Server.Location = new System.Drawing.Point(80, 70);
            this.tbxPOP3Server.Name = "tbxPOP3Server";
            this.tbxPOP3Server.Size = new System.Drawing.Size(156, 21);
            this.tbxPOP3Server.TabIndex = 3;
            // 
            // tbxSmtpServer
            // 
            this.tbxSmtpServer.Location = new System.Drawing.Point(80, 27);
            this.tbxSmtpServer.Name = "tbxSmtpServer";
            this.tbxSmtpServer.Size = new System.Drawing.Size(156, 21);
            this.tbxSmtpServer.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "POP3服务器";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "SMTP服务器";
            // 
            // logingroupbox
            // 
            this.logingroupbox.Controls.Add(this.btnLogout);
            this.logingroupbox.Controls.Add(this.btnLogin);
            this.logingroupbox.Controls.Add(this.txbPassword);
            this.logingroupbox.Controls.Add(this.label2);
            this.logingroupbox.Controls.Add(this.tbxUserMail);
            this.logingroupbox.Controls.Add(this.label1);
            this.logingroupbox.Location = new System.Drawing.Point(12, 12);
            this.logingroupbox.Name = "logingroupbox";
            this.logingroupbox.Size = new System.Drawing.Size(327, 132);
            this.logingroupbox.TabIndex = 1;
            this.logingroupbox.TabStop = false;
            this.logingroupbox.Text = "登录";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 97);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(64, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "注销";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(258, 97);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(63, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(81, 57);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(240, 21);
            this.txbPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "邮箱密码：";
            // 
            // tbxUserMail
            // 
            this.tbxUserMail.Location = new System.Drawing.Point(81, 20);
            this.tbxUserMail.Name = "tbxUserMail";
            this.tbxUserMail.Size = new System.Drawing.Size(240, 21);
            this.tbxUserMail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "邮箱地址：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lsttbxStatus);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.logingroupbox);
            this.panel1.Location = new System.Drawing.Point(8, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 412);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(366, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 412);
            this.panel2.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tabControlMyMailbox);
            this.groupBox2.Location = new System.Drawing.Point(3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 405);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "邮箱";
            // 
            // tabControlMyMailbox
            // 
            this.tabControlMyMailbox.Controls.Add(this.tabPageInbox);
            this.tabControlMyMailbox.Controls.Add(this.tabPageWriteLetter);
            this.tabControlMyMailbox.Location = new System.Drawing.Point(3, 18);
            this.tabControlMyMailbox.Name = "tabControlMyMailbox";
            this.tabControlMyMailbox.SelectedIndex = 0;
            this.tabControlMyMailbox.Size = new System.Drawing.Size(366, 390);
            this.tabControlMyMailbox.TabIndex = 0;
            // 
            // tabPageInbox
            // 
            this.tabPageInbox.Controls.Add(this.tbxMailboxInfo);
            this.tabPageInbox.Controls.Add(this.btnRefreshMailList);
            this.tabPageInbox.Controls.Add(this.btnReadMail);
            this.tabPageInbox.Controls.Add(this.btnDeleteMail);
            this.tabPageInbox.Controls.Add(this.btnDownLoad);
            this.tabPageInbox.Controls.Add(this.lstViewMailList);
            this.tabPageInbox.Location = new System.Drawing.Point(4, 22);
            this.tabPageInbox.Name = "tabPageInbox";
            this.tabPageInbox.Size = new System.Drawing.Size(358, 364);
            this.tabPageInbox.TabIndex = 0;
            this.tabPageInbox.Text = "收件箱";
            this.tabPageInbox.UseVisualStyleBackColor = true;
            // 
            // tb_popPort
            // 
            this.tb_popPort.Location = new System.Drawing.Point(286, 70);
            this.tb_popPort.Name = "tb_popPort";
            this.tb_popPort.Size = new System.Drawing.Size(41, 21);
            this.tb_popPort.TabIndex = 7;
            this.tb_popPort.Text = "110";
            // 
            // tb_smtpPort
            // 
            this.tb_smtpPort.Location = new System.Drawing.Point(286, 27);
            this.tb_smtpPort.Name = "tb_smtpPort";
            this.tb_smtpPort.Size = new System.Drawing.Size(41, 21);
            this.tb_smtpPort.TabIndex = 6;
            this.tb_smtpPort.Text = "25";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(245, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "端口：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(243, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "端口：";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(750, 430);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "邮件客户端（贺培超-1120171018）";
            this.tabPageWriteLetter.ResumeLayout(false);
            this.tabPageWriteLetter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.logingroupbox.ResumeLayout(false);
            this.logingroupbox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabControlMyMailbox.ResumeLayout(false);
            this.tabPageInbox.ResumeLayout(false);
            this.tabPageInbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox tbxMailboxInfo;
        private System.Windows.Forms.Button btnRefreshMailList;
        private System.Windows.Forms.Button btnReadMail;
        private System.Windows.Forms.Button btnDeleteMail;
        private System.Windows.Forms.Button btnDownLoad;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TabPage tabPageWriteLetter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.ComboBox cmbAttachment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richtbxBody;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbSubject;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbSendTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lstViewMailList;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListBox lsttbxStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxPOP3Server;
        private System.Windows.Forms.TextBox tbxSmtpServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox logingroupbox;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxUserMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControlMyMailbox;
        private System.Windows.Forms.TabPage tabPageInbox;
        private System.Windows.Forms.TextBox tb_popPort;
        private System.Windows.Forms.TextBox tb_smtpPort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

