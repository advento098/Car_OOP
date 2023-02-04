using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_OOP
{
    public partial class Form1 : Form
    {

        public float bmw_speed = 300;
        public float lamborghini_speed = 320;
        public float ferrari_speed = 310;

        public float bmw_brakes = 100;
        public float lamborghini_brakes = 200;
        public float ferrari_brakes = 150;




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_bmw_Click(object sender, EventArgs e)
        {
            Car bmw = new Car(btn_bmw.Text, bmw_speed, bmw_brakes);
            label1.Text = bmw.speed.ToString();
            label6.Text = bmw.brakes.ToString();
            car_label.Text = bmw.car;
        }

        private void btn_lamborghini_Click(object sender, EventArgs e)
        {
            Car lambo = new Car(btn_lamborghini.Text, lamborghini_speed, lamborghini_brakes);
            label1.Text = lambo.speed.ToString();
            label6.Text = lambo.brakes.ToString();
            car_label.Text = lambo.car;
        }

        private void btn_ferrari_Click(object sender, EventArgs e)
        {
            Car ferrari = new Car(btn_ferrari.Text, ferrari_speed, ferrari_brakes);
            label1.Text = ferrari.speed.ToString();
            label6.Text = ferrari.brakes.ToString();
            car_label.Text = ferrari.car;
        }

        private void btn_red_Click(object sender, EventArgs e)
        {
            car_label.ForeColor = Color.Red;
        }

        private void btn_blue_Click(object sender, EventArgs e)
        {
            car_label.ForeColor = Color.Blue;
        }

        private void btn_green_Click(object sender, EventArgs e)
        {
            car_label.ForeColor = Color.Green;
        }

    }
}
