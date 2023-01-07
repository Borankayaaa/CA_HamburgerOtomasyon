string menuSecimi;
int menuFiyati;
int adet;
int toplamTutar;
bool aktifSiparis = true;
string yanit;

void Fiyatlandir()
{
    Console.WriteLine("Lutfen sectiginiz menu numarasini giriniz: ");
    menuSecimi = Console.ReadLine();
    switch (menuSecimi)
    {
        case "1":
            menuFiyati = 30;
            //Console.WriteLine("McChicken menu sectiniz.");
            break;
        case "2":
            menuFiyati = 50;
            //Console.WriteLine("BigMc menu sectiniz.");
            break;
        case "3":
            menuFiyati = 60;
            //Console.WriteLine("TexasSmoke menu sectiniz.");
            break;
        case "4":
            menuFiyati = 45;
            //Console.WriteLine("CheeseBurger menu sectiniz.");
            break;
        default:
            Console.WriteLine("Seciminiz menumuzde mevcut degildir!");
            Fiyatlandir();
            break;
    }
}

void AdetAl()
{
    Console.WriteLine("Lutfen kac adet siparis vereceginizi belirtiniz: ");
    adet = Convert.ToInt32(Console.ReadLine());
}

void TotalHesapla()
{
    toplamTutar = menuFiyati * adet;
    Console.WriteLine($"Odemeniz gereken tutar: {toplamTutar} TL'dir.");
}


while (aktifSiparis)
{
    Console.WriteLine("Menuler:\n1.McChicken => 30 TL \n2.BigMc => 50 TL\n3.TexasSmoke => 60 TL\n4.CheeseBurger => 45 TL");
    Fiyatlandir();
    AdetAl();
    TotalHesapla();

    Console.WriteLine("Tekrar siparis vermek ister misiniz? evet icin e / hayir icin h: ");
    yanit = Console.ReadLine();
    if (yanit == "e")
    {
        aktifSiparis = true;
    }
    else
    {
        aktifSiparis = false;
        Console.WriteLine("Afiyet olsun!");
    }
}
