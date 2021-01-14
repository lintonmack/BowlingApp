using System.Collections.Generic;
using NSubstitute;
using NUnit.Framework;

namespace BowlingApp.Test
{
    [TestFixture]
    public class GameTests
    {
        private IRollGenerator _rollGenerator;
        private IRollSequenceGenerator _rollSequenceGenerator;
        private IGameManager _gameManager;
        private IFrameManager _frameManager;
        private IGame _game;
        
        [SetUp]
        public void Setup()
        {
            _rollGenerator = Substitute.For<IRollGenerator>();
            _rollSequenceGenerator = Substitute.For<IRollSequenceGenerator>();
            _frameManager = new FrameManager(_gameManager, _rollSequenceGenerator);
            _game = new Game(_frameManager);
            _gameManager = new GameManager(_game);

        }
        
        [Test]
        public void GivenAGameIsCreated_Then10FramesAreAvailable()
        {

            // When
            var frames = _game.GetFrames();

            // When / Then
            Assert.AreEqual(10, frames);
        }

        [Test]
        public void GivenAPlayerRollsAGutterBall_WhenScoreIsCalled_ZeroIsReturned()
        {
            // Given
            _game.Roll(0);

            // When
            var result = _game.Score();

            // Then
            Assert.AreEqual(0, result);
        }
        
        [Test]
        public void GivenAPlayerRollsA7_WhenScoreIsCalled_7IsReturned()
        {
            // Given
            _game.Roll(7);

            // When
            var result = _game.Score();

            // Then
            Assert.AreEqual(7, result);
        }

        [Test]
        public void GivenAGameIsStarted_WhenPlayIsCalled_ThenAScoreOf100IsReturned()
        {
            // Given

            _rollGenerator.Generate(10).Returns(
                x => 10);

            _rollSequenceGenerator.Generate().Returns(
                x => new List<int> {10});

            // When
            var result = _game.Play();

            // Then 
            Assert.AreEqual(100, result);
            
        }
        
        //The game consists of 10 frames.
        //In each frame the player has two rolls to knock down 10 pins.
        //The score for the frame is the total number of pins knocked down, plus bonuses for strikes and spares.
        //A spare is when the player knocks down all 10 pins in two rolls.
        //The bonus for that frame is the number of pins knocked down by the next roll.
        //A strike is when the player knocks down all 10 pins on his first roll.
        //The frame is then completed with a single roll.
        //The bonus for that frame is the value of the next two rolls.
        //In the tenth frame a player who rolls a spare or strike is allowed to roll the extra balls to complete the frame.
        //However no more than three balls can be rolled in tenth frame.
    }
}