import java.lang.*;
import java.text.*;
import java.util.*;

public class Product {
	private int ProductID;
	private int quanity;
	private String StorageLocation;
	private int NumberofDaysToExpriement;
	private Date inStockdate;
	private ProductDetails productDetail;
	public int getProductID() {
		return ProductID;
	}
	public void setProductID(int productID) {
		ProductID = productID;
	}
	public int getQuanity() {
		return quanity;
	}
	public void setQuanity(int quanity) {
		this.quanity = quanity;
	}
	public String getStorageLocation() {
		return StorageLocation;
	}
	public void setStorageLocation(String storageLocation) {
		StorageLocation = storageLocation;
	}
	public int getNumberofDaysToExpriement() {
		return NumberofDaysToExpriement;
	}
	public void setNumberofDaysToExpriement(int numberofDaysToExpriement) {
		NumberofDaysToExpriement = numberofDaysToExpriement;
	}
	public Date getInStockdate() {
		return inStockdate;
	}
	public void setInStockdate(Date inStockdate) {
		this.inStockdate = inStockdate;
	}
	public ProductDetails getProductDetail() {
		return productDetail;
	}
	public void setProductDetail(ProductDetails productDetail) {
		this.productDetail = productDetail;
	}
	public Unit getUnit() {
		return unit;
	}
	public void setUnit(Unit unit) {
		this.unit = unit;
	}
	public Category getCategory() {
		return category;
	}
	public void setCategory(Category category) {
		this.category = category;
	}
	private Unit unit;
	private Category category;


}
