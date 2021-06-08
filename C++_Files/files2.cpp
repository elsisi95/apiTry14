#include <iostream>
#include <fstream>
using namespace std;

int main() {
  ofstream MyFile("test.txt");

  if (MyFile.is_open()) { //is_open() member function checks 
  //whether the file is open and ready to be accessed
   MyFile << "This is awesome! \n";
  }
  else {
   cout << "Something went wrong";
  }
  MyFile.close();
}

