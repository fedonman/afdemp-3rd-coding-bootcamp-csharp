## Staircase
Consider a staircase of size *n = 4*:
```
   #
  ##
 ###
####
```
Observe that its base and height are both equal to *n*, and the image is drawn using # symbols and spaces. The last line is not preceded by any spaces.
Write a function that prints a staircase of size *n*.


## Grading Students
AFDEmp University has the following grading policy:

+ Every student receives a grade in the inclusive range from 0 to 100.
+ Any grade less than 40 is a failing grade.

Sam is a professor at the university and likes to round each student's grade according to these rules:

+ If the difference between the grade and the next multiple of 5 is less than 3, round  up to the next multiple of 5. 
+ If the value of grade is less than 38, no rounding occurs as the result will still be a failing grade.

For example, `grade = 84` will be rounded to 85, `grade = 71` will not be rounded because the difference from the next multiple of 5 is greater than 3, and `grade = 28` will not be rounded because the rounding would result in a number that is less than 40.

Write a method to automate the rounding process. It takes as input an array of the student's grades and returns an array with the grades rounded.


## Utopian Tree
The Utopian Tree goes through 2 cycles of growth every year. Each spring, it doubles in height. Each summer, its height increases by 1 meter.

Laura plants a Utopian Tree sapling with a height of 1 meter at the onset of spring. How tall will her tree be after N growth cycles?

Write a function that returns an array with elements the tree's height after each cycle. So, `array[0]` will contain the initial tree's height, `array[1] will contain the tree's height after 1 cycle etc.

Write a second function that prints the results. Each height must be printed on a new line.


## Time from now
Write a function that takes as input a date and returns a string representating the relative difference between *now* and that date. For example if *now* is `04-12-2017` and input date is `05-01-2018` then the function would return `"1 month and 1 day from now"`. 
