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
public class SuiteTests : IDisposable
{
    public IWebDriver driver { get; private set; }
    public IDictionary<String, Object> vars { get; private set; }
    public IJavaScriptExecutor js { get; private set; }
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
    public void CT01Campos()
    {
        driver.Navigate().GoToUrl("https://rafajms.github.io/ProjetoAlmoxarifadoMain/?authuser=0/ProjetoAlmoxarifadoMain/?authuser=0");
        driver.Manage().Window.Size = new System.Drawing.Size(945, 1012);
        driver.FindElement(By.Id("inpNumero")).SendKeys("1");
        driver.FindElement(By.Id("inpNumero")).Click();
        driver.FindElement(By.Id("idDepartamento")).Click();
        driver.FindElement(By.Id("idDepartamento")).SendKeys("1");
        driver.FindElement(By.Id("categoriaMotivo")).Click();
        {
            var dropdown = driver.FindElement(By.Id("categoriaMotivo"));
            dropdown.FindElement(By.XPath("//option[. = 'Gest�o']")).Click();
        }
        driver.FindElement(By.Id("Motivo")).Click();
        {
            var dropdown = driver.FindElement(By.Id("Motivo"));
            dropdown.FindElement(By.XPath("//option[. = 'Equipamento Permanente']")).Click();
        }
        driver.FindElement(By.CssSelector(".grupoPrioridade:nth-child(2)")).Click();
        driver.FindElement(By.Id("medio")).Click();
        driver.FindElement(By.Id("CodigoProtudo")).Click();
        driver.FindElement(By.Id("CodigoProtudo")).SendKeys("1");
        driver.FindElement(By.Id("btnInserirItens")).Click();
        driver.FindElement(By.Id("btnGravar")).Click();
    }
    public void CT02CamposCor()
    {
        driver.Navigate().GoToUrl("https://rafajms.github.io/ProjetoAlmoxarifadoMain/?authuser=0");
        driver.Manage().Window.Size = new System.Drawing.Size(945, 1012);
        driver.FindElement(By.Id("idDepartamento")).Click();
        driver.FindElement(By.Id("departamento")).Click();
        driver.FindElement(By.Id("dataRequisicao")).Click();
        driver.FindElement(By.Id("idFuncionario")).Click();
        driver.FindElement(By.Id("NomeFuncionario")).Click();
        driver.FindElement(By.Id("cargo")).Click();
        driver.FindElement(By.Id("categoriaMotivo")).Click();
        driver.FindElement(By.Id("Motivo")).Click();
        driver.FindElement(By.Id("CodigoProtudo")).Click();
        driver.FindElement(By.Id("DescricaoProtudo")).Click();
        driver.FindElement(By.Id("Quantidade")).Click();
    }
    public void CT03Campos()
    {
        driver.Navigate().GoToUrl("https://rafajms.github.io/ProjetoAlmoxarifadoMain/?authuser=0");
        driver.Manage().Window.Size = new System.Drawing.Size(945, 1012);
        driver.FindElement(By.Id("inpNumero")).Click();
        driver.FindElement(By.Id("inpNumero")).SendKeys("1");
        driver.FindElement(By.Id("idDepartamento")).Click();
        driver.FindElement(By.Id("idDepartamento")).SendKeys("1");
        driver.FindElement(By.Id("dataRequisicao")).Click();
        driver.FindElement(By.Id("dataRequisicao")).SendKeys("0002-11-11");
        driver.FindElement(By.Id("dataRequisicao")).SendKeys("0020-11-11");
        driver.FindElement(By.Id("dataRequisicao")).SendKeys("0202-11-11");
        driver.FindElement(By.Id("dataRequisicao")).SendKeys("2024-11-11");
        driver.FindElement(By.Id("idFuncionario")).Click();
        driver.FindElement(By.Id("idFuncionario")).SendKeys("1");
        driver.FindElement(By.CssSelector(".grupo7 > span")).Click();
        driver.FindElement(By.Id("categoriaMotivo")).Click();
        {
            var dropdown = driver.FindElement(By.Id("categoriaMotivo"));
            dropdown.FindElement(By.XPath("//option[. = 'Gest�o']")).Click();
        }
        driver.FindElement(By.Id("Motivo")).Click();
        driver.FindElement(By.CssSelector("#legenda > div:nth-child(1) > p")).Click();
        driver.FindElement(By.Id("Motivo")).Click();
        {
            var dropdown = driver.FindElement(By.Id("Motivo"));
            dropdown.FindElement(By.XPath("//option[. = 'Equipamento Permanente']")).Click();
        }
        driver.FindElement(By.Id("medio")).Click();
        driver.FindElement(By.Id("CodigoProtudo")).Click();
        driver.FindElement(By.Id("CodigoProtudo")).SendKeys("1,2");
        driver.FindElement(By.Id("DescricaoProtudo")).Click();
        driver.FindElement(By.Id("DescricaoProtudo")).SendKeys("2");
        {
            var element = driver.FindElement(By.Id("Estoque"));
            Actions builder = new Actions(driver);
            builder.DoubleClick(element).Perform();
        }
        driver.FindElement(By.CssSelector(".linhaAdicionarItens")).Click();
        driver.FindElement(By.CssSelector(".linhaAdicionarItens")).Click();
        driver.FindElement(By.Id("Quantidade")).Click();
        driver.FindElement(By.CssSelector(".linhaAdicionarItens")).Click();
        driver.FindElement(By.Id("CodigoProtudo")).SendKeys("1");
        driver.FindElement(By.Id("Quantidade")).Click();
        driver.FindElement(By.Id("Quantidade")).Click();
        driver.FindElement(By.Id("Quantidade")).SendKeys("2");
        driver.FindElement(By.Id("btnGravar")).Click();
    }

}