namespace PhoenixVB6.ProjectModel
{
	public interface IProjectContext
	{
		string ProjectPath { get; }

		IFileSystem FileSystem { get; }

		IProject Project { get; }
	}
}