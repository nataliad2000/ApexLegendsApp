using System;
using System.Collections.Generic;
using System.Text;

namespace ApexLegendsApp.Model
{
    public class EUWest
    {
        public string Status { get; set; }
        public int HTTPCode { get; set; }
        public int ResponseTime { get; set; }
        public int QueryTimestamp { get; set; }
        public string ToString
        {
            get => $" {Status}, {HTTPCode}, {ResponseTime}, {QueryTimestamp}";
        }
    }
    public class EUEast
    {
        public string Status { get; set; }
        public int HTTPCode { get; set; }
        public int ResponseTime { get; set; }
        public int QueryTimestamp { get; set; }
        public string ToString
        {
            get => $" {Status}, {HTTPCode}, {ResponseTime}, {QueryTimestamp}";
        }
    }
    public class USWest
    {
        public string Status { get; set; }
        public int HTTPCode { get; set; }
        public int ResponseTime { get; set; }
        public int QueryTimestamp { get; set; }
        public string ToString
        {
            get => $" {Status}, {HTTPCode}, {ResponseTime}, {QueryTimestamp}";
        }
    }
    public class USCentral
    {
        public string Status { get; set; }
        public int HTTPCode { get; set; }
        public int ResponseTime { get; set; }
        public int QueryTimestamp { get; set; }
        public string ToString
        {
            get => $" {Status}, {HTTPCode}, {ResponseTime}, {QueryTimestamp}";
        }
    }
    public class USEast
    {
        public string Status { get; set; }
        public int HTTPCode { get; set; }
        public int ResponseTime { get; set; }
        public int QueryTimestamp { get; set; }
        public string ToString
        {
            get => $" {Status}, {HTTPCode}, {ResponseTime}, {QueryTimestamp}";
        }
    }
    public class Asia
    {
        public string Status { get; set; }
        public int HTTPCode { get; set; }
        public int ResponseTime { get; set; }
        public int QueryTimestamp { get; set; }
        public string ToString
        {
            get => $" {Status}, {HTTPCode}, {ResponseTime}, {QueryTimestamp}";
        }
    }
    public class Africa
    {
        public string Status { get; set; }
        public int HTTPCode { get; set; }
        public int ResponseTime { get; set; }
        public int QueryTimestamp { get; set; }
        public string ToString
        {
            get => $" {Status}, {HTTPCode}, {ResponseTime}, {QueryTimestamp}";
        }
    }
    public class SouthAmerica
    {
        public string Status { get; set; }
        public int HTTPCode { get; set; }
        public int ResponseTime { get; set; }
        public int QueryTimestamp { get; set; }
        public string ToString
        {
            get => $" {Status}, {HTTPCode}, {ResponseTime}, {QueryTimestamp}";
        }
    }

    public class OriginLogin
    {
        public EUWest EUwest { get; set; }
        public EUEast EUeast { get; set; }
        public USWest USwest { get; set; }
        public USCentral UScentral { get; set; }
        public USEast USeast { get; set; }
        public SouthAmerica SouthAmerica { get; set; }
        public Asia Asia { get; set; }
        public Africa Africa { get; set; }
    }

    public class EANovafusion
    {
        public EUWest EUwest { get; set; }
        public EUEast EUeast { get; set; }
        public USWest USwest { get; set; }
        public USCentral UScentral { get; set; }
        public USEast USeast { get; set; }
        public SouthAmerica SouthAmerica { get; set; }
        public Asia Asia { get; set; }
        public Africa Africa { get; set; }
    }

    public class EAAccounts
    {
        public EUWest EUwest { get; set; }
        public EUEast EUeast { get; set; }
        public USWest USwest { get; set; }
        public USCentral UScentral { get; set; }
        public USEast USeast { get; set; }
        public SouthAmerica SouthAmerica { get; set; }
        public Asia Asia { get; set; }
        public Africa Africa { get; set; }
    }

    public class ApexOauthPC
    {
        public EUWest EUwest { get; set; }
        public EUEast EUeast { get; set; }
        public USWest USwest { get; set; }
        public USCentral UScentral { get; set; }
        public USEast USeast { get; set; }
        public SouthAmerica SouthAmerica { get; set; }
        public Asia Asia { get; set; }
        public Africa Africa { get; set; }
    }

    public class ApexOauthPS4
    {
        public EUWest EUwest { get; set; }
        public EUEast EUeast { get; set; }
        public USWest USwest { get; set; }
        public USCentral UScentral { get; set; }
        public USEast USeast { get; set; }
        public SouthAmerica SouthAmerica { get; set; }
        public Asia Asia { get; set; }
        public Africa Africa { get; set; }
    }

    public class ApexOauthX1
    {
        public EUWest EUwest { get; set; }
        public EUEast EUeast { get; set; }
        public USWest USwest { get; set; }
        public USCentral UScentral { get; set; }
        public USEast USeast { get; set; }
        public SouthAmerica SouthAmerica { get; set; }
        public Asia Asia { get; set; }
        public Africa Africa { get; set; }
    }

    public class MozambiquehereStatsAPI
    {
        public EUWest EUwest { get; set; }
        public EUEast EUeast { get; set; }
        public USWest USwest { get; set; }
        public USCentral UScentral { get; set; }
        public USEast USeast { get; set; }
        public SouthAmerica SouthAmerica { get; set; }
        public Asia Asia { get; set; }
        public Africa Africa { get; set; }
    }

    public class ServerStatus
    {
        public OriginLogin Origin_login { get; set; }
        public EANovafusion EA_novafusion { get; set; }
        public EAAccounts EA_accounts { get; set; }
        public ApexOauthPC ApexOauth_PC { get; set; }
        public ApexOauthPS4 ApexOauth_PS4 { get; set; }
        public ApexOauthX1 ApexOauth_X1 { get; set; }
        public MozambiquehereStatsAPI Mozambiquehere_StatsAPI { get; set; }
    }

}
