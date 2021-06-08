#include <iostream>
#include <fstream> //needed for files

int main() {
  ofstream MyFile;
  MyFile.open("test.txt"); //creating a file called test.txt

  MyFile << "Some text. \n";
  MyFile.close(); //to close the file after openning it 
}
