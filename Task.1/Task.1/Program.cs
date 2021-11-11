using System;
using System.Collections.Generic;

namespace TaskList
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //List<int> ls = new List<int>();
            //ls.Add(1);
            //ls.Add(2);
            //ls.Add(3);
            //ls.Add(4);

            //foreach (var item in Task1(ls))
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region task2
            //List<int> ls2 = new List<int>();
            //ls2.Add(1);
            //ls2.Add(2);
            //ls2.Add(3);
            //ls2.Add(4);

            //foreach (var item in Task2(ls2))
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region task3
            //List<string> ls3 = new List<string>();
            //ls3.Add("A");
            //ls3.Add("B");
            //ls3.Add("C");
            //ls3.Add("D");

            //foreach (var item in Task3(ls3))
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region task4
            //List<Car> carList = new List<Car>()
            //{
            //    new Car("Mercedes","e-350",4),
            //    new Car("BMW","M4",2),
            //    new Car("Range-Rover","VOG",4),
            //    new Car("Mercedes","SLS",2),
            //    new Car("Tesla","Plaid",2),
            //};

            //foreach (var item in carList)
            //{
            //    Console.WriteLine(item.FullInfo());
            //}
            //Console.ReadKey();
            #endregion

            #region task5
            //List<byte> ls4 = new List<byte>();
            //ls4.Add(7);
            //ls4.Add(9);
            //ls4.Add(10);
            //foreach (var item in Task5(ls4))
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

        }
        public static List<int> Task1(List<int> list)
        {
            List<int> newList = new List<int>();
            foreach (var item in list)
            {
                newList.Add(item * 3);
            }
            return newList;
        }

        public static List<int> Task2(List<int> list)
        {
            List<int> newList = new List<int>();
            foreach (var item in list)
            {
                newList.Add(item * item * item);
            }
            return newList;
        }
        public static List<string> Task3(List<string> list)
        {
            List<string> newList = new List<string>();
            foreach (var item in list)
            {
                newList.Add("#" + item + "#");
            }
            return newList;
        }

        public static List<byte> Task5(List<byte> byteList)
        {
            byte[] bArr = new byte[] { 1, 2 };
            byte[] bArr2 = new byte[] { 3, 4 };

            byteList.Add(5);
            byteList.AddRange(bArr);
            byteList.Insert(2, 11);
            byteList.InsertRange(3, bArr2);

            byteList.Remove(5);
            byteList.RemoveAll(s=>s>5);
            byteList.RemoveAt(1);
            byteList.RemoveRange(0, 2);
            //byteList.Clear();

            return byteList;
        }
    }
}