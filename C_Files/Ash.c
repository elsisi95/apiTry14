#include <stdio.h>
#include <string.h>

    int count = 0;
    int m = 10; //number of employees
    int sal; //for question 2.3 (user specified value)
    float perc;
    int id;


        //2.1
        typedef struct {
        char name[50];
        int ID;
        char adr[50];
        int salary;
        } employee;

        employee emps[10];



void scan(){
   while (count <= m) {

        scanf("%s %d %s %d", &emps[count].name, &emps[count].ID,
        &emps[count].adr, &emps[count].salary);

        count ++;
    }
}


void specValue(){

    for (count = 0; count <= 10; count ++){
        if(emps[count].salary > sal){
            printf("the employee ID is %d\n", emps[count].ID);
        }
    }

}


void payRise(){

    for (count = 0; count <= 10; count ++){
        if(emps[count].ID == id){
            emps[count].salary = emps[count].salary + ((emps[count].salary)*perc);
            //salary = salary + (salary*(rise_percentage))
        }
    }

}


void salPrint(){

    for (count = 0; count <= 10; count ++){
        printf("the employee salary is %d\n", emps[count].salary);
    }

}




int main() {

    //2.2
    scan();
    

    //2.3
    printf("Enter the salary value\n");
    scanf("%d", &sal);
    specValue();

    

    //2.4
    printf("Enter the rise percentage and ID:\n");
    scanf("%f %d", &perc, &id);
    payRise();


    //2.5
    salPrint();
    
    return 0;
}