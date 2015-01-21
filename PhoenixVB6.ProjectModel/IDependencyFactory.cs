using System;

namespace PhoenixVB6.ProjectModel
{
	public interface IDependencyFactory
	{
		ILibraryDependency CreateLibrary(DependencyType dependencyType, string displayName, string filePath, Guid typeLibId, int majorVersion, int minorVersion, int localeId);

		IClassDependency CreateClass(string displayName, string filePath, Guid classId, string progId);
	}
}