using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PropertyType
    {
        public string PropertyTypeDescription { get; set; }
    }


    public class Province
    {
        public string ProvinceDescription { get; set; }
    }


    public class City
    {
        public string CityDescription { get; set; }
        public int ProvinceID { get; set; }
    }

    public class Agency
    {
        public int AgencyID { get; set; }
        public string AgencyName { get; set; }
        public int SuburbID { get; set; }
    }

    public class Suburb
    {
        public string SuburbDescription{ get; set; }
        public int PostalCode { get; set; }
        public int CityID { get; set; }
    }
    public class Agent
    {
        public int AgentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Phone { get; set; }
        public  string Status { get; set; }
        public int AgencyID { get; set; }
    }

    public class Tenant
    {
        public int TenantID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Phone { get; set; }
        public string Status { get; set; }
    }

    public class Propertly
    {
        public int PropertyID { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public byte[] Image { get; set; }
        public int PropertyTypeID { get; set; }
        public string Status { get; set; }
        public int SuburbID { get; set; }

    }

    public class PropertyAgent
    {
        public int PropertyAgentID { get; set; }
        public int PropertyID { get; set; }
        public int AgentID { get; set; }
        public DateTime Date { get; set; }
    }

    public class Rental
    {
        public int RentalID { get; set; }
        public int PropertyAgentID { get; set; }
        public int TenantID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public class Admin
    {
        public int AdminID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
    }

}
