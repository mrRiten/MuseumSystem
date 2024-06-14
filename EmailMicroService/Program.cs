using Microsoft.EntityFrameworkCore;
using MuseumSystem.Core;
using MuseumSystem.Infrastructure.Repositories;
using MuseumSystem.Infrastructure.Services;
using Newtonsoft.Json;

namespace EmailMicroService
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var json = File.ReadAllText("appsettings.json");

            var config = JsonConvert.DeserializeObject<Config>(json);

            var connectionString = config.ConnectionStrings.DefaultConnection;
            var smtpServer = config.SMTP.Server;
            var smtpPort = int.Parse(config.SMTP.Port);
            var smtpAddress = config.SMTP.Address;
            var smtpPassword = config.SMTP.Password;
            var smtpName = config.SMTP.Name;

            var optionsBuilder = new DbContextOptionsBuilder<MuseumSystemDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            var emailDataRepository = new EmailDataRepository(new MuseumSystemDbContext(optionsBuilder.Options));

            var emailDataService = new EmailDataService(emailDataRepository);

            var emailService = new EmailService(smtpServer, smtpPort, smtpAddress, smtpPassword, smtpName);

            while (true)
            {
                var emailData = await emailDataService.GetAllAsync();

                foreach (var item in emailData)
                {
                    var message = $"Уважаемый {item.Client.LastName} {item.Client.FirstName} {item.Client.MiddleName}," +
                        $"Вы записались на {item.TargetEvent.NameEvent}, начало в {item.TargetRecord.dateTime}";

                    await emailService.SendAsync(item.Client.Email, message, item.TargetEvent.NameEvent);
                    await emailDataService.DeleteAsync(item.IdEmailData);
                }

                await Task.Delay(TimeSpan.FromMinutes(1));
            }
        }
    }
}
