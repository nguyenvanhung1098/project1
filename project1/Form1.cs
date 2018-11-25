using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            propertyGrid1.Visible = false;
            propertyGrid2.Visible = false;
            propertyGrid3.Visible = false;
            propertyGrid4.Visible = false;
            propertyGrid5.Visible = false;
            propertyGrid6.Visible = false;
            propertyGrid7.Visible = false;
            button2.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Mouse_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file          
                DateTime aDateTime = DateTime.Now;// lay thoi gian hien tai
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click chuot trai: X = " + (e.X + 230) + " ; Y = " + (e.Y + 70));
                file.Close();
            }
            if (e.Button == MouseButtons.Right)
            {
                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file
                DateTime aDateTime = DateTime.Now;
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click chuot phai: X = " + (e.X + 230) + " ; Y = " + (e.Y + 70));
                file.Close();
            }
            if (e.Button == MouseButtons.Middle)
            {
                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file
                DateTime aDateTime = DateTime.Now;
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click chuot giua: X = " + (e.X + 230) + " ; Y = " + (e.Y + 70));
                file.Close();
            }
        }

        private void pictureBox2_MouseLeft_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file          
                DateTime aDateTime = DateTime.Now;// lay thoi gian hien tai
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click chuot trai: X = " + (e.X + 230) + " ; Y = " + (e.Y + 70));
                file.Close();
            }
            if (e.Button == MouseButtons.Right)
            {
                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file
                DateTime aDateTime = DateTime.Now;
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click chuot phai: X = " + (e.X + 230) + " ; Y = " + (e.Y + 70));
                file.Close();
            }
            if (e.Button == MouseButtons.Middle)
            {
                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file
                DateTime aDateTime = DateTime.Now;
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click chuot giua: X = " + (e.X + 230) + " ; Y = " + (e.Y + 70));
                file.Close();
            }
        }

        private void pictureBox3_MouseMid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file          
                DateTime aDateTime = DateTime.Now;// lay thoi gian hien tai
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click chuot trai: X = " + (e.X + 230) + " ; Y = " + (e.Y + 70));
                file.Close();
            }
            if (e.Button == MouseButtons.Right)
            {
                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file
                DateTime aDateTime = DateTime.Now;
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click chuot phai: X = " + (e.X + 230) + " ; Y = " + (e.Y + 70));
                file.Close();
            }
            if (e.Button == MouseButtons.Middle)
            {
                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file
                DateTime aDateTime = DateTime.Now;
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click chuot giua: X = " + (e.X + 230) + " ; Y = " + (e.Y + 70));
                file.Close();
            }
        }

        private void pictureBox4_MouseRight_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file          
                DateTime aDateTime = DateTime.Now;// lay thoi gian hien tai
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click chuot trai: X = " + (e.X + 230) + " ; Y = " + (e.Y + 70));
                file.Close();
            }
            if (e.Button == MouseButtons.Right)
            {
                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file
                DateTime aDateTime = DateTime.Now;
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click chuot phai: X = " + (e.X + 230) + " ; Y = " + (e.Y + 70));
                file.Close();
            }
            if (e.Button == MouseButtons.Middle)
            {
                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file
                DateTime aDateTime = DateTime.Now;
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click chuot giua: X = " + (e.X + 230) + " ; Y = " + (e.Y + 70));
                file.Close();
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file          
                DateTime aDateTime = DateTime.Now;// lay thoi gian hien tai
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click chuot trai: X = " + e.X + " ; Y = " + e.Y);
                file.Close();
            }
            if (e.Button == MouseButtons.Right)
            {
                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file
                DateTime aDateTime = DateTime.Now;
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click chuot phai: X = " + e.X + " ; Y = " + e.Y);
                file.Close();
            }
            if (e.Button == MouseButtons.Middle)
            {
                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file
                DateTime aDateTime = DateTime.Now;
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click chuot giua: X = " + e.X + " ; Y = " + e.Y);
                file.Close();
            }
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file          
                DateTime aDateTime = DateTime.Now;// lay thoi gian hien tai
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click chuot trai: X = " + e.X + " ; Y = " + e.Y);
                file.Close();
            }
            if (e.Button == MouseButtons.Right)
            {
                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file
                DateTime aDateTime = DateTime.Now;
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click chuot phai: X = " + e.X + " ; Y = " + e.Y);
                file.Close();
            }
            if (e.Button == MouseButtons.Middle)
            {
                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file
                DateTime aDateTime = DateTime.Now;
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click chuot giua: X = " + e.X + " ; Y = " + e.Y);
                file.Close();
            }
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file          
                DateTime aDateTime = DateTime.Now;// lay thoi gian hien tai
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click chuot trai: X = " + e.X + " ; Y = " + e.Y);
                file.Close();
            }
            if (e.Button == MouseButtons.Right)
            {
                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file
                DateTime aDateTime = DateTime.Now;
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click chuot phai: X = " + e.X + " ; Y = " + e.Y);
                file.Close();
            }
            if (e.Button == MouseButtons.Middle)
            {
                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file
                DateTime aDateTime = DateTime.Now;
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click chuot giua: X = " + e.X + " ; Y = " + e.Y);
                file.Close();
            }
        }

        // Su ly su kien MouseDoubleClick
        private void pictureBox1_Mouse_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file          
                DateTime aDateTime = DateTime.Now;// lay thoi gian hien tai
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click dup chuot trai: X = " + (e.X + 230) + " ; Y = " + (e.Y + 70));
                file.Close();
            }
            if (e.Button == MouseButtons.Right)
            {
                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file
                DateTime aDateTime = DateTime.Now;
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click dup chuot phai: X = " + (e.X + 230) + " ; Y = " + (e.Y + 70));
                file.Close();
            }
            if (e.Button == MouseButtons.Middle)
            {
                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file
                DateTime aDateTime = DateTime.Now;
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click dup chuot giua: X = " + (e.X + 230) + " ; Y = " + (e.Y + 70));
                file.Close();
            }
        }

        private void pictureBox2_MouseLeft_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file          
                DateTime aDateTime = DateTime.Now;// lay thoi gian hien tai
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click dup chuot trai: X = " + (e.X + 230) + " ; Y = " + (e.Y + 70));
                file.Close();
            }
            if (e.Button == MouseButtons.Right)
            {
                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file
                DateTime aDateTime = DateTime.Now;
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click dup chuot phai: X = " + (e.X + 230) + " ; Y = " + (e.Y + 70));
                file.Close();
            }
            if (e.Button == MouseButtons.Middle)
            {
                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file
                DateTime aDateTime = DateTime.Now;
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click dup chuot giua: X = " + (e.X + 230) + " ; Y = " + (e.Y + 70));
                file.Close();
            }
        }

        private void pictureBox3_MouseMid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file          
                DateTime aDateTime = DateTime.Now;// lay thoi gian hien tai
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click dup chuot trai: X = " + (e.X + 230) + " ; Y = " + (e.Y + 70));
                file.Close();
            }
            if (e.Button == MouseButtons.Right)
            {
                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file
                DateTime aDateTime = DateTime.Now;
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click dup chuot phai: X = " + (e.X + 230) + " ; Y = " + (e.Y + 70));
                file.Close();
            }
            if (e.Button == MouseButtons.Middle)
            {
                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file
                DateTime aDateTime = DateTime.Now;
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click dup chuot giua: X = " + (e.X + 230) + " ; Y = " + (e.Y + 70));
                file.Close();
            }
        }

        private void pictureBox4_MouseRight_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file          
                DateTime aDateTime = DateTime.Now;// lay thoi gian hien tai
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click dup chuot trai: X = " + (e.X + 230) + " ; Y = " + (e.Y + 70));
                file.Close();
            }
            if (e.Button == MouseButtons.Right)
            {
                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file
                DateTime aDateTime = DateTime.Now;
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click dup chuot phai: X = " + (e.X + 230) + " ; Y = " + (e.Y + 70));
                file.Close();
            }
            if (e.Button == MouseButtons.Middle)
            {
                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file
                DateTime aDateTime = DateTime.Now;
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click dup chuot giua: X = " + (e.X + 230) + " ; Y = " + (e.Y + 70));
                file.Close();
            }
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file          
                DateTime aDateTime = DateTime.Now;// lay thoi gian hien tai
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click dup chuot trai: X = " + e.X + " ; Y = " + e.Y);
                file.Close();
            }
            if (e.Button == MouseButtons.Right)
            {
                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file
                DateTime aDateTime = DateTime.Now;
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click dup chuot phai: X = " + e.X + " ; Y = " + e.Y);
                file.Close();
            }
            if (e.Button == MouseButtons.Middle)
            {
                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file
                DateTime aDateTime = DateTime.Now;
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click dup chuot giua: X = " + e.X + " ; Y = " + e.Y);
                file.Close();
            }
        }

        private void label1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file          
                DateTime aDateTime = DateTime.Now;// lay thoi gian hien tai
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click dup chuot trai: X = " + e.X + " ; Y = " + e.Y);
                file.Close();
            }
            if (e.Button == MouseButtons.Right)
            {
                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file
                DateTime aDateTime = DateTime.Now;
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click dup chuot phai: X = " + e.X + " ; Y = " + e.Y);
                file.Close();
            }
            if (e.Button == MouseButtons.Middle)
            {
                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file
                DateTime aDateTime = DateTime.Now;
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click dup chuot giua: X = " + e.X + " ; Y = " + e.Y);
                file.Close();
            }
        }

        private void label2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file          
                DateTime aDateTime = DateTime.Now;// lay thoi gian hien tai
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click dup chuot trai: X = " + e.X + " ; Y = " + e.Y);
                file.Close();
            }
            if (e.Button == MouseButtons.Right)
            {
                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file
                DateTime aDateTime = DateTime.Now;
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click dup chuot phai: X = " + e.X + " ; Y = " + e.Y);
                file.Close();
            }
            if (e.Button == MouseButtons.Middle)
            {
                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file
                DateTime aDateTime = DateTime.Now;
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click dup chuot giua: X = " + e.X + " ; Y = " + e.Y);
                file.Close();
            }
        }

        // su ly su kien MouseDown: khi click chuot se hien thi ra man hinh vi tri chuot da click Trai phai hoac giua
        private void pictureBox1_Mouse_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file
                DateTime aDateTime = DateTime.Now;
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click chuot trai: X = " + (e.X + 230) + " ; Y = " + (e.Y + 70));
                file.Close();
                pictureBox1_Mouse.Visible = false;
                pictureBox2_MouseLeft.Visible = true;
                pictureBox3_MouseMid.Visible = false;
                pictureBox4_MouseRight.Visible = false;

            }
            if (e.Button == MouseButtons.Right)
            {
                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file
                DateTime aDateTime = DateTime.Now;
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click chuot phai: X = " + (e.X + 230) + " ; Y = " + (e.Y + 70));
                file.Close();
                pictureBox1_Mouse.Visible = false;
                pictureBox2_MouseLeft.Visible = false;
                pictureBox3_MouseMid.Visible = false;
                pictureBox4_MouseRight.Visible = true;
            }
            if (e.Button == MouseButtons.Middle)
            {
                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file
                DateTime aDateTime = DateTime.Now;
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click chuot giua: X = " + (e.X + 230) + " ; Y = " + (e.Y + 70));
                file.Close();
                pictureBox1_Mouse.Visible = false;
                pictureBox2_MouseLeft.Visible = false;
                pictureBox3_MouseMid.Visible = true;
                pictureBox4_MouseRight.Visible = false;
            }
        }

        private void pictureBox2_MouseLeft_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pictureBox1_Mouse.Visible = false;
                pictureBox2_MouseLeft.Visible = true;
                pictureBox3_MouseMid.Visible = false;
                pictureBox4_MouseRight.Visible = false;
            }
            if (e.Button == MouseButtons.Right)
            {
                pictureBox1_Mouse.Visible = false;
                pictureBox2_MouseLeft.Visible = false;
                pictureBox3_MouseMid.Visible = false;
                pictureBox4_MouseRight.Visible = true;
            }
            if (e.Button == MouseButtons.Middle)
            {
                pictureBox1_Mouse.Visible = false;
                pictureBox2_MouseLeft.Visible = false;
                pictureBox3_MouseMid.Visible = true;
                pictureBox4_MouseRight.Visible = false;
            }
        }

        private void pictureBox3_MouseMid_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pictureBox1_Mouse.Visible = false;
                pictureBox2_MouseLeft.Visible = true;
                pictureBox3_MouseMid.Visible = false;
                pictureBox4_MouseRight.Visible = false;
            }
            if (e.Button == MouseButtons.Right)
            {
                pictureBox1_Mouse.Visible = false;
                pictureBox2_MouseLeft.Visible = false;
                pictureBox3_MouseMid.Visible = false;
                pictureBox4_MouseRight.Visible = true;
            }
            if (e.Button == MouseButtons.Middle)
            {
                pictureBox1_Mouse.Visible = false;
                pictureBox2_MouseLeft.Visible = false;
                pictureBox3_MouseMid.Visible = true;
                pictureBox4_MouseRight.Visible = false;
            }
        }

        private void pictureBox4_MouseRight_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pictureBox1_Mouse.Visible = false;
                pictureBox2_MouseLeft.Visible = true;
                pictureBox3_MouseMid.Visible = false;
                pictureBox4_MouseRight.Visible = false;
            }
            if (e.Button == MouseButtons.Right)
            {
                pictureBox1_Mouse.Visible = false;
                pictureBox2_MouseLeft.Visible = false;
                pictureBox3_MouseMid.Visible = false;
                pictureBox4_MouseRight.Visible = true;
            }
            if (e.Button == MouseButtons.Middle)
            {
                pictureBox1_Mouse.Visible = false;
                pictureBox2_MouseLeft.Visible = false;
                pictureBox3_MouseMid.Visible = true;
                pictureBox4_MouseRight.Visible = false;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pictureBox1_Mouse.Visible = false;
                pictureBox2_MouseLeft.Visible = true;
                pictureBox3_MouseMid.Visible = false;
                pictureBox4_MouseRight.Visible = false;
            }
            if (e.Button == MouseButtons.Right)
            {
                pictureBox1_Mouse.Visible = false;
                pictureBox2_MouseLeft.Visible = false;
                pictureBox3_MouseMid.Visible = false;
                pictureBox4_MouseRight.Visible = true;
            }
            if (e.Button == MouseButtons.Middle)
            {
                pictureBox1_Mouse.Visible = false;
                pictureBox2_MouseLeft.Visible = false;
                pictureBox3_MouseMid.Visible = true;
                pictureBox4_MouseRight.Visible = false;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pictureBox1_Mouse.Visible = false;
                pictureBox2_MouseLeft.Visible = true;
                pictureBox3_MouseMid.Visible = false;
                pictureBox4_MouseRight.Visible = false;
            }
            if (e.Button == MouseButtons.Right)
            {
                pictureBox1_Mouse.Visible = false;
                pictureBox2_MouseLeft.Visible = false;
                pictureBox3_MouseMid.Visible = false;
                pictureBox4_MouseRight.Visible = true;
            }
            if (e.Button == MouseButtons.Middle)
            {
                pictureBox1_Mouse.Visible = false;
                pictureBox2_MouseLeft.Visible = false;
                pictureBox3_MouseMid.Visible = true;
                pictureBox4_MouseRight.Visible = false;
            }
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pictureBox1_Mouse.Visible = false;
                pictureBox2_MouseLeft.Visible = true;
                pictureBox3_MouseMid.Visible = false;
                pictureBox4_MouseRight.Visible = false;
            }
            if (e.Button == MouseButtons.Right)
            {
                pictureBox1_Mouse.Visible = false;
                pictureBox2_MouseLeft.Visible = false;
                pictureBox3_MouseMid.Visible = false;
                pictureBox4_MouseRight.Visible = true;
            }
            if (e.Button == MouseButtons.Middle)
            {
                pictureBox1_Mouse.Visible = false;
                pictureBox2_MouseLeft.Visible = false;
                pictureBox3_MouseMid.Visible = true;
                pictureBox4_MouseRight.Visible = false;
            }
        }

        // su ly su kien nha chuot: Hien thi anh chuot khi chua click chuot
        private void pictureBox1_Mouse_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1_Mouse.Visible = true; ;

        }

        private void pictureBox2_MouseLeft_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1_Mouse.Visible = true;
        }

        private void pictureBox3_MouseMid_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1_Mouse.Visible = true;
        }

        private void pictureBox4_MouseRight_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1_Mouse.Visible = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1_Mouse.Visible = true;
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1_Mouse.Visible = true;
        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1_Mouse.Visible = true;

        }

        // su ly su kien MouseMove : khi di chuyen chuot tren Form : se in toa do chuot ra man hinh
        private void pictureBox1_Mouse_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "X = " + (e.X + 230); // cong them toa do pictureBox
            label2.Text = "Y = " + (e.Y + 70); // cong them toa do pictureBox
            label1.Location = new Point(e.X + 230 - label1.Width, e.Y + 70);
            label2.Location = new Point(e.X + 230, e.Y + 70 - label2.Height);
        }

        private void pictureBox2_MouseLeft_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "X = " + (e.X + 230);
            label2.Text = "Y = " + (e.Y + 70);
            label1.Location = new Point(e.X + 230 - label1.Width, e.Y + 70);
            label2.Location = new Point(e.X + 230, e.Y + 70 - label2.Height);
        }

        private void pictureBox3_MouseMid_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "X = " + (e.X + 230);
            label2.Text = "Y = " + (e.Y + 70);
            label1.Location = new Point(e.X + 230 - label1.Width, e.Y + 70);
            label2.Location = new Point(e.X + 230, e.Y + 70 - label2.Height);
        }

        private void pictureBox4_MouseRight_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "X = " + (e.X + 230);
            label2.Text = "Y = " + (e.Y + 70);
            label1.Location = new Point(e.X + 230 - label1.Width, e.Y + 70);
            label2.Location = new Point(e.X + 230, e.Y + 70 - label2.Height);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "X = " + e.X;
            label2.Text = "Y = " + e.Y;
            label1.Location = new Point(e.X - label1.Width, e.Y);
            label2.Location = new Point(e.X, e.Y - label2.Height);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "X = " + e.X;
            label2.Text = "Y = " + e.Y;
            label1.Location = new Point(e.X - label1.Width, e.Y);
            label2.Location = new Point(e.X, e.Y - label2.Height);
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "X = " + e.X;
            label2.Text = "Y = " + e.Y;
            label1.Location = new Point(e.X - label1.Width, e.Y);
            label2.Location = new Point(e.X, e.Y - label2.Height);
        }

        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            propertyGrid1.Visible = true;
            propertyGrid2.Visible = false;
            propertyGrid3.Visible = false;
            propertyGrid4.Visible = false;
            propertyGrid5.Visible = false;
            propertyGrid6.Visible = false;
        }

        private void pictureBox1MouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            propertyGrid1.Visible = false;
            propertyGrid2.Visible = true;
            propertyGrid3.Visible = false;
            propertyGrid4.Visible = false;
            propertyGrid5.Visible = false;
            propertyGrid6.Visible = false;
            propertyGrid7.Visible = false;
        }

        private void pictureBox2MouseLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            propertyGrid1.Visible = false;
            propertyGrid2.Visible = false;
            propertyGrid3.Visible = true;
            propertyGrid4.Visible = false;
            propertyGrid5.Visible = false;
            propertyGrid6.Visible = false;
            propertyGrid7.Visible = false;
        }

        private void pictureBox3MouseMidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            propertyGrid1.Visible = false;
            propertyGrid2.Visible = false;
            propertyGrid3.Visible = false;
            propertyGrid4.Visible = true;
            propertyGrid5.Visible = false;
            propertyGrid6.Visible = false;
            propertyGrid7.Visible = false;
        }

        private void pictureBox4MouseRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            propertyGrid1.Visible = false;
            propertyGrid2.Visible = false;
            propertyGrid3.Visible = false;
            propertyGrid4.Visible = false;
            propertyGrid5.Visible = true;
            propertyGrid6.Visible = false;
            propertyGrid7.Visible = false;
        }

        private void label1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            propertyGrid1.Visible = false;
            propertyGrid2.Visible = false;
            propertyGrid3.Visible = false;
            propertyGrid4.Visible = false;
            propertyGrid5.Visible = false;
            propertyGrid6.Visible = true;
            propertyGrid7.Visible = false;
        }

        private void label2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            propertyGrid1.Visible = false;
            propertyGrid2.Visible = false;
            propertyGrid3.Visible = false;
            propertyGrid4.Visible = false;
            propertyGrid5.Visible = false;
            propertyGrid6.Visible = false;
            propertyGrid7.Visible = true;
        }


        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            propertyGrid1.Visible = false;
            propertyGrid2.Visible = false;
            propertyGrid3.Visible = false;
            propertyGrid4.Visible = false;
            propertyGrid5.Visible = false;
            propertyGrid6.Visible = false;
            propertyGrid7.Visible = false;
            button2.Visible = false;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            contextMenuStrip1.Show(this, new Point(0, 0));
            if (e.Button == MouseButtons.Left)
            {

                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file          
                DateTime aDateTime = DateTime.Now;// lay thoi gian hien tai
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click chuot trai vao Properties");
                file.Close();
            }
            if (e.Button == MouseButtons.Right)
            {
                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file
                DateTime aDateTime = DateTime.Now;
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click chuot phai vao Properties");
                file.Close();
            }
            if (e.Button == MouseButtons.Middle)
            {
                StreamWriter file = new StreamWriter("Mouse.txt", true);// Mo va tao file MouseEvent.txt va ghi tiep vao file
                DateTime aDateTime = DateTime.Now;
                file.WriteLine(+aDateTime.Hour + ":" + aDateTime.Minute + ":" + aDateTime.Second + "  " + aDateTime.Day + "/" + aDateTime.Month + "/" + aDateTime.Year + ":" + "click chuot giua vao Properties");
                file.Close();
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pictureBox1_Mouse.Visible = false;
                pictureBox2_MouseLeft.Visible = true;
                pictureBox3_MouseMid.Visible = false;
                pictureBox4_MouseRight.Visible = false;
            }
            if (e.Button == MouseButtons.Right)
            {
                pictureBox1_Mouse.Visible = false;
                pictureBox2_MouseLeft.Visible = false;
                pictureBox3_MouseMid.Visible = false;
                pictureBox4_MouseRight.Visible = true;
            }
            if (e.Button == MouseButtons.Middle)
            {
                pictureBox1_Mouse.Visible = false;
                pictureBox2_MouseLeft.Visible = false;
                pictureBox3_MouseMid.Visible = true;
                pictureBox4_MouseRight.Visible = false;
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1_Mouse.Visible = true;
        }
    }
}
