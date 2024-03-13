using System.Net.Http;
using System.Net.Sockets;
using System.Text;

namespace serverVis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using var tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                await tcpClient.ConnectAsync("192.168.220.241", 12345);
                while (true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int ipAd;
            Console.ReadLine();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int iport;
            Console.ReadLine();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private async void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
