namespace HIS.Utilities.Commons
{
    public class AppConst
    {
        public static TimeSpan AcceptTokenExpiration = TimeSpan.FromMinutes(15);
        public static TimeSpan RefreshTokenExpiration = TimeSpan.FromDays(1);

        public const string TokenType = "token_type";
        public const string UserIdentifier = "user_identifier";
    }
}
