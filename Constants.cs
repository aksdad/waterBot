using System;
using System.Collections.Generic;
using System.Text;

namespace waterBot
{
    public static class Constants
    {
        private const string TextToSpeech           = "/tts";

        public static class UserMessage
        {
            public const string GimmeWater          = "!gimmewater";
        }

        public static class UserResponses
        {
            public const string HereIsYourWater     = TextToSpeech + " Here is your water you thirsty hoe 💦";
        }
    }
}
