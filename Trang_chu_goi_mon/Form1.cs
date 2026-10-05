using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Trang_chu_goi_mon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Paint(object sender, PaintEventArgs e)
        {
            System.Windows.Forms.Label lbl = sender as System.Windows.Forms.Label;
            int borderRadius = 10; // Nhập số nhỏ (khoảng 10-15) vì Label thường bé hơn Panel

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(lbl.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(lbl.Width - borderRadius, lbl.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, lbl.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseFigure();

            lbl.Region = new Region(path);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            System.Windows.Forms.Panel lbl = sender as System.Windows.Forms.Panel;
            int borderRadius = 20; // Nhập số nhỏ (khoảng 10-15) vì Label thường bé hơn Panel

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(lbl.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(lbl.Width - borderRadius, lbl.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, lbl.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseFigure();

            lbl.Region = new Region(path);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            System.Windows.Forms.Panel lbl = sender as System.Windows.Forms.Panel;
            int borderRadius = 15
                ; // Nhập số nhỏ (khoảng 10-15) vì Label thường bé hơn Panel

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(lbl.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(lbl.Width - borderRadius, lbl.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, lbl.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseFigure();

            lbl.Region = new Region(path);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            lblTienIch.ForeColor = Color.DarkSlateGray;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            System.Windows.Forms.Panel lbl = sender as System.Windows.Forms.Panel;
            int borderRadius = 20; // Nhập số nhỏ (khoảng 10-15) vì Label thường bé hơn Panel

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(lbl.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(lbl.Width - borderRadius, lbl.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, lbl.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseFigure();

            lbl.Region = new Region(path);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            System.Windows.Forms.Panel lbl = sender as System.Windows.Forms.Panel;
            int borderRadius = 20; // Nhập số nhỏ (khoảng 10-15) vì Label thường bé hơn Panel

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(lbl.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(lbl.Width - borderRadius, lbl.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, lbl.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseFigure();

            lbl.Region = new Region(path);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            System.Windows.Forms.Panel lbl = sender as System.Windows.Forms.Panel;
            int borderRadius = 20; // Nhập số nhỏ (khoảng 10-15) vì Label thường bé hơn Panel

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(lbl.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(lbl.Width - borderRadius, lbl.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, lbl.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseFigure();

            lbl.Region = new Region(path);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label13_Paint(object sender, PaintEventArgs e)
        {
            System.Windows.Forms.Label lbl = sender as System.Windows.Forms.Label;
            int borderRadius = 10; // Nhập số nhỏ (khoảng 10-15) vì Label thường bé hơn Panel

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(lbl.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(lbl.Width - borderRadius, lbl.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, lbl.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseFigure();

            lbl.Region = new Region(path);
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }
    }
}
