﻿using Application.Entities.Auth;
using Application.Entities.Ordering;
using Application.ValueObjects;

namespace Application.Abstractions.Services
{
    public interface IOrderServices
    {
        // return a list of all Orders from the database for an Account
        public List<Order> GetAllOrders(Account account);
        
        // create a new order, add it to the database. Return the Order Guid for confirmation.
        public Guid CreateOrder(Guid cartId, string email);

        // get the PaymentDetail from an order id
        public PaymentDetail GetReceipt(Guid orderId);
    }
}
