using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson16
{
    class Program
    {
        static void Main(string[] args)
        {

            Horse appaloosa = new Horse("Appaloosa Horse", true);
            Horse arabian = new Horse("Arabian Horse", true);
            Horse oldHorse = new Horse("Arabian Old Horse", false);

            Poodle cockapoo = new Poodle("Cockapoo", "Pedigree", "one");
            Wolf redWolf = new Wolf("Red Wolf", "Meat", "Reds wolves");
            PetWolf redWolfBaby = new PetWolf("Red Wolf", "Milk", "Reds wolves");

            AnimalBase[] animals = new AnimalBase[] { appaloosa, arabian, oldHorse, cockapoo, redWolf, redWolfBaby };
            AnimalSing(animals);

            Horse[] racingHorses = new Horse[] { appaloosa, arabian, oldHorse };
            GetRacingHorses(racingHorses);

        }

        public static void AnimalSing(AnimalBase[] animals)
        {
            for (int i = 0; i < animals.Length; i++)
            {
                
                Console.WriteLine(animals[i].MakeSound());
            }
        }

        public static void GetRacingHorses(Horse[] horses)
        {
            int counter = 0;
            for (int i = 0; i < horses.Length; i++)
            {
                if (horses[i]._racingHorse) 
                {
                    counter++;
                } 
            }
            Horse[] racehorses = new Horse[counter];
            for (int i = 0; i < counter; i++)
            {
                if (horses[i]._racingHorse)
                {
                    racehorses[i] = horses[i];
                }
            }
        }
    }
}
