using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    
    internal class Boucherie : Room
    {
        internal static bool IsHDDCollected;
        internal override string CreateDescription()
        {
            return "Tu est presentement dans la boucherie, celle ci te semble  bizarre, l'odeur te surprends elle te picote le nez...  \n\n" +
              " L'ambiance est lugubre et les lumieres scintilles;\n\n" +
              "Du sang coulant des armoires, vous vous retournez et vous apercevez une [porte] entrouverte\n\n" +
              "Il y a un [ordinateur] au fond de la salle allumer\n\n" +
              "Vous pouvez vous enfuire par la porte [arriere] a vos risques et peril....    ";
            throw new NotImplementedException();
        }

        internal override void ReceiveChoice(string choice)

        {
            switch (choice)
            {
                case "porte":
                    {
                        Game.Transition<Armoire>();


                    } break;


                case "ordinateur":

                    {
                       
                        int i = 0;
                        while (i < 10)
                        {
                            Console.WriteLine("Vous apercevez des vidéos d'archives très louches qui peuvent être très bonnes pour votre investigation.\n\n" +
                                "Des meutres horribles, des rituels macabres, des actions à glacer le sang...\n\n" +
                                "Des frissons vous montes a la peau, vous avez peur soudainement, vous avez le gout de vous en aller,\n\n" +
                                "Vous décidez de transmettre les fichiers sur votre disque dur.\n\n" +
                                "Copie des fichiers en cours");
                            Console.Write("[");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            for (int j = 0; j < 10; j++)
                            {

                                if (i == j)
                                {
                                    Console.ResetColor();
                                }
                                Console.Write("\u25A0");

                            }
                            Console.ResetColor();
                            Console.WriteLine("]");
                            i++;
                            Thread.Sleep(1000);

                            Console.Clear();
                        }
                        Console.WriteLine("Copie Terminée.");
                        Console.ReadKey();
                        IsHDDCollected = true;
                    } break;

                case "arriere":
                    {




                        Console.WriteLine("Vous ouvrez rapidement la porte, vous etes dans un endroit tres louche...\n\n" +
                            "vous voyez des conduits aeriens, vous rentrez dedans pour tentez de vous echapper\n\n" +
                            "vous reussisez!\n\n" +
                            "Il y a une voiture devant, vous y entrez\n\n");


                        if (IsHDDCollected == true)
                        {
                            Console.WriteLine("Bravo,vous vous etes echapper, apres toutes ces atrocités, vous êtes un/e survivant/e\n\n" +
                                    "Felicitations!\n\n" +
                                    "A la prochaine.....");
                            Game.Finish();

                        }
                        if (IsHDDCollected==false)
                        {
                            Console.WriteLine("Le disque dur que vous avez besoin n'est pas avec vous...\n\n" +
                                
                                    "5 hommes cagoules portant des habits entierements noirs attendaient votre retour..\n\n" +
                                    "Ils vous tuent sans pitie,se debarassant ensuite de votre depouille dans la boucherie.");
                            Game.Finish();

                        }


                    }break;


                    }



                    






            }

        }
    } 

     


                    