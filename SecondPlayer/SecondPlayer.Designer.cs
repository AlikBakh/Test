namespace SecondPlayer
{
    public partial class SecondPlayer
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
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblAdrIP = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.lblRound = new System.Windows.Forms.Label();
            this.FirstAsk = new System.Windows.Forms.PictureBox();
            this.SecondAsk = new System.Windows.Forms.PictureBox();
            this.ConnectUserFirst = new System.Windows.Forms.Label();
            this.ConnectUserSecond = new System.Windows.Forms.Label();
            this.ServerStatus = new System.Windows.Forms.Label();
            this.RoundCount = new System.Windows.Forms.Label();
            this.WinFirst = new System.Windows.Forms.Label();
            this.WinSecond = new System.Windows.Forms.Label();
            this.Rock = new System.Windows.Forms.Button();
            this.Scissors = new System.Windows.Forms.Button();
            this.Paper = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ClearChat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FirstAsk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondAsk)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxChat
            // 
            this.listBoxChat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBoxChat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBoxChat.FormattingEnabled = true;
            this.listBoxChat.ItemHeight = 16;
            this.listBoxChat.Items.AddRange(new object[] {
            "Введите IP и номер порта, а затем",
            "нажмите на кнопку подключиться.",
            "===================================="});
            this.listBoxChat.Location = new System.Drawing.Point(641, 27);
            this.listBoxChat.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxChat.Name = "listBoxChat";
            this.listBoxChat.Size = new System.Drawing.Size(331, 148);
            this.listBoxChat.TabIndex = 88;
            this.listBoxChat.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxChat_DrawItem);
            this.listBoxChat.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.listBoxChat_MeasureItem);
            // 
            // lblChat
            // 
            this.lblChat.AutoSize = true;
            this.lblChat.Location = new System.Drawing.Point(638, 6);
            this.lblChat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChat.Name = "lblChat";
            this.lblChat.Size = new System.Drawing.Size(85, 17);
            this.lblChat.TabIndex = 87;
            this.lblChat.Text = "Общий чат:";
            // 
            // lblSendMsg
            // 
            this.lblSendMsg.AutoSize = true;
            this.lblSendMsg.Location = new System.Drawing.Point(353, 6);
            this.lblSendMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSendMsg.Name = "lblSendMsg";
            this.lblSendMsg.Size = new System.Drawing.Size(161, 17);
            this.lblSendMsg.TabIndex = 86;
            this.lblSendMsg.Text = "Отправить сообщение:";
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(356, 27);
            this.textBoxSend.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSend.Multiline = true;
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(277, 148);
            this.textBoxSend.TabIndex = 85;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(533, 183);
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
            this.lblPort.Location = new System.Drawing.Point(0, 70);
            this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(94, 17);
            this.lblPort.TabIndex = 83;
            this.lblPort.Text = "Номер порта";
            // 
            // lblAdrIP
            // 
            this.lblAdrIP.AutoSize = true;
            this.lblAdrIP.Location = new System.Drawing.Point(0, 30);
            this.lblAdrIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdrIP.Name = "lblAdrIP";
            this.lblAdrIP.Size = new System.Drawing.Size(121, 17);
            this.lblAdrIP.TabIndex = 82;
            this.lblAdrIP.Text = "IP адрес сервера";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(140, 122);
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
            this.textBoxPort.Location = new System.Drawing.Point(140, 66);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(132, 22);
            this.textBoxPort.TabIndex = 80;
            this.textBoxPort.Text = "777";
            this.textBoxPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(140, 27);
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
            this.lblRound.Location = new System.Drawing.Point(402, 215);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(54, 17);
            this.lblRound.TabIndex = 78;
            this.lblRound.Text = "Round:";
            // 
            // FirstAsk
            // 
            this.FirstAsk.ErrorImage = null;
            this.FirstAsk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FirstAsk.InitialImage = null;
            this.FirstAsk.Location = new System.Drawing.Point(502, 247);
            this.FirstAsk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FirstAsk.Name = "FirstAsk";
            this.FirstAsk.Size = new System.Drawing.Size(197, 149);
            this.FirstAsk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FirstAsk.TabIndex = 77;
            this.FirstAsk.TabStop = false;
            // 
            // SecondAsk
            // 
            this.SecondAsk.ErrorImage = null;
            this.SecondAsk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SecondAsk.InitialImage = null;
            this.SecondAsk.Location = new System.Drawing.Point(168, 247);
            this.SecondAsk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SecondAsk.Name = "SecondAsk";
            this.SecondAsk.Size = new System.Drawing.Size(197, 149);
            this.SecondAsk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SecondAsk.TabIndex = 76;
            this.SecondAsk.TabStop = false;
            // 
            // ConnectUserFirst
            // 
            this.ConnectUserFirst.AutoSize = true;
            this.ConnectUserFirst.Location = new System.Drawing.Point(620, 216);
            this.ConnectUserFirst.Name = "ConnectUserFirst";
            this.ConnectUserFirst.Size = new System.Drawing.Size(79, 17);
            this.ConnectUserFirst.TabIndex = 75;
            this.ConnectUserFirst.Text = "First Player";
            // 
            // ConnectUserSecond
            // 
            this.ConnectUserSecond.AutoSize = true;
            this.ConnectUserSecond.Location = new System.Drawing.Point(165, 216);
            this.ConnectUserSecond.Name = "ConnectUserSecond";
            this.ConnectUserSecond.Size = new System.Drawing.Size(33, 17);
            this.ConnectUserSecond.TabIndex = 74;
            this.ConnectUserSecond.Text = "You";
            // 
            // ServerStatus
            // 
            this.ServerStatus.AutoSize = true;
            this.ServerStatus.Location = new System.Drawing.Point(820, 405);
            this.ServerStatus.Name = "ServerStatus";
            this.ServerStatus.Size = new System.Drawing.Size(152, 17);
            this.ServerStatus.TabIndex = 73;
            this.ServerStatus.Text = "You are not connected";
            // 
            // RoundCount
            // 
            this.RoundCount.AutoSize = true;
            this.RoundCount.Location = new System.Drawing.Point(459, 215);
            this.RoundCount.Name = "RoundCount";
            this.RoundCount.Size = new System.Drawing.Size(16, 17);
            this.RoundCount.TabIndex = 72;
            this.RoundCount.Text = "0";
            // 
            // WinFirst
            // 
            this.WinFirst.AutoSize = true;
            this.WinFirst.Location = new System.Drawing.Point(467, 317);
            this.WinFirst.Name = "WinFirst";
            this.WinFirst.Size = new System.Drawing.Size(16, 17);
            this.WinFirst.TabIndex = 71;
            this.WinFirst.Text = "0";
            // 
            // WinSecond
            // 
            this.WinSecond.AutoSize = true;
            this.WinSecond.Location = new System.Drawing.Point(402, 317);
            this.WinSecond.Name = "WinSecond";
            this.WinSecond.Size = new System.Drawing.Size(16, 17);
            this.WinSecond.TabIndex = 70;
            this.WinSecond.Text = "0";
            // 
            // Rock
            // 
            this.Rock.Location = new System.Drawing.Point(50, 270);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(75, 23);
            this.Rock.TabIndex = 67;
            this.Rock.Text = "Rock";
            this.Rock.UseVisualStyleBackColor = true;
            this.Rock.Click += new System.EventHandler(this.Rock_Click);
            // 
            // Scissors
            // 
            this.Scissors.Location = new System.Drawing.Point(50, 311);
            this.Scissors.Name = "Scissors";
            this.Scissors.Size = new System.Drawing.Size(75, 23);
            this.Scissors.TabIndex = 65;
            this.Scissors.Text = "Scissors";
            this.Scissors.UseVisualStyleBackColor = true;
            this.Scissors.Click += new System.EventHandler(this.Scissors_Click);
            // 
            // Paper
            // 
            this.Paper.Location = new System.Drawing.Point(50, 352);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(75, 23);
            this.Paper.TabIndex = 69;
            this.Paper.Text = "Paper";
            this.Paper.UseVisualStyleBackColor = true;
            this.Paper.Click += new System.EventHandler(this.Paper_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(402, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 89;
            this.label6.Text = "_________";
            // 
            // ClearChat
            // 
            this.ClearChat.Location = new System.Drawing.Point(862, 183);
            this.ClearChat.Name = "ClearChat";
            this.ClearChat.Size = new System.Drawing.Size(110, 28);
            this.ClearChat.TabIndex = 90;
            this.ClearChat.Text = "Очистить чат";
            this.ClearChat.UseVisualStyleBackColor = true;
            this.ClearChat.Click += new System.EventHandler(this.ClearChat_Click);
            // 
            // SecondPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(986, 426);
            this.Controls.Add(this.ClearChat);
            this.Controls.Add(this.listBoxChat);
            this.Controls.Add(this.lblChat);
            this.Controls.Add(this.lblSendMsg);
            this.Controls.Add(this.textBoxSend);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblAdrIP);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.FirstAsk);
            this.Controls.Add(this.SecondAsk);
            this.Controls.Add(this.ConnectUserFirst);
            this.Controls.Add(this.ConnectUserSecond);
            this.Controls.Add(this.ServerStatus);
            this.Controls.Add(this.RoundCount);
            this.Controls.Add(this.WinFirst);
            this.Controls.Add(this.WinSecond);
            this.Controls.Add(this.Rock);
            this.Controls.Add(this.Scissors);
            this.Controls.Add(this.Paper);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SecondPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Second Player";
            ((System.ComponentModel.ISupportInitialize)(this.FirstAsk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondAsk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBoxChat;
        public System.Windows.Forms.Label lblChat;
        public System.Windows.Forms.Label lblSendMsg;
        public System.Windows.Forms.TextBox textBoxSend;
        public System.Windows.Forms.Button buttonSend;
        public System.Windows.Forms.Label lblPort;
        public System.Windows.Forms.Label lblAdrIP;
        public System.Windows.Forms.Button buttonConnect;
        public System.Windows.Forms.TextBox textBoxPort;
        public System.Windows.Forms.TextBox textBoxIP;
        public System.Windows.Forms.Label lblRound;
        public System.Windows.Forms.PictureBox FirstAsk;
        public System.Windows.Forms.PictureBox SecondAsk;
        public System.Windows.Forms.Label ConnectUserFirst;         
        public System.Windows.Forms.Label ConnectUserSecond;        
        public System.Windows.Forms.Label ServerStatus;
        public System.Windows.Forms.Label RoundCount;
        public System.Windows.Forms.Label WinFirst;     
        public System.Windows.Forms.Label WinSecond;    
        public System.Windows.Forms.Button Rock;
        public System.Windows.Forms.Button Scissors;
        public System.Windows.Forms.Button Paper;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button ClearChat;
    }
}

