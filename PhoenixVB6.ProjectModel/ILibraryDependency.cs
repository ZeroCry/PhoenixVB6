using System;

namespace PhoenixVB6.ProjectModel
{
	public interface ILibraryDependency : IDependency
	{
		Guid TypeLibId { get; }

		int MajorVersion { get; }

		int MinorVersion { get; }

		int LocaleId { get; }
	}
}