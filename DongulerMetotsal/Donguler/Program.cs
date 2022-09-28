int[] sayilar = { 10, 17, 5, 21, 40, 7 }; 
int  sayac = 0;
int toplam = 0;

Basla();

void Basla()
{
    ForEachDongusu();  // Bu şekilde yazarsak kod kazanımı sağlamıyor ama okuma kolaylığı sağlamış oluyoruz. Daha profseyonel bir kodlama yapmış oluyoruz.
    WhileDongusu();
    DoDongusu();
    ForDongusu();
}

void BaslıkYaz(string metin)
{
    toplam = 0;
    sayac = 0;
    Console.WriteLine("********************");
    Console.WriteLine(metin);
    Console.WriteLine("********************");
}

void ToplamAl(int sonuc)
{
    Console.WriteLine("----------------------");
    Console.WriteLine($"Toplam : {sonuc}");
    Console.WriteLine("----------------------");
}

void ForEachDongusu()
{
    BaslıkYaz("For each Döngüsü");

    foreach (var item in sayilar)
    {
        Console.WriteLine(item);
        toplam += item;
    }
    ToplamAl(toplam);
}

void WhileDongusu()
{
    BaslıkYaz("While Döngüsü");

    while (sayac < sayilar.Length)
    {
        Console.WriteLine(sayilar[sayac]);
        toplam += sayilar[sayac];
        sayac++;
    }
    ToplamAl(toplam);
}

void DoDongusu()
{
    BaslıkYaz("Do Döngüsü");

    do
    {
        Console.WriteLine(sayilar[sayac]);
        toplam += sayilar[sayac];
        sayac++;
    } while (sayac < sayilar.Length);
    ToplamAl(toplam);
}

void ForDongusu()
{
    BaslıkYaz("For Döngüsü");

    for (int i = 0; i < sayilar.Length; i++)
    {
        Console.WriteLine(sayilar[i]);
        toplam = toplam + sayilar[i];  
    }
    ToplamAl(toplam);
}
