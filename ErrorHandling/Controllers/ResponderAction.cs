using System.Collections.Generic;

namespace ErrorHandling.Controllers
{
    public class ResponderAction
    {
        private Dictionary<string, object> arguments;

        public ResponderAction()
        {
            arguments = new Dictionary<string, object>();
        }

        public string Name { get; set; }

        public IDictionary<string, object> Arguments
        {
            get { return arguments; }
        }
    }
}