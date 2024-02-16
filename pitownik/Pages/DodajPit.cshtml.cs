using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System.Globalization;

namespace pitownik.Pages
{
    public class DodajPitModel : PageModel
    {

        //DBO PIT
        private int id_pit, konta_id, A_id, B1_id, B2_id, C_id, D1_id, D2_id, E_id, F_id, G_id, H_id, I_id, J_id, K_id, L_id, M_id, N_id, O_id;
        public string pit_nazwa { get; set; }
        public string wartosc1 { get; set; }
        public string wartosc2 { get; set; }
        public string wartosc5 { get; set; }
        public string wartosc6_1 { get; set; }
        public string wartosc6_2 { get; set; }
        public string wartosc6_3 { get; set; }
        public string wartosc6_4 { get; set; }
        public string wartosc7 { get; set; }
        public string wartosc8 { get; set; }


        //DBO A
        public string wartosc9 { get; set; }
        public string wartosc10 { get; set; }
        public string wartosc11 { get; set; }


        //DBO B1
        public string wartosc12 { get; set; }
        public string wartosc13 { get; set; }
        public string wartosc14_1 { get; set; }
        public string wartosc14_2 { get; set; }
        public string wartosc14_3 { get; set; }
        public string wartosc15 { get; set; }
        public string wartosc16 { get; set; }
        public string wartosc17 { get; set; }
        public string wartosc18 { get; set; }
        public string wartosc19 { get; set; }
        public string wartosc20 { get; set; }
        public string wartosc21 { get; set; }
        public string wartosc22 { get; set; }
        public string wartosc23 { get; set; }

        //DBO B2
        public string wartosc24 { get; set; }
        public string wartosc25 { get; set; }
        public string wartosc26_1 { get; set; }
        public string wartosc26_2 { get; set; }
        public string wartosc26_3 { get; set; }
        public string wartosc27 { get; set; }
        public string wartosc28 { get; set; }
        public string wartosc29 { get; set; }
        public string wartosc30 { get; set; }
        public string wartosc31 { get; set; }
        public string wartosc32 { get; set; }
        public string wartosc33 { get; set; }
        public string wartosc34 { get; set; }
        public string wartosc35 { get; set; }


        //DBO C
        public string wartosc36 { get; set; }
        public string wartosc37 { get; set; }
        public string wartosc38 { get; set; }
        public string wartosc39 { get; set; }
        public string wartosc40 { get; set; }
        public string wartosc41 { get; set; }
        public string wartosc42 { get; set; }
        public string wartosc43 { get; set; }
        public string wartosc44 { get; set; }
        public string wartosc45 { get; set; }
        public string wartosc46 { get; set; }
        public string wartosc47 { get; set; }
        public string wartosc48 { get; set; }
        public string wartosc49 { get; set; }
        public string wartosc50 { get; set; }
        public string wartosc51 { get; set; }



        //DBO D1
        public string wartosc52 { get; set; }
        public string wartosc53 { get; set; }
        public string wartosc54 { get; set; }
        public string wartosc55 { get; set; }
        public string wartosc56 { get; set; }
        public string wartosc57 { get; set; }
        public string wartosc58 { get; set; }
        public string wartosc59 { get; set; }
        public string wartosc60 { get; set; }
        public string wartosc61 { get; set; }
        public string wartosc62 { get; set; }
        public string wartosc63 { get; set; }
        public string wartosc64 { get; set; }
        public string wartosc65 { get; set; }
        public string wartosc66 { get; set; }
        public string wartosc67 { get; set; }
        public string wartosc68 { get; set; }
        public string wartosc69 { get; set; }
        public string wartosc70 { get; set; }
        public string wartosc71 { get; set; }
        public string wartosc72 { get; set; }
        public string wartosc73 { get; set; }
        public string wartosc74 { get; set; }
        public string wartosc75 { get; set; }
        public string wartosc76 { get; set; }
        public string wartosc77 { get; set; }
        public string wartosc78 { get; set; }
        public string wartosc79 { get; set; }
        public string wartosc80 { get; set; }
        public string wartosc81 { get; set; }
        public string wartosc82 { get; set; }
        public string wartosc83 { get; set; }
        public string wartosc84 { get; set; }
        public string wartosc85 { get; set; }
        public string wartosc86 { get; set; }


        //DBO D2
        public string wartosc87 { get; set; }
        public string wartosc88 { get; set; }
        public string wartosc89 { get; set; }
        public string wartosc90 { get; set; }
        public string wartosc91 { get; set; }
        public string wartosc92 { get; set; }
        public string wartosc93 { get; set; }
        public string wartosc94 { get; set; }
        public string wartosc95 { get; set; }
        public string wartosc96 { get; set; }
        public string wartosc97 { get; set; }
        public string wartosc98 { get; set; }
        public string wartosc99 { get; set; }
        public string wartosc100 { get; set; }
        public string wartosc101 { get; set; }
        public string wartosc102 { get; set; }
        public string wartosc103 { get; set; }
        public string wartosc104 { get; set; }
        public string wartosc105 { get; set; }
        public string wartosc106 { get; set; }
        public string wartosc107 { get; set; }
        public string wartosc108 { get; set; }
        public string wartosc109 { get; set; }
        public string wartosc110 { get; set; }
        public string wartosc111 { get; set; }
        public string wartosc112 { get; set; }
        public string wartosc113 { get; set; }
        public string wartosc114 { get; set; }
        public string wartosc115 { get; set; }
        public string wartosc116 { get; set; }
        public string wartosc117 { get; set; }
        public string wartosc118 { get; set; }
        public string wartosc119 { get; set; }
        public string wartosc120 { get; set; }
        public string wartosc121 { get; set; }



        //DBO E
        public string wartosc122 { get; set; }
        public string wartosc123 { get; set; }
        public string wartosc124 { get; set; }
        public string wartosc125 { get; set; }
        public string wartosc126 { get; set; }
        public string wartosc127 { get; set; }
        public string wartosc128 { get; set; }


        //DBO F
        public string wartosc129 { get; set; }
        public string wartosc130 { get; set; }
        public string wartosc131 { get; set; }
        public string wartosc132 { get; set; }


        //DBO G
        public string wartosc133 { get; set; }
        public string wartosc134 { get; set; }
        public string wartosc135 { get; set; }
        public string wartosc136 { get; set; }


        //DBO H
        public string wartosc137 { get; set; }
        public string wartosc138 { get; set; }
        public string wartosc139 { get; set; }


        //DBO I
        public string wartosc140 { get; set; }
        public string wartosc141 { get; set; }
        public string wartosc142 { get; set; }
        public string wartosc143 { get; set; }
        public string wartosc144 { get; set; }
        public string wartosc145 { get; set; }

        //DBO J
        public string wartosc146 { get; set; }


        //DBO K
        public string wartosc147 { get; set; }
        public string wartosc148 { get; set; }

        //DBO L
        public string wartosc149 { get; set; }
        public string wartosc150 { get; set; }
        public string wartosc151 { get; set; }

        //DBO M
        public string wartosc152 { get; set; }
        public string wartosc153 { get; set; }
        public string wartosc154 { get; set; }
        public string wartosc155 { get; set; }
        public string wartosc156 { get; set; }
        public string wartosc157 { get; set; }
        public string wartosc158 { get; set; }

        //DBO N
        public string wartosc159_1 { get; set; }
        public string wartosc159_2 { get; set; }
        public string wartosc160 { get; set; }
        public string wartosc161 { get; set; }
        public string wartosc162 { get; set; }
        public string wartosc163 { get; set; }

        //DBO O
        public string wartosc164_1 { get; set; }
        public string wartosc164_2 { get; set; }


        public IActionResult OnGet()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("email")))
            {
                return RedirectToPage("Index");
            }
            HttpContext.Session.Remove("edytujpit");
            HttpContext.Session.Remove("pobierz");
            return Page();
        }

        public IActionResult OnPostPit()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("edytujpit")))
            {
                dodawanie();
            }
            else
            {
                usuwanie(HttpContext.Session.GetString("edytujpit"));
                dodawanie();
                HttpContext.Session.Remove("edytujpit");
            }
                
            return RedirectToPage("MojeKonto");
        }

        private void dodawanie() 
        { 
            string query;
            int id_A, id_B1, id_B2, id_C, id_D1, id_D2, id_E, id_F, id_G, id_H, id_I, id_J, id_K, id_L, id_M, id_N, id_O;

            string connectionDB = "Server=(LocalDb)\\MSSQLLocalDB;Database=pitownik;trusted_connection=true";
            SqlConnection conn = new SqlConnection(connectionDB);
            conn.Open();


            //SEKCJA A
            id_A = getID("A");

            string wartosc10 = !String.IsNullOrEmpty(Request.Form["wartosc10_1"].ToString()) ? Request.Form["wartosc10_1"] : Request.Form["wartosc10_2"];

            string wartosc11;
            if (wartosc10 == "2")
            {
                wartosc11 = !String.IsNullOrEmpty(Request.Form["wartosc11_1"].ToString()) ? Request.Form["wartosc11_1"] : Request.Form["wartosc11_2"];
            }
            else
            {
                wartosc11 = "0"; 
            }
             

            query = "INSERT INTO podpunkt_A VALUES("+id_A+",'" + Request.Form["wartosc9"] + "','" + wartosc10 + "','" + wartosc11 + "');";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();




            //SEKCJA B1
            id_B1 = getID("B1");

            query = "INSERT INTO podpunkt_B1 VALUES("+id_B1+", '"+Request.Form["wartosc12"]+"', '"+Request.Form["wartosc13"]+"', '"+Request.Form["wartosc14.1"]+"', '"+Request.Form["wartosc14.2"]+"', '"+Request.Form["wartosc14.3"]+"', '"+Request.Form["wartosc15"]+"', '"+Request.Form["wartosc16"]+"', '"+Request.Form["wartosc17"]+"', '"+Request.Form["wartosc18"]+"', '"+Request.Form["wartosc19"]+"', '"+Request.Form["wartosc20"]+"', '"+Request.Form["wartosc21"]+"', '"+Request.Form["wartosc22"]+"', '"+Request.Form["wartosc23"]+"');";

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();




            //SEKCJA B2
            id_B2 = getID("B2");

            query = "INSERT INTO podpunkt_B2 VALUES("+id_B2+", '"+Request.Form["wartosc24"]+"', '"+Request.Form["wartosc25"]+"', '"+Request.Form["wartosc26.1"]+"', '"+Request.Form["wartosc26.2"]+"', '"+Request.Form["wartosc26.3"]+"', '"+Request.Form["wartosc27"]+"', '"+Request.Form["wartosc28"]+"', '"+Request.Form["wartosc29"]+"', '"+Request.Form["wartosc30"]+"', '"+Request.Form["wartosc31"]+"', '"+Request.Form["wartosc32"]+"', '"+Request.Form["wartosc33"]+"', '"+Request.Form["wartosc34"]+"', '"+Request.Form["wartosc35"]+"');";

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();


            //SEKCJA C
            id_C = getID("C");

            int wart36 = String.IsNullOrEmpty(Request.Form["wartosc36"]) ? wart36 = 0 : wart36 = int.Parse(Request.Form["wartosc36"]);
            int wart37 = String.IsNullOrEmpty(Request.Form["wartosc37"]) ? wart37 = 0 : wart37 = int.Parse(Request.Form["wartosc37"]);
            int wart38 = String.IsNullOrEmpty(Request.Form["wartosc38"]) ? wart38 = 0 : wart38 = int.Parse(Request.Form["wartosc38"]);
            int wart39 = String.IsNullOrEmpty(Request.Form["wartosc39"]) ? wart39 = 0 : wart39 = int.Parse(Request.Form["wartosc39"]);
            int wart40 = String.IsNullOrEmpty(Request.Form["wartosc40"]) ? wart40 = 0 : wart40 = int.Parse(Request.Form["wartosc40"]);
            int wart41 = String.IsNullOrEmpty(Request.Form["wartosc41"]) ? wart41 = 0 : wart41 = int.Parse(Request.Form["wartosc41"]);
            int wart42 = String.IsNullOrEmpty(Request.Form["wartosc42"]) ? wart42 = 0 : wart42 = int.Parse(Request.Form["wartosc42"]);
            int wart43 = String.IsNullOrEmpty(Request.Form["wartosc43"]) ? wart43 = 0 : wart43 = int.Parse(Request.Form["wartosc43"]);

            query = "INSERT INTO podpunkt_C VALUES(" + id_C + ", '" + wart36 + "', '" + wart37 + "', '" + wart38 + "', '" + wart39 + "', '" + wart40 + "', '" + wart41 + "', '" + wart42 + "', '" + wart43 + "', '" + Request.Form["wartosc44"] + "', '" + Request.Form["wartosc45"] + "', '" + Request.Form["wartosc46"] + "', '" + Request.Form["wartosc47"] + "', '" + Request.Form["wartosc48"] + "', '" + Request.Form["wartosc49"] + "', '" + Request.Form["wartosc50"] + "', '" + Request.Form["wartosc51"] + "');";

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();


            //SEKCJA D1
            id_D1 = getID("D1");

            query = "INSERT INTO podpunkt_D1 VALUES(" + id_D1 + ", '" + Request.Form["wartosc52"] + "', '" + Request.Form["wartosc53"] + "', '" + Request.Form["wartosc54"] + "', '" + Request.Form["wartosc55"] + "', '" + Request.Form["wartosc56"] + "', '" + Request.Form["wartosc57"] + "', '" + Request.Form["wartosc58"] + "', '" + Request.Form["wartosc59"] + "', '" + Request.Form["wartosc60"] + "', '" + Request.Form["wartosc61"] + "', '" + Request.Form["wartosc62"] + "', '" + Request.Form["wartosc63"] + "', '" + Request.Form["wartosc64"] + "', '" + Request.Form["wartosc65"] + "', '" + Request.Form["wartosc66"] + "', '" + Request.Form["wartosc67"] + "', '" + Request.Form["wartosc68"] + "', '" + Request.Form["wartosc69"] + "', '" + Request.Form["wartosc70"] + "', '" + Request.Form["wartosc71"] + "', '" + Request.Form["wartosc72"] + "', '" + Request.Form["wartosc73"] + "', '" + Request.Form["wartosc74"] + "', '" + Request.Form["wartosc75"] + "', '" + Request.Form["wartosc76"] + "', '" + Request.Form["wartosc77"] + "', '" + Request.Form["wartosc78"] + "', '" + Request.Form["wartosc79"] + "', '" + Request.Form["wartosc80"] + "', '" + Request.Form["wartosc81"] + "', '" + Request.Form["wartosc82"] + "', '" + Request.Form["wartosc83"] + "', '" + Request.Form["wartosc84"] + "', '" + Request.Form["wartosc85"] + "', '" + Request.Form["wartosc86"] + "');";

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();


            //SEKCJA D2
            id_D2 = getID("D2");

            query = "INSERT INTO podpunkt_D2 VALUES(" + id_D2 + ", '" + Request.Form["wartosc87"] + "', '" + Request.Form["wartosc88"] + "', '" + Request.Form["wartosc89"] + "', '" + Request.Form["wartosc90"] + "', '" + Request.Form["wartosc91"] + "', '" + Request.Form["wartosc92"] + "', '" + Request.Form["wartosc93"] + "', '" + Request.Form["wartosc94"] + "', '" + Request.Form["wartosc95"] + "', '" + Request.Form["wartosc96"] + "', '" + Request.Form["wartosc97"] + "', '" + Request.Form["wartosc98"] + "', '" + Request.Form["wartosc99"] + "', '" + Request.Form["wartosc100"] + "', '" + Request.Form["wartosc101"] + "', '" + Request.Form["wartosc102"] + "', '" + Request.Form["wartosc103"] + "', '" + Request.Form["wartosc104"] + "', '" + Request.Form["wartosc105"] + "', '" + Request.Form["wartosc106"] + "', '" + Request.Form["wartosc107"] + "', '" + Request.Form["wartosc108"] + "', '" + Request.Form["wartosc109"] + "', '" + Request.Form["wartosc110"] + "', '" + Request.Form["wartosc111"] + "', '" + Request.Form["wartosc112"] + "', '" + Request.Form["wartosc113"] + "', '" + Request.Form["wartosc114"] + "', '" + Request.Form["wartosc115"] + "', '" + Request.Form["wartosc116"] + "', '" + Request.Form["wartosc117"] + "', '" + Request.Form["wartosc118"] + "', '" + Request.Form["wartosc119"] + "', '" + Request.Form["wartosc120"] + "', '" + Request.Form["wartosc121"] + "');";

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();


            //SEKCJA E
            id_E = getID("E");

            query = "INSERT INTO podpunkt_E VALUES(" + id_E + ", '" + Request.Form["wartosc122"] + "', '" + Request.Form["wartosc123"] + "', '" + Request.Form["wartosc124"] + "', '" + Request.Form["wartosc125"] + "', '" + Request.Form["wartosc126"] + "', '" + Request.Form["wartosc127"] + "', '" + Request.Form["wartosc128"] + "');";

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();


            //SEKCJA F
            id_F = getID("F");

            query = "INSERT INTO podpunkt_F VALUES(" + id_F + ", '" + Request.Form["wartosc129"] + "', '" + Request.Form["wartosc130"] + "', '" + Request.Form["wartosc131"] + "', '" + Request.Form["wartosc132"] + "');";

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();


            //SEKCJA G
            id_G = getID("G");

            query = "INSERT INTO podpunkt_G VALUES(" + id_G + ", '" + Request.Form["wartosc133"] + "', '" + Request.Form["wartosc134"] + "', '" + Request.Form["wartosc135"] + "', '" + Request.Form["wartosc136"] + "');";

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();


            //SEKCJA H
            id_H = getID("H");

            query = "INSERT INTO podpunkt_H VALUES(" + id_H + ", '" + Request.Form["wartosc137"] + "', '" + Request.Form["wartosc138"] + "', '" + Request.Form["wartosc139"] + "');";

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();


            //SEKCJA I
            id_I = getID("I");

            query = "INSERT INTO podpunkt_I VALUES(" + id_I + ", '" + Request.Form["wartosc140"] + "', '" + Request.Form["wartosc141"] + "', '" + Request.Form["wartosc142"] + "', '" + Request.Form["wartosc143"] + "', '" + Request.Form["wartosc144"] + "', '" + Request.Form["wartosc145"] + "');";

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();


            //SEKCJA J
            id_J = getID("J");

            query = "INSERT INTO podpunkt_J VALUES(" + id_J + ", '" + Request.Form["wartosc146"] + "');";

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();


            //SEKCJA K
            id_K = getID("K");

            query = "INSERT INTO podpunkt_K VALUES(" + id_K + ", '" + Request.Form["wartosc147"] + "', '" + Request.Form["wartosc148"] + "');";

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();


            //SEKCJA L
            id_L = getID("L");

            int wart150 = String.IsNullOrEmpty(Request.Form["wartosc150"]) ? wart150 = 0 : wart150 = int.Parse(Request.Form["wartosc150"]);

            query = "INSERT INTO podpunkt_L VALUES(" + id_L + ", '" + Request.Form["wartosc149"] + "', '" + wart150 + "', '" + Request.Form["wartosc151"] + "');";

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();


            //SEKCJA M
            id_M = getID("M");

            int wart156 = 0;
            if (!String.IsNullOrEmpty(Request.Form["wartosc156_1"]))
            {
                wart156 = 1;
            }
            if (!String.IsNullOrEmpty(Request.Form["wartosc156_2"]))
            {
                wart156 = 2;
            }


            int wart157 = 0;
            if (!String.IsNullOrEmpty(Request.Form["wartosc157_1"]))
            {
                wart157 = 1;
            }
            if (!String.IsNullOrEmpty(Request.Form["wartosc157_2"]))
            {
                wart157 = 2;
            }
            if (!String.IsNullOrEmpty(Request.Form["wartosc157_3"]))
            {
                wart157 = 3;
            }

            query = "INSERT INTO podpunkt_M VALUES(" + id_M + ", '" + Request.Form["wartosc152"] + "', '" + Request.Form["wartosc153"] + "', '" + Request.Form["wartosc154"] + "', '" + Request.Form["wartosc155"] + "', '" + wart156 + "', '" + wart157 + "', '" + Request.Form["wartosc158"] + "');";

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();


            //SEKCJA N
            id_N = getID("N");

            int wart159_1 = String.IsNullOrEmpty(Request.Form["wartosc159_1"]) ? wart159_1 = 0 : wart159_1 = int.Parse(Request.Form["wartosc159_1"]);
            int wart159_2 = String.IsNullOrEmpty(Request.Form["wartosc159_2"]) ? wart159_2 = 0 : wart159_2 = int.Parse(Request.Form["wartosc159_2"]);

            query = "INSERT INTO podpunkt_N VALUES(" + id_N + ", '" + wart159_1 + "', '" + wart159_2 + "', '" + Request.Form["wartosc160"] + "', '" + Request.Form["wartosc161"] + "', '" + Request.Form["wartosc162"] + "', '" + Request.Form["wartosc163"] + "');";

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();


            //SEKCJA O
            id_O = getID("O");

            int wart164_1 = String.IsNullOrEmpty(Request.Form["wartosc164_1"]) ? wart164_1 = 0 : wart164_1 = int.Parse(Request.Form["wartosc164_1"]);
            int wart164_2 = String.IsNullOrEmpty(Request.Form["wartosc164_2"]) ? wart164_2 = 0 : wart164_2 = int.Parse(Request.Form["wartosc164_2"]);

            query = "INSERT INTO podpunkt_O VALUES(" + id_O + ", '" + wart164_1 + "', '" + wart164_2 + "');";

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            conn.Close();


            //SEKCJA PIT
            query = "SELECT TOP 1 id_pit FROM pit ORDER BY id_pit desc;";
            int id_pit = 0;
            int id_acc = int.Parse(HttpContext.Session.GetString("id_acc"));
            var date = DateTime.Now.ToString("dd.MM.yyyy");

            int wart6_1 = String.IsNullOrEmpty(Request.Form["wartosc6.1"]) ? wart6_1 = 0 : wart6_1 = int.Parse(Request.Form["wartosc6.1"]);
            int wart6_2 = String.IsNullOrEmpty(Request.Form["wartosc6.2"]) ? wart6_2 = 0 : wart6_2 = int.Parse(Request.Form["wartosc6.2"]);
            int wart6_3 = String.IsNullOrEmpty(Request.Form["wartosc6.3"]) ? wart6_3 = 0 : wart6_3 = int.Parse(Request.Form["wartosc6.3"]);
            int wart6_4 = String.IsNullOrEmpty(Request.Form["wartosc6.4"]) ? wart6_4 = 0 : wart6_4 = int.Parse(Request.Form["wartosc6.4"]);
            int wart7 = String.IsNullOrEmpty(Request.Form["wartosc7"]) ? wart7 = 0 : wart7 = int.Parse(Request.Form["wartosc7"]);
            int wart8 = String.IsNullOrEmpty(Request.Form["wartosc8"]) ? wart8 = 0 : wart8 = int.Parse(Request.Form["wartosc8"]);


            string con_string = "Server=(LocalDb)\\MSSQLLocalDB;Database=pitownik;trusted_connection=true";
            SqlConnection connect = new SqlConnection(con_string);
            connect.Open();
            SqlCommand cmd2 = new SqlCommand(query, connect);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                id_pit = int.Parse(reader2[0].ToString());
            }
            id_pit++;

            query = "INSERT INTO pit VALUES(" + id_pit + ", " + id_acc + ", '" + Request.Form["wartosc1"] + "', '" + Request.Form["wartosc2"] + "', '" + Request.Form["wartosc5"] + "', '" + wart6_1 + "', '" + wart6_2 + "', '" + wart6_3 + "', '" + wart6_4 + "', '" + wart7 + "', '" + wart8 + "', " + id_A + ", " + id_B1 + ", " + id_B2 + ", " + id_C + ", " + id_D1 + ", " + id_D2 + ", " + id_E + ", " + id_F + ", " + id_G + ", " + id_H + ", " + id_I + ", " + id_J + ", " + id_K + ", " + id_L + ", " + id_M + ", " + id_N + ", " + id_O + ", '" + date + "', '" + Request.Form["wartosc13"] + " " +Request.Form["wartosc12"] + " "+Request.Form["wartosc5"] + " #" + id_pit + "');";

            reader2.Close();
            cmd2.CommandText = query;
            cmd2.ExecuteNonQuery();

            connect.Close();
        }

        private void usuwanie(string x)
        {
            string id = x;

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
        }
        public void OnGetEdytujpit()
        {
            try
            {
                id_pit = int.Parse(HttpContext.Session.GetString("edytujpit"));
                pobierzDane(id_pit);
            }
            catch
            {
                HttpContext.Session.Remove("edytujpit");
                HttpContext.Session.Remove("pobierz");
                RedirectToPage("DodajPit","");
            }
            
        }


        private int getID(string s)
        {   
            int id = 0;
            try
            {

                string query = "SELECT TOP 1 id_"+s+" FROM podpunkt_"+s+" ORDER BY id_"+s+" desc;";

                string connectionDB = "Server=(LocalDb)\\MSSQLLocalDB;Database=pitownik;trusted_connection=true";
                SqlConnection conn = new SqlConnection(connectionDB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = int.Parse(reader[0].ToString());
                }

                conn.Close();
                reader.Close();
                
                return (id+1);

            }
            catch 
            { 
                return 1;   
            }
            
        }

        private void pobierzDane(int id)
        {
            string query = "SELECT * FROM pit WHERE id_pit = "+id+";";

            string connectionDB = "Server=(LocalDb)\\MSSQLLocalDB;Database=pitownik;trusted_connection=true";
            SqlConnection conn = new SqlConnection(connectionDB);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                konta_id = int.Parse(reader[1].ToString());
                A_id = int.Parse(reader[11].ToString());
                B1_id = int.Parse(reader[12].ToString());
                B2_id = int.Parse(reader[13].ToString());
                C_id = int.Parse(reader[14].ToString());
                D1_id = int.Parse(reader[15].ToString());
                D2_id = int.Parse(reader[16].ToString());
                E_id = int.Parse(reader[17].ToString());
                F_id = int.Parse(reader[18].ToString());
                G_id = int.Parse(reader[19].ToString());
                H_id = int.Parse(reader[20].ToString());
                I_id = int.Parse(reader[21].ToString());
                J_id = int.Parse(reader[22].ToString());
                K_id = int.Parse(reader[23].ToString());
                L_id = int.Parse(reader[24].ToString());
                M_id = int.Parse(reader[25].ToString());
                N_id = int.Parse(reader[26].ToString());
                O_id = int.Parse(reader[27].ToString());

                wartosc1 = reader[2].ToString();
                wartosc2 = reader[3].ToString();
                wartosc5 = reader[4].ToString();
                wartosc6_1 = reader[5].ToString();
                wartosc6_2 = reader[6].ToString();
                wartosc6_3 = reader[7].ToString();
                wartosc6_4 = reader[8].ToString();
                wartosc7 = reader[9].ToString();
                wartosc8 = reader[10].ToString();
                pit_nazwa = reader[29].ToString();

            }
            reader.Close();


            query = "SELECT * FROM podpunkt_A WHERE id_A = "+ A_id;
            cmd.CommandText = query;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                wartosc9 = reader[1].ToString();
                wartosc10 = reader[2].ToString();
                wartosc11 = reader[3].ToString();
            }
            reader.Close();


            query = "SELECT * FROM podpunkt_B1 WHERE id_B1 = "+ B1_id;
            cmd.CommandText = query;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                wartosc12 = reader[1].ToString();
                wartosc13 = reader[2].ToString();
                wartosc14_1 = reader[3].ToString();
                wartosc14_2 = reader[4].ToString();
                wartosc14_3 = reader[5].ToString();
                wartosc15 = reader[6].ToString();
                wartosc16 = reader[7].ToString();
                wartosc17 = reader[8].ToString();
                wartosc18 = reader[9].ToString();
                wartosc19 = reader[10].ToString();
                wartosc20 = reader[11].ToString();
                wartosc21 = reader[12].ToString();
                wartosc22 = reader[13].ToString();
                wartosc23 = reader[14].ToString();
            }
            reader.Close();


            query = "SELECT * FROM podpunkt_B2 WHERE id_B2 = "+ B2_id;
            cmd.CommandText = query;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                wartosc24 = reader[1].ToString();
                wartosc25 = reader[2].ToString();
                wartosc26_1 = reader[3].ToString();
                wartosc26_2 = reader[4].ToString();
                wartosc26_3 = reader[5].ToString();
                wartosc27 = reader[6].ToString();
                wartosc28= reader[7].ToString();
                wartosc29 = reader[8].ToString();
                wartosc30 = reader[9].ToString();
                wartosc31 = reader[10].ToString();
                wartosc32 = reader[11].ToString();
                wartosc33 = reader[12].ToString();
                wartosc34 = reader[13].ToString();
                wartosc35 = reader[14].ToString();
            }
            reader.Close();


            query = "SELECT * FROM podpunkt_C WHERE id_C = "+ C_id;
            cmd.CommandText = query;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                wartosc36 = reader[1].ToString();
                wartosc37 = reader[2].ToString();
                wartosc38 = reader[3].ToString();
                wartosc39 = reader[4].ToString();
                wartosc40 = reader[5].ToString();
                wartosc41 = reader[6].ToString();
                wartosc42= reader[7].ToString();
                wartosc43 = reader[8].ToString();
                wartosc44 = reader[9].ToString();
                wartosc45 = reader[10].ToString();
                wartosc46 = reader[11].ToString();
                wartosc47 = reader[12].ToString();
                wartosc48 = reader[13].ToString();
                wartosc49 = reader[14].ToString();
                wartosc50 = reader[15].ToString();
                wartosc51 = reader[16].ToString();
            }
            reader.Close();

            query = "SELECT * FROM podpunkt_D1 WHERE id_D1 = "+ D1_id;
            cmd.CommandText = query;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                wartosc52 = reader[1].ToString();
                wartosc53 = reader[2].ToString();
                wartosc54 = reader[3].ToString();
                wartosc55 = reader[4].ToString();
                wartosc56 = reader[5].ToString();
                wartosc57 = reader[6].ToString();
                wartosc58 = reader[7].ToString();
                wartosc59 = reader[8].ToString();
                wartosc60 = reader[9].ToString();
                wartosc61 = reader[10].ToString();
                wartosc62 = reader[11].ToString();
                wartosc63 = reader[12].ToString();
                wartosc64 = reader[13].ToString();
                wartosc65 = reader[14].ToString();
                wartosc66 = reader[15].ToString();
                wartosc67 = reader[16].ToString();
                wartosc68 = reader[17].ToString();
                wartosc69 = reader[18].ToString();
                wartosc70 = reader[19].ToString();
                wartosc71 = reader[20].ToString();
                wartosc72 = reader[21].ToString();
                wartosc73 = reader[22].ToString();
                wartosc74 = reader[23].ToString();
                wartosc75 = reader[24].ToString();
                wartosc76 = reader[25].ToString();
                wartosc77 = reader[26].ToString();
                wartosc78 = reader[27].ToString();
                wartosc79 = reader[28].ToString();
                wartosc80 = reader[29].ToString();
                wartosc81 = reader[30].ToString();
                wartosc82 = reader[31].ToString();
                wartosc83 = reader[32].ToString();
                wartosc84 = reader[33].ToString();
                wartosc85 = reader[34].ToString();
                wartosc86 = reader[35].ToString();
            }
            reader.Close();

            query = "SELECT * FROM podpunkt_D2 WHERE id_D2 = "+ D2_id;
            cmd.CommandText = query;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                wartosc87 = reader[1].ToString();
                wartosc88 = reader[2].ToString();
                wartosc89 = reader[3].ToString();
                wartosc90 = reader[4].ToString();
                wartosc91 = reader[5].ToString();
                wartosc92 = reader[6].ToString();
                wartosc93 = reader[7].ToString();
                wartosc94 = reader[8].ToString();
                wartosc95 = reader[9].ToString();
                wartosc96 = reader[10].ToString();
                wartosc97 = reader[11].ToString();
                wartosc98 = reader[12].ToString();
                wartosc99 = reader[13].ToString();
                wartosc100 = reader[14].ToString();
                wartosc101 = reader[15].ToString();
                wartosc102 = reader[16].ToString();
                wartosc103 = reader[17].ToString();
                wartosc104 = reader[18].ToString();
                wartosc105 = reader[19].ToString();
                wartosc106 = reader[20].ToString();
                wartosc107 = reader[21].ToString();
                wartosc108 = reader[22].ToString();
                wartosc109 = reader[23].ToString();
                wartosc110 = reader[24].ToString();
                wartosc111 = reader[25].ToString();
                wartosc112 = reader[26].ToString();
                wartosc113 = reader[27].ToString();
                wartosc114 = reader[28].ToString();
                wartosc115 = reader[29].ToString();
                wartosc116 = reader[30].ToString();
                wartosc117 = reader[31].ToString();
                wartosc118 = reader[32].ToString();
                wartosc119 = reader[33].ToString();
                wartosc120 = reader[34].ToString();
                wartosc121 = reader[35].ToString();
            }
            reader.Close();

            query = "SELECT * FROM podpunkt_E WHERE id_E = "+ E_id;
            cmd.CommandText = query;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                wartosc122 = reader[1].ToString();
                wartosc123 = reader[2].ToString();
                wartosc124 = reader[3].ToString();
                wartosc125 = reader[4].ToString();
                wartosc126 = reader[5].ToString();
                wartosc127 = reader[6].ToString();
                wartosc128 = reader[7].ToString();
            }
            reader.Close();


            query = "SELECT * FROM podpunkt_F WHERE id_F = "+ F_id;
            cmd.CommandText = query;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                wartosc129 = reader[1].ToString();
                wartosc130 = reader[2].ToString();
                wartosc131 = reader[3].ToString();
                wartosc132 = reader[4].ToString();
            }
            reader.Close();

            query = "SELECT * FROM podpunkt_G WHERE id_G = "+ G_id;
            cmd.CommandText = query;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                wartosc133 = reader[1].ToString();
                wartosc134 = reader[2].ToString();
                wartosc135 = reader[3].ToString();
                wartosc136 = reader[4].ToString();
            }
            reader.Close();

            query = "SELECT * FROM podpunkt_H WHERE id_H = "+ H_id;
            cmd.CommandText = query;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                wartosc137 = reader[1].ToString();
                wartosc138 = reader[2].ToString();
                wartosc139 = reader[3].ToString();
            }
            reader.Close();

            query = "SELECT * FROM podpunkt_I WHERE id_I = "+ I_id;
            cmd.CommandText = query;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                wartosc140 = reader[1].ToString();
                wartosc141 = reader[2].ToString();
                wartosc142 = reader[3].ToString();
                wartosc143 = reader[4].ToString();
                wartosc144 = reader[5].ToString();
                wartosc145 = reader[6].ToString();
            }
            reader.Close();

            

            query = "SELECT * FROM podpunkt_J WHERE id_J = "+ J_id;
            cmd.CommandText = query;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                wartosc146 = reader[1].ToString();
            }
            reader.Close();


            query = "SELECT * FROM podpunkt_K WHERE id_K = "+ K_id;
            cmd.CommandText = query;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                wartosc147 = reader[1].ToString();
                wartosc148 = reader[2].ToString();
            }
            reader.Close();


            query = "SELECT * FROM podpunkt_L WHERE id_L = "+ L_id;
            cmd.CommandText = query;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                wartosc149 = reader[1].ToString();
                wartosc150 = reader[2].ToString();
                wartosc151 = reader[3].ToString();
            }
            reader.Close();

            query = "SELECT * FROM podpunkt_M WHERE id_M = "+ M_id;
            cmd.CommandText = query;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                wartosc152 = reader[1].ToString();
                wartosc153 = reader[2].ToString();
                wartosc154 = reader[3].ToString();
                wartosc155 = reader[4].ToString();
                wartosc156 = reader[5].ToString();
                wartosc157 = reader[6].ToString();
                wartosc158 = reader[7].ToString();
            }
            reader.Close();

            query = "SELECT * FROM podpunkt_N WHERE id_N = "+ N_id;
            cmd.CommandText = query;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                wartosc159_1 = reader[1].ToString();
                wartosc159_2 = reader[2].ToString();
                wartosc160 = reader[3].ToString();
                wartosc161 = reader[4].ToString();
                wartosc162 = reader[5].ToString();
                wartosc163 = reader[6].ToString();
            }
            reader.Close();

            query = "SELECT * FROM podpunkt_O WHERE id_O = "+ O_id;
            cmd.CommandText = query;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                wartosc164_1 = reader[1].ToString();
                wartosc164_2 = reader[2].ToString();
            }
            reader.Close();


            conn.Close();
        }
    }
}
