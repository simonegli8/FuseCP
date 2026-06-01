using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FuseCP.EnterpriseServer.Data.Migrations.SqlServer
{
    /// <inheritdoc />
    public partial class RenameToFuseCP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserSettings",
                keyColumns: new[] { "PropertyName", "SettingsName", "UserID" },
                keyValues: new object[] { "DemoMessage", "SolidCPPolicy", 1 });

            migrationBuilder.DeleteData(
                table: "UserSettings",
                keyColumns: new[] { "PropertyName", "SettingsName", "UserID" },
                keyValues: new object[] { "ForbiddenIP", "SolidCPPolicy", 1 });

            migrationBuilder.DeleteData(
                table: "UserSettings",
                keyColumns: new[] { "PropertyName", "SettingsName", "UserID" },
                keyValues: new object[] { "PasswordPolicy", "SolidCPPolicy", 1 });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 2,
                column: "ProviderType",
                value: "FuseCP.Providers.Web.IIs60, FuseCP.Providers.Web.IIs60");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 3,
                column: "ProviderType",
                value: "FuseCP.Providers.FTP.MsFTP, FuseCP.Providers.FTP.IIs60");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 4,
                column: "ProviderType",
                value: "FuseCP.Providers.Mail.MailEnable, FuseCP.Providers.Mail.MailEnable");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 5,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MsSqlServer, FuseCP.Providers.Database.SqlServer");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 6,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MySqlServer, FuseCP.Providers.Database.MySQL");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 7,
                column: "ProviderType",
                value: "FuseCP.Providers.DNS.MsDNS, FuseCP.Providers.DNS.MsDNS");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 8,
                column: "ProviderType",
                value: "FuseCP.Providers.Statistics.AWStats, FuseCP.Providers.Statistics.AWStats");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 9,
                column: "ProviderType",
                value: "FuseCP.Providers.DNS.SimpleDNS, FuseCP.Providers.DNS.SimpleDNS");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 10,
                column: "ProviderType",
                value: "FuseCP.Providers.Statistics.SmarterStats, FuseCP.Providers.Statistics.SmarterStats");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 11,
                column: "ProviderType",
                value: "FuseCP.Providers.Mail.SmarterMail2, FuseCP.Providers.Mail.SmarterMail2");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 12,
                column: "ProviderType",
                value: "FuseCP.Providers.FTP.Gene6, FuseCP.Providers.FTP.Gene6");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 13,
                column: "ProviderType",
                value: "FuseCP.Providers.Mail.Merak, FuseCP.Providers.Mail.Merak");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 14,
                column: "ProviderType",
                value: "FuseCP.Providers.Mail.SmarterMail3, FuseCP.Providers.Mail.SmarterMail3");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 16,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MsSqlServer2005, FuseCP.Providers.Database.SqlServer");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 17,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MySqlServer50, FuseCP.Providers.Database.MySQL");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 18,
                column: "ProviderType",
                value: "FuseCP.Providers.Mail.MDaemon, FuseCP.Providers.Mail.MDaemon");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 19,
                column: "ProviderType",
                value: "FuseCP.Providers.Mail.ArgoMail, FuseCP.Providers.Mail.ArgoMail");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 20,
                column: "ProviderType",
                value: "FuseCP.Providers.Mail.hMailServer, FuseCP.Providers.Mail.hMailServer");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 21,
                column: "ProviderType",
                value: "FuseCP.Providers.Mail.AbilityMailServer, FuseCP.Providers.Mail.AbilityMailServer");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 22,
                column: "ProviderType",
                value: "FuseCP.Providers.Mail.hMailServer43, FuseCP.Providers.Mail.hMailServer43");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 24,
                column: "ProviderType",
                value: "FuseCP.Providers.DNS.IscBind, FuseCP.Providers.DNS.Bind");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 25,
                column: "ProviderType",
                value: "FuseCP.Providers.FTP.ServU, FuseCP.Providers.FTP.ServU");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 26,
                column: "ProviderType",
                value: "FuseCP.Providers.FTP.FileZilla, FuseCP.Providers.FTP.FileZilla");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 27,
                column: "ProviderType",
                value: "FuseCP.Providers.HostedSolution.Exchange2007, FuseCP.Providers.HostedSolution");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 28,
                column: "ProviderType",
                value: "FuseCP.Providers.DNS.SimpleDNS5, FuseCP.Providers.DNS.SimpleDNS50");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 29,
                column: "ProviderType",
                value: "FuseCP.Providers.Mail.SmarterMail5, FuseCP.Providers.Mail.SmarterMail5");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 30,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MySqlServer51, FuseCP.Providers.Database.MySQL");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 31,
                column: "ProviderType",
                value: "FuseCP.Providers.Statistics.SmarterStats4, FuseCP.Providers.Statistics.SmarterStats");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 32,
                column: "ProviderType",
                value: "FuseCP.Providers.HostedSolution.Exchange2010, FuseCP.Providers.HostedSolution");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 55,
                column: "ProviderType",
                value: "FuseCP.Providers.DNS.Nettica, FuseCP.Providers.DNS.Nettica");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 56,
                column: "ProviderType",
                value: "FuseCP.Providers.DNS.PowerDNS, FuseCP.Providers.DNS.PowerDNS");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 60,
                column: "ProviderType",
                value: "FuseCP.Providers.Mail.SmarterMail6, FuseCP.Providers.Mail.SmarterMail6");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 61,
                column: "ProviderType",
                value: "FuseCP.Providers.Mail.Merak10, FuseCP.Providers.Mail.Merak10");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 62,
                column: "ProviderType",
                value: "FuseCP.Providers.Statistics.SmarterStats5, FuseCP.Providers.Statistics.SmarterStats");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 63,
                column: "ProviderType",
                value: "FuseCP.Providers.Mail.hMailServer5, FuseCP.Providers.Mail.hMailServer5");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 64,
                column: "ProviderType",
                value: "FuseCP.Providers.Mail.SmarterMail7, FuseCP.Providers.Mail.SmarterMail7");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 65,
                column: "ProviderType",
                value: "FuseCP.Providers.Mail.SmarterMail9, FuseCP.Providers.Mail.SmarterMail9");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 66,
                column: "ProviderType",
                value: "FuseCP.Providers.Mail.SmarterMail10, FuseCP.Providers.Mail.SmarterMail10");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 67,
                column: "ProviderType",
                value: "FuseCP.Providers.Mail.SmarterMail100, FuseCP.Providers.Mail.SmarterMail100");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 90,
                column: "ProviderType",
                value: "FuseCP.Providers.HostedSolution.Exchange2010SP2, FuseCP.Providers.HostedSolution");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 91,
                column: "ProviderType",
                value: "FuseCP.Providers.HostedSolution.Exchange2013, FuseCP.Providers.HostedSolution.Exchange2013");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 92,
                column: "ProviderType",
                value: "FuseCP.Providers.HostedSolution.Exchange2016, FuseCP.Providers.HostedSolution.Exchange2016");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 93,
                column: "ProviderType",
                value: "FuseCP.Providers.HostedSolution.Exchange2019, FuseCP.Providers.HostedSolution.Exchange2019");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 101,
                column: "ProviderType",
                value: "FuseCP.Providers.Web.IIs70, FuseCP.Providers.Web.IIs70");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 102,
                column: "ProviderType",
                value: "FuseCP.Providers.FTP.MsFTP, FuseCP.Providers.FTP.IIs70");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 103,
                column: "ProviderType",
                value: "FuseCP.Providers.HostedSolution.OrganizationProvider, FuseCP.Providers.HostedSolution");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 105,
                column: "ProviderType",
                value: "FuseCP.Providers.Web.IIs80, FuseCP.Providers.Web.IIs80");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 106,
                column: "ProviderType",
                value: "FuseCP.Providers.FTP.MsFTP80, FuseCP.Providers.FTP.IIs80");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 110,
                column: "ProviderType",
                value: "FuseCP.Providers.FTP.CerberusFTP6, FuseCP.Providers.FTP.CerberusFTP6");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 111,
                column: "ProviderType",
                value: "FuseCP.Providers.OS.Windows2016, FuseCP.Providers.OS.Windows2016");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 112,
                column: "ProviderType",
                value: "FuseCP.Providers.Web.IIs100, FuseCP.Providers.Web.IIs100");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 113,
                column: "ProviderType",
                value: "FuseCP.Providers.FTP.MsFTP100, FuseCP.Providers.FTP.IIs100");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 160,
                column: "ProviderType",
                value: "FuseCP.Providers.Mail.IceWarp, FuseCP.Providers.Mail.IceWarp");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 200,
                column: "ProviderType",
                value: "FuseCP.Providers.HostedSolution.HostedSharePointServer, FuseCP.Providers.HostedSolution");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 201,
                column: "ProviderType",
                value: "FuseCP.Providers.HostedSolution.CRMProvider, FuseCP.Providers.HostedSolution");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 202,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MsSqlServer2008, FuseCP.Providers.Database.SqlServer");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 203,
                column: "ProviderType",
                value: "FuseCP.Providers.HostedSolution.BlackBerryProvider, FuseCP.Providers.HostedSolution");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 204,
                column: "ProviderType",
                value: "FuseCP.Providers.HostedSolution.BlackBerry5Provider, FuseCP.Providers.HostedSolution");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 205,
                column: "ProviderType",
                value: "FuseCP.Providers.HostedSolution.OCS2007R2, FuseCP.Providers.HostedSolution");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 206,
                column: "ProviderType",
                value: "FuseCP.Providers.HostedSolution.OCSEdge2007R2, FuseCP.Providers.HostedSolution");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 208,
                column: "ProviderType",
                value: "FuseCP.Providers.HostedSolution.HostedSharePointServer2010, FuseCP.Providers.HostedSolution");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 209,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MsSqlServer2012, FuseCP.Providers.Database.SqlServer");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 250,
                column: "ProviderType",
                value: "FuseCP.Providers.HostedSolution.Lync2010, FuseCP.Providers.HostedSolution");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 300,
                column: "ProviderType",
                value: "FuseCP.Providers.Virtualization.HyperV, FuseCP.Providers.Virtualization.HyperV");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 301,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MySqlServer55, FuseCP.Providers.Database.MySQL");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 302,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MySqlServer56, FuseCP.Providers.Database.MySQL");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 303,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MySqlServer57, FuseCP.Providers.Database.MySQL");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 304,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MySqlServer80, FuseCP.Providers.Database.MySQL");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 305,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MySqlServer81, FuseCP.Providers.Database.MySQL");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 306,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MySqlServer82, FuseCP.Providers.Database.MySQL");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 307,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MySqlServer83, FuseCP.Providers.Database.MySQL");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 308,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MySqlServer84, FuseCP.Providers.Database.MySQL");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 320,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MySqlServer90, FuseCP.Providers.Database.MySQL");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 350,
                column: "ProviderType",
                value: "FuseCP.Providers.Virtualization.HyperV2012R2, FuseCP.Providers.Virtualization.HyperV2012R2");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 351,
                column: "ProviderType",
                value: "FuseCP.Providers.Virtualization.HyperVvmm, FuseCP.Providers.Virtualization.HyperVvmm");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 352,
                column: "ProviderType",
                value: "FuseCP.Providers.Virtualization.HyperV2016, FuseCP.Providers.Virtualization.HyperV2016");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 370,
                column: "ProviderType",
                value: "FuseCP.Providers.Virtualization.Proxmoxvps, FuseCP.Providers.Virtualization.Proxmoxvps");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 371,
                column: "ProviderType",
                value: "FuseCP.Providers.Virtualization.ProxmoxvpsLocal, FuseCP.Providers.Virtualization.Proxmoxvps");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 400,
                column: "ProviderType",
                value: "FuseCP.Providers.VirtualizationForPC.HyperVForPC, FuseCP.Providers.VirtualizationForPC.HyperVForPC");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 410,
                column: "ProviderType",
                value: "FuseCP.Providers.DNS.MsDNS2012, FuseCP.Providers.DNS.MsDNS2012");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 500,
                column: "ProviderType",
                value: "FuseCP.Providers.OS.Unix, FuseCP.Providers.OS.Unix");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 600,
                column: "ProviderType",
                value: "FuseCP.Providers.EnterpriseStorage.Windows2012, FuseCP.Providers.EnterpriseStorage.Windows2012");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 700,
                column: "ProviderType",
                value: "FuseCP.Providers.StorageSpaces.Windows2012, FuseCP.Providers.StorageSpaces.Windows2012");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1201,
                column: "ProviderType",
                value: "FuseCP.Providers.HostedSolution.CRMProvider2011, FuseCP.Providers.HostedSolution.CRM2011");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1202,
                column: "ProviderType",
                value: "FuseCP.Providers.HostedSolution.CRMProvider2013, FuseCP.Providers.HostedSolution.Crm2013");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1203,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MsSqlServer2014, FuseCP.Providers.Database.SqlServer");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1205,
                column: "ProviderType",
                value: "FuseCP.Providers.HostedSolution.CRMProvider2015, FuseCP.Providers.HostedSolution.Crm2015");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1206,
                column: "ProviderType",
                value: "FuseCP.Providers.HostedSolution.CRMProvider2016, FuseCP.Providers.HostedSolution.Crm2016");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1301,
                column: "ProviderType",
                value: "FuseCP.Providers.HostedSolution.HostedSharePointServer2013, FuseCP.Providers.HostedSolution.SharePoint2013");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1306,
                column: "ProviderType",
                value: "FuseCP.Providers.HostedSolution.HostedSharePointServer2016, FuseCP.Providers.HostedSolution.SharePoint2016");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1401,
                column: "ProviderType",
                value: "FuseCP.Providers.HostedSolution.Lync2013, FuseCP.Providers.HostedSolution.Lync2013");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1402,
                column: "ProviderType",
                value: "FuseCP.Providers.HostedSolution.Lync2013HP, FuseCP.Providers.HostedSolution.Lync2013HP");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1403,
                column: "ProviderType",
                value: "FuseCP.Providers.HostedSolution.SfB2015, FuseCP.Providers.HostedSolution.SfB2015");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1404,
                column: "ProviderType",
                value: "FuseCP.Providers.HostedSolution.SfB2019, FuseCP.Providers.HostedSolution.SfB2019");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1501,
                column: "ProviderType",
                value: "FuseCP.Providers.RemoteDesktopServices.Windows2012,FuseCP.Providers.RemoteDesktopServices.Windows2012");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1502,
                column: "ProviderType",
                value: "FuseCP.Providers.RemoteDesktopServices.Windows2016,FuseCP.Providers.RemoteDesktopServices.Windows2016");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1503,
                column: "ProviderType",
                value: "FuseCP.Providers.RemoteDesktopServices.Windows2019,FuseCP.Providers.RemoteDesktopServices.Windows2019");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1504,
                column: "ProviderType",
                value: "FuseCP.Providers.RemoteDesktopServices.Windows2022,FuseCP.Providers.RemoteDesktopServices.Windows2022");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1505,
                column: "ProviderType",
                value: "FuseCP.Providers.RemoteDesktopServices.Windows2025,FuseCP.Providers.RemoteDesktopServices.Windows2025");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1550,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MariaDB101, FuseCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1552,
                column: "ProviderType",
                value: "FuseCP.Providers.HostedSolution.HostedSharePointServer2013Ent, FuseCP.Providers.HostedSolution.SharePoint2013Ent");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1560,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MariaDB102, FuseCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1570,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MariaDB103, FuseCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1571,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MariaDB104, FuseCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1572,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MariaDB105, FuseCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1573,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MariaDB106, FuseCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1574,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MariaDB107, FuseCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1575,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MariaDB108, FuseCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1576,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MariaDB109, FuseCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1577,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MariaDB1010, FuseCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1578,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MariaDB1011, FuseCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1579,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MariaDB110, FuseCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1580,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MariaDB111, FuseCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1581,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MariaDB112, FuseCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1582,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MariaDB113, FuseCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1583,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MariaDB114, FuseCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1584,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MariaDB115, FuseCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1585,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MariaDB116, FuseCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1586,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MariaDB117, FuseCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1601,
                column: "ProviderType",
                value: "FuseCP.Providers.Filters.MailCleaner, FuseCP.Providers.Filters.MailCleaner");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1602,
                column: "ProviderType",
                value: "FuseCP.Providers.Filters.SpamExperts, FuseCP.Providers.Filters.SpamExperts");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1701,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MsSqlServer2016, FuseCP.Providers.Database.SqlServer");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1702,
                column: "ProviderType",
                value: "FuseCP.Providers.HostedSolution.HostedSharePointServer2016Ent, FuseCP.Providers.HostedSolution.SharePoint2016Ent");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1703,
                column: "ProviderType",
                value: "FuseCP.Providers.DNS.SimpleDNS6, FuseCP.Providers.DNS.SimpleDNS60");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1704,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MsSqlServer2017, FuseCP.Providers.Database.SqlServer");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1705,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MsSqlServer2019, FuseCP.Providers.Database.SqlServer");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1706,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MsSqlServer2022, FuseCP.Providers.Database.SqlServer");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1707,
                column: "ProviderType",
                value: "FuseCP.Providers.Database.MsSqlServer2025, FuseCP.Providers.Database.SqlServer");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1711,
                column: "ProviderType",
                value: "FuseCP.Providers.HostedSolution.HostedSharePointServer2019, FuseCP.Providers.HostedSolution.SharePoint2019");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1800,
                column: "ProviderType",
                value: "FuseCP.Providers.OS.Windows2019, FuseCP.Providers.OS.Windows2019");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1801,
                column: "ProviderType",
                value: "FuseCP.Providers.Virtualization.HyperV2019, FuseCP.Providers.Virtualization.HyperV2019");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1802,
                column: "ProviderType",
                value: "FuseCP.Providers.OS.Windows2022, FuseCP.Providers.OS.Windows2022");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1803,
                column: "ProviderType",
                value: "FuseCP.Providers.Virtualization.HyperV2022, FuseCP.Providers.Virtualization.HyperV2022");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1804,
                column: "ProviderType",
                value: "FuseCP.Providers.OS.Windows2025, FuseCP.Providers.OS.Windows2025");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1805,
                column: "ProviderType",
                value: "FuseCP.Providers.Virtualization.HyperV2025, FuseCP.Providers.Virtualization.HyperV2025");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1901,
                column: "ProviderType",
                value: "FuseCP.Providers.DNS.SimpleDNS8, FuseCP.Providers.DNS.SimpleDNS80");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1902,
                column: "ProviderType",
                value: "FuseCP.Providers.DNS.MsDNS2016, FuseCP.Providers.DNS.MsDNS2016");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1903,
                column: "ProviderType",
                value: "FuseCP.Providers.DNS.SimpleDNS9, FuseCP.Providers.DNS.SimpleDNS90");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1910,
                column: "ProviderType",
                value: "FuseCP.Providers.FTP.VsFtp3, FuseCP.Providers.FTP.VsFtp");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1911,
                column: "ProviderType",
                value: "FuseCP.Providers.Web.Apache24, FuseCP.Providers.Web.Apache");

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 729,
                column: "QuotaDescription",
                value: "Automatic Replies via FuseCP Allowed");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 1,
                column: "GroupController",
                value: "FuseCP.EnterpriseServer.OperatingSystemController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 2,
                column: "GroupController",
                value: "FuseCP.EnterpriseServer.WebServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 3,
                column: "GroupController",
                value: "FuseCP.EnterpriseServer.FtpServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 4,
                column: "GroupController",
                value: "FuseCP.EnterpriseServer.MailServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 5,
                column: "GroupController",
                value: "FuseCP.EnterpriseServer.DatabaseServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 6,
                column: "GroupController",
                value: "FuseCP.EnterpriseServer.DatabaseServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 7,
                column: "GroupController",
                value: "FuseCP.EnterpriseServer.DnsServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 8,
                column: "GroupController",
                value: "FuseCP.EnterpriseServer.StatisticsServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 10,
                column: "GroupController",
                value: "FuseCP.EnterpriseServer.DatabaseServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 11,
                column: "GroupController",
                value: "FuseCP.EnterpriseServer.DatabaseServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 20,
                column: "GroupController",
                value: "FuseCP.EnterpriseServer.HostedSharePointServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 22,
                column: "GroupController",
                value: "FuseCP.EnterpriseServer.DatabaseServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 23,
                column: "GroupController",
                value: "FuseCP.EnterpriseServer.DatabaseServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 44,
                column: "GroupController",
                value: "FuseCP.EnterpriseServer.EnterpriseStorageController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 46,
                column: "GroupController",
                value: "FuseCP.EnterpriseServer.DatabaseServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 49,
                column: "GroupController",
                value: "FuseCP.EnterpriseServer.StorageSpacesController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 50,
                column: "GroupController",
                value: "FuseCP.EnterpriseServer.DatabaseServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 71,
                column: "GroupController",
                value: "FuseCP.EnterpriseServer.DatabaseServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 72,
                column: "GroupController",
                value: "FuseCP.EnterpriseServer.DatabaseServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 73,
                column: "GroupController",
                value: "FuseCP.EnterpriseServer.HostedSharePointServerEntController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 74,
                column: "GroupController",
                value: "FuseCP.EnterpriseServer.DatabaseServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 75,
                column: "GroupController",
                value: "FuseCP.EnterpriseServer.DatabaseServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 76,
                column: "GroupController",
                value: "FuseCP.EnterpriseServer.DatabaseServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 90,
                column: "GroupController",
                value: "FuseCP.EnterpriseServer.DatabaseServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 91,
                column: "GroupController",
                value: "FuseCP.EnterpriseServer.DatabaseServerController");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_ACTIVATE_PAID_INVOICES" },
                column: "Description",
                value: "~/DesktopModules/FuseCP/ScheduleTaskControls/EmptyView.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_AUDIT_LOG_REPORT" },
                column: "Description",
                value: "~/DesktopModules/FuseCP/ScheduleTaskControls/AuditLogReportView.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_BACKUP" },
                column: "Description",
                value: "~/DesktopModules/FuseCP/ScheduleTaskControls/Backup.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_BACKUP_DATABASE" },
                column: "Description",
                value: "~/DesktopModules/FuseCP/ScheduleTaskControls/BackupDatabase.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_CALCULATE_EXCHANGE_DISKSPACE" },
                column: "Description",
                value: "~/DesktopModules/FuseCP/ScheduleTaskControls/EmptyView.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_CALCULATE_PACKAGES_BANDWIDTH" },
                column: "Description",
                value: "~/DesktopModules/FuseCP/ScheduleTaskControls/EmptyView.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_CALCULATE_PACKAGES_DISKSPACE" },
                column: "Description",
                value: "~/DesktopModules/FuseCP/ScheduleTaskControls/EmptyView.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_CANCEL_OVERDUE_INVOICES" },
                column: "Description",
                value: "~/DesktopModules/FuseCP/ScheduleTaskControls/EmptyView.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_CHECK_WEBSITE" },
                column: "Description",
                value: "~/DesktopModules/FuseCP/ScheduleTaskControls/CheckWebsite.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_CHECK_WEBSITES_SSL" },
                column: "Description",
                value: "~/DesktopModules/FuseCP/ScheduleTaskControls/CheckWebsitesSslView.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_DOMAIN_EXPIRATION" },
                column: "Description",
                value: "~/DesktopModules/FuseCP/ScheduleTaskControls/DomainExpirationView.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_DOMAIN_LOOKUP" },
                column: "Description",
                value: "~/DesktopModules/FuseCP/ScheduleTaskControls/DomainLookupView.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_FTP_FILES" },
                column: "Description",
                value: "~/DesktopModules/FuseCP/ScheduleTaskControls/SendFilesViaFtp.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_GENERATE_INVOICES" },
                column: "Description",
                value: "~/DesktopModules/FuseCP/ScheduleTaskControls/EmptyView.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_HOSTED_SOLUTION_REPORT" },
                column: "Description",
                value: "~/DesktopModules/FuseCP/ScheduleTaskControls/HostedSolutionReport.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_NOTIFY_OVERUSED_DATABASES" },
                column: "Description",
                value: "~/DesktopModules/FuseCP/ScheduleTaskControls/NotifyOverusedDatabases.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_RUN_PAYMENT_QUEUE" },
                column: "Description",
                value: "~/DesktopModules/FuseCP/ScheduleTaskControls/EmptyView.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_RUN_SYSTEM_COMMAND" },
                column: "Description",
                value: "~/DesktopModules/FuseCP/ScheduleTaskControls/ExecuteSystemCommand.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_SEND_MAIL" },
                column: "Description",
                value: "~/DesktopModules/FuseCP/ScheduleTaskControls/SendEmailNotification.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_SUSPEND_OVERDUE_INVOICES" },
                column: "Description",
                value: "~/DesktopModules/FuseCP/ScheduleTaskControls/EmptyView.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_SUSPEND_PACKAGES" },
                column: "Description",
                value: "~/DesktopModules/FuseCP/ScheduleTaskControls/SuspendOverusedSpaces.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_USER_PASSWORD_EXPIRATION_NOTIFICATION" },
                column: "Description",
                value: "~/DesktopModules/FuseCP/ScheduleTaskControls/UserPasswordExpirationNotificationView.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_ZIP_FILES" },
                column: "Description",
                value: "~/DesktopModules/FuseCP/ScheduleTaskControls/ZipFiles.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_ACTIVATE_PAID_INVOICES",
                column: "TaskType",
                value: "FuseCP.Ecommerce.EnterpriseServer.ActivatePaidInvoicesTask, FuseCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_AUDIT_LOG_REPORT",
                column: "TaskType",
                value: "FuseCP.EnterpriseServer.AuditLogReportTask, FuseCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_BACKUP",
                column: "TaskType",
                value: "FuseCP.EnterpriseServer.BackupTask, FuseCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_BACKUP_DATABASE",
                column: "TaskType",
                value: "FuseCP.EnterpriseServer.BackupDatabaseTask, FuseCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_CALCULATE_EXCHANGE_DISKSPACE",
                column: "TaskType",
                value: "FuseCP.EnterpriseServer.CalculateExchangeDiskspaceTask, FuseCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_CALCULATE_PACKAGES_BANDWIDTH",
                column: "TaskType",
                value: "FuseCP.EnterpriseServer.CalculatePackagesBandwidthTask, FuseCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_CALCULATE_PACKAGES_DISKSPACE",
                column: "TaskType",
                value: "FuseCP.EnterpriseServer.CalculatePackagesDiskspaceTask, FuseCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_CANCEL_OVERDUE_INVOICES",
                column: "TaskType",
                value: "FuseCP.Ecommerce.EnterpriseServer.CancelOverdueInvoicesTask, FuseCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_CHECK_WEBSITE",
                column: "TaskType",
                value: "FuseCP.EnterpriseServer.CheckWebSiteTask, FuseCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_CHECK_WEBSITES_SSL",
                column: "TaskType",
                value: "FuseCP.EnterpriseServer.CheckWebsitesSslTask, FuseCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_DELETE_EXCHANGE_ACCOUNTS",
                column: "TaskType",
                value: "FuseCP.EnterpriseServer.DeleteExchangeAccountsTask, FuseCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_DOMAIN_EXPIRATION",
                column: "TaskType",
                value: "FuseCP.EnterpriseServer.DomainExpirationTask, FuseCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_DOMAIN_LOOKUP",
                column: "TaskType",
                value: "FuseCP.EnterpriseServer.DomainLookupViewTask, FuseCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_FTP_FILES",
                column: "TaskType",
                value: "FuseCP.EnterpriseServer.FTPFilesTask, FuseCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_GENERATE_INVOICES",
                column: "TaskType",
                value: "FuseCP.Ecommerce.EnterpriseServer.GenerateInvoicesTask, FuseCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_HOSTED_SOLUTION_REPORT",
                column: "TaskType",
                value: "FuseCP.EnterpriseServer.HostedSolutionReportTask, FuseCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_NOTIFY_OVERUSED_DATABASES",
                column: "TaskType",
                value: "FuseCP.EnterpriseServer.NotifyOverusedDatabasesTask, FuseCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_RUN_PAYMENT_QUEUE",
                column: "TaskType",
                value: "FuseCP.Ecommerce.EnterpriseServer.RunPaymentQueueTask, FuseCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_RUN_SYSTEM_COMMAND",
                column: "TaskType",
                value: "FuseCP.EnterpriseServer.RunSystemCommandTask, FuseCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_SEND_MAIL",
                column: "TaskType",
                value: "FuseCP.EnterpriseServer.SendMailNotificationTask, FuseCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_SUSPEND_OVERDUE_INVOICES",
                column: "TaskType",
                value: "FuseCP.Ecommerce.EnterpriseServer.SuspendOverdueInvoicesTask, FuseCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_SUSPEND_PACKAGES",
                column: "TaskType",
                value: "FuseCP.EnterpriseServer.SuspendOverusedPackagesTask, FuseCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_USER_PASSWORD_EXPIRATION_NOTIFICATION",
                column: "TaskType",
                value: "FuseCP.EnterpriseServer.UserPasswordExpirationNotificationTask, FuseCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_ZIP_FILES",
                column: "TaskType",
                value: "FuseCP.EnterpriseServer.ZipFilesTask, FuseCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ServiceDefaultProperties",
                keyColumns: new[] { "PropertyName", "ProviderID" },
                keyValues: new object[] { "SecureFoldersModuleAssembly", 101 },
                column: "PropertyValue",
                value: "FuseCP.IIsModules.SecureFolders, FuseCP.IIsModules, Version=1.0.0.0, Culture=Neutral, PublicKeyToken=37f9c58a0aa32ff0");

            migrationBuilder.UpdateData(
                table: "ServiceDefaultProperties",
                keyColumns: new[] { "PropertyName", "ProviderID" },
                keyValues: new object[] { "SecureFoldersModuleAssembly", 105 },
                column: "PropertyValue",
                value: "FuseCP.IIsModules.SecureFolders, FuseCP.IIsModules, Version=1.0.0.0, Culture=Neutral, PublicKeyToken=37f9c58a0aa32ff0");

            migrationBuilder.UpdateData(
                table: "ServiceDefaultProperties",
                keyColumns: new[] { "PropertyName", "ProviderID" },
                keyValues: new object[] { "SecureFoldersModuleAssembly", 112 },
                column: "PropertyValue",
                value: "FuseCP.IIsModules.SecureFolders, FuseCP.IIsModules, Version=1.0.0.0, Culture=Neutral, PublicKeyToken=37f9c58a0aa32ff0");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 2,
                column: "TypeName",
                value: "FuseCP.Providers.OS.HomeFolder, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 5,
                column: "TypeName",
                value: "FuseCP.Providers.Database.SqlDatabase, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 6,
                column: "TypeName",
                value: "FuseCP.Providers.Database.SqlUser, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 7,
                column: "TypeName",
                value: "FuseCP.Providers.Database.SqlDatabase, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 8,
                column: "TypeName",
                value: "FuseCP.Providers.Database.SqlUser, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 9,
                column: "TypeName",
                value: "FuseCP.Providers.FTP.FtpAccount, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 10,
                column: "TypeName",
                value: "FuseCP.Providers.Web.WebSite, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 11,
                column: "TypeName",
                value: "FuseCP.Providers.Mail.MailDomain, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 12,
                column: "TypeName",
                value: "FuseCP.Providers.DNS.DnsZone, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 13,
                column: "TypeName",
                value: "FuseCP.Providers.OS.Domain, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 14,
                column: "TypeName",
                value: "FuseCP.Providers.Statistics.StatsSite, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 15,
                column: "TypeName",
                value: "FuseCP.Providers.Mail.MailAccount, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 16,
                column: "TypeName",
                value: "FuseCP.Providers.Mail.MailAlias, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 17,
                column: "TypeName",
                value: "FuseCP.Providers.Mail.MailList, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 18,
                column: "TypeName",
                value: "FuseCP.Providers.Mail.MailGroup, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 20,
                column: "TypeName",
                value: "FuseCP.Providers.OS.SystemDSN, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 21,
                column: "TypeName",
                value: "FuseCP.Providers.Database.SqlDatabase, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 22,
                column: "TypeName",
                value: "FuseCP.Providers.Database.SqlUser, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 23,
                column: "TypeName",
                value: "FuseCP.Providers.Database.SqlDatabase, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 24,
                column: "TypeName",
                value: "FuseCP.Providers.Database.SqlUser, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 25,
                column: "TypeName",
                value: "FuseCP.Providers.Web.SharedSSLFolder, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 28,
                column: "TypeName",
                value: "FuseCP.Providers.DNS.SecondaryDnsZone, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 29,
                column: "TypeName",
                value: "FuseCP.Providers.HostedSolution.Organization, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 30,
                column: "TypeName",
                value: "FuseCP.Providers.HostedSolution.OrganizationDomain, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 31,
                column: "TypeName",
                value: "FuseCP.Providers.Database.SqlDatabase, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 32,
                column: "TypeName",
                value: "FuseCP.Providers.Database.SqlUser, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 33,
                column: "TypeName",
                value: "FuseCP.Providers.Virtualization.VirtualMachine, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 34,
                column: "TypeName",
                value: "FuseCP.Providers.Virtualization.VirtualSwitch, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 35,
                column: "TypeName",
                value: "FuseCP.Providers.Virtualization.VMInfo, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 36,
                column: "TypeName",
                value: "FuseCP.Providers.Virtualization.VirtualSwitch, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 37,
                column: "TypeName",
                value: "FuseCP.Providers.Database.SqlDatabase, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 38,
                column: "TypeName",
                value: "FuseCP.Providers.Database.SqlUser, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 39,
                column: "TypeName",
                value: "FuseCP.Providers.Database.SqlDatabase, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 40,
                column: "TypeName",
                value: "FuseCP.Providers.Database.SqlUser, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 41,
                column: "TypeName",
                value: "FuseCP.Providers.Virtualization.VirtualMachine, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 42,
                column: "TypeName",
                value: "FuseCP.Providers.Virtualization.VirtualSwitch, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 71,
                column: "TypeName",
                value: "FuseCP.Providers.Database.SqlDatabase, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 72,
                column: "TypeName",
                value: "FuseCP.Providers.Database.SqlUser, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 73,
                column: "TypeName",
                value: "FuseCP.Providers.Database.SqlDatabase, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 74,
                column: "TypeName",
                value: "FuseCP.Providers.Database.SqlUser, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 75,
                column: "TypeName",
                value: "FuseCP.Providers.Database.SqlDatabase, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 76,
                column: "TypeName",
                value: "FuseCP.Providers.Database.SqlUser, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 77,
                column: "TypeName",
                value: "FuseCP.Providers.Database.SqlDatabase, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 78,
                column: "TypeName",
                value: "FuseCP.Providers.Database.SqlUser, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 79,
                column: "TypeName",
                value: "FuseCP.Providers.Database.SqlDatabase, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 80,
                column: "TypeName",
                value: "FuseCP.Providers.Database.SqlUser, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 90,
                column: "TypeName",
                value: "FuseCP.Providers.Database.SqlDatabase, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 91,
                column: "TypeName",
                value: "FuseCP.Providers.Database.SqlUser, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 143,
                column: "TypeName",
                value: "FuseCP.Providers.Virtualization.VirtualMachine, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 144,
                column: "TypeName",
                value: "FuseCP.Providers.Virtualization.VirtualSwitch, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 200,
                column: "TypeName",
                value: "FuseCP.Providers.SharePoint.SharePointSiteCollection, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 202,
                column: "TypeName",
                value: "FuseCP.Providers.Database.SqlDatabase, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 203,
                column: "TypeName",
                value: "FuseCP.Providers.Database.SqlUser, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 204,
                column: "TypeName",
                value: "FuseCP.Providers.SharePoint.SharePointEnterpriseSiteCollection, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 205,
                column: "TypeName",
                value: "FuseCP.Providers.Database.SqlDatabase, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 206,
                column: "TypeName",
                value: "FuseCP.Providers.Database.SqlUser, FuseCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "SystemSettings",
                keyColumns: new[] { "PropertyName", "SettingsName" },
                keyValues: new object[] { "MfaTokenAppDisplayName", "AuthenticationSettings" },
                column: "PropertyValue",
                value: "FuseCP");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "ThemeID",
                keyValue: 1,
                column: "DisplayName",
                value: "FuseCP v1");

            migrationBuilder.UpdateData(
                table: "UserSettings",
                keyColumns: new[] { "PropertyName", "SettingsName", "UserID" },
                keyValues: new object[] { "HtmlBody", "AccountSummaryLetter", 1 },
                column: "PropertyValue",
                value: "<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n<head>\r\n    <title>Account Summary Information</title>\r\n    <style type=\"text/css\">\r\n		.Summary { background-color: ##ffffff; padding: 5px; }\r\n		.Summary .Header { padding: 10px 0px 10px 10px; font-size: 16pt; background-color: ##E5F2FF; color: ##1F4978; border-bottom: solid 2px ##86B9F7; }\r\n        .Summary A { color: ##0153A4; }\r\n        .Summary { font-family: Tahoma; font-size: 9pt; }\r\n        .Summary H1 { font-size: 1.7em; color: ##1F4978; border-bottom: dotted 3px ##efefef; }\r\n        .Summary H2 { font-size: 1.3em; color: ##1F4978; }\r\n        .Summary TABLE { border: solid 1px ##e5e5e5; }\r\n        .Summary TH,\r\n        .Summary TD.Label { padding: 5px; font-size: 8pt; font-weight: bold; background-color: ##f5f5f5; }\r\n        .Summary TD { padding: 8px; font-size: 9pt; }\r\n        .Summary UL LI { font-size: 1.1em; font-weight: bold; }\r\n        .Summary UL UL LI { font-size: 0.9em; font-weight: normal; }\r\n    </style>\r\n</head>\r\n<body>\r\n<div class=\"Summary\">\r\n\r\n<a name=\"top\"></a>\r\n<div class=\"Header\">\r\n	Hosting Account Information\r\n</div>\r\n\r\n<ad:if test=\"#Signup#\">\r\n<p>\r\nHello #user.FirstName#,\r\n</p>\r\n\r\n<p>\r\nNew user account has been created and below you can find its summary information.\r\n</p>\r\n\r\n<h1>Control Panel URL</h1>\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>Control Panel URL</th>\r\n            <th>Username</th>\r\n            <th>Password</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n        <tr>\r\n            <td><a href=\"http://panel.HostingCompany.com\">http://panel.HostingCompany.com</a></td>\r\n            <td>#user.Username#</td>\r\n            <td>#user.Password#</td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n</ad:if>\r\n\r\n<h1>Hosting Spaces</h1>\r\n<p>\r\n    The following hosting spaces have been created under your account:\r\n</p>\r\n<ad:foreach collection=\"#Spaces#\" var=\"Space\" index=\"i\">\r\n<h2>#Space.PackageName#</h2>\r\n<table>\r\n	<tbody>\r\n		<tr>\r\n			<td class=\"Label\">Hosting Plan:</td>\r\n			<td>\r\n				<ad:if test=\"#not(isnull(Plans[Space.PlanId]))#\">#Plans[Space.PlanId].PlanName#<ad:else>System</ad:if>\r\n			</td>\r\n		</tr>\r\n		<ad:if test=\"#not(isnull(Plans[Space.PlanId]))#\">\r\n		<tr>\r\n			<td class=\"Label\">Purchase Date:</td>\r\n			<td>\r\n# Space.PurchaseDate#\r\n			</td>\r\n		</tr>\r\n		<tr>\r\n			<td class=\"Label\">Disk Space, MB:</td>\r\n			<td><ad:NumericQuota space=\"#SpaceContexts[Space.PackageId]#\" quota=\"OS.Diskspace\" /></td>\r\n		</tr>\r\n		<tr>\r\n			<td class=\"Label\">Bandwidth, MB/Month:</td>\r\n			<td><ad:NumericQuota space=\"#SpaceContexts[Space.PackageId]#\" quota=\"OS.Bandwidth\" /></td>\r\n		</tr>\r\n		<tr>\r\n			<td class=\"Label\">Maximum Number of Domains:</td>\r\n			<td><ad:NumericQuota space=\"#SpaceContexts[Space.PackageId]#\" quota=\"OS.Domains\" /></td>\r\n		</tr>\r\n		<tr>\r\n			<td class=\"Label\">Maximum Number of Sub-Domains:</td>\r\n			<td><ad:NumericQuota space=\"#SpaceContexts[Space.PackageId]#\" quota=\"OS.SubDomains\" /></td>\r\n		</tr>\r\n		</ad:if>\r\n	</tbody>\r\n</table>\r\n</ad:foreach>\r\n\r\n<ad:if test=\"#Signup#\">\r\n<p>\r\nIf you have any questions regarding your hosting account, feel free to contact our support department at any time.\r\n</p>\r\n\r\n<p>\r\nBest regards,<br />\r\nFuseCP.<br />\r\nWeb Site: <a href=\"https://fusecp.com\">https://fusecp.com</a><br />\r\nE-Mail: <a href=\"mailto:support@fusecp.com\">support@fusecp.com</a>\r\n</p>\r\n</ad:if>\r\n\r\n<ad:template name=\"NumericQuota\">\r\n	<ad:if test=\"#space.Quotas.ContainsKey(quota)#\">\r\n		<ad:if test=\"#space.Quotas[quota].QuotaAllocatedValue isnot -1#\">#space.Quotas[quota].QuotaAllocatedValue#<ad:else>Unlimited</ad:if>\r\n	<ad:else>\r\n		0\r\n	</ad:if>\r\n</ad:template>\r\n\r\n</div>\r\n</body>\r\n</html>");

            migrationBuilder.UpdateData(
                table: "UserSettings",
                keyColumns: new[] { "PropertyName", "SettingsName", "UserID" },
                keyValues: new object[] { "Subject", "AccountSummaryLetter", 1 },
                column: "PropertyValue",
                value: "<ad:if test=\"#Signup#\">FuseCP  account has been created for<ad:else>FuseCP  account summary for</ad:if> #user.FirstName# #user.LastName#");

            migrationBuilder.UpdateData(
                table: "UserSettings",
                keyColumns: new[] { "PropertyName", "SettingsName", "UserID" },
                keyValues: new object[] { "TextBody", "AccountSummaryLetter", 1 },
                column: "PropertyValue",
                value: "=================================\r\n   Hosting Account Information\r\n=================================\r\n<ad:if test=\"#Signup#\">Hello #user.FirstName#,\r\n\r\nNew user account has been created and below you can find its summary information.\r\n\r\nControl Panel URL: https://panel.fusecp.com\r\nUsername: #user.Username#\r\nPassword: #user.Password#\r\n</ad:if>\r\n\r\nHosting Spaces\r\n==============\r\nThe following hosting spaces have been created under your account:\r\n\r\n<ad:foreach collection=\"#Spaces#\" var=\"Space\" index=\"i\">\r\n=== #Space.PackageName# ===\r\nHosting Plan: <ad:if test=\"#not(isnull(Plans[Space.PlanId]))#\">#Plans[Space.PlanId].PlanName#<ad:else>System</ad:if>\r\n<ad:if test=\"#not(isnull(Plans[Space.PlanId]))#\">Purchase Date: #Space.PurchaseDate#\r\nDisk Space, MB: <ad:NumericQuota space=\"#SpaceContexts[Space.PackageId]#\" quota=\"OS.Diskspace\" />\r\nBandwidth, MB/Month: <ad:NumericQuota space=\"#SpaceContexts[Space.PackageId]#\" quota=\"OS.Bandwidth\" />\r\nMaximum Number of Domains: <ad:NumericQuota space=\"#SpaceContexts[Space.PackageId]#\" quota=\"OS.Domains\" />\r\nMaximum Number of Sub-Domains: <ad:NumericQuota space=\"#SpaceContexts[Space.PackageId]#\" quota=\"OS.SubDomains\" />\r\n</ad:if>\r\n</ad:foreach>\r\n\r\n<ad:if test=\"#Signup#\">If you have any questions regarding your hosting account, feel free to contact our support department at any time.\r\n\r\nBest regards,\r\nFuseCP.\r\nWeb Site: https://fusecp.com\">\r\nE-Mail: support@fusecp.com\r\n</ad:if><ad:template name=\"NumericQuota\"><ad:if test=\"#space.Quotas.ContainsKey(quota)#\"><ad:if test=\"#space.Quotas[quota].QuotaAllocatedValue isnot -1#\">#space.Quotas[quota].QuotaAllocatedValue#<ad:else>Unlimited</ad:if><ad:else>0</ad:if></ad:template>");

            migrationBuilder.UpdateData(
                table: "UserSettings",
                keyColumns: new[] { "PropertyName", "SettingsName", "UserID" },
                keyValues: new object[] { "HtmlBody", "PasswordReminderLetter", 1 },
                column: "PropertyValue",
                value: "<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n<head>\r\n    <title>Account Summary Information</title>\r\n    <style type=\"text/css\">\r\n		.Summary { background-color: ##ffffff; padding: 5px; }\r\n		.Summary .Header { padding: 10px 0px 10px 10px; font-size: 16pt; background-color: ##E5F2FF; color: ##1F4978; border-bottom: solid 2px ##86B9F7; }\r\n        .Summary A { color: ##0153A4; }\r\n        .Summary { font-family: Tahoma; font-size: 9pt; }\r\n        .Summary H1 { font-size: 1.7em; color: ##1F4978; border-bottom: dotted 3px ##efefef; }\r\n        .Summary H2 { font-size: 1.3em; color: ##1F4978; }\r\n        .Summary TABLE { border: solid 1px ##e5e5e5; }\r\n        .Summary TH,\r\n        .Summary TD.Label { padding: 5px; font-size: 8pt; font-weight: bold; background-color: ##f5f5f5; }\r\n        .Summary TD { padding: 8px; font-size: 9pt; }\r\n        .Summary UL LI { font-size: 1.1em; font-weight: bold; }\r\n        .Summary UL UL LI { font-size: 0.9em; font-weight: normal; }\r\n    </style>\r\n</head>\r\n<body>\r\n<div class=\"Summary\">\r\n\r\n<a name=\"top\"></a>\r\n<div class=\"Header\">\r\n	Hosting Account Information\r\n</div>\r\n\r\n<p>\r\nHello #user.FirstName#,\r\n</p>\r\n\r\n<p>\r\nPlease, find below details of your control panel account. The one time password was generated for you. You should change the password after login. \r\n</p>\r\n\r\n<h1>Control Panel URL</h1>\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>Control Panel URL</th>\r\n            <th>Username</th>\r\n            <th>One Time Password</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n        <tr>\r\n            <td><a href=\"http://panel.HostingCompany.com\">http://panel.HostingCompany.com</a></td>\r\n            <td>#user.Username#</td>\r\n            <td>#user.Password#</td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n\r\n\r\n<p>\r\nIf you have any questions regarding your hosting account, feel free to contact our support department at any time.\r\n</p>\r\n\r\n<p>\r\nBest regards,<br />\r\nFuseCP.<br />\r\nWeb Site: <a href=\"https://fusecp.com\">https://fusecp.com</a><br />\r\nE-Mail: <a href=\"mailto:support@fusecp.com\">support@fusecp.com</a>\r\n</p>\r\n\r\n</div>\r\n</body>\r\n</html>");

            migrationBuilder.UpdateData(
                table: "UserSettings",
                keyColumns: new[] { "PropertyName", "SettingsName", "UserID" },
                keyValues: new object[] { "TextBody", "PasswordReminderLetter", 1 },
                column: "PropertyValue",
                value: "=================================\r\n   Hosting Account Information\r\n=================================\r\n\r\nHello #user.FirstName#,\r\n\r\nPlease, find below details of your control panel account. The one time password was generated for you. You should change the password after login.\r\n\r\nControl Panel URL: https://panel.fusecp.com\r\nUsername: #user.Username#\r\nOne Time Password: #user.Password#\r\n\r\nIf you have any questions regarding your hosting account, feel free to contact our support department at any time.\r\n\r\nBest regards,\r\nFuseCP.\r\nWeb Site: https://fusecp.com\"\r\nE-Mail: support@fusecp.com");

            migrationBuilder.UpdateData(
                table: "UserSettings",
                keyColumns: new[] { "PropertyName", "SettingsName", "UserID" },
                keyValues: new object[] { "ParkingPageContent", "WebPolicy", 1 },
                column: "PropertyValue",
                value: "<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n<head>\r\n    <title>The web site is under construction</title>\r\n<style type=\"text/css\">\r\n	H1 { font-size: 16pt; margin-bottom: 4px; }\r\n	H2 { font-size: 14pt; margin-bottom: 4px; font-weight: normal; }\r\n</style>\r\n</head>\r\n<body>\r\n<div id=\"PageOutline\">\r\n	<h1>This web site has just been created from <a href=\"https://www.fusecp.com\">FuseCP </a> and it is still under construction.</h1>\r\n	<h2>The web site is hosted by <a href=\"https://fusecp.com\">FuseCP</a>.</h2>\r\n</div>\r\n</body>\r\n</html>");

            migrationBuilder.InsertData(
                table: "UserSettings",
                columns: new[] { "PropertyName", "SettingsName", "UserID", "PropertyValue" },
                values: new object[,]
                {
                    { "DemoMessage", "FuseCPPolicy", 1, "When user account is in demo mode the majority of operations are\r\ndisabled, especially those ones that modify or delete records.\r\nYou are welcome to ask your questions or place comments about\r\nthis demo on  <a href=\"http://forum.fusecp.com\"\r\ntarget=\"_blank\">FuseCP  Support Forum</a>" },
                    { "ForbiddenIP", "FuseCPPolicy", 1, "" },
                    { "PasswordPolicy", "FuseCPPolicy", 1, "True;6;20;0;1;0;True;;0;;;False;False;0;" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserSettings",
                keyColumns: new[] { "PropertyName", "SettingsName", "UserID" },
                keyValues: new object[] { "DemoMessage", "FuseCPPolicy", 1 });

            migrationBuilder.DeleteData(
                table: "UserSettings",
                keyColumns: new[] { "PropertyName", "SettingsName", "UserID" },
                keyValues: new object[] { "ForbiddenIP", "FuseCPPolicy", 1 });

            migrationBuilder.DeleteData(
                table: "UserSettings",
                keyColumns: new[] { "PropertyName", "SettingsName", "UserID" },
                keyValues: new object[] { "PasswordPolicy", "FuseCPPolicy", 1 });

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 2,
                column: "ProviderType",
                value: "SolidCP.Providers.Web.IIs60, SolidCP.Providers.Web.IIs60");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 3,
                column: "ProviderType",
                value: "SolidCP.Providers.FTP.MsFTP, SolidCP.Providers.FTP.IIs60");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 4,
                column: "ProviderType",
                value: "SolidCP.Providers.Mail.MailEnable, SolidCP.Providers.Mail.MailEnable");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 5,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MsSqlServer, SolidCP.Providers.Database.SqlServer");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 6,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MySqlServer, SolidCP.Providers.Database.MySQL");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 7,
                column: "ProviderType",
                value: "SolidCP.Providers.DNS.MsDNS, SolidCP.Providers.DNS.MsDNS");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 8,
                column: "ProviderType",
                value: "SolidCP.Providers.Statistics.AWStats, SolidCP.Providers.Statistics.AWStats");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 9,
                column: "ProviderType",
                value: "SolidCP.Providers.DNS.SimpleDNS, SolidCP.Providers.DNS.SimpleDNS");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 10,
                column: "ProviderType",
                value: "SolidCP.Providers.Statistics.SmarterStats, SolidCP.Providers.Statistics.SmarterStats");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 11,
                column: "ProviderType",
                value: "SolidCP.Providers.Mail.SmarterMail2, SolidCP.Providers.Mail.SmarterMail2");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 12,
                column: "ProviderType",
                value: "SolidCP.Providers.FTP.Gene6, SolidCP.Providers.FTP.Gene6");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 13,
                column: "ProviderType",
                value: "SolidCP.Providers.Mail.Merak, SolidCP.Providers.Mail.Merak");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 14,
                column: "ProviderType",
                value: "SolidCP.Providers.Mail.SmarterMail3, SolidCP.Providers.Mail.SmarterMail3");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 16,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MsSqlServer2005, SolidCP.Providers.Database.SqlServer");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 17,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MySqlServer50, SolidCP.Providers.Database.MySQL");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 18,
                column: "ProviderType",
                value: "SolidCP.Providers.Mail.MDaemon, SolidCP.Providers.Mail.MDaemon");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 19,
                column: "ProviderType",
                value: "SolidCP.Providers.Mail.ArgoMail, SolidCP.Providers.Mail.ArgoMail");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 20,
                column: "ProviderType",
                value: "SolidCP.Providers.Mail.hMailServer, SolidCP.Providers.Mail.hMailServer");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 21,
                column: "ProviderType",
                value: "SolidCP.Providers.Mail.AbilityMailServer, SolidCP.Providers.Mail.AbilityMailServer");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 22,
                column: "ProviderType",
                value: "SolidCP.Providers.Mail.hMailServer43, SolidCP.Providers.Mail.hMailServer43");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 24,
                column: "ProviderType",
                value: "SolidCP.Providers.DNS.IscBind, SolidCP.Providers.DNS.Bind");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 25,
                column: "ProviderType",
                value: "SolidCP.Providers.FTP.ServU, SolidCP.Providers.FTP.ServU");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 26,
                column: "ProviderType",
                value: "SolidCP.Providers.FTP.FileZilla, SolidCP.Providers.FTP.FileZilla");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 27,
                column: "ProviderType",
                value: "SolidCP.Providers.HostedSolution.Exchange2007, SolidCP.Providers.HostedSolution");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 28,
                column: "ProviderType",
                value: "SolidCP.Providers.DNS.SimpleDNS5, SolidCP.Providers.DNS.SimpleDNS50");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 29,
                column: "ProviderType",
                value: "SolidCP.Providers.Mail.SmarterMail5, SolidCP.Providers.Mail.SmarterMail5");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 30,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MySqlServer51, SolidCP.Providers.Database.MySQL");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 31,
                column: "ProviderType",
                value: "SolidCP.Providers.Statistics.SmarterStats4, SolidCP.Providers.Statistics.SmarterStats");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 32,
                column: "ProviderType",
                value: "SolidCP.Providers.HostedSolution.Exchange2010, SolidCP.Providers.HostedSolution");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 55,
                column: "ProviderType",
                value: "SolidCP.Providers.DNS.Nettica, SolidCP.Providers.DNS.Nettica");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 56,
                column: "ProviderType",
                value: "SolidCP.Providers.DNS.PowerDNS, SolidCP.Providers.DNS.PowerDNS");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 60,
                column: "ProviderType",
                value: "SolidCP.Providers.Mail.SmarterMail6, SolidCP.Providers.Mail.SmarterMail6");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 61,
                column: "ProviderType",
                value: "SolidCP.Providers.Mail.Merak10, SolidCP.Providers.Mail.Merak10");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 62,
                column: "ProviderType",
                value: "SolidCP.Providers.Statistics.SmarterStats5, SolidCP.Providers.Statistics.SmarterStats");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 63,
                column: "ProviderType",
                value: "SolidCP.Providers.Mail.hMailServer5, SolidCP.Providers.Mail.hMailServer5");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 64,
                column: "ProviderType",
                value: "SolidCP.Providers.Mail.SmarterMail7, SolidCP.Providers.Mail.SmarterMail7");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 65,
                column: "ProviderType",
                value: "SolidCP.Providers.Mail.SmarterMail9, SolidCP.Providers.Mail.SmarterMail9");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 66,
                column: "ProviderType",
                value: "SolidCP.Providers.Mail.SmarterMail10, SolidCP.Providers.Mail.SmarterMail10");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 67,
                column: "ProviderType",
                value: "SolidCP.Providers.Mail.SmarterMail100, SolidCP.Providers.Mail.SmarterMail100");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 90,
                column: "ProviderType",
                value: "SolidCP.Providers.HostedSolution.Exchange2010SP2, SolidCP.Providers.HostedSolution");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 91,
                column: "ProviderType",
                value: "SolidCP.Providers.HostedSolution.Exchange2013, SolidCP.Providers.HostedSolution.Exchange2013");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 92,
                column: "ProviderType",
                value: "SolidCP.Providers.HostedSolution.Exchange2016, SolidCP.Providers.HostedSolution.Exchange2016");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 93,
                column: "ProviderType",
                value: "SolidCP.Providers.HostedSolution.Exchange2019, SolidCP.Providers.HostedSolution.Exchange2019");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 101,
                column: "ProviderType",
                value: "SolidCP.Providers.Web.IIs70, SolidCP.Providers.Web.IIs70");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 102,
                column: "ProviderType",
                value: "SolidCP.Providers.FTP.MsFTP, SolidCP.Providers.FTP.IIs70");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 103,
                column: "ProviderType",
                value: "SolidCP.Providers.HostedSolution.OrganizationProvider, SolidCP.Providers.HostedSolution");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 105,
                column: "ProviderType",
                value: "SolidCP.Providers.Web.IIs80, SolidCP.Providers.Web.IIs80");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 106,
                column: "ProviderType",
                value: "SolidCP.Providers.FTP.MsFTP80, SolidCP.Providers.FTP.IIs80");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 110,
                column: "ProviderType",
                value: "SolidCP.Providers.FTP.CerberusFTP6, SolidCP.Providers.FTP.CerberusFTP6");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 111,
                column: "ProviderType",
                value: "SolidCP.Providers.OS.Windows2016, SolidCP.Providers.OS.Windows2016");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 112,
                column: "ProviderType",
                value: "SolidCP.Providers.Web.IIs100, SolidCP.Providers.Web.IIs100");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 113,
                column: "ProviderType",
                value: "SolidCP.Providers.FTP.MsFTP100, SolidCP.Providers.FTP.IIs100");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 160,
                column: "ProviderType",
                value: "SolidCP.Providers.Mail.IceWarp, SolidCP.Providers.Mail.IceWarp");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 200,
                column: "ProviderType",
                value: "SolidCP.Providers.HostedSolution.HostedSharePointServer, SolidCP.Providers.HostedSolution");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 201,
                column: "ProviderType",
                value: "SolidCP.Providers.HostedSolution.CRMProvider, SolidCP.Providers.HostedSolution");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 202,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MsSqlServer2008, SolidCP.Providers.Database.SqlServer");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 203,
                column: "ProviderType",
                value: "SolidCP.Providers.HostedSolution.BlackBerryProvider, SolidCP.Providers.HostedSolution");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 204,
                column: "ProviderType",
                value: "SolidCP.Providers.HostedSolution.BlackBerry5Provider, SolidCP.Providers.HostedSolution");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 205,
                column: "ProviderType",
                value: "SolidCP.Providers.HostedSolution.OCS2007R2, SolidCP.Providers.HostedSolution");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 206,
                column: "ProviderType",
                value: "SolidCP.Providers.HostedSolution.OCSEdge2007R2, SolidCP.Providers.HostedSolution");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 208,
                column: "ProviderType",
                value: "SolidCP.Providers.HostedSolution.HostedSharePointServer2010, SolidCP.Providers.HostedSolution");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 209,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MsSqlServer2012, SolidCP.Providers.Database.SqlServer");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 250,
                column: "ProviderType",
                value: "SolidCP.Providers.HostedSolution.Lync2010, SolidCP.Providers.HostedSolution");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 300,
                column: "ProviderType",
                value: "SolidCP.Providers.Virtualization.HyperV, SolidCP.Providers.Virtualization.HyperV");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 301,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MySqlServer55, SolidCP.Providers.Database.MySQL");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 302,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MySqlServer56, SolidCP.Providers.Database.MySQL");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 303,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MySqlServer57, SolidCP.Providers.Database.MySQL");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 304,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MySqlServer80, SolidCP.Providers.Database.MySQL");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 305,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MySqlServer81, SolidCP.Providers.Database.MySQL");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 306,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MySqlServer82, SolidCP.Providers.Database.MySQL");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 307,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MySqlServer83, SolidCP.Providers.Database.MySQL");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 308,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MySqlServer84, SolidCP.Providers.Database.MySQL");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 320,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MySqlServer90, SolidCP.Providers.Database.MySQL");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 350,
                column: "ProviderType",
                value: "SolidCP.Providers.Virtualization.HyperV2012R2, SolidCP.Providers.Virtualization.HyperV2012R2");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 351,
                column: "ProviderType",
                value: "SolidCP.Providers.Virtualization.HyperVvmm, SolidCP.Providers.Virtualization.HyperVvmm");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 352,
                column: "ProviderType",
                value: "SolidCP.Providers.Virtualization.HyperV2016, SolidCP.Providers.Virtualization.HyperV2016");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 370,
                column: "ProviderType",
                value: "SolidCP.Providers.Virtualization.Proxmoxvps, SolidCP.Providers.Virtualization.Proxmoxvps");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 371,
                column: "ProviderType",
                value: "SolidCP.Providers.Virtualization.ProxmoxvpsLocal, SolidCP.Providers.Virtualization.Proxmoxvps");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 400,
                column: "ProviderType",
                value: "SolidCP.Providers.VirtualizationForPC.HyperVForPC, SolidCP.Providers.VirtualizationForPC.HyperVForPC");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 410,
                column: "ProviderType",
                value: "SolidCP.Providers.DNS.MsDNS2012, SolidCP.Providers.DNS.MsDNS2012");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 500,
                column: "ProviderType",
                value: "SolidCP.Providers.OS.Unix, SolidCP.Providers.OS.Unix");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 600,
                column: "ProviderType",
                value: "SolidCP.Providers.EnterpriseStorage.Windows2012, SolidCP.Providers.EnterpriseStorage.Windows2012");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 700,
                column: "ProviderType",
                value: "SolidCP.Providers.StorageSpaces.Windows2012, SolidCP.Providers.StorageSpaces.Windows2012");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1201,
                column: "ProviderType",
                value: "SolidCP.Providers.HostedSolution.CRMProvider2011, SolidCP.Providers.HostedSolution.CRM2011");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1202,
                column: "ProviderType",
                value: "SolidCP.Providers.HostedSolution.CRMProvider2013, SolidCP.Providers.HostedSolution.Crm2013");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1203,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MsSqlServer2014, SolidCP.Providers.Database.SqlServer");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1205,
                column: "ProviderType",
                value: "SolidCP.Providers.HostedSolution.CRMProvider2015, SolidCP.Providers.HostedSolution.Crm2015");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1206,
                column: "ProviderType",
                value: "SolidCP.Providers.HostedSolution.CRMProvider2016, SolidCP.Providers.HostedSolution.Crm2016");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1301,
                column: "ProviderType",
                value: "SolidCP.Providers.HostedSolution.HostedSharePointServer2013, SolidCP.Providers.HostedSolution.SharePoint2013");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1306,
                column: "ProviderType",
                value: "SolidCP.Providers.HostedSolution.HostedSharePointServer2016, SolidCP.Providers.HostedSolution.SharePoint2016");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1401,
                column: "ProviderType",
                value: "SolidCP.Providers.HostedSolution.Lync2013, SolidCP.Providers.HostedSolution.Lync2013");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1402,
                column: "ProviderType",
                value: "SolidCP.Providers.HostedSolution.Lync2013HP, SolidCP.Providers.HostedSolution.Lync2013HP");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1403,
                column: "ProviderType",
                value: "SolidCP.Providers.HostedSolution.SfB2015, SolidCP.Providers.HostedSolution.SfB2015");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1404,
                column: "ProviderType",
                value: "SolidCP.Providers.HostedSolution.SfB2019, SolidCP.Providers.HostedSolution.SfB2019");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1501,
                column: "ProviderType",
                value: "SolidCP.Providers.RemoteDesktopServices.Windows2012,SolidCP.Providers.RemoteDesktopServices.Windows2012");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1502,
                column: "ProviderType",
                value: "SolidCP.Providers.RemoteDesktopServices.Windows2016,SolidCP.Providers.RemoteDesktopServices.Windows2016");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1503,
                column: "ProviderType",
                value: "SolidCP.Providers.RemoteDesktopServices.Windows2019,SolidCP.Providers.RemoteDesktopServices.Windows2019");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1504,
                column: "ProviderType",
                value: "SolidCP.Providers.RemoteDesktopServices.Windows2022,SolidCP.Providers.RemoteDesktopServices.Windows2022");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1505,
                column: "ProviderType",
                value: "SolidCP.Providers.RemoteDesktopServices.Windows2025,SolidCP.Providers.RemoteDesktopServices.Windows2025");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1550,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MariaDB101, SolidCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1552,
                column: "ProviderType",
                value: "SolidCP.Providers.HostedSolution.HostedSharePointServer2013Ent, SolidCP.Providers.HostedSolution.SharePoint2013Ent");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1560,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MariaDB102, SolidCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1570,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MariaDB103, SolidCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1571,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MariaDB104, SolidCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1572,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MariaDB105, SolidCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1573,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MariaDB106, SolidCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1574,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MariaDB107, SolidCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1575,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MariaDB108, SolidCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1576,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MariaDB109, SolidCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1577,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MariaDB1010, SolidCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1578,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MariaDB1011, SolidCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1579,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MariaDB110, SolidCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1580,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MariaDB111, SolidCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1581,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MariaDB112, SolidCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1582,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MariaDB113, SolidCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1583,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MariaDB114, SolidCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1584,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MariaDB115, SolidCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1585,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MariaDB116, SolidCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1586,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MariaDB117, SolidCP.Providers.Database.MariaDB");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1601,
                column: "ProviderType",
                value: "SolidCP.Providers.Filters.MailCleaner, SolidCP.Providers.Filters.MailCleaner");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1602,
                column: "ProviderType",
                value: "SolidCP.Providers.Filters.SpamExperts, SolidCP.Providers.Filters.SpamExperts");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1701,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MsSqlServer2016, SolidCP.Providers.Database.SqlServer");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1702,
                column: "ProviderType",
                value: "SolidCP.Providers.HostedSolution.HostedSharePointServer2016Ent, SolidCP.Providers.HostedSolution.SharePoint2016Ent");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1703,
                column: "ProviderType",
                value: "SolidCP.Providers.DNS.SimpleDNS6, SolidCP.Providers.DNS.SimpleDNS60");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1704,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MsSqlServer2017, SolidCP.Providers.Database.SqlServer");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1705,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MsSqlServer2019, SolidCP.Providers.Database.SqlServer");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1706,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MsSqlServer2022, SolidCP.Providers.Database.SqlServer");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1707,
                column: "ProviderType",
                value: "SolidCP.Providers.Database.MsSqlServer2025, SolidCP.Providers.Database.SqlServer");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1711,
                column: "ProviderType",
                value: "SolidCP.Providers.HostedSolution.HostedSharePointServer2019, SolidCP.Providers.HostedSolution.SharePoint2019");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1800,
                column: "ProviderType",
                value: "SolidCP.Providers.OS.Windows2019, SolidCP.Providers.OS.Windows2019");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1801,
                column: "ProviderType",
                value: "SolidCP.Providers.Virtualization.HyperV2019, SolidCP.Providers.Virtualization.HyperV2019");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1802,
                column: "ProviderType",
                value: "SolidCP.Providers.OS.Windows2022, SolidCP.Providers.OS.Windows2022");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1803,
                column: "ProviderType",
                value: "SolidCP.Providers.Virtualization.HyperV2022, SolidCP.Providers.Virtualization.HyperV2022");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1804,
                column: "ProviderType",
                value: "SolidCP.Providers.OS.Windows2025, SolidCP.Providers.OS.Windows2025");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1805,
                column: "ProviderType",
                value: "SolidCP.Providers.Virtualization.HyperV2025, SolidCP.Providers.Virtualization.HyperV2025");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1901,
                column: "ProviderType",
                value: "SolidCP.Providers.DNS.SimpleDNS8, SolidCP.Providers.DNS.SimpleDNS80");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1902,
                column: "ProviderType",
                value: "SolidCP.Providers.DNS.MsDNS2016, SolidCP.Providers.DNS.MsDNS2016");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1903,
                column: "ProviderType",
                value: "SolidCP.Providers.DNS.SimpleDNS9, SolidCP.Providers.DNS.SimpleDNS90");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1910,
                column: "ProviderType",
                value: "SolidCP.Providers.FTP.VsFtp3, SolidCP.Providers.FTP.VsFtp");

            migrationBuilder.UpdateData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 1911,
                column: "ProviderType",
                value: "SolidCP.Providers.Web.Apache24, SolidCP.Providers.Web.Apache");

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 729,
                column: "QuotaDescription",
                value: "Automatic Replies via SolidCP Allowed");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 1,
                column: "GroupController",
                value: "SolidCP.EnterpriseServer.OperatingSystemController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 2,
                column: "GroupController",
                value: "SolidCP.EnterpriseServer.WebServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 3,
                column: "GroupController",
                value: "SolidCP.EnterpriseServer.FtpServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 4,
                column: "GroupController",
                value: "SolidCP.EnterpriseServer.MailServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 5,
                column: "GroupController",
                value: "SolidCP.EnterpriseServer.DatabaseServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 6,
                column: "GroupController",
                value: "SolidCP.EnterpriseServer.DatabaseServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 7,
                column: "GroupController",
                value: "SolidCP.EnterpriseServer.DnsServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 8,
                column: "GroupController",
                value: "SolidCP.EnterpriseServer.StatisticsServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 10,
                column: "GroupController",
                value: "SolidCP.EnterpriseServer.DatabaseServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 11,
                column: "GroupController",
                value: "SolidCP.EnterpriseServer.DatabaseServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 20,
                column: "GroupController",
                value: "SolidCP.EnterpriseServer.HostedSharePointServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 22,
                column: "GroupController",
                value: "SolidCP.EnterpriseServer.DatabaseServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 23,
                column: "GroupController",
                value: "SolidCP.EnterpriseServer.DatabaseServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 44,
                column: "GroupController",
                value: "SolidCP.EnterpriseServer.EnterpriseStorageController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 46,
                column: "GroupController",
                value: "SolidCP.EnterpriseServer.DatabaseServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 49,
                column: "GroupController",
                value: "SolidCP.EnterpriseServer.StorageSpacesController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 50,
                column: "GroupController",
                value: "SolidCP.EnterpriseServer.DatabaseServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 71,
                column: "GroupController",
                value: "SolidCP.EnterpriseServer.DatabaseServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 72,
                column: "GroupController",
                value: "SolidCP.EnterpriseServer.DatabaseServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 73,
                column: "GroupController",
                value: "SolidCP.EnterpriseServer.HostedSharePointServerEntController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 74,
                column: "GroupController",
                value: "SolidCP.EnterpriseServer.DatabaseServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 75,
                column: "GroupController",
                value: "SolidCP.EnterpriseServer.DatabaseServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 76,
                column: "GroupController",
                value: "SolidCP.EnterpriseServer.DatabaseServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 90,
                column: "GroupController",
                value: "SolidCP.EnterpriseServer.DatabaseServerController");

            migrationBuilder.UpdateData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 91,
                column: "GroupController",
                value: "SolidCP.EnterpriseServer.DatabaseServerController");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_ACTIVATE_PAID_INVOICES" },
                column: "Description",
                value: "~/DesktopModules/SolidCP/ScheduleTaskControls/EmptyView.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_AUDIT_LOG_REPORT" },
                column: "Description",
                value: "~/DesktopModules/SolidCP/ScheduleTaskControls/AuditLogReportView.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_BACKUP" },
                column: "Description",
                value: "~/DesktopModules/SolidCP/ScheduleTaskControls/Backup.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_BACKUP_DATABASE" },
                column: "Description",
                value: "~/DesktopModules/SolidCP/ScheduleTaskControls/BackupDatabase.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_CALCULATE_EXCHANGE_DISKSPACE" },
                column: "Description",
                value: "~/DesktopModules/SolidCP/ScheduleTaskControls/EmptyView.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_CALCULATE_PACKAGES_BANDWIDTH" },
                column: "Description",
                value: "~/DesktopModules/SolidCP/ScheduleTaskControls/EmptyView.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_CALCULATE_PACKAGES_DISKSPACE" },
                column: "Description",
                value: "~/DesktopModules/SolidCP/ScheduleTaskControls/EmptyView.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_CANCEL_OVERDUE_INVOICES" },
                column: "Description",
                value: "~/DesktopModules/SolidCP/ScheduleTaskControls/EmptyView.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_CHECK_WEBSITE" },
                column: "Description",
                value: "~/DesktopModules/SolidCP/ScheduleTaskControls/CheckWebsite.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_CHECK_WEBSITES_SSL" },
                column: "Description",
                value: "~/DesktopModules/SolidCP/ScheduleTaskControls/CheckWebsitesSslView.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_DOMAIN_EXPIRATION" },
                column: "Description",
                value: "~/DesktopModules/SolidCP/ScheduleTaskControls/DomainExpirationView.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_DOMAIN_LOOKUP" },
                column: "Description",
                value: "~/DesktopModules/SolidCP/ScheduleTaskControls/DomainLookupView.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_FTP_FILES" },
                column: "Description",
                value: "~/DesktopModules/SolidCP/ScheduleTaskControls/SendFilesViaFtp.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_GENERATE_INVOICES" },
                column: "Description",
                value: "~/DesktopModules/SolidCP/ScheduleTaskControls/EmptyView.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_HOSTED_SOLUTION_REPORT" },
                column: "Description",
                value: "~/DesktopModules/SolidCP/ScheduleTaskControls/HostedSolutionReport.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_NOTIFY_OVERUSED_DATABASES" },
                column: "Description",
                value: "~/DesktopModules/SolidCP/ScheduleTaskControls/NotifyOverusedDatabases.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_RUN_PAYMENT_QUEUE" },
                column: "Description",
                value: "~/DesktopModules/SolidCP/ScheduleTaskControls/EmptyView.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_RUN_SYSTEM_COMMAND" },
                column: "Description",
                value: "~/DesktopModules/SolidCP/ScheduleTaskControls/ExecuteSystemCommand.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_SEND_MAIL" },
                column: "Description",
                value: "~/DesktopModules/SolidCP/ScheduleTaskControls/SendEmailNotification.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_SUSPEND_OVERDUE_INVOICES" },
                column: "Description",
                value: "~/DesktopModules/SolidCP/ScheduleTaskControls/EmptyView.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_SUSPEND_PACKAGES" },
                column: "Description",
                value: "~/DesktopModules/SolidCP/ScheduleTaskControls/SuspendOverusedSpaces.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_USER_PASSWORD_EXPIRATION_NOTIFICATION" },
                column: "Description",
                value: "~/DesktopModules/SolidCP/ScheduleTaskControls/UserPasswordExpirationNotificationView.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTaskViewConfiguration",
                keyColumns: new[] { "ConfigurationID", "TaskID" },
                keyValues: new object[] { "ASP_NET", "SCHEDULE_TASK_ZIP_FILES" },
                column: "Description",
                value: "~/DesktopModules/SolidCP/ScheduleTaskControls/ZipFiles.ascx");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_ACTIVATE_PAID_INVOICES",
                column: "TaskType",
                value: "SolidCP.Ecommerce.EnterpriseServer.ActivatePaidInvoicesTask, SolidCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_AUDIT_LOG_REPORT",
                column: "TaskType",
                value: "SolidCP.EnterpriseServer.AuditLogReportTask, SolidCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_BACKUP",
                column: "TaskType",
                value: "SolidCP.EnterpriseServer.BackupTask, SolidCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_BACKUP_DATABASE",
                column: "TaskType",
                value: "SolidCP.EnterpriseServer.BackupDatabaseTask, SolidCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_CALCULATE_EXCHANGE_DISKSPACE",
                column: "TaskType",
                value: "SolidCP.EnterpriseServer.CalculateExchangeDiskspaceTask, SolidCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_CALCULATE_PACKAGES_BANDWIDTH",
                column: "TaskType",
                value: "SolidCP.EnterpriseServer.CalculatePackagesBandwidthTask, SolidCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_CALCULATE_PACKAGES_DISKSPACE",
                column: "TaskType",
                value: "SolidCP.EnterpriseServer.CalculatePackagesDiskspaceTask, SolidCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_CANCEL_OVERDUE_INVOICES",
                column: "TaskType",
                value: "SolidCP.Ecommerce.EnterpriseServer.CancelOverdueInvoicesTask, SolidCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_CHECK_WEBSITE",
                column: "TaskType",
                value: "SolidCP.EnterpriseServer.CheckWebSiteTask, SolidCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_CHECK_WEBSITES_SSL",
                column: "TaskType",
                value: "SolidCP.EnterpriseServer.CheckWebsitesSslTask, SolidCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_DELETE_EXCHANGE_ACCOUNTS",
                column: "TaskType",
                value: "SolidCP.EnterpriseServer.DeleteExchangeAccountsTask, SolidCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_DOMAIN_EXPIRATION",
                column: "TaskType",
                value: "SolidCP.EnterpriseServer.DomainExpirationTask, SolidCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_DOMAIN_LOOKUP",
                column: "TaskType",
                value: "SolidCP.EnterpriseServer.DomainLookupViewTask, SolidCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_FTP_FILES",
                column: "TaskType",
                value: "SolidCP.EnterpriseServer.FTPFilesTask, SolidCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_GENERATE_INVOICES",
                column: "TaskType",
                value: "SolidCP.Ecommerce.EnterpriseServer.GenerateInvoicesTask, SolidCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_HOSTED_SOLUTION_REPORT",
                column: "TaskType",
                value: "SolidCP.EnterpriseServer.HostedSolutionReportTask, SolidCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_NOTIFY_OVERUSED_DATABASES",
                column: "TaskType",
                value: "SolidCP.EnterpriseServer.NotifyOverusedDatabasesTask, SolidCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_RUN_PAYMENT_QUEUE",
                column: "TaskType",
                value: "SolidCP.Ecommerce.EnterpriseServer.RunPaymentQueueTask, SolidCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_RUN_SYSTEM_COMMAND",
                column: "TaskType",
                value: "SolidCP.EnterpriseServer.RunSystemCommandTask, SolidCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_SEND_MAIL",
                column: "TaskType",
                value: "SolidCP.EnterpriseServer.SendMailNotificationTask, SolidCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_SUSPEND_OVERDUE_INVOICES",
                column: "TaskType",
                value: "SolidCP.Ecommerce.EnterpriseServer.SuspendOverdueInvoicesTask, SolidCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_SUSPEND_PACKAGES",
                column: "TaskType",
                value: "SolidCP.EnterpriseServer.SuspendOverusedPackagesTask, SolidCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_USER_PASSWORD_EXPIRATION_NOTIFICATION",
                column: "TaskType",
                value: "SolidCP.EnterpriseServer.UserPasswordExpirationNotificationTask, SolidCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ScheduleTasks",
                keyColumn: "TaskID",
                keyValue: "SCHEDULE_TASK_ZIP_FILES",
                column: "TaskType",
                value: "SolidCP.EnterpriseServer.ZipFilesTask, SolidCP.EnterpriseServer.Code");

            migrationBuilder.UpdateData(
                table: "ServiceDefaultProperties",
                keyColumns: new[] { "PropertyName", "ProviderID" },
                keyValues: new object[] { "SecureFoldersModuleAssembly", 101 },
                column: "PropertyValue",
                value: "SolidCP.IIsModules.SecureFolders, SolidCP.IIsModules, Version=1.0.0.0, Culture=Neutral, PublicKeyToken=37f9c58a0aa32ff0");

            migrationBuilder.UpdateData(
                table: "ServiceDefaultProperties",
                keyColumns: new[] { "PropertyName", "ProviderID" },
                keyValues: new object[] { "SecureFoldersModuleAssembly", 105 },
                column: "PropertyValue",
                value: "SolidCP.IIsModules.SecureFolders, SolidCP.IIsModules, Version=1.0.0.0, Culture=Neutral, PublicKeyToken=37f9c58a0aa32ff0");

            migrationBuilder.UpdateData(
                table: "ServiceDefaultProperties",
                keyColumns: new[] { "PropertyName", "ProviderID" },
                keyValues: new object[] { "SecureFoldersModuleAssembly", 112 },
                column: "PropertyValue",
                value: "SolidCP.IIsModules.SecureFolders, SolidCP.IIsModules, Version=1.0.0.0, Culture=Neutral, PublicKeyToken=37f9c58a0aa32ff0");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 2,
                column: "TypeName",
                value: "SolidCP.Providers.OS.HomeFolder, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 5,
                column: "TypeName",
                value: "SolidCP.Providers.Database.SqlDatabase, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 6,
                column: "TypeName",
                value: "SolidCP.Providers.Database.SqlUser, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 7,
                column: "TypeName",
                value: "SolidCP.Providers.Database.SqlDatabase, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 8,
                column: "TypeName",
                value: "SolidCP.Providers.Database.SqlUser, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 9,
                column: "TypeName",
                value: "SolidCP.Providers.FTP.FtpAccount, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 10,
                column: "TypeName",
                value: "SolidCP.Providers.Web.WebSite, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 11,
                column: "TypeName",
                value: "SolidCP.Providers.Mail.MailDomain, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 12,
                column: "TypeName",
                value: "SolidCP.Providers.DNS.DnsZone, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 13,
                column: "TypeName",
                value: "SolidCP.Providers.OS.Domain, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 14,
                column: "TypeName",
                value: "SolidCP.Providers.Statistics.StatsSite, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 15,
                column: "TypeName",
                value: "SolidCP.Providers.Mail.MailAccount, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 16,
                column: "TypeName",
                value: "SolidCP.Providers.Mail.MailAlias, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 17,
                column: "TypeName",
                value: "SolidCP.Providers.Mail.MailList, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 18,
                column: "TypeName",
                value: "SolidCP.Providers.Mail.MailGroup, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 20,
                column: "TypeName",
                value: "SolidCP.Providers.OS.SystemDSN, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 21,
                column: "TypeName",
                value: "SolidCP.Providers.Database.SqlDatabase, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 22,
                column: "TypeName",
                value: "SolidCP.Providers.Database.SqlUser, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 23,
                column: "TypeName",
                value: "SolidCP.Providers.Database.SqlDatabase, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 24,
                column: "TypeName",
                value: "SolidCP.Providers.Database.SqlUser, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 25,
                column: "TypeName",
                value: "SolidCP.Providers.Web.SharedSSLFolder, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 28,
                column: "TypeName",
                value: "SolidCP.Providers.DNS.SecondaryDnsZone, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 29,
                column: "TypeName",
                value: "SolidCP.Providers.HostedSolution.Organization, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 30,
                column: "TypeName",
                value: "SolidCP.Providers.HostedSolution.OrganizationDomain, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 31,
                column: "TypeName",
                value: "SolidCP.Providers.Database.SqlDatabase, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 32,
                column: "TypeName",
                value: "SolidCP.Providers.Database.SqlUser, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 33,
                column: "TypeName",
                value: "SolidCP.Providers.Virtualization.VirtualMachine, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 34,
                column: "TypeName",
                value: "SolidCP.Providers.Virtualization.VirtualSwitch, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 35,
                column: "TypeName",
                value: "SolidCP.Providers.Virtualization.VMInfo, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 36,
                column: "TypeName",
                value: "SolidCP.Providers.Virtualization.VirtualSwitch, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 37,
                column: "TypeName",
                value: "SolidCP.Providers.Database.SqlDatabase, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 38,
                column: "TypeName",
                value: "SolidCP.Providers.Database.SqlUser, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 39,
                column: "TypeName",
                value: "SolidCP.Providers.Database.SqlDatabase, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 40,
                column: "TypeName",
                value: "SolidCP.Providers.Database.SqlUser, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 41,
                column: "TypeName",
                value: "SolidCP.Providers.Virtualization.VirtualMachine, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 42,
                column: "TypeName",
                value: "SolidCP.Providers.Virtualization.VirtualSwitch, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 71,
                column: "TypeName",
                value: "SolidCP.Providers.Database.SqlDatabase, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 72,
                column: "TypeName",
                value: "SolidCP.Providers.Database.SqlUser, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 73,
                column: "TypeName",
                value: "SolidCP.Providers.Database.SqlDatabase, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 74,
                column: "TypeName",
                value: "SolidCP.Providers.Database.SqlUser, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 75,
                column: "TypeName",
                value: "SolidCP.Providers.Database.SqlDatabase, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 76,
                column: "TypeName",
                value: "SolidCP.Providers.Database.SqlUser, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 77,
                column: "TypeName",
                value: "SolidCP.Providers.Database.SqlDatabase, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 78,
                column: "TypeName",
                value: "SolidCP.Providers.Database.SqlUser, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 79,
                column: "TypeName",
                value: "SolidCP.Providers.Database.SqlDatabase, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 80,
                column: "TypeName",
                value: "SolidCP.Providers.Database.SqlUser, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 90,
                column: "TypeName",
                value: "SolidCP.Providers.Database.SqlDatabase, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 91,
                column: "TypeName",
                value: "SolidCP.Providers.Database.SqlUser, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 143,
                column: "TypeName",
                value: "SolidCP.Providers.Virtualization.VirtualMachine, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 144,
                column: "TypeName",
                value: "SolidCP.Providers.Virtualization.VirtualSwitch, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 200,
                column: "TypeName",
                value: "SolidCP.Providers.SharePoint.SharePointSiteCollection, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 202,
                column: "TypeName",
                value: "SolidCP.Providers.Database.SqlDatabase, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 203,
                column: "TypeName",
                value: "SolidCP.Providers.Database.SqlUser, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 204,
                column: "TypeName",
                value: "SolidCP.Providers.SharePoint.SharePointEnterpriseSiteCollection, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 205,
                column: "TypeName",
                value: "SolidCP.Providers.Database.SqlDatabase, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "ServiceItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 206,
                column: "TypeName",
                value: "SolidCP.Providers.Database.SqlUser, SolidCP.Providers.Base");

            migrationBuilder.UpdateData(
                table: "SystemSettings",
                keyColumns: new[] { "PropertyName", "SettingsName" },
                keyValues: new object[] { "MfaTokenAppDisplayName", "AuthenticationSettings" },
                column: "PropertyValue",
                value: "SolidCP");

            migrationBuilder.UpdateData(
                table: "Themes",
                keyColumn: "ThemeID",
                keyValue: 1,
                column: "DisplayName",
                value: "SolidCP v1");

            migrationBuilder.UpdateData(
                table: "UserSettings",
                keyColumns: new[] { "PropertyName", "SettingsName", "UserID" },
                keyValues: new object[] { "HtmlBody", "AccountSummaryLetter", 1 },
                column: "PropertyValue",
                value: "<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n<head>\r\n    <title>Account Summary Information</title>\r\n    <style type=\"text/css\">\r\n		.Summary { background-color: ##ffffff; padding: 5px; }\r\n		.Summary .Header { padding: 10px 0px 10px 10px; font-size: 16pt; background-color: ##E5F2FF; color: ##1F4978; border-bottom: solid 2px ##86B9F7; }\r\n        .Summary A { color: ##0153A4; }\r\n        .Summary { font-family: Tahoma; font-size: 9pt; }\r\n        .Summary H1 { font-size: 1.7em; color: ##1F4978; border-bottom: dotted 3px ##efefef; }\r\n        .Summary H2 { font-size: 1.3em; color: ##1F4978; }\r\n        .Summary TABLE { border: solid 1px ##e5e5e5; }\r\n        .Summary TH,\r\n        .Summary TD.Label { padding: 5px; font-size: 8pt; font-weight: bold; background-color: ##f5f5f5; }\r\n        .Summary TD { padding: 8px; font-size: 9pt; }\r\n        .Summary UL LI { font-size: 1.1em; font-weight: bold; }\r\n        .Summary UL UL LI { font-size: 0.9em; font-weight: normal; }\r\n    </style>\r\n</head>\r\n<body>\r\n<div class=\"Summary\">\r\n\r\n<a name=\"top\"></a>\r\n<div class=\"Header\">\r\n	Hosting Account Information\r\n</div>\r\n\r\n<ad:if test=\"#Signup#\">\r\n<p>\r\nHello #user.FirstName#,\r\n</p>\r\n\r\n<p>\r\nNew user account has been created and below you can find its summary information.\r\n</p>\r\n\r\n<h1>Control Panel URL</h1>\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>Control Panel URL</th>\r\n            <th>Username</th>\r\n            <th>Password</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n        <tr>\r\n            <td><a href=\"http://panel.HostingCompany.com\">http://panel.HostingCompany.com</a></td>\r\n            <td>#user.Username#</td>\r\n            <td>#user.Password#</td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n</ad:if>\r\n\r\n<h1>Hosting Spaces</h1>\r\n<p>\r\n    The following hosting spaces have been created under your account:\r\n</p>\r\n<ad:foreach collection=\"#Spaces#\" var=\"Space\" index=\"i\">\r\n<h2>#Space.PackageName#</h2>\r\n<table>\r\n	<tbody>\r\n		<tr>\r\n			<td class=\"Label\">Hosting Plan:</td>\r\n			<td>\r\n				<ad:if test=\"#not(isnull(Plans[Space.PlanId]))#\">#Plans[Space.PlanId].PlanName#<ad:else>System</ad:if>\r\n			</td>\r\n		</tr>\r\n		<ad:if test=\"#not(isnull(Plans[Space.PlanId]))#\">\r\n		<tr>\r\n			<td class=\"Label\">Purchase Date:</td>\r\n			<td>\r\n# Space.PurchaseDate#\r\n			</td>\r\n		</tr>\r\n		<tr>\r\n			<td class=\"Label\">Disk Space, MB:</td>\r\n			<td><ad:NumericQuota space=\"#SpaceContexts[Space.PackageId]#\" quota=\"OS.Diskspace\" /></td>\r\n		</tr>\r\n		<tr>\r\n			<td class=\"Label\">Bandwidth, MB/Month:</td>\r\n			<td><ad:NumericQuota space=\"#SpaceContexts[Space.PackageId]#\" quota=\"OS.Bandwidth\" /></td>\r\n		</tr>\r\n		<tr>\r\n			<td class=\"Label\">Maximum Number of Domains:</td>\r\n			<td><ad:NumericQuota space=\"#SpaceContexts[Space.PackageId]#\" quota=\"OS.Domains\" /></td>\r\n		</tr>\r\n		<tr>\r\n			<td class=\"Label\">Maximum Number of Sub-Domains:</td>\r\n			<td><ad:NumericQuota space=\"#SpaceContexts[Space.PackageId]#\" quota=\"OS.SubDomains\" /></td>\r\n		</tr>\r\n		</ad:if>\r\n	</tbody>\r\n</table>\r\n</ad:foreach>\r\n\r\n<ad:if test=\"#Signup#\">\r\n<p>\r\nIf you have any questions regarding your hosting account, feel free to contact our support department at any time.\r\n</p>\r\n\r\n<p>\r\nBest regards,<br />\r\nSolidCP.<br />\r\nWeb Site: <a href=\"https://fusecp.com\">https://fusecp.com</a><br />\r\nE-Mail: <a href=\"mailto:support@fusecp.com\">support@fusecp.com</a>\r\n</p>\r\n</ad:if>\r\n\r\n<ad:template name=\"NumericQuota\">\r\n	<ad:if test=\"#space.Quotas.ContainsKey(quota)#\">\r\n		<ad:if test=\"#space.Quotas[quota].QuotaAllocatedValue isnot -1#\">#space.Quotas[quota].QuotaAllocatedValue#<ad:else>Unlimited</ad:if>\r\n	<ad:else>\r\n		0\r\n	</ad:if>\r\n</ad:template>\r\n\r\n</div>\r\n</body>\r\n</html>");

            migrationBuilder.UpdateData(
                table: "UserSettings",
                keyColumns: new[] { "PropertyName", "SettingsName", "UserID" },
                keyValues: new object[] { "Subject", "AccountSummaryLetter", 1 },
                column: "PropertyValue",
                value: "<ad:if test=\"#Signup#\">SolidCP  account has been created for<ad:else>SolidCP  account summary for</ad:if> #user.FirstName# #user.LastName#");

            migrationBuilder.UpdateData(
                table: "UserSettings",
                keyColumns: new[] { "PropertyName", "SettingsName", "UserID" },
                keyValues: new object[] { "TextBody", "AccountSummaryLetter", 1 },
                column: "PropertyValue",
                value: "=================================\r\n   Hosting Account Information\r\n=================================\r\n<ad:if test=\"#Signup#\">Hello #user.FirstName#,\r\n\r\nNew user account has been created and below you can find its summary information.\r\n\r\nControl Panel URL: https://panel.fusecp.com\r\nUsername: #user.Username#\r\nPassword: #user.Password#\r\n</ad:if>\r\n\r\nHosting Spaces\r\n==============\r\nThe following hosting spaces have been created under your account:\r\n\r\n<ad:foreach collection=\"#Spaces#\" var=\"Space\" index=\"i\">\r\n=== #Space.PackageName# ===\r\nHosting Plan: <ad:if test=\"#not(isnull(Plans[Space.PlanId]))#\">#Plans[Space.PlanId].PlanName#<ad:else>System</ad:if>\r\n<ad:if test=\"#not(isnull(Plans[Space.PlanId]))#\">Purchase Date: #Space.PurchaseDate#\r\nDisk Space, MB: <ad:NumericQuota space=\"#SpaceContexts[Space.PackageId]#\" quota=\"OS.Diskspace\" />\r\nBandwidth, MB/Month: <ad:NumericQuota space=\"#SpaceContexts[Space.PackageId]#\" quota=\"OS.Bandwidth\" />\r\nMaximum Number of Domains: <ad:NumericQuota space=\"#SpaceContexts[Space.PackageId]#\" quota=\"OS.Domains\" />\r\nMaximum Number of Sub-Domains: <ad:NumericQuota space=\"#SpaceContexts[Space.PackageId]#\" quota=\"OS.SubDomains\" />\r\n</ad:if>\r\n</ad:foreach>\r\n\r\n<ad:if test=\"#Signup#\">If you have any questions regarding your hosting account, feel free to contact our support department at any time.\r\n\r\nBest regards,\r\nSolidCP.\r\nWeb Site: https://fusecp.com\">\r\nE-Mail: support@fusecp.com\r\n</ad:if><ad:template name=\"NumericQuota\"><ad:if test=\"#space.Quotas.ContainsKey(quota)#\"><ad:if test=\"#space.Quotas[quota].QuotaAllocatedValue isnot -1#\">#space.Quotas[quota].QuotaAllocatedValue#<ad:else>Unlimited</ad:if><ad:else>0</ad:if></ad:template>");

            migrationBuilder.UpdateData(
                table: "UserSettings",
                keyColumns: new[] { "PropertyName", "SettingsName", "UserID" },
                keyValues: new object[] { "HtmlBody", "PasswordReminderLetter", 1 },
                column: "PropertyValue",
                value: "<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n<head>\r\n    <title>Account Summary Information</title>\r\n    <style type=\"text/css\">\r\n		.Summary { background-color: ##ffffff; padding: 5px; }\r\n		.Summary .Header { padding: 10px 0px 10px 10px; font-size: 16pt; background-color: ##E5F2FF; color: ##1F4978; border-bottom: solid 2px ##86B9F7; }\r\n        .Summary A { color: ##0153A4; }\r\n        .Summary { font-family: Tahoma; font-size: 9pt; }\r\n        .Summary H1 { font-size: 1.7em; color: ##1F4978; border-bottom: dotted 3px ##efefef; }\r\n        .Summary H2 { font-size: 1.3em; color: ##1F4978; }\r\n        .Summary TABLE { border: solid 1px ##e5e5e5; }\r\n        .Summary TH,\r\n        .Summary TD.Label { padding: 5px; font-size: 8pt; font-weight: bold; background-color: ##f5f5f5; }\r\n        .Summary TD { padding: 8px; font-size: 9pt; }\r\n        .Summary UL LI { font-size: 1.1em; font-weight: bold; }\r\n        .Summary UL UL LI { font-size: 0.9em; font-weight: normal; }\r\n    </style>\r\n</head>\r\n<body>\r\n<div class=\"Summary\">\r\n\r\n<a name=\"top\"></a>\r\n<div class=\"Header\">\r\n	Hosting Account Information\r\n</div>\r\n\r\n<p>\r\nHello #user.FirstName#,\r\n</p>\r\n\r\n<p>\r\nPlease, find below details of your control panel account. The one time password was generated for you. You should change the password after login. \r\n</p>\r\n\r\n<h1>Control Panel URL</h1>\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>Control Panel URL</th>\r\n            <th>Username</th>\r\n            <th>One Time Password</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n        <tr>\r\n            <td><a href=\"http://panel.HostingCompany.com\">http://panel.HostingCompany.com</a></td>\r\n            <td>#user.Username#</td>\r\n            <td>#user.Password#</td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n\r\n\r\n<p>\r\nIf you have any questions regarding your hosting account, feel free to contact our support department at any time.\r\n</p>\r\n\r\n<p>\r\nBest regards,<br />\r\nSolidCP.<br />\r\nWeb Site: <a href=\"https://fusecp.com\">https://fusecp.com</a><br />\r\nE-Mail: <a href=\"mailto:support@fusecp.com\">support@fusecp.com</a>\r\n</p>\r\n\r\n</div>\r\n</body>\r\n</html>");

            migrationBuilder.UpdateData(
                table: "UserSettings",
                keyColumns: new[] { "PropertyName", "SettingsName", "UserID" },
                keyValues: new object[] { "TextBody", "PasswordReminderLetter", 1 },
                column: "PropertyValue",
                value: "=================================\r\n   Hosting Account Information\r\n=================================\r\n\r\nHello #user.FirstName#,\r\n\r\nPlease, find below details of your control panel account. The one time password was generated for you. You should change the password after login.\r\n\r\nControl Panel URL: https://panel.fusecp.com\r\nUsername: #user.Username#\r\nOne Time Password: #user.Password#\r\n\r\nIf you have any questions regarding your hosting account, feel free to contact our support department at any time.\r\n\r\nBest regards,\r\nSolidCP.\r\nWeb Site: https://fusecp.com\"\r\nE-Mail: support@fusecp.com");

            migrationBuilder.UpdateData(
                table: "UserSettings",
                keyColumns: new[] { "PropertyName", "SettingsName", "UserID" },
                keyValues: new object[] { "ParkingPageContent", "WebPolicy", 1 },
                column: "PropertyValue",
                value: "<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n<head>\r\n    <title>The web site is under construction</title>\r\n<style type=\"text/css\">\r\n	H1 { font-size: 16pt; margin-bottom: 4px; }\r\n	H2 { font-size: 14pt; margin-bottom: 4px; font-weight: normal; }\r\n</style>\r\n</head>\r\n<body>\r\n<div id=\"PageOutline\">\r\n	<h1>This web site has just been created from <a href=\"https://www.fusecp.com\">SolidCP </a> and it is still under construction.</h1>\r\n	<h2>The web site is hosted by <a href=\"https://fusecp.com\">SolidCP</a>.</h2>\r\n</div>\r\n</body>\r\n</html>");

            migrationBuilder.InsertData(
                table: "UserSettings",
                columns: new[] { "PropertyName", "SettingsName", "UserID", "PropertyValue" },
                values: new object[,]
                {
                    { "DemoMessage", "SolidCPPolicy", 1, "When user account is in demo mode the majority of operations are\r\ndisabled, especially those ones that modify or delete records.\r\nYou are welcome to ask your questions or place comments about\r\nthis demo on  <a href=\"http://forum.fusecp.com\"\r\ntarget=\"_blank\">SolidCP  Support Forum</a>" },
                    { "ForbiddenIP", "SolidCPPolicy", 1, "" },
                    { "PasswordPolicy", "SolidCPPolicy", 1, "True;6;20;0;1;0;True;;0;;;False;False;0;" }
                });
        }
    }
}
