using System;
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
            return "Vous apercevez une ombre au loin de cette salle, des lumières rouges , des chants très louches selon vous.  \n\n" +
                "Vous avez très peur, donc vous vous réfugiez à la salle la plus proche.\n\n" +
                "Vous avez le choix entre vous réfugiez dans la [salle] la plus proche ou allez vers l'[ombre]";
            throw new NotImplementedException();
        }

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "ombre":
                    {
                        Game.Transition<Ombre>();
                        

                    }break;
                case "salle":

                    Game.Transition<SalleVide>();
                    break;

                
            }

        }

        

    }
}
