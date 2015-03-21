using ErrorHandling.UseCases;

namespace ErrorHandling.Gateways
{
    public class FailingUserGateway : IUserGateway
    {
        private static bool userNameExists = false;

        public bool DoesExist(string userName)
        {
            userNameExists = !userNameExists;
            return userNameExists;
        }

        public void Save(User user)
        {
            try
            {

            }
            catch (DeadlockException)
            {
                Save(user);
            }

            throw new UnexpectedSqlException();
        }
    }
}