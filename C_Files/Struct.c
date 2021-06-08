#include <stdio.h>

int main(){

    struct course {
        int id;
        char title[40];
        float hours;
    };

struct course c1;
struct course c2;

struct course c3 = {26, "ahmed", 34.8};
struct course c4 = {.id = 23, .title = "mohamed", .hours = 45.6};

//to elemenate the usage of the struct for storing data

typedef struct{
    int ID;
    char Title[40];
    float Hours;
} course;
course cs1;
course cs2;

//structure within structure
typedef struct {
    int x;
    int y;
} point;

typedef struct {
    float radius;
    point center;
} circle;

circle c = {4.5, {1,3}};
printf("%3.1f %d, %d". c.radius, c.center.x, c.center.y);
//doesn't work

//Array of Structures
typedef struct {
  int h;
  int w;
  int l;
} box;

int main() {
  box boxes[3] = {{2, 6, 8}, {4, 6, 6}, {2, 6, 9}};
  int k, volume;
  
  for (k = 0; k < 3; k++) {
    volume = boxes[k].h*boxes[k].w*boxes[k].l;
    printf("box %d volume %d\n", k, volume);
  }
  return 0;
}
}