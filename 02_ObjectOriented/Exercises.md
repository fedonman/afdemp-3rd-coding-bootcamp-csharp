## Exercise Circle

1. Create a class called Circle that contains:
   * Two properties: Radius (of the type double) and Color (of the type String), with default value of 1.0 and "red", respectively. 
   * Two overloaded constructors - a default constructor with no argument, and a constructor which takes a double argument for radius. 
   * Two public methods: SetRadius() and SetColor() that sets the radius and color, respectively. 
   * One public method: GetArea(), which return the area of this instance.
2. Create a class called Color that contains three properties, R, G, B that represent the values of red, green, blue channels.
3. Update class Circle, so it has two properties for fill color and border color that are representated by Color. (delete previous Property Color)
4. Create a class Point, that representes a point in 2d space (x,y).
5. Update class Circle, so we it has a center point.
6. Create a method in class Circle, IsPointInCircle(Point p), that checks if p is inside the circle.
7. Test the above in Main(). Ask user to create a circle and check if a point is inside that circle.


## Exercise University
Implement a University class containing university's info, a list of Courses and a list of its Students. Courses have name and ECTS. Students have name and age. A Student registers up to 5 courses.
1. Create the classes and their properties.
2. Create a method that registers student to course
3. Create a method that marks a course as completed and stores user’s grade
4. Create a method that calculates user’s median grade. Use ECTS as weights. Ie. like M = (M1*E1 + M2*E2 + M3*E3) / (E1 + E2 + E3)
5. Create a method that returns the best and worst student of a course.


## Exercise Complex
1. Model the complex number as a class in C#. 
2. Create constructors for different input parameters, as well as copy constructors.
3. Implement common operations such as addition and subtraction as methods of the class 
4. Implement the same operations as overloaded operators. 
5. Override ToString() method for informative output.


## Exercise *Fraction*
1. Define a class *Fraction*, which contains information about the rational fraction (e.g. 1/4).  
2. Define the appropriate fields, properties and constructors.  
3. Override ToString() to print the Fraction (e.g. "1/4").  
4. Override operator * to multiply two Fractions.  
5. Define a static method Parse(string str) to create a Fraction from a string.
6. Define a property of type *decimal* to return the decimal value of the fraction (e.g. 0.25).  
7. Implement IComparable interface to enable sorting of Fractions.  
8. Write a function Cancel() to cancel the Fraction. (e.g. 10/15 is cancelled to 2/3).


## Exercise Utilities
Create a static class *Utilities* and

1. 
   1. Write a method which takes two integers parameters and swaps them. Use *ref*. 
   2. Create a second method which swaps generic types.
2. 
   1. Write a  method that finds the longest subsequence of equal numbers in a given *List<int>* and returns the result as new *List<int>*. 
   2. Create a second method which does the same for generic types. Test it with class *Fraction*. 
   3. Implement the same, but as an extension method of class *List* (search what extension method is). 
3. 
   1. Write a method that takes as parameters the a, b, c of the quadratic equation *ax^2 + bx + c = 0* and returns the real-valued solutions if they exist. 
   2. Try doing the same with complex solutions using the *Complex* class. 

