using System;
using System.Security.Cryptography.X509Certificates;

namespace GameStore;

public class GamerManager
{

    public static Gamer takeGamerInfo(){
        Gamer gamer = new Gamer();

            Console.Write("Lütfen TC Kimlik No'yu giriniz: ");
            gamer.Tc = Console.ReadLine();
            Console.Write("Lütfen Adınızı giriniz: ");
            gamer.Ad = Console.ReadLine();
            Console.Write("Lütfen Soyadınızı giriniz: ");
            gamer.Soyad = Console.ReadLine();
            Console.Write("Lütfen Doğum Yılınızı giriniz: ");
            gamer.DogumYili = int.Parse(Console.ReadLine());

            return gamer;
    }
    public static void Kaydol(Gamer gamer, List<Gamer> gamers){
        if (GamerExists(gamer,  gamers) == true){
            System.Console.WriteLine("Kaydınız tespit edildi.");
        }
        else{
            gamers.Add(gamer);
            System.Console.WriteLine("Kaydınız yapıldı!");
        }
    }

    public static bool GamerExists(Gamer gamer, List<Gamer> gamers){
        return (FindGamer(gamer, gamers) != null);
    }

    public static void KaydiSil(Gamer gamer, List<Gamer> gamers){
        if (GamerExists(gamer, gamers)){
            gamers.Remove(gamer);
            System.Console.WriteLine("Kaydınız başarıyla silindi.");
        }
        else{
            System.Console.WriteLine("Kaydınız bulunamadı.");
        }
    }

    public static Gamer FindGamer(Gamer gamer, List<Gamer> gamers){
        Gamer foundGamer = gamers.Find(g =>
                g.Tc == gamer.Tc &&
                g.Ad == gamer.Ad &&
                g.Soyad == gamer.Soyad &&
                g.DogumYili == gamer.DogumYili);
        return (foundGamer);
    }
        
}

