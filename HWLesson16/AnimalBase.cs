using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson16
{
    abstract class AnimalBase
    {
        public string _name;

        public AnimalBase(string _name)
        {
            this._name = _name;
        }

        public abstract void MakeSound();

        public override string ToString()
        {
            MakeSound();
            return $"{_name}";
        }

    }
}
