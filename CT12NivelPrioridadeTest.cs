// Generated by Selenium IDE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using Xunit;
public class SuiteTests : IDisposable {
  public IWebDriver driver {get; private set;}
  public IDictionary<String, Object> vars {get; private set;}
  public IJavaScriptExecutor js {get; private set;}
  public SuiteTests()
  {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<String, Object>();
  }
  public void Dispose()
  {
    driver.Quit();
  }
  [Fact]
  public void CT12NivelPrioridade() {
    driver.Navigate().GoToUrl("https://rafajms.github.io/ProjetoAlmoxarifadoMain/?authuser=0");
    driver.Manage().Window.Size = new System.Drawing.Size(945, 1012);
    driver.FindElement(By.Id("radioPrioridade")).Click();
    driver.FindElement(By.Id("urgente")).Click();
    driver.FindElement(By.Id("medio")).Click();
    driver.FindElement(By.CssSelector("#legenda > div:nth-child(1) > p")).Click();
  }
}