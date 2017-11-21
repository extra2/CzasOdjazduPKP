using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Web.Script.Serialization;
using OpenQA.Selenium.Remote;
using System.Windows.Forms;

namespace CzasOdjazdu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Z: ");
            var z_z = Console.ReadLine();
            Console.Write("Do: ");
            var z_do = Console.ReadLine();
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(service);
            driver.Url = "http://rozklad-pkp.pl/?utm_source=pkppl&utm_medium=boksrozklad&utm_campaign=pkppl";
            try
            {
                driver.FindElement(By.Name("REQ0JourneyStopsS0G")).SendKeys(z_z);
                System.Threading.Thread.Sleep(1000);
                driver.FindElement(By.Name("REQ0JourneyStopsZ0G")).SendKeys(z_do);
                System.Threading.Thread.Sleep(1000);
                driver.FindElement(By.XPath("//*[@id=\"accordion\"]/div[2]/a")).Click();
                System.Threading.Thread.Sleep(1000);
                driver.FindElement(By.XPath("//*[@id=\"collapseTwo\"]/fieldset/div[1]/div/label[2]/div")).Click();
                System.Threading.Thread.Sleep(1000);
                driver.FindElement(By.XPath("//*[@id=\"collapseTwo\"]/fieldset/div[2]/div/label[2]/div")).Click();
                System.Threading.Thread.Sleep(1000);
                driver.FindElement(By.XPath("//*[@id=\"collapseTwo\"]/fieldset/div[3]/div/label[2]/div")).Click();
                driver.FindElement(By.Name("singlebutton")).Click();
                System.Threading.Thread.Sleep(5000);
                driver.FindElement(By.XPath("//*[@id=\"content\"]/div/div[1]/div[3]/form[1]/fieldset/ul/li[3]/a/div")).Click();
                System.Threading.Thread.Sleep(1000);
            }
            catch (Exception)
            {

                MessageBox.Show("Sth went wrong try to zoom out brwoser window.");
                driver.Quit();
            }
            
        }
    }
}
