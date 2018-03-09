namespace OutlookToDesktop.ApiService
{
    public class ServiceBase
    {
        protected IAuthenticationService _authenticationService;
        protected AuthenticationResultModel _authenticationResultModel;
        protected string _token;
        protected ProfileModel _profile;

        public ServiceBase(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
            var task = _authenticationService.Authenticate();
            _authenticationResultModel = task.GetAwaiter().GetResult();

            _profile = _authenticationResultModel.Profile;
            _token = _authenticationResultModel.Token.AccessToken;
        }
    }
}
