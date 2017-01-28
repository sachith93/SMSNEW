using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

       
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 100) timer1.Stop();
              
         }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        
      
        

       
    }
}
