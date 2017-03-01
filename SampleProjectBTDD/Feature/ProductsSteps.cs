using System;
using TechTalk.SpecFlow;

namespace SampleProjectBTDD.Feature
{
    [Binding]
    public class ProductsSteps
    {
        private ProductPage _productPage; 
        [Given(@"I have navigated to Products page")]
        public void GivenIHaveNavigatedToProductsPage()
        {
            _productPage = new ProductPage();
            _productPage.NavigateToProducts();
        }
        
        [Given(@"I have verified states dropdown exits")]
        public void GivenIHaveVerifiedStatesDropdownExits()
        {
            _productPage.DropDownExists();
        }
        
        [When(@"I press states dropdown")]
        public void WhenIPressStatesDropdown()
        {
            _productPage.DropDownClick();
        }
        
        [Then(@"the result should states list in dropdown")]
        public void ThenTheResultShouldStatesListInDropdown()
        {
            _productPage.DropDownValuesExists();
        }
    }
}
