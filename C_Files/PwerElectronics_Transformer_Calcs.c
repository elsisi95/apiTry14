#include <stdio.h>
#include <math.h>

int main() {

  /////////////Variables/////////////
  double Ns;
  double Np;
  double time; //capital delta
  double De; //delta
  double c;
  double Ce; //convertion coefficint
  //int Vp;
  int Vs; //??
  double l;
  double Dtime; //derivative of time



  /////////////Constants/////////////
  int Vo = 600;
  int Vi = 400;
  int Vp = 400;
  int io = 10;
  float ton = 0.7;   //on time
  long fsw = 10*10^3;  //you have to sleect it !!
  int deltaI = 1;
  float Vripple = 0.025; //enta ely t5tarha
  float j = 5; //current denisty (A/mm2)
  float Wf = 0.8; //winding factor
  int Ac = 76;
  int B = 600;


  /////////////Equations/////////////

  //time = 1/fsw;

  //De = ton/time; //delta value

  De = ton*fsw;

  Np = (Vp*ton)/(2*deltaB*Ac);

  //Vo = (Vi * De)*(Ns/Np);

  Ns = (Vo*Np)/(Vi*ton);

  //Ns = Np*(Vs/Vp);

  c = (deltaI)/(8*fsw*Vripple);

  Vs = (Vp*Ns)/Np;

  Dtime = (De/2)*(1/fsw);

  l = ((Vs - Vo)*Dtime)/deltaI;


  /////////////Results/////////////

  printf("Delta is %f\n\t", De);
  printf("primary winding is %f\n\t", Np);
  printf("secondry winding is %f\n\t", Ns);
  printf("capacitance value is %f\n\t", c);
  //printf("%f\n\t", Vs);
  printf("inductance value is %f\n\t", l);


  return 0;

}
