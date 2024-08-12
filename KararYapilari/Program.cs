
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#region if, else if, else karar yapısı

#region Mevsim
// SORU: Kullanıcıdan alınan ay numarasına karşılık gelen mevsimi ekrana yazan program
//Console.Write("Mevsimini öğrenmek istediğiniz ay numarasını giriniz: ");

//AyNumarasi:
//int ayNum = int.Parse(Console.ReadLine());

//if (ayNum == 12 || ayNum == 1 || ayNum ==2 ) 
//{ 
//    Console.WriteLine($"Girdiğiniz ay numarasına ({ayNum}) göre mevsim KIŞ"); 
//}
//else if (ayNum == 3 || ayNum == 4 || ayNum == 5)
//{
//    Console.WriteLine($"Girdiğiniz ay numarasına ({ayNum}) göre mevsim İLKBAHAR");
//}
//else if (ayNum == 6 || ayNum == 7 || ayNum == 8)
//{
//    Console.WriteLine($"Girdiğiniz ay numarasına ({ayNum}) göre mevsim YAZ");
//}
//else if (ayNum == 9 || ayNum == 10 || ayNum == 11)
//{
//    Console.WriteLine($"Girdiğiniz ay numarasına ({ayNum}) göre mevsim SONBAHAR");
//}
//else { 
//    Console.WriteLine("Geçersiz ay numarası. 1 - 12 arasında bir sayı giriniz");
//    goto AyNumarasi;
//}
#endregion

#region İki tam sayı işlemleri
// SORU: Kullanıcıdan alınan 2 tam sayıdan herhangi biri negatif ise toplamlarını, ikisi de negatif ise çarpımlarını, ikisi de pozitif ise aritmetik ortalamalarını bulup ekran yazan program. Sayılardan biri 0 girilirse kullanıcıdan yeniden o sayıyı isteyecek
//Console.Write("1. sayıyı giriniz: ");

//sayi1Tekrar:
//int sayi1 = int.Parse(Console.ReadLine());
//if(sayi1 == 0)
//{
//    Console.WriteLine("Sayıyı 0 girdiniz. Yeniden bir sayı giriniz: ");
//    goto sayi1Tekrar;
//}

//Console.Write("2. sayıyı giriniz: ");
//sayi2Tekrar:
//int sayi2 = int.Parse(Console.ReadLine());
//if (sayi2 == 0)
//{
//    Console.WriteLine("Sayıyı 0 girdiniz. Yeniden bir sayı giriniz: ");
//    goto sayi2Tekrar;
//}

//if(sayi1 < 0 && sayi2 < 0)
//{
//    Console.WriteLine($"İki sayıyı da negatif girdiniz. Sayıların çarpımı: {sayi1 * sayi2}");
//}
//else if(sayi1 < 0 ||  sayi2 < 0)
//{
//    Console.WriteLine($"Sayılardan biri negatif. Sayıların toplamı: {sayi1 + sayi2}");
//}

//else if (sayi1 > 0 && sayi2 > 0)
//{
//    Console.WriteLine($"İki sayı da pozitif. Sayıların aritmetik ortalaması: {(sayi1 + sayi2) / 2}");
//}

#endregion

#region İçecek Tercihi
// SORU: Kullanıcıdan alınan tercih bilgisine göre hangi içeceğin tercih edildiğini ekrana yazan program
// Ç: Çay, L: Limonata, K: Kola, G: Gazoz

//tercih:
//Console.Write("Hangi içeceği tercih ederiniz? [Ç: Çay, L: Limonata, K: Kola, G: Gazoz] ");
//    string icecek = Console.ReadLine();
//if (icecek == "Ç" || icecek == "ç")
//{
//    Console.WriteLine("İçecek tercihiniz: Çay");
//}
//else if (icecek == "L" || icecek == "l")
//{
//    Console.WriteLine("İçecek tercihiniz: Limonata");
//}
//else if (icecek == "K" || icecek == "k")
//{
//    Console.WriteLine("İçecek tercihiniz: Kola");
//}
//else if (icecek == "G" || icecek == "g")
//{
//    Console.WriteLine("İçecek tercihiniz: Gazoz");
//}
//else {
//    Console.WriteLine("Yanlış bilgi girdiniz. İlgili tercih kodlarından birini giriniz.");
//    goto tercih;
//}

#endregion

#endregion

#region switch case karar yapısı

#region İçecek Tercihi
// SORU: Kullanıcıdan alınan tercih bilgisine göre hangi içeceğin tercih edildiğini ekrana yazan program
// Ç: Çay, L: Limonata, K: Kola, G: Gazoz

//tercih:
//Console.Write("Hangi içeceği tercih ederiniz? [Ç: Çay, L: Limonata, K: Kola, G: Gazoz] ");
//string icecekTercihi = Console.ReadLine();

//switch(icecekTercihi)
//{
//    case "ç":
//    case "Ç":
//        Console.WriteLine("İçecek tercihiniz: Çay");
//        break;

//    case "l":
//    case "L":
//        Console.WriteLine("İçecek tercihiniz: Limonata");
//        break;

//    case "k":
//    case "K":
//        Console.WriteLine("İçecek tercihiniz: Kola");
//        break;

//    case "g":
//    case "G":
//        Console.WriteLine("İçecek tercihiniz: Gazoz");
//        break;

//    default:
//        Console.WriteLine("Yanlış içecek tercihi. İlgili harflerden birini seçiniz.");
//        goto tercih;
//}

#endregion

#region Mevsim
// SORU: Kullanıcıdan alınan ay numarasına karşılık gelen mevsimi ekrana yazan program
//Console.Write("Mevsimini öğrenmek istediğiniz ay numarasını giriniz: ");

//AyNumarasi:
//int ayNum = int.Parse(Console.ReadLine());

//switch(ayNum)
//{
//    case 12:
//    case 1:
//    case 2:
//        Console.WriteLine($"Seçim: {ayNum} Mevsim KIŞ");
//        break;

//    case 3:
//    case 4:
//    case 5:
//        Console.WriteLine($"Seçim: {ayNum} Mevsim İLKBAHAR");
//        break;

//    case 6:
//    case 7:
//    case 8:
//        Console.WriteLine($"Seçim: {ayNum} Mevsim YAZ");
//        break;

//    case 9:
//    case 10:
//    case 11:
//        Console.WriteLine($"Seçim: {ayNum} Mevsim SONBAHAR");
//        break;

//    default : 
//        Console.WriteLine("Yanlış seçim. 1 - 12 arasında bir sayı seçin.");
//        goto AyNumarasi;

//}
#endregion

#endregion


#region ÖDEV
// SORU: Kullanıcıdan alınan suyun sıcaklığı bilgisine göre suyun hangi fazda olduğunu ekrana yazdıran program. Hem if else, hem de switch case ile yap. (Breakpointler 0 ve 100)

#region IF ELSE
//SicaklikGiris:
//Console.Write("Suyun sıcaklığını giriniz: ");
//bool sonuc = int.TryParse(Console.ReadLine(), out int girilenSicaklik);

//if (sonuc)
//{
//    if(girilenSicaklik >= 100)
//    {
//        Console.WriteLine($"{girilenSicaklik} derecede su gaz halindedir.");
//    } 
//    else if(girilenSicaklik <= 0)
//    {
//        Console.WriteLine($"{girilenSicaklik} derecede su katı halindedir.");
//    } 
//    else
//    {
//        Console.WriteLine($"{girilenSicaklik} derecede su sıvı halindedir.");
//    }
//}
//else
//{
//    Console.WriteLine("Hatalı veri girişi. Lütfen sayı giriniz.");
//    goto SicaklikGiris;
//}
#endregion

#region SWITCH CASE
SicaklikGiris:
Console.Write("Suyun sıcaklığını giriniz: ");
bool sonuc = int.TryParse(Console.ReadLine(), out int girilenSicaklik);
switch(sonuc)
{
    case true:
        switch(girilenSicaklik)
        {
            case (>= 100):
                Console.WriteLine($"{girilenSicaklik} derecede su gaz halindedir.");
                break;

            case (<= 0):
                Console.WriteLine($"{girilenSicaklik} derecede su katı halindedir.");
                break;
            default:
                Console.WriteLine($"{girilenSicaklik} derecede su sıvı halindedir.");
                break;

        }
        break;
    default:
        Console.WriteLine("Hatalı veri girişi. Lütfen sayı giriniz.");
        goto SicaklikGiris;
}
#endregion

#endregion

