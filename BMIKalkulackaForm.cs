using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS012BMIKalkulacka
{
    public partial class BMIKalkulackaForm : Form
    {
        Color BarvaBMIPodvaha = Color.FromArgb(100, 197, 204);
        Color BarvaBMINormalni = Color.FromArgb(138, 195, 84);
        Color BarvaBMINadvaha = Color.FromArgb(248, 172, 60);
        Color BarvaBMIObezita = Color.FromArgb(237, 90, 36);
        Color BarvaBMIExtremniObezita = Color.FromArgb(217, 81, 57);

        public BMIKalkulackaForm()
        {
            InitializeComponent();
        }
        
        private double BMI(double m, double v)
        {
            return (m / (v * v));
        }
        private Color BMIBarva(double bmi)
        {
            if (bmi < 18.5) return BarvaBMIPodvaha;


            else if (bmi < 24.9) return BarvaBMINormalni;

            else if (bmi < 29.9) return BarvaBMINadvaha;

            else if (bmi < 34.9) return BarvaBMIObezita;

            else return BarvaBMIExtremniObezita;

        }

        private void vypocetBMIButton_Click(object sender, EventArgs e)
        {
            BMILabel.Text = Math.Round(BMI(double.Parse(hmotnostTextBox.Text), 
                                           double.Parse(vyskaTextBox.Text) / 100),
                                       2).ToString();

            BMILabel.ForeColor = BMIBarva(Math.Round(BMI(double.Parse(hmotnostTextBox.Text),
                                                         double.Parse(vyskaTextBox.Text) / 100),
                                                     2));
        }
    }
}
