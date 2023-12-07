namespace ProjetNarratif.Rooms
{
    internal class Bathroom : Room
    {
        internal static bool mouv = false;  
        internal override string CreateDescription() =>
             
@"Dans la toilette, le [bain] est rempli d'eau chaude mais une odeur bizarre s'y presente.
Le [miroir] devant toi affiche ton visage angoisser et tendu.
Tu regardes proche du miroir et tu apercois une [porte] cacher
Tu peux revenir dans ta [chambre].
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "bain":
                    Console.WriteLine("Tu apercois un corps mort dans la baignore .");
                    mouv = true;
                    break;
                    
                case "miroir":
                    
                    if (mouv == false)
                    {
                        Console.WriteLine("Vous devez vous lavez va dans le bain sale puant");

                    }
                    if (mouv == true)
                    {
                        Console.WriteLine("Tu aperçois les chiffres 8888 écrits sur la brume sur le miroir.");
                    }

                    break;

                case "chambre":
                    Console.WriteLine("Tu retournes dans ta chambre.");
                    Game.Transition<Bedroom>();
                    break;
                case "porte":
                    {

                        Console.WriteLine("Tu ouvres la porte tranquillement, un leger grincement , tu entres dans cette mysterieuse piece");
                        Game.Transition<BarRoom>();

                    }break;

                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
