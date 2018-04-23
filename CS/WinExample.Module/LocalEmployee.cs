using DevExpress.Xpo;

using DevExpress.Persistent.Base;

namespace WinExample.Module {
    [DefaultClassOptions]
    public class LocalEmployee : EmployeeBase {
        public LocalEmployee(Session session) : base(session) { }
        private string insurancePolicyNumber;
        public string InsurancePolicyNumber {
            get { return insurancePolicyNumber; }
            set {
                SetPropertyValue("InsurancePolicyNumber", ref insurancePolicyNumber, value);
            }
        }
    }

}
