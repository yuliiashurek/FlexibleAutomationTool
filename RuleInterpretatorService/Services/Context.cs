namespace RuleInterpretatorService.Services
{
    public class Context
    {
        public DateTime Time { get; set; } = DateTime.Now.AddMinutes(-3);
        private bool isActive;
        public bool usersAreActive
        {
            get => new TelegramActiveUsersService().isActiveUsers().Result;
            private set
            {
                var tg = new TelegramActiveUsersService();
                isActive = tg.isActiveUsers().Result;
            }
        }
        //public string Recipient { get; set; } = "juliysik@gmail.com";
        public string Recipient { get; set; } 
    }
}
