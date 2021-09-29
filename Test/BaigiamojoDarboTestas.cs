using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Test
{
    class BaigiamasisDarbas : BaseTest
    {


        [Test]
        public static void RegistrateAccount()
        {
            _baigiamojoDarboPage.NavigateToregistrationPage()

                .CloseCoockey()
                .CloseWelecomeWindow()
                .AccountButtonClick()
                .AccountLoginPageButton()
                .RegistrationEmailInputField()
                .RegistrationPasswordInputField()
                .RegistrationConfirmPasswordInputField()
                .ClickDropdown()
                .ClickDropdownSelect()
                .SecurityQuestionAnswers("Tron")
                .RegistrateButtonClick();
                
        }
        [Test]
        public static void LoginAccount()
        {
            _baigiamojoDarboPage.NavigateToDefaultPage()

                .CloseCoockey()
                .CloseWelecomeWindow()
                .EmailFieldInput()
                .PasswordFieldInput()
                .LoginButtonClick();
                
        }


    }
}
