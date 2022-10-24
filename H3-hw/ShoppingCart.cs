using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_homework
{
    internal class ShoppingCart
    {
        //CartItem tipinde liste oluşturuldu.
        
        private List<CartItem> cartList;
        
        //Liste başlatıldı
        public ShoppingCart()
        {
            cartList = new List<CartItem>();
        }

        //Oluşturulan CartItem ları listeye ekleme.
        public void Add(CartItem item)
        {
            cartList.Add(item);
        }

        // Read
        public CartItem ReadCartItem(int id)
        {
            return cartList[id];
        }

        // Delete
        public CartItem DeleteCartItem(int id)
        {
            var std = ReadCartItem(id);
            cartList.RemoveAt(id);
            return std;
        }

        //Liste Dön
        public void GetList()
        {
            foreach (var item in cartList)
                Console.WriteLine(item.ToString());
        }

        public string GetBalance()
        {
            float price = 0;
            foreach (var item in cartList)
            {
                price +=(item.Product.ProductPrice * item.Quantity);
            }
            return ($"Toplam: {price} ");

        }



    }
}
