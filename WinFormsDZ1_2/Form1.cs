using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDz_1_3
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MouseMove += MyMouseMove;
            this.MouseClick += MyMouseClick;
        }
        private void MyMouseClick(object sender, MouseEventArgs e)
        {
            string text = "";
            if (e.Button == MouseButtons.Left)
            {
                if (ModifierKeys == Keys.Control)
                {
                    Close();
                }

                if ((e.X < 10 || e.X > ClientSize.Width - 10) || (e.Y < 10 || e.Y > ClientSize.Height - 10))
                {
                    text = "Клик снаружи прямоугольника!";
                }
                else if ((e.X == 10 || e.X == ClientSize.Width - 10) || (e.Y == 10 || e.Y == ClientSize.Height - 10))
                {
                    text = "Клик на границе прямоугольника!";
                }
                else
                {
                    text = "Клик внутри прямоугольника!";
                }
                MessageBox.Show(text, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (e.Button == MouseButtons.Right)
            {
                Text = $"Размере клиентской области окна! Ширина = {ClientSize.Width}, Высота = {ClientSize.Height}";
                Thread.Sleep(2000);
            }
        }
        private void MyMouseMove(object sender, MouseEventArgs e)
        {
            Text = $"X {e.X} - Y {e.Y}";
        }
    }
}