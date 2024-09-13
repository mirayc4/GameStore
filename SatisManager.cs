using System;

namespace GameStore;

public class SatisManager
{
    public static void SatisYap(Gamer gamer, Game game){
        SepeteEkle(gamer, game);
        StokIndir(gamer, game);
        System.Console.WriteLine(game.Ad + "'i satın aldınız!");
    }
    public static void SepeteEkle(Gamer gamer, Game game){
        gamer.Sepet.Add(game);
    }
    public static void StokIndir(Gamer gamer, Game game){
        game.Stok--;
    }

    
    /*public static bool SepetteOyunVarMi(Gamer gamer, Game game){
        return (gamer.Sepet).Exists(g => g.Ad == game.Ad);
    }*/

}
