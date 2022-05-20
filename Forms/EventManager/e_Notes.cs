using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class e_Notes : Form
    {
        public e_Notes()
        {
            InitializeComponent();
        }

        private void CreateEventButton_Click(object sender, EventArgs e)
        {
                GlobalDependencies.eventManagerInstance.CreateEventButton_Click(this, new EventArgs());
        }
    }
}
