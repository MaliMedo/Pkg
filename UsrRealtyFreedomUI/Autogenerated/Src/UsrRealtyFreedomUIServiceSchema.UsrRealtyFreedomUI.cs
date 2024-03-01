namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyFreedomUIServiceSchema

	/// <exclude/>
	public class UsrRealtyFreedomUIServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyFreedomUIServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyFreedomUIServiceSchema(UsrRealtyFreedomUIServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("549ce1b9-76ab-42b6-872f-76fc12f9162c");
			Name = "UsrRealtyFreedomUIService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4f4f52cd-c1fb-429e-a671-eb1bfa346bef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,83,112,204,171,84,112,86,86,112,206,79,73,5,0,97,143,3,221,12,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("549ce1b9-76ab-42b6-872f-76fc12f9162c"));
		}

		#endregion

	}

	#endregion

}

