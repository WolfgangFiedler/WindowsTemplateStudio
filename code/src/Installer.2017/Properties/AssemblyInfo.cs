﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using Microsoft.VisualStudio.Shell;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Microsoft.Templates.Extension")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Microsoft.Templates.Extension")]
[assembly: AssemblyCopyright("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("0.0.0.0")]
[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)]
[assembly: ProvideBindingRedirection(AssemblyName = "Microsoft.TemplateEngine.Abstractions", Culture = "neutral", OldVersionLowerBound = "1.0.0.0", OldVersionUpperBound = "1.0.0.234", NewVersion = "1.0.0.234")]
[assembly: ProvideBindingRedirection(AssemblyName = "Microsoft.TemplateEngine.Edge", Culture = "neutral", OldVersionLowerBound = "1.0.0.0", OldVersionUpperBound = "1.0.0.234", NewVersion = "1.0.0.234")]
[assembly: ProvideBindingRedirection(AssemblyName = "Microsoft.TemplateEngine.Utils", Culture = "neutral", OldVersionLowerBound = "1.0.0.0", OldVersionUpperBound = "1.0.0.234", NewVersion = "1.0.0.234")]
[assembly: ProvideBindingRedirection(AssemblyName = "Microsoft.TemplateEngine.Orchestrator.RunnableProjects", Culture = "neutral", OldVersionLowerBound = "1.0.0.0", OldVersionUpperBound = "1.0.0.234", NewVersion = "1.0.0.234")]
[assembly: ProvideBindingRedirection(AssemblyName = "Microsoft.TemplateEngine.Core", Culture = "neutral", OldVersionLowerBound = "1.0.0.0", OldVersionUpperBound = "1.0.0.234", NewVersion = "1.0.0.234")]
[assembly: ProvideBindingRedirection(AssemblyName = "Microsoft.TemplateEngine.Core.Contracts", Culture = "neutral", OldVersionLowerBound = "1.0.0.0", OldVersionUpperBound = "1.0.0.234", NewVersion = "1.0.0.234")]
