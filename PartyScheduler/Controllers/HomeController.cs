using PartyScheduler.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyScheduler.Controllers
{
    public class HomeController : Controller
    {

        DB_9B8D99_PartySchedulerEntities db = new DB_9B8D99_PartySchedulerEntities();
        
        Check obj1 = new Check();
        Party1 test_object0 = new Party1();
        Party2 test_object = new Party2();
        Party3 test_object1 = new Party3();
        CombineClass1 model1 = new CombineClass1();
        

       public static CombineClass1 Manual(String UserName) {
            using (var ctx = new DB_9B8D99_PartySchedulerEntities())
            {
                Party1 test_object0 = new Party1();
                Party2 test_object = new Party2();
                Party3 test_object1 = new Party3();
                

              try
              {  test_object0 = ctx.Party1.SqlQuery("Select * from Party1 where LoginID='" + UserName + "'").FirstOrDefault<Party1>(); }

              catch (Exception) { }
              try
              {
                   test_object = ctx.Party2.SqlQuery("Select * from Party2 where LoginID='" + UserName + "'").FirstOrDefault<Party2>();
              }
              catch (Exception ) { }

              try
              {
                   test_object1 = ctx.Party3.SqlQuery("Select * from Party3 where LoginID='" + UserName + "'").FirstOrDefault<Party3>();
              }
              catch (Exception ) { }

                      CombineClass1 test_object_combine = new CombineClass1();
              test_object_combine.class1 = test_object0;
              test_object_combine.class2 = test_object;
              test_object_combine.class3 = test_object1;
              return test_object_combine;

            }
        
        
        }
       public bool check_loginid(CombineClass1 ob,String password)
       {
           int count=0;
         try
         {
             if (ob.class1.Password != password)
                 count=1;
         }
               catch (Exception){}

         try
         {
             if (ob.class3.Password != password)
                 count = 1;
         }
         catch (Exception) { }

         try
         {
             if (ob.class2.Password != password)
                 count = 1;
         }
         catch (Exception) { }

         if (count == 1)
             return true;
         else return false;

           }
        //
        // GET: /Account/LogOn

        public ActionResult LogOn()
        {
            
            
            return View(model1);
        }

        //
        // POST: /Account/LogOn

        [HttpPost]
        public ActionResult LogOn(CombineClass1 model)
        {
            
            {
                String password = model.class1.Password;
              CombineClass1 ob=  Manual(model.class1.LoginID);
              ViewBag.now = 1;
              if (check_loginid(ob,password))
              {
                  ModelState.AddModelError("", "Password Incorrect");
                  return View();
              }

                
                return View(ob);
            }

            
        }



        public ActionResult Index()
        {

            
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult PartyScheduler()
        {
           
            return View(obj1);
        }  
 
        [HttpPost]
        public ActionResult PartyScheduler(Check obj2)

        {
            if (ModelState.IsValid)
            {
                ViewBag.lo = 1;
if(obj2.option.Equals("1"))
                {
                    db.Party1.Add(obj2.obj);
                    db.SaveChanges();
                    ViewBag.Confirmation = "Event Added";
                  //  Manual();
                }
                //else ModelState.AddModelError("", "Login Error");
if (obj2.option.Equals("2"))
{
    test_object.Address = obj2.obj.Address;
    test_object.LoginID = obj2.obj.LoginID;
    test_object.Password = obj2.obj.Password;
    test_object.Title = obj2.obj.Title;
    test_object.EventDate = obj2.obj.EventDate;
    test_object.Description = obj2.obj.Description;
    test_object.HostedBy = obj2.obj.HostedBy;
    test_object.ContactPhone = obj2.obj.ContactPhone;
    test_object.Country = obj2.obj.Country;
    test_object.Latitude = obj2.obj.Latitude;
    test_object.Longitude = obj2.obj.Longitude;


    db.Party2.Add(test_object);
    db.SaveChanges();
    ViewBag.Confirmation = "Event Added";
}
if (obj2.option.Equals("3"))
{
    test_object1.Address = obj2.obj.Address;
    test_object1.LoginID = obj2.obj.LoginID;
    test_object1.Password = obj2.obj.Password;
    test_object1.Title = obj2.obj.Title;
    test_object1.EventDate = obj2.obj.EventDate;
    test_object1.Description = obj2.obj.Description;
    test_object1.HostedBy = obj2.obj.HostedBy;
    test_object1.ContactPhone = obj2.obj.ContactPhone;
    test_object1.Country = obj2.obj.Country;
    test_object1.Latitude = obj2.obj.Latitude;
    test_object1.Longitude = obj2.obj.Longitude;


    db.Party3.Add(test_object1);
    db.SaveChanges();
    ViewBag.Confirmation = "Event Added";
}

            }
            
            return View();
        }


        public ActionResult Map()
        {

            return View();
        
        }

    
    
    }
}
