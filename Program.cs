using ProjetNarratif;
using ProjetNarratif.Rooms;

var game = new Game();
game.Add(new Bedroom());
game.Add(new Bathroom());
game.Add(new AtticRoom());
game.Add(new BarRoom());
game.Add(new BasementRoom());
game.Add(new Boucherie());
game.Add(new Armoire());
game.Add(new Ombre());
game.Add(new SalleVide());




while (!game.IsGameOver())
{
    Console.WriteLine("--");
    Console.WriteLine(game.CurrentRoomDescription);
    string? choice = Console.ReadLine()?.ToLower() ?? "";
    Console.Clear();
    game.ReceiveChoice(choice);
}

Console.WriteLine("FIN");
Console.ReadLine();