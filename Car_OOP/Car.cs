using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_OOP
{
    internal class Car
    {
        public string car;
        public float speed;
        public float brakes;
        public Car(string car, float speed, float brakes) 
        {
            this.car = car;
            this.speed = speed; 
            this.brakes = brakes;   
        
        }  
    }
}
