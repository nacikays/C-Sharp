# For Döngüsü ve Break Continue

Örnek bir for döngüsü 2 ifade, 1 koşuldan oluşur.
```
for(ifade1;kosul;ifade2)
{
    komut1;
    komut2;
}
```
- ifade1: Döngünün sayacının tanımlandığı ve atamasının yapıldığı ifadedir. Örneğin; int i=0;

- ifade2: Döngünün sayacının artırım yada azaltım şeklini belirten ifadedir. Örneğin ; i++, i-- gibi.

- koşul: döngünün devam etme koşuludur. Bu koşul sağlandığı sürece döngü devam eder. Örneğin : i<=12;

***ÖNEMLİ:*** For döngüsünü oluşturan bu 2 ifade 1 koşulun bir kısmı ya da tamamı boş bırakılabilir. Ama aralardaki ";" işareti mutlaka kullanılmalıdır.

```for(;;) // Sonsuz döngüyü ifade eder.``` 
## Break
Break ifadesi döngü içerisinden çıkmak istenildiğinde kullanılır.
```
for (int i; ;)// Sonsuz döngü
{
    a = Convert.ToChar(Console.ReadLine());
    if (i == 7)
        break;
}
//Kod burdan devam eder. 
```

Yukarıdaki örnekte console'dan girilen değer 7' ye eşit ise döngü sonlandırılır.

Not: İç içe döngüler kullanıldığında break ifadesi yalnızca içinde bulunduğu ilk döngüyü sonlandırır.

## Continue 
Kullanım amacı break ifadesine benzer ama continue sadece mevcut iterasyonu sonlandırır. Döngü bir sonraki iterasyondan devam eder.

for (int i = 1; i <= 10; i++)
{
    if (i % 2 == 0)
        continue;
    Console.WriteLine(i);
}
Yukarıdaki örnekte i çift sayıya eşit olduğunda döngünün o anki iterasyon sonlanacaktır. Bu durumda console'a 1 ile 10 arasındaki tek sayılar yazdırılacaktır.
