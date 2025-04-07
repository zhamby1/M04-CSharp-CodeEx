class AccountPrivate{

    // we are changing our access modifier to private
    //private means that anything outside of this class cannot access it, specifically with dot notation ( . )
    private string AccountName;
    private string AccountNumber;
    private double AccountBalance;

    //to access data, we create PUBLIC METHODS to grab and set data

    //as an intro to methods, lets talk about one method that will make our lives easier..a constructor
    //a constructor is a  special method/function that allows us to initialize our instances with data
    //ie instead of the dot notation, we can stick the data in the () when making a new account
    //to make a constructor method, use the class name, and declare the parameters/argument that match the data fields in the class

    //by making a method public, it will allow outside data to access and change data inside of the AccountPrivate class
    public AccountPrivate(string account_name, string account_number, double account_balance){
        AccountName = account_name;
        AccountNumber = account_number;
        AccountBalance = account_balance;

    }

    //in order to get our data we can use getters and setters
    //there is a "tradtional" way of doing this by making 2 methods for each data field
    //the more modern way allows us to summarize these with the get and set keyword

    //set and gets are just methods..the can be named whatever you want.. in this case i will use the lower case version of the field


    public string account_name{
        //get grabs data
        //you can say get then what you want get to do
        get {return AccountName;}
        //set - sets the data
        //we have set to set the data to whatever value you give to the account_balance method
        set {AccountName = value;}
    }

    public string account_number{
        //get grabs data
        //you can say get then what you want get to do
        get {return AccountNumber;}
        //set - sets the data
        //we have set to set the data to whatever value you give to the account_balance method
        set {AccountNumber = value;}
    }
    public double account_balance{
        //get grabs data
        //you can say get then what you want get to do
        get {return AccountBalance;}
        //set - sets the data
        //we have set to set the data to whatever value you give to the account_balance method
        set {AccountBalance = value;}
    }

    //besides getters and setters, we can have other methods or functions that deal with this class.
    //this is the power of classes, can we can also organize accounts by WHAT THEY DO.

    //all account can deposit money
    public void Deposit(double amount){
        AccountBalance = AccountBalance + amount;
    }

    public void Withdrawl (double amount){
        if(AccountBalance < amount){
            Console.WriteLine("You cannot withdrawl...too little funds");
        }
        else{
            AccountBalance = AccountBalance - amount;
        }
    }
    


}

