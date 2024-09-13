using System;

namespace GameStore;

public class GameManager
{
    public static void OyunlariSirala(List<Game> games){
        System.Console.WriteLine("\nOYUNLAR:");
        foreach(Game game in games){
            int num = 1;
            System.Console.WriteLine(num.ToString() + ":" + game.Ad);
            num++;
        }
    }

    public static string OyunSeciminiAl() {
        System.Console.WriteLine("Hangi oyunu satın almak istiyorsun? İsmini yaz: ");
        string gameName = Console.ReadLine();
        return gameName;
    }

    public static Game IstenilenOyunuBul(string gameName, List<Game> games){
        return games.Find(game => game.Ad.Equals(gameName, StringComparison.OrdinalIgnoreCase));
    }

}
