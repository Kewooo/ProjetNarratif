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
            return "Bienvenue au Bar de la secte [porte] pour explorer les parties mysterieuses de la maison si vous avez peur [toilette] pour revenir en arriere ";                                                                          
            throw new NotImplementedException();
        }

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "porte":
                    {



                    }break;

                case "toilette":
                    {
                        Game.Transition<Bathroom>();

                    }break;




            }
            
        }
    }
}
