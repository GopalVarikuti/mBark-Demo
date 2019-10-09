using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Demo.Service.Contracts;
using Demo.Service.Helpers;
using Demo.Service.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdatePaymentController : ControllerBase
    {
        [HttpPut]
        public IActionResult UpdateCredit([FromBody] UpdateRequest bookingRequest)
        {
            string bookingno = bookingRequest.booking.bookingno;

            List<Contracts.Guest> list = bookingRequest.booking.creditcardinfo.guestsmapped;
            var Parent = new Dictionary<String, object>();
            var gbooking = new Dictionary<String, object>();


            gbooking.Add("voyno", bookingRequest.booking.voyno);
            gbooking.Add("bookingno", bookingRequest.booking.bookingno);

            Parent.Add("status", "00");
            Parent.Add("message", "Guest Payment Card Details Updated");
            Parent.Add("timeinmillis", "400");

            var guestid = "";

            var book = new Dictionary<string, object>();
            var guestlist = new Dictionary<string, object>();
            var guests = new List<object>();

            for (int i = 0; i < list.Count; i++)
            {
                var check = new Dictionary<string, object>();
                var checkin = new Dictionary<String, object>();

                //guestidtest = test.personalinfo.guestid;
                guestid = bookingRequest.booking.creditcardinfo.guestsmapped[i].personalinfo.guestid;
                checkin.Add("guestid", guestid);

                check.Add("isolc", "Y");
                check.Add("ispaymentcomplete", "Y");
                check.Add("isdocumentinfocomplete", "Y");

                checkin.Add("checkinstatus", check);
                guests.Add(checkin);

                using (olcdbContext db = new olcdbContext())
                {
                    try
                    {
                        var entity = db.Bookingdetails.Where(e => (e.Bookingno == bookingno && e.Guestid == guestid)).FirstOrDefault();

                        if (entity == null)
                        {
                            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Bookingdetails with id=" + bookingno + "not found to update");
                        }
                        else
                        {
                            bookingRequest.booking.voyno = entity.Voyno;
                            bookingRequest.booking.bookingno = entity.Bookingno;
                            bookingRequest.booking.shipcode = entity.Shipcode;
                            bookingRequest.booking.shipname = entity.Shipname;
                            bookingRequest.booking.embarkationdate = entity.Embarkationdate;
                            bookingRequest.booking.debarkationdate = entity.Debarkationdate;

                            entity.Registeredcardid = bookingRequest.booking.creditcardinfo.registeredcardid;
                            entity.Ccholdername = bookingRequest.booking.creditcardinfo.ccholdername;
                            entity.Ccmaskedno = bookingRequest.booking.creditcardinfo.ccmaskedno;
                            entity.Ccexpiry = bookingRequest.booking.creditcardinfo.ccexpiry;
                            entity.Cctype = bookingRequest.booking.creditcardinfo.cctype;
                            entity.Currencycode = bookingRequest.booking.creditcardinfo.currencycode;
                            entity.Cctoken = bookingRequest.booking.creditcardinfo.cctoken;
                            entity.Iscctokenpresent = bookingRequest.booking.creditcardinfo.iscctokenpresent;

                            bookingRequest.booking.creditcardinfo.guestsmapped[i].personalinfo.seqno = entity.Seqno;
                            bookingRequest.booking.creditcardinfo.guestsmapped[i].personalinfo.guestid = entity.Guestid;
                            bookingRequest.booking.creditcardinfo.guestsmapped[i].personalinfo.folio = entity.Folio;
                            bookingRequest.booking.creditcardinfo.guestsmapped[i].personalinfo.plastname = entity.Plastname;
                            bookingRequest.booking.creditcardinfo.guestsmapped[i].personalinfo.middlename = entity.Middlename;
                            bookingRequest.booking.creditcardinfo.guestsmapped[i].personalinfo.firstname = entity.Firstname;
                            bookingRequest.booking.creditcardinfo.guestsmapped[i].personalinfo.title = entity.Title;
                            bookingRequest.booking.creditcardinfo.guestsmapped[i].personalinfo.gender = entity.Gender;
                            bookingRequest.booking.creditcardinfo.guestsmapped[i].personalinfo.loyalty = entity.Loyalty;
                            bookingRequest.booking.creditcardinfo.guestsmapped[i].personalinfo.isresponsible = entity.Isresponsible;
                            bookingRequest.booking.creditcardinfo.guestsmapped[i].personalinfo.guesttype = entity.Guesttype;

                            bookingRequest.booking.creditcardinfo.guestsmapped[i].personalinfo.barcode = entity.Barcode;
                            bookingRequest.booking.creditcardinfo.guestsmapped[i].personalinfo.cabin = entity.Cabin;
                            db.SaveChanges();
                        }
                    }
                    catch (Exception ex)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "something went wrong");
                    }
                }
            }
            gbooking.Add("guests", guests);
            Parent.Add("booking", gbooking);

            return this.Request.CreateResponse(HttpStatusCode.OK, Parent);
        }
    }
}