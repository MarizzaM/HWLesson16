using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson16
{
    class Wolf : Dog
    {
        public string _nameOfPack;

        public Wolf(string _name, string _favoriteDogFood, string _nameOfPack) : base(_name, _favoriteDogFood)
        {
            this._nameOfPack = _nameOfPack;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Number Of Pack : {_nameOfPack}";
        }
    }
}
