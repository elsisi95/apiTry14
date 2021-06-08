print('Hello World')
print((4 + 8) / 2)
print(5**3) #5 power 3
print(8 ** (1/3)) 
print(10//4) #how much the 1st number contains of the 2nd number
print(20 % 6) #reminder
print('Brian\'s mother: He\'s not an angel. He\'s a very naughty boy!')
#to include quotation or abostroph inside the string you need the backslash
print('One \nTwo \nThree')
print("""this
is a
multiline
text""")

#variables do not have specific type

name = input("Enter your name: ")

print("Hello, " + name)

#input function takes a string, to make it take an integer:
age = int(input())
print(age)

#or

age = 42
print("His age is " + str(age))


#else if in python

num = 3
if num == 1:
  print("One")
elif num == 2:
  print("Two")
elif num == 3:
  print("Three")
else:
  print("Something else")

# in python we have "and" instead of &&
# "or" instead of ||
# "not" instead of !

#Lists: to store multiple items (like arrays i guess)

words = ["Hello", "world", "!"]
print(words[0])
print(words[1])
print(words[2])

#empty list

empty_list = []
print(empty_list)

#nested lists (lists within lists)
number = 3
things = ["string", 0, [1, 2, number], 4.56]
print(things[1])
print(things[2])
print(things[2][2])


#operations on lists
nums = [1, 2, 3]
print(nums + [4, 5, 6])
print(nums * 3)

#check if an item is in the list
words = ["spam", "egg", "spam", "sausage"]
print("spam" in words)
print("egg" in words)
print("tomato" in words)
#returns true if found it, false if didn't

#check if an item is not in the list
nums = [1, 2, 3]
print(not 4 in nums)
print(4 not in nums)
print(not 3 in nums)
print(3 not in nums)
#returns true if didn't find, and false if did (i guess)

#append (add an item at the end of a list)
nums = [1, 2, 3]
nums.append(4)
print(nums)

#to get the number of items in the list
nums = [1, 3, 5, 2, 4]
print(len(nums))

#insert: like append, but the item can be added anywhere
words = ["Python", "fun"]
index = 1
words.insert(index, "is")
print(words)

#The index method finds the first occurrence of a list item and returns its index.
letters = ['p', 'q', 'r', 's', 'p', 'u']
print(letters.index('r'))
print(letters.index('p'))
print(letters.index('z'))

#while loop
i = 1
while i <= 5:
   print(i)
   i = i + 1
print("Finished!")

#break to end an infinite loop
i = 0
while True:
  print(i)
  i = i + 1
  if i >= 5:
    print("Breaking")
    break
print("Finished")

#Continue state: opposite of break
i = 1
while i <= 5:
    print(i)
    i += 1
    if i == 3:
      print("Skipping 3")
      i = i + 1
      continue
print("Continue")


#for loops 
str = "testing for loops"
count = 0

for x in str:
  if(x == 't'):
    count += 1

print(count)

days = ["Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"]
for d in days:
   print (d)

for i,d in enumerate(days):
   print(i,d)
#prints the element order and the element itself


#range function:
#The range() function returns a sequence of numbers.
#By default, it starts from 0, increments by 1 and stops before the specified number.
numbers = list(range(10))
print(numbers)

#if 2 arguments in the range func, it will produce number from the 1st to the 2dn argument -1
numbers = list(range(3, 8))
print(numbers)
print(range(20) == range(0, 20))

#if there is a 3rd argument, it will be the value of increment
numbers = list(range(5, 20, 2))
print(numbers)

#functions:

def my_func():
    print("Ahmed")
    print("spam")


def max(x, y):
    if x >= y:
        return x
    else:
        return y


print(max(4, 7))
z = max(8, 5)
print(z) 

#any statement written after the return 
#statement will not be excuted
def add_numbers(x, y):
  total = x + y
  return total
  #print("This won't be printed")
  #3amlt el satr ely fo2 da comment 3ashan
  #ashel el error bs
  


#assigning a fuction to another
def multiply(x, y):
   return x * y


a = 4
b = 7
operation = multiply
print(operation(a, b))

#function with multiple arguments but written once
def multi_add(*arg):
   result = 0 
   for x in arg:
      result = result + arg
   return result
# the *arg takes multiple variable number of arguments
#not working  in Pycharm



#modules:
#Modules are pieces of code that other people have written to fulfill common tasks, 
# such as generating 
# random numbers, performing mathematical operations, etc.
#The basic way to use a module is to add import module_name at the 
# top of your code, and then using module_name.var to access functions 
# and values with the name var in the module.

import random

for i in range(5):
   value = random.randint(1, 6)
   print(value)

import math

print(math.sqrt(16))

#to insert a specific part of the module:
from math import pi

print(pi)

#to import multiple stuff
from math import pi,sqrt

#importing a part under a different name:
from math import sqrt as square_root
print(square_root(100))

#try/except:
#To handle exceptions, and to call code when an exception occurs, 
# you can use a try/except statement.
try:
   num1 = 7
   num2 = 0
   print(num1 / num2)
   print("Done calculation")
except ZeroDivisionError:
   print("An error occurred")
   print("due to zero division")


#another example:
try:
   variable = 10
   print(variable + "hello")
   print(variable / 2)
except ZeroDivisionError:
   print("Divided by zero")
except (ValueError, TypeError):
   print("Error occurred")

#to include all error:
#leave the exception parameters empty
try:
   word = "spam"
   print(word / 0)
except:
   print("An error occurred")

#to code to run no matter what
#use finally
#and use it at the end of the block 
try:
   print("Hello")
   print(1 / 0)
except ZeroDivisionError:
   print("Divided by zero")
finally:
   print("This code will run no matter what")

#raising an exception: (see last example)
"""
print(1)
raise ValueError
print(2)
"""

#prints: 1 ValueError

#to be more specific in your exceptions:
name = "123"
raise NameError("Invalid name!")

#to make it easier for you:
#if you just write raise
#it will inlcude whatever error occured
#but it have to be inside the except block:
try:
   num = 5 / 0
except:
   print("An error occurred")
   raise
###################################
#Best way for try-except statements
###################################

#aasertion => bal7



##
#Files#
##

#to open a file
myFile = open("ahmed.txt")

# write mode
open("filename.txt", "w")

# read mode
open("filename.txt", "r")
open("filename.txt")

#append mpde
open("filename.txt", "a")

# binary write mode
open("filename.txt", "wb")
#binary mode can be in append and read too

#to close the file:
file = open("filename.txt", "w")
# do stuff to the file
file.close()

#to read files:
file = open("filename.txt", "r")
cont = file.read() #here
print(cont) #and here
file.close()

#to read a specific number of bytes:
file = open("filename.txt", "r")
print(file.read(16))
print(file.read(4))
print(file.read(4))
print(file.read()) #reads the whole file
file.close()

#to read each line alone:
file = open("filename.txt", "r")
print(file.readlines())
file.close()

#or 

file = open("filename.txt", "r")

for line in file:
    print(line)

file.close()


#to write in files:

file = open("newfile.txt", "w")
file.write("This has been written to a file")
file.close()

file = open("newfile.txt", "r")
print(file.read())
file.close()

# prints whats inside it

#When a file is opened in write mode, the file's existing content is deleted.

#use try and finally to always ensure the
#files are closed

try:
   f = open("filename.txt")
   print(f.read())
finally:
   f.close()



# files 2.0

f = open("textFile.txt", "w+")   
#W+ means write and the plus means create if not existed 
f.write("This is the first line \n")
f.close()

f = open("textFile.txt", "a")
f.write("ahmed")
f.close()


f = open("textFile.txt", "r")
ahm = f.read()
print(ahm)


#date & time

from datetime import date
from datetime import time
from datetime import datetime
#importing 3 classes from datetime libraries
today = date.today()
print(today)
print(today.day, today.month, today.year)
# retrieve today's weekday (0=Monday, 6=Sunday)
print("Today's Weekday #: ", today.weekday())
days = ["monday", "tuesday", "wednesday",
        "thursday", "friday", "saturday", "sunday"]
print("Which is a " + days[today.weekday()])

## DATETIME OBJECTS
# Get today's date from the datetime class
today = datetime.now()
print("The current date and time is ", today)

# Get the current time
t = datetime.time(datetime.now())
print("The current time is ", t)

from datetime import timedelta # to perform mathematics on time and dates




#extra

import os  # let you deal with operating system related stuff
from os import path
import datetime
from datetime import date, time, timedelta
import time


def main():
  # Print the name of the OS
  print(os.name)
  print((path.exists("texrFile.txt")))

  #check the Ch4 files



#########
#Check Classes
#Check Copying/renaming/copy with stats files
#Check how to use python in shell methods ?? Ch4
#Check how to use the shell to work with zip files

#fetching data from internet


#import urllib.request  #import urllib bs ely btsht3'l 
#def main():
  # open a connection to a URL using urllib2
#  webUrl = urllib.request.urlopen("http://www.google.com")

  # get the result code and print it
#  print("result code: " + str(webUrl.getcode()))

  # read the data from the URL and print it
#  data = webUrl.read()
#  print(data)
  
