import java.lang.*;
import java.text.*;
import java.util.*;

public class Category {
	private int CategoryID;
	private String CategoryName;
	private boolean IsActive;
	public int getCategoryID() {
		return CategoryID;
	}

	//this is a testing for commitment
	public void setCategoryID(int categoryID) {
		CategoryID = categoryID;
	}
	public String getCategoryName() {
		return CategoryName;
	}
	public void setCategoryName(String categoryName) {
		CategoryName = categoryName;
	}
	public boolean isIsActive() {
		return IsActive;
	}
	public void setIsActive(boolean isActive) {
		IsActive = isActive;
	}
	
}
