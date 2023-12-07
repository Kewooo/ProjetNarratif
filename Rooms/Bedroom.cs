namespace ProjetNarratif.Rooms
{
    internal class Bedroom : Room
    {
        internal override string CreateDescription() =>
@"Vous venez de vous reveiller.
Un mal de tete poignant vous prend.
Vous n'etes pas conscient de votre situation ni de l'endroit ou vous vous trouvez.
Tu vois une [note] avec un message sur ta table de chevet
Tu decides d'aller vers ta [toilette]

";

        internal override void  ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "toilette":
                    Console.WriteLine("Tu entres dans la toilette.");
                    Game.Transition<Bathroom>();
                    break;

                case "note":

                    Console.WriteLine("Bonjour mon nom est William Church,\n\n" +
                        "je t'ecris cette note pour t'annoncer que je suis mort...\n\n" +
                        "A la personne qui lit ceci. Je veux que tu continues mon investigation.\n\n" +
                        "Celle-ci consiste a trouver l'ordinateur et copier les fichiers et ensuite s'enfuire avec ceux-ci");
                    
                    break;
            }
        }
    }
}
