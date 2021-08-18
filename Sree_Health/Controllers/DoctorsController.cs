using ClassLibrary_SreeHealth;
using Microsoft.AspNet.Identity;
using Sree_Health.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Sree_Health.Controllers
{
    [Authorize]
    public class DoctorsController : Controller
    {
        DepartmentsController departments = new DepartmentsController();
        // GET: Doctors
        public ActionResult Index()
        {
            List<DoctorsListModel> list = LoadDoctors();
            return View(list);
        }

        // GET: Doctors/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Doctors/Create
        public ActionResult CreateDoctors()
        {
            DoctorsViewModels model = new DoctorsViewModels();
            model.DepartmentsList = departments.LoadDepartmentsList();
            return View(model);
        }

        // POST: Doctors/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateDoctors(DoctorsViewModels model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    InsertDoctors(model);
                    //LoginLinkDoctor(model);
                    return RedirectToAction("Register", "Account", new { Email = model.Email, UserRole = 2 });
                }
                catch (Exception e)
                {
                    model.DepartmentsList = departments.LoadDepartmentsList();
                    return View(model);
                }
            }
            return View();
        }

        // GET: Doctors/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Doctors/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Doctors/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Doctors/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        #region Functions
        private List<DoctorsListModel> LoadDoctors()
        {
            BusinessLib blib = new BusinessLib();
            DataTable dataTable = blib.Load_T02();
            List<DoctorsListModel> list = new List<DoctorsListModel>();
            DoctorsListModel model;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                model = new DoctorsListModel();
                model.DoctorID = dataRow["DoctorID"].ToString();
                model.Department = dataRow["Department"].ToString();
                model.Doctor = dataRow["Doctor"].ToString();
                model.Qualification = dataRow["Qualification"].ToString();
                model.Note = dataRow["Note"].ToString();
                model.Email = dataRow["Email"].ToString();
                model.Contact = dataRow["Contact"].ToString();
                model.Address = dataRow["Address"].ToString();
                model.Status = Convert.ToBoolean(dataRow["Status"].ToString());
                list.Add(model);
            }
            return list;
        }
        public List<DoctorsListModel> LoadDoctorsList()
        {
            BusinessLib blib = new BusinessLib();
            DataTable dataTable = blib.Load_T02_Doctors();
            List<DoctorsListModel> list = new List<DoctorsListModel>();
            DoctorsListModel model;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                model = new DoctorsListModel();
                model.DoctorID = dataRow["DoctorID"].ToString();
                model.Doctor = dataRow["Doctor"].ToString();
                list.Add(model);
            }
            return list;
        }

        private void InsertDoctors(DoctorsViewModels model)
        {
            BusinessLib blib = new BusinessLib();
            PropertyLib plib = new PropertyLib();
            plib.DepartmentID = model.DepartmentID;
            plib.Doctor = model.Doctor;
            plib.Qualification = model.Qualification;
            plib.Note = model.Note;
            plib.Email = model.Email;
            plib.Contact = model.Contact;
            plib.Address = model.Address;
            plib.Status = model.Status;
            plib.UserID = User.Identity.GetUserId() ?? "";
            blib.Insert_T02(plib);
        }
        //private void LoginLinkDoctor(DoctorsViewModels Model)
        //{

        //    MailMessage mail = new MailMessage();
        //    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
        //    //mail.From = new MailAddress("\"JobPortal\"  <no-reply@jobportalapp.com>");
        //    //mail.From = new MailAddress("\"BARAKATFRESH\"  <webmailer@webaaps.com>");
        //    //mail.To.Add("sreeji0009@gmail.com");
        //    mail.From = new MailAddress("\"JobPortalApp\"<no-reply@ihealth.com>");
        //    mail.To.Add(new MailAddress(Model.Email));

        //    //mail.CC.Add("sub-membership@icaiauh.org");
        //    //mail.To.Add(_email);
        //    //icai_business_library obj_bll = new icai_business_library();
        //    //icai_app_property objcls = new icai_app_property();
        //    //objcls.id = _mail_id;
        //    //DataTable _data = obj_bll.load_mass_mail_details(objcls);
        //    //string _subject = _data.Rows[0]["subject"].ToString();
        //    //string _message = _data.Rows[0]["message"].ToString();
        //    //mail.Subject = "Preview: " + _subject;
        //    mail.Subject = "Sign Up request";
        //    //mail.Subject = _subject;
        //    mail.IsBodyHtml = true;
        //    //string _payments = "";
        //    //decimal _total = 0;
        //    //_message = _message.Replace("|MEMBER|", "CA Ashish Bhandari");
        //    //if (_data.Rows[0]["email_top_image"].ToString() != "")
        //    //{
        //    //string _FileAttachment = Path.Combine(Server.MapPath("~/_email_attachments"), _data.Rows[0]["email_top_image"].ToString());
        //    //string _FileAttachment = Path.Combine(Server.MapPath("~/Content/Attachments/CandidateCV"), NewAttachmentPath);
        //    //mail.Attachments.Add(new Attachment(_FileAttachment));
        //    //}
        //    //if (_data.Rows[0]["attachment2"].ToString() != "")
        //    //{
        //    //    string _FileAttachment = Path.Combine(Server.MapPath("~/_email_attachments"), _data.Rows[0]["attachment2"].ToString());
        //    //    mail.Attachments.Add(new Attachment(_FileAttachment));
        //    //}

        //    string message = "";
        //        message = "<p><strong>Hello " + Model.Doctor + ", </strong></p><p>You are registerd for the Your application has been received for the following job opportunity:</p><p><strong>" + Model.ApplyJobTitle + "</strong><br/>Your application Reference ID: <strong>" + Model.ReferenceId + "</strong></p><p>Our recruiting team will evaluvate your application and contact you should your skills and qualifications match the requirements for the position.</p><p>Thank you for your interest in SFC Group.</p>";
        //        //message = "<p> <strong>" + Model.FirstName + ",</strong></p><br/>" +
        //        //    "<h5>Your application Reference Id : " + Model.ReferenceId + "</h5>" +
        //        //    "<p>Your application submitted successfully</p><br/><p><strong>JobPortal</strong></p>";
        //    string htmlBody = message;
        //    //string htmlBody = _message;
        //    StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "\\EmailTemplates\\" + "EmailTemplate.txt");
        //    string msgbody = sr.ReadToEnd();
        //    msgbody = msgbody.Replace("|MessageBody|", htmlBody);
        //    //msgbody = msgbody + "<p style='text-align:center'>Please click below to confirm your attendance</p><p><a href='" + _link + "' style='display:block;font-weight:bold;background-color:#5cb85c;color:#f5f5f5;width:300px;padding:10px;text-align:center'>REGISTER NOW</a></p>";
        //    //msgbody = msgbody;
        //    //mail.Body = htmlBody;
        //    mail.Body = msgbody;
        //    mail.Priority = MailPriority.Normal;
        //    SmtpServer.Port = 587;
        //    SmtpServer.UseDefaultCredentials = true;
        //    SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
        //    SmtpServer.Credentials = new System.Net.NetworkCredential("sreeihealth@gmail.com", "ihealth@123");
        //    SmtpServer.EnableSsl = true;
        //    try
        //    {
        //        SmtpServer.Send(mail);
        //    }
        //    catch (SmtpFailedRecipientsException ex)
        //    {
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //}

        //public string SendCodeToEmail(DoctorsViewModels model)
        //{
        //    SmtpClient _myclient = new SmtpClient("mail.google.net");
        //    _myclient.EnableSsl = false;
        //    _myclient.Port = 587;
        //    _myclient.Credentials = new System.Net.NetworkCredential("sreeihealth@gmail.com", "ihealth@123");
        //    MailMessage msg = new MailMessage();
        //    msg.From = new MailAddress("\"Oboticario\"<no-reply@oboticario.com>");
        //    msg.To.Add(new MailAddress(model.Email));
        //    //msg.To.Add(new MailAddress("sreeji0009@gmail.com"));
        //    msg.Priority = MailPriority.High;
        //    msg.IsBodyHtml = true;
        //    msg.Subject = "Registration code";
        //    model.Code = "12345";
        //    string message = "<p>Please use this code to Register with Oboticario <strong>" + model.Code + "</strong></p><br/><br/><p>Oboticario</p>";
        //    msg.Body = message;
        //    _myclient.Send(msg);
        //    return (model.Code);
        //}
        #endregion Functions

    }
}
