using System;

namespace PhoenixVB6.ProjectModel.Exports
{
	public class ClassDependency : Dependency, IClassDependency
	{
		protected Guid mClassId;
		protected string mProgId;

		#region IClassDependency Members

		public virtual Guid ClassId
		{
			get { return mClassId; }
			set { mClassId = value; }
		}

		public virtual string ProgId
		{
			get { return mProgId; }
			set { mProgId = value; }
		}

		#endregion
	}
}