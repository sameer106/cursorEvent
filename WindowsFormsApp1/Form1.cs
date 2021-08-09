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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Thread t;
        public Form1()
        {
            t = new Thread(new ThreadStart(processStart));
            InitializeComponent();
            this.Visible = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t.Abort();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            t.Start();
        }

        private async void processStart()
        {
            while (true)
            {
                for (int i = 0; i < 20; i++)
                {
                    //this.Cursor = new Cursor(Cursor.Current.Handle);
                    Cursor.Position = new Point(Cursor.Position.X - 1, Cursor.Position.Y - 1);
                    Cursor.Clip = new Rectangle(this.Location, this.Size);

                    
                }
                SendKeys.SendWait("{Esc}");
                Thread.Sleep(1000 * 60 * 3);
            }
        }
    }
}
