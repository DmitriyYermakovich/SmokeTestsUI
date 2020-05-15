using NUnit.Framework;
using Tests.Pages;
using System;
using OpenQA.Selenium;

namespace Tests
{

    public class SmokeTests : BaseTest
    {
        [Test]
        public void AuthorizationUserTest()
        {
            var email = "dcUMT_1581089986812_test@dating.com";
            new MainPage(Browser)
            .ClickSignInWithEmailBtn()
            .YourEmailField(email)
            .PasswordField()
            .SignInBtn()
            .SandwichInPopup()
            .MenuProfile();

            var UserId = "14043278542";
            Assert.That(Browser.Url, Does.Contain(UserId), "Id авторизованного клиента неверный");
        }

        [Test]
        public void SingInFailedWithEmptyGenderAndDateOfBirth()
        {
            new MainPage(Browser)
                .ClickSignInWithEmailBtn()
                .ClickCreateYourAccountBtn()
                .NameOrNicknameField()
                .ReadEmailField()
                .NewPasswordField()
                .CreateAccountBtn()
                .NextBtn();

            Assert.That(new MainPage(Browser).AboutYouFormYourGenderDisplayed(), Is.True, "Не отображается подсказка для поля выбора пола");
            Assert.That(new MainPage(Browser).AboutYouFormYourGender(), Does.Contain("Select your gender"), "Неправильная подсказка для поля выбора пола");

            Assert.That(new MainPage(Browser).AboutYouFormGenderPreferenceDisplayed(), Is.True, "Не отображается подсказка для поля выбора предпочитаемого пола");
            Assert.That(new MainPage(Browser).AboutYouFormGenderPreference(), Does.Contain("Select gender preference"), "Неправильная подсказка для поля выбора предпочитаемого пола");

            Assert.That(new MainPage(Browser).AboutYouFormYourDateOfBirthDisplayed(), Is.True, "Не отображается подсказка для полей указания дня рождения");
            Assert.That(new MainPage(Browser).AboutYouFormYourDateOfBirth(), Does.Contain("Select your date of birth"), "Неправильная подсказка для полей указания дня рождения");
        }

        [Test]
        public void RegistrationUser()
        {
            new MainPage(Browser)
            .RegistrationNewTestUser();
            //new MainPage(Browser)
            /*.ClickSignInWithEmailBtn()
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
            .PhotosFormApproveBtn();*/

            Assert.That(new MainPage(Browser).PopupControlUnknownDisplayed(), Is.True, "Не отображается блок для выбора настроения");
        }
    }
}