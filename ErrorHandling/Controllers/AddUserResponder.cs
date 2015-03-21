using System.Collections.Generic;
using System.Collections.ObjectModel;
using ErrorHandling.UseCases;

namespace ErrorHandling.Controllers
{
    public class AddUserResponder : IAddUserResponder
    {
        private Collection<ResponderAction> actions;

        public AddUserResponder()
        {
            actions = new Collection<ResponderAction>();
        }

        public void ShowWarning(string warning)
        {
            var action = new ResponderAction();
            action.Name = "showWarning";
            action.Arguments.Add("text", warning);
            actions.Add(action);
        }

        public IEnumerable<ResponderAction> Actions
        {
            get { return actions; }
        }
    }
}
