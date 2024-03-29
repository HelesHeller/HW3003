using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        private TcpListener listener;
        private TcpClient client;
        private NetworkStream stream;

        public Form1()
        {
            InitializeComponent();
            startServerButton.Click += StartServerButton_Click;
        }
        private void StartServerButton_Click(object sender, EventArgs e)
        {
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            int port = 8888;
            listener = new TcpListener(ipAddress, port);
            listener.Start();

            Task.Run(() => ListenForClients());

            LogMessage("Сервер запущен и ожидает подключения...");
        }

        private async Task ListenForClients()
        {
            while (true)
            {
                client = await listener.AcceptTcpClientAsync();
                stream = client.GetStream();
                LogMessage("Клиент подключен.");

                await ReceiveImage();
            }
        }

        private async Task ReceiveImage()
        {
            while (true)
            {
                byte[] sizeBytes = new byte[sizeof(int)];
                await stream.ReadAsync(sizeBytes, 0, sizeBytes.Length);
                int imageSize = BitConverter.ToInt32(sizeBytes, 0);

                byte[] imageData = new byte[imageSize];
                int totalBytesRead = 0;
                while (totalBytesRead < imageSize)
                {
                    totalBytesRead += await stream.ReadAsync(imageData, totalBytesRead, imageSize - totalBytesRead);
                }

                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    Image image = Image.FromStream(ms);
                    DisplayImage(image);
                }

                await Task.Delay(60);
            }
        }
        private void DisplayImage(Image image)
        {
            if (screenPanel.InvokeRequired)
            {
                screenPanel.Invoke(new MethodInvoker(delegate { DisplayImage(image); }));
            }
            else
            {
                RemovePreviousPictureBox();
                AddNewPictureBox(image);
            }
        }
        private void RemovePreviousPictureBox()
        {
            foreach (Control control in screenPanel.Controls)
            {
                if (control is PictureBox)
                {
                    screenPanel.Controls.Remove(control);
                    control.Dispose();
                }
            }
        }
        private void AddNewPictureBox(Image image)
        {
            PictureBox newPictureBox = new PictureBox();
            newPictureBox.Dock = DockStyle.Fill;
            newPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            newPictureBox.Image = image;

            screenPanel.Controls.Add(newPictureBox);
        }
        private void LogMessage(string message)
        {
            if (logTextBox.InvokeRequired)
            {
                logTextBox.Invoke(new MethodInvoker(delegate { LogMessage(message); }));
            }
            else
            {
                logTextBox.AppendText(message + Environment.NewLine);
            }
        }
    }
}