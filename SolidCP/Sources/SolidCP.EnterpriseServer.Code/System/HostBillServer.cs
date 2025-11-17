using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.PeerToPeer;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SolidCP.EnterpriseServer;


public class HostBillServer : HostBillServerInfo
{
	//SystemController SystemController;
	public static HostBillServerInfo GetHostBillIntegration() => SystemController.GetHostBillIntegration();
	#region --- Typed Models ---
	public class HostBillDateConverter : JsonConverter<DateTime>
	{
		public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var str = reader.GetString();
			return DateTime.ParseExact(str,new string[] { "yyyy-MM-dd HH:mm:ss", "yyyy-MM-dd" }, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None);
		}

		public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToString("yyyy-MM-dd HH:mm:ss"));
		}
	}

	public class HostBillResponseBase
	{
        [JsonPropertyName("success")]
        public bool? Success { get; set; }

        [JsonPropertyName("error")]
        public string[] Error { get; set; }

        [JsonPropertyName("info")]
        public string[] Info { get; set; }

        [JsonPropertyName("call")]
		public string Call { get; set; }

		[JsonPropertyName("server_time")]
		public int ServerTime { get; set; }

    }
    public class HostBillGetClientsResponse: HostBillResponseBase
	{
		[JsonPropertyName("clients")]
		public List<HostBillClient> Clients { get; set; }
	}
    public class HostBillGetClientResponse : HostBillResponseBase
    {
        [JsonPropertyName("client")]
        public HostBillClient Client { get; set; }
    }


    public class HostBillAddClientResponse: HostBillResponseBase
    {
        [JsonPropertyName("client_id")]
        public int ClientId { get; set; }
    }
    public class HostBillClient
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("username")]
		public string Username { get; set; }

		[JsonPropertyName("firstname")]
		public string FirstName { get; set; }

		[JsonPropertyName("lastname")]
		public string LastName { get; set; }

		[JsonPropertyName("companyname")]
		public string CompanyName { get; set; }

		[JsonPropertyName("email")]
		public string Email { get; set; }

		[JsonPropertyName("phonenumber")]
		public string PhoneNumber { get; set; }

		[JsonPropertyName("address1")]
		public string Address1 { get; set; }

		[JsonPropertyName("address2")]
		public string Address2 { get; set; }

		[JsonPropertyName("city")]
		public string City { get; set; }

		[JsonPropertyName("state")]
		public string State { get; set; }

		[JsonPropertyName("postcode")]
		public string Postcode { get; set; }

		[JsonPropertyName("country")]
		public string Country { get; set; }

		[JsonPropertyName("datecreated")]
		[JsonConverter(typeof(HostBillDateConverter))]
		public DateTime DateCreated { get; set; }

		[JsonPropertyName("status")]
		public string Status { get; set; }

		[JsonPropertyName("group_id")]
		public string GroupId { get; set; }

		[JsonPropertyName("currency_id")]
		public string CurrencyId { get; set; }

		[JsonPropertyName("brand_id")]
		public string BrandId { get; set; }

		[JsonPropertyName("credit")]
		public string Credit { get; set; }

		[JsonPropertyName("language")]
		public string Language { get; set; }

		[JsonPropertyName("taxexempt")]
		public string TaxExempt { get; set; }

		[JsonPropertyName("defaultgateway")]
		public string DefaultGateway { get; set; }

		[JsonPropertyName("customfields")]
		public Dictionary<string, string> CustomFields { get; set; }

		[JsonExtensionData]
		public Dictionary<string, object> AdditionalData { get; set; }
	}
	public class AuthenticateResponse
	{
		[JsonPropertyName("status")]
		public string Status { get; set; }

        [JsonPropertyName("error")]
        public string[] Error { get; set; }

        [JsonPropertyName("client")]
		public HostBillClient Client { get; set; }
	}

	public class VerifyClientLoginResponse: HostBillResponseBase
	{
		[JsonPropertyName("client_id")]
		public int ClientId { get; set; }

		[JsonPropertyName("mfa_status")]
		public int MfaStatus { get; set; }
	}
	#endregion

	public static T CallApi<T>(string cmd, string parameters, Method method = Method.Post) where T : class
	{
		var server = GetHostBillIntegration();
		if (!server.Enabled) return null;

		string apiUrl = $"{server.Url}/api.php";
		var data = $"api_id={Uri.EscapeDataString(server.Id)}&api_key={Uri.EscapeDataString(server.Key)}&outputformat=json&call={cmd}&{parameters}";

		var client = new RestClient(apiUrl);
		var request = new RestRequest("", method);
		request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
		request.AddParameter("application/x-www-form-urlencoded", data, ParameterType.RequestBody);

		var response = client.Execute<T>(request);

		if (!response.IsSuccessful) throw new InvalidOperationException($"REST Error: {response.ErrorMessage} {response.StatusCode}");

		return response.Data;
	}

    public static void CreateHostBillUser(UserInfo user, string password) {
        var server = GetHostBillIntegration();
        if (!server.Enabled) return;

		var client = new HostBillClient()
		{
			Address1 = user.Address,
			City = user.City,
			CompanyName = user.CompanyName,
			Country = user.Country,
			Email = user.Email,
			FirstName = user.FirstName,
			LastName = user.LastName,
			PhoneNumber = user.PrimaryPhone,
			Postcode = user.Zip,
			Username = user.Username,
			CurrencyId = "1", // default currency
			Language = "en", // default language
            AdditionalData = new Dictionary<string, object>()
			{
				{ "password", password }
			}
		};

		try
		{
			var response = CallApi<HostBillAddClientResponse>("addClient",
				$"username={Uri.EscapeDataString(client.Username)}&firstname={Uri.EscapeDataString(client.FirstName)}&lastname={Uri.EscapeDataString(client.LastName)}&companyname={Uri.EscapeDataString(client.CompanyName)}&email={Uri.EscapeDataString(client.Email)}&phonenumber={Uri.EscapeDataString(client.PhoneNumber)}&address1={Uri.EscapeDataString(client.Address1)}&city={Uri.EscapeDataString(client.City)}&state={Uri.EscapeDataString(client.State)}&postcode={Uri.EscapeDataString(client.Postcode)}&country={Uri.EscapeDataString(client.Country)}&currency_id={Uri.EscapeDataString(client.CurrencyId)}&language={Uri.EscapeDataString(client.Language)}&password={Uri.EscapeDataString(password)}");
			if (response == null || response.Success != true)
			{
                throw new InvalidOperationException($"HostBill user creation failed: {response.Error.FirstOrDefault()}");
            }
		} catch (Exception ex)
		{
			throw new InvalidOperationException($"HostBill user creation failed: {ex.Message}", ex);
        }
    }

	// returns null on success or error message otherwise
	public static string AuthenticateAndAddHostBillUser(string username, string password)
	{
		var server = GetHostBillIntegration();
		if (!server.Enabled) return null;

		try
		{
			var verifyClientLoginResponse = CallApi<VerifyClientLoginResponse>("verifyClientLogin", $"email={Uri.EscapeDataString(username)}&password={Uri.EscapeDataString(password)}");
			if (verifyClientLoginResponse != null && verifyClientLoginResponse.Success == true)
			{
				var userId = verifyClientLoginResponse.ClientId;
				var getClientDetailsResponse = CallApi<HostBillGetClientResponse>("getClientDetails", $"id={userId}");
				if (getClientDetailsResponse != null && getClientDetailsResponse.Success == true)
				{
					var user = getClientDetailsResponse.Client;
					UserController.AddUser(new UserInfo
					{
						Address = user.Address1,
						City = user.City,
						CompanyName = user.CompanyName,
						Country = user.Country,
						Created = user.DateCreated,
						Email = user.Email,
						FirstName = user.FirstName,
						LastName = user.LastName,
						OwnerId = 1,
						PrimaryPhone = user.PhoneNumber,
						State = user.State,
						Role = UserRole.User,
						Zip = user.Postcode,
						Username = username,
						Status = UserStatus.Active,
					}, false, password, false);
                    return null;
                } return getClientDetailsResponse.Error?.FirstOrDefault() ?? "HostBill user could not authenticate.";
            }
			else return verifyClientLoginResponse.Error?.FirstOrDefault() ?? "HostBill user could not authenticate.";
		} catch (Exception ex) {
			return ex.Message;
		}
	}

	public static bool UpdateMaxEmailAccountsPerDomainQuotaFromHostBill(string username)
	{
		var server = GetHostBillIntegration();
		if (!server.Enabled) return false;

		
		//var clientResponse = CallApi<HostBillClientResponse>("client.getinfo", $"username={Uri.EscapeDataString(username)}");
		//TODO get quota

		return true;
    }
}