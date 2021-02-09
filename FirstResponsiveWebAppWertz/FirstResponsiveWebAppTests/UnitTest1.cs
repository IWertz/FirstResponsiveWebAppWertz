using System;
using Xunit;
using FirstResponsiveWebAppWertz.Models;

namespace FirstResponsiveWebAppTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestAge()
        {
            //Arrange
            ResponsiveWebModel response = new ResponsiveWebModel();
            response.BirthYear = 2001;
            int expected = 20;
            int actual;

            //Act
            actual = response.AgeThisYear();

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestEdgeCaseHigh()
        {
            //Arrange 
            ResponsiveWebModel response = new ResponsiveWebModel();
            response.BirthYear = 2021;
            int expected = 0;
            int actual;

            //Act
            actual = response.AgeThisYear();

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestEdgeCaseLow()
        {
            //Arrange 
            ResponsiveWebModel response = new ResponsiveWebModel();
            response.BirthYear = 1900;
            int expected = 121;
            int actual;

            //Act
            actual = response.AgeThisYear();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
