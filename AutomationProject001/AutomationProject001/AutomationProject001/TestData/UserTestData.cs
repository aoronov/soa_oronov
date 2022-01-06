

using AutomationProject001.Configuration;
using AutomationProject001.Models;

namespace AutomationProject001.TestData
{
    public class UserTestData
    {
        public static User DefaultIncorrectUser = new()
        {
            UserName = "WrongUsername",
            Password = "WrongPassword"
        };

        public static User DefaultUser = new()
        {
            UserName = ConfigurationProvider.GetValue["adminUser"],
            Password = "WrongPassword"
        };

    }
}
