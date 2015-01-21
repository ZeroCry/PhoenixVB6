using System;

namespace PhoenixVB6.ProjectModel.Exports
{
	public class LibraryDependency : Dependency, ILibraryDependency
	{
		protected Guid mTypeLibId;
		protected int mMajorVersion;
		protected int mMinorVersion;
		protected int mLocaleId;

		#region ILibraryDependency Members

		public virtual Guid TypeLibId
		{
			get { return mTypeLibId; }
			set { mTypeLibId = value; }
		}

		public virtual int MajorVersion
		{
			get { return mMajorVersion; }
			set { mMajorVersion = value; }
		}

		public virtual int MinorVersion
		{
			get { return mMinorVersion; }
			set { mMinorVersion = value; }
		}

		public virtual int LocaleId
		{
			get { return mLocaleId; }
			set { mLocaleId = value; }
		}

		#endregion
	}
}