// Problem 6. Sum Two Numbers
// write a program SumTwoNumbers.java that enters two integers 
// from the console, calculates and prints their sum. Search in 
// Internet to learn how to read numbers from the console. 

import java.util.Scanner;

public class _06_SumTwoNumbers {
	
	public static void main(String[] args) {
		
		try(Scanner input = new Scanner(System.in)){
	
			System.out.print("a = ");
			int a = input.nextInt();
			System.out.print("b = ");
			int b = input.nextInt();
		
			System.out.println(a + b);	
		}
	}
}	
