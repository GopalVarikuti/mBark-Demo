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
                try
                {
                    var watch = new Stopwatch();
                    watch.Start();
                    var entity = db.Manifest.Where(e => (e.ShipId == shipid)).FirstOrDefault();

                    //var item = db.Manifest.ToList();

                    List<Manifest> manifestlist = db.Manifest.ToList();

                    List<Metadata> Maninmetadata = db.Metadata.ToList();

                    //List<Metadata> docum = db.Metadata.ToList();
                    //List<Metadata> question = db.Metadata.ToList();
                    metadata.Add("voyno", entity.VoyNo);


                    //documents list
                    foreach (Metadata doc in Maninmetadata)
                    {
                        var testdoc = new Dictionary<string, object>();
                        testdoc.Add("docName", doc.DocName);
                        testdoc.Add("docType", doc.DocType);
                        testdoc.Add("docValidityReq", doc.DocValidityReq);

                        documents.Add(testdoc);
                    }

                    //questions list
                    foreach (Metadata ques in Maninmetadata)
                    {
                        var testquestion = new Dictionary<string, object>();
                        testquestion.Add("questionNo", ques.QuestionNo);
                        testquestion.Add("question", ques.Question);
                        testquestion.Add("questionType", ques.QuestionType);

                        questions.Add(testquestion);
                    }

                    //checkInParameters list
                    foreach (Metadata check in Maninmetadata)
                    {
                        var testcheckin = new Dictionary<string, object>();
                        testcheckin.Add("isHealthQuestionsReq", check.IsHealthQuestionsReq);
                        testcheckin.Add("isNonVisaWaiverAllowed", check.IsNonVisaWaiverAllowed);
                        testcheckin.Add("isPassportReceiptReq", check.IsPassportReceiptReq);
                        testcheckin.Add("isPregQuestionsReq", check.IsPregQuestionsReq);
                        testcheckin.Add("isPlaceBirth", check.IsPlaceBirth);
                        testcheckin.Add("ageMinor", check.Ageminor);
                        testcheckin.Add("isB1B2VisaCheckin", check.IsB1b2visaCheckIn);
                        testcheckin.Add("isAutoDeleteManifest", check.IsAutoDeleteManifest);
                        testcheckin.Add("isRetryRFIDLift", check.IsRetryRfidlift);
                        testcheckin.Add("offlineTimeout", check.OfflineTimeout);

                        checkInParameters.Add(testcheckin);
                    }

                    //Country's list

                    //List<Metadata> country = db.Metadata.ToList();
                    foreach (Metadata cou in Maninmetadata)
                    {
                        var testcountry = new Dictionary<string, object>();
                        testcountry.Add("cntryCode", cou.CntryCode);
                        testcountry.Add("cntryName", cou.CntryName);
                        testcountry.Add("isVisaWaiver", cou.IsVisaWaiver);

                        countries.Add(testcountry);
                    }
                    for (int i = 0; i < manifestlist.Count; i++)
                    {
                        var insidemanifest = new Dictionary<string, object>();

                        insidemanifest.Add("voyNo", manifestlist[i].VoyNo);
                        insidemanifest.Add("bookingNo", manifestlist[i].BookingNo);
                        insidemanifest.Add("seqNo", manifestlist[i].SeqNo);
                        insidemanifest.Add("guestId", manifestlist[i].GuestId);
                        insidemanifest.Add("folio", manifestlist[i].Folio);
                        insidemanifest.Add("authNo", manifestlist[i].AuthNo);
                        insidemanifest.Add("lastName", manifestlist[i].LastName);
                        insidemanifest.Add("firstName", manifestlist[i].FirstName);
                        insidemanifest.Add("title", manifestlist[i].Title);
                        insidemanifest.Add("gender", manifestlist[i].Gender);
                        insidemanifest.Add("stateRoom", manifestlist[i].StateRoom);
                        insidemanifest.Add("loyalty", manifestlist[i].Loyalty);
                        insidemanifest.Add("isResponsible", manifestlist[i].IsResponsible);
                        insidemanifest.Add("guestType", manifestlist[i].GuestType);
                        insidemanifest.Add("docType", manifestlist[i].DocType);
                        insidemanifest.Add("docNumber", manifestlist[i].DocNumber);
                        insidemanifest.Add("docIssueDate", manifestlist[i].DocIssueDate);
                        insidemanifest.Add("docExpiryDate", manifestlist[i].DocExpiryDate);
                        insidemanifest.Add("docIssueCountry", manifestlist[i].DocIssueCountry);
                        insidemanifest.Add("dateOfBirth", manifestlist[i].DateofBirth);
                        insidemanifest.Add("placeOfBirth", manifestlist[i].PlaceofBirth);
                        insidemanifest.Add("nationality", manifestlist[i].Nationality);
                        insidemanifest.Add("flagStatus", manifestlist[i].FlagStatus);
                        insidemanifest.Add("isOLC", manifestlist[i].IsOlc);
                        insidemanifest.Add("ccHolderName", manifestlist[i].CcHolderName);
                        insidemanifest.Add("ccMaskedNo", manifestlist[i].CcMaskedNo);
                        insidemanifest.Add("ccExpiry", manifestlist[i].CcExpiry);
                        insidemanifest.Add("ccType", manifestlist[i].CcType);
                        insidemanifest.Add("ccToken", manifestlist[i].CcToken);
                        insidemanifest.Add("shipCode", manifestlist[i].ShipCode);
                        insidemanifest.Add("shipName", manifestlist[i].ShipName);
                        insidemanifest.Add("embarkationDate", manifestlist[i].EmbarkationDate);
                        insidemanifest.Add("guestStatus", manifestlist[i].GuestStatus);
                        insidemanifest.Add("sailDate", manifestlist[i].SailDate);
                        insidemanifest.Add("musterStation", manifestlist[i].MusterStation);
                        insidemanifest.Add("checkInWindow", manifestlist[i].CheckInWindow);
                        insidemanifest.Add("departTime", manifestlist[i].DepartTime);
                        insidemanifest.Add("cabinCategory", manifestlist[i].CabinCategory);
                        insidemanifest.Add("requestedBy", manifestlist[i].RequestedBy);
                        insidemanifest.Add("requestorName", manifestlist[i].RequestorName);
                        insidemanifest.Add("purposeOfVisit", manifestlist[i].PurposeofVisit);
                        insidemanifest.Add("checkInStatus", manifestlist[i].CheckInStatus);
                        insidemanifest.Add("isCheckedIn", manifestlist[i].IsCheckedIn);
                        insidemanifest.Add("checkoutDate", manifestlist[i].CheckoutDate);
                        insidemanifest.Add("guestImage", manifestlist[i].GuestImage);
                        insidemanifest.Add("chkInDateTime", manifestlist[i].ChkInDateTime);
                        insidemanifest.Add("pictureType", manifestlist[i].PictureType);
                        insidemanifest.Add("gQuestionRes1", manifestlist[i].GQuestionRes1);
                        insidemanifest.Add("gQuestionRes2", manifestlist[i].GQuestionRes2);
                        insidemanifest.Add("pQuestionRes1", manifestlist[i].PQuestionRes1);
                        insidemanifest.Add("pQuestionRes2", manifestlist[i].PQuestionRes2);
                        insidemanifest.Add("barcode", manifestlist[i].Barcode);
                        insidemanifest.Add("onboardStatus", manifestlist[i].OnboardStatus);
                        insidemanifest.Add("zone", manifestlist[i].Zone);

                        listmanifest.Add(insidemanifest);
                    }

                    watch.Stop();
                    var duration = (watch.ElapsedMilliseconds).ToString();

                    //metadatadetails.Add("documents", documents);
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