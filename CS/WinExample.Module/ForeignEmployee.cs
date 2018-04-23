using System;

using DevExpress.Xpo;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace WinExample.Module {
    [DefaultClassOptions]
    public class ForeignEmployee : EmployeeBase {
        public ForeignEmployee(Session session) : base(session) { }
        private DateTime visaExpirationDate;
        public DateTime VisaExpirationDate {
            get { return visaExpirationDate; }
            set {
                SetPropertyValue("VisaExpirationDate", ref visaExpirationDate, value);
            }
        }
    }

}
