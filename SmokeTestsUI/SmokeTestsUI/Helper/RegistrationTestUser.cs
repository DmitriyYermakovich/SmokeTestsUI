using OpenQA.Selenium;
using Tests.Pages;

namespace Helper
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
            .TypingNameOrNicknameField()
            .TypingReadEmailField()
            .TypingNewPasswordField()
            .ClickCreateAccountBtn()
            .SelectMonthOfBirth()
            .SelectDayOfBirth()
            .SelectYearOfBirth()
            .SelectOwnGenderMal()
            .SelectPrefferedGenderFemale()
            .ClickNextBtn()
            .ClickApproveBigBtn()
            .ClickApproveBigTwoBtn()
            .ClickApproveBitBtn()
            .ClickPhotosFormApproveBtn();
        }
        #endregion
    }
}
