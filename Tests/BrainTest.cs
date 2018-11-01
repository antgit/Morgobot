﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Morgobot.Brain;
using Moq;
using Morgobot.Brain.Movements;
using Telegram.Bot.Types;

namespace Tests
{
    [TestClass]
    public class BrainTest
    {
        private Brain _brain;
        private Mock<BasicThoughts> _basicThoughtsMock;
        private Mock<MovementThoughts> _movementThoughtsMock;
        private Mock<Huefication> _hueficationMock;
        private Mock<ServiceMessageAnalysis> _serviceMessageAnalysis;

        [TestInitialize]
        public void Init()
        {
            _basicThoughtsMock = new Mock<BasicThoughts>();
            _movementThoughtsMock = new Mock<MovementThoughts>();
            _hueficationMock = new Mock<Huefication>();
            _serviceMessageAnalysis = new Mock<ServiceMessageAnalysis>();

            _brain = new Brain(_basicThoughtsMock.Object, _movementThoughtsMock.Object, _hueficationMock.Object, _serviceMessageAnalysis.Object);
        }

        [TestMethod]
        public void YoTest()
        {
            /*_brain.Analyse(Update.FromString(
                "{ " +
                    "'Message' : { " +
                        "'Test': 'вперёд', " +
                        "'message_id':'123', " +
                        "'date':'2018-11-01', " +
                        "'MessageType': 'TextMessage' " +
                    "}," +
                    "'Type': 'MessageUpdate'" +
                "}"));*/
            //_movementThoughtsMock.Verify(x => x.Analyse());
        }
    }
}
