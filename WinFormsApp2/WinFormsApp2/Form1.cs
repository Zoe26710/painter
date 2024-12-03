using System.Drawing.Imaging;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(800, 600);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
        }


        private void �B�s�ɮ�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save(@"C:\Users\User\Desktop\1.png", ImageFormat.Png);
            MessageBox.Show("�s�ɦ��\");
        }


        int x, y;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        int pen_color = 0;
        int pen_width = 1;
        int p_style = 0;


        private void �Ŧ�ToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);

                if (pen_color == 0)
                {
                    Pen p = new Pen(Color.Black, pen_width);
                    g.DrawLine(p, x, y, e.X, e.Y);
                   
                }
                else if (pen_color == 1)
                {
                    Pen p = new Pen(Color.DeepSkyBlue, pen_width);
                    g.DrawLine(p, x, y, e.X, e.Y);
                }
                else if (pen_color == 2)
                {
                    Pen p = new Pen(Color.Red, pen_width);
                    g.DrawLine(p, x, y, e.X, e.Y);
                }
                else if (pen_color == 3)
                {
                    Pen p = new Pen(Color.LimeGreen, pen_width);
                    g.DrawLine(p, x, y, e.X, e.Y);
                }
                else if (pen_color == 4)
                {
                    Pen p = new Pen(Color.Khaki, pen_width);
                    g.DrawLine(p, x, y, e.X, e.Y);
                }
                else if (pen_color == 5)
                {
                    Pen p = new Pen(Color.LightPink, pen_width);
                    g.DrawLine(p, x, y, e.X, e.Y);
                }
                else if (pen_color == 6)
                {
                    Pen p = new Pen(Color.MediumPurple, pen_width);
                    g.DrawLine(p, x, y, e.X, e.Y);
                }

                x = e.X;
                y = e.Y;
                pictureBox1.Refresh();
            }
        }


        private void �¦�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen_color = 0;
        }
        private void �Ŧ�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen_color = 1;
        }
        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen_color = 2;
        }

        private void ���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen_color = 3;
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen_color = 4;
        }


        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen_color = 5;

        }
        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen_color = 6;
        }
        private void ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen_width = 1;
        }

        private void ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen_width = 3;
        }

        private void ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen_width = 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(800, 600);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
        }

        
    }
}