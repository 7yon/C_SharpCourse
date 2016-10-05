﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FifteenPuzzle.Tests
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Game_TryCreateImpossiblePlayingFieldWithIncorrectDimension_MustThrowException()
        {
            Game game = new Game(1, 2, 3, 4, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Game_TryCreateImpossiblePlayingFieldWithIncorrectNumberCells_MustThrowException()
        {
            Game game = new Game(1, 2, 2, 4, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Game_TryCreateImpossiblePlayingFieldWithIncorrectValuesvaluesNotFromRange_MustThrowException()
        {
            Game game = new Game(1, 2, 2, 4, 12, 5, 6, 7, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Game_TryMoveCellWhereThereNoZero_MustThrowException()
        {
            Game game = new Game(1, 2, 3, 0, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

            game.Shift(14);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Game_TryGeCoordinatesOfIncorrectValue_MustThrowException()
        {
            Game game = new Game(1, 2, 3, 0, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

            game.GetLocation(22);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Game_TryGetValueOfIncorrectCoordinates_MustThrowException()
        {
            Game game = new Game(1, 2, 3, 0, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

            int value = game[9, 2];
        }

        [TestMethod]
        public void Game_TryMoveCellToZeroCell_MustCorrectMoveCell()
        {
            Game game = new Game(1, 2, 3, 0, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

            game.Shift(3);

            Cell newCell = game.GetLocation(3);

            Assert.AreEqual(0, newCell.X);
            Assert.AreEqual(3, newCell.Y);
        }

        [TestMethod]
        public void Game_TryGetCoordinatesOfValue_MustCorrectMoveCell()
        {
            Game game = new Game(1, 2, 3, 0, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

            Cell currentCell = game.GetLocation(3);

            Assert.AreEqual(0, currentCell.X);
            Assert.AreEqual(2, currentCell.Y);
        }

        [TestMethod]
        public void Game_TryGetValueOfCoordinates_MustGetCorrectValueCell()
        {
            Game game = new Game(1, 2, 3, 0, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

            int value = game[1, 2];

            Assert.AreEqual(6, value);
        }


        //

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ImmutableGame_TryCreateImpossiblePlayingFieldWithIncorrectDimension_MustThrowException()
        {
            ImmutableGame game = new ImmutableGame(1, 2, 3, 4, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ImmutableGame_TryCreateImpossiblePlayingFieldWithIncorrectNumberCells_MustThrowException()
        {
            ImmutableGame game = new ImmutableGame(1, 2, 2, 4, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ImmutableGame_TryCreateImpossiblePlayingFieldWithIncorrectValuesvaluesNotFromRange_MustThrowException()
        {
            ImmutableGame game = new ImmutableGame(1, 2, 2, 4, 12, 5, 6, 7, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ImmutableGame_TryMoveCellWhereThereNoZero_MustThrowException()
        {
            ImmutableGame game = new ImmutableGame(1, 2, 3, 0, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

            game.Shift(14);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ImmutableGame_TryGeCoordinatesOfIncorrectValue_MustThrowException()
        {
            ImmutableGame game = new ImmutableGame(1, 2, 3, 0, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

            game.GetLocation(22);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ImmutableGame_TryGetValueOfIncorrectCoordinates_MustThrowException()
        {
            ImmutableGame game = new ImmutableGame(1, 2, 3, 0, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

            int value = game[9, 2];
        }

        [TestMethod]
        public void ImmutableGame_TryMoveCellToZeroCell_MustCorrectMoveCell()
        {
            ImmutableGame game = new ImmutableGame(1, 2, 3, 0, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

            game.Shift(3);

            Cell newCell = game.GetLocation(3);

            Assert.AreEqual(0, newCell.X);
            Assert.AreEqual(2, newCell.Y);
        }

        [TestMethod]
        public void ImmutableGame_TryGetCoordinatesOfValue_MustCorrectMoveCell()
        {
            ImmutableGame game = new ImmutableGame(1, 2, 3, 0, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

            Cell currentCell = game.GetLocation(3);

            Assert.AreEqual(0, currentCell.X);
            Assert.AreEqual(2, currentCell.Y);
        }

        [TestMethod]
        public void ImmutableGame_TryGetValueOfCoordinates_MustGetCorrectValueCell()
        {
            ImmutableGame game = new ImmutableGame(1, 2, 3, 0, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

            int value = game[1, 2];

            Assert.AreEqual(6, value);
        }

        [TestMethod]
        public void ImmutableGame_TryGetNewGameWithCorrectCoordinates_MustGetNewCorrectGame()
        {
            ImmutableGame game = new ImmutableGame(1, 2, 3, 0, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

            ImmutableGame newGame = game.Shift(3);

            Assert.AreEqual(0, game[0, 3]);
            Assert.AreEqual(3, newGame[0, 3]);
            Assert.AreEqual(3, game[0, 2]);
            Assert.AreEqual(0, newGame[0, 2]);
        }
    }
}
