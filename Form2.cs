using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quad_Design2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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
    }
}
