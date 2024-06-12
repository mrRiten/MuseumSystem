namespace MuseumSystem.Application.ServiceContracts
{
    public interface IEmailService
    {
        public Task SendAsync(string email, string text);

    }
}
