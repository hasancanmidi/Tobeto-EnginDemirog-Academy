int sayi1 = 10;
int sayi2 = 30;
sayi1 = sayi2;
sayi2 = 65;
//sayi1 ?? > 30

int[] sayilar1 = new int[]{10,20,30};
int[] sayilar2 = new int[]{100,200,300};
sayilar1 = sayilar2;
sayilar2[0] = 999;
//sayilar1[0] ?? > 999

/*
int,decimal,float,double,boolean = Değer tip
array,class,interface = Referans tip

Nasıl çalışır ? 

Bellekte stack ve heap diye iki alan vardır. Değişken tanımladıgında değer tipler stack olur.
Referans tipler ise heap'dır.

         Stack                       Heap
        -------                     ------
     Sayi1 = 10>30
     Sayi2 = 30>65
     Sayilar1 //1                 [10,20,30] //1
     Sayilar2 //2                 [100,200,300] //2
     
     Satır 9'da ki gibi eşitlediğimizde sayilar1'in referans numarası ile sayilar2'nin referans numarası
     adres kopyalaması yapar
     
     Stack                           Heap
    -------                        -------
   Sayilar1 //2                X [10,20,30] //1 (Bunu tutan olmadığı için garbage collector bellekten atar)
   Sayilar2 //2                 [100,200,300] //2
*/