using BlazorEcommerce.Data.Models;

namespace BlazorEcommerce.Utilities
{
    public static class RoleConstant
    {
        public static string Admin = "Admin";
        public static string Customer = "Customer";

        public static List<OrderDetail> ConvertShoppingCartListToOrderDetail(List<ShoppingCart> shoppingCarts)
        {
            List<OrderDetail> orderDetails = new List<OrderDetail>();

            foreach (var cart in shoppingCarts)
            {
                OrderDetail orderDetail = new OrderDetail
                {
                    ProductId = cart.ProductId,
                    Count = cart.Count,
                    Price = Convert.ToDouble(cart.Product.Price),
                    ProductName = cart.Product.Name
                };
                orderDetails.Add(orderDetail);
            }

            return orderDetails;
        }
    }

    public static class ProcessingStatus
    {
        public static string Pending = "Pending";
        public static string Approved = "Approved";
        public static string ReadyForPickUp = "ReadyForPickUp";
        public static string Completed = "Completed";
        public static string Cancelled = "Cancelled";
    }
}

