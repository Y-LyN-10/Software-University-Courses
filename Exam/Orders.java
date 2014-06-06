import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.Set;
import java.util.TreeMap;

public class Orders {

	public static void main(String[] args) {

		Scanner input = new Scanner(System.in);

		int n = Integer.parseInt(input.nextLine());

		// lamer String[] something = input.nextLine().split(" ");
		// solution System.out.println(something[2] + ": " + something[0] + " "
		// + something[1]);
		// Expected output: apples: steve 8

		HashMap<String, TreeMap<String, Integer>> orders = new HashMap<String, TreeMap<String, Integer>>();
				
		for (int i = 0; i < n; i++) {

			String line = input.nextLine();
			String[] singleOrder = line.split(" ");
			String name = singleOrder[0];
			
			int howMany = Integer.parseInt(singleOrder[1]);
			String product = singleOrder[2];
			
			if (orders.containsKey(product)) {
				howMany += Integer.parseInt(singleOrder[1]);
			}

			TreeMap<String, Integer> numsAndNames = orders.get(product);

			if (numsAndNames == null) {
				numsAndNames = new TreeMap<String, Integer>();
				orders.put(product, numsAndNames);
			}
			numsAndNames.put(name, howMany);
		}

		Set<String> products = orders.keySet();
		
		//print result
		for (String product : products) {
			System.out.printf("%s: ", product);
			TreeMap<String, Integer> numsAndNames = orders.get(product);
			
			for (Map.Entry<String, Integer> entry : numsAndNames.entrySet()) {
				String name = entry.getKey();
				int howMany = entry.getValue();
				
				System.out.printf("%s %s", name, howMany);
				if(!(name.equals(numsAndNames.lastKey()))){
					System.out.printf(", ");					
				}
			}
			System.out.println("");
		}
	}
}

/*
 * 
 * steve 8 apples maria 3 bananas kiro 3 bananas kiro 9 apples maria 2 apples
 * steve 4 apples kiro 1 bananas kiro 1 apples
 */