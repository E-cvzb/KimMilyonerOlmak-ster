using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Merhaba hoşgeldin karşına gelecek 3 sorudan sonra milyoner olabilirsin");
Console.WriteLine("Hazırsan başlayalım ");
Console.ReadLine();
int dogrucevapsayısı = 0;//doğru sayısını saymak için int ile sayaç oluşturuyorum

Console.WriteLine("Birinci sorumuz ile başlıyoruz");
Console.WriteLine("Dünya da deniz seviyesinin altında olan gölünün adı hangisidir");
Console.WriteLine("A)Lut gölü B)Van gölü");
char cevap1= Convert.ToChar(Console.ReadLine().ToUpper());//yarişmacı şıkları söyleyerek yarışmaya devam ediyor o yuzden char kulanıyorum

if (cevap1 =='A')
{
    Console.WriteLine("Tebrikler ilk soruyu doğru cevapladın");
    dogrucevapsayısı++;//doğru sayaçlarını doğru cevaplara ekliyorum 
   
}
else
{
    Console.WriteLine("Malesef soruyu yanlış cevapladın kazanmak için iki soruyu da doğru cevaplaman gerekiyor");
}
Console.WriteLine($"Doğru cevap sayınız {dogrucevapsayısı}");
Console.WriteLine("İkşinci sorumuza geçiyorum");
Console.WriteLine("Tavşanların kaç bacağı verdır?");
Console.WriteLine("A)2 B)4");
char cevap2 = Convert.ToChar(Console.ReadLine().ToUpper());


switch (cevap2)
{
    case 'B':
        Console.WriteLine("Cevabınız doğru ");
        dogrucevapsayısı++;
        break;
    default:
        Console.WriteLine("Malesef bunu da yanlış cevapladınız ");
        break;
}
Console.WriteLine($"Doğru cevap sayınız {dogrucevapsayısı}");
if (dogrucevapsayısı >= 2)//2. sorudan sonra kaznma ihtimaline karşı doğru cevap sayısına kontrol sağlıyorum
{
    Console.WriteLine("Tebrikler yarışmayı kazandınız ve milyoner oldunuz");
}
else//doğru sayısı 2 ye ulaşamadıysa burda else ile 3. sorumu soruyorum 
{
    Console.WriteLine("Üçüncü soruyu geçelim");
    Console.WriteLine("2x(82/2) işleminin sonucu nedir");
    Console.WriteLine("A)42 B)40");
    char cevap3 = Convert.ToChar(Console.ReadLine().ToUpper());
    switch (cevap3)
    {
        case 'A':
            Console.WriteLine("Tebrikler doğru cevapladınız");
            dogrucevapsayısı++;
            break;
        default:
            Console.WriteLine("Yanlış cevapladınız");
            break;
    }
}

Console.WriteLine($"Doğru cevap sanyınız {dogrucevapsayısı}");
 

if (dogrucevapsayısı>= 2)//bütün sorular bittikten sonra tekrardan kazanma ihtimaline karşın doğru cevap sayısını tekrar değerlendiriyorum
{
    Console.WriteLine("Tebrikler yarışmayı kazandınız ve milyoner oldunuz");
}
else
{
    Console.WriteLine( "Malesef yarışmayı kaybettiniz");
}



