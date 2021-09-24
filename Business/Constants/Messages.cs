using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
  public static  class Messages
    {

        public static string CarAdded = "Car added";
        public static string CarNameInvalid = "Car invalid";
        public static string CarDeleted = "Car deleted";
        public static string CarIsNotDeleted = "Car is not deleted!";
        public static string CarUpdated = "Car updated";
        public static string CarIsNotUpdated = "Car is not updated!";
        public static string CarsListed = "Cars  listed";
        public static string CarListed = "Car  listed";
        public static string CarsDetailsListed = "Carsdetails listed";
        public static string MaintenanceTime = "System is under maintenance";
      
        public static string CustomerAdded = "Customer added";
        public static string CustomerDeleted = "Customer deleted";
        public static string CustomerUpdated = "Customer updated";
        public static string RentalAddedFailed = "The operation failed because the car was not delivered";
        public static string RentalAdded = "Car rental added";
        public static string RentalDeleted = "Car rental deleted";
        public static string RentalUpdated = "Car rental updated";
        public static string RentalsListed = "Car rentals listed";
        public static string RentalListed = "Car rental  listed";
        public static string CustomersListed = "Customers are listed";
        public static string CustomerListed = "Customer listed";
        public static string UserAdded = "User added";
        public static string UserDeleted = "User deleted";
        public static string UserUpdated = "User updated";
        public static string UsersListed = "Users listed";
        public static string UserListed = "User listed";
        public static string RentalDetailDtoListed = "RentalDetails Listed";
        public static string CarImageAdded= "CarImage added";
        public static string CarImageDeleted= "CarImage deleted";
        public static string CarImageUpdated= "CarImage updated";
        public static string AccessTokenCreated="AccessToken Created";

        public static string UserNotFound = "UserNotFound";
        public static string PasswordError="Wrong Password";
        public static string SuccessfullLogin="Sucessfull Login";
        public static string UserRegistered="User registered succesfully";
        public static string UserAlreadyExist="User Already Exist";
        public static string AuthorizationDenied="Authorization Denied";
        public static string CarNameAlreadyExist="Carname already exist";
        public static string CarCountOfBrandError="Carcount of brand error";
    }
}
