using System;
using System.ComponentModel.Composition;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using CuttingEdge.Conditions;

namespace PhoenixVB6.ProjectModel.Exports
{
	[Export(ContractName, typeof(IProjectItemProvider))]
	public class LibraryReferenceProvider : IProjectItemProvider
	{
		private const string ContractName = "Reference";
		private static readonly Regex mRegex = new Regex(@"^Reference=\*\\G(?<TypeLibId>\{.+\})#(?<MajorVersion>[[:xdigit:]]{1,4})\.(?<MinorVersion>[[:xdigit:]]{1,4})#(?<LocaleId>[[:xdigit:]]{1,8})#(?<FilePath>.+)#(?<DisplayName>.+)$");

		[Import]
		public virtual IDependencyFactory DependencyFactory { get; set; }

		public virtual bool TryRead(IProjectContext context, LineInfo line, out IProjectItem item)
		{
			var match = mRegex.Match(line.Full);
			if (!match.Success)
			{
				item = null;
				return false;
			}

			var strTypeLibId = match.Groups["TypeLibId"].Value;
			var strMajorVersion = match.Groups["MajorVersion"].Value;
			var strMinorVersion = match.Groups["MinorVersion"].Value;
			var strLocaleId = match.Groups["LocaleId"].Value;
			var filePath = match.Groups["FilePath"].Value;
			var displayName = match.Groups["DisplayName"].Value;

			Guid typeLibId;
			Guid.TryParse(strTypeLibId, out typeLibId);

			int majorVersion;
			Int32.TryParse(strMajorVersion, NumberStyles.HexNumber, null, out majorVersion);

			int minorVersion;
			Int32.TryParse(strMinorVersion, NumberStyles.HexNumber, null, out minorVersion);

			int localeId;
			Int32.TryParse(strLocaleId, NumberStyles.HexNumber, null, out localeId);

			var dependency = DependencyFactory.CreateLibrary(
				DependencyType.Reference,
				displayName,
				filePath,
				typeLibId,
				majorVersion,
				minorVersion,
				localeId);

			dependency.Refresh();

			item = dependency;
			return true;
		}

		public virtual void Write(IProjectContext context, StreamWriter writer, IProjectItem item)
		{
			Condition.Requires(writer, "writer").IsNotNull();
			Condition.Requires(item, "item").IsNotNull();

			var dependency = (ILibraryDependency)item;
			var strTypeLibId = dependency.TypeLibId.ToString("B");
			var hexMajorVersion = dependency.MajorVersion.ToString("X");
			var hexMinorVersion = dependency.MinorVersion.ToString("X");
			var hexLocaleId = dependency.LocaleId.ToString("X");

			writer.Write(ContractName);
			writer.Write("*G\\");
			writer.Write(strTypeLibId);
			writer.Write("#");
			writer.Write(hexMajorVersion);
			writer.Write(".");
			writer.Write(hexMinorVersion);
			writer.Write("#");
			writer.Write(hexLocaleId);
			writer.Write("#");
			writer.Write(dependency.FilePath);
			writer.Write("#");
			writer.Write(dependency.DisplayName);
			writer.WriteLine();
		}

	}
}