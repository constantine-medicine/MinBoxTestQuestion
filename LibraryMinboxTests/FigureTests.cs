using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryMinbox;
using System;
using System.Collections.Generic;

namespace LibraryMinbox.Tests
{
    [TestClass()]
    public class FigureTests
    {        
        [TestMethod()]
        public void GetAreaTest()
        {
            // Arrange
            List<int> itemsTriangle = new List<int> { 4, 4, 4 };
            List<int> itemsCircle = new List<int> { 12 };
            List<int> itemUnknown = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            List<int> rightTraingle = new List<int>() { 3, 4, 5 };

            // Act
            // Получение площадей через через известную фигуру и неизветсную
            var resTriangle = Figure.GetArea(TypeFigure.Triangle, itemsTriangle);
            var resTriangleUnk = Figure.GetArea(itemsTriangle);
            
            var resCircle = Figure.GetArea(TypeFigure.Circle, itemsCircle);
            var resCircleUnk = Figure.GetArea(itemsCircle);

            // Является ли треугольник прямоугольным
            var isRightTriangle = Figure.IsRightTriangle(rightTraingle);
            //var resUnk = Figure.GetArea(itemUnknown);
            
            // Assert
            Assert.AreEqual(6.928203, resTriangle);
            Assert.AreEqual(6.928203, resTriangleUnk);
            Assert.AreEqual(452.389342, resCircle);
            Assert.AreEqual(452.389342, resCircleUnk);
            Assert.IsTrue(isRightTriangle);
            //Console.WriteLine(resUnk);
        }
    }
}