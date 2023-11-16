﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class BasementRoom : Room
    {
        internal override string CreateDescription()
        {
            return "Woah, je ne pensais pas que vous alliez decouvrir cette Salle[toilette], vous apercevez une ombre au loin de cette salle, des lumieres rouges , des chants tres louche selon vous\n\n" +
                "vous avez tres peur et donc vous vous refugiez a la [salle] la plus proche";
            throw new NotImplementedException();
        }

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "ombre":
                    {
                        Console.WriteLine("vous decidez d'y avancer quand meme, les chants augmente de decibels, vous voyez des gens en capuche rouge, un d'entre eux vous apercois, il commence a vous attaquer");
                        

                    }break;
                case "salle": { Game.Transition<Boucherie>();   }break;

                case "toilette": 
                    {
                        Game.Transition<Bathroom>();          
                    
                    }break;
            }

        }

        

    }
}
