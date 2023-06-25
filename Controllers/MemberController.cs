using Microsoft.AspNetCore.Mvc;
using MVC03.DAL;
using MVC03.Models;
namespace MVC03.Controllers
{ 
    
public class MemberController : Controller
{
    
     private readonly IMemberRepository<Member> _member;

    public MemberController(IMemberRepository<Member> member)
    {
        _member = member;
    }

    public IActionResult Index()
    {
        var users = _member.GetAll();
        return View(users);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Member user)
    {
        _member.Insert(user);
        return RedirectToAction("Index");
    }
}
}