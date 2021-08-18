using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sree_Health.Models
{
    public class PrescriptionsViewModels
    {
        public string DoctorEmail { get; set; }
        public string AppointmentID { get; set; }
        public string Prescription { get; set; }
        public bool Status { get; set; }
    }
    public class PrescriptionsListModel
    {
        public string PrescriptionID { get; set; }
        public DateTime CreateDate { get; set; }
        public string Prescription { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Department { get; set; }
        public string Doctor { get; set; }
        public string Patient { get; set; }
        public bool Status { get; set; }
    }

}