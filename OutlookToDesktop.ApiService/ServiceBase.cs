using log4net;
using System.Reflection;

namespace OutlookToDesktop.ApiService
{
    public class ServiceBase
    {
        protected IAuthenticationService _authenticationService;
        protected AuthenticationResultModel _authenticationResultModel;
        protected string _token;
        protected ProfileModel _profile;
        protected readonly ILog _log;

        public ServiceBase(IAuthenticationService authenticationService, ILog logger)
        {
            _log = logger;

            _authenticationService = authenticationService;
            var task = _authenticationService.Authenticate();
            _authenticationResultModel = task.GetAwaiter().GetResult();

            _profile = _authenticationResultModel.Profile;
            _token = _authenticationResultModel.Token.AccessToken;
        }
    }
}
