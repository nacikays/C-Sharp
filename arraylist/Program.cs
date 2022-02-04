using System;
using System.Collections;
using System.Collections.Generic;

namespace arraylist
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Arraylist liste = new Arraylist();
           liste.Add("Ayşe");
           liste.Add(2);
           liste.Add(true);
           liste.Add('A');

        //içerisinde verilen erişim
        Console.WriteLine(liste[1]);

        foreach (var item in liste)
            Console.WriteLine(item);
        
        //AddRange
        Console.WriteLine("****** Add Range ******");
        string[] renkler ={"Kırmızı","Sarı","yeşil"};
        Liste<int> sayılar = new Liste<int>(){1,8,3,7,9,92,5};
        liste.AddRange(renkler);
        Liste.AddRange(sayılar);

        foreach (var item in liste)
            Console.WriteLine(item);
        
        //Sort
        Console.WriteLine("**** Sort ****")    
        liste.Sort();

        foreach (var item in liste)
            Console.WriteLine(item); // 1,3,5,7,8,9,92

        //Binary Search 
        Console.WriteLine("**** Binary Search ****");
        Console.WriteLine(liste.BinarySearch(9)); // 5

        //Reverse
        Console.WriteLine("**** Reverse ****");
        liste.Reverse();

        foreach (var item in liste)
            Console.WriteLine(item); //92,9,8,7,5,3,1 

        //Clear
        liste.Clear();
        
        foreach (var item in liste)
            Console.WriteLine(item);




        }
    }
}