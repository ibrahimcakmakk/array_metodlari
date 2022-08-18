using System;
class Program{

    static void Main(string[] args){

        //sort
        int[] sayiDizisi = {23,12,4,86,72,3,11,17};

        Console.WriteLine("sırasız dizi");
        foreach (var item in sayiDizisi)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("sıralı dizi");
        Array.Sort(sayiDizisi);

        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }
        //clear
        Console.WriteLine("array clear");
        Array.Clear(sayiDizisi,2,2);

        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }
        //reverse
        Console.WriteLine("array reverse");
        Array.Reverse(sayiDizisi);

        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }
        //indexOf
        Console.WriteLine("array indexOf");
        Array.IndexOf(sayiDizisi,23);
        Console.WriteLine(Array.IndexOf(sayiDizisi,23));

        //resize
        Console.WriteLine("array resize");
        Array.Resize<int>(ref sayiDizisi,9);
        sayiDizisi[8] = 99;

        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }
    }
}
