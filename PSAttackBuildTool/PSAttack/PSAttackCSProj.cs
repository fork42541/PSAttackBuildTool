﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace PSAttackBuildTool.PSAttack
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\jared\Documents\GitHub\PSAttackBuildTool\PSAttack\PSAttack\PSAttackCSProj.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class PSAttackCSProj : PSAttackCSProjBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("﻿<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<Project ToolsVersion=\"14.0\" DefaultTarg" +
                    "ets=\"Build\" xmlns=\"http://schemas.microsoft.com/developer/msbuild/2003\">\r\n  <Imp" +
                    "ort Project=\"$(MSBuildExtensionsPath)\\$(MSBuildToolsVersion)\\Microsoft.Common.pr" +
                    "ops\" Condition=\"Exists(\'$(MSBuildExtensionsPath)\\$(MSBuildToolsVersion)\\Microsof" +
                    "t.Common.props\')\" />\r\n  <PropertyGroup>\r\n    <Configuration Condition=\" \'$(Confi" +
                    "guration)\' == \'\' \">Debug</Configuration>\r\n    <Platform Condition=\" \'$(Platform)" +
                    "\' == \'\' \">AnyCPU</Platform>\r\n    <ProjectGuid>{DA1B7904-0DDC-45A0-875F-33BBA2236" +
                    "C44}</ProjectGuid>\r\n    <OutputType>Exe</OutputType>\r\n    <AppDesignerFolder>Pro" +
                    "perties</AppDesignerFolder>\r\n    <RootNamespace>PSAttack</RootNamespace>\r\n    <A" +
                    "ssemblyName>PSAttack</AssemblyName>\r\n    <TargetFrameworkVersion>v3.5</TargetFra" +
                    "meworkVersion>\r\n    <FileAlignment>512</FileAlignment>\r\n    <AutoGenerateBinding" +
                    "Redirects>true</AutoGenerateBindingRedirects>\r\n    <TargetFrameworkProfile>\r\n   " +
                    " </TargetFrameworkProfile>\r\n  </PropertyGroup>\r\n  <PropertyGroup Condition=\" \'$(" +
                    "Configuration)|$(Platform)\' == \'Debug|AnyCPU\' \">\r\n    <PlatformTarget>x64</Platf" +
                    "ormTarget>\r\n    <DebugSymbols>true</DebugSymbols>\r\n    <DebugType>full</DebugTyp" +
                    "e>\r\n    <Optimize>false</Optimize>\r\n    <OutputPath>bin\\Debug\\</OutputPath>\r\n   " +
                    " <DefineConstants>DEBUG;TRACE</DefineConstants>\r\n    <ErrorReport>prompt</ErrorR" +
                    "eport>\r\n    <WarningLevel>4</WarningLevel>\r\n    <Prefer32Bit>false</Prefer32Bit>" +
                    "\r\n  </PropertyGroup>\r\n  <PropertyGroup Condition=\" \'$(Configuration)|$(Platform)" +
                    "\' == \'Release|AnyCPU\' \">\r\n    <PlatformTarget>AnyCPU</PlatformTarget>\r\n    <Debu" +
                    "gType>pdbonly</DebugType>\r\n    <Optimize>true</Optimize>\r\n    <OutputPath>bin\\Re" +
                    "lease\\</OutputPath>\r\n    <DefineConstants>TRACE</DefineConstants>\r\n    <ErrorRep" +
                    "ort>prompt</ErrorReport>\r\n    <WarningLevel>4</WarningLevel>\r\n    <Prefer32Bit>f" +
                    "alse</Prefer32Bit>\r\n  </PropertyGroup>\r\n  <PropertyGroup Condition=\"\'$(Configura" +
                    "tion)|$(Platform)\' == \'Debug|x64\'\">\r\n    <DebugSymbols>true</DebugSymbols>\r\n    " +
                    "<OutputPath>bin\\x64\\Debug\\</OutputPath>\r\n    <DefineConstants>DEBUG;TRACE</Defin" +
                    "eConstants>\r\n    <DebugType>full</DebugType>\r\n    <PlatformTarget>x64</PlatformT" +
                    "arget>\r\n    <ErrorReport>prompt</ErrorReport>\r\n    <CodeAnalysisRuleSet>MinimumR" +
                    "ecommendedRules.ruleset</CodeAnalysisRuleSet>\r\n    <Prefer32Bit>false</Prefer32B" +
                    "it>\r\n  </PropertyGroup>\r\n  <PropertyGroup Condition=\"\'$(Configuration)|$(Platfor" +
                    "m)\' == \'Release|x64\'\">\r\n    <OutputPath>bin\\x64\\Release\\</OutputPath>\r\n    <Defi" +
                    "neConstants>TRACE</DefineConstants>\r\n    <Optimize>true</Optimize>\r\n    <DebugTy" +
                    "pe>pdbonly</DebugType>\r\n    <PlatformTarget>x64</PlatformTarget>\r\n    <ErrorRepo" +
                    "rt>prompt</ErrorReport>\r\n    <CodeAnalysisRuleSet>MinimumRecommendedRules.rulese" +
                    "t</CodeAnalysisRuleSet>\r\n    <Prefer32Bit>true</Prefer32Bit>\r\n  </PropertyGroup>" +
                    "\r\n  <PropertyGroup>\r\n    <StartupObject />\r\n  </PropertyGroup>\r\n  <PropertyGroup" +
                    " />\r\n  <PropertyGroup />\r\n  <ItemGroup>\r\n    <Reference Include=\"System\" />\r\n   " +
                    " <Reference Include=\"System.Core\" />\r\n    <Reference Include=\"System.Management\"" +
                    " />\r\n    <Reference Include=\"System.Management.Automation\" />\r\n    <Reference In" +
                    "clude=\"System.Xml.Linq\" />\r\n    <Reference Include=\"System.Data.DataSetExtension" +
                    "s\" />\r\n    <Reference Include=\"System.Data\" />\r\n    <Reference Include=\"System.X" +
                    "ml\" />\r\n  </ItemGroup>\r\n  <ItemGroup>\r\n    <Compile Include=\"PSAttackProcessing\\" +
                    "TabExpansion.cs\" />\r\n    <Compile Include=\"PSAttackShell\\PSColors.cs\" />\r\n    <C" +
                    "ompile Include=\"Utils\\Display.cs\" />\r\n    <Compile Include=\"PSAttackProcessing\\A" +
                    "ttackState.cs\" />\r\n    <Compile Include=\"Utils\\CryptoUtils.cs\" />\r\n    <Compile " +
                    "Include=\"PSAttackProcessing\\Processing.cs\" />\r\n    <Compile Include=\"Program.cs\"" +
                    " />\r\n    <Compile Include=\"Properties\\AssemblyInfo.cs\" />\r\n    <Compile Include=" +
                    "\"PSAttackShell\\PSParameter.cs\" />\r\n    <Compile Include=\"PSAttackShell\\PSParamTy" +
                    "pe.cs\" />\r\n    <Compile Include=\"PSAttackShell\\PSAttackHost.cs\" />\r\n    <Compile" +
                    " Include=\"PSAttackShell\\PSAttackHostRawUserInterface.cs\" />\r\n    <Compile Includ" +
                    "e=\"PSAttackShell\\PSAttackHostUserInterface.cs\" />\r\n    <Compile Include=\"Strings" +
                    ".cs\" />\r\n    <Compile Include=\"Utils\\PSAUtils.cs\" />\r\n  </ItemGroup>\r\n  <ItemGro" +
                    "up>\r\n    <None Include=\"app.config\" />\r\n\t");
            
            #line 100 "C:\Users\jared\Documents\GitHub\PSAttackBuildTool\PSAttack\PSAttack\PSAttackCSProj.tt"
 foreach (string file in this.files ) {
	WriteLine("<EmbeddedResource Include=\"Modules\\{0}.ps1.enc\"/>", file);
	 } 
            
            #line default
            #line hidden
            this.Write(@"  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include=""Resources\attackDate.txt"" />
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include=""Resources\BuildDate.txt"" />
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include=""Modules\key.txt"" />
  </ItemGroup>
  <Import Project=""$(MSBuildToolsPath)\Microsoft.CSharp.targets"" />
  <PropertyGroup>
    <PreBuildEvent>powershell -command ""write-host (get-date -Format D) at (get-date -Format T)"" &gt; ""$(ProjectDir)\Resources\BuildDate.txt""</PreBuildEvent>
  </PropertyGroup>
  <!-- To modify your build process, add your task inside one of the targets below and uncomment it.
       Other similar extension points exist, see Microsoft.Common.targets.
  <Target Name=""BeforeBuild"">
  </Target>
  <Target Name=""AfterBuild"">
  </Target>
  -->
</Project>");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "C:\Users\jared\Documents\GitHub\PSAttackBuildTool\PSAttack\PSAttack\PSAttackCSProj.tt"

private global::System.Collections.Generic.List<string> _filesField;

/// <summary>
/// Access the files parameter of the template.
/// </summary>
private global::System.Collections.Generic.List<string> files
{
    get
    {
        return this._filesField;
    }
}


/// <summary>
/// Initialize the template
/// </summary>
public virtual void Initialize()
{
    if ((this.Errors.HasErrors == false))
    {
bool filesValueAcquired = false;
if (this.Session.ContainsKey("files"))
{
    this._filesField = ((global::System.Collections.Generic.List<string>)(this.Session["files"]));
    filesValueAcquired = true;
}
if ((filesValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("files");
    if ((data != null))
    {
        this._filesField = ((global::System.Collections.Generic.List<string>)(data));
    }
}


    }
}


        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public class PSAttackCSProjBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
