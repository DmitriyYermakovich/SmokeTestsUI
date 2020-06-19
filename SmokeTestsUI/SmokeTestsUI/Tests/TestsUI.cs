using NUnit.Framework;
using Tests.Pages;
using Helper;

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
          .TypingYourEmailField(email)
          .TypingPasswordField(password)
          .ClickSignInBtn();

        new PeoplePage(Browser)
           .ClickSandwichInPopup()
           .ClickMenuProfile();

             var UserId = "14043278542";
             Assert.That(Browser.Url, Does.Contain(UserId), "Id авторизованного клиента неверный");
         }

    [Test]
    public void SingInFailedWithEmptyGenderAndDateOfBirthTest()
    {
         new MainPage(Browser)
            .ClickSignInWithEmailBtn()
            .ClickCreateYourAccountBtn()
            .TypingNameOrNicknameField()
            .TypingReadEmailField()
            .TypingNewPasswordField()
            .ClickCreateAccountBtn()
            .ClickNextBtn();

             Assert.That(new AboutYouFormPage(Browser).GetInvalidTextYouGenderOnAboutYouFormDisplayed(), Is.True, "Не отображается подсказка для поля выбора пола");
             Assert.That(new AboutYouFormPage(Browser).GetInvalidTextYouGenderOnAboutYouForm(), Does.Contain("Select your gender"), "Неправильная подсказка для поля выбора пола");

             Assert.That(new AboutYouFormPage(Browser).GetInvalidTextGenderPreferenceOnAboutYouFormDisplayed(), Is.True, "Не отображается подсказка для поля выбора предпочитаемого пола");
             Assert.That(new AboutYouFormPage(Browser).GetInvalidTextGenderPreferenceOnAboutYouForm(), Does.Contain("Select gender preference"), "Неправильная подсказка для поля выбора предпочитаемого пола");

             Assert.That(new AboutYouFormPage(Browser).GetInvalidTextDateOfBirthOnAboutYouFormDisplayed(), Is.True, "Не отображается подсказка для полей указания дня рождения");
             Assert.That(new AboutYouFormPage(Browser).GetInvalidTextDateOfBirthOnAboutYouForm(), Does.Contain("Select your date of birth"), "Неправильная подсказка для полей указания дня рождения");
         }

    [Test]
     public void RegistrationUserTest()
     {
         new RegistrationTestUser(Browser)
         .RegistrationNewTestUser();

    Assert.That(new PeoplePage(Browser).ClickPopupControlUnknownDisplayed(), Is.True, "Не отображается блок для выбора настроения");
        }

        [Test]
        public void FirstPurchaseTest()
        {
            new RegistrationTestUser(Browser)
            .RegistrationNewTestUser();

            new FirstPurchaser(Browser)
            .FirstPurchaserClient();

            Assert.That(new PeoplePage(Browser).BtnRefillAccountDisplayed(), Is.True, "Отсутствует кнопка 'Refill account'");
            Assert.That(new PeoplePage(Browser).GetNoticePurchasedCreditsDisplayed(), Is.True, "Не отобразилось уведомление о покупке 20 кредитов");
            Assert.That(new PeoplePage(Browser).GetNoticePurchaseMembershipDisplayed(), Is.True, "Не отобразилось уведомление о покупке МШ");

            new PeoplePage(Browser)
            .ClickSandwichInPopup()
            .ClickMenuProfile();

            Assert.That(new PeoplePage(Browser).AccrualCreditsAfterPurchase(), Is.True, "Не начислены 20 кредитов");
        }
    }
}
