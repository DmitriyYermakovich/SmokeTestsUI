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
            .NameOrNicknameField()
            .ReadEmailField()
            .NewPasswordField()
            .CreateAccountBtn()
            .Month()
            .MonthChoice()
            .Day()
            .DayChoice()
            .Year()
            .YearChoice()
            .IconMal()
            .IconFem()
            .NextBtn()
            .ApproveBigBtn()
            .ApproveBigTwoBtn()
            .ApproveBitBtn()
            .PhotosFormApproveBtn();
        }
        #endregion
    }
}
