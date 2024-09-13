using System;
using System.Collections.Generic;

namespace GameStore{
    class Program{
        static void Main(string[] args){

            Game witcher = new Game(){Ad = "The Witcher 3", Stok = 100};
            Game gta = new Game(){Ad = "GTA V", Stok = 100};
            Game cp = new Game(){Ad = "Cyperpunk 2077", Stok = 100};
            List<Game> games = new List<Game>(){witcher, gta, cp};

            Gamer me = new Gamer(){Tc = "1", Ad = "Miray", Soyad = "Çapan", DogumYili = 2002};
            List<Gamer> gamers= new List<Gamer>(){me};

            Campaign eylulK = new Campaign(){Ad = "Eylül Kampanyası"};
            Campaign bdK = new Campaign(){Ad = "Doğum Günü Kampanyası"};
            List<Campaign> campaigns = new List<Campaign>(){eylulK, bdK};

            string secim = WelcomePage.FirstPage();
            if (secim == "1"){
                Gamer newGamer = GamerManager.takeGamerInfo();
                WelcomePage.KayitPage(newGamer, gamers);
            }
            else if (secim == "2"){
                Gamer gamer = GamerManager.takeGamerInfo();               
                WelcomePage.BilgileriGuncellePage(gamer, gamers);
            }
            else if(secim == "3"){
                Gamer gamer = GamerManager.takeGamerInfo();               
                WelcomePage.KaydiSilPage(gamer, gamers);
            }
            else if( secim == "4"){
                Gamer gamer = GamerManager.takeGamerInfo();               
                if (GamerManager.GamerExists(gamer, gamers) == true){
                    WelcomePage.GirisYaptiPage(gamer, gamers, games);
                }
                else{
                    System.Console.WriteLine("Böyle bir kullanıcı bulunmuyor!");
                }
            }
            else if(secim == "5"){
                CampaignManager.KampanyalariSirala(campaigns);
                string islem = CampaignManager.KampanyaIslemleri();
                if (islem == "1"){
                    CampaignManager.YeniKampanyaKoy(campaigns);
                }
                /*else if (islem == "2"){
                    string c = CampaignManager.KampanyaIsmiAl;
                    Campaign ca = CampaignManager.FindCampaign(c, campaigns);
                    CampaignManager.KampanyayiSil(ca, campaigns);
                }/*
                /*else if (islem == "3"){

                }*/
            }




        }
    }
}