import java.util.Scanner;

public class CountBeers {

	public static void main(String[] args) {
		
		final int BEERS_IN_STACK = 20;
		
		try (Scanner input = new Scanner(System.in)){
			
			int totalStacks = 0;
			int totalBeers = 0;
			
			int currentCount = input.nextInt(); // 4
			String whatToCount = input.nextLine().trim(); //stacks
			
			while (input.hasNextInt()) {

				if (whatToCount.equals("stacks")) {
					totalStacks += currentCount;
				} 
				else if (whatToCount.equals("beers")) {
					totalBeers += currentCount;
				}

				currentCount = input.nextInt();
				whatToCount = input.nextLine().trim();
			}	
			
			if (whatToCount.equals("stacks")) {
				totalStacks += currentCount;
			} 
			else if (whatToCount.equals("beers")) {
				totalBeers += currentCount;
			}
			
			if (totalBeers >= BEERS_IN_STACK) {
				while (totalBeers >= BEERS_IN_STACK){
					totalBeers -= BEERS_IN_STACK;
					totalStacks++;
				}
			}
			
			System.out.printf("%d stacks + %s beers", totalStacks, totalBeers);
		}
	}
}

//4 stacks
//12 beers
//10 beers
//1 stacks
//1 beers
//End

//41 beers
//1 stacks
//19 beers
//End
