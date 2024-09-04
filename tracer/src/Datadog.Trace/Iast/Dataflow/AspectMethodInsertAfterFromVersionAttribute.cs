// <copyright file="AspectMethodInsertAfterFromVersionAttribute.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

#nullable enable

namespace Datadog.Trace.Iast.Dataflow;

[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
internal class AspectMethodInsertAfterFromVersionAttribute : AspectMethodInsertAfterAttribute
{
    public AspectMethodInsertAfterFromVersionAttribute(string version, string targetMethod)
        : base(targetMethod)
    {
    }
}