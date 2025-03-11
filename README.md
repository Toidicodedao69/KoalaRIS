# KoalaRIS

# Introduction

KoalaRIS is a web-based information system developed to assist the scaling operations of an expanding restaurant called Koala. The web application offer the following features:

+ [Authentication/Authorisation](#authenticationauthorisation)
+ [Ordering](#order)
+ [Checkout](#checkout)
+ [Admin Dashboard](#admin-dashboard)

# Features
## Authentication/Authorisation
There are 2 user roles:

+ <b>Customer</b>: Can view menu and make order 
+ <b>Admin</b>: Have admin portal to view current/past orders, reservations, and some statistics 

User must sign in with registered username to access the features 

<image src="readme-resources/login.png" alt="login page">
<p align="center"><i>Login Page</i></p>

## Order
Customers can select items from menu and addd to cart. The cart will display all added items with total price.

<image src="readme-resources/order.png" alt="order page">
<p align="center"><i>Order Page</i></p>

## Checkout
To proceed, customers can checkout the order by filling in their personal details and card payment.

<image src="readme-resources/checkout.png" alt="checkout page">
<p align="center"><i>Checkout Page</i></p><br>

If payment is successful, customer will be directed to a confirmation page. This page will show the order ID and status of order.

<image src="readme-resources/confirmation.png" alt="confirmation page">
<p align="center"><i>Confirmation Page</i></p>

## Admin Dashboard
The admin dashboard allow admin users to easily naviagte and manage orders and reservations. The main page shows current orders with statistics of current date's total orders and best selling items.

<image src="readme-resources/admindashboard-main.png" alt="admin main page">
<p align="center"><i>Admin Main Page</i></p><br>

Admin can view orders history. Clicking on an order will show its details.

<image src="readme-resources/admin-order.png" alt="admin order page">
<p align="center"><i>Admin Order History Page</i></p><br>

Admin can also view reservations. Similar to order page, clicking on a reservation will show its details 

<image src="readme-resources/admin-booking.png" alt="admin booking page">
<p align="center"><i>Admin Reservation Page</i></p>


