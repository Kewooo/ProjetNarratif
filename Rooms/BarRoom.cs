using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class BarRoom : Room                                                                                                                       
    {
        internal override string CreateDescription()

        {
            return "Vous ne savez pas vous etes oû, mais vous avez envie d'explorer et d'entrer dans les differentes salles.\n\n" +
                " Vous apercevez une [porte] à votre droite.\n\n" +
                "Si vous avez peur, vous pouvez revenir a la [toilette]";                                                                          
            throw new NotImplementedException();
        }

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "porte":
                    {
                        Game.Transition<BasementRoom>();


                    }break;

                case "toilette":
                    {
                        Game.Transition<Bathroom>();

                    }break;




            }
            
        }
    }
}
