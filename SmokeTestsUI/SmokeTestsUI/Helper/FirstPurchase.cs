using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Tests.Pages
{
    class FirstPurchaser : BasePage
    {
        public FirstPurchaser(IWebDriver Browser) : base(Browser)
        {

        }
        #region Methods
        //Метод выполнения первой покупки клиентом
        public void FirstPurchaserClient()
        {
            new PeoplePage(Browser)
            
            .ClickUpgadeAccountBtn()
            .VisaCardNumber()
            .CardMonthField()
            .CardMonthChoice()
            .CardYearField()
            .CardYearChoice()
            .CardCVV()
            .CardHolder()
            .ClickPurchaseCreditsBtn();

        }
        #endregion
    }
}