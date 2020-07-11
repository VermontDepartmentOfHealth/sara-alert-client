using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace SaraAlertApi
{
    class SaraAlertClient
    {
        private ISaraAlertConfig Config { get; set; }

        public SaraAlertClient(ISaraAlertConfig config)
        {
            Config = config;
        }

        private const string GRANT_TYPE_AUTHORIZE = "authorization_code";
        private const string RETURN_URI_LOCAL = "urn:ietf:wg:oauth:2.0:oob";
        private const string TOKEN_URL = "https://demo.saraalert.org/oauth/token";
        private const string PATIENT_URL = "https://demo.saraalert.org/fhir/r4/patient";

        public async System.Threading.Tasks.Task<string> RefreshAccessToken()
        {
            // TODO: if we have a a valid value inside of apptoken.json, we don't need to call method - we're done - token will be read on startup

            AuthRequest authReq = new AuthRequest()
            {
                ClientId = Config.ClientId,
                ClientSecret = Config.ClientSecret,
                Code = Config.AuthorizationCode,
                GrantType = GRANT_TYPE_AUTHORIZE,
                RedirectUri = RETURN_URI_LOCAL
            };

            var body = JsonConvert.SerializeObject(authReq);

            using var webClient = new HttpClient();
            using var request = new HttpRequestMessage(HttpMethod.Post, TOKEN_URL);

            request.Headers.TryAddWithoutValidation("content-type", "application/json");
            request.Content = new StringContent(body, Encoding.UTF8, "application/json");

            var response = await webClient.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();
            var authData = JsonConvert.DeserializeObject<AuthResponse>(content);

            if (!string.IsNullOrEmpty(authData.Error)) throw new System.UnauthorizedAccessException(authData.ErrorDescription);

            // TODO: if we got a resposnse back, write to apptoken.json
            // convert to just token data
            var tokenData = new AuthToken(authData);

            // serialize into JSON
            var apptokenContens = JsonConvert.SerializeObject(tokenData);

            // write file to apptoken.json
            var filePathName = Path.Combine(Directory.GetCurrentDirectory(), "apptoken.json");
            using (var outputFile = new StreamWriter(filePathName))
            {
                await outputFile.WriteAsync(apptokenContens);
            }

            return authData.AccessToken;
        }

        public async System.Threading.Tasks.Task SetPatients(IEnumerable<Patient> patients)
        {
            var accessToken = await RefreshAccessToken();


            var client = new FhirClient(Config.SaraAlertEndpoint)
            {
                PreferredFormat = ResourceFormat.Json
            };

            // TODO: The Accept header must be application/fhir+json mime type.
            // TODO: The Content-Type header must be application/fhir+json mime type.

            client.OnBeforeRequest += (object sender, BeforeRequestEventArgs e) =>
            {
                // Replace with a valid bearer token for this server
                e.RawRequest.Headers.Add("Authorization", $"Bearer {accessToken}");
            };

            foreach (var patient in patients)
            {
                var returnPatient = client.Create(patient);


            }

        }

    }
}
