using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Models.Authentication;
using MovieApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Controllers
{
    [Authorize(Roles = "Admin,Moderator,User")]
    public class AdminController : Controller
    {
        readonly UserManager<AppUser> _userManager;
        readonly SignInManager<AppUser> _signInManager;
        readonly RoleManager<AppRole> _roleManager;
        public AdminController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return RedirectToAction("UserList");
        }

        [AllowAnonymous]
        public IActionResult Login(string ReturnUrl)
        {
            TempData["returnUrl"] = ReturnUrl;
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)//model doğrulandıysa
            {
                AppUser user = await _userManager.FindByEmailAsync(model.Email);//kullanıcı epostasına göre kullanıcı bilgileri çekiyoruz.
                if (user != null)
                {
                    //İlgili kullanıcıya dair önceden oluşturulmuş bir Cookie varsa siliyoruz.
                    await _signInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user, model.Password, model.Persistent, model.Lock);

                    if (result.Succeeded)
                    {
                        await _userManager.ResetAccessFailedCountAsync(user); //Önceki hatalı girişler neticesinde +1 arttırılmış tüm değerleri 0(sıfır)a çekiyoruz.

                        return RedirectToAction("Index");
                    }
                    else
                    {
                        await _userManager.AccessFailedAsync(user); //Eğer ki başarısız bir account girişi söz konusu ise AccessFailedCount kolonundaki değer +1 arttırılacaktır. 

                        int failcount = await _userManager.GetAccessFailedCountAsync(user); //Kullanıcının yapmış olduğu başarısız giriş deneme adedini alıyoruz.
                        if (failcount == 3)
                        {
                            await _userManager.SetLockoutEndDateAsync(user, new DateTimeOffset(DateTime.Now.AddMinutes(1))); //Eğer ki başarısız giriş denemesi 3'ü bulduysa ilgili kullanıcının hesabını 1 dakika kilitliyoruz.
                            ModelState.AddModelError("Locked", "Art arda 3 başarısız giriş denemesi yaptığınızdan dolayı hesabınız 1 dk kitlenmiştir.");
                        }
                        else
                        {
                            if (result.IsLockedOut)
                                ModelState.AddModelError("Locked", "Art arda 3 başarısız giriş denemesi yaptığınızdan dolayı hesabınız 1 dk kilitlenmiştir.");
                            else
                                ModelState.AddModelError("NotUser2", "E-posta veya şifre yanlış.");
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("NotUser", "Böyle bir kullanıcı bulunmamaktadır.");
                    ModelState.AddModelError("NotUser2", "E-posta veya şifre yanlış.");
                }
            }
            return View(model);
        }


        // ÇIKIŞ İŞLEMİ
        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();//oluşturulmuş cookie leri siliyoruz
            return RedirectToAction("login");
        }


        //---------- KULLANICI İŞLEMLERİ ----------//

        // KULLANICI KAYIT
        [Authorize(Roles = "Admin,Moderator")]
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(AppUserViewModel appUserViewModel)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser
                {
                    UserName = appUserViewModel.UserName,
                    Email = appUserViewModel.Email,
                    NameSurname = appUserViewModel.NameSurname,
                    PhoneNumber = appUserViewModel.PhoneNumber,

                };
                IdentityResult result = await _userManager.CreateAsync(appUser, appUserViewModel.Sifre);
                if (result.Succeeded)
                {
                    ModelState.Clear();
                    ViewBag.State = true;
                }
                else
                    result.Errors.ToList().ForEach(e => ModelState.AddModelError(e.Code, e.Description));
            }
            return View();
        }

        // KULLANICI LİSTESİ
        public IActionResult UserList()
        {
            return View(_userManager.Users);
        }

        // KULLANICI BİLGİ GETİRME
        [Authorize(Roles = "Admin,Moderator")]
        [HttpGet]
        public async Task<IActionResult> EditUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id); // Id değerine göre kullanıcı bilgilerini alıyoruz.
            var model = new AppUserViewModel
            {
                UserName = user.UserName,
                NameSurname = user.NameSurname,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
            };
            return View(model);
        }

        // KULLANICI BİLGİ GÜNCELLEME
        [Authorize(Roles = "Admin,Moderator")]
        [HttpPost]
        public async Task<IActionResult> EditUser(AppUserViewModel model)
        {
            var user = await _userManager.FindByIdAsync(model.Id.ToString()); //Id değerine göre kullanıcı bilgilerini alıyoruz.

            user.UserName = model.UserName;
            user.NameSurname = model.NameSurname;
            user.Email = model.Email;
            user.PhoneNumber = model.PhoneNumber;

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("UserList");
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
            return View(model);
        }


        // KULLANICI KAYIT SİLME
        [Authorize(Roles = "Admin,Moderator")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id); //Id değerine göre kullanıcı bilgilerini alıyoruz.
            List<string> userRoles = await _userManager.GetRolesAsync(user) as List<string>; //Seçilen kullanıcının rollerini listeliyoruz.

            if (userRoles.Contains("Admin")) //Eger listede Admin değeri varsa.
            {
                TempData["ErrorMsg"] = "Admin yetkisi olan kullanıcı silinemez !";

                return RedirectToAction("UserList");
            }
            else
            {
                var result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    //Başarılı..
                }
                return RedirectToAction("UserList");
            }

        }

        //---------- ROL İŞLEMLERİ ----------//

        // ROL EKLEME VE GÜNCELLEME
        [Authorize(Roles = "Admin,Moderator")]
        public async Task<IActionResult> CreateRole(string id)
        {
            if (id != null)
            {
                AppRole role = await _roleManager.FindByIdAsync(id);

                return View(new RoleViewModel
                {
                    Name = role.Name
                });
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleViewModel model, string id)
        {
            IdentityResult result = null;
            if (id != null)
            {
                AppRole role = await _roleManager.FindByIdAsync(id);
                role.Name = model.Name;
                result = await _roleManager.UpdateAsync(role);
            }
            else
                result = await _roleManager.CreateAsync(new AppRole { Name = model.Name, OlusturulmaTarihi = DateTime.Now });

            if (result.Succeeded)
            {
                //Başarılı...
                return RedirectToAction("rolelist");
            }
            else
            {
                return View();
            }
        }

        // ROL LİSTELEME
        public IActionResult RoleList()
        {
            return View(_roleManager.Roles.ToList());
        }

        //ROL SİLME
        [Authorize(Roles = "Admin,Moderator")]
        public async Task<IActionResult> DeleteRole(string id)
        {
            AppRole role = await _roleManager.FindByIdAsync(id); //Id ye göre rolleri alıyoruz.

            if (role.Name == "Admin")//Roller içerisinde Admin değeri varsa
            {
                TempData["ErrorMsg"] = "Admin rolü silinemez !";

                return RedirectToAction("rolelist");
            }
            else
            {
                IdentityResult result = await _roleManager.DeleteAsync(role);
                if (result.Succeeded)
                {
                    //Başarılı...
                }
                return RedirectToAction("rolelist");
            }
        }

        // ROL ATAMA-YETKİ VERME
        [Authorize(Roles = "Admin,Moderator")]
        public async Task<IActionResult> RoleAssign(string id)
        {
            AppUser user = await _userManager.FindByIdAsync(id);//Id ye göre kullanıcı bilgilerini alıyoruz.
            List<AppRole> allRoles = _roleManager.Roles.ToList();//Tüm rolleri listeliyoruz.
            List<string> userRoles = await _userManager.GetRolesAsync(user) as List<string>;//Kullanıcıya ait rolleri listeliyoruz.
            List<RoleAssignViewModel> assignRoles = new List<RoleAssignViewModel>();
            allRoles.ForEach(role => assignRoles.Add(new RoleAssignViewModel
            {
                HasAssign = userRoles.Contains(role.Name),
                RoleId = role.Id,
                RoleName = role.Name
            }));

            return View(assignRoles);
        }
        [HttpPost]
        public async Task<ActionResult> RoleAssign(List<RoleAssignViewModel> modelList, string id)
        {
            AppUser user = await _userManager.FindByIdAsync(id);

            foreach (RoleAssignViewModel role in modelList)
            {
                if (role.HasAssign)
                    await _userManager.AddToRoleAsync(user, role.RoleName);//seçili rolleri kullanıcıya ekliyoruz
                else
                    await _userManager.RemoveFromRoleAsync(user, role.RoleName);//Seçili olmayan rolleri kullanıcı rollerinden çıkartıyoruz.
            }

            return RedirectToAction("UserList", "admin");
        }

        [AllowAnonymous]
        public IActionResult AccessBarrier()//Erişim engeli uyarısı
        {
            return View();
        }
    }
}
