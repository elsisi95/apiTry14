var myVar = 25

print("Hello World)")
print("the value is \(myVar)")

myVar == 30?; print("false");print("true") //bts2l so2al fel awl, law s7
//haytb3 awl print, law 3'alt haytb3 tany print
//Mesh Sha3'ala

var myVar2: int?=404 //hal ely fel variable da beysawy ely mowgood ?
myVar2 = nil

var myVar1: String? //does this variable contain a string 
//if its not true, then the variable will be automatically set to nil

//swift define the variable based on what you write 
//in it, if you want to declare something by your self
let album: String = "Ahmed"
let age: Int = 25
let condition: Bool = true


//example of how to create an array:
let john = "John Lenon"
let chris = "Cristiano"
let ahmed = "Ahmed E."
let omar = "Omar E."
let team = [john, chris, ahmed, omar]

print(team[1])

//sets are like arrays, but they have no order 
//in thier elements, and all elements are unique
//so no 2 identical elements
//creating a set of an array:
let colors = Set(["red", "green", "blue"])

//tuples:
//like arrays but cannot change anything
//inside it
var fullName = (first: "Ahmed", Last: "Elsisi")
print(fullName.1)
print(fullName.first)

//////////////////////////////////////////////////////
//very important: different between sets - tuples- arrays
//fixed collection and items => sets
//if you need just to store unique &  unarranged items
// use Sets
//well arrays lamma tkoon ay values bs arranged
//////////////////////////////////////////////////////

//dictionaries
//=> zay el arrays bs mmkn enk te acces el info be ay tare2a

let weights = [ 
    "Ahmed": 77,
    "Yousif": 45
]
print(weights["ahmed"])
//a lot of code in the dictionary is not valid

//create an empty collection we neray7 nafsna
var teams = [String:String]()
teams["Paul"] = "Red"

//switch - if - while -
//isnted of do-while, we have repeat-while

//new for type
for index in 1,2,3,4,5{
    print("\(index) times 5 is \(index*5)")
}

//mesh sha3'ala

/////////Control Transfer///////////

//to alter the code exceution by transferring control from one piece
//of the code to another 

//types: continue - break - fallthrough - return


//strings btt3rf bel let will var

//declare an empty string:
var emptyString = ""
//or
var emptyString1 = String()

//is empty is afuntion to check wither a string is empty or not

if emptyString.isEmpty {
    print("string is empty")
}

//strings addition
var string1 = "Hello"
var string2 = "Wolrd"
var string3 = string1 + string2
//or

var string4 = "ahmed"
string4 += " elsisi"
print(string4)

//arithmetic operators

let firstnumber = 12
let secondnumber = 5

let total = firstnumber + secondnumber
let different = firstnumber - secondnumber
let multiply = firstnumber * secondnumber
let devide = firstnumber / secondnumber

print(total)
print(different)
print(multiply)
print(devide)


//character count 
let somestring = "this is a string to be counted"
print("the number of characters is \(somestring.count)")

//array declaration 
var somearray = [int]()
//repeateting array
var fourDouble = [Double](repeating: 0.0, count:4)


//array modification:
//array append => to add a term in the end of the array
var shoppingList = ["this is the shopping list array"]
shoppingList.append("Flour")
//or
shoppingList += ["juice"]

//accessing an array
var firstitem = shoppingList[0]

//array modification
shoppingList[0] = ["bread"]
//or
shoppingList.insert("milk", at 0)
//to remove
shoppingList.remove(at:0)
//to remove last item
shoppingList.removelast()

//array iteration
for item in shoppingList {
    print(item)
}

//Sets are like arrays but without order
var names: Set<String> = ["Ahmed", "Mohamed","Hassan"]
//or without declaring without indicating the type
var names1: Set = ["Ahmed", "Mohamed","Hassan"]

//Sets modifications
//(1) adding
names.insert("Paul")
//(2) remove
names.remove("Paul")
//(3) contains
if names.contains("James"){
    print("James is here")

    else {
        print ("James is not here")
    }
}

//Set iterating
for name in names{
    print("\(name)")
}

//Set iterating with sorting
for name in names.sorted(){
   print("\(name)")
}

//this is a good example of adding 2 sets and sorting them
let oddDigit: Set = [1,3,5,7,9]
let evenDigits: Set = [0,2,4,6,8]

let x = oddDigits.union(evenDigits).sorted()
//tgm3 de be de we trtbhm
//operations: Union - Subtraction - symmetericDifference - intersection


///////////////////////////////////
///////////////////////////////////
///////////////////////////////////
///////////////////////////////////
///////////////////////////////////
///////////////////////////////////
///////////////////////////////////


//Dictionaries
//Array of values with a sepcial key to each value of them 
//Syntax => Dictionary<Key, Value> (OR) [Key: Value]
var airports = [Int: String]()
// so the keys are a type of integer, and their values are in strings
//Example Literal
var airports1: [String: String]= ["TOR": "Toronto", "NY": "New York"]

airports["LHR"] = "London"
//to chnage the value of LHR
airports["LHR"] = "London Heathrow"
//to display the value using the key
var airportName = airports["LHR"] //will print the name associated with the key
//to remove the value inside a key
airports["TOR"] = nil

//Functions
func sayHello(personName: String) -> String {
    //name of the function, (paramerters)
    //the arrow indicates the type of value returned
    let greeting = "Hello " + personName + "!"
    return greeting
}
//to print using the functio
print(sayHello(personName: "Ahmed"))

//functions can be declared without paramteres
func sayHello1() -> String {
    return "Hello, Wolrd!"
}

//functions can be declared without return
func sayHello2(name: String){
    print("Hello  + \(name)")
}
//to bring its output
sayHellow(name: "Ahmed")

//functions also can have multiple returns
//functions have 2 parameters:
//local parameters: only when the function is called
//external paramteres: called anywhere 
//example

func someFunc(externalName localName:int){
    //function can use localName
}

//example with 2 parameters

func sayHello3(to p1: String, and p2: String) -> String {
    return("Hellow \(p1) and \(p2)")
}
print(sayHello(to: "Tom", and: "Jerry"))

//to & and are the external parameters names

//default parameter value

func someFunc1(p1: Int=12){
}

someFunc(p1: 6) //p1 = 6
someFunc() //p1 = 12

//inout parameters -> the function paramters values are constant
//if you want to change the parameters of the function in and outside the function
//the parameters must be declared as inout

func inoutFunc(a: inout Int, b: inout Int){
    return a*a*b
}
//if you want to call the fucntion with inout parameters:
var number1 = 3
var number2 = 100
inoutFunc(a: &number1, b: &number2)

//assign a function with its parameters to a variable
var mathFunction:(Int, Int) -> Int = addInt 

//function parameters can be called using another function
func printResult(mathFunc: (Int, Int) -> Int, a: Int, b: Int) {
   print("Result: \(mathFunc(a, b))")
}
printResult(addInts, a: 3, b: 5) 

//function type as return 

func plus(input: Int) -> Int {
   return input + 1
}
func minus(input: Int) -> Int {
   return input - 1
}
func chooseFunc(flag: Bool) -> (Int) -> Int {
   if(flag) {
     return plus
   }
   else {
     return minus
   }
}

//inside the function, you can call another function, its called:
// "nested function"

//function can call its self, called recursion "like in C"


// §    s: function block can be called anywhere in the code
//bal7, rag3ha tany ba3d ma t5ls

//Tuples:
// group of values in a single compound value

let error = (404, "Not Found")

//the tuple above is a type of (Int, String)

let (Amessage, Bmessage) = error 
print("the status code is \(Amessage)")
//prints the status code is 404
print("the status code is \(Bmessage)")
//prints the status code is Not Found

//or

print("the status code is \(error.0)")
print("the status code is \(error.1)")

//another implementation

let ahmedStatus = (codeStatus: 250, codeDesign: "OK")

print("the status code is\(ahmedStatus.codeStatus)")
print("the status code is\(ahmedStatus.codeDesign)")

//Enumerations

enum Compass {
    case North
    case South
    case west 
    case East
}

//or

enum Planets {
    case Mars, Jupiter, Earth, Venus
}

var soso = Planets.Mars
//keda hay5osh 3ala el value ely gowa el numeration

//objected oriented 

//classes and structs:

struct Resolution() {
    var width = 0
    var length = 0
}

class VideoMode() {
    var resolution = Resolution()
    var frameR = 0.0
    var interlaced = false
}

//struct can be called inside the classes i guess

//to call the outputs of classes and structs (they are similar)

let xy = Resolution()
let yx = VideoMode()

//to access the isntance for both structs and classes

print("the width is \(xy.width)")
//we bardo
print(yx.resolution.width) 

//to assign a value to a variable inside a struct or a class

yx.resolution.width = 1200

//for structs, you can do the following (BUT NOT FOR CLASSES)

let vga = Resolution(width: 3000, length: 400)

//not for classes, only structs

/////////////////NOTE MOHMA///////////////

//law kan 3andk 2 values mn struct, we nas5t el 2 values dol le instance
//ba3deen 3'ayrt value mn el 2 dol fel instance el gdeed
//el instance el awlany hayfdl zay mahowa wely hayt3'ayr bs howa el instance 
//el tany, bs vel classes, law 3'ayrt hasga fel instance el gdeed hayt3'ayr fel
//adeem kaman

//example:

struct Test1() {
    var num1 = 17
}
let a = Test1()
let b = a
b.num1 = 35
print(a.num1)
// will print 17
print(b.num1)
//will print 35

class Test2() {
    var num2 = 17
}
let c = Test2()
let d = c
b.num2 = 35
print(c.num2)
// will print 35
print(d.num2)
//will print 35


//Identity operators:

//Identical to (===)
//Not identical to (!==)

//Properties => enk tst5dm el class, enummeration aw el structure f3ln

struct Size(){
    var depth: Int
    var hight: Int
}

var size1 = Size(depth: 10, hight: 10)
//to access
size1.depth = 20

//Lazy stored properties: a value is not calculated until the 1st time its used
//and always must be declared as var

//other properties bal7

//willSet => call just before the value is stored
//didSet => call right after the new value is stored

//static values can be in swift too, and they are declared like this:

static var storedProp = "SOme Value"

//it have to be initialised 


//Methods:

class Counter {
   var count = 0
   func increment() {
      count+=1
   }
  func incrementBy(amount: Int) {
      count += amount
  }
  func reset() {
      count = 0
   }
}


let counter = Counter()
// the initial counter value is 0
counter.increment()
// the counter's value is now 1
counter.incrementBy(amount: 5)
// the counter's value is now 6
counter.reset()
// the counter's value is now 0

//law 3ayz t3'ayr el functiontality bta3t function mesh mt3rfa constant (i guess)
//use mutating......example:

struct Point {
   var x = 0.0, y = 0.0
   mutating func moveByX(dX: Double, dY: Double) {
     x += dX
     y += dY
   }
}

//if you wanna declare a type method function, write static  before it

static func someFunc2()

//subscripts:
//subscripts like enumeration, structure, classes
//mesh fahmha
//they are used to access values from an instance
//used in matrixes as well

//`inhertance` => class to inhernint properties from another class
//subclass and superclass

//subclassing => bassing a new class on an existing class

class Vehicle {
  var currentSpeed = 0.0
  var desc: String {
    return "traveling at \(currentSpeed) mph"
  }
  func makeNoise() {
    // do nothing
  }
}


class Bicycle: Vehicle {
    //subclass from the superclass
   var hasBasket = false
}

//bycycle class will have all the properties from the vehicle class



let bicycle = Bicycle()
bicycle.hasBasket = true
bicycle.currentSpeed = 25.0
print("Bicycle: \(bicycle.desc)")


//subclasses can be subclassed
class Tandem: Bicycle {
   var currNumOfPassengers = 0
}

let tandem = Tandem()
tandem.hasBasket = true
tandem.currNumOfPassengers = 2
tandem.currentSpeed = 20.0
print("Tandem: \(tandem.desc)")


//fe haga leha 3elaqa bel override

//Initializers:
//to set initial values for instances
// => init() {}

//Write the required modifier before the definition 
//of  a class initializer to indicate that every 
//subclass of the class must implement that initializer:

class SomeClass23 {
   required init() {
     // initializer implementation goes here
   }
}

//deinitialization:
//// => deinit() {}

//storyBoard => betwareek el app beyb2a shaklo ezzay
//mn launchScreen.storyboard
// 2 main files in any program:
//AppDelegate.swift
//SceneDelegate.swift
//storyboard background is called Canvas

// .character function

var eString = "Meet me in St. Louis"
for character in eString.characters {
    if character == "e" {
        print("found an e!")
    } else {
    }
}

// .count function in .character

var theTruth = "Money can’t buy me love."
theTruth.characters.count 


