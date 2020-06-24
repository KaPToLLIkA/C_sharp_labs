namespace LAB3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.chatPage = new System.Windows.Forms.TabPage();
            this.ChannelBox = new System.Windows.Forms.ComboBox();
            this.sendMsgButton = new System.Windows.Forms.Button();
            this.inputMsg = new System.Windows.Forms.TextBox();
            this.authRegPage = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.inputIP = new System.Windows.Forms.TextBox();
            this.buttonReg = new System.Windows.Forms.Button();
            this.buttonAuth = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.serverAnswers = new System.Windows.Forms.ListBox();
            this.msgList = new System.Windows.Forms.ListBox();
            this.tabControl.SuspendLayout();
            this.chatPage.SuspendLayout();
            this.authRegPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.chatPage);
            this.tabControl.Controls.Add(this.authRegPage);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(558, 729);
            this.tabControl.TabIndex = 0;
            // 
            // chatPage
            // 
            this.chatPage.Controls.Add(this.msgList);
            this.chatPage.Controls.Add(this.ChannelBox);
            this.chatPage.Controls.Add(this.sendMsgButton);
            this.chatPage.Controls.Add(this.inputMsg);
            this.chatPage.Location = new System.Drawing.Point(4, 25);
            this.chatPage.Name = "chatPage";
            this.chatPage.Padding = new System.Windows.Forms.Padding(3);
            this.chatPage.Size = new System.Drawing.Size(550, 700);
            this.chatPage.TabIndex = 0;
            this.chatPage.Text = "Chat";
            this.chatPage.UseVisualStyleBackColor = true;
            // 
            // ChannelBox
            // 
            this.ChannelBox.FormattingEnabled = true;
            this.ChannelBox.Location = new System.Drawing.Point(6, 7);
            this.ChannelBox.Name = "ChannelBox";
            this.ChannelBox.Size = new System.Drawing.Size(538, 24);
            this.ChannelBox.TabIndex = 3;
            this.ChannelBox.SelectedIndexChanged += new System.EventHandler(this.ChannelBox_SelectedIndexChanged);
            // 
            // sendMsgButton
            // 
            this.sendMsgButton.Location = new System.Drawing.Point(408, 672);
            this.sendMsgButton.Name = "sendMsgButton";
            this.sendMsgButton.Size = new System.Drawing.Size(136, 23);
            this.sendMsgButton.TabIndex = 2;
            this.sendMsgButton.Text = "SEND";
            this.sendMsgButton.UseVisualStyleBackColor = true;
            this.sendMsgButton.Click += new System.EventHandler(this.sendMsgButton_Click);
            // 
            // inputMsg
            // 
            this.inputMsg.Location = new System.Drawing.Point(6, 672);
            this.inputMsg.Name = "inputMsg";
            this.inputMsg.Size = new System.Drawing.Size(395, 22);
            this.inputMsg.TabIndex = 1;
            // 
            // authRegPage
            // 
            this.authRegPage.Controls.Add(this.serverAnswers);
            this.authRegPage.Controls.Add(this.label4);
            this.authRegPage.Controls.Add(this.inputIP);
            this.authRegPage.Controls.Add(this.buttonReg);
            this.authRegPage.Controls.Add(this.buttonAuth);
            this.authRegPage.Controls.Add(this.label3);
            this.authRegPage.Controls.Add(this.inputPassword);
            this.authRegPage.Controls.Add(this.label2);
            this.authRegPage.Controls.Add(this.inputName);
            this.authRegPage.Location = new System.Drawing.Point(4, 25);
            this.authRegPage.Name = "authRegPage";
            this.authRegPage.Padding = new System.Windows.Forms.Padding(3);
            this.authRegPage.Size = new System.Drawing.Size(550, 700);
            this.authRegPage.TabIndex = 1;
            this.authRegPage.Text = "Auth/Reg";
            this.authRegPage.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "IP:";
            // 
            // inputIP
            // 
            this.inputIP.Location = new System.Drawing.Point(89, 62);
            this.inputIP.Name = "inputIP";
            this.inputIP.Size = new System.Drawing.Size(455, 22);
            this.inputIP.TabIndex = 8;
            // 
            // buttonReg
            // 
            this.buttonReg.Location = new System.Drawing.Point(89, 90);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(202, 23);
            this.buttonReg.TabIndex = 6;
            this.buttonReg.Text = "REGISTER";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // buttonAuth
            // 
            this.buttonAuth.Location = new System.Drawing.Point(345, 90);
            this.buttonAuth.Name = "buttonAuth";
            this.buttonAuth.Size = new System.Drawing.Size(202, 23);
            this.buttonAuth.TabIndex = 4;
            this.buttonAuth.Text = "LOGIN";
            this.buttonAuth.UseVisualStyleBackColor = true;
            this.buttonAuth.Click += new System.EventHandler(this.buttonAuth_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // inputPassword
            // 
            this.inputPassword.Location = new System.Drawing.Point(89, 34);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(455, 22);
            this.inputPassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(89, 6);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(455, 22);
            this.inputName.TabIndex = 0;
            // 
            // serverAnswers
            // 
            this.serverAnswers.FormattingEnabled = true;
            this.serverAnswers.ItemHeight = 16;
            this.serverAnswers.Location = new System.Drawing.Point(6, 179);
            this.serverAnswers.Name = "serverAnswers";
            this.serverAnswers.Size = new System.Drawing.Size(538, 516);
            this.serverAnswers.TabIndex = 10;
            this.serverAnswers.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // msgList
            // 
            this.msgList.FormattingEnabled = true;
            this.msgList.ItemHeight = 16;
            this.msgList.Location = new System.Drawing.Point(7, 38);
            this.msgList.Name = "msgList";
            this.msgList.Size = new System.Drawing.Size(537, 628);
            this.msgList.TabIndex = 4;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(582, 753);
            this.Controls.Add(this.tabControl);
            this.MaximumSize = new System.Drawing.Size(600, 800);
            this.MinimumSize = new System.Drawing.Size(600, 800);
            this.Name = "Form1";
            this.tabControl.ResumeLayout(false);
            this.chatPage.ResumeLayout(false);
            this.chatPage.PerformLayout();
            this.authRegPage.ResumeLayout(false);
            this.authRegPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

       
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage chatPage;
        private System.Windows.Forms.TabPage authRegPage;
        private System.Windows.Forms.ComboBox ChannelBox;
        private System.Windows.Forms.Button sendMsgButton;
        private System.Windows.Forms.TextBox inputMsg;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Button buttonAuth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputIP;
        private System.Windows.Forms.ListBox serverAnswers;
        private System.Windows.Forms.ListBox msgList;
    }
}

