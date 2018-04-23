using DevExpress.Xpo;

using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;

namespace WinExample.Module {
    [DefaultClassOptions]
    public class EmployeeBase : BaseObject {
        public EmployeeBase(Session session) : base(session) { }
        private string name;
        private string email;
        public string Name {
            get { return name; }
            set {
                SetPropertyValue("Name", ref name, value);
            }
        }
        public string Email {
            get { return email; }
            set {
                SetPropertyValue("Email", ref email, value);
            }
        }
    }

}
