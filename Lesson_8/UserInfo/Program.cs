using System;
using System.Configuration;
using System.IO;
namespace UserInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConfigurationManager.AppSettings["Greeting"]);
            Configuration roaming = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoaming);
            var fileMap = new ExeConfigurationFileMap { ExeConfigFilename = roaming.FilePath };
            
                Configuration config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
                if (config.AppSettings.Settings.Count == 0)
                {
                    Console.WriteLine("Введите Ваше имя");
                    config.AppSettings.Settings.Add("UsersName", Console.ReadLine());
                    Console.WriteLine("Введите Ваш возраст");
                    config.AppSettings.Settings.Add("UsersAge", Console.ReadLine());
                    Console.WriteLine("Введите Ваш род деятельности");
                    config.AppSettings.Settings.Add("UsersOccupation", Console.ReadLine());
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
                }
                else
                {
                    Console.WriteLine($"{config.AppSettings.Settings["UsersName"].Key}: {config.AppSettings.Settings["UsersName"].Value}");
                    Console.WriteLine($"{config.AppSettings.Settings["UsersAge"].Key}: {config.AppSettings.Settings["UsersAge"].Value}");
                    Console.WriteLine($"{config.AppSettings.Settings["UsersOccupation"].Key}: {config.AppSettings.Settings["UsersOccupation"].Value}");
                }
        }
    }
}
