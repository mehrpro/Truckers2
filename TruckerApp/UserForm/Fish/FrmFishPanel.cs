using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckerApp.UserForm.Fish
{
    public partial class FrmFishPanel : Form
    {
        public FrmFishPanel()
        {
            InitializeComponent();
        }

        private void FrmFishPanel_Load(object sender, EventArgs e)
        {
            layoutControl1.Location = new Point(this.Width / 2 - (layoutControl1.Width / 2), layoutControl1.Location.Y);
        }
    }
}
