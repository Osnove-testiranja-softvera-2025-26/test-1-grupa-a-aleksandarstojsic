using NUnit.Framework;
using OTS2026_GrupaA.Exceptions;
using OTS2026_GrupaA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2026_GrupaA.Test
{   //F1
    [TestFixture]
    internal class GameTest
    {
        private Game game;
        [SetUp]
        public void Setup()
        {
            game = new Game(new Position(1,2,0), new Position(1,24,0));
        }

    [Test]
    public void Game_OutOfMapPosition_ThrowsException()
    {
        Exception ex = Assert.Throws<PositionOutsideOfMapException>((TestDelegate)(() => game(new Position(0, 0, 0), null, null)));
        Assert.That(ex.Message, Is.EqualTo("Positions must be valid!"));
    }

        //F2
        /*
        [TestCase(Move.Up)]
        [TestCase(Move.Down)]
        [TestCase(Move.Left)]
        [TestCase(Move.Right)]
        [TestCase(Move.Front)]
        [TestCase(Move.Back)]
        private void MovePlayer_PlayerMovementIsValid_Successful(Move move)
        {
                Game Player = new Game(new Position(1, 2, 0), new Position(1, 24, 0));
                Player.GetPositionAfterMove(Move move);
                Assert.That()

        }
        */


        //F5

    }
}
