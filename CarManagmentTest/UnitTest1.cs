using CarManagment.Domain.Entity;
using CarManagment.App.Abstract;
using CarManagment.App.Manager;
using CarManagment.App.Concrete;
using Moq;
using System;
using System.ComponentModel;
using Xunit;

namespace CarManagmentTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            Car item = new Car(9, "DW6660WR", 3, 1400, new DateTime(2023, 3, 23), new DateTime(2023, 4, 24));
            var mock = new Mock<IService<Car>>();
            mock.Setup(s => s.GetItemById(9)).Returns(item);

            var manager = new ItemManager(new MenuActionService(), mock.Object);
            //Act

            var returnedItem = manager.GetItemById(item.Id);
            //Assert

            Assert.Equal(item, returnedItem);
        }
    }
}