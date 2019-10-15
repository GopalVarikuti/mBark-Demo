using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Demo.Service.Helpers;
using Demo.Service.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Demo.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ManifestController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public IActionResult manifest([FromQuery] string shipid, string DeviceId, string agentName, string requestId)
        {
            //string shipid = manifest.ShipId;

            var metadatadetails = new Dictionary<string, object>();
            var metadata = new Dictionary<string, object>();


            var listmanifest = new List<object>();
            var listErrors = new List<object>();
            var listWarnings = new List<object>();

            var documents = new List<object>();
            var questions = new List<object>();
            var checkInParameters = new List<object>();
            var countries = new List<object>();


            using (mBarkDemoAppContext db = new mBarkDemoAppContext())
            {

                List<Metadata> Maninmetadata = db.Metadata.ToList();
                List<Country> Countrydata = db.Country.ToList();

                //var shipcode = Maninmetadata[0].ShipCode;
                try
                {
                    var watch = new Stopwatch();
                    watch.Start();
                    var entity = db.Manifest.Where(e => (e.ShipCode == shipid)).FirstOrDefault(); //&& e.ShipCode == shipcode

                    var retList = new List<string>();
                    retList.Add(entity.ToString());

                    metadata.Add("voyno", entity.VoyNo);

                    for (int j = 0; j < Maninmetadata.Count; j++)
                    {
                        //documents list
                        var testdoc = new Dictionary<string, object>();
                        testdoc.Add("docName", Maninmetadata[j].DocName);
                        testdoc.Add("docType", Maninmetadata[j].DocType);
                        testdoc.Add("docValidityReq", Maninmetadata[j].DocValidityReq);

                        documents.Add(testdoc);

                        //questions list

                        var testquestion = new Dictionary<string, object>();
                        testquestion.Add("questionNo", Maninmetadata[j].QuestionNo);
                        testquestion.Add("question", Maninmetadata[j].Question);
                        testquestion.Add("questionType", Maninmetadata[j].QuestionType);

                        questions.Add(testquestion);
                        //checkInParameters list

                        var testcheckin = new Dictionary<string, object>();
                        testcheckin.Add("isHealthQuestionsReq", Maninmetadata[j].IsHealthQuestionsReq);
                        testcheckin.Add("isNonVisaWaiverAllowed", Maninmetadata[j].IsNonVisaWaiverAllowed);
                        testcheckin.Add("isPassportReceiptReq", Maninmetadata[j].IsPassportReceiptReq);
                        testcheckin.Add("isPregQuestionsReq", Maninmetadata[j].IsPregQuestionsReq);
                        testcheckin.Add("isPlaceBirth", Maninmetadata[j].IsPlaceBirth);
                        testcheckin.Add("ageMinor", Maninmetadata[j].Ageminor);
                        testcheckin.Add("isB1B2VisaCheckin", Maninmetadata[j].IsB1b2visaCheckIn);
                        testcheckin.Add("isAutoDeleteManifest", Maninmetadata[j].IsAutoDeleteManifest);
                        testcheckin.Add("isRetryRFIDLift", Maninmetadata[j].IsRetryRfidlift);
                        testcheckin.Add("offlineTimeout", Maninmetadata[j].OfflineTimeout);

                        checkInParameters.Add(testcheckin);

                        //Country's list

                        
                    }

                    for (int k = 0; k < Countrydata.Count; k++)
                    {
                        var testcountry = new Dictionary<string, object>();
                        testcountry.Add("cntryCode", Countrydata[k].CntryCode);
                        testcountry.Add("cntryName", Countrydata[k].CntryName);
                        testcountry.Add("isVisaWaiver", Countrydata[k].IsVisaWaiver);

                        countries.Add(testcountry);
                    }


                    for (int i = 0; i < retList.Count; i++)
                    {
                        var insidemanifest = new Dictionary<string, object>();

                        insidemanifest.Add("voyNo", entity.VoyNo);
                        insidemanifest.Add("bookingNo", entity.BookingNo);
                        insidemanifest.Add("seqNo", entity.SeqNo);
                        insidemanifest.Add("guestId", entity.GuestId);
                        insidemanifest.Add("folio", entity.Folio);
                        insidemanifest.Add("authNo", entity.AuthNo);
                        insidemanifest.Add("lastName", entity.LastName);
                        insidemanifest.Add("firstName", entity.FirstName);
                        insidemanifest.Add("title", entity.Title);
                        insidemanifest.Add("gender", entity.Gender);
                        insidemanifest.Add("stateRoom", entity.StateRoom);
                        insidemanifest.Add("loyalty", entity.Loyalty);
                        insidemanifest.Add("isResponsible", entity.IsResponsible);
                        insidemanifest.Add("guestType", entity.GuestType);
                        insidemanifest.Add("docType", entity.DocType);
                        insidemanifest.Add("docNumber", entity.DocNumber);
                        insidemanifest.Add("docIssueDate", entity.DocIssueDate);
                        insidemanifest.Add("docExpiryDate", entity.DocExpiryDate);
                        insidemanifest.Add("docIssueCountry", entity.DocIssueCountry);
                        insidemanifest.Add("dateOfBirth", entity.DateofBirth);
                        insidemanifest.Add("placeOfBirth", entity.PlaceofBirth);
                        insidemanifest.Add("nationality", entity.Nationality);
                        insidemanifest.Add("flagStatus", entity.FlagStatus);
                        insidemanifest.Add("isOLC", entity.IsOlc);
                        insidemanifest.Add("ccHolderName", entity.CcHolderName);
                        insidemanifest.Add("ccMaskedNo", entity.CcMaskedNo);
                        insidemanifest.Add("ccExpiry", entity.CcExpiry);
                        insidemanifest.Add("ccType", entity.CcType);
                        insidemanifest.Add("ccToken", entity.CcToken);
                        insidemanifest.Add("shipCode", entity.ShipCode);
                        insidemanifest.Add("shipName", entity.ShipName);
                        insidemanifest.Add("embarkationDate", entity.EmbarkationDate);
                        insidemanifest.Add("guestStatus", entity.GuestStatus);
                        insidemanifest.Add("sailDate", entity.SailDate);
                        insidemanifest.Add("musterStation", entity.MusterStation);
                        insidemanifest.Add("checkInWindow", entity.CheckInWindow);
                        insidemanifest.Add("departTime", entity.DepartTime);
                        insidemanifest.Add("cabinCategory", entity.CabinCategory);
                        insidemanifest.Add("requestedBy", entity.RequestedBy);
                        insidemanifest.Add("requestorName", entity.RequestorName);
                        insidemanifest.Add("purposeOfVisit", entity.PurposeofVisit);
                        insidemanifest.Add("checkInStatus", entity.CheckInStatus);
                        insidemanifest.Add("isCheckedIn", entity.IsCheckedIn);
                        insidemanifest.Add("checkoutDate", entity.CheckoutDate);
                        insidemanifest.Add("guestImage", entity.GuestImage);
                        insidemanifest.Add("chkInDateTime", entity.ChkInDateTime);
                        insidemanifest.Add("pictureType", entity.PictureType);
                        insidemanifest.Add("gQuestionRes1", entity.GQuestionRes1);
                        insidemanifest.Add("gQuestionRes2", entity.GQuestionRes2);
                        insidemanifest.Add("pQuestionRes1", entity.PQuestionRes1);
                        insidemanifest.Add("pQuestionRes2", entity.PQuestionRes2);
                        insidemanifest.Add("barcode", entity.Barcode);
                        insidemanifest.Add("onboardStatus", entity.OnboardStatus);
                        insidemanifest.Add("zone", entity.Zone);

                        listmanifest.Add(insidemanifest);
                    }

                    watch.Stop();
                    var duration = (watch.ElapsedMilliseconds).ToString();

                    metadatadetails.Add("metadata", metadata);
                    metadata.Add("documents", documents);

                    metadata.Add("questions", questions);
                    metadata.Add("checkInParameters", checkInParameters);
                    metadata.Add("countries", countries);


                    metadatadetails.Add("manifest", listmanifest);
                    metadatadetails.Add("errors", listErrors);
                    metadatadetails.Add("warnings", listWarnings);
                    metadatadetails.Add("success", "True");
                    metadatadetails.Add("message", "Successfully retrieved the manifest");
                    metadatadetails.Add("timeInMillis", duration);
                    metadatadetails.Add("httpStatusCode", HttpStatusCode.OK);
                }
                catch (Exception)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "something went wrong");
                }
            }
            return this.Request.CreateResponse(HttpStatusCode.OK, metadatadetails);
        }
    }
}