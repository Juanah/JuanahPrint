using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuanahPrint
{
    public partial class Form1 : Form
    {
        private float[] diameter;
        

        public Form1()
        {
            diameter = new float[2];
            diameter[0] = 1.75f;
            diameter[1] = 3.00f;
            InitializeComponent();
        }

        private void cmb_diameter_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilamentCalculator.FilaCalc.SetDiameter(diameter[cmb_diameter.SelectedIndex]);
            inp_nextValue.Text = diameter[cmb_diameter.SelectedIndex].ToString();
        }

        private void btn_addValue_Click(object sender, EventArgs e)
        {
            float input;
            if (!float.TryParse(inp_nextValue.Text,out input))
            {
                MessageBox.Show(String.Format("Could not parse Value {0} to valid float value.", inp_nextValue.Text));
                return;
            }
            FilamentCalculator.FilaCalc.AddMesurement(input);
            RefreshDisplay();
        }


        void RefreshDisplay()
        {

            FilamentCalculator.FilaCalcResult result = FilamentCalculator.FilaCalc.Calculate();
            lbn_currentDiameter.Text = String.Format("{0}mm", result.Averrage);
            lbn_measurements.Text = result.Messurements.ToString();
        }

    }
}
