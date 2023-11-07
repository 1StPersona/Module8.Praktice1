using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8.Praktice1
{
    /// <summary>
    /// zanadie 1
    /// </summary>
   /* class RangeOfArray
    {
        public int lowerBount;//переменная нижнего индекса 
        public int upperBount;//переменная верхнего индекса
        public int[] Arr;//массив чисел
        Random rand = new Random();//переменная для рандома
        public RangeOfArray (int upperIndex, int lowerIndex)//конструтор принимающий значения верхнего и нижнего индекса 
        {
            this.lowerBount = lowerIndex;
            this.upperBount = upperIndex;
            Arr = new int[Math.Abs(upperIndex - lowerIndex) + 1];
        }

        public int this[int index]
        {
            get
            {
                if (index < lowerBount || index > upperBount)
                {
                    throw new IndexOutOfRangeException("Индекс выходит за пределы диапазона");
                }

                return Arr[index - lowerBount];
            }
            set
            {
                if (index < lowerBount || index > upperBount)
                {
                    throw new IndexOutOfRangeException("Индекс выходит за пределы диапазона");
                }

                Arr[index - lowerBount] = value;
            }
        }

        public void Print(RangeOfArray mass, int lowerIndex)//функция вывода массива 
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i]=rand.Next(10);
                Console.WriteLine($"{i + lowerIndex} элемент массива равен = " + Arr[i]);
            }
        }
    }*/
    
    
    
    /// <summary>
    /// zanadie 2 
    /// </summary>
    /*
     public class Product
     {
         public double Price { get; set; }
         public string Name { get; set; }
         public string Category { get; set; }

     }
     public class SerivceProduct
     {
         List<Product> products = null;
         public SerivceProduct()
         {
             products = new List<Product>();
             products.Add(new Product() {Price=1000,Name="Mlk",Category="Milk" });
             products.Add(new Product() { Price = 300, Name = "Cucumber", Category = "Ovoshi" });
             products.Add(new Product() { Price = 2000, Name = "Turkey", Category = "Meat" });


         }
         public double this[string Category]
         {
             get
             {  
                 double sum = 0;

                 foreach (Product item in products.Where(w=>w.Category==Category))
                 {
                     sum += item.Price;
                 }
                 TimeSpan StartTime = new TimeSpan(8,0,0);
                 TimeSpan EndTime = new TimeSpan(9, 0, 0);
                 if(DateTime.Now.TimeOfDay>StartTime & DateTime.Now.TimeOfDay < EndTime)
                 {
                     return sum*0.95;
                 }
                 return sum;
             }
         }
     }
     */






    class Program
    {
        static void Main(string[] args)
        {
           /* 
            Console.WriteLine("Введите нижний индекс диапазона массива");
            int lowerIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите верхний индекс диапазона массива");
            int uperIndex = Convert.ToInt32(Console.ReadLine());
            RangeOfArray array = new RangeOfArray(lowerIndex, uperIndex);
            array.Print(array,lowerIndex);
           */
 /////////////////////////////////////////////////////////////////////////////////////
            /* SerivceProduct sproduct = new SerivceProduct();
             Console.WriteLine(sproduct["Milk"]);*/

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 






            Console.ReadKey();
        }
    }

}
