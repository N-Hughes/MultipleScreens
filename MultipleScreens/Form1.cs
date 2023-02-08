using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleScreens
{
    public partial class Form1 : Form
    {
        public static int numberPlays = 0;

        public Form1()
        {
            int temp = 0;

            InitializeComponent();
            MenuScreen ms = new MenuScreen();

            // Centre the screen on the form
            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);

            this.Controls.Add(ms);
            ms.Focus();
        }
    }
}
