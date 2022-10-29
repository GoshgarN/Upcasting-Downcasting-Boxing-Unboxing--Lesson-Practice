using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_Practice.Models
{
    public class Eagle : Bird
    {
        public string Color { get; set; }

        //public Eagle()
        //{
        //    Console.WriteLine("Eagle constructor");
        //}

        public override void Eat()
        {
            Console.WriteLine("Eagle eating");
        }
    }
}
