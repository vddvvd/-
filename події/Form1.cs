using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace події
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
      

        }




        public static int eCount = 0;
        public void MyMetod(object sender, EventArgs e)
        { eCount++; 
            Control c = (Control)sender;
            
            c.Text = "Подія номер " +  eCount.ToString();
            if(eCount > 5 ) c.BackColor = Color.Green;
            if (eCount > 7) c.ForeColor = Color.Yellow;
        }
        public void MyMetodUp(object sender, EventArgs e)
        {
            Control c1 = (Control)sender;
            int x = c1.Location.X;
            int y = c1.Location.Y;  
            c1.Location = new Point(x, y-10);  
        }
        public void MyMetodDown(object sender, EventArgs e)
        {
            Control c1 = (Control)sender;
            int x = c1.Location.X;
            int y = c1.Location.Y;
            c1.Location = new Point(x, y + 10);
        }



        private void start_Click(object sender, EventArgs e)
        {
            if(start.Text == "Start")
            {
                textBox1.Click += MyMetod;
                button1.Click += MyMetod;   
                label1.Click += MyMetod;
                start.Text = "Stop";
            }
            else
            {
                textBox1.Click -= MyMetod;
                button1.Click -= MyMetod;
                label1.Click -= MyMetod;
                start.Text = "Start";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Click += MyMetodUp;
            button1.Click += MyMetodUp;
            label1.Click += MyMetodUp;
            textBox1.Click -= MyMetodDown;
            button1.Click -= MyMetodDown;
            label1.Click -= MyMetodDown;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Click += MyMetodDown;
            button1.Click += MyMetodDown;
            label1.Click += MyMetodDown;
            textBox1.Click -= MyMetodUp;
            button1.Click -= MyMetodUp;
            label1.Click -= MyMetodUp;
        }
       
    }
}
