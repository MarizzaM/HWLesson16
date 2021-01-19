using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson16
{
    class PetWolf : Wolf
    {
        public PetWolf(string _name, string _favoriteDogFood, string _nameOfPack) : base(_name, _favoriteDogFood, _nameOfPack)
        {
        }

        public override void Bark()
        {
            Console.WriteLine("---");
        }
        public override void MakeSound()
        {
            Bark();
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
