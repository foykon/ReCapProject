using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Car's been added !";
        public static string CarNameInvalid = "Car Name is invalid !";
        public static string CarDeleted = "Car's been deleted !";
        public static string CarsListed = "Cars've been listed !";
        public static string CarUpdated = "Car's been updated !";

        public static string UsersListed = "Users've been listed";
        public static string UserAdded = "User's been added";
        public static string UserDeleted = "User's been deleted";
        public static string UserUpdated = "User's been updated";

        public static string CustomerUpdated = "Customer's been updated";
        public static string CustomerAdded = "Customer's been added";
        public static string CustomerDeleted = "Customer's been deleted";
        public static string CustomerListed = "Customers've been listed";

        public static string RentalAdded = "Rental's been added";
        public static string RentalDeleted = "Rental's been deleted";
        public static string RentalUpdated = "Rental's been updated";
        public static string RentalListed = "Rentals've been listed";
        public static string RentalIsNotAdded = "Car cannot rental because of it is not returned";
    }
}
