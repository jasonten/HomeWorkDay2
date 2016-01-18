using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarryPotterShoppingCar;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace HarryPotterShoppingCar.Tests
{
    [TestClass()]
    public class HarryPotterShoppingCarTests
    {
        [TestMethod()]
        public void ShoppingCartTest_buy_BookName_1_BookCount_1_Total_100()
        {
            //var target = new HarryPotterShoppingCar();
            List<BookList> BookLists = new List<BookList>()
            {
             new  BookList(){ BookName = "HarryPotter1",BookCount = 1}
            };
            int price = 100;

            var Total = 100;

            //act
            var actual = BookLists[0].BookCount * price;

            //assert
            Assert.AreEqual(Total, actual);
        }
    }
    public class BookList
    {
        public string BookName { get; set; }
        public int BookCount { get; set; }
    }
}
