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
    public partial class S_Points : Form
    {
        public S_Points()
        {
            InitializeComponent();

            MinPointsTf.Text = Rules.GetMinPoints().ToString();

            PointModeBox.SelectedIndex = Rules.GetPointHandlingMode();
        }
    }
}
