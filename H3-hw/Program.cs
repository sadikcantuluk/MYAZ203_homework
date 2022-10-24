using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var product=new Product() { ProductId=1,ProductName="S10",ProductPrice=4500};
            var product1 = new Product() { ProductId = 2, ProductName = "S20", ProductPrice = 5890 };
            var product2 = new Product() { ProductId = 3, ProductName = "S30", ProductPrice = 7800 };

            var cartItem = new CartItem() { CartId=1,Product= product,Quantity=10};
            var cartItem2= new CartItem() { CartId = 2, Product = product1, Quantity = 5 };
            var cartItem3= new CartItem() { CartId = 3, Product = product2, Quantity = 3 };

            var shoppingCart = new ShoppingCart();

            shoppingCart.Add(cartItem);
            shoppingCart.Add(cartItem2);
            shoppingCart.Add(cartItem3);

            shoppingCart.DeleteCartItem(2);

            shoppingCart.GetList();

            Console.WriteLine(shoppingCart.GetBalance());

            


            Console.ReadLine();

        }
    }
}
