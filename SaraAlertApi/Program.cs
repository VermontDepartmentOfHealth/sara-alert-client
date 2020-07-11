
using System.Threading.Tasks;

namespace SaraAlertApi
{
    class Program
    {
        static async Task Main(string[] args)
        {

            // setup
            var config = new Startup().GetConfigSettings();
            var dbAccess = new DataAccess(config);
            var saraClient = new SaraAlertClient(config);
            var mapper = new Mapper();

            // get info from db
            var returningTravelers = dbAccess.GetReturningTravelers();

            // map to FHIR object
            var patients = mapper.MapExportToFhir(returningTravelers);

            // call api
            await saraClient.SetPatients(patients);

        }

    }

}
