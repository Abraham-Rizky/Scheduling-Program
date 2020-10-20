using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling_Program
{
    public partial class DaySchedule : Form
    {
        public DaySchedule()
        {
            InitializeComponent();
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu openMainMenu = new MainMenu();
            openMainMenu.Tag = this;
            openMainMenu.Show(this);
            Hide();
        }
    }
}
