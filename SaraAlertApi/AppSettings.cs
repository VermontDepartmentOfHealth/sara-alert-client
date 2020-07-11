using System;
using System.Collections.Generic;
using System.Text;

namespace SaraAlertApi
{
    public class AppSettings : IDatabaseConfig, ISaraAlertConfig, ITokenConfig
    {
        // app settings
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string SurveyID { get; set; }
        public string SaraAlertEndpoint { get; set; }

        // app secrets
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string AuthorizationCode { get; set; }

        // token
        public string AccessToken { get; set; }
        public string TokenType { get; set; }      
        public int ExpiresInd { get; set; }
        public string Scope { get; set; }
        public int CreatedAt { get; set; }
    }

    public interface IDatabaseConfig
    {
        string ServerName { get; set; }
        string DatabaseName { get; set; }
        string SurveyID { get; set; }
    }

    public interface ISaraAlertConfig
    {
        string SaraAlertEndpoint { get; set; }
        string ClientId { get; set; }
        string ClientSecret { get; set; }
        string AuthorizationCode { get; set; }
    }

    public interface ITokenConfig
    {
        string AccessToken { get; set; }
        string TokenType { get; set; }
        int ExpiresInd { get; set; }
        string Scope { get; set; }
        int CreatedAt { get; set; }
    }
}
