namespace ErrorHandling.UseCases
{
    public class AddUserUseCase
    {
        public IUserGateway UserGateway { get; set; }

        public void Execute(IAddUserResponder responder)
        {
            string requestedUserName = "RequestedUserName";

            if (UserGateway.DoesExist(requestedUserName))
            {
                responder.ShowWarning("User name already exists.");
                return;
            }

            var user = new User { Name = requestedUserName };
            UserGateway.Save(user);
        }
    }
}