using OpenQA.Selenium;
using System;
using Tests.Pages;

namespace Helper
{
    class GenerateCardNumber : BasePage
    {
        public GenerateCardNumber(IWebDriver Browser) : base(Browser)
        {

        }
        #region Methods
        //Метод генерации уникального номера карты visa
        public String GenerateVisaCardNumber()
        {
            var visanumber = RandomText();
            return "4" + visanumber;
        }
        // Метод генерации рандомной строки из цифр
        public String RandomText()
        {
            Random rnd = new Random();
            String text = "";
            Char[] pwdChars = new Char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 0; i < 20; i++)
                text += pwdChars[rnd.Next(0, 9)];
            return text;
        }
        #endregion
    }
}