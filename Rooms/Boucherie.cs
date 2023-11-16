using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Boucherie : Room
    {
        internal override string CreateDescription()
        {
            return "Tu est presentement dans la boucherie, celle ci te semble  bizarre, l'odeur te surprends elle te picote le nez...  \n\n" +
              " L'ambiance est lugubre et les lumieres scintilles;\n\n" +
              "Du sang coulant des armoires, vous vous retournez et vous apercevez une [porte] entrouverte\n\n" +
              "Il y a un [ordinateur] au fond de la salle allumer";  
            throw new NotImplementedException();
        }

        internal override void ReceiveChoice(string choice) 
        
        { 
        switch (choice)
            {
                case  "porte": 
                    {
                        Game.Transition<Armoire>();
                    
                    
                    }break;


                case "ordinateur": 
                    
                    {
                        Console.WriteLine("Vous apercevez des videos d'archives tres louches qui peuvent etre tres bonne pour votre investigation.\n\n" +
                                "Des meutres horribles, des rituels macabres, des actions a glacer le sang..\n\n" +
                                "Des frissons vous montes a la peau, vous avez peur soudainement, vous avez le gout de vous en aller");
                    
                    
                    } break;


            }
        
        
        
        
        
        }
    }
}
                    