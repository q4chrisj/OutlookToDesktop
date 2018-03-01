using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace OutlookToDesktop.ApiService
{
    public class AuthenticationResultModel : ModelBase
    {
        [JsonProperty("token")]
        public TokenModel Token { get; set; }

        [JsonProperty("profile")]
        public ProfileModel Profile { get; set; }
    }

    public class TokenModel
    {
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        // I think this is a unix timestamp
        [JsonProperty("expire_token")]
        public string ExpireToken { get; set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
    }

    public class ProfileModel
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("_organization")]
        public OrganizationModel Organization { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("suspended")]
        public bool Suspended { get; set; }

        [JsonProperty("client")]
        public ClientModel Client { get; set; }

        [JsonProperty("demo")]
        public bool Demo { get; set; }

        [JsonProperty("products")]
        public List<ProductModel> Products { get; set; }

        [JsonProperty("services")]
        public List<ServiceModel> Services { get; set; }
    }

    public class OrganizationModel
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("exchange")]
        public string Exchange { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("Address")]
        public string address { get; set; }

        [JsonProperty("suspended")]
        public bool Suspended { get; set; }

        [JsonProperty("subscriptions")]
        public List<SubscriptionModel> Subscriptions { get; set; }

        [JsonProperty("tickers")]
        public List<TickerModel> Tickers { get; set; }

        [JsonProperty("entitlements")]
        public List<EntitlementModel> Entitlements { get; set; }
    }

    public class SubscriptionModel
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    public class TickerModel
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("_security")]
        public string Security { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("exchange")]
        public string Exchange { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }
    }

    public class EntitlementModel
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        //[JsonProperty("keys")]
        //public List<KeysModel> Keys { get; set; }
    }

    public class KeysModel
    {
        [JsonProperty("secret")]
        public string Secret { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }

    public class ClientModel
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("exchange")]
        public string Exchange { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProductModel
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ServiceModel
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("demo")]
        public bool Demo { get; set; }
    }
}