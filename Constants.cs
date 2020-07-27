using System;
using System.Collections.Generic;
using System.Text;

namespace waterBot
{
    internal static class Constants
    {
        private const string TextToSpeech           = "/tts";

        internal static class UserMessage
        {
            internal const string GimmeWater          = "!gimmewater";
        }

        internal static class UserResponses
        {
            internal const string HereIsYourWater     = TextToSpeech + " Here is your water you thirsty hoe 💦";
        }
    }
}
