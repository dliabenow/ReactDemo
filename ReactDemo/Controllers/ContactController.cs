using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Mvc;
using ReactDemo.Models;

namespace ReactDemo.Controllers
{
    public class ContactController : Controller
    {
        private static readonly IList<Contact> _contacts;

        static ContactController()
        {
            _contacts = new List<Contact>
            {
            new Contact { 
                ContactId =1, 
                Address = new Address { AddressId = 1, StreetAddress = "123 AnyStreet", City = "AnyTown", State = "UT" }, 
                FirstName = "Bob", 
                LastName = "Builder"
            }
                ,
            new Contact { 
                ContactId =2, 
                Address = new Address { AddressId = 2, StreetAddress = "234 AnyStreet", City = "AnyTown", State = "UT" }, 
                FirstName = "Stevie", 
                LastName = "Wonder"
            }
                ,
            new Contact { 
                ContactId =3, 
                Address = new Address { AddressId = 3, StreetAddress = "345 AnyStreet", City = "AnyTown", State = "UT" }, 
                FirstName = "Dave", 
                LastName = "Crocket"
            }
                ,
            new Contact { 
                ContactId =1, 
                Address = new Address { AddressId = 4, StreetAddress = "456 AnyStreet", City = "AnyTown", State = "UT" }, 
                FirstName = "George", 
                LastName = "Washington"
            }
            };
        }

        [System.Web.Mvc.HttpGet]
        public JsonResult GetContact(int contactId)
        {
            var contact = _contacts.FirstOrDefault((c) => c.ContactId == contactId);
            if (contact != null)
            {
                return Json(
                    data: contact,
                    behavior: JsonRequestBehavior.AllowGet
                    );
            }
            else
            {
                return null;
            }
        }

        [System.Web.Mvc.HttpGet]
        public JsonResult GetContacts()
        {
            if (_contacts != null)
            {
                return Json(
                    data: _contacts, 
                    behavior: JsonRequestBehavior.AllowGet
                    );
            }
            else
            {
                return null;
            }
        }
    }
}
