using OpenQA.Selenium;
using System;
using Tests.Pages;

namespace Helper
{
    class GenerateRandomLetter : BasePage
    {
        public GenerateRandomLetter(IWebDriver Browser) : base(Browser)
        {

        }
        #region Methods
        // Метод генерации рандомной строки из букв
        public String GetRandomLetter(int stringLength)
        {
            Random rnd = new Random();
            String letter = "";
            Char[] pwdChars = new Char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            for (int i = 0; i < stringLength; i++)
                letter += pwdChars[rnd.Next(0, 25)];
            return letter;
        }
        #endregion
    }
}