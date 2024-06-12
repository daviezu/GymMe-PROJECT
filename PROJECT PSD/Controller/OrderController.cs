using PROJECT_PSD.Handler;
using PROJECT_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_PSD.Controller
{
    public class OrderController
    {
        public static List<MsCart> GetCartItemsByUserId(int userId)
        {
            return OrderHandler.GetCartByUserID(userId);
        }

        public static void ClearCart(int userId)
        {
            OrderHandler.ClearCart(userId);
        }

        public static void CheckoutCart(int userId)
        {
            OrderHandler.CheckoutCart(userId);
        }
    }
}