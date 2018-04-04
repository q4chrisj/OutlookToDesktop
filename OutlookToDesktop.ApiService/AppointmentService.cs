using log4net;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OutlookToDesktop.ApiService
{
    public interface IAppointmentService
    {
        Task SyncAppointmentAsync(AppointmentSyncModel model);
    }

    public class AppointmentService : ServiceBase, IAppointmentService
    {
        private readonly string _appointmentEndPoint;
        private readonly string _desktopDomain;

        public AppointmentService(IAuthenticationService authenticationService, string desktopDomain, ILog logger) : base(authenticationService, logger)
        {
            _desktopDomain = desktopDomain;

            _appointmentEndPoint = String.Concat(desktopDomain, "/api/crm/outlook");
        }

        public async Task SyncAppointmentAsync(AppointmentSyncModel model)
        {
            model.Profile = _profile;

            var uri = new Uri(_appointmentEndPoint);
            var content = JsonConvert.SerializeObject(model);
            var stringContent = new StringContent(content, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

                var response = await client.PostAsync(uri, stringContent);
                var responseString = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<AuthenticationResultModel>(responseString);
            }
        }
    }
}
