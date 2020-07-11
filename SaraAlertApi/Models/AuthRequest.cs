using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaraAlertApi
{
    class AuthRequest
    {
        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("grant_type")]
        public string GrantType { get; set; }

        [JsonProperty("redirect_uri")]
        public string RedirectUri { get; set; }
    }

    class AuthResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("error_description")]
        public string ErrorDescription { get; set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("expires_in")]
        public int ExpiresInd { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }
    }


    class AuthToken
    {
        public AuthToken(AuthResponse response)
        {
            this.AccessToken = response.AccessToken;
            this.TokenType = response.TokenType;
            this.ExpiresInd = response.ExpiresInd;
            this.Scope = response.Scope;
            this.CreatedAt = response.CreatedAt;
        }
        public string AccessToken { get; set; }
        public string TokenType { get; set; }
        public int ExpiresInd { get; set; }
        public string Scope { get; set; }
        public int CreatedAt { get; set; }
    }

}
