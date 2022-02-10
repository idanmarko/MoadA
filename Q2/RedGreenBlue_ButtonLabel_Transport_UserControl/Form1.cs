using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace RedGreenBlue_ButtonLabel_Transport_UserControl
{
    public partial class Form1 : Form
    {
        private UserControl1 UC_From;
        private UserControl1[] arrUC_To = new UserControl1[3], arrUC_Transport = new UserControl1[3];
        private int width_FromTo = 1000, maxCounter_FromTo = 80, width_Transport = 150, maxCounter_Transport = 8;

        public Form1()
        {
            InitializeComponent();
            this.Width = 1025;

            UC_From = new UserControl1(width_FromTo, maxCounter_FromTo, "Full", "Label");

            UC_From.Location = new Point(2, 70);
            this.Controls.Add(UC_From);

            for (int i = 0; i < 3; i++)
            {
                arrUC_Transport[i] = new UserControl1(width_Transport, maxCounter_Transport, "Empty", "");
                arrUC_Transport[i].Location = new Point(2 + (width_Transport + 8) * i, 161);
                this.Controls.Add(arrUC_Transport[i]);

                arrUC_To[i] = new UserControl1(width_FromTo, maxCounter_FromTo, "Empty", "");
                arrUC_To[i].Location = new Point(2, 220 + 57 * i);
                this.Controls.Add(arrUC_To[i]);
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
