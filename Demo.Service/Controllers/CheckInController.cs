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
        //[Route(Routes.Create)]
        public IActionResult Check([FromBody] CheckInRequest CheckIn)
        {
            //string id = CheckIn.passenger.guestId;
            
            string bookingNo = CheckIn.passenger.bookingNo;


            CheckInResponse checkInResponse = new CheckInResponse();

            //Metadata mdata = new Metadata();

            //int id = mdata.Id;


            var Parent = new Dictionary<string, object>(); //sub dictionary
            var Errors = new List<object>();
            var Warnings = new List<object>();

             using (mBarkDemoAppContext db = new mBarkDemoAppContext())
            {
                try
                {
                    var entity = db.Passengers.Where(e => (e.PersonId == bookingNo)).FirstOrDefault();
                   
                        entity.AuthNo = CheckIn.passenger.authNo;
                        entity.Barcode = CheckIn.passenger.barcode;
                        entity.CabinCategory = CheckIn.passenger.cabinCategory;
                        //mdata.cc = CheckIn.passenger.ccExpiry;
                        //entity.CcHolderName = CheckIn.passenger.ccHolderName;
                        //entity.CcType = CheckIn.passenger.ccType;
                        entity.CheckInStatus = CheckIn.passenger.checkInStatus;
                        entity.CheckInWindow = CheckIn.passenger.checkInWindow;
                        entity.ChkInDateTime = CheckIn.passenger.chkInDateTime;
                        //entity.Nationality = CheckIn.passenger.nationality;
                        //entity.BookingNo = CheckIn.passenger.bookingNo;
                        entity.DateOfBirth = CheckIn.passenger.dateOfBirth;
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
                        //entity.DocExpiryDate = CheckIn.passenger.docExpiryDate;
                        //entity.FirstName = CheckIn.passenger.firstName;
                        //entity.DocIssueCountry = CheckIn.passenger.docIssueCountry;
                        //entity.LastName = CheckIn.passenger.lastName;
                        //entity.DocNumber = CheckIn.passenger.docNumber;
                        //entity.GuestId = CheckIn.passenger.guestId;
                        //entity.GuestType = CheckIn.passenger.guestType;
                        //entity.ProcessingStatus = CheckIn.ProcessingStatus;
                        //entity.PurposeOfVisit = CheckIn.PurposeOfVisit;
                        entity.RequestedBy = CheckIn.passenger.requestedBy;
                        entity.RequestorName = CheckIn.passenger.requestorName;
                        //entity.StateRoom = CheckIn.passenger.stateRoom;
                        //entity.RowId = CheckIn.rowId;
                        entity.SailDate = CheckIn.passenger.sailDate;
                        //entity.SeqNo= CheckIn.SeqNo;
                        entity.ShipCode = CheckIn.passenger.shipCode;
                        //entity.VoyNo = CheckIn.passenger.voyNo;
                        entity.ShipName = CheckIn.passenger.shipName;
                        entity.Title = CheckIn.passenger.title;
                        entity.Zone = CheckIn.passenger.zone;
                        entity.ShipCode = CheckIn.passenger.shipCode;
                        //entity.AgentName = CheckIn.AgentName;
                        //entity.DeviceID = CheckIn.DeviceID;
                        //entity.RequestId = CheckIn.RequestId;
                        db.SaveChanges();

                        var watch = new Stopwatch();
                        watch.Start();
                        watch.Stop();
                        var responseTimeForCompleteRequest = watch.ElapsedMilliseconds;

                        if (entity.CheckInStatus == null)
                        {
                           // Parent.Add("pguestID", entity.GuestId);
                            Parent.Add("pstatus", entity.CheckInStatus);
                            Parent.Add("Pmessage", "Guest Document Details not Updated");
                            Parent.Add("Success", "False");
                            Parent.Add("Pmessage", "Guest Document Details not Updated");
                            Parent.Add("timeinmillis", responseTimeForCompleteRequest);
                            Parent.Add("Errors", Errors.ToList());
                            Parent.Add("Warning", Warnings.ToList());
                            Parent.Add("HttpstatusCode", checkInResponse.HttpStatusCode);
                        }
                        else
                        {
                          //  Parent.Add("pguestID", entity.GuestId);
                            Parent.Add("pstatus", entity.CheckInStatus);
                            Parent.Add("message", "Guest Document Details Updated");
                            Parent.Add("Success", "True");
                            Parent.Add("timeinmillis", responseTimeForCompleteRequest);
                            Parent.Add("Errors", Errors.ToList());
                            Parent.Add("Warning", Warnings.ToList());
                            Parent.Add("HttpstatusCode", checkInResponse.HttpStatusCode);
                        }                   
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


