using System;
using System.Linq;
using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.BaseImpl;
using XAFBlazorDashboards.Module.BusinessObjects;
using Bogus;

namespace XAFBlazorDashboards.Module.DatabaseUpdate {
    // For more typical usage scenarios, be sure to check out https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Updating.ModuleUpdater
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
            base(objectSpace, currentDBVersion) {
        }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();

            if (ObjectSpace.GetObjectsCount(typeof(DomainObject1), null) == 0)
            {
                var userFaker = new Faker<DomainObject1>()
                    .CustomInstantiator(f => new DomainObject1(((XPObjectSpace)ObjectSpace).Session))
                    .RuleFor(o => o.Name, f => f.Name.FullName())
                    .RuleFor(o => o.Address, f => f.Address.FullAddress())
                    .RuleFor(o => o.Active, f => f.Random.Bool())
                    .RuleFor(o => o.Birthday, f => f.Date.Recent(100))
                    .RuleFor(o => o.Salary, f => f.Random.Decimal(50000, 100000));
                var users = userFaker.Generate(3000);



                ObjectSpace.CommitChanges();
            }
        }
        public override void UpdateDatabaseBeforeUpdateSchema() {
            base.UpdateDatabaseBeforeUpdateSchema();
            //if(CurrentDBVersion < new Version("1.1.0.0") && CurrentDBVersion > new Version("0.0.0.0")) {
            //    RenameColumn("DomainObject1Table", "OldColumnName", "NewColumnName");
            //}
        }
    }
}
