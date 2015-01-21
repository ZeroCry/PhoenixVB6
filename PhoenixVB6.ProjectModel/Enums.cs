#region Copyright Preamble

// 
//    Copyright 2015 Overman Group, LLC.
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

#endregion

using System.ComponentModel;

namespace PhoenixVB6.ProjectModel
{
	// TODO: Update casing and spelling of enum identifiers so that suppressions are no longer required.

	public enum ProjectType
	{
		[Description("Standard EXE")]
		Exe,

		[Description("ActiveX EXE")]
		OleExe,

		[Description("ActiveX DLL")]
		OleDll,

		[Description("ActiveX Control")]
		Control
	}

	public enum DependencyType
	{
		Reference = 0,
		Component,
	}

	public enum DataBindingBehavior
	{
		None = 0,
		SimpleBound = 1,
		ComplexBound = 2
	}

	public enum DataSourceBehavior
	{
		None = 0,
		DataSource = 1
	}

	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue")]
	public enum Instancing
	{
		Private = 1,
		PublicNotCreatable = 2,
		SingleUse = 3,
		GlobalSingleUse = 4,

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly",
			MessageId = "MultiUse")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly",
MessageId = "Multi")]
		MultiUse = 5,

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly",
			MessageId = "MultiUse")]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly",
MessageId = "Multi")]
		GlobalMultiUse = 6
	}

	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly",
		MessageId = "MTS")]
	// ReSharper disable once InconsistentNaming
	public enum MTSTransactionMode
	{
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly",
			MessageId = "MTS")]
		// ReSharper disable once InconsistentNaming
		NotAnMTSObject = 0,
		NoTransactions = 1,
		RequiresTransaction = 2,
		UsesTransaction = 3,
		RequiresNewTransaction = 4
	}

	public enum Persistable
	{
		NotPersistable = 0,
		Persistable = 1
	}
}