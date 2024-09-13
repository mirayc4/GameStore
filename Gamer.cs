using System;

namespace GameStore;

public class Gamer
{
    public string Tc { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public List<Game> Sepet { get; set; } = new List<Game>();

}
