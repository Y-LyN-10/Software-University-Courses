## Homework: Defining Classes
----------------------------
This document defines the homework assignments from the <a href="https://softuni.bg/trainings/coursesinstances/details/8">"OOP" Course @ Software University</a>. Please submit as homework a single zip / rar / 7z archive holding the solutions (source code) of all below described problems. The solutions should be written in C#.


#### Problem 1. Persons
Define a class <strong>Person</strong> that has <strong>name</strong>, <strong>age</strong> and <strong>email</strong>. The <strong>name</strong> and <strong>age</strong> are mandatory. The <strong>email</strong> is optional. Define <strong>properties</strong> that accept non-empty name and age in the range [1...100]. In case of invalid argument, throw an exception. Define a property for the email that accepts either <strong>null</strong> or non-empty string containing '@'. Define two <strong>constructors</strong>. The first constructor should take name, age and email. The second constructor should take name and age only and call the first constructor. Implement the <strong>ToString()</strong> method to enable printing persons at the console.
<p>
#### Problem 2. Laptop Shop
Define a class <strong>Laptop</strong> that holds the following information about a laptop device: <strong>model, manufacturer, processor, RAM, graphics card, HDD, screen, battery, battery life</strong> in hours and <strong>price</strong>.
* The <strong>model</strong> and <strong>price</strong> are mandatory. All other values are optional.
* Define two separate classes: a class <strong>Laptop</strong> holding an instance of class <strong>Battery</strong>.
* Define several constructors that take different sets of arguments (full laptop + battery information or only part of it). Use proper variable types.
* Add a method in the <strong>Laptop</strong> class that displays information about the given instance
	-	Tip: override the <strong>ToString()</strong> method
*	Put <strong>validation</strong> in all property setters and constructors. String values cannot be empty, and numeric data cannot be negative. Throw exceptions when improper data is entered.

<p>
<strong>Sample laptop description (full):</strong><br>
<strong>Model</strong> Lenovo Yoga 2 Pro<br>
<strong>Manufacturer</strong> Lenovo<br>
<strong>Processor</strong> Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache) <br>
<strong>RAM</strong> 8 GB <br>		
<strong>Graphics card</strong> Intel HD Graphics 4400		
<strong>HDD</strong> 128GB SSD		
<strong>Screen</strong>	13.3" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display		
<strong>Battery</strong> Li-Ion, 4-cells, 2550 mAh		
<strong>Battery</strong> life 4.5 hours		
<strong>Price</strong> 2259.00 lv.	
<br>
<strong>Sample laptop description (mandatory properties only)</strong>
<strong>Model</strong> HP 250 G2
<strong>Price</strong> 699.00 lv.

<p>
#### Problem 3.	PC Catalog
Define a class <strong>Computer</strong> that holds <strong>name, several components</strong> and <strong>price</strong>. The components (processor, graphics card, motherboard, etc.) should be objects of class <strong>Component</strong>, which holds <strong>name, details</strong> (optional) and <strong>price</strong>. 

* Define several constructors that take different sets of arguments. Use proper variable types. Use properties to validate the data. Throw exceptions when improper data is entered.
* Add a method in the Computer class that displays the <strong>name</strong>, each of the <strong>components' name</strong> and <strong>price</strong> and the <strong>total computer price</strong>. The total price is the <strong>sum of all components' price</strong>. Print the prices in BGN currency format.
* Create several Computer objects, <strong>sort them by price</strong>, and print them on the console using the created display method.

#### Problem 4.** Software University Learning System
Define a class <strong>Person</strong> and the classes <strong>Trainer, Student</strong>. There are two types of trainers – <strong>Junior</strong> and <strong>Senior Trainer</strong>. There are three types of Students – <strong>Graduate, Current</strong> and Dropout Student. There are two types of Current Students – **Online** and **Onsite Student**. Implement the given structure below. **A class down in the hierarchy should implement the fields, properties and methods of the classes above it.** (Tip: Use **Inheritance** to achieve code reusability). The classes should implement the following fields/methods:
* **Person** – fields **first name, last name, age**
	-	**Trainer** – method **CreateCourse([courseName])** that prints that the course has been created
		* Senior Trainer – method **DeleteCourse([courseName])** that prints that the course has been deleted
	-	**Student** – fields **student number, average grade**
		* **Current Student** – field **current course**
		- **Onsite Student** – field **number of visits**
		- **Dropout Student** – field **dropout reason**, method **Reapply()** that prints all information about the student and the dropout reason
		
Write a class **SULSTest** that tests the implemented class structure. Create a **list of objects from each class**. Extract only the **Current Students, sort them by average grade** and **print information** about each one on the console.
Tip: Use the LINQ extension methods **Where()** and **OrderBy()** with lambda expressions.
