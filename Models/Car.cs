using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCShrap.Models
{
    public class Car
    {
        public int Model { get; set; }
        public string Brand { get; set; }
        public void Accelerate()
        {
            Console.WriteLine("Accelerate");
        }
        public void Break()
        {
            Console.WriteLine("Break");
        }
    }
}
