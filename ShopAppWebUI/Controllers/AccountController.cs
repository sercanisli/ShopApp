using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShopAppWebUI.Entities;

namespace ShopAppWebUI.Controllers
{
    public class AccountController : Controller
    {
	    private UserManager<CustomIdentityUser> _userManager;
	    private RoleManager<CustomIdentityRole> _userRole;
	    private SignInManager<CustomIdentityUser> _signInManager;

	    public AccountController(UserManager<CustomIdentityUser> userManager, RoleManager<CustomIdentityRole> userRole, SignInManager<CustomIdentityUser> signInManager)
	    {
		    _userManager = userManager;
		    _userRole = userRole;
		    _signInManager = signInManager;
	    }

	    public IActionResult Index()
        {
            return View();
        }
    }
}