using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Practicequery
{

    class Program
    {
        static void Main()
        {
            // From w3resource LINQ

            //Q1
            //int[] number = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var nQurry =
            //    from num in number
            //    where (num % 2) == 0
            //    select num;

            //foreach (var num in nQurry)
            //{
            //    Console.WriteLine("{0} ", num);
            //}

            //Q2
            //int[] number = new int[] { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            //var nQuery =
            //    from num in number
            //    where (num > 0)
            //    where (num < 11)
            //    select num;
            //foreach(var item in nQuery)
            //{
            //    Console.WriteLine("{0} ", item);
            //}

            //Q3
            //int[] number = { 3, 9, 2, 8, 6, 5 };

            //var nQuerry =
            //    from num in number
            //    let multi = num * num
            //    where multi > 20
            //    select new { num, multi };
            //foreach (var item in nQuerry)
            //{
            //    Console.WriteLine(item);
            //}

            //Q4
            //int[] number = { 5, 5, 5, 9, 9, 9, 9, 1 };

            //var nQuery =
            //    from num in number
            //    group num by num into num2 //group by can grap specific data in querry Ex. group data in data.name into newquerry
            //    select num2;

            //foreach (var item in nQuery)
            //{
            //    Console.WriteLine("This " + item.Key + " apprear " + item.Count());
            //}


            //Q5
            //Console.Write("Input a string : ");
            //string input = Console.ReadLine();

            //var nQuery =
            //    from word in input
            //    group word by word into newstring
            //    select newstring;

            //foreach (var item in nQuery)
            //{
            //    Console.WriteLine(item.Key + " show up " + item.Count() + " times .");
            //}

            //Q6
            //string[] week = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            //var nQuery =
            //    from day in week
            //    select day;

            //foreach(var item in nQuery)
            //{
            //    Console.WriteLine(item);
            //}

            //Q7
            //int[] number = { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

            //var nQuery =
            //    from num in number
            //    group num by num into newnum
            //    select newnum;

            ////.Sum() 計算數值序列的總和
            //foreach (var item in nQuery)
            //{
            //    Console.WriteLine(item.Key + "\t" + item.Sum() + "\t" + item.Count());
            //}


            //Q8
            //string firstw, lastw;
            //string input;
            //string[] words = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            //Console.Write("Input first char : ");
            //input = Console.ReadLine();
            //firstw = input.ToString();
            //Console.Write("Input last char : ");
            //input = Console.ReadLine();
            //lastw = input.ToString();


            //var nQuery =
            //    from word in words
            //    where word.StartsWith(firstw)
            //    where word.EndsWith(lastw)
            //    select word;

            //foreach(var item in nQuery)
            //{
            //    Console.Write("Select by start char " + firstw + " and last char " + lastw + " : " + item);
            //}

            //Q9
            //int[] number = { 55, 200, 740, 76, 230, 482, 95 };

            //var nQuery =
            //    from num in number
            //    where num > 80
            //    select num;

            //Console.Write("Number greater than 80 : ");
            //foreach (var item in nQuery)
            //{
            //    Console.Write(item + "  ");
            //}

            //Q10
            //int[] number = { 10, 48, 52, 94, 63 };
            //Console.Write("Input the value above you want to display the members of the List : ");
            //int input = Convert.ToInt32(Console.ReadLine());

            //var nQuery =
            //    from num in number
            //    where num > input
            //    select num;

            //foreach(var item in nQuery)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine("is/are greater than {0}", input);

            //Q11
            //List<int> templist = new List<int>();
            //templist.Add(5);
            //templist.Add(7);
            //templist.Add(13);
            //templist.Add(24);
            //templist.Add(6);
            //templist.Add(9);
            //templist.Add(8);
            //templist.Add(7);

            //Console.Write("Number in List : ");
            //foreach(var item in templist)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.Write("\nHow many records you want to display ? : ");
            //int input = Convert.ToInt32(Console.ReadLine());

            //templist.Sort();
            //templist.Reverse();

            //foreach(var item in templist.Take(input))
            //{
            //    Console.Write(item + " ");
            //}

            //Q12
            //string input = "THIS is A STRING";
            //var upperword = filter(input);

            //foreach (var item in upperword)
            //{
            //    Console.Write(item + " ");
            //}

            //static IEnumerable<string> filter(string input)
            //{
            //    var upperword = input.Split(' ').Where(x => String.Equals(x, x.ToUpper(), StringComparison.Ordinal));
            //    return upperword;
            //}

            //Q13
            //Console.Write("Input number of strings to store in the array : ");
            //int size = Convert.ToInt32(Console.ReadLine());
            //string[] array = new string[size] ;

            //Console.WriteLine("Input {0} strings for the array : ", size);

            //for (int i= 0; i <= size-1; i++){
            //    Console.Write("Array[{0}] : ", i);
            //    array[i] = Console.ReadLine();
            //}

            //string newstring = String.Join(",", array.Select(x => x.ToString()).ToArray());

            //Console.WriteLine(newstring);

            //Q14
            //Students e = new Students();

            //Console.Write("Which maximum grade point(1st, 2nd, 3rd, ...) you want to find  : ");
            //int input = Convert.ToInt32(Console.ReadLine());

            //var stulist = e.GtStuRec();

            //var students =
            //    (from stu in stulist
            //     group stu by stu.GrPoint into g
            //     orderby g.Key descending
            //     select new
            //     {
            //         StuRecord = g.ToList()
            //     }).ToList();

            ////array strat from 0 so input have to -1
            //students[input - 1].StuRecord
            //    .ForEach(x => Console.WriteLine(" Id : {0},  Name : {1},  achieved Grade Point : {2}", x.StuId,x.StuName, x.GrPoint));

            //Q15
            //string[] arr1 = { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };

            //var data = arr1.Select(file => Path.GetExtension(file).TrimStart('.').ToLower())
            //    .GroupBy(z => z, (fExt, extCtr) => new
            //    {
            //        Extension = fExt,
            //        Count = extCtr.Count()
            //    });

            //foreach(var item in data)
            //{
            //    Console.WriteLine("{0} File(s) with {1} Extension ", item.Count, item.Extension);
            //}

            //Q16
            //string[] dirfile = Directory.GetFiles("PATH");

            //var avgsize = dirfile.Select(file => new FileInfo(file).Length).Average();
            //avgsize = Math.Round(avgsize / 10 , 1);
            //Console.WriteLine("The Average file size is {0} MB", avgsize);

            //Q17
            //List<string> listOfString = new List<string>();
            //listOfString.Add("m");
            //listOfString.Add("n");
            //listOfString.Add("o");
            //listOfString.Add("p");
            //listOfString.Add("q");

            //var nQuery1 =
            //    from word in listOfString
            //    select word;

            //foreach (var item in nQuery1)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.Write("\nInput a word which will remove : ");
            //string input = Console.ReadLine();

            ////Find the input in listOfString
            //string newstr = listOfString.FirstOrDefault(x => x == input);
            //listOfString.Remove(newstr);

            ////Can also write as from Q18: 
            ////listOfString.Remove(listOfString.FirstOrDefault(x => x == input));

            ////Can also write as from Q19 :
            ////listOfString.RemoveAll(x => x == input);

            ////Can also write as from Q20:              
            ////listOfString.RemoveAt(3);

            ////Can also write as from Q21:
            ////listOfString.RemoveRange(1, 3);

            //var nQuery2 =
            //    from word in listOfString
            //    select word;
            //foreach (var item in nQuery2)
            //{
            //    Console.Write(item + " ");
            //}

            //Q18
            //I think it's same question as Q17.

            //Q19
            //I think it's same question as Q17.

            //Q20
            //I think it's same question as Q17.

            //Q21
            //I think it's same question as Q17.

            //Q22
            //Console.Write("Input number of strings to store in the array : ");
            //int asize = Convert.ToInt32(Console.ReadLine());
            //string[] array = new string[asize];

            //for(int i = 0; i < asize; i++)
            //{
            //    Console.Write("Array[{0}] : ", i);
            //    array[i] = Console.ReadLine();
            //}

            //Console.Write("Input the minimum length of the item you want to find : ");
            //int wsize = Convert.ToInt32(Console.ReadLine());

            //var newobj =
            //    from word in array
            //    where word.Length > wsize
            //    orderby word
            //    select word;

            //foreach(var item in newobj)
            //{
            //    Console.WriteLine(item);
            //}

            //Q23
            //char[] charset1 = { 'X', 'Y', 'Z' };
            //int[] numset1 = { 1, 2, 3, 4 };

            //var cartesian =
            //    from word in charset1
            //    from num in numset1
            //    select new { word, num };

            //Console.WriteLine("cartesian product : ");
            //foreach(var item in cartesian)
            //{
            //    Console.WriteLine(item);
            //}

            //Q24
            //char[] charset1 = { 'X', 'Y', 'Z' };
            //int[] numset1 = { 1, 2, 3 };
            //string[] colorset1 = { "Green", "Orange" };

            //var cartesian =
            //    from word in charset1
            //    from num in numset1
            //    from color in colorset1
            //    select new { word, num, color };

            //Console.WriteLine("cartesian product : ");
            //foreach(var item in cartesian)
            //{
            //    Console.WriteLine(item);
            //}

            //Q25
            // List<Item_mast> itemlist = new List<Item_mast>
            // {
            //new Item_mast { ItemId = 1, ItemDes = "Biscuit  " },
            //new Item_mast { ItemId = 2, ItemDes = "Chocolate" },
            //new Item_mast { ItemId = 3, ItemDes = "Butter   " },
            //new Item_mast { ItemId = 4, ItemDes = "Brade    " },
            //new Item_mast { ItemId = 5, ItemDes = "Honey    " }
            // };

            // List<Purchase> purchlist = new List<Purchase>
            // {
            //new Purchase { InvNo=100, ItemId = 3,  PurQty = 800 },
            //new Purchase { InvNo=101, ItemId = 2,  PurQty = 650 },
            //new Purchase { InvNo=102, ItemId = 3,  PurQty = 900 },
            //new Purchase { InvNo=103, ItemId = 4,  PurQty = 700 },
            //new Purchase { InvNo=104, ItemId = 3,  PurQty = 900 },
            //new Purchase { InvNo=105, ItemId = 4,  PurQty = 650 },
            //new Purchase { InvNo=106, ItemId = 1,  PurQty = 458 }
            // };

            // Console.WriteLine("Item ID\t\tItem Name\t\tPurchase Quantity");
            // Console.WriteLine("--------------------------------------------");

            // var newstring =
            //     from item in itemlist
            //     join purch in purchlist on item.ItemId equals purch.ItemId
            //     select new
            //     {
            //         itemID = item.ItemId,
            //         itemName = item.ItemDes,
            //         pQuantity = purch.PurQty
            //     };

            // foreach (var obj in newstring)
            // {
            //     Console.WriteLine("{0}\t\t{1}\t\t{2}", obj.itemID, obj.itemName, obj.pQuantity);
            // }

            //Q26
            // List<Item_mast> itemlist = new List<Item_mast>
            // {
            //new Item_mast { ItemId = 1, ItemDes = "Biscuit  " },
            //new Item_mast { ItemId = 2, ItemDes = "Chocolate" },
            //new Item_mast { ItemId = 3, ItemDes = "Butter   " },
            //new Item_mast { ItemId = 4, ItemDes = "Brade    " },
            //new Item_mast { ItemId = 5, ItemDes = "Honey    " }
            // };

            // List<Purchase> purchlist = new List<Purchase>
            // {
            //new Purchase { InvNo=100, ItemId = 3,  PurQty = 800 },
            //new Purchase { InvNo=101, ItemId = 2,  PurQty = 650 },
            //new Purchase { InvNo=102, ItemId = 3,  PurQty = 900 },
            //new Purchase { InvNo=103, ItemId = 4,  PurQty = 700 },
            //new Purchase { InvNo=104, ItemId = 3,  PurQty = 900 },
            //new Purchase { InvNo=105, ItemId = 4,  PurQty = 650 },
            //new Purchase { InvNo=106, ItemId = 1,  PurQty = 458 }
            // };

            // Console.WriteLine("Item ID\t\tItem Name\t\tPurchase Quantity");
            // Console.WriteLine("--------------------------------------------");

            // var newstring =
            //     from item in itemlist
            //     join purch in purchlist on item.ItemId equals purch.ItemId
            //     into a
            //         from b in a.DefaultIfEmpty(new Purchase())
            //         select new
            //         {
            //             itemID = item.ItemId,
            //             itemName = item.ItemDes,
            //             pQuantity = b.PurQty
            //         };

            // foreach (var obj in newstring)
            // {
            //     Console.WriteLine("{0}\t\t{1}\t\t{2}", obj.itemID, obj.itemName, obj.pQuantity);
            // }

            //Q27
            // List<Item_mast> itemlist = new List<Item_mast>
            // {
            //new Item_mast { ItemId = 1, ItemDes = "Biscuit  " },
            //new Item_mast { ItemId = 2, ItemDes = "Chocolate" },
            //new Item_mast { ItemId = 3, ItemDes = "Butter   " },
            //new Item_mast { ItemId = 4, ItemDes = "Brade    " },
            //new Item_mast { ItemId = 5, ItemDes = "Honey    " }
            // };

            // List<Purchase> purchlist = new List<Purchase>
            // {
            //new Purchase { InvNo=100, ItemId = 3,  PurQty = 800 },
            //new Purchase { InvNo=101, ItemId = 5,  PurQty = 650 },
            //new Purchase { InvNo=102, ItemId = 3,  PurQty = 900 },
            //new Purchase { InvNo=103, ItemId = 4,  PurQty = 700 },
            //new Purchase { InvNo=104, ItemId = 3,  PurQty = 900 },
            //new Purchase { InvNo=105, ItemId = 4,  PurQty = 650 },
            //new Purchase { InvNo=106, ItemId = 1,  PurQty = 458 }
            // };

            // Console.WriteLine("Item ID\t\tItem Name\t\tPurchase Quantity");
            // Console.WriteLine("--------------------------------------------");

            // var newstring =              
            //     from purch in purchlist
            //     join item in itemlist on purch.ItemId equals item.ItemId
            //     into a
            //         from b in a.DefaultIfEmpty()
            //         select new
            //         {
            //             itemID = b.ItemId,
            //             itemName = b.ItemDes,
            //             pQuantity = purch.PurQty
            //         };

            // foreach (var obj in newstring)
            // {
            //     Console.WriteLine("{0}\t\t{1}\t\t{2}", obj.itemID, obj.itemName, obj.pQuantity);
            // }

            //Q28

            //string[] cities =
            //{
            //    "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
            //};

            ////Not perfect
            ////var nQuery =
            ////    from city in cities
            ////    orderby city.Length
            ////    select city;

            //var cityOrder =
            //    cities.OrderBy(str => str.Length)
            //        .ThenBy(str => str);

            //foreach(var item in cityOrder)
            //{
            //    Console.WriteLine(item);
            //}

            //Q29
            //string[] cities =
            //{
            //    "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
            //};

            //Console.Write("Input a number that will group the array : ");
            //int size = Convert.ToInt32(Console.ReadLine());

            //var split =
            //    from i in Enumerable.Range(0, cities.Length)
            //    group cities[i] by i / size;


            //foreach (var item in split)
            //{
            //    cityView(string.Join(";  ", item.ToArray()));
            //    //Console.WriteLine(item.ToArray());
            //}

            //static void cityView(string cityMetro)
            //{
            //    Console.WriteLine(cityMetro);
            //    Console.WriteLine("--------------------\n");
            //}

            //Q30
            var itemlist = (from i in Item_Mast.GetItemMast() select i.ItemDes).Distinct().OrderBy(x => x);
            foreach (var item in itemlist)
            {
                Console.WriteLine(item);
            }
        }
    }
    //Q14
    //public class Students
    //{
    //    public string StuName { get; set; }
    //    public int GrPoint { get; set; }
    //    public int StuId { get; set; }

    //    public List<Students> GtStuRec()
    //    {
    //        List<Students> stulist = new List<Students>();
    //        stulist.Add(new Students { StuId = 1, StuName = " Joseph ", GrPoint = 800 });
    //        stulist.Add(new Students { StuId = 2, StuName = "Alex", GrPoint = 458 });
    //        stulist.Add(new Students { StuId = 3, StuName = "Harris", GrPoint = 900 });
    //        stulist.Add(new Students { StuId = 4, StuName = "Taylor", GrPoint = 900 });
    //        stulist.Add(new Students { StuId = 5, StuName = "Smith", GrPoint = 458 });
    //        stulist.Add(new Students { StuId = 6, StuName = "Natasa", GrPoint = 700 });
    //        stulist.Add(new Students { StuId = 7, StuName = "David", GrPoint = 750 });
    //        stulist.Add(new Students { StuId = 8, StuName = "Harry", GrPoint = 700 });
    //        stulist.Add(new Students { StuId = 9, StuName = "Nicolash", GrPoint = 597 });
    //        stulist.Add(new Students { StuId = 10, StuName = "Jenny", GrPoint = 750 });
    //        return stulist;
    //    }
    //}

    //Q25 , 26 , 27
    //public class Item_mast
    //{
    //    public int ItemId { get; set; }
    //    public string ItemDes { get; set; }

    //}
    //public class Purchase
    //{
    //    public int InvNo { get; set; }
    //    public int ItemId { get; set; }
    //    public int PurQty { get; set; }

    //}

    //Q30
    class Item_Mast
    {
        public int ItemId { get; set; }
        public string ItemDes { get; set; }

        public static List<Item_Mast> GetItemMast()
        {
            List<Item_Mast> itemlist = new List<Item_Mast>();
            itemlist.Add(new Item_Mast() { ItemId = 1, ItemDes = "Biscuit  " });
            itemlist.Add(new Item_Mast() { ItemId = 2, ItemDes = "Honey    " });
            itemlist.Add(new Item_Mast() { ItemId = 3, ItemDes = "Butter   " });
            itemlist.Add(new Item_Mast() { ItemId = 4, ItemDes = "Brade    " });
            itemlist.Add(new Item_Mast() { ItemId = 5, ItemDes = "Honey    " });
            itemlist.Add(new Item_Mast() { ItemId = 6, ItemDes = "Biscuit  " });
            return itemlist;
        }
    }
}

