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
            return "Vous apercevez une ombre au loin de cette salle, des lumieres rouges , des chants tres louche selon vous\n\n" +
                "Vous avez tres peur et donc vous vous refugiez a la plus proche\n\n" +
                "vous avez le choix entre vous refugiez dans la [salle] la plus proche ou allez vers l'[ombre]";
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
