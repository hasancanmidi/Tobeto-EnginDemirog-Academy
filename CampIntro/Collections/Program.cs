﻿// string[] isimler = new string[] {"engin","murat","halil","kerem"};
// Console.WriteLine(isimler[0]);
// Console.WriteLine(isimler[1]);
// Console.WriteLine(isimler[2]);
// Console.WriteLine(isimler[3]);
// isimler = new string [5];
// isimler[4] = "ilker";
// Console.WriteLine(isimler[4]);

/*
    Arrayler gerçek hayatta çok fazla kullanılmamaya başlandı. >> List
    Arraylerde sabitlik var 4 elemanlı yaptığınızda eleman ekleyemiyorsunuz.
*/
List<string> isimler2 = new List<string> {"engin","murat","kerem","halil"};
Console.WriteLine(isimler2[0]);
Console.WriteLine(isimler2[1]);
Console.WriteLine(isimler2[2]);
Console.WriteLine(isimler2[3]);
isimler2.Add("ilker");
Console.WriteLine(isimler2[4]);
