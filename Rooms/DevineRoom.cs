using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class DevineRoom : Room
    {
        internal override string CreateDescription()
        {
            return ("Bonjour je vais vous poser une [enigme]");

            throw new NotImplementedException();


        }
        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "enigme":
                    {
                        int nombreEssais = 2;

                        
                        string motMagique = "visualstudio";

                        
                        Console.WriteLine("Bienvenue dans le jeu de devinette !");
                        Console.WriteLine("La question : Quel est l'application (sans espaces) ?");
                        Console.WriteLine("Le mot commence par V");
                       
                        for (int essai = 1; essai <= nombreEssais; essai++)
                        {
                            
                            Console.Write("Essai {0}/{1}. Entrez votre réponse : ", essai, nombreEssais);
                            string reponseJoueur = Console.ReadLine();

                            
                            if (reponseJoueur == motMagique)
                            {
                                
                                Console.WriteLine("Félicitations ! Vous avez trouvé le mot magique.");
                                break; 
                            }
                            else
                            {
                               
                                Console.WriteLine("Dommage ! Ce n'est pas le mot magique.");

                                
                                if (essai < nombreEssais)
                                {
                                    Console.WriteLine("Indice : On utilise cette application pour coder.", motMagique);
                                }
                            }


                            if (essai == nombreEssais)
                            {
                                Console.WriteLine("Désolé, vous n'avez plus d'essais. Le mot magique était '{0}'.", motMagique);
                            }



                        }
                        break;

                    }
            }

        }
    }
}
