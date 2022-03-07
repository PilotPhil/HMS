using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarineControl.HMS.FORM
{
    public partial class Form_otherDevice : Form
    {
        System.Timers.Timer timer = new System.Timers.Timer(500);
        Random r = new Random();

        public Form_otherDevice()
        {
            InitializeComponent();

            float shipSpeed = 10;
            float windSpeed = 10;
            float shipDirection = 30;
            float windDirection = 30;
            float roll = 0;
            float pitch = 0;
            float heave = 0;
            float acc = 0;

            timer.Elapsed += (s, e) => 
            {
                float tem1 = (float)(shipSpeed + r.Next(-20, 20) / 25.5);
                arcScaleComponent1.Value = tem1;
                tb_speed.Text = tem1.ToString() + "Kn";

                float tem2 = (float)(shipDirection + r.Next(-40, 40) / 45.5);
                arcScaleComponent2.Value = tem2;
                tb_direction.Text = tem2.ToString() + "度";
 
                float tem3 = (float)(windSpeed + r.Next(-10, 10)/15.5);
                arcScaleComponent3.Value = tem3;
                textBox_windSpeed.Text = tem3.ToString() + "m/s";

                float tem4 = (float)(windDirection + r.Next(-5, 5)/10.5);
                arcScaleComponent4.Value = tem4;
                textBox_windDirection.Text = tem4.ToString() + "度";

                float tem5 = (float)(roll + r.Next(-10, 10) / 15.5);
                arcScaleComponent5.Value = tem5;
                tb_roll.Text = tem5.ToString() + "度";

                float tem6 = (float)(pitch + r.Next(-10, 10) / 20.5);
                arcScaleComponent6.Value = tem6;
                tb_pitch.Text = tem6.ToString() + "度";

                float tem7 = (float)(heave + r.Next(-10, 10) / 5.5);
                linearScaleComponent3.Value = tem7;
                tb_heave.Text = tem7.ToString()+"mm";

                float tem8 = (float)(acc + r.Next(0, 10) / 12.5);
                linearScaleComponent1.Value = tem8;
                tb_acc.Text = tem8.ToString() + "m/s^2";



            };

            timer.Start();
        }
    }
}
