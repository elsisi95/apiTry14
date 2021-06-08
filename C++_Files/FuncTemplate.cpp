/* Wouldn't it be much more efficient to be able to write one version of sum() to 
   work with parameters of any type?
   function templates give us the ability to do that! */

template <class T>
T sum(T a, T b) {
  return a+b;
}

int main () {
    int x=7, y=15;
    cout << sum(x, y) << endl;

    double x1=7.15, y1=15.54;
    cout << sum(x1, y1) << endl;
}

// Outputs 22
// Outputs 22.69