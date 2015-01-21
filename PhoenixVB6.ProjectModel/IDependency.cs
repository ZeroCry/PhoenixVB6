namespace PhoenixVB6.ProjectModel
{
	// [ProjectReference]
	// http://msdn.microsoft.com/en-us/library/dd949122(v=office.12).aspx
	// 
	// Syntax:
	//   Standalone Windows:   Project=*\A(ProjectPath)
	//   Standalone Macintosh: Project=*\B(ProjectPath)
	//   Embedded Windows:     Project=*\C(ProjectPath)
	//   Embedded Macintosh:   Project=*\D(ProjectPath)
	//
	// Examples:
	//   Project=*\ATestProject.vbp
	//
	// Properties:
	//   ProjectPath

	// [LibraryReference]
	// http://msdn.microsoft.com/en-us/library/dd922767(v=office.12).aspx
	//
	// Syntax:
	//   Reference=*\G(TypeLibId)#(vMajor).(vMinor)#(LCID)#(FilePath)#(DisplayName)
	//
	// Examples:
	//   Reference=*\G{00020430-0000-0000-C000-000000000046}#2.0#0#C:\Windows\SysWOW64\stdole2.tlb#OLE Automation
	//   Reference=*\G{2A75196C-D9EB-4129-B803-931327F72D5C}#2.8#0#C:\Program Files (x86)\Common Files\System\ado\msado28.tlb#Microsoft ActiveX Data Objects 2.8 Library
	//
	// TypeLibrary:
	//   DisplayName: 'HKCR\TypeLib\(TypeLibId)\(vMajor).(vMinor)\(Default)' regkey
	//   FilePath: 'HKCR\TypeLib\(TypeLibId)\(vMajor).(vMinor)\(LCID)\win32\(Default)' regkey

	// [ObjectReference]
	// http://msdn.microsoft.com/en-us/library/windows/desktop/ms221610(v=vs.85).aspx
	//
	// Syntax:
	//   Object=(ProgId); (FileNameHint)
	//   Object=(TypeLibId)#(vMajor)#(vMinor)#(LCID); (FileNameHint)
	//
	// Examples:
	//   Object=Equation.3; EQNEDT32.EXE
	//   Object={82351433-9094-11D1-A24B-00A0C932C7DF}#1.5#0; AniGIF.ocx
	//
	// Controls:
	//   Where: 'HKCR\(ProgId)\Control' exists
	//   Where: 'HKCR\CLSID\(CLSID)\Control' exists
	//   Where: 'HKCR\TypeLib\(TypeLibId)\(vMajor).(vMinor)\FLAGS' contains LIBFLAG_FCONTROL
	//   DisplayName: TypeLibName (unique)
	//   FilePath: (InProcServer32) or (LocalServer32)
	//
	// Insertable Objects:
	//   Where: 'HKCR\(ProgId)\Insertable' exists
	//   Where: 'HKCR\CLSID\(CLSID)\Insertable' exists
	//   DisplayName: ClassName (non-unique)
	//   FilePath: (InProcServer32) or (LocalServer32)
	//
	// Classes:
	//   DisplayName: Value from '(Default)' regkey
	//   FilePath: (InProcServer32) or (LocalServer32)
	//
	// Possible Properties:
	//   Guid
	//   MajorVersion
	//   MinorVersion
	//   LocaleId
	//   FileNameHint

	public interface IDependency : IProjectItem
	{
		DependencyType DependencyType { get; }

		string DisplayName { get; }

		string FilePath { get; }

		void Refresh();
	}
}