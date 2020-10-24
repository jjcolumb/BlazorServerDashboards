using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace XAFBlazorDashboards.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class DomainObject1 : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public DomainObject1(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        string _name;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Name
        {
            get => _name;
            set => SetPropertyValue(nameof(Name), ref _name, value);
        }

        string _address;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Address

        {
            get => _address;
            set => SetPropertyValue(nameof(Address), ref _address, value);
        }


        bool _active;
        public bool Active
        {
            get => _active;
            set => SetPropertyValue(nameof(Active), ref _active, value);
        }


        DateTime _birthday;
        public DateTime Birthday
        {
            get => _birthday;
            set => SetPropertyValue(nameof(Birthday), ref _birthday, value);
        }


        decimal _salary;
        public decimal Salary
        {
            get => _salary;
            set => SetPropertyValue(nameof(Salary), ref _salary, value);
        }

    }
}