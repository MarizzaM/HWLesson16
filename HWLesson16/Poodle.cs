using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson16
{
    class Poodle : Dog
    {
        public string _numberOfPonnyTails;

        public Poodle(string _name, string _favoriteDogFood, string _numberOfPonnyTails) : base(_name, _favoriteDogFood)
        {
            this._numberOfPonnyTails = _numberOfPonnyTails;
        }
        public override void Bark()
        {
            Console.WriteLine("Poodle Bark");
        }

        public override string ToString()
        {
            return $"{base.ToString()} Number Of PonyTails : {_numberOfPonnyTails}";
        }
    }
}
