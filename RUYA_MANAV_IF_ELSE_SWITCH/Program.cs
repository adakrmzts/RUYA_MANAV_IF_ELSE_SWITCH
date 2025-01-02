/*
        Console.WriteLine("Rüya Manava Hoşgeldiniz; Fiyatlarımız şu şekildedir;");
        Console.WriteLine("*ELMA = 2 TL ");
        Console.WriteLine("*ARMUT = 3 TL ");
        Console.WriteLine("*ÇİLEK = 2 TL ");
        Console.WriteLine("*MUZ = 3 TL ");
        Console.WriteLine("*KALAN TÜM MEYVE VE SEBZELER 4 TL");
        Console.WriteLine("*Ne istersiniz? ");

// Alt satırda yazılan harflerin hepsini küçük harfe çevirdim. 

string meyve = Console.ReadLine().ToLower();

// Burada or(veya) özelliğini kullandım. 
//if-else if ve else kullanmamın sebebi her satırda true değerini yokladıktan sonra alt satırın aktifleşmesine karar vermekti.

if (meyve == "elma" ||  meyve == "çilek")
    Console.WriteLine("Seçtiğiniz meyve 2 TL.");
else if (meyve == "armut" || meyve == "muz")
    Console.WriteLine("Seçtiğiniz meyve 3 TL.");
else
    Console.WriteLine("Seçtiğniz meyve 4 TL. ");

*/

Console.WriteLine("Rüya Manava Hoşgeldiniz; Fiyatlarımız şu şekildedir;");
Console.WriteLine("*ELMA = 2 TL ");
Console.WriteLine("*ARMUT = 3 TL ");
Console.WriteLine("*ÇİLEK = 2 TL ");
Console.WriteLine("*MUZ = 3 TL ");
Console.WriteLine("*KALAN TÜM MEYVE VE SEBZELER 4 TL");
Console.WriteLine("*Ne istersiniz? ");

string meyve = Console.ReadLine().ToLower();
 
switch(meyve)
{
    case "elma":
    case "çilek":
// Bu noktada aynı fiyatta olan meyveler eşledim kod uzamasın diye.
        Console.WriteLine("Seçtiğiniz meyve 2 TL.");
        break;
    case "armut":
    case "muz":
        Console.WriteLine("Seçtiğiniz meyve 3 TL. ");
        break;
//Kalan tüm meyveler aynı fiyat olduğu için kalanların hepsinde 4tl yazmasını istedim.
    default: 
        Console.WriteLine("Seçtiğiniz meyve 4 TL");
        break;  
}

