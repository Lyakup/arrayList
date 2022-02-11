using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("Mehmet");
            liste.Add(21);
            liste.Add(false);
            liste.Add('B');

            Console.WriteLine(liste[1]);

            foreach (var item in liste)
                Console.WriteLine(item);

            //Add Range
            string[] renkler = {"Mavi", "Yeşil", "Kırmızı" };
            List<int> sayilar = new List<int>() { 1, 3, 5 ,22,67};

            liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
                Console.WriteLine(item);

            //Sort
            liste.Sort(); // sıralamak için Arraylistte tek tip değişken türü olmalı 

            //Reverse
            liste.Reverse(); // listeyi ters çevirerek sıralar
            liste.Clear(); 
        }
    }
}
