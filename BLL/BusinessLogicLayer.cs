using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    
    public class BusinessLogicLayer
    {
        DataAccessLayer dal = new DataAccessLayer();

        public int InsertPropertyType(PropertyType pt)
        {
            return dal.InsertPropertyType(pt);
        }

        public DataTable DisplayPropertyType()
        {
            return dal.DisplayPropertyType();
        }

        public int InsertProvince(Province prov)
        {
            return dal.InsertProvince(prov);
        }

        public DataTable DisplayProvince()
        {
            return dal.DisplayProvince();
        }

        public int InsertCity(City city)
        {
            return dal.InsertCity(city);
        }

        public DataTable DisplayCity()
        {
            return dal.DisplayCity();
        }

        public DataTable LoadProvince()
        {
            return dal.LoadProvince();
        }

        public int InsertAgency(Agency agency)
        {
            return dal.InsertAgency(agency);
        }

        public DataTable DisplayAgency()
        {
            return dal.DisplayAgency();
        }
        public DataTable LoadSuburb()
        {
            return dal.LoadSuburb();
        }

        public int InsertSuburb(Suburb suburb)
        {
            return dal.InsertSuburb(suburb);
        }

        public DataTable DisplaySuburb()
        {
            return dal.DisplaySuburb();
        }

        public DataTable LoadCity()
        {
            return dal.LoadCity();
        }

        public int DeleteAgency(Agency agency)
        {
            return dal.DeteteAgency(agency);
        }

        public int InsertAgent(Agent agent)
        {
            return dal.InsertAgent(agent);
        }

        public DataTable DisplayAgent()
        {
            return dal.DisplayAgent();
        }

        public int DeleteAgent(Agent agent)
        {
            return dal.DeleteAgent(agent);
        }

        public int UpdateAgent(Agent agent)
        {
            return dal.UpdateAgent(agent);
        }

        public DataTable LoadAgency()
        {
            return dal.LoadAgency();
        }

        public int InsertTenant(Tenant tenant)
        {
            return dal.InsertTenant(tenant);
        }

        public DataTable DisplayTenant()
        {
            return dal.DisplayTenant();
        }

        public int UpdateTenant(Tenant tenant)
        {
            return dal.UpdateTenant(tenant);
        }

        public int DeleteTenant(Tenant tenant)
        {
            return dal.DeleteTenant(tenant);
        }

        public int InsertProperty(Propertly propertly)
        {
            return dal.InsertProperty(propertly);
        }

        public DataTable DisplayProperty()
        {
            return dal.DisplayProperty();
        }

        public int UpdateProperty(Propertly propertly)
        {
            return dal.UpdateProperty(propertly);
        }

        public int DeleteProperty(Propertly propertly)
        {
            return dal.DeleteProperty(propertly);
        }

        public DataTable LoadPropertyType()
        {
            return dal.LoadPropertyType();
        }

        public int InsertPropertyAgent(PropertyAgent propertygent)
        {
            return dal.InsertPropertyAgent(propertygent);
        }

        public int UpdateProprtyAgent(PropertyAgent propertyagent)
        {
            return dal.UpdateProprtyAgent(propertyagent);
        }

        public DataTable DisplayPropertyAgent()
        {
            return dal.DisplayPropertyAgent();
        }

        public DataTable LoadProperty()
        {
            return dal.LoadProperty();
        }

        public DataTable LoadAgent()
        {
            return dal.LoadAgent();
        }

        public int InsertRental(Rental rental)
        {
            return dal.InsertRental(rental);
        }

        public int UpdateRental(Rental rental)
        {
            return dal.UpdateRental(rental);
        }

        public DataTable DisplayRental()
        {
            return dal.DisplayRental();
        }

        public DataTable LoadPropertyAgent()
        {
            return dal.LoadPropertyAgent();
        }

        public DataTable LoadTenant()
        {
            return dal.LoadTenant();
        }

        public DataTable TenantLogin(string email, string password)
        {
            return dal.TenantLogin(email, password);
        }
        public DataTable AgentLogin(string email, string password)
        {
            return dal.AgentLogin(email, password);
        }
        public DataTable AdminLogin(string email, string password)
        {
            return dal.AdminLogin(email, password);
        }

        public DataTable GetPropertyByName(string description)
        {
            return dal.GetPropertyByName(description);
        }
        public DataTable GetPropertyTypeByName(string description)
        {
            return dal.GetPropertyTypeByName(description);
        }

        public DataTable GetCityReport(string city)
        {
            return dal.GetCityReport(city);
        }

        public DataTable GetSuburbReport(string suburb)
        {
            return dal.GetSuburbReport(suburb);
        }

        public DataTable GetProvinceReport(string province)
        {
            return dal.GetProvinceReport(province);
        }

        public DataTable GetRentalsByTenantReport(string status)
        {
            return dal.GetRentalsByTenantReport(status);
        }

        public DataTable GetRentalsReport(DateTime startDate, DateTime endDate)
        {
            return dal.GetRentalsReport(startDate, endDate);
        }

        public DataTable GetRentalsByPriceReport(double price)
        {
            return dal.GetRentalsByPriceReport(price);
        }

        public DataTable GetAgentReport()
        {
            return dal.GetAgentReport();
        }

        public DataTable GetAdminReport()
        {
            return dal.GetAdminReport();
        }

        public DataTable GetTenantReport()
        {
            return dal.GetTenantReport();
        }

        public DataTable GetAgentByName(string name)
        {
            return dal.GetAgentByName(name);
        }

        public DataTable GetAAdminByName(string name)
        {
            return dal.GetAdminByName(name);
        }

        public DataTable GetTenantByName(string name)
        {
            return dal.GetTenantByName(name);
        }

        public int InsertAdmin(Admin admin)
        {
            return dal.InsertAdmin(admin);
        }

        public DataTable displayAdmin()
        {
            return dal.DisplayAdmin();
        }

    }


}
