using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson16
{ 
    class Horse : AnimalBase
    {
        public bool _racingHorse;
        public Horse(string _name, bool _racingHorse) : base(_name)
        {
            this._racingHorse = _racingHorse;
        }
        public virtual void Neigh()
        {
            Console.WriteLine("Neigh");
        }

        public override void MakeSound()
        {
            Neigh();
        }

        public override string ToString()
        {
            return $"{base.ToString()} Is racing : {_racingHorse}";
        }

    }
}
