using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class Memory : Form
        {
        Random random = new Random();

        List<string> icons= new List<string> ()
        {
            "!","!","N","N",",",",","k","k",
            "b","b","v","v","w","w","z","z,"|*11.45 https://www.youtube.com/watch?v=frDKP-A71W0&list=PL-67phyyX1DTquuFHLD4Mv_CapW5X9ejY&index=11&t=570s
        }


        public Memory()
        {
            InitializeComponent();
        }

        private void Memory_Load(object sender, EventArgs e)
        {

        }
    }
}
