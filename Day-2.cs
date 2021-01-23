using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using BCrypt.Net;

namespace SanthoshDemos
{


    public class Store
    {

        public int TotalCartItems { get; set; }

        public List<String> Cart = new List<string>();

        public float TotalAmount { get; set; }
        
        //this will come db
        public Dictionary<String, double> Products = new Dictionary<string, double>() { { "Laptop", 799.99}, {"Phone",399.99 } };


        public void PrintAvailableItems()
        {
            Console.WriteLine("Welcome To Santhosh Store \nList of Products \n -- please select a product");

            foreach (var item in Products)
            {
                Console.WriteLine("{0} {1}",item.Key, item.Value);

            }
        }


        public void AddToCart(string item)
        {
            //Console.WriteLine(item);
            
            // use try catch
            Cart.Add(item);

            TotalAmount += (float) Products[item];

            TotalCartItems += 1;


        }

        public void PrintCardItems()
        {

            foreach (var item in Cart)
            {

            Console.WriteLine("{0} {1}", item, Products[item]);
            }

        }


    }



    public class Program
    {

        public static void Main(string[] args)
        {

            Store newStore = new Store();

            //show all the available products
            newStore.PrintAvailableItems();

            while (true)
            {
                //get the input of the customer
                string userInput = Console.ReadLine();

                //check for user input
                if (userInput == "checkout")
                {

                    newStore.PrintCardItems();


                    Console.WriteLine("Total Amount - {0} \nThanks and come again!!!", newStore.TotalAmount);

                    break;
                }
                else
                {

                    newStore.AddToCart(userInput);

                }

                //Console.WriteLine("Cart Items \n {0} Total Amount {1}",newStore.Cart, newStore.TotalAmount);

            }

            //will have to print the cart and total amount

        }
    }  
}
