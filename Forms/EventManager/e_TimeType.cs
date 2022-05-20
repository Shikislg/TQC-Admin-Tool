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
    public partial class e_TimeType : Form
    {
        public e_TimeType()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            GlobalDependencies.eventManagerInstance.currentForm++;
            GlobalDependencies.eventManagerInstance.LoadForm(GlobalDependencies.eventManagerInstance.participants);
        }
    }
}
