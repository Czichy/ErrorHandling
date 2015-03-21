using System.Web.Mvc;
using ErrorHandling.Gateways;
using ErrorHandling.UseCases;

namespace ErrorHandling.Controllers
{
    public class UseCaseController : Controller
    {
        [HttpPost]
        public ActionResult Execute()
        {
            var responder = new AddUserResponder();
            var gateway = new FailingUserGateway();
            var useCase = new AddUserUseCase();
            useCase.UserGateway = gateway;
            useCase.Execute(responder);
            return new CamelCaseJsonResult(responder.Actions);
        }

    }
}
