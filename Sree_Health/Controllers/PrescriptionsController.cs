using ClassLibrary_SreeHealth;
using Microsoft.AspNet.Identity;
using Sree_Health.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sree_Health.Controllers
{
    public class PrescriptionsController : Controller
    {
        // GET: Prescriptions
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index_Patient(string PatientEmail)
        {
            List<PrescriptionsListModel> list = LoadPrescriptions_Patient(PatientEmail);
            return View(list);
        }

        // GET: Prescriptions/Details/5
        public ActionResult Details(int id)
        {
            
            return View();
        }

        // GET: Prescriptions/Create
        public ActionResult CreatePrescriptions(string AppointmentID, string DoctorEmail)
        {
            PrescriptionsViewModels model = new PrescriptionsViewModels();
            model.AppointmentID = AppointmentID;
            model.DoctorEmail = DoctorEmail;
            return View(model);
        }

        // POST: Prescriptions/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreatePrescriptions(PrescriptionsViewModels model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    InsertPrescriptions(model);
                    return RedirectToAction("Index_Doctor", "Appointments", new { DoctorEmail = model.DoctorEmail });
                }
                catch (Exception e)
                {
                    return RedirectToAction("Index_Doctor", "Appointments", new { DoctorEmail = model.DoctorEmail });
                }
            }
            return RedirectToAction("Index_Doctor", "Appointments", new { DoctorEmail = model.DoctorEmail });
        }

        // GET: Prescriptions/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Prescriptions/Edit/5
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

        // GET: Prescriptions/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Prescriptions/Delete/5
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
        private void InsertPrescriptions(PrescriptionsViewModels model)
        {
            BusinessLib blib = new BusinessLib();
            PropertyLib plib = new PropertyLib();
            plib.AppointmentID = model.AppointmentID;
            plib.Prescription = model.Prescription;
            plib.Status = model.Status;
            plib.UserID = User.Identity.GetUserId() ?? "";
            blib.Insert_T05(plib);
        }
        private List<PrescriptionsListModel> LoadPrescriptions_Patient(string Email)
        {
            BusinessLib blib = new BusinessLib();
            PropertyLib plib = new PropertyLib();
            plib.Email = Email;
            DataTable dataTable = blib.Load_T05_Patient(plib);
            List<PrescriptionsListModel> list = new List<PrescriptionsListModel>();
            PrescriptionsListModel model;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                model = new PrescriptionsListModel();
                model.PrescriptionID = dataRow["PrescriptionID"].ToString();
                model.CreateDate = Convert.ToDateTime(dataRow["CreateDate"].ToString());
                model.Prescription = dataRow["Prescription"].ToString();
                model.AppointmentDate = Convert.ToDateTime(dataRow["AppointmentDate"].ToString());
                model.Department = dataRow["Department"].ToString();
                model.Doctor = dataRow["Doctor"].ToString();
                model.Patient = dataRow["Patient"].ToString();
                model.Status = Convert.ToBoolean(dataRow["Status"].ToString());
                list.Add(model);
            }
            return list;
        }

    }
}
