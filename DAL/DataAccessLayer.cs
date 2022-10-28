using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class DataAccessLayer
    {
        static string connString = "Data Source = localhost; Initial Catalog = ProjectDB; Integrated Security = true";
        SqlConnection dbConn = new SqlConnection(connString);
        SqlCommand dbComm;
        SqlDataAdapter dbAdapter;
        DataTable dt;

        //Inserting PropertyType
        public int InsertPropertyType(PropertyType pt)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertPropertyType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@PropertyTypeDescription", pt.PropertyTypeDescription);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        //Displaying PropertyType
        public DataTable DisplayPropertyType()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DisplayPropertyType", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }

        //Inserting Province information
        public int InsertProvince(Province prov)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertProvince", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ProvinceDescription", prov.ProvinceDescription);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        //Displaying Province
        public DataTable DisplayProvince()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DisplayProvince", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        //Inserting City Information
        public int InsertCity(City city)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertCity", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@CityDescription", city.CityDescription);
            dbComm.Parameters.AddWithValue("@ProvinceID", city.ProvinceID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        //Displaying City
        public DataTable DisplayCity()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DisplayCity", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        //Loading Province ComboBox
        public DataTable LoadProvince()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_ProvinceCombo", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }


        //Insert Suburb information
        public int InsertSuburb(Suburb suburb)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertSuburb", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@SuburbDescription", suburb.SuburbDescription);
            dbComm.Parameters.AddWithValue("@PostalCode", suburb.PostalCode);
            dbComm.Parameters.AddWithValue("@CityID", suburb.CityID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }


        //Displaying Suburb
        public DataTable DisplaySuburb()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DisplaySuburb", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        //Load CityComboBox
        public DataTable LoadCity()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_CityCombo", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }



        //Inserting Agency information
        public int InsertAgency(Agency agency)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertAgency", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AgencyName", agency.AgencyName);
            dbComm.Parameters.AddWithValue("@SuburbID", agency.SuburbID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }


        //displaying Agency
        public DataTable DisplayAgency()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DisplayAgency", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }


        //Loading Suburb ComboBox
        public DataTable LoadSuburb()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_SuburbCombo", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        //Deleting Agency

        public int DeteteAgency(Agency agency)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DeleteAgency", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AgencyID", agency.AgencyID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        //Adding Agent
        public int InsertAgent(Agent agent)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Name", agent.Name);
            dbComm.Parameters.AddWithValue("@Surname", agent.Surname);
            dbComm.Parameters.AddWithValue("@Email", agent.Email);
            dbComm.Parameters.AddWithValue("@Password", agent.Password);
            dbComm.Parameters.AddWithValue("@Phone", agent.Phone);
            dbComm.Parameters.AddWithValue("@Status", agent.Status);
            dbComm.Parameters.AddWithValue("@AgencyID", agent.AgencyID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        //Displaying Agent
        public DataTable DisplayAgent()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DisplayAgent", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        //Deleting Agent
        public int DeleteAgent(Agent agent)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DeleteAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AgentID", agent.AgentID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        //Updating Agent
        public int UpdateAgent(Agent agent)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_UpdateAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AgentID", agent.AgentID);
            dbComm.Parameters.AddWithValue("@Email", agent.Email);
            dbComm.Parameters.AddWithValue("@Phone", agent.Phone);
            dbComm.Parameters.AddWithValue("@Status", agent.Status);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        //Agency ComboBox
        public DataTable LoadAgency()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_AgencyCombo", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        //Insert Tenant
        public int InsertTenant(Tenant tenant)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertTenant", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Name", tenant.Name);
            dbComm.Parameters.AddWithValue("@Surname", tenant.Surname);
            dbComm.Parameters.AddWithValue("@Email", tenant.Email);
            dbComm.Parameters.AddWithValue("@Password", tenant.Password);
            dbComm.Parameters.AddWithValue("@Phone", tenant.Phone);
            dbComm.Parameters.AddWithValue("@Status", tenant.Status);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        //Display Tenant
        public DataTable DisplayTenant()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DisplayTenant", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        //Updating Tenant
        public int UpdateTenant(Tenant tenant)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_UpdateTenant", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AgentID", tenant.TenantID);
            dbComm.Parameters.AddWithValue("@Email", tenant.Email);
            dbComm.Parameters.AddWithValue("@Phone", tenant.Phone);
            dbComm.Parameters.AddWithValue("@Status", tenant.Status);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        //Deleting Tenant
        public int DeleteTenant(Tenant tenant)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DeleteTenant", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@TenantID", tenant.TenantID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        //Inserting Property Details
        public int InsertProperty(Propertly propertly)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertProperty", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Description", propertly.Description);
            dbComm.Parameters.AddWithValue("@Price", propertly.Price);
            dbComm.Parameters.AddWithValue("@Image", propertly.Image);
            dbComm.Parameters.AddWithValue("@PropertyTypeID", propertly.PropertyTypeID);
            dbComm.Parameters.AddWithValue("@Status", propertly.Status);
            dbComm.Parameters.AddWithValue("@SuburbID", propertly.SuburbID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        //Displaying Property
        public DataTable DisplayProperty()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DisplayProperty", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        // Update Property
        public int UpdateProperty(Propertly propertly)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_UpdateProperty", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@PropertyID", propertly.PropertyID);
            dbComm.Parameters.AddWithValue("@Price", propertly.Price);
            dbComm.Parameters.AddWithValue("@PropertyTypeID", propertly.PropertyTypeID);
            dbComm.Parameters.AddWithValue("@Status", propertly.Status);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        //Delete Property
        public int DeleteProperty(Propertly propertly)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DeleteProperty", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@PropertyID", propertly.PropertyID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        //PropertyType ComboBox
        public DataTable LoadPropertyType()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_PropertyTypeCombo", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        //Inserting PropertyAgent
        public int InsertPropertyAgent(PropertyAgent propertygent)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertPropertyAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@PropertyID", propertygent.PropertyID);
            dbComm.Parameters.AddWithValue("@AgentID", propertygent.AgentID);
            dbComm.Parameters.AddWithValue("@Date", propertygent.Date);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        //Updating PropertyAgent
        public int UpdateProprtyAgent(PropertyAgent propertyagent)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_UpdatePropertyAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@PropertyAgentID", propertyagent.PropertyAgentID);
            dbComm.Parameters.AddWithValue("@PropertyID", propertyagent.PropertyID);
            dbComm.Parameters.AddWithValue("@AgentID", propertyagent.AgentID);
            dbComm.Parameters.AddWithValue("@Date", propertyagent.Date);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        //Displaying PropertyAgent
        public DataTable DisplayPropertyAgent()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DisplayPropertyAgent", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        //Property Combo
        public DataTable LoadProperty()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_PropertyCombo", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        //Agent Combo
        public DataTable LoadAgent()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_AgentCombo", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        //Inserting Rental
        public int InsertRental(Rental rental)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertRental", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@PropertyAgentID", rental.PropertyAgentID);
            dbComm.Parameters.AddWithValue("@TenantID", rental.TenantID);
            dbComm.Parameters.AddWithValue("@StartDate", rental.StartDate);
            dbComm.Parameters.AddWithValue("@EndDate", rental.EndDate);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        //Updating Rental
        public int UpdateRental(Rental rental)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_UpdateRental", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@RentalID", rental.RentalID);
            dbComm.Parameters.AddWithValue("@StartDate", rental.StartDate);
            dbComm.Parameters.AddWithValue("@EndDate", rental.EndDate);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        //Displaying Rental
        public DataTable DisplayRental()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DisplayRental", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        //PropertyAgent combo
        public DataTable LoadPropertyAgent()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_PropertyAgentCombo", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }


        //Tenant Combo
        public DataTable LoadTenant()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_TenantCombo", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        // Tenant Login
        public DataTable TenantLogin(string email, string password)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_TenantLogin", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Email", email);
            dbComm.Parameters.AddWithValue("@Password", password);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        //Agent login
        public DataTable AgentLogin(string email, string password)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_AgentLogin", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Email", email);
            dbComm.Parameters.AddWithValue("@Password", password);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        // Admin login
        public DataTable AdminLogin(string email, string password)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_AdminLogin", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Email", email);
            dbComm.Parameters.AddWithValue("@Password", password);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        public DataTable GetPropertyByName(string description)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetPropertyByNameReport", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Description", description);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        public DataTable GetPropertyTypeByName(string description)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetPropertyTypeByNameReport", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@PropertyTypeDescription", description);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        public DataTable GetCityReport(string city)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetCityReport", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@CityDescription", city);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        public DataTable GetSuburbReport(string suburb)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetSuburbReport", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@SuburbDescription", suburb);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        public DataTable GetProvinceReport(string province)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetProvinceReport", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ProvinceDescription", province);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        public DataTable GetRentalsByTenantReport(string status)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetRentalTenantReport", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Status", status);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        public DataTable GetRentalsReport(DateTime startDate, DateTime endDate)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetRentalReport", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StartDate", startDate);
            dbComm.Parameters.AddWithValue("@EndDate", endDate);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        public DataTable GetRentalsByPriceReport(double price)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetRentalsByAmount", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Price", price);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        public DataTable GetAgentReport()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DisplayAgentReport", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        public DataTable GetAdminReport()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DisplayAdminReport", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        public DataTable GetTenantReport()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DisplayTenantReport", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        public DataTable GetAgentByName(string name)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetAgentByNameReport", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Name", name);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        public DataTable GetAdminByName(string name)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DisplayAdminByNameReport", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Name", name);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }


        public DataTable GetTenantByName(string name)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DisplayTenantByNameReport", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Name", name);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        public int InsertAdmin(Admin admin)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_InsertAdmin", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Name", admin.Name);
            dbComm.Parameters.AddWithValue("@Surname", admin.Surname);
            dbComm.Parameters.AddWithValue("@Email", admin.Email);
            dbComm.Parameters.AddWithValue("@Password", admin.Password);
            dbComm.Parameters.AddWithValue("@Status", admin.Status);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public DataTable DisplayAdmin()
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_DisplayAdmin", dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }


    }
}
