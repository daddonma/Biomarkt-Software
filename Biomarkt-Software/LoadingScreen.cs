using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biomarkt_Software
{
    public partial class LoadingScreen : Form
    {

        private int loadingBarValue = 0;

        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            loadingbarTimer.Start();
        }

        private void loadingbarTimer_Tick(object sender, EventArgs e)
        {

            loadingBarValue += 1;
            labelLoadingProgress.Text = loadingBarValue.ToString() + " %";
            loadingProgressbar.Value = loadingBarValue;
        
            if(loadingBarValue >= loadingProgressbar.Maximum)
            {
                loadingbarTimer.Stop();

                //Finished Loading
            }
        }

    }
}
