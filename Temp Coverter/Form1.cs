using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temp_Coverter
{
    public partial class Form1 : Form
    {

        int farhenheit = 32;
        int result;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            result = Convert.ToInt32(textBoxCelsius.Text);
            textBoxFarenheit.Text = Convert.ToString(result + farhenheit) ;
        }
    }
}
