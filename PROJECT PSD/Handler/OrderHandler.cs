using PROJECT_PSD.Models;
using PROJECT_PSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_PSD.Handler
{
    public class OrderHandler
    {
        public static List<MsCart> GetCartByUserID(int userID)
        {
            return CartRepository.GetCartByUserID(userID);
        }

        public static void ClearCart(int userID)
        {
            CartRepository.ClearCart(userID);    
        }

        public static void CheckoutCart(int userID)
        {
            using (var db = new LocalDatabaseEntities())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        // Retrieve cart items
                        var cartItems = GetCartByUserID(userID);

                        if (cartItems.Count == 0)
                        {
                            throw new Exception("Your cart is empty.");
                        }

                        //// Create order header
                        //var order = new Order
                        //{
                        //    UserId = userId,
                        //    OrderDate = DateTime.Now,
                        //    Status = "Unhandled"
                        //};

                        //CartRepository.AddOrder(order);

                        //// Add order details
                        //var orderDetails = cartItems.Select(cartItem => new OrderDetail
                        //{
                        //    OrderId = order.OrderId,
                        //    SupplementId = cartItem.SupplementId,
                        //    Quantity = cartItem.Quantity,
                        //    Price = cartItem.Supplement.Price
                        //}).ToList();

                        //CartRepository.AddOrderDetails(orderDetails);

                        // Clear cart
                        ClearCart(userID);

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Checkout failed: " + ex.Message);
                    }
                }
            }
        }
    }
}