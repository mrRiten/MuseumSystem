namespace MuseumSystem.Application.ServiceContracts
{
    public interface IEmailService
    {
        public Task SendAsync(string ToEmail, string message, string subject);

    }
}
