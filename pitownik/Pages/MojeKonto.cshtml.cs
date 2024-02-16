using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using pitownik.context;
using System.Data.SqlClient;
using System.IO;

namespace pitownik.Pages
{
    public class MojeKontoModel : PageModel
    {
        private readonly ILogger<MojeKontoModel> _logger;

        private AppDbContext _db;

        private int pitlicznik =  0;

        public List<pityTabela> pity_tabela = new List<pityTabela>();

        public int licznikPIT { get { return pitlicznik; } }


        public MojeKontoModel(ILogger<MojeKontoModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("email")))
            {
                return RedirectToPage("Index");
            }

            HttpContext.Session.Remove("pobierz");



            string query = "SELECT * FROM pit JOIN konta ON konta_id = id_konta WHERE email = '"+HttpContext.Session.GetString("email")+"'";

            string connectionDB = "Server=(LocalDb)\\MSSQLLocalDB;Database=pitownik;trusted_connection=true";
            SqlConnection conn = new SqlConnection(connectionDB);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                pitlicznik++;
                pity_tabela.Add(new pityTabela() { id = int.Parse(reader[0].ToString()), nazwa = reader[29].ToString(), data = reader[28].ToString() });
            }

            conn.Close();


            return Page();
        }

        public IActionResult OnPostUsun()
        {
            string id = Request.Form["id"];

            string id_A = "", id_B1 = "", id_B2 = "", id_C = "", id_D1 = "", id_D2 = "", id_E = "", id_F = "", id_G = "", id_H = "", id_I = "", id_J = "", id_K = "", id_L = "", id_M = "", id_N = "", id_O = "";

            string query = "SELECT * FROM pit JOIN konta ON konta_id = id_konta WHERE email = '" + HttpContext.Session.GetString("email") + "' AND id_pit = '"+id+"'";

            string connectionDB = "Server=(LocalDb)\\MSSQLLocalDB;Database=pitownik;trusted_connection=true";
            SqlConnection conn = new SqlConnection(connectionDB);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                id_A = reader[11].ToString();
                id_B1 = reader[12].ToString();
                id_B2 = reader[13].ToString();
                id_C = reader[14].ToString();
                id_D1 = reader[15].ToString();
                id_D2 = reader[16].ToString();
                id_E = reader[17].ToString();
                id_F = reader[18].ToString();
                id_G = reader[19].ToString();
                id_H = reader[20].ToString();
                id_I = reader[21].ToString();
                id_J = reader[22].ToString();
                id_K = reader[23].ToString();
                id_L = reader[24].ToString();
                id_M = reader[25].ToString();
                id_N = reader[26].ToString();
                id_O = reader[27].ToString();

            }
            reader.Close();

            query = "DELETE FROM pit where id_pit = " + id;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            query = "DELETE FROM podpunkt_A where id_A = " + id_A;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            query = "DELETE FROM podpunkt_B1 where id_B1 = " + id_B1;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            query = "DELETE FROM podpunkt_B2 where id_B2 = " + id_B2;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            query = "DELETE FROM podpunkt_C where id_C = " + id_C;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            query = "DELETE FROM podpunkt_D1 where id_D1 = " + id_D1;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            query = "DELETE FROM podpunkt_D2 where id_D2 = " + id_D2;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            query = "DELETE FROM podpunkt_E where id_E = " + id_E;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            query = "DELETE FROM podpunkt_F where id_F = " + id_F;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            query = "DELETE FROM podpunkt_G where id_G = " + id_G;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            query = "DELETE FROM podpunkt_H where id_H = " + id_H;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            query = "DELETE FROM podpunkt_I where id_I = " + id_I;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            query = "DELETE FROM podpunkt_J where id_J = " + id_J;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            query = "DELETE FROM podpunkt_K where id_K = " + id_K;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            query = "DELETE FROM podpunkt_L where id_L = " + id_L;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            query = "DELETE FROM podpunkt_M where id_M = " + id_M;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            query = "DELETE FROM podpunkt_N where id_N = " + id_N;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            query = "DELETE FROM podpunkt_O where id_O = " + id_O;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();


            conn.Close();

            return RedirectToPage("MojeKonto");
        }

        public IActionResult OnPostEdytuj()
        {
            HttpContext.Session.SetString("edytujpit", Request.Form["id"]);

            return RedirectToPage("DodajPit", "Edytujpit");
        }

        public IActionResult OnPostPobierz()
        {
            HttpContext.Session.SetString("edytujpit", Request.Form["id"]);
            HttpContext.Session.SetString("pobierz", "TRUE");

            return RedirectToPage("DodajPit", "Edytujpit");
        }


        public class pityTabela
        {
            public int id { get; set; }
            public string nazwa { get; set; }
            public string data { get; set; }

        }
    }
}
