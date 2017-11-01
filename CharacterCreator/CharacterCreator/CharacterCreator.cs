﻿using CharacterCreator.CharacterRaces;
using CharacterCreator.PartyCreation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    class CharacterCreator
    {
        public void MainMenu()
        {
            //Race[,] party = new Race[2, 3];

            Sentient elf = new Sentient();
            elf.Strength = 53;
            elf.Stamina = 106;
            elf.Name = "Snapp";
            elf.Intelligence = 200;
            elf.Charisma = 500;

            NonSentient orc = new NonSentient(200, 80, "Bill",false);
            Human human = new Human(10, 10, "Deidré", 90, 111);
            //Race ka ;
            //ka = human;
            //party[0,0] = elf;
            //party[0,1] = orc;
            //party[0,2] = human;

            //Console.WriteLine("You are playing as a " +
            //    party[0,2].GetType().Name + "\n" + 
            //    party[0,2].PrintRace());
            Dog dog = new Dog(1, 2, "chuchu", false);
            Party<Race> party;
            //party = new Party<Race>(orc);
            party = new Party<Race>(human);
            //party = new Party<Race>(elf);
            party.Hire(elf);
            party.Hire(human);
            //party.Fire(2);
            party.Hire(dog);

            foreach (var race in party)
            {
                Console.WriteLine(race.PrintRace()+"\n----------------------\n");
            }
            Console.WriteLine(human.CalculateNumberOfLanguages());
            Console.ReadLine();
        }
    }
}
