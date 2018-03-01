using Newtonsoft.Json;
using System;
using System.Net.Http;
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

        public AppointmentService(IAuthenticationService authenticationService, string desktopDomain) : base(authenticationService, desktopDomain)
        {
            _appointmentEndPoint = String.Concat(desktopDomain, "/api/crm/activity");
        }

        public async Task SyncAppointmentAsync(AppointmentSyncModel model)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", _token));

            var content = JsonConvert.SerializeObject(model);

            var response = await client.PostAsync(_appointmentEndPoint, new StringContent(content));

            var responseString = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<AuthenticationResultModel>(responseString);
        }
    }
}
