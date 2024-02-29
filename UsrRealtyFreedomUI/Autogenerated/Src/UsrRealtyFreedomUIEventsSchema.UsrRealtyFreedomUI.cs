namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyFreedomUIEventsSchema

	/// <exclude/>
	public class UsrRealtyFreedomUIEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyFreedomUIEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyFreedomUIEventsSchema(UsrRealtyFreedomUIEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("77ce04d6-7346-45c4-92e2-ed1411c3b7e3");
			Name = "UsrRealtyFreedomUIEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4f4f52cd-c1fb-429e-a671-eb1bfa346bef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,77,79,227,48,16,189,35,241,31,70,209,30,18,169,178,224,186,124,72,219,170,172,42,161,5,209,148,203,106,15,174,51,13,70,254,136,108,167,80,16,255,157,113,156,46,37,45,18,115,177,61,126,243,102,222,211,24,174,209,55,92,32,148,232,28,247,118,21,216,196,154,149,172,91,199,131,180,230,248,232,245,248,8,40,90,47,77,13,243,141,15,168,207,118,83,187,133,90,91,243,229,167,67,54,53,65,6,137,254,59,24,54,93,163,9,91,232,223,46,189,233,114,215,146,134,48,232,242,185,120,64,205,255,144,6,184,128,108,225,221,29,114,21,54,87,14,177,178,122,49,203,138,127,169,186,105,151,74,10,16,138,123,15,9,116,128,15,126,194,152,123,60,240,147,88,122,39,118,8,237,154,102,151,21,194,218,202,10,110,204,156,175,73,81,110,151,143,40,2,120,52,21,186,17,36,194,49,174,72,94,71,251,203,213,30,176,248,160,219,97,142,177,164,41,216,127,182,45,13,22,103,159,97,137,23,92,167,135,28,200,83,162,72,5,3,112,133,66,106,174,160,113,82,68,187,82,21,251,141,161,220,52,88,77,172,106,181,185,231,170,197,243,30,122,153,71,75,111,35,62,27,182,150,43,200,19,211,37,156,158,108,163,248,12,26,168,138,129,108,230,39,220,8,84,88,209,16,193,181,72,204,251,56,31,92,92,13,90,78,207,107,44,81,55,138,135,56,182,193,39,184,182,130,43,249,194,151,10,231,29,46,239,197,44,60,58,218,94,67,230,211,234,178,59,244,182,117,130,64,214,17,203,8,246,251,196,56,176,56,105,245,178,17,100,123,189,60,235,76,154,249,210,218,177,172,211,43,43,88,105,251,89,138,111,8,34,33,41,193,174,172,211,60,228,3,161,212,248,148,157,140,127,236,249,30,35,60,56,251,212,25,49,125,22,216,68,169,219,250,33,252,237,227,217,95,233,120,123,7,210,234,72,108,245,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("0c4c2218-df5f-fff8-154b-a110e0e220d8"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("4f4f52cd-c1fb-429e-a671-eb1bfa346bef"),
				CreatedInSchemaUId = new Guid("77ce04d6-7346-45c4-92e2-ed1411c3b7e3"),
				ModifiedInSchemaUId = new Guid("77ce04d6-7346-45c4-92e2-ed1411c3b7e3")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("77ce04d6-7346-45c4-92e2-ed1411c3b7e3"));
		}

		#endregion

	}

	#endregion

}

