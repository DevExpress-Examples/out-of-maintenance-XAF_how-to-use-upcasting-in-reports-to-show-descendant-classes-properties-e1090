using System;

using DevExpress.ExpressApp.Updating;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp.Reports;
using DevExpress.Persistent.BaseImpl;

namespace WinExample.Module {
    public class Updater : ModuleUpdater {
        public Updater(DevExpress.ExpressApp.IObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            CreateReport("EmployeeBaseReport");
            EmployeeBase employee = ObjectSpace.CreateObject<EmployeeBase>();
            employee.Name = "Employee";
            employee.Email = "employee1@corp.com";
            ForeignEmployee foreignEmployee = ObjectSpace.CreateObject<ForeignEmployee>();
            foreignEmployee.Name = "Foreign Employee";
            foreignEmployee.Email = "employee2@corp.com";
            foreignEmployee.VisaExpirationDate = DateTime.Now.AddMonths(2);
            LocalEmployee localEmployee = ObjectSpace.CreateObject<LocalEmployee>();
            localEmployee.Name = "Local Employee";
            localEmployee.Email = "employee3@corp.com";
            localEmployee.InsurancePolicyNumber = "111-222-333";
        }
        private void CreateReport(string reportName) {
            ReportData reportdata = ObjectSpace.FindObject<ReportData>(new BinaryOperator("Name", reportName));
            if (reportdata == null) {
                reportdata = ObjectSpace.CreateObject<ReportData>();
                XafReport rep = new XafReport();
                rep.ReportName = reportName;
                rep.ObjectSpace = ObjectSpace;
                rep.LoadLayout(GetType().Assembly.GetManifestResourceStream(
                   "WinExample.Module.EmbeddedReports." + reportName + ".repx"));
                reportdata.SaveReport(rep);
                reportdata.Save();
            }
        }
    }
}
