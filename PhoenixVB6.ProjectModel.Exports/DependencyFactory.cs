using System;
using System.ComponentModel.Composition;

namespace PhoenixVB6.ProjectModel.Exports
{
	[Export(typeof(IDependencyFactory))]
	public class DependencyFactory : IDependencyFactory
	{
		#region IDependencyFactory Members

		public virtual ILibraryDependency CreateLibrary(DependencyType dependencyType, string displayName, string filePath, Guid typeLibId, int majorVersion, int minorVersion, int localeId)
		{
			return new LibraryDependency
			{
				DependencyType = dependencyType,
				DisplayName = displayName,
				FilePath = filePath,
				TypeLibId = typeLibId,
				MajorVersion = majorVersion,
				MinorVersion = minorVersion,
				LocaleId = localeId,
			};
		}

		public virtual IClassDependency CreateClass(string displayName, string filePath, Guid classId, string progId)
		{
			return new ClassDependency
			{
				DependencyType = DependencyType.Component,
				DisplayName = displayName,
				FilePath = filePath,
				ClassId = classId,
				ProgId = progId,
			};
		}

		#endregion
	}
}