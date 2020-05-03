namespace FirstPlayer
{
    partial class FirstPlayer
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
            this.listBoxChat = new System.Windows.Forms.ListBox();
            this.lblChat = new System.Windows.Forms.Label();
            this.lblSendMsg = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblAdrIP = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.lblRound = new System.Windows.Forms.Label();
            this.User2Ask = new System.Windows.Forms.PictureBox();
            this.User1Ask = new System.Windows.Forms.PictureBox();
            this.ConnectUser2 = new System.Windows.Forms.Label();
            this.ConnectUser1 = new System.Windows.Forms.Label();
            this.ServerStatus = new System.Windows.Forms.Label();
            this.RoundCount = new System.Windows.Forms.Label();
            this.L = new System.Windows.Forms.Label();
            this.W = new System.Windows.Forms.Label();
            this.RockU1 = new System.Windows.Forms.Button();
            this.PaperU2 = new System.Windows.Forms.Button();
            this.ScissorsU1 = new System.Windows.Forms.Button();
            this.PaperU1 = new System.Windows.Forms.Button();
            this.RockU2 = new System.Windows.Forms.Button();
            this.ScissorsU2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.User2Ask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User1Ask)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxChat
            // 
            this.listBoxChat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBoxChat.FormattingEnabled = true;
            this.listBoxChat.ItemHeight = 16;
            this.listBoxChat.Items.AddRange(new object[] {
            "Введите IP и номер порта, а затем",
            "нажмите на кнопку подключиться.",
            "===================================="});
            this.listBoxChat.Location = new System.Drawing.Point(641, 27);
            this.listBoxChat.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxChat.Name = "listBoxChat";
            this.listBoxChat.ScrollAlwaysVisible = true;
            this.listBoxChat.Size = new System.Drawing.Size(331, 148);
            this.listBoxChat.TabIndex = 88;
            this.listBoxChat.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            this.listBoxChat.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.listBox1_MeasureItem);
            // 
            // lblChat
            // 
            this.lblChat.AutoSize = true;
            this.lblChat.Location = new System.Drawing.Point(638, 4);
            this.lblChat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChat.Name = "lblChat";
            this.lblChat.Size = new System.Drawing.Size(85, 17);
            this.lblChat.TabIndex = 87;
            this.lblChat.Text = "Общий чат:";
            // 
            // lblSendMsg
            // 
            this.lblSendMsg.AutoSize = true;
            this.lblSendMsg.Location = new System.Drawing.Point(353, 4);
            this.lblSendMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSendMsg.Name = "lblSendMsg";
            this.lblSendMsg.Size = new System.Drawing.Size(161, 17);
            this.lblSendMsg.TabIndex = 86;
            this.lblSendMsg.Text = "Отправить сообщение:";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(356, 183);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(100, 28);
            this.buttonSend.TabIndex = 84;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(3, 95);
            this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(94, 17);
            this.lblPort.TabIndex = 83;
            this.lblPort.Text = "Номер порта";
            // 
            // lblAdrIP
            // 
            this.lblAdrIP.AutoSize = true;
            this.lblAdrIP.Location = new System.Drawing.Point(3, 55);
            this.lblAdrIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdrIP.Name = "lblAdrIP";
            this.lblAdrIP.Size = new System.Drawing.Size(121, 17);
            this.lblAdrIP.TabIndex = 82;
            this.lblAdrIP.Text = "IP адрес сервера";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(143, 147);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(133, 28);
            this.buttonConnect.TabIndex = 81;
            this.buttonConnect.Text = "Подключиться";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(143, 91);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(132, 22);
            this.textBoxPort.TabIndex = 80;
            this.textBoxPort.Text = "777";
            this.textBoxPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(143, 52);
            this.textBoxIP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(132, 22);
            this.textBoxIP.TabIndex = 79;
            this.textBoxIP.Text = "127.0.0.1";
            this.textBoxIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Location = new System.Drawing.Point(353, 240);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(54, 17);
            this.lblRound.TabIndex = 78;
            this.lblRound.Text = "Round:";
            // 
            // User2Ask
            // 
            this.User2Ask.ErrorImage = null;
            this.User2Ask.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.User2Ask.InitialImage = null;
            this.User2Ask.Location = new System.Drawing.Point(453, 272);
            this.User2Ask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.User2Ask.Name = "User2Ask";
            this.User2Ask.Size = new System.Drawing.Size(197, 149);
            this.User2Ask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.User2Ask.TabIndex = 77;
            this.User2Ask.TabStop = false;
            // 
            // User1Ask
            // 
            this.User1Ask.ErrorImage = null;
            this.User1Ask.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.User1Ask.InitialImage = null;
            this.User1Ask.Location = new System.Drawing.Point(119, 272);
            this.User1Ask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.User1Ask.Name = "User1Ask";
            this.User1Ask.Size = new System.Drawing.Size(197, 149);
            this.User1Ask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.User1Ask.TabIndex = 76;
            this.User1Ask.TabStop = false;
            // 
            // ConnectUser2
            // 
            this.ConnectUser2.AutoSize = true;
            this.ConnectUser2.Location = new System.Drawing.Point(545, 240);
            this.ConnectUser2.Name = "ConnectUser2";
            this.ConnectUser2.Size = new System.Drawing.Size(51, 17);
            this.ConnectUser2.TabIndex = 75;
            this.ConnectUser2.Text = "Enemy";
            // 
            // ConnectUser1
            // 
            this.ConnectUser1.AutoSize = true;
            this.ConnectUser1.Location = new System.Drawing.Point(116, 241);
            this.ConnectUser1.Name = "ConnectUser1";
            this.ConnectUser1.Size = new System.Drawing.Size(33, 17);
            this.ConnectUser1.TabIndex = 74;
            this.ConnectUser1.Text = "You";
            // 
            // ServerStatus
            // 
            this.ServerStatus.AutoSize = true;
            this.ServerStatus.Location = new System.Drawing.Point(820, 457);
            this.ServerStatus.Name = "ServerStatus";
            this.ServerStatus.Size = new System.Drawing.Size(152, 17);
            this.ServerStatus.TabIndex = 73;
            this.ServerStatus.Text = "You are not connected";
            // 
            // RoundCount
            // 
            this.RoundCount.AutoSize = true;
            this.RoundCount.Location = new System.Drawing.Point(410, 240);
            this.RoundCount.Name = "RoundCount";
            this.RoundCount.Size = new System.Drawing.Size(16, 17);
            this.RoundCount.TabIndex = 72;
            this.RoundCount.Text = "0";
            // 
            // L
            // 
            this.L.AutoSize = true;
            this.L.Location = new System.Drawing.Point(418, 342);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(16, 17);
            this.L.TabIndex = 71;
            this.L.Text = "0";
            // 
            // W
            // 
            this.W.AutoSize = true;
            this.W.Location = new System.Drawing.Point(353, 342);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(16, 17);
            this.W.TabIndex = 70;
            this.W.Text = "0";
            // 
            // RockU1
            // 
            this.RockU1.Location = new System.Drawing.Point(1, 295);
            this.RockU1.Name = "RockU1";
            this.RockU1.Size = new System.Drawing.Size(75, 23);
            this.RockU1.TabIndex = 67;
            this.RockU1.Text = "Rock";
            this.RockU1.UseVisualStyleBackColor = true;
            this.RockU1.Click += new System.EventHandler(this.RockU1_Click);
            // 
            // PaperU2
            // 
            this.PaperU2.Location = new System.Drawing.Point(699, 377);
            this.PaperU2.Name = "PaperU2";
            this.PaperU2.Size = new System.Drawing.Size(75, 23);
            this.PaperU2.TabIndex = 66;
            this.PaperU2.Text = "Paper";
            this.PaperU2.UseVisualStyleBackColor = true;
            this.PaperU2.Click += new System.EventHandler(this.PaperU2_Click);
            // 
            // ScissorsU1
            // 
            this.ScissorsU1.Location = new System.Drawing.Point(1, 336);
            this.ScissorsU1.Name = "ScissorsU1";
            this.ScissorsU1.Size = new System.Drawing.Size(75, 23);
            this.ScissorsU1.TabIndex = 65;
            this.ScissorsU1.Text = "Scissors";
            this.ScissorsU1.UseVisualStyleBackColor = true;
            this.ScissorsU1.Click += new System.EventHandler(this.ScissorsU1_Click);
            // 
            // PaperU1
            // 
            this.PaperU1.Location = new System.Drawing.Point(1, 377);
            this.PaperU1.Name = "PaperU1";
            this.PaperU1.Size = new System.Drawing.Size(75, 23);
            this.PaperU1.TabIndex = 69;
            this.PaperU1.Text = "Paper";
            this.PaperU1.UseVisualStyleBackColor = true;
            this.PaperU1.Click += new System.EventHandler(this.PaperU1_Click);
            // 
            // RockU2
            // 
            this.RockU2.Location = new System.Drawing.Point(699, 295);
            this.RockU2.Name = "RockU2";
            this.RockU2.Size = new System.Drawing.Size(75, 23);
            this.RockU2.TabIndex = 64;
            this.RockU2.Text = "Rock";
            this.RockU2.UseVisualStyleBackColor = true;
            this.RockU2.Click += new System.EventHandler(this.RockU2_Click);
            // 
            // ScissorsU2
            // 
            this.ScissorsU2.Location = new System.Drawing.Point(699, 336);
            this.ScissorsU2.Name = "ScissorsU2";
            this.ScissorsU2.Size = new System.Drawing.Size(75, 23);
            this.ScissorsU2.TabIndex = 68;
            this.ScissorsU2.Text = "Scissors";
            this.ScissorsU2.UseVisualStyleBackColor = true;
            this.ScissorsU2.Click += new System.EventHandler(this.ScissorsU2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 89;
            this.label6.Text = "_________";
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(355, 27);
            this.textBoxSend.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSend.Multiline = true;
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(277, 148);
            this.textBoxSend.TabIndex = 90;
            // 
            // FirstPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(986, 483);
            this.Controls.Add(this.textBoxSend);
            this.Controls.Add(this.listBoxChat);
            this.Controls.Add(this.lblChat);
            this.Controls.Add(this.lblSendMsg);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblAdrIP);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.User2Ask);
            this.Controls.Add(this.User1Ask);
            this.Controls.Add(this.ConnectUser2);
            this.Controls.Add(this.ConnectUser1);
            this.Controls.Add(this.ServerStatus);
            this.Controls.Add(this.RoundCount);
            this.Controls.Add(this.L);
            this.Controls.Add(this.W);
            this.Controls.Add(this.RockU1);
            this.Controls.Add(this.PaperU2);
            this.Controls.Add(this.ScissorsU1);
            this.Controls.Add(this.PaperU1);
            this.Controls.Add(this.RockU2);
            this.Controls.Add(this.ScissorsU2);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FirstPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "First Player";
            ((System.ComponentModel.ISupportInitialize)(this.User2Ask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.User1Ask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxChat;
        private System.Windows.Forms.Label lblChat;
        private System.Windows.Forms.Label lblSendMsg;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblAdrIP;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.PictureBox User2Ask;
        private System.Windows.Forms.PictureBox User1Ask;
        private System.Windows.Forms.Label ConnectUser2;
        private System.Windows.Forms.Label ConnectUser1;
        public System.Windows.Forms.Label ServerStatus;
        private System.Windows.Forms.Label RoundCount;
        private System.Windows.Forms.Label L;
        private System.Windows.Forms.Label W;
        private System.Windows.Forms.Button RockU1;
        private System.Windows.Forms.Button PaperU2;
        private System.Windows.Forms.Button ScissorsU1;
        private System.Windows.Forms.Button PaperU1;
        private System.Windows.Forms.Button RockU2;
        private System.Windows.Forms.Button ScissorsU2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSend;
    }
}