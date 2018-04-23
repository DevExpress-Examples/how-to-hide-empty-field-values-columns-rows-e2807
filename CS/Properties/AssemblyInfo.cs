﻿// Developer Express Code Central Example:
// How to hide empty Field Values (Columns/Rows)
// 
// It is necessary to use the PivotGridControl.CustomFieldValueCells
// (ms-help://MS.VSCC.v90/MS.VSIPCC.v90/DevExpress.NETv10.2/DevExpress.WindowsForms/DevExpressXtraPivotGridPivotGridControl_CustomFieldValueCellstopic.htm)
// event to accomplish this task. See Also:
// http://www.devexpress.com/scid=E2769
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E2807

// Developer Express Code Central Example:
// How to hide particular rows and columns
// 
// The following example demonstrates how to hide particular rows and columns by
// handling the CustomFieldValueCells event.
// In this example, the event handler
// iterates through all row headers and removes rows that correspond to the
// &quot;Employee B&quot; field value, and that are not Total Rows.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E2769

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("XtraPivotGrid_HidingColumnsAndRows")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("XtraPivotGrid_HidingColumnsAndRows")]
[assembly: AssemblyCopyright("Copyright ©  2010")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("0f2fdb4f-f8f2-407f-be1a-6022b677a73d")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
