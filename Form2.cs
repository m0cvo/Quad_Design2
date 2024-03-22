using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quad_Design2
{
    public partial class Form2 : Form
    {
        private PrintDocument PrintDocument1 = new PrintDocument();
        public Form2()
        {
            InitializeComponent();
            PrintDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            FreqIn.Text = string.Empty;
            R1.Text = R2.Text = R3.Text = R4.Text = R5.Text = string.Empty;
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double frequencyIn = double.Parse((FreqIn.Text).Trim());
                Reflector();
                Driven();
                Director1();
                Director2();
                Spacing();
            }
            catch (Exception) { MessageBox.Show("Incorrect format, please enter numbers only!"); }
        }

        private void Reflector()
        {
            double frequencyIn = double.Parse((FreqIn.Text).Trim());
            double Reflector = (78.7 / frequencyIn) * 4;
            R1.Text = Reflector.ToString() + "m";
        }

        private void Driven()
        {
            double frequencyIn = double.Parse((FreqIn.Text).Trim());
            double Driven = (76.6 / frequencyIn) * 4;
            R2.Text = Driven.ToString() + "m";
        }

        private void Director1()
        {
            double frequencyIn = double.Parse((FreqIn.Text).Trim());
            double Director1 = (74.3 / frequencyIn) * 4;
            R3.Text = Director1.ToString() + "m";
        }

        private void Director2()
        {
            double frequencyIn = double.Parse((FreqIn.Text).Trim());
            double Director2 = (74.3 / frequencyIn) * 4;
            R4.Text = Director2.ToString() + "m";
        }

        private void Spacing()
        {
            double frequencyIn = double.Parse((FreqIn.Text).Trim());
            double Spacing = 43.3 / frequencyIn;
            R5.Text = Spacing.ToString() + "m";
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            PrintDocument1.Print();
        }

        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            myGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
