int myAge = 25;
//same data types as in C
Console.WriteLine("Hello World!");
//ends and goes to a new line
Console.Write("Hello World!");
//ends and stays in the same line

int x = 10;
double y = 20;
Console.WriteLine("x = {0}; y = {1}", x, y);
//x = 10 and y = 20 cuz they are predefined
//btst5dmha bs law hatktb hagten ganb ba3d

//to read input
yourName = Console.ReadLine();

Console.Writeline("Hello {0}", yourName);
//lel asf lazm tktb el {0} 3ashan el Hello tezhar


//Readline only takes string, to take other values:
int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are {0} years old", age);

//Convert.ToDouble and Convert.ToBoolean.
//Convert.ToInt16, Convert.ToInt32 and Convert.ToInt64

//another example
double n;
string x = "77";
n = Convert.ToDouble(x);

/*
multi 
line 
comment
*/

//here the var function determines the
//data type on its own

var temp = 14.55;
//and var values must be initialized with a 
//value, otherwise it will be error

const double PI = 3.14;
//the constant value cannot be changed

//operators the same as in C
int z = 10;
int w = 20;
Console.Writeline(z+w);


// x += 2 eq to x = x +2
// feh kaman x++ we ++x

//if statement
int x = 8;
int y = 3;

if (x > y)
{
    Console.WriteLine("x is greater than y");
}

// we bardo else if we else
//nafs el tare2a


//Switch case nafso bardo
switch (age)
{
    case 16:
        Console.WriteLine("Too young");
        break;
    case 42:
        Console.WriteLine("Adult");
        break;
    case 70:
        Console.WriteLine("Senior");
        break;
    default:
        Console.WriteLine("The default case");
        break;
}


//While loop
//the same bardo
//bs de feha e5tsar gdeed

int num = 0;
while (++num < 6)
    Console.WriteLine(num);

//for loop
//the same bardo
for (int x = 10; x < 15; x++)
{
    Console.WriteLine("Value of x: {0}", x);
}

//mmkn tfks le haga mnl for conditions
//ma3rfsh leeh bs shofha
int x = 10;
for (; x > 0; x -= 3)
{
    Console.WriteLine(x);
}

//another example
int x = 10;
for (; x > 0;)
{
    Console.WriteLine(x);
    x -= 3;
}

//5od balk mnl syntax wel ;

//do while bardo zayha
int a = 0;
do
{
    Console.WriteLine(a);
    a++;
} while (a < 5);

//fe continue and break statement bardo 


// ? operator
int age = 42;
string msg;
msg = (age >= 18) ? "Welcome" : "Sorry";
Console.WriteLine(msg);
//law el condition s7, ro7 le awl output,
//law 3'alt, roo7 lel tany

//garb t3mlha bel functions badl messages !!!!!!!!!!


//basic calculator
do
{
    Console.Write("x = ");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.Write("y = ");
    int y = Convert.ToInt32(Console.ReadLine());

    int sum = x + y;
    Console.WriteLine("Result: {0}", sum);
}
while (true);



//with exit statement to exit the program

do
{
    Console.Write("x = ");
    string str = Console.ReadLine();
    if (str == "exit")
        break;

    int x = Convert.ToInt32(str);

    Console.Write("y = ");
    int y = Convert.ToInt32(Console.ReadLine());

    int sum = x + y;
    Console.WriteLine("Result: {0}", sum);
}
while (true);


//functions:
//functions in C# Called Methods

int sqrt(int x){
    int result = x*x;
    return result;
}

//mmkn bel void kaman
static void func(){
    Console.Write("Hello");
}

//then call it by using func()
//aslo can be declared with multiple 
//parameters (int x , int y)

static int Vol(int x, int y = 3, int z = 1)
{
    return x * y * z;
}
static void Main(string[] args)
{
    Console.WriteLine(Vol(2, 4));
}

//will print 8 (taken by order)


static int Area(int h, int w)
{
    return h * w;
}
static void Main(string[] args)
{
    int res = Area(w: 5, h: 8);
    Console.WriteLine(res);
}

//will assign the values by order


//output by argument:
static void Test(int x)
{
    x = 8;
}
static void Main()
{
    int a = 5;
    Test(a);
    Console.WriteLine(a);
} //outputs 5


//output by refrence:
static void Sqr(ref int x)
{
    x = x * x;
}
static void Main(string[] args)
{
    int a = 3;
    Sqr(ref a);

    Console.WriteLine(a);
} //output 9


//output by output:
static void GetValues(out int x, out int y)
{
    x = 5;
    y = 42;
}
static void Main(string[] args)
{
    int a, b;
    GetValues(out a, out b);
    Console.WriteLine(a + " " + b);
}
//a = 5 , b = 42


//overloading = same method name, different parametes
//the method is called everytime using
//a different type of parameters
static void Print(int a)
{
    Console.WriteLine("Value: " + a);
}
static void Print(double a)
{
    Console.WriteLine("Value: " + a);
}
static void Print(string label, double a)
{
    Console.WriteLine(label + a);
}
static void Main(string[] args)
{
    Print(11);
    Print(4.13);
    Print("Average: ", 7.57);
}

//recursion:
//factorial:
static int Fact(int num)
{
    if (num == 1)
    {
        return 1;
    }
    return num * Fact(num - 1);
}
static void Main(string[] args)
{
    Console.WriteLine(Fact(6));
}

//classes:
//same concept as C

//to have several class copies, they are
//called objects

//C# stores values in a stack of memory 
//C# stores objects in heap

//Class Example:
class Person
{
    int age;
    string name;
    public void SayHi() //can be accesed outside the method cuz its declared public
    {
        Console.WriteLine("Hi");
    }
}

//class example with an object:

/*
class Person {
            int age;
            string name;
            public void SayHi() {
                Console.WriteLine("Hi");
            }
        }
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.SayHi();
        }

        */

//example 2


/*
class Dog
{
    public string name;
    public int age;
}
static void Main(string[] args)
{
    Dog bob = new Dog();
    bob.name = "Bobby";
    bob.age = 3;

    Console.WriteLine(bob.age);
}
*/

//Encapsulation we rabna yostor 

//C# supports the following access modifiers: public, private, 
//protected, internal, protected internal.
//ex:
class BankAccount
{
    private double balance = 0;
    public void Deposit(double n)
    {
        balance += n;
    }
    public void Withdraw(double n)
    {
        balance -= n;
    }
    public double GetBalance()
    {
        return balance;
    }
}
class Program
{
    static void Main(string[] args)
    {
        BankAccount b = new BankAccount();
        b.Deposite(199);
        b.Withdraw(42);
        Console.WriteLine(b.GetBalance());
    }
}


//////////////////Start of bala7////////////////

//constructors => bal77
//Ex:
/*
class Person
{
    private int age;
    private string name;
    public Person(string nm)
    {
        name = nm;
    }
    public string getName()
    {
        return name;
    }
}
static void Main(string[] args)
{
    Person p = new Person("David");
    Console.WriteLine(p.getName());
}

*/


//property tab3ha de bal7 bardo
//Ex:
class Person
{
    private string name; //field

    public string Name //property
    {
        get { return name; }
        set { name = value; }
    }
}

//Ex2:
/*
class Person
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}
static void Main(string[] args)
{
    Person p = new Person();
    p.Name = "Bob";
    Console.WriteLine(p.Name);
}
*/

//EX3:
/*
class Person
{
  private int age=0;
  public int Age
  {
    get { return age; }
    set {
      if (value > 0)
        age = value;
    }
  }
}
*/

//////////////////End of bala7////////////////


//Arrays:
/*
must be declared inside a scoop
int[ ] myArray = new int[5];
myArray[0] = 23;
*/

//ex2
/*
string[ ] names = new string[3] {"John", "Mary", "Jessica"};
double[ ] prices = new double[4] {3.6, 9.8, 6.4, 5.9};
*/

//ex3
/*
string[ ] names = new string[ ] {"John", "Mary", "Jessica"};
double[ ] prices = new double[ ] {3.6, 9.8, 6.4, 5.9};
*/

//ex4
/*
string[ ] names = {"John", "Mary", "Jessica"};
double[ ] prices = {3.6, 9.8, 6.4, 5.9};
*/

//to access an element
//Console.Writeline(b[2]);

//Arrays and loops
class Program
{
    static void Main(string[] args)
    {
        int[] a = new int[10];
        for (int k = 0; k < 10; k++)
        {
            a[k] = k * 2;
        }
        
        for (int k = 0; k< 10; k++){
            Console.WriteLine(a[k]);
        }
    }
}

//easier way for accesssing arrays:
//the foreach:

class Program{
    static void Main(string[] args){
        int [] k = new int[10];


        foreach(int k in a){ //de a7sn 
            Console.WriteLine(k);
            //5od balk en hena k bs
        }
    }
}

//mmkn tktb foreach(var k in a)
//btkoon var a7sn 3ashan keda el compiler howa
//ely bey7dd el variable type

//another example:
class Program{
    static void Main(string[] args){

        int[] arr = { 11, 35, 62, 555, 989 };
        int sum = 0;

        foreach (int x in arr)
        {
            sum += x;
        }
        Console.WriteLine(sum);
    }
}

//Multi dimenstional array:
class Program{
    static void Main(string[] args){


        //2 dimenstional array
        int [ , ] x = new int[3,4];

        int[,] someNums = { { 2, 3 }, { 5, 6 }, { 4, 6 } };
        // 3 rows, 2 colomns 

        //to print:
        for (int k = 0; k < 3; k++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(someNums[k, j] + " ");
            }
            Console.WriteLine();
        }

    }
}

//Jagged Arrays => Arrays of Arrays
class Program
{
    static void Main(string[] args)
    {

        int[][] jaggedArr = new int[][]
        //first [] after new int
        //is for how many arrays
        //second [] is for how many dimentions
        //for each array
       {
        new int[ ] {1,8,2,7,9},
        new int[ ] {2,4,6},
        new int[ ] {33,42} 
        };

        int [] arr = {2,4,7};
        Console.WriteLine(arr.Length);
        Console.WriteLine(arr.Rank);
        //rank => dimenstions
        Console.WriteLine(arr.Max());
        Console.WriteLine(arr.Min());
        Console.WriteLine(arr.Sum());

    }
}

//Strings with arrays:
//Example for everything within the arrays:
class Program
{
    static void Main(string[] args)
    {
        string a = "some text";
        Console.WriteLine(a.Length);
        //Outputs 9

        Console.WriteLine(a.IndexOf('t'));
        //Outputs 5

        a = a.Insert(0, "This is ");
        Console.WriteLine(a);
        //Outputs "This is some text"

        a = a.Replace("This is", "I am");
        Console.WriteLine(a);
        //Outputs "I am some text"

        if (a.Contains("some"))
            Console.WriteLine("found");
        //Outputs "found"

        a = a.Remove(4);
        Console.WriteLine(a);
        //Outputs "I am"

        a = a.Substring(2);
        Console.WriteLine(a);
        //Outputs "am"
    }
}

//Destructors 
//something that invoked automatically when
//an object is destroyed or deleted
//name of the destructor is the same as 
//the class with only tilde before it ~

/*
class Dog
{
    public Dog()
    {
        Console.WriteLine("Constructor");
    }
    ~Dog()
    {
        Console.WriteLine("Destructor");
    }
}
static void Main(string[] args)
{
    Dog d = new Dog();
}
*/

//Static:
//This makes those members belong to the class itself, 
//instead of belonging to individual objects
//bal7

/*
Math.PI the constant PI.
Math.E represents the natural logarithmic base e.
Math.Max() returns the larger of its two arguments.
Math.Min() returns the smaller of its two arguments.
Math.Abs() returns the absolute value of its argument.
Math.Sin() returns the sine of the specified angle.
Math.Cos() returns the cosine of the specified angle.
Math.Pow() returns a specified number raised to the specified power.
Math.Round() rounds the decimal number to its nearest integral value.
Math.Sqrt() returns the square root of a specified number.
*/

/*string s1 = "some text";
string s2 = "another text";

String.Concat(s1, s2); // combines the two strings

String.Equals(s1, s2); // returns false
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(DateTime.Now);
        Console.WriteLine(DateTime.Today);

        Console.WriteLine(DateTime.DaysInMonth(2016, 2));
    }
}

//indexer:
//mn esmha, el index mn el array
class program{
    static void Main(string[] args){

        string str = "Hello World";
        char x = str[4];
        Console.WriteLine(x);

    }
}

//example 3n ezzay te use get we set 
/*
class Box
{
    public int Height { get; set; }
    public int Width { get; set; }
    public Box(int h, int w)
    {
        Height = h;
        Width = w;
    }
}
static void Main(string[] args)
{
    Box b1 = new Box(14, 3);
    Box b2 = new Box(5, 7);
}
*/

//Classes again!!
//mnl a5r, haga tsht3'l ba3deen t2fl aw ttms7

/*
class Dog
{
    public Dog()
    {
        Console.WriteLine("Constructor");
    }
    ~Dog()
    {
        Console.WriteLine("Destructor");
    }
}
static void Main(string[] args)
{
    Dog d = new Dog();
    //enta hena bt3ml Dog() gdeda 3ashan tst5dmha
    tany ba3d el delete
}
*/


//static:
/*
No matter how many objects of the class are 
created, there is only one copy of the static 
member.
*/

//shoof fel example ely gai enk t5osh 3al count
//3ala tool mn 3'eer t7tag t7dd anhy object:

/*
class Program
    {
        class Cat {
            public static int count=0;
            public Cat() {
                count++;
            }
        }
        static void Main(string[] args)
        {
            Cat c1 = new Cat();
            Cat c2 = new Cat();
            Console.WriteLine(Cat.count);
        }
    }

*/

//static also applied to Methods "functions"
class Program
{
    class Dog
    {
        public static void Bark()
        {
            Console.WriteLine("Woof");
        }
    }
    static void Main(string[] args)
    {
        Dog.Bark();
    }
}

//constants are static by default 

//this
//delwa2ty law 3ankd static class we feha static
//objects, we use the 'this' keyword
//3ashan nrkz 3al object de bs
class Person
{
    private string name;
    public Person(string name)
    {
        this.name = name;
    }
}

//shof this tany mnl net

//readonly
/*enk t3rf haga marra wa7da we maynf3sh ba3den
enk t3dlha tany, btkoon bs read only
*/
class Person
{
    private readonly string name = "John";
    public Person(string name)
    {
        this.name = name;
    }
}

/*elfar2 maben el readonly wel constant, 
en el readonly mesh lazm ykon fe initial value
bs el constant lazm */

/*
readonly string name; // OK
const double PI; // Error
*/

//indexers => haga habla shewaya ka topic lewa7dha
/*
string str = "I know C#";
char x = str[3];
Console.WriteLine(x);
*/

//example bel get wel set bal7

class Clients
{
    private string[] names = new string[10];

    public string this[int index]
    {
        get
        {
            return names[index];
        }
        set
        {
            names[index] = value;
        }
    }
}
/*
            Clients c = new Clients();
            c[0] = "Dave";
            c[1] = "Bob";
            
            Console.WriteLine(c[1]);
*/
//prints Bob


//OverLoading

/*
class Box
{
    public int Height { get; set; }
    public int Width { get; set; }
    public Box(int h, int w)
    {
        Height = h;
        Width = w;
    }
}
static void Main(string[] args)
{
    Box b1 = new Box(14, 3);
    Box b2 = new Box(5, 7);
}
*/

//el overloading hena:

//Box b3 = b1 + b2;



//overloading operators:

/*

=> keyword 'Operator" followed by the actual operator

*/

public static Box operator+ (Box a, Box b) {
  int h = a.Height + b.Height;
  int w = a.Width + b.Width;
  Box res = new Box(h, w);
  return res;
}

//enta keda bt3ml box 3 bel 2 boxes el awlaneyen
//operator keyword Must be static
//check overloading opertaor file <=


//inheritance:
//to define a class on another class
//base class - derived class


//ex (check the syntax): 
class Animal
{
    public int Legs { get; set; }
    public int Age { get; set; }
}

class Dog : Animal
{
    public Dog()
    {
        Legs = 4;
    }
    public void Bark()
    {
        Console.Write("Woof");
    }
}

//base class => Animal
//derived class => Dog
//all public members of animals

//full example with an output:

/*
class Program
    {
        class Person {
            public void Speak() {
                Console.WriteLine("Hi there");
            }
        }
        class Student : Person {
            int number;
        }
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Speak();
        }
    }

    */

//Public - Protected

/*
class Program
    {
        class Person {
            protected int Age {get; set;}
            protected string Name {get; set;}
        }
        class Student : Person {
            public Student(string nm) {
                Name = nm;
            }
            public void Speak() {
                Console.Write("Name: "+Name);
            }
        }
        static void Main(string[] args)
        {
            Student s = new Student("David");
            s.Speak();
        }
    }
*/

//Public members may be accessed from anywhere 
//outside of the class, while access to private 
//members is limited to their class. 

/*
The protected access modifier is very similar 
to private with one difference; it can be 
accessed in the derived classes. So, 
a protected member is accessible only from 
derived classes.
*/

//Sealed:
//preventing other classes from inherting the
//sealed class

/*
sealed class Animal {
            //some code
        }
        class Dog : Animal { } //Error
        
        static void Main(string[] args)
        {
            
        }
        */

//for derived classes, if you wanna make 
//destructors, you have to create them seperately

class Animal
{
    public Animal()
    {
        Console.WriteLine("Animal created");
    }
    ~Animal()
    {
        Console.WriteLine("Animal deleted");
    }
}
class Dog : Animal
{
    public Dog()
    {
        Console.WriteLine("Dog created");
    }
    ~Dog()
    {
        Console.WriteLine("Dog deleted");
    }
}

//creating a dog object
/*
static void Main(string[] args)
        {
            Dog d = new Dog();
        }
        */



//Polymorphism => means having many forms
//magmo3a mn el classes kollohm inherited
//mn base class

//to declare a base polymorphism class:

class Shape
{
    public virtual void Draw()
    {
        Console.Write("Base Draw");
    }
}

//another example

class Circle : Shape
{
    public override void Draw()
    {
        // draw a circle...
        Console.WriteLine("Circle Draw");
    }
}
class Rectangle : Shape
{
    public override void Draw()
    {
        // draw a rectangle...
        Console.WriteLine("Rect Draw");
    }
}

//to overridden the class:

/*
static void Main(string[] args)
{
    Shape c = new Circle();
    c.Draw();

    Shape r = new Rectangle();
    r.Draw();
}
*/

//mnl a5r:
/*
polymorphism is a way to call the same method 
for different objects and generate different 
results based on the object type.
*/

//asbract classes:
//mesh fahm eh da bs mmkn en kol inherited class
//3andha its own set

/*
abstract class Shape {
            public abstract void Draw();
        }
        class Circle : Shape {
            public override void Draw() {
                Console.WriteLine("Circle Draw");
            }
        }
        class Rectangle : Shape {
            public override void Draw() {
                Console.WriteLine("Rect Draw");
            }
        }
        static void Main(string[] args)
        {
            Shape c = new Circle();
            c.Draw();
        }
        */


//interface:
//abstarct class with abstract members

public interface IShape
{
    void Draw();
}
//no need to use abstract in the scoop
//cuz all interface members are abstract by default

//interface can only contain methods and properties



//nested class:
class Car
{
    string name;
    public Car(string nm)
    {
        name = nm;
        Motor m = new Motor();
    }
    public class Motor
    {
        // some code
    }
}
//The Motor class is nested in the Car class



//Structs
//just like C
struct Book
{
    public string title;
    public double price;
    public string author;
}
/*
static void Main(string[] args)
        {
            Book b;
            b.title = "Test";
            b.price = 5.99;
            b.author = "David";
            
            Console.WriteLine(b.title);
        }
        */

// to create a new struct from an existing one
/*
struct Point
{
            public int x;
public int y;
public Point(int x, int y)
{
    this.x = x;
    this.y = y;
}
        }
        static void Main(string[] args)
{
    Point p = new Point(10, 15);
    Console.WriteLine(p.x);
}
*/

//classes => more complex
//structs => less complex

//Enum
//enumeration => array with numbers

//ex

/*
enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
static void Main(string[] args)
{
    int x = (int)Days.Tue;
    Console.WriteLine(x);
}
*/

//enum with switch case example:
/*
enum TrafficLights { Green, Red, Yellow };
        static void Main(string[] args)
        {
            TrafficLights x = TrafficLights.Red;
            switch (x) {
                case TrafficLights.Green:
                    Console.WriteLine("Go!");
                    break;
                case TrafficLights.Red:
                    Console.WriteLine("Stop!");
                    break;
                case TrafficLights.Yellow:
                    Console.WriteLine("Caution!");
                    break;
            }
        }
*/

//when error occured, an exception will be raised

//to handle exceptions:
/*
try {
                int[] arr = new int[] { 4, 5, 8 };
                Console.Write(arr[8]);
            }
            catch(Exception e) {
                Console.WriteLine("An error occurred");
            }
*/

//the code that might generate an exception
//we use 'try' with it
//if an exception occurs, the 'catch' block will
//be excuted

//General exception message to handle everything
//mnl a5r
/*
try {
                int[] arr = new int[] { 4, 5, 8 };
                Console.Write(arr[8]);
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
            }
*/

//multiple exceptions:
/*
int x, y;
try
{
    x = Convert.ToInt32(Console.Read());
    y = Convert.ToInt32(Console.Read());
    Console.WriteLine(x / y);
}
catch (DivideByZeroException e)
{
    Console.WriteLine("Cannot divide by 0");
}
catch (Exception e)
{
    Console.WriteLine("An error occurred");
}
*/

//another exception:
//to inter integer if declared so, float if declared
//so, and so on

/*
Catch(FormatException){
    Console.WriteLine("Please inter the right format");
}
*/


//Finally keyword (conclusion):
/*
static void Main(string[] args)
        {
            int result=0;
            int num1 = 8;
            int num2 = 4;
            try {
                result = num1 / num2;
            }
            catch (DivideByZeroException e) {
                Console.WriteLine("Error");
            }
            finally {
                Console.WriteLine(result);
            }
        }
*/


////////Files////////

namespace System.IO
{
    class Program
    {
        string str = "Some text";
        //File.WriteAllText("text.txt", str);


//The WriteAllText() method creates a 
//file with the specified path and writes the 
//content to it. If the file already exists, 
//it is overwritten. 

    }
}

//to Read:
/*
static void Main(string[] args)
        {
            string str = "Some text";
            File.WriteAllText("test.txt", str);
            
            string txt = File.ReadAllText("test.txt");
            Console.WriteLine(txt); 
        }

*/


/*
AppendAllText() - appends text to the end of the file.
Create() - creates a file in the specified location.
Delete() - deletes the specified file.
Exists() - determines whether the specified file exists.
Copy() - copies a file to a new location.
Move() - moves a specified file to a new location
*/


//Generics:
//Generics allow the reuse of code across 
//different types.

//ex:
/*
static void Swap(ref int a, ref int b) {
  int temp = a;
  a = b;
  b = temp;
}

static void Swap<T>(ref T a, ref T b) {
  T temp = a;
  a = b;
  b = temp;
}
*/

//In the code above, T is the name of our 
//generic type. We can name it anything we want, 
//but T is a commonly used name


//full example:

/*
static void Swap<T>(ref T a, ref T b) {
            T temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int a = 4, b = 9;
            Swap<int>(ref a, ref b);
            Console.WriteLine(a+" "+b);
            
            string x = "Hello";
            string y = "World";
            Swap<string>(ref x, ref y);
            Console.WriteLine(x+" "+y);
        }
*/

//Generic Classes:
class Stack<T>
{
    int index = 0;
    T[] innerArray = new T[100];
    public void Push(T item)
    {
        innerArray[index++] = item;
    }
    public T Pop()
    {
        return innerArray[--index];
    }
    public T Get(int k) { return innerArray[k]; }
}

//stack usualy called LIFO
//now we can create objects of our generic class
/*
Stack<int> intStack = new Stack<int>();
Stack<string> strStack = new Stack<string>();
Stack<Person> PersonStack = new Stack<Person>();
*/

//Collections
//=> group of related objects
//Collections are dynamic, not like arrays
//its size can grow and shrink

//   List<int> li = new List<int>();

//generic collections:
// => using Systems.Collections.Generic;

/*
- List<T>
- Dictionary<TKey, TValue>
- SortedList<TKey, TValue>
- Stack<T>
- Queue<T>
- Hashset<T>
*/


//non generic collections
// => using System.Collections

/*
- ArrayList
- SortedList
- Stack
- Queue
- Hashtable
- BitArray 
*/




//example on List:

/*
List<int> li = new List<int>();
li.Add(59);
li.Add(72);
li.Add(95);
li.Add(5);
li.Add(9);
li.RemoveAt(1); // remove 72

Console.Write("\nList: ");
for (int x = 0; x < li.Count; x++)
    Console.Write(li[x] + " "); // 59  95  5  9
li.Sort();
Console.Write("\nSorted: ");
for (int x = 0; x < li.Count; x++)
    Console.Write(li[x] + " "); // 5  9  59  95
*/

// other 'List' Properties

/*
Capacity - A property that gets the number of elements the list can hold before needing to be resized.

Clear() - Removes all the elements from the list.

TrimExcess() - Sets the capacity to the actual number of elements in the list. This is useful when trying to reduce memory overhead.

AddRange(IEnumerable coll) - Adds the elements of collection coll with elements of the same type as List<T> to the end of the list. IEnumerable is the collections interface that supports simple iteration over the collection.

Insert(int i, T t) - Inserts an element t at a specific index i in the list.

InsertRange(int i, IEnumerable coll) - Inserts the elements of a collection coll at a specified index i in the list. IEnumerable is the collections interface that supports simple iteration over the collection.

Remove(T t) - Removes the first occurrence of the object t from the list.

RemoveRange(int i, int count) - Removes a specified number of elements count from the list starting at a specified index i.

Contains(T t) - Returns true if the specified element t is present in the list.

IndexOf(T t) - Returns the index of the first occurrence of the element t in the list.

Reverse() - Reverses the order of the elements in the list.

ToArray() - Copies the elements of the list into a new array.
*/




//Sorted List:

/*
SortedList<K, V>


A sorted list is a collection of key/value pairs that are sorted by key. A key can be used to access its corresponding value in the sorted list.

The C# generic collection SortedList<K, V> class requires all element key/value pairs to be of the same type K, V. Duplicate keys are not permitted, which ensures that every key/value pair is unique.

SortedList<K, V> properties include:
Count - Gets the number of key/value pairs contained in the sorted list.
Item[K key] - Gets or sets the value associated the specified key contained in the sorted list. Item is the indexer and is not required when accessing an element. You only need to use the brackets [] and the key, value.
Keys - Gets a sorted and indexed collection containing only the keys in the sorted list.

SortedList<K, V> methods include:
Add(K key, V value) - Adds an element with a specific key, value pair into the sorted list.
Remove(K key) - Removes the element with the specific key, value pair associated with the specified key from the sorted list.

Values - Gets a sorted and indexed collection of the values in the sorted list.
Clear() - Removes all the elements from the sorted list.
ContainsKey(K key) - Returns true when the specified key is present in the sorted list.
ContainsValue(V value) - Returns true when a specified value is present in the sorted list.
IndexOfKey(K key) - Returns the index of the specified key within the sorted list.
IndexOfValue(V value) - Returns the index of the specified value within the sorted list.



*/

//ex:
/*
SortedList<string, int> sl = new SortedList<string, int>();

sl.Add("Solo", 59);
sl.Add("A", 95);
sl.Add("Learn", 72);
sl.Remove("A");

Console.WriteLine("Sorted List: ");
foreach (string s in sl.Keys)
    Console.WriteLine(s + ": " + sl[s]);  // Learn: 72  Solo: 59
Console.WriteLine("\nCount: " + sl.Count);  // 2
*/



//Bit Arrays:
//Array of 0's and 1' only

//properties:
/*
BitArray properties include:
Count - Gets the number of bits in the bit array.
IsReadOnly - Gets a value indicating if the bit array is read only or not.

BitArray methods include:
Get(int i) - Gets the value of the bit at a specified position i in the bit array.
Set(int i, bool value) - Sets the bit at a specified position i to a specified value in the bit array.
SetAll(bool value) - Sets all the bits to a specified value in the bit array.
And(BitArray ba) - Performs the bitwise AND operation on the elements of the bit array object with a specified bit array ba.
Or(BitArray ba) - Performs the bitwise OR operation on the elements of the bit array and the specified bit array ba.
Not() - Inverts the bit values of the bit array.
Xor(BitArray ba) - Performs the bitwise XOR operation on the elements of the current bit array object and the elements in the specified bit array ba.
*/


//ex:
/*
// Printing BitArray
        public static void PrintBarr(string name, BitArray ba)
        {
            Console.Write(name + " : ");
            for (int x = 0; x < ba.Length; x++)
                Console.Write(ba.Get(x) + " ");
            Console.WriteLine();
        }
        
        public static void Main(string[] args)
        {
            BitArray ba1 = new BitArray(4);
            BitArray ba2 = new BitArray(4);
            
            ba1.SetAll(true);
            ba2.SetAll(false);
            
            ba1.Set(2, false);
            ba2.Set(3, true);
            
            PrintBarr("ba1", ba1);
            PrintBarr("ba2", ba2);
            Console.WriteLine();
            
            PrintBarr("ba1 AND ba2", ba1.And(ba2));
            PrintBarr("    NOT ba2", ba2.Not());
*/



//Stacks:        LIFO
//Properties:
/*
Stack<T> properties include:
Count - Returns the number of elements in the stack.

Stack<T> methods include:
Peek() - Returns the element at the top of the stack without removing it.
Pop() - Returns the element at the top of the stack and removes it from the stack.
Push(T t) - Inserts an element t at the top of the stack.
Clear() - Removes all the elements from the stack.
Contains(T t) - Returns true when the element t is present in the stack.
ToArray() - Copies the stack into a new array.
*/

//ex:
/*
Stack<int> s = new Stack<int>();
            
		    s.Push(59);
		    s.Push(72);
		    s.Push(65);

		    Console.Write("Stack: ");
		    foreach (int i in s)
		        Console.Write(i + " ");  // 65  72  59
		    Console.Write("\nCount: " + s.Count);  // 3
            
		    Console.Write("\nTop: " + s.Peek());  // 65
		    Console.Write("\nPop: " + s.Pop());  // 65
            
		    Console.Write("\nStack: ");
		    foreach (int i in s)
		        Console.Write(i + " ");  // 72  59
		    Console.Write("\nCount: " + s.Count);  // 2
*/





//Queue:        FIFO
//properties;
/*
Count - Gets the number of elements in the queue.

And methods include:
Dequeue() - Returns the object at the beginning of the queue and also removes it.
Enqueue(T t) -Adds the object t to the end of the queue.
Clear() - Removes all objects from the queue.
Contains(T t) - Returns true when the element t is present in the queue.
Peek() - Returns the object at the beginning of the queue without removing it.
ToArray() - Copies the queue into a new array.
*/

//Ex:
/*
Queue<int> q = new Queue<int>();
            
            q.Enqueue(5);
            q.Enqueue(10);
            q.Enqueue(15);
            Console.Write("Queue: ");
            foreach (int i in q)
                Console.Write(i + " ");  // 5  10  15
            Console.Write("\nCount: " + q.Count);  // 3
            
            Console.Write("\nDequeue: " + q.Dequeue()); // 5
            
            Console.Write("\nQueue: ");
            foreach (int i in q)
                Console.Write(i + " ");  // 10  15
            Console.Write("\nCount: " + q.Count);  // 2
*/





//Dictionaries:
//properties:
/*
Count - Gets the number of key/value pairs contained in the dictionary.
Item[K key] - Gets the value associated with the specified key in the dictionary. Item is the indexer and is not required when accessing an element. You only need to use the brackets [] and key value.
Keys - Gets an indexed collection containing only the keys contained in the dictionary.

Dictionary<K, V> methods include:
Add(K key, V value) - Adds the key, value pair to the dictionary.
Remove(K key) - Removes the key/value pair related to the specified key from the dictionary.
Values - Gets an indexed collection containing only the values in the dictionary.
Clear() - Removes all the key/value pairs from the dictionary.
ContainsKey(K key) - Returns true if the specified key is present in the dictionary.
ContainsValue(V value) - Returns true if the specified value is present in the dictionary.
*/


//Ex:
/*
Dictionary<string, int> d = new Dictionary<string, int>();
            d.Add("Uno", 1);
            d.Add("One", 1);
            d.Add("Dos", 2);
            d.Add("Deux", 2);
            d.Remove("One");  // Remove key-value pair One, 1
            d.Remove("Dos");  // Remove key-value pair Dos, 2
            
            Console.WriteLine("Dictionary: ");
            foreach (string s in d.Keys)
                Console.WriteLine(s + ": " + d[s]);  // Uno: 1  Deux: 2
            Console.WriteLine("\nCount: {0}", d.Count); // 2 
*/




//Hashset
//is a set of unique values where duplicates 
//are not allowed.
//Properties:
/*
Count Returns the number of values in the hash set.
And methods include:
Add(T t) Adds a value (t) to the hash set.
IsSubsetOf(ICollection c) Returns true if the hash set is a subset of the specified collection (c).
Remove(T t) Removes the value (t) from the hash set.
Clear() Removes all the elements form the hash set.
Contains(T t) Returns true when a value (t) is present in the hash set.
ToString() Creates a string from the hash set.
IsSupersetOf(ICollection c) Returns true if the hash set is a superset of the specified collection.
UnionWith(ICollection c) Applies set union operation on the hash set and the specified collection (c).
IntersectWith(ICollection c) Applies set intersection operation on the hash set and the specified collection (c).
ExceptWith(ICollection c) Applies set difference operation on the hash set and the specified collection (c).
*/

//Ex:
/*
HashSet<int> hs = new HashSet<int>();
            
            hs.Add(5);
            hs.Add(10);
            hs.Add(15);
            hs.Add(20);
            Console.Write("\nHashSet: ");
            foreach (int i in hs)
                Console.Write(i + " ");  // 5  10  15  20  *elements may be in any order
            Console.Write("\nCount: " + hs.Count);  // 4
            
            HashSet<int> hs2 = new HashSet<int>();
            hs2.Add(15);
            hs2.Add(20);
            Console.Write("\n{15, 20} is a subset of {5, 10, 15, 20}: " + hs2.IsSubsetOf(hs)); // True 
*/




