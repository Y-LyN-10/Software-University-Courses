import java.math.BigDecimal;
import java.util.Scanner;
import java.util.TreeSet;

public class LargestNumbers {

	public static void main(String[] args) {
	
		try (Scanner input = new Scanner(System.in)){
			
			int n = Integer.parseInt(input.nextLine()); //number of lines
			TreeSet<BigDecimal> numbers = new TreeSet<BigDecimal>();
			
			for (int i = 0; i < n; i++) {	

				String nextNum = input.nextLine().replace(",", ".");
	
				BigDecimal big = new BigDecimal(nextNum);
				numbers.add(big);
			}
			
			String lastNumber = numbers.last().toPlainString();
			System.out.println(lastNumber);
			numbers.remove((BigDecimal)numbers.last());
			
			if(!(numbers.isEmpty())){
				System.out.println(numbers.last().toPlainString());
				lastNumber = numbers.last().toPlainString();
				numbers.remove((BigDecimal)numbers.last());
			}
			else if(numbers.isEmpty() && n > 1){
				System.out.println(lastNumber);
			}
			
			if(!(numbers.isEmpty())){
				System.out.println(numbers.last().toPlainString());
			}
			else if(numbers.isEmpty() && n > 2){
				System.out.println(lastNumber);
			}
		}
	}
}
