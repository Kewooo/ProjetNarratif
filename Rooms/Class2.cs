using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class SalleVide :Room 
    {

        internal override string CreateDescription()
        {
            return "Vous faites le tour de cette salle,il y a quelques trace de sang, des ecritures bizzares,\n\n" +
                " mais sinon elle est vide\n\n" +
                "Vous revenez donc en [arriere]";
            throw new NotImplementedException();
        }
        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "arriere":
                    Game.Transition<BasementRoom>();
                    
                    break;
            }
        }
    }
}
