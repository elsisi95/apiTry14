#include <stdio.h>
#include <string.h>

typedef struct{
    char name[40];
    char city[40];
} company;
company cs1;
company cs2;
company cs3;


typedef struct{
    char name1[40];
    long ID;
    float price;
    int amount;
    int age;
    char comp[40];
} item;

item it1;
item it2;
item it3;

int main() {

//for case 1
  int n; 
  int nn;
  char x[40];
  char y[40];
  char xx[40];
  char yy[40];


//for case2
  int m;  



 
    int i;
    printf("Select one of the following options:\n");
    printf("Press 1 to add data to database\n");
    printf("Press 2 to output data from database\n");
    printf("Press 3 to search item by name\n");
    printf("Press 4 to search an item with price greater \n");
    printf("Press 5 to search an item made by El-araby company\n");
    printf("Press 6 to search item by ID\n");
    printf("Press 7 to search an item with maximum amount\n");
    printf("Press 8 to search an item with 0 amount\n");
    printf("Press 9 to search an item for age >3 years\n");
    printf("Press 10 to Exit\n");
    scanf("%d", &i);

    switch(i)
   {

    ////////////////////////////////////////////////////////    
    case 1: 

    //fill data in database
    printf("which data you would like to add?\n");
    printf("Press 1 for company's data\n");
    printf("Press 2 for item's data\n");
    scanf("%d", &n);

    if (n==1){
      printf("Press 1 to add company's name or 2 to add company's city\n");
      scanf("%d", &nn);

      if(nn==1){
        printf("Enter the company's name\n");
        scanf("%s", &x[40]);
        //gets(x);
        strcpy(cs1.name, x);
      }

      else if (nn==2){
        printf("Enter the comapny's city\n");
        scanf("%s", &y[40]);
        //gets(y);
        strcpy(cs1.city, y);
      }

      else {
        printf("Wrong Input\n");
      }

    }

    else if(n==2){
      printf("to add data for items, press 1 for name, 2 for ID, 3 for price, 4 for company, 5 for age\n");
      scanf("%d", &nn);

      if(nn==1){
        printf("add the item's name\n");
        scanf("%s", &xx[40]);
        strcpy(it1.name1, xx);
      }

      else if(nn==2){
        printf("add the item's ID\n");
        scanf("%ld", it1.ID);
      }

      else if (nn==3){
        printf("add the item's price\n");
        scanf("%f", it1.price);
      }

      else if(nn==4){
        printf("add the item's company\n");
        scanf("%s", &xx[40]);
        strcpy(it1.comp, xx);
      }

      else if(nn==5){
        printf("add the item's age\n");
        scanf("%d", it1.age);
      }

      else{
        printf("Wrong Input\n");
      }

    }
    break; //end of case 1
   ////////////////////////////////////////////////////////    



    case 2: 

    //output the data from database
    printf("which data you would like to show\n");
    printf("Press 1 for company's data\n");
    printf("Press 2 for item's data\n");
    scanf("%d", &m);

    break;




    case 3: 
    //search by name
    break;



    case 4: 
    //
    break;

    case 5: 
    //
    break;

    case 6: 
    //
    break;

    case 7: 
    //
    break;

    case 8: 
    //
    break;

    case 9: 
    //
    break;

    case 10: 
    //
    break;

    

    default: printf("Wrong input\n");


} 
