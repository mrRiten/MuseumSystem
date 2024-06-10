namespace MuseumSystem.Application.ServiceContracts
{
    public interface IAdminService
    {
        public Task Login(string username, string password);
        public Task Logout();

        // For develop time
        public Task DevReg(string username, string password);
    }
}
