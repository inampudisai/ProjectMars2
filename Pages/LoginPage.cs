using InternshipTask1.Utilities;
using OpenQA.Selenium;
using ProjectMars;

public class LoginPage : CommonDriver
{
    public void LoginSteps()
    {

        //click on signin button
        IWebElement signIn = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
        signIn.Click();
        Thread.Sleep(1000);

        

        // enter username in textbox
        IWebElement username = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
        username.SendKeys("anjani5506eluri@gmail.com");

        // enter password
        Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[2]/div/div/div[1]/div/div[2]/input", 7);
        IWebElement password = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
        password.SendKeys("@Anju@1668");

        // click on login        
        Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[2]/div/div/div[1]/div/div[4]/button", 7);
        IWebElement loginbutton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
        loginbutton.Click();

    }
}

