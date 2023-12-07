using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Ombre : Room
    {
        internal override string CreateDescription()
        {

           return ("Vous decidez d'y avancer quand meme, les chants augmente de décibels, vous voyez des gens en capuche rouge.\n\n" +
                " Un d'entre eux vous apercois, il commence a vous attaquer\n\n" +
                "Vous devez vous refugiez a la [salle] la plus proche.");
            throw new NotImplementedException();
        }

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "salle":

                    {
                        Game.Transition<Boucherie>();

                    }
                    break;
                    
                   





            }
        }




    }
}
