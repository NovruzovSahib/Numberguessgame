
//using System.Collections;

////ArrayList arrayList = new ArrayList();
////arrayList.Add(0);
////arrayList.Add(1);
////arrayList.Add(2);

////foreach (var c in arrayList)
////{
////    Console.WriteLine(c);
////}



////Console.WriteLine(Mymethod(5, 6));

//// static int Mymethod(int a, int b)
////{
////    int c = a * b;
////    return c;
////}
//Console.WriteLine("Eded daxil edin");
//Random Random1 = new Random();
//var a = Random1.Next(1, 100);
//var b = 0;
//int count = 0;
//while (b!=a)
//{
//    b = int.Parse(Console.ReadLine());
//    if (b>a)
//    {
//        Console.WriteLine("Kicik eded daxil edin");
//    }
//    else if (a>b)
//    {
//        Console.WriteLine("Boyuk eded daxil edin");

//    }
//    count++;
//}
//Console.WriteLine($"Number is {b} {count}-ci cehdde tapdiniz");
//Console.ReadLine();








int a = 0;
int count = 0;
Random r = new Random();
int c= r.Next(50);

while (a!=c)
{

    try
    {
         Console.Write("Enter a number : ");
         a = Convert.ToInt32(Console.ReadLine());

        if (a>c)
        {
            Console.WriteLine("Enter a small number");
        }
        else if (c>a)
        {
            Console.WriteLine("Enter a big number");

        }
    }
    catch (Exception)
    {
        Console.WriteLine("Only numbers are valid");
        count--;
    }
    count++;

}
Console.WriteLine($"Your number is {a} in {count} try");
Console.ReadLine();




