//By default, arguments in C++ are passed by value.
#include <iostream>
#include <string> //for string
#include <cstdlib> //for random number functions rand() and srand()
using namespace std; //telling the compiler to use standrad naming identifiers 

int main() {

    int myVariable = 10;
    int num;
    unsigned short xy; //unsigned holds only positive & short is half the length of int
    signed long yx; //signed holds both +ve and -ve & long is twice the length of int
    //float 4 bytes
    //double 8 bytes
    //long double 16 bytes

    cout << "Hello World\n";
    cout << "this " << "is " << "awesome\n";
    cout << "programming test" << endl; //to provide an end and creating new line like \n in C
    cout << "Hello World again \n"; // \n can be used here as well
    // mulit line comments /* */ like in C
    cout << myVariable; //prints
    cin >> num; //scans the input from the user
    
    //if, while, do while, and switch statements are all like in C

    string nam = "Ahmed";

    int b[] = {11, 45, 62, 70, 88};

    cout << b[0] << endl;
    // Outputs 11

    cout<< b[3] << endl;
    // Outputs 70

    //array example:

    int myArr[5];

    for(int x=0; x<5; x++) {
    myArr[x] = 42;
 
        cout << x << ": " << myArr[x] << endl;
}
        /* Outputs 
        0: 42
        1: 42
        2: 42
        3: 42
        4: 42
        */

        //multi dimentional arrays

        int x[2][3] = {
        {2, 3, 4}, // 1st row
        {8, 9, 10} // 2nd row
        };

        //or

        int y[2][3] = {{2, 3, 4}, {8, 9, 10}};


        //pointers 
        //provides the memory address of the variable
        int score = 5;
        cout << &score << endl;

        //Outputs "0x29fee8"
        //A pointer is a variable, with the address of another variable as its value.


        //assigning the address of a pointer to an integer
        int score1 = 5;
        int *scorePtr;
        scorePtr = &score1;

        cout << scorePtr << endl;

        //Outputs "0x29fee8"

        //Address-of operator (&): returns the memory address of its operand.
        //Contents-of (or dereference) operator (*): returns the value of the variable 
        //located at the address specified by its operand.

        //2 types of memory in C++:

        //The stack: All of your local variables take up memory from the stack.
        //The heap: Unused program memory that can be used when the program runs to 
        //dynamically allocate the memory.

        //example of how to use the memory:

        int *p = new int; // request memory
        *p = 5; // store value

        cout << *p << endl; // use value

        delete p; // free up the memory

        //The delete operator frees up the memory allocated for the variable, 
        //but does not delete the pointer itself, as the pointer is stored on the stack.

        //Pointers that are left pointing to non-existent memory locations are c
        //alled dangling pointers.
        //For example:

        int *l = new int; // request memory
        *l = 5; // store value

        delete l; // free up the memory
        // now p is a dangling pointer

        l = new int; // reuse for a new address

        //sizeof (data type)
        //returns the size of the data (number of bytes)

        //function overloading: allows to create multiple functions with 
        //the same name, so long as they have different parameters.



        //Data abstraction is the concept of providing only essential 
        //information to the outside world. It's a process of representing 
        //essential features without including implementation details.


        //In object orientation, encapsulation means more than simply combining 
        //attributes and behavior together within a class; it also means restricting 
        //access to the inner workings of that class.

        



    return 0;
}

