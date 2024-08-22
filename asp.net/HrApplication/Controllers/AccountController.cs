using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using HrApplication.Models;
using System.Threading.Tasks;

public class AccountController : Controller
{
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly UserManager<IdentityUser> _userManager;

    public AccountController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
    {
        _signInManager = signInManager;
        _userManager = userManager;
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, false, lockoutOnFailure: false);
        if (result.Succeeded)
        {
            return RedirectToAction("Index", "Home");
        }

        ModelState.AddModelError(string.Empty, "Invalid login attempt.");
        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();
        return RedirectToAction("Index", "Home");
    }

    
    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Register(RegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            var user = new IdentityUser
            {
                UserName = model.Username,
                Email = model.Email
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
               // await _signInManager.SignInAsync(user, isPersistent: false);
                TempData["SuccessMessage"] = "Registration successful! Click here to log in.";
                return RedirectToAction("Login","Account"); 
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        return View(model);
    }


    public IActionResult TestTempData()
    {
        TempData["TestMessage"] = "This is a test message.";
        return RedirectToAction("DisplayMessage");
    }

  //  public IActionResult DisplayMessage()
    //{
       // return View();
   // }
    

    [HttpPost]
    public IActionResult TestRedirect()
    {
        // Set a message in TempData
        TempData["TestMessage"] = "Test message for redirection.";

        // Redirect to the DisplayMessage action
        return RedirectToAction("DisplayMessage");
    }

    // Action to display the message
    public IActionResult DisplayMessage()
    {
        return View();
    }


    public IActionResult TestRedirectForm()
    {
        return View();
    }

}

