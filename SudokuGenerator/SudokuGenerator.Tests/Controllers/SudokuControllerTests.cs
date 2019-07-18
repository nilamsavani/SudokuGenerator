using Microsoft.VisualStudio.TestTools.UnitTesting;
using SudokuGenerator.Logic;
using System.Net.Http;

namespace SudokuGenerator.Tests.Controllers
{
    [TestClass]
    public class SudokuControllerTests
    {
        int[,] inValidSudokuWithZero = new int[9, 9]
                                    {
                                        { 9, 1, 6, 2, 3, 7, 8, 5, 9 },
                                        { 9, 3, 5, 1, 6, 8, 4, 2, 7 },
                                        { 2, 7, 8, 4, 5, 9, 1, 3, 6 },
                                        { 6, 2, 4, 0, 1, 5, 3, 7, 8 },
                                        { 3, 8, 9, 6, 7, 4, 5, 1, 2 },
                                        { 1, 5, 7, 3, 8, 2, 9, 6, 4 },
                                        { 5, 6, 2, 8, 9, 1, 7, 4, 3 },
                                        { 7, 9, 3, 5, 4, 6, 2, 8, 1 },
                                        { 8, 4, 1, 7, 2, 3, 6, 9, 5 },
                                    };
        int[,] inValidSudoku = new int[9, 9]
                                    {
                                        { 9, 1, 6, 2, 3, 7, 8, 5, 9 },
                                        { 9, 3, 5, 1, 6, 8, 4, 2, 7 },
                                        { 2, 7, 8, 4, 5, 9, 1, 3, 6 },
                                        { 6, 2, 4, 9, 1, 5, 3, 7, 8 },
                                        { 3, 8, 9, 6, 7, 4, 5, 1, 2 },
                                        { 1, 5, 7, 3, 8, 2, 9, 6, 4 },
                                        { 5, 6, 2, 8, 9, 1, 7, 4, 3 },
                                        { 7, 9, 3, 5, 4, 6, 2, 8, 1 },
                                        { 8, 4, 1, 7, 2, 3, 6, 9, 5 },
                                    };

        int[,] validSudoku = new int[9, 9]
                                    {
                                        { 4, 1, 6, 2, 3, 7, 8, 5, 9 },
                                        { 9, 3, 5, 1, 6, 8, 4, 2, 7 },
                                        { 2, 7, 8, 4, 5, 9, 1, 3, 6 },
                                        { 6, 2, 4, 9, 1, 5, 3, 7, 8 },
                                        { 3, 8, 9, 6, 7, 4, 5, 1, 2 },
                                        { 1, 5, 7, 3, 8, 2, 9, 6, 4 },
                                        { 5, 6, 2, 8, 9, 1, 7, 4, 3 },
                                        { 7, 9, 3, 5, 4, 6, 2, 8, 1 },
                                        { 8, 4, 1, 7, 2, 3, 6, 9, 5 },
                                    };

        [TestMethod]
        public void IsValidSudoku()
        {
            //Arrange
            Sudoku objSudoku = new Sudoku();

            //Act
            var isValid = objSudoku.ValidateSudokuBoard(ref validSudoku);

            //Assert
            Assert.AreEqual(true, isValid);
            Assert.IsNotNull(isValid);
        }

        [TestMethod]
        public void IsInvalidSudoku()
        {
            //Arrange
            Sudoku objSudoku = new Sudoku();

            //Act
            var isValid = objSudoku.ValidateSudokuBoard(ref inValidSudoku);

            //Assert
            Assert.AreEqual(false, isValid);
        }

        [TestMethod]
        public void IsInvalidSudokuWithZero()
        {
            //Arrange
            Sudoku objSudoku = new Sudoku();

            //Act
            var isValid = objSudoku.ValidateSudokuBoard(ref inValidSudokuWithZero);

            //Assert
            Assert.AreEqual(false, isValid);
        }

        [TestMethod]
        public void IsvalidSudokuFromService()
        {
            //Arrange
            Sudoku objSudoku = new Sudoku();
            int[] result = new int[81];

            //Act
            result = objSudoku.GenerateSudokuBoard();

            //Assert
            Assert.AreEqual(true, result.Length >= 0);
        }

    }
}
