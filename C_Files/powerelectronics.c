#include <stdio.h>
#include <math.h>

int main() {

  double Ns;
  double Np;
  //double time; //capital delta
  double De; //delta
  double c;
  double Ce; //convertion coefficint
  //int Vp;
  //int Vs; //??
  double l;
  double Dtime; //derivative of time
  double ton;




  //////////Givens//////////

  int Vo = 600;
  int Vi = 400;
  int Vp = 400;
  int Vs = 1200;
  int io = 10;
  float delta = 0.8;   //on time
  long fsw = 10*10^3;  //you have to sleect it !!
  int Iripple = 1;
  float Vripple = 0.025; //enta ely t5tarha
  float j = 5; //current denisty (A/mm2)
  float Wf = 0.8; //winding factor
  int Ac = 76;
  int Ba = 300;





  //////////Equations//////////

  ton = delta/2*fsw; //2 for 2 transistors

  Np = (Vp*ton)/(Ac*2*Ba); //ton has to be max

  Ns = (Vo*Np)/(Vs*delta);

  //c = (Iripple)/(8*fsw*Vripple);

  //Vs = (Vp*Ns)/Np;

  //l = ((Vs - Vo)*Dtime)/deltaI;


  /////////////Results/////////////

  printf("ton is %f\n\t", ton);
  printf("primary winding is %f\n\t", Np);
  printf("secondry winding is %f\n\t", Ns);
  //printf("capacitance value is %f\n\t", c);
  //printf("secodnry voltage is%f\n\t", Vs);
  //printf("inductance value is %f\n\t", l);


}
