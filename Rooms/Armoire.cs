using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Armoire : Room
    {
        internal override string CreateDescription()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return "Vous ouvrez la porte et ce qui est face a vous est ignoble et cruel;\n\n" +
                "3 corps demembrer et des ecriture en latin, vous voulez absolument fermer la [porte]";
            throw new NotImplementedException();
        }
        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "porte": 
                    {
                        Game.Transition<Boucherie>();
                    
                    }break;

            }
        }




























    }
}
