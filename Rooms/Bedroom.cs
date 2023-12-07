namespace ProjetNarratif.Rooms
{
    internal class Bedroom : Room
    {
        internal override string CreateDescription() =>
@"Vous venez de vous réveiller.
Un mal de tête poignant vous prends.
Vous n'êtes pas conscient de votre situation ni de l'endroit ou vous vous trouvez.
Tu vois une [note] avec un message sur ta table de chevet
Tu décides d'aller vers ta [toilette]

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
                        "je t'écris cette note pour t'annoncer que je suis mort...\n\n" +
                        "À la personne qui lit ceci. Je veux que tu continues mon investigation.\n\n" +
                        "Celle-ci consiste a trouver l'ordinateur et copier les fichiers et ensuite s'enfuire avec le disque dur");
                    
                    break;
            }
        }
    }
}
