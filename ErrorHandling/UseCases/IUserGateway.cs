namespace ErrorHandling.UseCases
{
    public interface IUserGateway
    {
        bool DoesExist(string name);

        void Save(User user);
    }
}
