using EmployeeAppraisal.Models;
using EmployeeAppraisal.Validation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EmployeeAppraisal.Data;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using EmployeeAppraisal.DesignationEnum;

namespace EmployeeAppraisal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly loginvalidation _loginValidator;
        private readonly EmployeeContext _emp;
    //    private readonly IHttpContextAccessor _httpContextAcessor;
        public HomeController(ILogger<HomeController> logger,loginvalidation loginvalidation,EmployeeContext emp)
        {
            _logger = logger;
            _loginValidator = loginvalidation;
            _emp = emp;
        //    _httpContextAcessor = httpContextAcessor;
        }

        public IActionResult Index()
        {
            if(User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Welcome");
            }
            return View();
        }



        [HttpPost]
        public  async Task<IActionResult> Index(string username,string password)
        {

            if (ModelState.IsValid)
            {
                //return null if fails otherwise record and if there no data in database it returns 0
                var isCorrect = _loginValidator.Validate(username,password);

                if (isCorrect == null)
                {//validation fails
                    return View();
                }
               
                else
                {

                    List<Claim> claims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.Name,isCorrect.Name),
                        new Claim(ClaimTypes.Email,username),
                        new Claim("Designation",isCorrect.Designation)

                    };

                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                 await   HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                    //validation success
                    return RedirectToAction("Welcome");

                   // return RedirectToAction("WelCome");
                }
            }
            else
            {
                return View();
            }
        }

        public IActionResult Welcome()
        {
            ViewBag.app = _emp.createappraisals.Where(m => m.AppraisalStatus == "New").ToList();
             ViewBag.data =_emp.Employee.ToList();
            return View();
        }

        [Authorize]
        public IActionResult AddEmployee()
        {
            Employee emp = new Employee();
            return View(emp);
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee e)
        {
            if(ModelState.IsValid)
            {
                e.Designation = Enum.GetName(typeof(designation), int.Parse(e.Designation));
                _emp.Employee.Add(e);
                _emp.SaveChanges();

                return RedirectToAction("Welcome");

            }
            else
            {
                return View();
            }
        }


        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        //AppraisalDetails

        [Authorize]
        public IActionResult AppraiselForm()
        {

            Appraisal fm = new Appraisal();
            return View(fm);
        }



        //for deleteting the employees
        [Authorize]
        public IActionResult DeleteEmp(int id)
        {
            var k = _emp.Employee.Where(m=>m.EID ==id).FirstOrDefault();
            _emp.Employee.Attach(k);
            _emp.Employee.Remove(k);
            
            _emp.SaveChanges();
       


            return RedirectToAction("welcome");

        }


        //creating a new Appraisal for employee and check the status.
        [Authorize]
        public IActionResult CreateAppraisal()
        {
            createappraisal ca = new createappraisal();
            var currentUserID = _emp.Employee.Where(m => m.Email == User.Claims.ToList()[1].Value).FirstOrDefault();

            ViewBag.Emp = _emp.Employee.Where(m => m.MID == currentUserID.EID);



            return View(ca);
        }


        [HttpPost]

        public IActionResult CreateAppraisal(createappraisal cp)
        {
            var user = _emp.Employee.Where(m => m.Email == User.Claims.ToList()[1].Value).FirstOrDefault();
            cp.ManagerID = user.EID;


            var currentUserID = _emp.Employee.Where(m => m.Email == User.Claims.ToList()[1].Value).FirstOrDefault();

            ViewBag.Emp = _emp.Employee.Where(m => m.MID == currentUserID.EID);

            ViewBag.Emp = _emp.Employee.Where(m => m.MID == currentUserID.EID);


            if (ModelState.IsValid)
            {
                
              var c=  _emp.createappraisals.Add(cp);
                _emp.SaveChanges();

                foreach (var item in cp.comps)
                {
                    _emp.compitencies.Add(new compitency()
                    {
                        AID =1,
                        compi = item
                    });

                    _emp.SaveChanges();

                }

                ViewBag.succ = "Form Submitted ";
                return View();
            }
            else
            {
              
                return View();
            }
          

        }


    }
}
