//Geriye Değer Döndürmeyen Bir void metot.

SarkiSözü("Aç kapıyı gardiyan, sevdiklerim yok burada");


static void SarkiSözü(string sarki)
{
    Console.WriteLine(sarki);
}


//Geriye Tamsayı Döndüren Bir metot

Console.WriteLine(Tamsayi());

static int Tamsayi()
{
    Random rnd = new Random();
    int randomNumber = rnd.Next();
    return randomNumber % 2;
}


//Parametre Alan ve Geriye Değer Döndüren Bir Metot

Console.WriteLine(SayiCarpim(5,7));

static int SayiCarpim(int a, int b)
{
    return a * b;
}

//Parametre Alan ve Geriye Değer Döndürmeyen bir Metot

Text("Zekeriya", "Karabey");


static void Text(string isim, string soyisim)
{
    Console.WriteLine($"Hosgeldiniz {isim} {soyisim}");
}