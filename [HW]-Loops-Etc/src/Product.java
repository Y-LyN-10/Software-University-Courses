import java.math.BigDecimal;

public class Product implements Comparable<Product> {

	private String name;
	private BigDecimal price;

	public Product(String name, BigDecimal price) {
		this.name = name;
		this.price = price;
	}

	public String getName() {
		return this.name;
	}

	public BigDecimal getPrice() {
		return this.price;
	}

	@Override
	public String toString() {
		return this.price + " " + this.name;
	}

	@Override
	public int compareTo(Product otherProduct) {
		return this.price.compareTo(otherProduct.getPrice());
	}
}