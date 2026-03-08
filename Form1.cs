namespace CS_week01_25010012_MyBusinessCard
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

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            // 0~255 사이의 R, G, B 값을 무작위로 생성하여 배경색에 적용
            this.BackColor = Color.FromArgb(rd.Next(256), rd.Next(256), rd.Next(256));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/logeonwoo05-logan",
                UseShellExecute = true
            });
        }



        private void button3_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.two;
        }


       private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
         
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        }
    }
    }

