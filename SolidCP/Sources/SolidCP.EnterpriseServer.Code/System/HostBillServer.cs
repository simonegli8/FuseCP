using RestSharp;
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Data;
using System.Net.PeerToPeer;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Linq;

namespace SolidCP.EnterpriseServer;


public class HostBillServer {
	
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

	public class PaginationResult
	{
		[JsonPropertyName("totalpages")]
		public int TotalPages { get; set; }
		[JsonPropertyName("perpage")]
		public int ItemsPerPage { get; set; }
		[JsonPropertyName("sorterrecords")]
		public int TotalRecords { get; set; }
		[JsonPropertyName("sorterpage")]
		public int NextPage { get; set; }

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

		[JsonPropertyName("sorter")]
		public PaginationResult Sorter { get; set; }
    }
    public class GetClientsResponse: HostBillResponseBase
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
		[JsonPropertyName("accountref")]
		public string AccountRef { get; set; }
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

	public class AccountRelation
	{
		[JsonPropertyName("parent_type")]
		public string ParentType { get; set; }
		[JsonPropertyName("parent_id")]
		public int ParentId { get; set; }
		[JsonPropertyName("child_type")]
        public string ChildType { get; set; }
		[JsonPropertyName("child_id")]
        public int ChildId { get; set; }
    }

	public class Domain
	{
		[JsonPropertyName("name")]
		public string Name { get; set; }
		[JsonPropertyName("id")]
		public int Id { get; set; }
		[JsonPropertyName("cid")]
		public int ClientId { get; set; }
    }
	public class GetDomainsResponse : HostBillResponseBase
	{
		[JsonPropertyName("domains")]
		public List<Domain> Domains { get; set; }
    }
    public class GetDomainLicensesResponse : HostBillResponseBase
	{
		[JsonPropertyName("domains")]
		public List<DomainLicense> Domains { get; set; }
    }
	public class DomainLicense
	{
		[JsonPropertyName("Name")]
		public string Name { get; set; }
		[JsonPropertyName("Quantity")]
		public int Quantity { get; set; }
		[JsonPropertyName("Product")]
		public string Product { get; set; }
    }
    #endregion

    public static T CallApi<T>(string cmd, string parameters, Method method = Method.Post) where T : class
	{
		var server = GetHostBillIntegration();
		if (!server.Enabled) return null;

		string apiUrl = cmd != "getDomainLicenses" ? $"{server.Url}/api.php": $"{server.Url}/apiextended.php"; 
		var key = cmd != "getDomainLicenses" ? server.Key : server.ExtendedKey;
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
	public static string AuthenticateAndSyncHostBillUser(string username, string password, string ip = "")
	{
		var server = GetHostBillIntegration();
		if (!server.Enabled) return null;

		try
		{
			var verifyClientLoginResponse = CallApi<VerifyClientLoginResponse>("verifyClientLogin", $"email={Uri.EscapeDataString(username)}&password={Uri.EscapeDataString(password)}");
			if (verifyClientLoginResponse != null && verifyClientLoginResponse.Success == true)
			{
				var hbUserId = verifyClientLoginResponse.ClientId;
				int userId = -1;
                var scpuser = UserController.GetUserByHostBillIdInternally(hbUserId);
                if (scpuser != null)
                {
                    userId = scpuser.UserId;
                    if ((CryptoUtils.SHA1(scpuser.Password) != password) && (scpuser.Password != password) ||
                        scpuser.Password != CryptoUtils.SHA1(password) && CryptoUtils.SHA1(scpuser.Password) != CryptoUtils.SHA1(password))
                    {
                        UserController.ChangeUserPassword(scpuser.Username, scpuser.Password, CryptoUtils.SHA1(password), ip);
                    }
                }
                else
                {
                    var getClientDetailsResponse = CallApi<HostBillGetClientResponse>("getClientDetails", $"id={hbUserId}");
					if (getClientDetailsResponse != null && getClientDetailsResponse.Success == true)
					{
                        var hbUser = getClientDetailsResponse.Client;
                        userId = UserController.AddUser(new UserInfo
                        {
                            Address = hbUser.Address1,
                            City = hbUser.City,
                            CompanyName = hbUser.CompanyName,
                            Country = hbUser.Country,
                            Created = hbUser.DateCreated,
                            Email = hbUser.Email,
                            FirstName = hbUser.FirstName,
                            LastName = hbUser.LastName,
                            OwnerId = 1,
                            PrimaryPhone = hbUser.PhoneNumber,
                            State = hbUser.State,
                            Role = UserRole.User,
                            Zip = hbUser.Postcode,
                            Username = username,
                            Status = UserStatus.Active,
							HostBillClientId = hbUserId,
							HostBillAccountRef = hbUser.AccountRef
                        }, false, password, false);
                    } else return getClientDetailsResponse.Error?.FirstOrDefault() ?? "HostBill user could not authenticate.";
                }
                var domains = GetDomains(username, hbUserId);
				var scpDomains = new List<string>();
				var userDomainsSet = UserController.GetUserDomainsPaged(hbUserId,null, null, null, 0, int.MaxValue);
				var userDomains = userDomainsSet.Tables[1].Rows.OfType<DataRow>()
					.Select(row => (string)row["DomainName"])
					.ToList();

				var newDomains = domains.Except(userDomains);
				var deletedDomains = userDomains.Except(domains);

				var package = PackageController.GetMyPackages(hbUserId)
					.FirstOrDefault(package => package.PackageName == server.DefaultHostingPlan);
				int packageId = 0;
				if (package == null)
				{
					var hostingplans = ObjectUtils.CreateListFromDataSet<HostingPlanInfo>(PackageController.GetHostingPlans(1));
                    var planId = hostingplans.FirstOrDefault(plan => plan.PlanName == server.DefaultHostingPlan)?.PlanId;
					if (planId.HasValue)
					{
						var result = PackageController.AddPackage(hbUserId, planId.Value, server.DefaultHostingPlan, "", (int)PackageStatus.Active, DateTime.Now, false);
						packageId = result.Result;
					}
					else return "HostBill user sync, DefaultHostingPlan does not exist.";
                } else packageId = package.PackageId;

				if (packageId < 0) return "HostBill user could not be synchronized: unable to create hosting package.";

				var allocatedDomains = PackageController.GetPackageQuota(packageId, Quotas.OS_DOMAINS).QuotaAllocatedValue;
				if (allocatedDomains >= 0 && domains.Count > allocatedDomains)
				{
					var addons = ObjectUtils.CreateListFromDataSet<HostingPlanInfo>(PackageController.GetHostingAddons(1));
					var addon = addons.FirstOrDefault(a => a.IsAddon && a.PlanName == server.DomainAddOn);
					if (addon != null)
					{
						var packageAddon = ObjectUtils.CreateListFromDataSet<PackageAddonInfo>(
							PackageController.GetPackageAddons(packageId))
							.FirstOrDefault(a => a.PlanId == addon.PlanId);
						if (packageAddon != null)
						{
							packageAddon.Quantity += domains.Count - allocatedDomains;
							PackageController.UpdatePackageAddon(packageAddon);
						}
						else
						{
							var pa = new PackageAddonInfo
							{
								PackageId = packageId,
								PlanId = addon.PlanId,
								Quantity = domains.Count - allocatedDomains,
								PlanName = addon.PlanName,
								PurchaseDate = DateTime.Now,
								StatusId = (int)PackageStatus.Active
							};
							PackageController.AddPackageAddon(pa);
						}
					}
					else return "HostBill Domain Addon not found.";
                }

                foreach (var domain in newDomains)
				{
					if (ServerController.CheckDomain(domain) < 0) return $"Domain {domain} already exists";
					var now = DateTime.Now;
                    ServerController.AddDomain(new DomainInfo
					{
						DomainName = domain,
						PackageId = packageId,
						CreationDate = now,
						HostingAllowed = true,
						IsDomainPointer = false,
						IsPreviewDomain = false,
						IsSubDomain = false,
						LastUpdateDate = now,
						MailDomainName = domain,
						ExpirationDate = now.AddYears(1)
					}, false, true);
				}
				foreach (var domain in deletedDomains)
				{
					var domainId = ServerController.GetDomain(domain)?.DomainId;
					if (domainId.HasValue) ServerController.DeleteDomain(domainId.Value);
				}
				return null;
            }
			else return verifyClientLoginResponse.Error?.FirstOrDefault() ?? "HostBill user could not authenticate.";
		} catch (Exception ex) {
			return ex.Message;
		}
	}

	public static IEnumerable<DomainLicense> GetDomainQuotaFromHostBill(string username, int? clientId = null)
	{
		const int DefaultLicenses = 5;
		var server = GetHostBillIntegration();
		if (!server.Enabled) return null;

		if (clientId == null)
		{
			var clientsResponse = CallApi<GetClientsResponse>("getClients", $"page=1&filter[email]={Uri.EscapeDataString(username)}");
			clientId = clientsResponse?.Clients?.FirstOrDefault()?.Id;
		}
		if (clientId == null) return null;

		var domainsResponse = CallApi<GetDomainLicensesResponse>("getDomainLicenses", $"client_id={clientId}");
		var domains = domainsResponse?.Domains;
		return domains
			?.GroupBy(d => d.Name)
			.Select(d => new DomainLicense()
			{
				Name = d.Key,
				Quantity = d.Sum(dl =>
				{
					if (dl.Product == null) return DefaultLicenses;
					var nmatch = Regex.Match(dl.Product, @"\d+");
					if (!nmatch.Success) return dl.Quantity * DefaultLicenses;
					int n = dl.Quantity * DefaultLicenses;
					int.TryParse(nmatch.Value, out n);
					return n;
				})
			});
	}

	public static bool UpdateDomainMailAccountLicensesFromHostBill(string username, int? clientId = null)
	{
		var server = GetHostBillIntegration();
		if (!server.Enabled) return false;

		var domains = GetDomainQuotaFromHostBill(username, clientId);
		foreach (var domain in domains)
		{
			DataProvider.SetMaxEmailAccountsForDomain(domain.Quantity, domain.Name);
        }
		return true;
    }

	public static List<string> GetDomains(string username, int? clientId = null)
	{
		var server = GetHostBillIntegration();
		if (!server.Enabled) return new List<string>();

		string clientName = null;
        if (clientId == null)
        {
            var clientsResponse = CallApi<GetClientsResponse>("getClients", $"page=1&filter[email]={Uri.EscapeDataString(username)}");
			var client = clientsResponse?.Clients?.FirstOrDefault();
            clientId = client?.Id;
			if (client != null) clientName = $"{client.FirstName} {client.LastName}";
        } else
		{
			var getClientDetailsResponse = CallApi<HostBillGetClientResponse>("getClientDetails", $"id={clientId}");
			var client = getClientDetailsResponse?.Client;
			if (client != null) clientName = $"{client.FirstName} {client.LastName}";
        }
		if (clientId == null) return null;

        var domains = new List<string>();
		GetDomainsResponse domainsResponse;
		var page = 0;
		do
		{
			domainsResponse = CallApi<GetDomainsResponse>("getDomains", $"page={page}{(clientName != null ? $"&filter[client_name]={clientName}" : "")}");
			domains.AddRange(domainsResponse?.Domains?.Where(d => d.ClientId == clientId).Select(d => d.Name) ?? Enumerable.Empty<string>());
        } while (domainsResponse?.Sorter != null && domainsResponse.Sorter.TotalPages > page++);

		return domains;
    }
}