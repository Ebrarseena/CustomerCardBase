using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;

namespace CustomerCardBase.Module.BusinessObjects
{
    [DefaultClassOptions]
    [ImageName("BO_District")]
    public class District : BaseObject
    {
        public District(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();

        }

        private string _Code;
        [RuleRequiredField("RuleRequiredField for District.Code", DefaultContexts.Save, "You have to fill in the field!")]
        /// <summary>
        ///
        /// </summary>
        public string Code
        {
            get { return _Code; }
            set
            {
                if (SetPropertyValue<string>(nameof(Code), ref _Code, value))
                {
                    if (!IsLoading && !IsSaving)
                    {

                    }
                }
            }
        }

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                if (SetPropertyValue<string>(nameof(Name), ref _Name, value))
                {
                    if (!IsLoading && !IsSaving)
                    {

                    }
                }
            }
        }

        private City _City;
        [Association("City-Districts")]
        public City City
        {
            get { return _City; }
            set
            {
                if (SetPropertyValue<City>(nameof(City), ref _City, value))
                {
                    if (!IsLoading && !IsSaving)
                    {

                    }
                }
            }
        }

    }
}