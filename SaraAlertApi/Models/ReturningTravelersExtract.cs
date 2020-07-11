using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SaraAlertApi
{
    [DebuggerDisplay("{FirstName} / {DateOfBirth}")]
    public class ReturningTravelersExtract
    {

        [Column("First Name")]
        public string FirstName { get; set; }

        [Column("Middle Name")]
        public string MiddleName { get; set; }

        [Column("Last Name")]
        public string LastName { get; set; }

        [Column("Date of Birth")]
        public string DateOfBirth { get; set; }

        [Column("Sex at Birth")]
        public string SexAtBirth { get; set; }




        [Column("Address Line 1")]
        public string AddressLine1 { get; set; }

        [Column("Address Line 2")]
        public string AddressLine2 { get; set; }

        [Column("Address City")]
        public string AddressCity { get; set; }

        [Column("Address State")]
        public string AddressState { get; set; }

        [Column("Address Zip")]
        public string AddressZip { get; set; }



        [Column("Preferred Contact Method")]
        public string PreferredContactMethod { get; set; }

        [Column("Primary Telephone")]
        public string PrimaryTelephone { get; set; }

        [Column("Primary Telephone Type")]
        public string PrimaryTelephoneType { get; set; }


        [Column("Secondary Telephone")]
        public string SecondaryTelephone { get; set; }

        [Column("Secondary Telephone Type")]
        public string SecondaryTelephoneType { get; set; }

        [Column("Preferred Contact Time")]
        public string PreferredContactTime { get; set; }

        [Column("Email")]
        public string Email { get; set; }



        [Column("Last Date of Exposure")]
        public string LastDateofExposure { get; set; }


        [Column("Full Assigned Jurisdiction Path")]
        public string FullAssignedJurisdictionPath { get; set; }


        #region unused fields


        [Column("White")]
        private string White { get; set; }

        [Column("Black or African American")]
        private string BlackorAfricanAmerican { get; set; }

        [Column("American Indian or Alaska Native")]
        private string AmericanIndianorAlaskaNative { get; set; }

        [Column("Asian")]
        private string Asian { get; set; }

        [Column("Native Hawaiian or Other Pacific Islander")]
        private string NativeHawaiianOrOtherPacificIslander { get; set; }

        [Column("Ethnicity")]
        private string Ethnicity { get; set; }



        [Column("Primary Language")]
        private string PrimaryLanguage { get; set; }

        [Column("Secondary Language")]
        private string SecondaryLanguage { get; set; }

        [Column("Interpretation Required?")]
        private string InterpretationRequired { get; set; }

        [Column("Nationality")]
        private string Nationality { get; set; }



        [Column("Identifier (STATE/LOCAL)")]
        private string IdentifierStateLocal { get; set; }

        [Column("Identifier (CDC)")]
        private string IdentifierCdc { get; set; }

        [Column("Identifier (NNDSS)")]
        private string IdentifierNndss { get; set; }




        [Column("Address County")]
        private string AddressCounty { get; set; }



        [Column("Foreign Address Line 1")]
        private string ForeignAddressLine1 { get; set; }

        [Column("Foreign Address Line 2")]
        private string ForeignAddressLine2 { get; set; }

        [Column("Foreign Address Line 3")]
        private string ForeignAddressLine3 { get; set; }

        [Column("Foreign Address City")]
        private string ForeignAddressCity { get; set; }

        [Column("Foreign Address Country")]
        private string ForeignAddressCountry { get; set; }

        [Column("Foreign Address Zip")]
        private string ForeignAddressZip { get; set; }

        [Column("Foreign Address State")]
        private string ForeignAddressState { get; set; }



        [Column("Monitored Address Line 1")]
        private string MonitoredAddressLine1 { get; set; }

        [Column("Monitored Address Line 2")]
        private string MonitoredAddressLine2 { get; set; }

        [Column("Monitored Address City")]
        private string MonitoredAddressCity { get; set; }

        [Column("Monitored Address State")]
        private string MonitoredAddressState { get; set; }


        [Column("Monitored Address Zip")]
        private string MonitoredAddressZip { get; set; }

        [Column("Monitored Address County")]
        private string MonitoredAddressCounty { get; set; }



        [Column("Foreign Monitored Address Line 1")]
        private string ForeignMonitoredAddressLine1 { get; set; }

        [Column("Foreign Monitored Address Line 2")]
        private string ForeignMonitoredAddressLine2 { get; set; }

        [Column("Foreign Monitored Address City")]
        private string ForeignMonitoredAddressCity { get; set; }

        [Column("Foreign Monitored Address State")]
        private string ForeignMonitoredAddressState { get; set; }

        [Column("Foreign Monitored Address Zip")]
        private string ForeignMonitoredAddressZip { get; set; }

        [Column("Foreign Monitored Address County")]
        private string ForeignMonitoredAddressCounty { get; set; }




        [Column("Port of Origin")]
        private string PortofOrigin { get; set; }

        [Column("Date of Departure")]
        private string DateofDeparture { get; set; }

        [Column("Source of Report")]
        private string SourceofReport { get; set; }

        [Column("Flight or Vessel Number")]
        private string FlightorVesselNumber { get; set; }

        [Column("Flight or Vessel Carrier")]
        private string FlightorVesselCarrier { get; set; }

        [Column("Port of Entry Into USA")]
        private string PortofEntryIntoUSA { get; set; }

        [Column("Date of Arrival")]
        private string DateofArrival { get; set; }

        [Column("Travel Related Notes")]
        private string TravelRelatedNotes { get; set; }



        [Column("Additional Planned Travel Type")]
        private string AdditionalPlannedTravelType { get; set; }

        [Column("Additional Planned Travel Destination")]
        private string AdditionalPlannedTravelDestination { get; set; }

        [Column("Additional Planned Travel Destination State")]
        private string AdditionalPlannedTravelDestinationState { get; set; }

        [Column("Additional Planned Travel Destination Country")]
        private string AdditionalPlannedTravelDestinationCountry { get; set; }

        [Column("Additional Planned Travel Port of Departure")]
        private string AdditionalPlannedTravelPortofDeparture { get; set; }

        [Column("Additional Planned Travel Start Date")]
        private string AdditionalPlannedTravelStartDate { get; set; }

        [Column("Additional Planned Travel End Date")]
        private string AdditionalPlannedTravelEndDate { get; set; }

        [Column("Additional Planned Travel Related Notes")]
        private string AdditionalPlannedTravelRelatedNotes { get; set; }



        [Column("Potential Exposure Location")]
        private string PotentialExposureLocation { get; set; }

        [Column("Potential Exposure Country")]
        private string PotentialExposureCountry { get; set; }



        [Column("Contact of Known Case?")]
        private string ContactofKnownCase { get; set; }

        [Column("Contact of Known Case ID")]
        private string ContactofKnownCaseID { get; set; }

        [Column("Travel from Affected Country or Area?")]
        private string TravelfromAffectedCountryorArea { get; set; }

        [Column("Was in Health Care Facility With Known Cases?")]
        private string WasinHealthCareFacilityWithKnownCases { get; set; }

        [Column("Health Care Facility with Known Cases Name")]
        private string HealthCareFacilitywithKnownCasesName { get; set; }


        [Column("Laboratory Personnel?")]
        private string LaboratoryPersonnel { get; set; }

        [Column("Laboratory Personnel Facility Name")]
        private string LaboratoryPersonnelFacilityName { get; set; }


        [Column("Health Care Personnel?")]
        private string HealthCarePersonnel { get; set; }

        [Column("Health Care Personnel Facility Name")]
        private string HealthCarePersonnelFacilityName { get; set; }

        [Column("Crew on Passenger or Cargo Flight?")]
        private string CrewonPassengerorCargoFlight { get; set; }

        [Column("Member of a Common Exposure Cohort?")]
        private string MemberofaCommonExposureCohort { get; set; }

        [Column("Common Exposure Cohort Name")]
        private string CommonExposureCohortName { get; set; }

        [Column("Exposure Risk Assessment")]
        private string ExposureRiskAssessment { get; set; }

        [Column("Monitoring Plan")]
        private string MonitoringPlan { get; set; }

        [Column("Exposure Notes")]
        private string ExposureNotes { get; set; }


        [Column("Status")]
        private string Status { get; set; }

        [Column("Symptom Onset Date")]
        private string SymptomOnsetDate { get; set; }

        [Column("Case Status")]
        private string CaseStatus { get; set; }



        [Column("Lab 1 Test Type")]
        private string Lab1TestType { get; set; }

        [Column("Lab 1 Specimen Collection Date")]
        private string Lab1SpecimenCollectionDate { get; set; }

        [Column("Lab 1 Report Date")]
        private string Lab1ReportDate { get; set; }

        [Column("Lab 1 Result")]
        private string Lab1Result { get; set; }


        [Column("Lab 2 Test Type")]
        private string Lab2TestType { get; set; }

        [Column("Lab 2 Specimen Collection Date")]
        private string Lab2SpecimenCollectionDate { get; set; }

        [Column("Lab 2 Report Date")]
        private string Lab2ReportDate { get; set; }

        [Column("Lab 2 Result")]
        private string Lab2Result { get; set; }



        [Column("Assigned User")]
        private string AssignedUser { get; set; }

        #endregion

    }
}
