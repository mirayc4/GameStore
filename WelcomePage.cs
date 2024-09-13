using System;
using System.Collections.Generic;

namespace GameStore;

public class WelcomePage
{
    public static string FirstPage()
    {
        System.Console.WriteLine("\n\nHOŞGELDİN\n\n1. Kaydol\n2. Bilgilerimi güncelle\n3.Kaydımı sil \n4.Giriş Yap\n5. Kampanyaları Düzenle \nLütfen İşlem Gir: ");
        string output = Console.ReadLine();
        return output;
    }


    public static void KayitPage(Gamer gamer, List<Gamer> gamers){
        if (!GamerManager.GamerExists(gamer, gamers))
        {
            GamerManager.Kaydol(gamer, gamers); 
        }
        else
        {
            System.Console.WriteLine("Gamer already exists!");
        }
    }

    public static void BilgileriGuncellePage(Gamer gamer, List<Gamer> gamers){
        Gamer oldGamer = GamerManager.FindGamer(gamer, gamers); 
        Gamer newGamer = GamerManager.takeGamerInfo();
        oldGamer = newGamer;
        System.Console.WriteLine("Bilgileriniz güncellendi");
    }

    public static void KaydiSilPage(Gamer gamer, List <Gamer> gamers){
        Gamer oldGamer = GamerManager.takeGamerInfo();
        gamers.Remove(oldGamer);
        System.Console.WriteLine("Kaydınız silindi!");
    }


    public static void GirisYaptiPage(Gamer gamer,List<Gamer> gamers, List<Game> games){
        GameManager.OyunlariSirala(games);
        string gameName = GameManager.OyunSeciminiAl();
        Game wantedGame = GameManager.IstenilenOyunuBul(gameName, games);
        SatisManager.SatisYap(gamer, wantedGame);
    }

    public static void KampanyaPage(){

    }
    }



