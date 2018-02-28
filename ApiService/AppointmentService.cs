namespace OutlookToDesktop.ApiService
{
    public interface IAppointmentService
    {
        void SyncAppointment();
    }

    public class AppointmentService : IAppointmentService
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly string _token;

        public AppointmentService(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
            var task = _authenticationService.Authenticate();
            _token = task.GetAwaiter().GetResult();

        }

        public void SyncAppointment()
        {

        }
    }
}
