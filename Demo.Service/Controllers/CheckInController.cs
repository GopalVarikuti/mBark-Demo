using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Demo.Service.Contracts;
using Demo.Service.Helpers;
using Demo.Service.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Demo.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckInController : ControllerBase
    {
        [HttpPost]
        [Authorize]
        public IActionResult Check([FromBody] CheckInRequest CheckIn)
        {
            string bookingNo = CheckIn.passenger.bookingNo;
            string voyNo = CheckIn.passenger.voyNo;

            CheckInResponse checkInResponse = new CheckInResponse();

            var Parent = new Dictionary<string, object>(); //sub dictionary
            var Errors = new List<object>();
            var Warnings = new List<object>();

            using (mBarkDemoAppContext db = new mBarkDemoAppContext())
            {
                try
                {
                    var watch = new Stopwatch();
                    watch.Start();

                    var entity = db.Manifest.Where(e => (e.BookingNo == bookingNo && e.VoyNo== voyNo)).FirstOrDefault();

                    entity.AuthNo = CheckIn.passenger.authNo;
                    entity.Barcode = CheckIn.passenger.barcode;
                    entity.CabinCategory = CheckIn.passenger.cabinCategory;
                    
                    entity.CheckInStatus = CheckIn.passenger.checkInStatus;
                    entity.CheckInWindow = CheckIn.passenger.checkInWindow;
                    entity.ChkInDateTime = CheckIn.passenger.chkInDateTime;
                    
                    entity.DateofBirth = CheckIn.passenger.dateOfBirth;
                    entity.DepartTime = CheckIn.passenger.departTime;
                    entity.DocType = CheckIn.passenger.docType;
                    entity.EmbarkationDate = CheckIn.passenger.embarkationDate;
                    entity.FlagStatus = CheckIn.passenger.flagStatus;
                    entity.Folio = CheckIn.passenger.folio;
                    entity.Gender = CheckIn.passenger.gender;
                    entity.GuestStatus = CheckIn.passenger.guestStatus;
                    entity.IsOlc = CheckIn.passenger.isOLC;
                    entity.Loyalty = CheckIn.passenger.loyalty;
                    entity.MusterStation = CheckIn.passenger.musterStation;
                    
                    entity.RequestedBy = CheckIn.passenger.requestedBy;
                    entity.RequestorName = CheckIn.passenger.requestorName;
                    
                    entity.SailDate = CheckIn.passenger.sailDate;
                    
                    entity.ShipCode = CheckIn.passenger.shipCode;
                    
                    entity.ShipName = CheckIn.passenger.shipName;
                    entity.Title = CheckIn.passenger.title;
                    entity.Zone = CheckIn.passenger.zone;
                    entity.ShipCode = CheckIn.passenger.shipCode;
                    
                    db.SaveChanges();

                    
                    watch.Stop();
                    var duration = (watch.ElapsedMilliseconds).ToString();

                    if (entity.CheckInStatus != null)
                    {
                        Parent.Add("pguestID", CheckIn.passenger.guestId);
                        Parent.Add("pstatus", entity.CheckInStatus);
                        Parent.Add("pmessage", "Guest Document Details Updated");
                        Parent.Add("Errors", Errors.ToList());
                        Parent.Add("Warning", Warnings.ToList());
                        Parent.Add("Success", "True");
                        Parent.Add("message", " ");
                        Parent.Add("timeinmillis", duration);
                        Parent.Add("httpstatusCode", HttpStatusCode.OK);
                    }
                    /*else
                    {
                        Parent.Add("pstatus", entity.CheckInStatus);
                        Parent.Add("Pmessage", "Guest Document Details not Updated");
                        Parent.Add("Success", "False");
                        Parent.Add("Pmessage", "Guest Document Details not Updated");
                        Parent.Add("timeinmillis", duration);
                        Parent.Add("Errors", Errors.ToList());
                        Parent.Add("Warning", Warnings.ToList());
                        Parent.Add("HttpstatusCode", checkInResponse.HttpStatusCode);  
                    }*/
                }
                catch (Exception)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "something went wrong");
                }
            }
            return this.Request.CreateResponse(HttpStatusCode.OK, Parent);
        }
    }
}


