public class SearchTest
{

	driver.Manage.Timeouts().ImplicitWait = Timespan.FromSeconds(0.1)
	public void test_CheckInputAndSearchBtnExist()
	{
		if(driver.findElements(By.Id("search-input")).size() != 0)
		{ Console.WriteLine("input field exists.");}
		else{Console.WriteLine("Input field doesnot exist);}
		if(driver.findElements(By.Id("search-button")).size() != 0)
		{ Console.WriteLine("Search Button exists.");}
		else{Console.WriteLine("Search button doesnot exist");}
	}

	public void test_CheckEmptyQueryIsForbidden()
	{
		driver.findElement(By.Id("search-input")).clear();
		driver.findElement(By.Id("search-button").SendClick();
		if(driver.findElement(By.Id("error-empty-query")).isDisplayed()
		&& driver.findElement(By.Id("error-empty-query")).GetText().Equals("Provide some query"))
		{ Console.WriteLine("Provide some query error message is displayed.");}
		else{Console.WriteLine("No Message is displayed");}
	}

	public void test_CheckifAtleastOneislandReturned()
	{
		driver.findElement(By.Id("search-input")).SendKeys("isla");
		driver.findElement(By.Id("search-button").SendClick();
		
		if(driver.findElements(By.xpath("//ul[@id='search-results']/li")).size() > 0)
		{ Console.WriteLine("Atleast one island is returned");}
		else{Console.WriteLine("No island is returned");}
	}

	public void test_CheckFeedbackWhenNoresults()
	{
		driver.findElement(By.Id("search-input")).SendKeys("castle");
		driver.findElement(By.Id("search-button").SendClick();
		
		if(driver.findElements(By.xpath("//ul[@id='search-results']/li")).size() == 0
		&& driver.findElement(By.Id("error-no-results")).isDisplayed()
		&& driver.findElement(By.Id("error-no-results")).GetText().Equals("No results"))
		{ Console.WriteLine("Displayed No results");}
		else{Console.WriteLine("Did not display any feedback");}
	}

	public void test_GetOneResultForPortRoyal()
	{
		driver.findElement(By.Id("search-input")).SendKeys("port royal");
		driver.findElement(By.Id("search-button").SendClick();
		
		if(driver.findElements(By.xpath("//ul[@id='search-results']/li")).size() == 1
		&& driver.findElement(By.xpath("//ul[@id='search-results']/li")).GetText().Equals("Port Royal"))
		{ Console.WriteLine("Port Royal is returned");}
		else{Console.WriteLine("Port Royal is not returned");}
	}

}