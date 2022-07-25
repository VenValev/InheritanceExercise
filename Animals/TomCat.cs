using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    internal class TomCat : Cat
    {
        private const string defGender = "Male";
        public TomCat(string name, int age) 
            : base(name, age, defGender)
        {
        }

        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
