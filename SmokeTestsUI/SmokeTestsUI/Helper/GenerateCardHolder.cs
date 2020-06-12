using OpenQA.Selenium;
using System;

namespace Tests.Pages
{
    class GenerateCardHolder : BasePage
    {
        public GenerateCardHolder(IWebDriver Browser) : base(Browser)
        {

        }
        #region Methods
        //Метод генерации уникального CardHolder
        public String GenerateNewCardHolder()
        {
            var cardholder = RandomText();
            return cardholder;
        }
        // Метод генерации рандомной строки из букв
        public String RandomText()
        {
            Random rnd = new Random();
            String text = "";
            Char[] pwdChars = new Char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            for (int i = 0; i < 20; i++)
                text += pwdChars[rnd.Next(0, 25)];
            return text;
        }
        #endregion
    }
}