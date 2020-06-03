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
        var password = "654321";

        new MainPage(Browser)
          .ClickSignInWithEmailBtn()
          .YourEmailField(email)
          .PasswordField(password)
          .SignInBtn();

        new PeoplePage(Browser)
           .SandwichInPopup()
           .MenuProfile();

             var UserId = "14043278542";
             Assert.That(Browser.Url, Does.Contain(UserId), "Id авторизованного клиента неверный");
         }

    [Test]
    public void SingInFailedWithEmptyGenderAndDateOfBirthTest()
    {
         new MainPage(Browser)
            .ClickSignInWithEmailBtn()
            .ClickCreateYourAccountBtn()
            .NameOrNicknameField()
            .ReadEmailField()
            .NewPasswordField()
            .CreateAccountBtn()
            .NextBtn();

             Assert.That(new AboutYouFormPage(Browser).AboutYouFormYourGenderDisplayed(), Is.True, "Не отображается подсказка для поля выбора пола");
             Assert.That(new AboutYouFormPage(Browser).AboutYouFormYourGender(), Does.Contain("Select your gender"), "Неправильная подсказка для поля выбора пола");

             Assert.That(new AboutYouFormPage(Browser).AboutYouFormGenderPreferenceDisplayed(), Is.True, "Не отображается подсказка для поля выбора предпочитаемого пола");
             Assert.That(new AboutYouFormPage(Browser).AboutYouFormGenderPreference(), Does.Contain("Select gender preference"), "Неправильная подсказка для поля выбора предпочитаемого пола");

             Assert.That(new AboutYouFormPage(Browser).AboutYouFormYourDateOfBirthDisplayed(), Is.True, "Не отображается подсказка для полей указания дня рождения");
             Assert.That(new AboutYouFormPage(Browser).AboutYouFormYourDateOfBirth(), Does.Contain("Select your date of birth"), "Неправильная подсказка для полей указания дня рождения");
         }

    [Test]
     public void RegistrationUserTest()
     {
         new RegistrationTestUser(Browser)
         .RegistrationNewTestUser();

    Assert.That(new PeoplePage(Browser).ClickPopupControlUnknownDisplayed(), Is.True, "Не отображается блок для выбора настроения");
        }
    }
}
