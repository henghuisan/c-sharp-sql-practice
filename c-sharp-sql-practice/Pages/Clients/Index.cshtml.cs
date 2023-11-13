using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using System.Linq.Expressions;
using System.Diagnostics;


namespace c_sharp_sql_practice.Pages.Clients
{
    public class IndexModel : PageModel
    {
        public List<ClientInfo> listClients = new List<ClientInfo>();

        public void OnGet()
        {
			try
			{
				String connectionString = "Data Source=LAPTOP-JP6QO1OQ\\SQLEXPRESS;Initial Catalog=practice;Integrated Security=True;TrustServerCertificate=true";

				using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "SELECT * FROM clients";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
							while (reader.Read())
                            {
                                ClientInfo clientInfo = new ClientInfo();
                                clientInfo.id = "" + reader.GetInt32(0);
                                clientInfo.name = reader.GetString(1);
                                clientInfo.email = reader.GetString(2);
                                clientInfo.phone = reader.GetString(3);
                                clientInfo.address = reader.GetString(4);
                                clientInfo.created_at = reader.GetDateTime(5).ToString();

                                listClients.Add(clientInfo);
								Debug.WriteLine(clientInfo);

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
				Debug.WriteLine("Error Exception: " + ex.ToString());
            }
        }
    }

	public class ClientInfo
	{
		public String id { get; set; }
		public String name { get; set; }
		public String email { get; set; }
		public String phone { get; set; }
		public String address { get; set; }
		public String created_at { get; set; }
	}
}
