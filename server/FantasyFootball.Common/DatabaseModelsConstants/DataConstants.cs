namespace FantasyFootball.Common.DatabaseModelsConstants
{
    public static class DataConstants
    {
        public static class ApplicationUser
        {
            public const int NicknameMinLength = 3;
            public const int NicknameMaxLength = 50;

            public const string NicknameLengthErrorMessage = "Nickname must be between 3 and 50 characters long";
        }

        public static class Team 
        {
            public const int TeamNameMinLength = 3;
            public const int TeamNameMaxLength = 50;

            public const string TeamNameLengthErrorMessage = "Team name must be between 3 and 50 characters long";

            public const int TeamHomeTownAndCountryMinLength = 3;
            public const int TeamHomeTownAndCountryMaxLength = 50;

            public const string TeamHomeTownAndCountryErrorMessage = "Home town / Home country of the team must be between 3 and 50 characters long";
        }

        public static class Player
        {
            public const int PlayerNameMinLength = 3;
            public const int PlayerNameMaxLength = 50;

            public const string PlayerNameLengthErrorMessage = "Player name must be between 3 and 50 characters long";
        }

    }
}
