

using System;

namespace ConstructorEx
{
    public class Fruit
    {
        public string color;
        public string name;
        public int quantity;
        public int price;

        public Fruit(string fruitColor, string fruitName) //constructor
        {
            color = fruitColor;
            name = fruitName;
        }
        public Fruit(int fruitquantity,int fruitprice) 
        {
            quantity = fruitquantity;
            price= fruitprice;
        }
        public void DisplayName()
        {
            Console.WriteLine(name);
        }
        public void DisplayPrice()
        {
            Console.WriteLine(price);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fruit apple = new Fruit("Red", "Apple");
            apple.DisplayName();
            Fruit apple = new Fruit("5", "50");
            apple.DisplayPrice();

        }
    }
}