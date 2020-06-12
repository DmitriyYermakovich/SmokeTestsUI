using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Tests.Pages
{
    class RegistrationTestUser : BasePage
    {
        public RegistrationTestUser(IWebDriver Browser) : base(Browser)
        {

        }
        #region Methods
        //Метод регистрации нового пользователя на сайте
        public void RegistrationNewTestUser()
        {
            new MainPage(Browser)

            .ClickSignInWithEmailBtn()
            .ClickCreateYourAccountBtn()
            .InputNameOrNicknameField()
            .InputReadEmailField()
            .InputNewPasswordField()
            .ClickCreateAccountBtn()
            .OpenDropdownListMonth()
            .MonthChoice()
            .OpenDropdownListDay()
            .DayChoice()
            .OpenDropdownListYear()
            .YearChoice()
            .ClickIconMal()
            .ClickIconFem()
            .ClickNextBtn()
            .ClickApproveBigBtn()
            .ClickApproveBigTwoBtn()
            .ClickApproveBitBtn()
            .ClickPhotosFormApproveBtn();
        }
        #endregion
    }
}
