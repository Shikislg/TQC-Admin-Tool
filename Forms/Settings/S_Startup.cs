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
    public partial class S_Startup : Form
    {
        public S_Startup()
        {
            InitializeComponent();
            PullDataOnStartup.SelectedIndex = Rules.GetPullDataOnOpen();
        }
    }
}
