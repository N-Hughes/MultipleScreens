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
    public partial class GameScreen : UserControl
    {
        public GameScreen()
        {
            InitializeComponent();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            MenuScreen ms = new MenuScreen();

            // Centre the screen on the form
            ms.Location = new Point((f.Width - ms.Width) / 2, (f.Height - ms.Height) / 2);

            f.Controls.Add(ms);
            ms.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void returnButton_Enter(object sender, EventArgs e)
        {
            returnButton.BackColor = Color.Green;
            exitButton.BackColor = Color.White;
        }

        private void exitButton_Enter(object sender, EventArgs e)
        {
            returnButton.BackColor = Color.White;
            exitButton.BackColor = Color.Green;
        }
    }
}
