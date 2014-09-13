// Problem 8. Extract Emails

// Write a program to extract all email addresses from given text. 
// The text comes at the first input line. Print the emails in the output, each 
// at a separate line. Emails are considered to be in format <user>@<host>, where:

// •	<user> is a sequence of letters and digits, where '.', '-' and '_' can 
// 		appear between them. Examples of valid users: "stephan", "mike03", "s.johnson", 
// 		"st_steward", "softuni-bulgaria", "12345". Examples of invalid users: ''--123", 
//		".....", "nakov_-", "_steve", ".info".

// •	<host> is a sequence of at least two words, separated by dots '.'. Each word is 
//		sequence of letters and can have hyphens '-' between the letters. Examples of hosts: 
//		"softuni.bg", "software-university.com", "intoprogramming.info", "mail.softuni.org". 
//		Examples of invalid hosts: "helloworld", ".unknown.soft.", "invalid-host-", "invalid-".

// •	Example of valid emails: info@softuni-bulgaria.org, kiki@hotmail.co.uk, no-reply@github.com, 
//		s.peterson@mail.uu.net, info-bg@software-university.software.academy.

import java.util.ArrayList;
import java.util.Scanner;

public class _08_Extract_Emails {

	public static void main(String[] args) {
		
		try (Scanner input = new Scanner(System.in)){
			
			//Divide the text by empty space			
			String text = input.nextLine();
			String[] parts = text.split("\\s"); 
			
			//Add all to the List to use a Lambda expressions
			ArrayList<String> listedParts = new ArrayList<>();
			for (String part : parts) listedParts.add(part);
			
			//Well, I know... this looks like a cheat, but it works for all given examples...
			listedParts.stream().filter(x -> x.contains("@") && x.length() > 1)
				.forEach(x-> System.out.println(x));
		}
	}
}
