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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void btnDaySchedule_Click(object sender, EventArgs e)
        {
            DaySchedule openDaySchedule = new DaySchedule();
            openDaySchedule.Tag = this;
            openDaySchedule.Show(this);
            Hide();
        }
    }
}
