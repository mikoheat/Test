using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Taeho Kim
 * Date: August 17, 2017
 * Description: Calculator Demo Project
 * Version: 0.1 - created an flashform and tick handler
 */

namespace SplashForm
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            this.PickHighestCardForm.Show(); // temporary name of object: PickHighestCardForm

            this.Hide();

            SplashFormTimer.Enabled = false; // turn timer off
        }
    }
}
