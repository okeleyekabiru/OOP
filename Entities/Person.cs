using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Entities
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Color SkinColor { get; set; }
        public int Height { get; set; }

        public bool CanWalk()
        {
            return Age > 1;
        }

        public abstract bool HasMentralCycle();
    }

    public enum Color
    {
        Dark,
        White,
        Asian
    }

    public class Female : Person
    {
        public override bool HasMentralCycle()
        {
            return true;
        }
    }

    public class Male : Person
    {
        public override bool HasMentralCycle()
        {
            return false;
        }
    }
}