using System;

using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp.Reports;
using DevExpress.ExpressApp;

namespace WinExample.Module {
    public class Updater : ModuleUpdater {
        public Updater(Session session, Version currentDBVersion) : base(session, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            CreateReport("EmployeeBaseReport");
            EmployeeBase employee = new EmployeeBase(Session);
            employee.Name = "Employee";
            employee.Email = "employee1@corp.com";
            employee.Save();
            ForeignEmployee foreignEmployee = new ForeignEmployee(Session);
            foreignEmployee.Name = "Foreign Employee";
            foreignEmployee.Email = "employee2@corp.com";
            foreignEmployee.VisaExpirationDate = DateTime.Now.AddMonths(2);
            foreignEmployee.Save();
            LocalEmployee localEmployee = new LocalEmployee(Session);
            localEmployee.Name = "Local Employee";
            localEmployee.Email = "employee3@corp.com";
            localEmployee.InsurancePolicyNumber = "111-222-333";
            localEmployee.Save();
        }
        private void CreateReport(string reportName) {
            ReportData reportdata = Session.FindObject<ReportData>(new BinaryOperator("Name", reportName));
            if (reportdata == null) {
                reportdata = new ReportData(Session);
                XafReport rep = new XafReport();
                rep.ReportName = reportName;
                rep.ObjectSpace = new ObjectSpace(new UnitOfWork(Session.DataLayer), XafTypesInfo.Instance);
                rep.LoadLayout(GetType().Assembly.GetManifestResourceStream(
                   "WinExample.Module.EmbeddedReports." + reportName + ".repx"));
                reportdata.SaveXtraReport(rep);
                reportdata.Save();
            }
        }
    }
}
