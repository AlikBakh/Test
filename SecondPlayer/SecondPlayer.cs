using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;


namespace SecondPlayer
{
    public partial class SecondPlayer : Form, IGameInteractive
    {
        public SecondPlayer()
        {
            InitializeComponent();
            KeyPreview = true;

            RockU2.Enabled = false;
            ScissorsU2.Enabled = false;
            PaperU2.Enabled = false;

            User1Ask.Visible = false;
            User2Ask.Visible = false;

            listBoxChat.HorizontalScrollbar = true;
        }
        #region Game
        void HotKeys_KeyDown(object sender, KeyEventArgs e)//горячме клавиши
        {
            if (e.KeyCode == Keys.Z)
            {
                RockU1.PerformClick();
            }
            if (e.KeyCode == Keys.X)
            {
                ScissorsU1.PerformClick();
            }
            if (e.KeyCode == Keys.C)
            {
                PaperU1.PerformClick();
            }
        }

        public const int rock = (int)Item.Rock;
        public const int scissors= (int)Item.Scissors;
        public const int paper = (int)Item.Paper;

        public bool flagItemRock2 = true;
        public bool flagItemScissors2 = true;
        public bool flagItemPaper2 = true;


        public  int User1Choose = 0;//дальнейшее значение предмета у 1-го игрока будет записан в майчуз
        public void RockU1_Click(object sender, EventArgs e)//камень
        {
            User1Choose = rock;
            Score(User1Choose, User2Choose);



            RockU1.Enabled = false;
            ScissorsU1.Enabled = false;
            PaperU1.Enabled = false;

            RockU2.Enabled = true;
            ScissorsU2.Enabled = true;
            PaperU2.Enabled = true;

            User1Ask.Visible = false;
            User2Ask.Visible = false;
        }
        public void ScissorsU1_Click(object sender, EventArgs e)//ножницы
        {
            User1Choose = (int)Item.Scissors;
            Score(User1Choose, User2Choose);

            RockU1.Enabled = false;
            ScissorsU1.Enabled = false;
            PaperU1.Enabled = false;

            RockU2.Enabled = true;
            ScissorsU2.Enabled = true;
            PaperU2.Enabled = true;

            User1Ask.Visible = false;
            User2Ask.Visible = false;
        }
        public void PaperU1_Click(object sender, EventArgs e)//бумага
        {
            User1Choose = (int)Item.Paper;
            Score(User1Choose, User2Choose);

            RockU1.Enabled = false;
            ScissorsU1.Enabled = false;
            PaperU1.Enabled = false;

            RockU2.Enabled = true;
            ScissorsU2.Enabled = true;
            PaperU2.Enabled = true;

            User1Ask.Visible = false;
            User2Ask.Visible = false;
        }



        public int User2Choose = 0;//дальнейшее значение предмета у 2-го игрока будет записан в майчуз
        public void RockU2_Click(object sender, EventArgs e)//камень
        {
            User2Choose = rock;
            Score(User1Choose, User2Choose);

            RockU2.Enabled = false;
            ScissorsU2.Enabled = false;
            PaperU2.Enabled = false;

            RockU1.Enabled = true;
            ScissorsU1.Enabled = true;
            PaperU1.Enabled = true;

            User1Ask.Visible = true;
            User2Ask.Visible = true;
        }
        public void ScissorsU2_Click(object sender, EventArgs e)//ножницы
        {
            User2Choose = (int)Item.Scissors;
            Score(User1Choose, User2Choose);

            RockU2.Enabled = false;
            ScissorsU2.Enabled = false;
            PaperU2.Enabled = false;

            RockU1.Enabled = true;
            ScissorsU1.Enabled = true;
            PaperU1.Enabled = true;

            User1Ask.Visible = true;
            User2Ask.Visible = true;
        }
        public void PaperU2_Click(object sender, EventArgs e)//бумага
        {
            User2Choose = (int)Item.Paper;

            Score(User1Choose, User2Choose);

            RockU2.Enabled = false;
            ScissorsU2.Enabled = false;
            PaperU2.Enabled = false;

            RockU1.Enabled = true;
            ScissorsU1.Enabled = true;
            PaperU1.Enabled = true;

            User1Ask.Visible = true;
            User2Ask.Visible = true;
        }



        public int User1Win;
        public int User2Win;
        public int Rounds;
        public void Score(int user1, int user2)
        {
            if (User1Choose == rock)
                User1Ask.Image = Properties.Resources.urock;
            if (User1Choose == (int)Item.Scissors)
                User1Ask.Image = Properties.Resources.uscissors;
            if (User1Choose == (int)Item.Paper)
                User1Ask.Image = Properties.Resources.upaper;

            if (User2Choose == rock)
                User2Ask.Image = Properties.Resources.crock;
            if (User2Choose == (int)Item.Scissors)
                User2Ask.Image = Properties.Resources.csccissors;
            if (User2Choose == (int)Item.Paper)
                User2Ask.Image = Properties.Resources.cpaper;

            if (((User1Choose == rock) && (User2Choose == (int)Item.Scissors)) || ((User1Choose == (int)Item.Scissors) && (User2Choose == (int)Item.Paper)) || ((User1Choose == (int)Item.Paper) && (User2Choose == rock)))
            {
                User1Win++;
                W.Text = User1Win.ToString();
                User1Choose = 0;
                User2Choose = 0;

                RockU1.Enabled = true;
                ScissorsU1.Enabled = true;
                PaperU1.Enabled = true;

                RockU2.Enabled = true;
                ScissorsU2.Enabled = true;
                PaperU2.Enabled = true;


            }
            if (((User1Choose == (int)Item.Scissors) && (User2Choose == rock)) || ((User1Choose == (int)Item.Paper) && (User2Choose == (int)Item.Scissors)) || ((User1Choose == rock) && (User2Choose == (int)Item.Paper)))
            {
                User2Win++;
                L.Text = User2Win.ToString();
                User1Choose = 0;
                User2Choose = 0;

                RockU1.Enabled = true;
                ScissorsU1.Enabled = true;
                PaperU1.Enabled = true;

                RockU2.Enabled = true;
                ScissorsU2.Enabled = true;
                PaperU2.Enabled = true;
            }
            if (User1Choose == User2Choose)
            {
                Rounds++;
                RoundCount.Text = Rounds.ToString();
                User1Choose = 0;
                User2Choose = 0;
            }
        }
        #endregion

        //TcpClient tcpClient = new TcpClient();
        //IPAddress locaddr = IPAddress.Parse("127.0.0.1");
        //int port = 1434;
        // Объект содержащий рабочий сокет клиентского приложения
        TcpClient tcpСlient = new TcpClient();

        // Объект сетевого потока для приема и отправки сообщений
        NetworkStream ns;

        // Флаг для остановки потоков и завершения сетевой работы приложения
        bool stopNetwork;

        #region Управление клиентским приложением

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            ConnectGame();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DisconnectGame();
        }

        #endregion


        #region Функциональная часть Сетевая работа
        
        public void ConnectGame()// Попытка подключения к серверу
        {
            try
            {
                tcpСlient.Connect(textBoxIP.Text, int.Parse(textBoxPort.Text));
                ns = tcpСlient.GetStream();
                listBoxChat.Items.Add("Добро пожаловать!");
                listBoxChat.Items.Add("==================================");

                Thread th = new Thread(ReceiveRun);
                th.Start();
                // Рандомное цветовое оповещение о подключении.
                Random random = new Random();
                BackColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                ServerStatus.Text = "Successful connection";
            }
            catch
            {
                BackColor = Color.Gray;
                ServerStatus.ForeColor = Color.Red;
                ServerStatus.Text = "You are disconnected";
                listBoxChat.Items.Add("Произошла ошибка при запуске сервера.");
                listBoxChat.Items.Add("==================================");
                ErrorSound();
            }
        }

        public void DisconnectGame()//отключение
        {
            if (ns != null) ns.Close();
            if (tcpСlient != null) tcpСlient.Close();
            stopNetwork = true;
            // Цветовое оповещение об отключении.
            BackColor = Color.FromName("White");
            ServerStatus.ForeColor = Color.Red;
            ServerStatus.Text = "You are disconnected";
        }
        


        void SendMessage()
        {
            if (ns != null)
            {
                byte[] buffer = Encoding.Default.GetBytes(textBoxSend.Text);
                ns.Write(buffer, 0, buffer.Length);
            }
        }


        // Цикл извлечения сообщений, запускается в отдельном потоке.
        void ReceiveRun()
        {
            while (true)
            {
                try
                {
                    string s = null;
                    while (ns.DataAvailable == true)
                    {
                        // Определение необходимого размера буфера приема.
                        byte[] buffer = new byte[tcpСlient.Available];

                        ns.Read(buffer, 0, buffer.Length);
                        s += Encoding.Default.GetString(buffer);
                    }

                    if (s != null)
                    {
                        ShowReceiveMessage(s);
                        s = String.Empty;
                    }

                    Thread.Sleep(100);
                }
                catch
                {
                    ErrorSound();
                }

                if (stopNetwork == true) break;

            }
        }
        #endregion


        #region Информации о сетевой работе

        // Код доступа к свойствам объектов главной формы  из других потоков
        delegate void UpdateReceiveDisplayDelegate(string message);
        void ShowReceiveMessage(string message)
        {
            if (listBoxChat.InvokeRequired == true)
            {
                UpdateReceiveDisplayDelegate rdd = new UpdateReceiveDisplayDelegate(ShowReceiveMessage);

                // Данный метод вызывается в дочернем потоке,  ищет основной поток и
                //выполняет делегат указанный в качестве параметра в главном потоке, безопасно обновляя интерфейс формы.
                Invoke(rdd, new object[] { message });
            }
            else
            {
                // Если не требуется вызывать метод Invoke, обратимся напрямую к элементу формы.
                listBoxChat.Items.Add(message);

            }
        }

        // Звуковое оповещение о перехваченной ошибке.
        void ErrorSound()
        {
            Console.Beep(2000, 80);
            Console.Beep(3000, 120);
        }


        #endregion
        #region Перенос строки в листбоксе


        private void listBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(listBoxChat.Items[e.Index].ToString(), listBoxChat.Font, listBoxChat.Width).Height;
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (listBoxChat.Items.Count > 0)
            {
                e.DrawBackground();
                e.DrawFocusRectangle();
                e.Graphics.DrawString(listBoxChat.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            }
        }
        #endregion
    
    }
}