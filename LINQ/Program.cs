using System.Runtime.Versioning;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> games = new List<string> {"Minecraft", "Tetris", "Doom", "Pacman", "Portal", "Call Of Duty", "Fortnight"};
            var orderd = games.OrderByDescending(x => x.Length).Reverse();
            foreach (string game in orderd) {
                Console.WriteLine(game);
            }
        }
    }
}
