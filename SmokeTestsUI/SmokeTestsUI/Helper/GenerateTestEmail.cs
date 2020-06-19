using OpenQA.Selenium;
using System;
using Tests.Pages;

namespace Helper
{
    class GenerateTestEmail : BasePage
    {
        public GenerateTestEmail(IWebDriver Browser) : base(Browser)
        {

        }
        #region Methods
        //Метод генерации уникального email при регистрации пользователя на сайте
        public String GenerateNewTestEmail()
        {
            var emailSeed = RandomText();
            return "newtestemail+" + emailSeed + "@sdventures.com";
        }
        // Метод генерации рандомной строки из букв и цифр
        public String RandomText()
        {
            Random rnd = new Random();
            String text = "";
            Char[] pwdChars = new Char[36] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 0; i < 20; i++)
                text += pwdChars[rnd.Next(0, 35)];
            return text;
        }
        #endregion
    }
}
