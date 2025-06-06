﻿// <copyright file="GacCommandTests.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

using System.IO;
using System.Runtime.Versioning;
using FluentAssertions;
using Xunit;

namespace Datadog.Trace.Tools.Runner.IntegrationTests;

#if NET5_0_OR_GREATER
[SupportedOSPlatform("windows")]
#endif
[Collection(nameof(ConsoleTestsCollection))]
public class GacCommandTests
{
    [SkippableTheory]
    [Trait("RunOnWindows", "True")]
    [InlineData("DummyAssembly", false)]
    [InlineData("mscorlib", true)]
    public void GacGetTest(string assemblyName, bool expectedToBeFound)
    {
        Skip.IfNot(FrameworkDescription.Instance.IsWindows());

        var commandLine = $"gac get {assemblyName}";

        using var console = ConsoleHelper.Redirect();

        var result = Program.Main(commandLine.Split(' '));

        if (expectedToBeFound)
        {
            result.Should().Be(0);
            console.Output.Should().Contain("Assembly Found!");
            console.Output.Should().Contain("FullName=mscorlib, Version=");
        }
        else
        {
            result.Should().NotBe(0);
            console.Output.Should().Contain($"Error getting '{assemblyName}' from the GAC");
        }
    }

    [SkippableFact]
    [Trait("RunOnWindows", "True")]
    public void GacCompleteTest()
    {
        Skip.IfNot(FrameworkDescription.Instance.IsWindows());

        // We skip the test if we don't have permissions
        Skip.IfNot(Gac.AdministratorHelper.IsElevated);

        const string DummyAssemblyName = "DummyLibrary";
        var rootFolder = Path.GetDirectoryName(typeof(GacCommandTests).Assembly.Location)!;
        var assemblyPathV1 = Path.GetFullPath(Path.Combine(rootFolder, "V1", $"{DummyAssemblyName}.dll"));

        // GET
        using (var consoleGet = ConsoleHelper.Redirect())
        {
            var result = Program.Main($"gac get {DummyAssemblyName}".Split(' '));

            // it shouldn't be in the gac
            result.Should().NotBe(0);
            consoleGet.Output.Should().Contain($"Error getting '{DummyAssemblyName}' from the GAC");
        }

        // INSTALL
        using (var consoleInstall = ConsoleHelper.Redirect())
        {
            var result = Program.Main($"gac install {assemblyPathV1}".Split(' '));

            // should be successful
            result.Should().Be(0);
        }

        // GET
        using (var consoleGet2 = ConsoleHelper.Redirect())
        {
            var result = Program.Main($"gac get {DummyAssemblyName}".Split(' '));

            // should be in the gac
            result.Should().Be(0);
            consoleGet2.Output.Should().Contain("Assembly Found!");
        }

        // UNINSTALL
        using (var consoleUninstall = ConsoleHelper.Redirect())
        {
            var result = Program.Main($"gac uninstall {DummyAssemblyName}".Split(' '));

            // should be successful
            result.Should().Be(0);
        }

        // GET
        using (var consoleGet3 = ConsoleHelper.Redirect())
        {
            var result = Program.Main($"gac get {DummyAssemblyName}".Split(' '));

            // it shouldn't be in the gac
            result.Should().NotBe(0);
            consoleGet3.Output.Should().Contain($"Error getting '{DummyAssemblyName}' from the GAC");
        }
    }

    [SkippableFact]
    [Trait("RunOnWindows", "True")]
    public void GacWithMultipleVersions()
    {
        Skip.IfNot(FrameworkDescription.Instance.IsWindows());

        // We skip the test if we don't have permissions
        Skip.IfNot(Gac.AdministratorHelper.IsElevated);

        const string DummyAssemblyName = "DummyLibrary";
        var rootFolder = Path.GetDirectoryName(typeof(GacCommandTests).Assembly.Location)!;
        var assemblyPathV1 = Path.GetFullPath(Path.Combine(rootFolder, "V1", $"{DummyAssemblyName}.dll"));
        var assemblyPathV2 = Path.GetFullPath(Path.Combine(rootFolder, "V2", $"{DummyAssemblyName}.dll"));

        // GET
        using (var consoleGet = ConsoleHelper.Redirect())
        {
            var result = Program.Main($"gac get {DummyAssemblyName}".Split(' '));

            // it shouldn't be in the gac
            result.Should().NotBe(0);
            consoleGet.Output.Should().Contain($"Error getting '{DummyAssemblyName}' from the GAC");
        }

        // INSTALL

        // install the first one
        using (var consoleInstall = ConsoleHelper.Redirect())
        {
            var result = Program.Main($"gac install {assemblyPathV1}".Split(' '));

            // should be successful
            result.Should().Be(0);
        }

        // install the second one
        using (var consoleInstall = ConsoleHelper.Redirect())
        {
            var result = Program.Main($"gac install {assemblyPathV2}".Split(' '));

            // should be successful
            result.Should().Be(0);
        }

        // GET
        using (var consoleGet2 = ConsoleHelper.Redirect())
        {
            var result = Program.Main($"gac get {DummyAssemblyName}".Split(' '));

            // should be in the gac
            result.Should().Be(0);
            consoleGet2.Output.Should().Contain("Assembly Found!");

            // Check installation of version 1
            consoleGet2.Output.Should().Contain($"- FullName={DummyAssemblyName}, Version=1.0.0.0, Culture=neutral, PublicKeyToken=fb8e173370c0fc9d");

            // Check installation of version 2
            consoleGet2.Output.Should().Contain($"- FullName={DummyAssemblyName}, Version=2.0.0.0, Culture=neutral, PublicKeyToken=fb8e173370c0fc9d");
        }

        // UNINSTALL
        using (var consoleUninstall = ConsoleHelper.Redirect())
        {
            var result = Program.Main($"gac uninstall {DummyAssemblyName}".Split(' '));

            // should be successful
            result.Should().Be(0);
        }

        // GET
        using (var consoleGet3 = ConsoleHelper.Redirect())
        {
            var result = Program.Main($"gac get {DummyAssemblyName}".Split(' '));

            // it shouldn't be in the gac
            result.Should().NotBe(0);
            consoleGet3.Output.Should().Contain($"Error getting '{DummyAssemblyName}' from the GAC");
        }
    }
}
