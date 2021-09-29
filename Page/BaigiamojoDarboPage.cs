using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Page
{
    public class BaigiamojoDarboPage : BasePage
    {
        private const string registrationEmail = "disav65805@busantei.com";//new email required
        private const string registrationPassword = "K!llbot125";
        private const string email = "narimantas12@gmail.com";
        private const string password = "K!llbot126";
        private const string _pageAddress = "https://arnasr.herokuapp.com/#/login";
        private const string _registrationPage = "https://arnasr.herokuapp.com/#/register";
        private const string SecurityQuestionAnswer = "Tron";
        private const string AppleJuiceExpectedResult = "Apple Juice (1000ml)";
        private const string BananaJuiseExpectedResult = "Banana Juice (1000ml)";
        private const string ApplePomaceExpectedResult = "Apple Pomace";

        private IWebElement _closeCoockey => Driver.FindElement(By.CssSelector("body > div.cc-window.cc-floating.cc-type-info.cc-theme-classic.cc-bottom.cc-right.cc-color-override-1934802758 > div > a"));

        private IWebElement _closeWelecomeWondow => Driver.FindElement(By.CssSelector("#mat-dialog-0 > app-welcome-banner > div > div:nth-child(3) > button.mat-focus-indicator.close-dialog.mat-raised-button.mat-button-base.mat-primary.ng-star-inserted"));

        private IWebElement _accountButton => Driver.FindElement(By.Id("navbarAccount"));

        private IWebElement _goToLoginPageButton => Driver.FindElement(By.Id("navbarLoginButton"));

        private IWebElement _loginEmailInputField => Driver.FindElement(By.Id("email"));

        private IWebElement _loginPasswordInputField => Driver.FindElement(By.Id("password"));

        private IWebElement _loginButton => Driver.FindElement(By.Id("loginButton"));

        private IWebElement _registrationEmailInputField => Driver.FindElement(By.Id("emailControl"));

        private IWebElement _registrationPaswordInputField => Driver.FindElement(By.Id("passwordControl"));

        private IWebElement _registrationConfirmPaswordInputField => Driver.FindElement(By.Id("repeatPasswordControl"));

        public IWebElement _dropDown => Driver.FindElement(By.Id("mat-select-0"));

        private IWebElement _dropDownSelection => Driver.FindElement(By.Id("mat-option-11"));
                                                                           
        private IWebElement _addToCartAppleJuise => Driver.FindElement(By.CssSelector("body > app-root > div > mat-sidenav-container > mat-sidenav-content > app-search-result > div > div > div.ng-star-inserted > mat-grid-list > div > mat-grid-tile:nth-child(1) > figure > mat-card > div:nth-child(2) > button"));

        private IWebElement _addToCartApplePomace => Driver.FindElement(By.CssSelector("body > app-root > div > mat-sidenav-container > mat-sidenav-content > app-search-result > div > div > div.ng-star-inserted > mat-grid-list > div > mat-grid-tile:nth-child(2) > figure > mat-card > div:nth-child(2) > button"));

        private IWebElement _AddToCartBananaJuice => Driver.FindElement(By.CssSelector("body > app-root > div > mat-sidenav-container > mat-sidenav-content > app-search-result > div > div > div.ng-star-inserted > mat-grid-list > div > mat-grid-tile:nth-child(3) > figure > mat-card > div:nth-child(2) > button"));

        private IWebElement _securityQuestionAnswer => Driver.FindElement(By.Id("securityAnswerControl"));

        private IWebElement _registerdButton => Driver.FindElement(By.Id("registerButton"));

        private IWebElement _shoppingBasket => Driver.FindElement(By.CssSelector("body > app-root > div > mat-sidenav-container > mat-sidenav-content > app-navbar > mat-toolbar > mat-toolbar-row > button.mat-focus-indicator.buttons.mat-button.mat-button-base.ng-star-inserted"));

        private IWebElement _AppleJuise => Driver.FindElement(By.CssSelector("body > app-root > div > mat-sidenav-container > mat-sidenav-content > app-basket > mat-card > app-purchase-basket > mat-table > mat-row:nth-child(2) > mat-cell.mat-cell.cdk-cell.cdk-column-product.mat-column-product.ng-star-inserted"));

        private IWebElement _Bananajuise => Driver.FindElement(By.CssSelector("body > app-root > div > mat-sidenav-container > mat-sidenav-content > app-basket > mat-card > app-purchase-basket > mat-table > mat-row:nth-child(3) > mat-cell.mat-cell.cdk-cell.cdk-column-product.mat-column-product.ng-star-inserted"));

        private IWebElement _ApplePomace => Driver.FindElement(By.CssSelector("body > app-root > div > mat-sidenav-container > mat-sidenav-content > app-basket > mat-card > app-purchase-basket > mat-table > mat-row:nth-child(4) > mat-cell.mat-cell.cdk-cell.cdk-column-product.mat-column-product.ng-star-inserted"));

        public BaigiamojoDarboPage(IWebDriver webDriver) : base(webDriver) { }

        public BaigiamojoDarboPage NavigateToDefaultPage()
        {
            if (Driver.Url != _pageAddress)
            {
                Driver.Url = _pageAddress;
            }
            return this;
        }

        public BaigiamojoDarboPage NavigateToregistrationPage()
        {
            if (Driver.Url != _registrationPage)
            {
                Driver.Url = _registrationPage;
            }
            return this;
        }

        public BaigiamojoDarboPage CloseCoockey ()
        {
            _closeCoockey.Click();
            return this;
        }

        public BaigiamojoDarboPage CloseWelecomeWindow ()
        {
            _closeWelecomeWondow.Click();
            return this;
        }

        public BaigiamojoDarboPage AccountButtonClick()
        {
            _accountButton.Click();

            return this;
        }


        public BaigiamojoDarboPage AccountLoginPageButton()
        {
            _goToLoginPageButton.Click();

            return this;
        }

        public BaigiamojoDarboPage EmailFieldInput()
        {
            _loginEmailInputField.Clear();
            _loginEmailInputField.SendKeys(email);

            return this;
        }
        public BaigiamojoDarboPage AddAppleJuiseToCart()
        {
            _addToCartAppleJuise.Click();

            return this;
        }
        public BaigiamojoDarboPage AddApplePomaceToCart()
        {
            _addToCartApplePomace.Click();

            return this;
        }
        public BaigiamojoDarboPage AddBananaJuiseToCart()
        {
            _AddToCartBananaJuice.Click();

            return this;
        }

        public BaigiamojoDarboPage PasswordFieldInput()
        {
            _loginPasswordInputField.Clear();
            _loginPasswordInputField.SendKeys(password);

            return this;
        }

        public BaigiamojoDarboPage LoginButtonClick()
        {
            _loginButton.Click();
            return this;
        }

        public BaigiamojoDarboPage RegistrationEmailInputField()
        {
            _registrationEmailInputField.SendKeys(registrationEmail);

            return this;
        }

        public BaigiamojoDarboPage RegistrationPasswordInputField()
        {
            _registrationPaswordInputField.SendKeys(registrationPassword);

            return this;
        }

        public BaigiamojoDarboPage RegistrationConfirmPasswordInputField()
        {
            _registrationConfirmPaswordInputField.SendKeys(registrationPassword);

            return this;
        }


        public BaigiamojoDarboPage ClickDropdown()
        {
            _dropDown.Click();

            return this;
        }
        public BaigiamojoDarboPage ClickDropdownSelect()
        {
            _dropDownSelection.Click();

            return this;
        }


        public BaigiamojoDarboPage SecurityQuestionAnswers(string Text)
        {
            _securityQuestionAnswer.SendKeys(Text);

            return this;
        }

        public BaigiamojoDarboPage RegistrateButtonClick()
        {

            _registerdButton.Click();

            return this;
        }
        public BaigiamojoDarboPage YourBasketButtonClick()
        {

            _shoppingBasket.Click();

            return this;
        }
        public BaigiamojoDarboPage VerifySelection()
        {
            Assert.AreEqual(_AppleJuise, AppleJuiceExpectedResult, $"Result is wrong not{AppleJuiceExpectedResult}");
            Assert.AreEqual(_ApplePomace, ApplePomaceExpectedResult, $"Result is wrong not{ApplePomaceExpectedResult}");
            Assert.AreEqual(_Bananajuise, BananaJuiseExpectedResult, $"Result is wrong not{BananaJuiseExpectedResult}");
            return this;
        }
    }
}
