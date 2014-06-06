import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.time.format.DateTimeParseException;
import java.time.temporal.ChronoUnit;
import java.util.Scanner;

// Problem 7. Days between Two Dates
// Write a program to calculate the difference between two dates in number of days. 
// The dates are entered at two consecutive lines in format day-month-year. 
// Days are in range [1…31]. Months are in range [1…12]. Years are in range [1900…2100].

public class _7_Days_Between_2_Dates {

	public static void main(String[] args) {

		try (Scanner input = new Scanner(System.in)) {

			System.out.println("Enter first date (day-month-year):");
			LocalDate firstDate = LocalDate.parse(input.nextLine(), DateTimeFormatter.ofPattern("d-M-yyyy"));

			System.out.println("Enter second date (day-month-year):");
			LocalDate secondDate = LocalDate.parse(input.nextLine(), DateTimeFormatter.ofPattern("d-M-yyyy"));

			long daysBetweenDates = ChronoUnit.DAYS.between(firstDate, secondDate);

			System.out.println("Days between " + firstDate + " and " + secondDate + " : " +
					daysBetweenDates + " days");

		} catch (DateTimeParseException e) {
			System.out.println("Wrong format.");
		}	
	}
}
