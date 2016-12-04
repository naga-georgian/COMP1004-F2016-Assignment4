using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using COMP1004_F2016_Assignment4.Models;
using System.Diagnostics;

// Name: Naga Rimmalapudi
// Student #: 200277598
// Date: Dec 1, 2016
// Dollar Computers

namespace COMP1004_F2016_Assignment4
{
    public partial class SplashForm : Form
    {
        private StartForm StartForm;

        public SplashForm()
        {
            InitializeComponent();

            this.StartForm = new StartForm();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            this.SplashTimer.Enabled = false;

            this.loadStartForm();
        }

        private void loadStartForm()
        {
            this.Hide();

            this.StartForm.Show();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            this.StartForm.LoadProducts();
            this.SplashTimer.Enabled = true;
        }
    }
}
