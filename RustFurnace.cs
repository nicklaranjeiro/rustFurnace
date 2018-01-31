using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RustFurnaceSimulator
{
    public partial class RustFurnace : Form
    {
        public RustFurnace()
        {
            InitializeComponent();
        }

        private void OreTypes_Enter(object sender, EventArgs e)
        {

        }

        private void RustFurnace_Load(object sender, EventArgs e)
        {
            oreTrackBar.Minimum = 0;
            oreTrackBar.Maximum = 3000;
            oreTrackBar.TickFrequency = 250;
            oreTrackBar.TickStyle = TickStyle.BottomRight;
            woodTrackBar.Minimum = 0;
            woodTrackBar.Maximum = 1000;
            woodTrackBar.TickFrequency = 100;
            woodTrackBar.TickStyle = TickStyle.BottomRight;
        }

        private void oreAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void woodAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void oreTrackBar_Scroll(object sender, EventArgs e)
        {
            oreAmount.Text = oreTrackBar.Value.ToString();
        }

        private void woodTrackBar_Scroll(object sender, EventArgs e)
        {
            woodAmount.Text = woodTrackBar.Value.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            MetalOre.Checked = true;
            SulfurOre.Checked = false;
            HQOre.Checked = false;
            oreAmount.Text = "0";
            woodAmount.Text = "0";
            oreTrackBar.Value = 1;
            woodTrackBar.Value = 1;
            ttcValue.Text = "";
            metalFragments.Visible = false;
            sulfur.Visible = false;
            highQuality.Visible = false;
            resultAmount.Text = "";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            var oreUsed = int.Parse(oreAmount.Text);
            //Splits it into 3 empty spots in the furnace
            var oreSplit = (int)(oreUsed / 3);
            var woodUsed = int.Parse(woodAmount.Text);
            //Since each piece of wood takes 2 seconds to burn creates the total number of seconds needed for all the wood to be used
            var woodTimer = woodUsed * 2;
            TimeSpan time = TimeSpan.FromSeconds(woodTimer);
            string str = time.ToString(@"hh\:mm\:ss\:fff");
            ttcValue.Text = str;
            //FIX CALCULATIONS!!
            if(MetalOre.Checked == true)
            {
                var mfCalculator = (woodUsed/5)*3;
                if(mfCalculator > oreUsed)
                {
                    mfCalculator = oreUsed;
                }
                //(((0.2 * oreSplit) * 3))*
                resultAmount.Text = "x " + (int)mfCalculator;
                metalFragments.Visible = true;
                sulfur.Visible = false;
                highQuality.Visible = false;
            }
            if(SulfurOre.Checked == true)
            {
                var sCalculator = (woodUsed / 2.5) * 3;
                if (sCalculator > oreUsed)
                {
                    sCalculator = oreUsed;
                }
                if(sCalculator > 1000)
                {
                    sCalculator = 1000;
                }
                resultAmount.Text = "x " + (int)sCalculator;
                sulfur.Visible = true;
                highQuality.Visible = false;
                metalFragments.Visible = false;
            }
            if(HQOre.Checked == true)
            {
                var hqCalculator = (woodUsed / 10) * 3;
                if (hqCalculator > oreUsed)
                {
                    hqCalculator = oreUsed;
                }
                if (hqCalculator > 100)
                {
                    hqCalculator = 100;
                }
                resultAmount.Text = "x " + (int)hqCalculator;
                highQuality.Visible = true;
                sulfur.Visible = false;
                metalFragments.Visible = false;
            }
        }

        private void OreTypes_Enter_1(object sender, EventArgs e)
        {

        }




        //1 wood gives you a time of 2 seconds to burn
        //5 wood burns 1 metal ore
        //2.5 wood burns 1 sulfur ore
        //10 wood burns 1 hq ore
        // 300 and 619

    }
}
