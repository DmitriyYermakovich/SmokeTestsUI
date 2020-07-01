using OpenQA.Selenium;
using System;
using Tests.Pages;

namespace Helper
{
    class GenerateRandomInt : BasePage
    {
        public GenerateRandomInt(IWebDriver Browser) : base(Browser)
        {

        }
        #region Methods
        // Метод генерации рандомной строки из цифр
        public String GetRandomInt(int stringLength)
        {
            Random rnd = new Random();
            String number = "";
            Char[] pwdChars = new Char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 0; i < stringLength; i++)
                number += pwdChars[rnd.Next(0, 10)];
            return number;
        } 
        #endregion
    }
}