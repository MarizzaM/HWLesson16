using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson16
{
    class Dog : AnimalBase
    {
        public string _favoriteDogFood;
        public Dog(string _name, string _favoriteDogFood) : base(_name)
        {
            this._favoriteDogFood = _favoriteDogFood;
        }
        public virtual void Bark()
        {
            Console.WriteLine("Bark");
        }

        public override void MakeSound()
        {
            Bark();
        }

        public override string ToString()
        {
            return $"{base.ToString()} Favorite food : {_favoriteDogFood}";
        }
    }
}
