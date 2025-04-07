using System;
using System.Runtime.InteropServices;
using System.Security.Authentication;

//because we are using multiple classses, we have to give our program an entry point.
//in other words, we have to create a main method, so that c# knows where to start the program

//name of file or class and then add main method
class Program{
    //create the main method where we can call other classes into it

    //this is template code basically for c# main method
    public static void Main(string[] args){

        //in the main method we can call or use the class above
        //we call copy or spawning a class into another variable an instance
        AccountPrivate zach = new AccountPrivate("Zach Account","16741320",1000.00);
        AccountPrivate tim = new AccountPrivate("Tim Account","1665461",100.00);

        zach.account_balance = 1500.00;
        Console.WriteLine(zach.account_balance);

        tim.account_number = "150354630";
        Console.WriteLine(tim.account_number);

        zach.Deposit(500);
        Console.WriteLine(zach.account_balance);

        zach.Withdrawl(1000);
        Console.WriteLine(zach.account_balance);

        MyMath.add(7,4);
        MyMath.multiply(10,2);
        MyMath.area_square(20);



   
        





    }
}
