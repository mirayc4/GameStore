using System;
using System.Runtime.InteropServices;

namespace GameStore;

public class CampaignManager
{
    public static void KampanyalariSirala(List<Campaign> campaigns ){
        System.Console.WriteLine("Kampanyalar:");
        foreach (Campaign c in campaigns){
            int num = 1;
            System.Console.WriteLine(num.ToString() + ":" + c.Ad);
        }
    }

   public static void KampanyayiSil(Campaign campaign, List <Campaign> campaigns){
        campaigns.Remove(campaign);
        System.Console.WriteLine("Kampanya silindi!");
    }

    public static void YeniKampanyaKoy(List<Campaign> campaigns){
        string campaignName = KampanyaIsmiAl();
        if (FindCampaign(campaignName, campaigns) == null)
        { 
            Campaign newCampaign = new Campaign();
            newCampaign.Ad = campaignName;
        }
        else{
            System.Console.WriteLine("Kampanya mevcut!");
        }
    }

    public static string KampanyaIslemleri(){
        System.Console.WriteLine("1. Yeni kampanya girişi \n 2. Kampanya sil\n3.Kampanya güncelle");
        string input = Console.ReadLine();
        return input;
        }
         
    
    /*public static void KampanyaGuncelleme(List<Campaign> campaigns){
        string cName = KampanyaIsmiAl();
        Campaign c = campaigns.FindCampaign(cName, campaigns);
        string 

    }*/

    public static string KampanyaIsmiAl(){
        System.Console.WriteLine("Kampanya ismini giriniz: ");
        string cName = Console.ReadLine();
        return cName;
    }

    public static Campaign FindCampaign(string cName, List<Campaign> campaigns){
        return campaigns.Find(campaign => campaign.Ad.Equals(cName, StringComparison.OrdinalIgnoreCase));
    }


    }
