using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_Practice.Models
{
   public abstract class Animal
    {

        public string Name { get; set; }

        public abstract void Eat();
    }
}
