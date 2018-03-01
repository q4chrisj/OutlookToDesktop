namespace OutlookToDesktop.ApiService
{
    public class ServiceBase
    {
        protected IAuthenticationService _authenticationService;
        protected AuthenticationResultModel _authenticationResultModel;
        protected string _token;

        public ServiceBase(IAuthenticationService authenticationService, string desktopDomain)
        {
            _authenticationService = authenticationService;
            var task = _authenticationService.Authenticate();
            _authenticationResultModel = task.GetAwaiter().GetResult();

            _token = _authenticationResultModel.Token.AccessToken;
        }
    }
}
