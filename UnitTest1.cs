using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Xunit;

namespace AutomacaoSite
{
    public class procurandoDory
    {
        [Fact]
        public void abrirImagemPersonagemDoryGoogle()
        {
            IWebDriver navegador = new ChromeDriver();
            navegador.Manage().Window.Maximize();

            Thread.Sleep(2000);
            navegador.Navigate().GoToUrl("https://www.google.com.br/");

            Thread.Sleep(2000);
            navegador.FindElement(By.Name("q")).SendKeys("imagens dory procurando nemo" + Keys.Enter);

            Thread.Sleep(2000);
            navegador.FindElement(By.XPath("//div[@class='fWhgmd'][1]")).Click();

            Thread.Sleep(2000);
            navegador.FindElement(By.XPath("//span[@class='pM4Snf'][1]")).Click();

            Thread.Sleep(2000);


            navegador.Quit();
            navegador.Dispose();

        }
    }
}
