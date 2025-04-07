// using System;
// using System.Runtime.InteropServices;
// using System.Security.Authentication;
// using System.Collections;

// //because we are using multiple classses, we have to give our program an entry point.
// //in other words, we have to create a main method, so that c# knows where to start the program

// //name of file or class and then add main method
// class Program{
//     //create the main method where we can call other classes into it

//     //this is template code basically for c# main method
//     public static void Main(string[] args){

//         //so if we want to store multiple items..it is usually good just to stick them in a list vs an array
//         List<AccountPrivate> bank_accounts = new List<AccountPrivate>();

//         //in the main method we can call or use the class above
//         //we call copy or spawning a class into another variable an instance
//         AccountPrivate zach = new AccountPrivate("Zach Account","16741320",1000.00);
//         AccountPrivate tim = new AccountPrivate("Tim Account","1665461",100.00);

//         //added to the list

//         bank_accounts.Add(zach);
//         bank_accounts.Add(tim);

//         //maybe we want to ask the user for some accounts to be added to the list
//         Console.WriteLine("Give me the number of accounts you wish to add");
//         int number_of_accounts = int.Parse(Console.ReadLine());

//         for(int i = 0; i < number_of_accounts; i++){

//             Console.WriteLine("Give me the name");
//             string name = Console.ReadLine();

//             Console.WriteLine("Give me the account number");
//             string ac_number = Console.ReadLine();

//             Console.WriteLine("Give me the account balance");
//             double ac_balance = double.Parse(Console.ReadLine());



//             bank_accounts.Add(new AccountPrivate(name,ac_number,ac_balance));

//         }

//         //display our list items
//         //foreach - make sure to call the get/sets to grab data..cannot grab it directly
//         foreach(var account in bank_accounts){
//             Console.WriteLine(account.account_name);
//             Console.WriteLine(account.account_number);
//             Console.WriteLine(account.account_balance);


//         }






   
        





//     }
// }
