﻿using System.Runtime.InteropServices;
using Morgobot.Brain.Grammar;
using Morgobot.Brain.Movements;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Morgobot.Brain
{
    public class Brain
    {
        private readonly BasicThoughts _basicThoughts;
        private readonly MovementThoughts _movementThoughts;
        private readonly Huefication _huefication;
        private readonly ServiceMessageAnalysis _serviceMessageAnalysis;

        public Brain(BasicThoughts basicThoughts, MovementThoughts movementThoughts, Huefication huefication, ServiceMessageAnalysis serviceMessageAnalysis)
        {
            _basicThoughts = basicThoughts;
            _movementThoughts = movementThoughts;
            _huefication = huefication;
            _serviceMessageAnalysis = serviceMessageAnalysis;
        }

        public string Analyse(Update update)
        {
            if (update.Message.Type == MessageType.ServiceMessage)
            {
                return _serviceMessageAnalysis.Analyse(update);
            }

            var message = update.Message.Text;

            if (message == null)
            {
                return null;
            }

            message = message.ToLower();

            if (message.StartsWith("/"))
            {
                message = message.Substring(1, message.Length - 1);
            }

            var phrase = new Phrase(message);

            return _movementThoughts.Analyse(phrase)
                ?? _basicThoughts.Analyse(phrase)
                ?? _huefication.Analyse(phrase)
                ?? "Иди нахуй!";
        }
    }
}
