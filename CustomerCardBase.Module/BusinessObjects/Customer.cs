using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;

namespace CustomerCardBase.Module.BusinessObjects
{
	[DefaultClassOptions]
	[ImageName("BO_Customer")]
	public class Customer : BaseObject
    { 
        public Customer(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

		private string _Code;
		[RuleRequiredField("RuleRequiredField for Customer.Code", DefaultContexts.Save, "You have to fill in the field!")]
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

		private DateTime _AgreementDate;
		public DateTime AgreementDate
		{
			get { return _AgreementDate; }
			set
			{
				if (SetPropertyValue<DateTime>(nameof(AgreementDate), ref _AgreementDate, value))
				{
					if (!IsLoading && !IsSaving)
					{

					}
				}
			}
		}

		private City _City2;
		public City City2
		{
			get { return _City2; }
			set
			{
				if (SetPropertyValue<City>(nameof(City2), ref _City2, value))
				{
					if (!IsLoading && !IsSaving)
					{

					}
				}
			}
		}

		private District _District2;
		public District District2
		{
			get { return _District2; }
			set
			{
                if (SetPropertyValue<District>(nameof(District2), ref _District2, value))
				{
					if (!IsLoading && !IsSaving)
					{

					}
				}
			}
		}
	}

}
