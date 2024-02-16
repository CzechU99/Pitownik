using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using pitownik.context;
using System.Net;
using pitownik.Models;
using System.Linq;
using System.Net.Mail;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace pitownik.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private AppDbContext _db;

        public string msg;
        public string msg2;
        public string msg3;
        public string msg4;
        public string msg5;
        public string msg6;
        public string msg7;

        [BindProperty]
        public konto users { get; set; }

        public konto users2 { get; set; }

        public IndexModel(ILogger<IndexModel> logger, AppDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public List<konto> user { get; set; }

        public void OnGet()
        {
            users2 = new konto();
            users = new konto();
            user = _db.konta.ToList();
        }

        public IActionResult OnPostLogin()
        {
           
            var acc = login(users.email, users.haslo);
            if(acc == null)
            {
                msg = "Niepoprawne dane!";
                return Page();
            }
            else
            {
                HttpContext.Session.SetString("email", acc.email);
                HttpContext.Session.SetString("id_acc", acc.id_konta.ToString());
                HttpContext.Session.SetString("imie", acc.imie);
                HttpContext.Session.SetString("nazwisko", acc.nazwisko);
                return RedirectToPage("MojeKonto");
            }

        }   

        private konto login(string email, string haslo)
        {
            var user = _db.konta.SingleOrDefault(a => a.email.Equals(email));
            if(user != null)
            {
                if (user.haslo.Equals(haslo))
                {
                    return user;
                }
            }
            return null;
        }   

        public IActionResult OnGetLogout()
        {
            HttpContext.Session.Remove("email");
            HttpContext.Session.Remove("imie");
            HttpContext.Session.Remove("nazwisko");
            HttpContext.Session.Remove("id_acc");
            HttpContext.Session.Remove("edytujpit");
            HttpContext.Session.Remove("pobierz");
            return RedirectToPage("Index");
        }

        public IActionResult OnPostRegister()
        {

            string haslo = Request.Form["pass"];
            string haslo2 = Request.Form["pass2"];
            string imie = Request.Form["imie"];
            string nazwisko = Request.Form["nazwisko"]; 
            string email = Request.Form["email"];
            bool test = true;
            bool test2 = true;
            bool test3 = true;
            bool test4 = true;

            Regex validateGuidRegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{12,}$");
            //min 8 chars, one uppercase letter, one lowercase letter, one number, one special character

            var emailValidation = new EmailAddressAttribute();

            string connectionDB = "Server=(LocalDb)\\MSSQLLocalDB;Database=pitownik;trusted_connection=true";
            SqlConnection conn = new SqlConnection(connectionDB);
            conn.Open();
            string query = "SELECT * FROM konta WHERE email = '" + email + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            int test_email = 0;

            while (reader.Read())
            {
                test_email++;
            }

            if ((validateGuidRegex.IsMatch(haslo)) && (haslo == haslo2))
            {
                test = true;
            }
            else
            {
                test = false;
                msg3 = "Zły format hasła!";
            }

            if ((imie.Length > 2) && (imie.Length < 20) && (imie.All(Char.IsLetter)))
            {
                test2 = true;
            }
            else
            {
                test2 = false;
                msg4 = "Zły format imienia!!";
            }

            if ((nazwisko.Length > 2) && (nazwisko.Length < 20) && (nazwisko.All(Char.IsLetter)))
            {
                test3 = true;
            }
            else
            {
                test3 = false;
                msg5 = "Zły format nazwiska!";
            }

            if (emailValidation.IsValid(email)) 
            {
                if (test_email == 0)
                {
                    test4 = true;
                }
                else
                {
                    test4 = false;
                    msg6 = "E-mail w użyciu!";
                }
            }
            else
            {
                test4 = false;
                msg6 = "Zły format E-MAIL!";
            }

            if (test && test2 && test3 && test4)
            {
                users.haslo = haslo.ToString();
                _db.konta.Add(users);
                _db.SaveChanges();
                msg7 = "Konto zostało utworzone!";
            }

            return Page();

        }

    }
}