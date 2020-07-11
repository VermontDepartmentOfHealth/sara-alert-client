using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;


namespace SaraAlertApi
{
    public class Mapper
    {

        public IEnumerable<Patient> MapExportToFhir(IEnumerable<ReturningTravelersExtract> returningTravelers)
        {
            var results = new List<Patient>();

            foreach (var record in returningTravelers)
            {
                // create new patient
                var patient = new Patient();

                patient.Name = new List<HumanName>
                {
                    new HumanName() {
                        Given = new [] { record.FirstName, record.MiddleName },
                        Family = record.LastName
                    }
                };

                patient.BirthDate = DateTime.Parse(record.DateOfBirth).ToString("yyyy-MM-dd");

                patient.Gender = MapAdministrativeGender(record.SexAtBirth);

                patient.Address = new List<Address> {
                    new Address()
                    {
                        //Use = Address.AddressUse.Home, // home | work | temp | old | billing - purpose of this address
                        Line = new [] { record.AddressLine1, record.AddressLine2 },
                        City = record.AddressCity,
                        PostalCode = record.AddressZip,
                        State = record.AddressState, // validate (where that lookup resolves to)
                    }
                };

                // custom fields
                var isoLastExposureDate = DateTime.Parse(record.LastDateofExposure).ToString("yyyy-MM-dd");
                var lastExp = new Extension()
                {
                    Url = "http://saraalert.org/StructureDefinition/last_exposure_date",
                    Value = new Date(isoLastExposureDate)
                };

                patient.Extension.Add(lastExp);

                results.Add(patient);
            }


            return results;
        }


        private AdministrativeGender MapAdministrativeGender(string gender)
        {
            return gender switch
            {
                "Female" => AdministrativeGender.Female,
                "Male" => AdministrativeGender.Male,
                _ => AdministrativeGender.Unknown,
            };
        }

    }
}
