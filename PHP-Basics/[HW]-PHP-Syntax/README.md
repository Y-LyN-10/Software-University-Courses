## Homework: PHP Syntax

This document defines the homework assignments from the “PHP Basics“ Course @ Software University. 
Please submit as homework a single zip / rar / 7z archive holding the solutions (source code) of 
all below described problems.

#### Problem 1.	Personal Info
Write a PHP script PersonalInfo.php. Declare a few variables. The first variable should hold your first name, the second should hold your last name, the third - your age, and the last one should hold your full name (use concatenation). The result should be printed.  Sample output:
------------------------------------------------
My name is Mister DakMan and I am 21 years old.
------------------------------------------------
My name is Pesho Peshev and I am 55 years old.
------------------------------------------------

#### Problem 2. Sum Two Numbers
Write a PHP script SumTwoNumbers.php that decleares two variables, firstNumber and secondNumber. They should hold integer or floating-point numbers (hard-coded values). Print their sum in the output in the format shown in the examples below. The numbers should be rounded to the second number after the decimal point. Find in Internet how to round a given number in PHP. Examples:

Input: 
2
5

Otput:
$firstNumber + $secondNumber = 2 + 5 = 7.00

Input:
1.567808
0.356

Output:
$firstNumber + $secondNumber = 1.567808 + 0.356 = 1.92

#### Problem 3. Dump Variable
Write a PHP script DumpVariable.php that declares a variable. If the variable is numeric, print it by the built-in function var_dump(). If the variable is not numeric, print its type at the input. 

#### Problem 4.	Non-Repeating Digits
Write a PHP script NonRepeatingDigits.php that declares an integer variable N, and then finds all 3-digit numbers that are less or equal than N (<= N) and consist of unique digits. Print "no" if no such numbers exist. Examples:

Input: 1234
Output: 102, 103, 104, 105, 106, 107, 108, 109, 120, 123, 124, 125, 126, 127, 128, 129, 130, 132, 134, 135, …, 980, 981, 982, 983, 984, 985, 986, 987

#### Problem 5.	Lazy Sundays
Write a PHP script LazySundays.php which prints the dates of all Sundays in the current month. 

#### Problem 6.	HTML Table
Write a PHP script InformationTable.php which generates an HTML table by given information about a person (name, phone number, age, address). Styling the table is optional. Semantic HTML is required. 

#### Problem 7.	Form Data
Write a PHP script GetFormData.php which retrieves the input data from an HTML form, and displays it as string. The input fields should hold name, age and gender (radio buttons). The returned string should be a message containing the information submitted by the form. 100% accuracy is NOT required. Semantic HTML is required. 

#### Problem 8.	* Time Until New Year
Write a PHP script TimeUntilNewYear.php. Use the built-in function getdate() to get the current date and time. Print how many hours, minutes and seconds are left until New Year and how many days, hours, minutes and seconds are left in a counter format . Look at examples below to get a better idea. The examples show the current date and time in "d-m-Y G:i:s" format. Use the current time. Check here for date/time formats in PHP. (Note: Keep the Spring/Autumn time shifts in mind in your calculations.)

Example Input: 12-08-2014 13:07:09
Output: 
Hours until new year : 3394
Minutes until new year : 203 692
Seconds until new year : 12 221 570
Days:Hours:Minutes:Seconds 141:10:52:50

#### Problem 9.	** Awesome Calendar
Write a PHP script AwesomeCalendar.php which creates a calendar in HTML for a given year. Styling the calendar is optional. Semantic HTML is required. Hint: Embed HTML in your PHP code. Use tables or divs for structuring the calendar. Look for a way to find the day of the week.
