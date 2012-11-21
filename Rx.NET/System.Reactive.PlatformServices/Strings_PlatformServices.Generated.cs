﻿/*
 * This file is manually generated upon every change to the corresponding .resx file, using the built-in code generator.
 * However, we can't use auto-generated code because the output is different for .NET 4.5 for Metro and PLIB, due to
 * changes in the reflection APIs (search for CRIPPLED_REFLECTION in this file), and because regeneration doesn't happen
 * as part of build, but rather at design time in Visual Studio. While we likely could tweak MSBuild to force regeneration
 * using the right version of ResGen.exe, this approach turned out to be the easiest for the time being.
 * 
 * Upon adding entries to the ResX file, regenerate this file, put this comment back, and make sure to add the #if checks
 * for conditional use of the right flavor of reflection (using the CRIPPLED_REFLECTION defined symbol).
 */

// Required for the use of the GetTypeInfo extension method.
#if CRIPPLED_REFLECTION
using System.Reflection;
#endif

// GENERATED CODE starts here

namespace System.Reactive
{
    using System;


    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings_PlatformServices
    {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings_PlatformServices()
        {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
#if CRIPPLED_REFLECTION
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Reactive.Strings_PlatformServices", typeof(Strings_PlatformServices).GetTypeInfo().Assembly);
#else
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Reactive.Strings_PlatformServices", typeof(Strings_PlatformServices).Assembly);
#endif
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The WinRT thread pool doesn&apos;t support creating periodic timers with a period below 1 millisecond..
        /// </summary>
        internal static string WINRT_NO_SUB1MS_TIMERS
        {
            get
            {
                return ResourceManager.GetString("WINRT_NO_SUB1MS_TIMERS", resourceCulture);
            }
        }
    }
}
