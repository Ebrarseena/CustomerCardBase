﻿using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;

namespace CustomerCardBase.Module.BusinessObjects
{
	[DefaultClassOptions]
	[ImageName("BO_City")]
	public class City : BaseObject
	{
		public City(Session session)
			: base(session)
		{
		}
		public override void AfterConstruction()
		{
			base.AfterConstruction();
		}

		private string _Code;
		[RuleRequiredField("RuleRequiredField for City.Code", DefaultContexts.Save, "You have to fill in the field!")]
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

		[Association("City-Districts"), Aggregated]
		public XPCollection<District> Districts
		{
			get { return GetCollection<District>(nameof(Districts)); }
		}
	}
}
