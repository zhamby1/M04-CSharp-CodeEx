//static methods do not need an instance to run
//the work similarly to have pure functions in other languages
//they are just organized into classes

//the cool thing about static classes is that you can organize multiple functions/methods inside of one class name

//where is this useful...lets give an example.
//I want to create a MyMath class that just has a list of multiple math methods or formulas.
//I dont need any data or instance for this class...I just want to run the calculation when given parameters
class MyMath{

    public static void add(int x, int y){
        int sum = x + y;
        Console.WriteLine(sum);
    }

    public static void multiply(int x, int y){
        int product = x * y;
        Console.WriteLine(product);
    }

    public static void area_square(double side){
        double area = side * side;
        Console.WriteLine(area);
    }



}
