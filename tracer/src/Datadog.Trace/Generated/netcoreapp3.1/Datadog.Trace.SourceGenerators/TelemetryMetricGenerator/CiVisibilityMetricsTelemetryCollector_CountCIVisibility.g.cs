﻿// <copyright company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>
// <auto-generated/>

#nullable enable

using System.Threading;

namespace Datadog.Trace.Telemetry;
internal partial class CiVisibilityMetricsTelemetryCollector
{
    private const int CountCIVisibilityLength = 343;

    /// <summary>
    /// Creates the buffer for the <see cref="Datadog.Trace.Telemetry.Metrics.CountCIVisibility" /> values.
    /// </summary>
    private static AggregatedMetric[] GetCountCIVisibilityBuffer()
        => new AggregatedMetric[]
        {
            // event_created, index = 0
            new(new[] { "test_framework:xunit", "event_type:test" }),
            new(new[] { "test_framework:xunit", "event_type:test", "is_benchmark" }),
            new(new[] { "test_framework:xunit", "event_type:suite" }),
            new(new[] { "test_framework:xunit", "event_type:module" }),
            new(new[] { "test_framework:xunit", "event_type:session" }),
            new(new[] { "test_framework:xunit", "event_type:session", "is_unsupported_ci" }),
            new(new[] { "test_framework:xunit", "event_type:session", "has_codeowner", "is_unsupported_ci" }),
            new(new[] { "test_framework:xunit", "event_type:session", "has_codeowner" }),
            new(new[] { "test_framework:nunit", "event_type:test" }),
            new(new[] { "test_framework:nunit", "event_type:test", "is_benchmark" }),
            new(new[] { "test_framework:nunit", "event_type:suite" }),
            new(new[] { "test_framework:nunit", "event_type:module" }),
            new(new[] { "test_framework:nunit", "event_type:session" }),
            new(new[] { "test_framework:nunit", "event_type:session", "is_unsupported_ci" }),
            new(new[] { "test_framework:nunit", "event_type:session", "has_codeowner", "is_unsupported_ci" }),
            new(new[] { "test_framework:nunit", "event_type:session", "has_codeowner" }),
            new(new[] { "test_framework:mstest", "event_type:test" }),
            new(new[] { "test_framework:mstest", "event_type:test", "is_benchmark" }),
            new(new[] { "test_framework:mstest", "event_type:suite" }),
            new(new[] { "test_framework:mstest", "event_type:module" }),
            new(new[] { "test_framework:mstest", "event_type:session" }),
            new(new[] { "test_framework:mstest", "event_type:session", "is_unsupported_ci" }),
            new(new[] { "test_framework:mstest", "event_type:session", "has_codeowner", "is_unsupported_ci" }),
            new(new[] { "test_framework:mstest", "event_type:session", "has_codeowner" }),
            new(new[] { "test_framework:benchmarkdotnet", "event_type:test" }),
            new(new[] { "test_framework:benchmarkdotnet", "event_type:test", "is_benchmark" }),
            new(new[] { "test_framework:benchmarkdotnet", "event_type:suite" }),
            new(new[] { "test_framework:benchmarkdotnet", "event_type:module" }),
            new(new[] { "test_framework:benchmarkdotnet", "event_type:session" }),
            new(new[] { "test_framework:benchmarkdotnet", "event_type:session", "is_unsupported_ci" }),
            new(new[] { "test_framework:benchmarkdotnet", "event_type:session", "has_codeowner", "is_unsupported_ci" }),
            new(new[] { "test_framework:benchmarkdotnet", "event_type:session", "has_codeowner" }),
            new(new[] { "test_framework:unknown", "event_type:test" }),
            new(new[] { "test_framework:unknown", "event_type:test", "is_benchmark" }),
            new(new[] { "test_framework:unknown", "event_type:suite" }),
            new(new[] { "test_framework:unknown", "event_type:module" }),
            new(new[] { "test_framework:unknown", "event_type:session" }),
            new(new[] { "test_framework:unknown", "event_type:session", "is_unsupported_ci" }),
            new(new[] { "test_framework:unknown", "event_type:session", "has_codeowner", "is_unsupported_ci" }),
            new(new[] { "test_framework:unknown", "event_type:session", "has_codeowner" }),
            // event_finished, index = 40
            new(new[] { "test_framework:xunit", "event_type:test" }),
            new(new[] { "test_framework:xunit", "event_type:test", "is_benchmark" }),
            new(new[] { "test_framework:xunit", "event_type:suite" }),
            new(new[] { "test_framework:xunit", "event_type:module" }),
            new(new[] { "test_framework:xunit", "event_type:session" }),
            new(new[] { "test_framework:xunit", "event_type:session", "is_unsupported_ci" }),
            new(new[] { "test_framework:xunit", "event_type:session", "has_codeowner", "is_unsupported_ci" }),
            new(new[] { "test_framework:xunit", "event_type:session", "has_codeowner" }),
            new(new[] { "test_framework:xunit", "event_type:test", "is_new:true" }),
            new(new[] { "test_framework:xunit", "event_type:test", "is_new:true", "early_flake_detection_abort_reason:slow" }),
            new(new[] { "test_framework:xunit", "event_type:test", "browser_driver:selenium" }),
            new(new[] { "test_framework:xunit", "event_type:test", "is_new:true", "browser_driver:selenium" }),
            new(new[] { "test_framework:xunit", "event_type:test", "is_new:true", "early_flake_detection_abort_reason:slow", "browser_driver:selenium" }),
            new(new[] { "test_framework:xunit", "event_type:test", "browser_driver:selenium", "is_rum:true" }),
            new(new[] { "test_framework:xunit", "event_type:test", "is_new:true", "browser_driver:selenium", "is_rum:true" }),
            new(new[] { "test_framework:xunit", "event_type:test", "is_new:true", "early_flake_detection_abort_reason:slow", "browser_driver:selenium", "is_rum:true" }),
            new(new[] { "test_framework:nunit", "event_type:test" }),
            new(new[] { "test_framework:nunit", "event_type:test", "is_benchmark" }),
            new(new[] { "test_framework:nunit", "event_type:suite" }),
            new(new[] { "test_framework:nunit", "event_type:module" }),
            new(new[] { "test_framework:nunit", "event_type:session" }),
            new(new[] { "test_framework:nunit", "event_type:session", "is_unsupported_ci" }),
            new(new[] { "test_framework:nunit", "event_type:session", "has_codeowner", "is_unsupported_ci" }),
            new(new[] { "test_framework:nunit", "event_type:session", "has_codeowner" }),
            new(new[] { "test_framework:nunit", "event_type:test", "is_new:true" }),
            new(new[] { "test_framework:nunit", "event_type:test", "is_new:true", "early_flake_detection_abort_reason:slow" }),
            new(new[] { "test_framework:nunit", "event_type:test", "browser_driver:selenium" }),
            new(new[] { "test_framework:nunit", "event_type:test", "is_new:true", "browser_driver:selenium" }),
            new(new[] { "test_framework:nunit", "event_type:test", "is_new:true", "early_flake_detection_abort_reason:slow", "browser_driver:selenium" }),
            new(new[] { "test_framework:nunit", "event_type:test", "browser_driver:selenium", "is_rum:true" }),
            new(new[] { "test_framework:nunit", "event_type:test", "is_new:true", "browser_driver:selenium", "is_rum:true" }),
            new(new[] { "test_framework:nunit", "event_type:test", "is_new:true", "early_flake_detection_abort_reason:slow", "browser_driver:selenium", "is_rum:true" }),
            new(new[] { "test_framework:mstest", "event_type:test" }),
            new(new[] { "test_framework:mstest", "event_type:test", "is_benchmark" }),
            new(new[] { "test_framework:mstest", "event_type:suite" }),
            new(new[] { "test_framework:mstest", "event_type:module" }),
            new(new[] { "test_framework:mstest", "event_type:session" }),
            new(new[] { "test_framework:mstest", "event_type:session", "is_unsupported_ci" }),
            new(new[] { "test_framework:mstest", "event_type:session", "has_codeowner", "is_unsupported_ci" }),
            new(new[] { "test_framework:mstest", "event_type:session", "has_codeowner" }),
            new(new[] { "test_framework:mstest", "event_type:test", "is_new:true" }),
            new(new[] { "test_framework:mstest", "event_type:test", "is_new:true", "early_flake_detection_abort_reason:slow" }),
            new(new[] { "test_framework:mstest", "event_type:test", "browser_driver:selenium" }),
            new(new[] { "test_framework:mstest", "event_type:test", "is_new:true", "browser_driver:selenium" }),
            new(new[] { "test_framework:mstest", "event_type:test", "is_new:true", "early_flake_detection_abort_reason:slow", "browser_driver:selenium" }),
            new(new[] { "test_framework:mstest", "event_type:test", "browser_driver:selenium", "is_rum:true" }),
            new(new[] { "test_framework:mstest", "event_type:test", "is_new:true", "browser_driver:selenium", "is_rum:true" }),
            new(new[] { "test_framework:mstest", "event_type:test", "is_new:true", "early_flake_detection_abort_reason:slow", "browser_driver:selenium", "is_rum:true" }),
            new(new[] { "test_framework:benchmarkdotnet", "event_type:test" }),
            new(new[] { "test_framework:benchmarkdotnet", "event_type:test", "is_benchmark" }),
            new(new[] { "test_framework:benchmarkdotnet", "event_type:suite" }),
            new(new[] { "test_framework:benchmarkdotnet", "event_type:module" }),
            new(new[] { "test_framework:benchmarkdotnet", "event_type:session" }),
            new(new[] { "test_framework:benchmarkdotnet", "event_type:session", "is_unsupported_ci" }),
            new(new[] { "test_framework:benchmarkdotnet", "event_type:session", "has_codeowner", "is_unsupported_ci" }),
            new(new[] { "test_framework:benchmarkdotnet", "event_type:session", "has_codeowner" }),
            new(new[] { "test_framework:benchmarkdotnet", "event_type:test", "is_new:true" }),
            new(new[] { "test_framework:benchmarkdotnet", "event_type:test", "is_new:true", "early_flake_detection_abort_reason:slow" }),
            new(new[] { "test_framework:benchmarkdotnet", "event_type:test", "browser_driver:selenium" }),
            new(new[] { "test_framework:benchmarkdotnet", "event_type:test", "is_new:true", "browser_driver:selenium" }),
            new(new[] { "test_framework:benchmarkdotnet", "event_type:test", "is_new:true", "early_flake_detection_abort_reason:slow", "browser_driver:selenium" }),
            new(new[] { "test_framework:benchmarkdotnet", "event_type:test", "browser_driver:selenium", "is_rum:true" }),
            new(new[] { "test_framework:benchmarkdotnet", "event_type:test", "is_new:true", "browser_driver:selenium", "is_rum:true" }),
            new(new[] { "test_framework:benchmarkdotnet", "event_type:test", "is_new:true", "early_flake_detection_abort_reason:slow", "browser_driver:selenium", "is_rum:true" }),
            new(new[] { "test_framework:unknown", "event_type:test" }),
            new(new[] { "test_framework:unknown", "event_type:test", "is_benchmark" }),
            new(new[] { "test_framework:unknown", "event_type:suite" }),
            new(new[] { "test_framework:unknown", "event_type:module" }),
            new(new[] { "test_framework:unknown", "event_type:session" }),
            new(new[] { "test_framework:unknown", "event_type:session", "is_unsupported_ci" }),
            new(new[] { "test_framework:unknown", "event_type:session", "has_codeowner", "is_unsupported_ci" }),
            new(new[] { "test_framework:unknown", "event_type:session", "has_codeowner" }),
            new(new[] { "test_framework:unknown", "event_type:test", "is_new:true" }),
            new(new[] { "test_framework:unknown", "event_type:test", "is_new:true", "early_flake_detection_abort_reason:slow" }),
            new(new[] { "test_framework:unknown", "event_type:test", "browser_driver:selenium" }),
            new(new[] { "test_framework:unknown", "event_type:test", "is_new:true", "browser_driver:selenium" }),
            new(new[] { "test_framework:unknown", "event_type:test", "is_new:true", "early_flake_detection_abort_reason:slow", "browser_driver:selenium" }),
            new(new[] { "test_framework:unknown", "event_type:test", "browser_driver:selenium", "is_rum:true" }),
            new(new[] { "test_framework:unknown", "event_type:test", "is_new:true", "browser_driver:selenium", "is_rum:true" }),
            new(new[] { "test_framework:unknown", "event_type:test", "is_new:true", "early_flake_detection_abort_reason:slow", "browser_driver:selenium", "is_rum:true" }),
            // code_coverage_started, index = 120
            new(new[] { "test_framework:xunit", "library:custom" }),
            new(new[] { "test_framework:xunit", "library:unknown" }),
            new(new[] { "test_framework:nunit", "library:custom" }),
            new(new[] { "test_framework:nunit", "library:unknown" }),
            new(new[] { "test_framework:mstest", "library:custom" }),
            new(new[] { "test_framework:mstest", "library:unknown" }),
            new(new[] { "test_framework:benchmarkdotnet", "library:custom" }),
            new(new[] { "test_framework:benchmarkdotnet", "library:unknown" }),
            new(new[] { "test_framework:unknown", "library:custom" }),
            new(new[] { "test_framework:unknown", "library:unknown" }),
            // code_coverage_finished, index = 130
            new(new[] { "test_framework:xunit", "library:custom" }),
            new(new[] { "test_framework:xunit", "library:unknown" }),
            new(new[] { "test_framework:nunit", "library:custom" }),
            new(new[] { "test_framework:nunit", "library:unknown" }),
            new(new[] { "test_framework:mstest", "library:custom" }),
            new(new[] { "test_framework:mstest", "library:unknown" }),
            new(new[] { "test_framework:benchmarkdotnet", "library:custom" }),
            new(new[] { "test_framework:benchmarkdotnet", "library:unknown" }),
            new(new[] { "test_framework:unknown", "library:custom" }),
            new(new[] { "test_framework:unknown", "library:unknown" }),
            // manual_api_events, index = 140
            new(new[] { "event_type:test" }),
            new(new[] { "event_type:suite" }),
            new(new[] { "event_type:module" }),
            new(new[] { "event_type:session" }),
            // events_enqueued_for_serialization, index = 144
            new(null),
            // endpoint_payload.requests, index = 145
            new(new[] { "endpoint:test_cycle" }),
            new(new[] { "endpoint:test_cycle", "rq_compressed:true" }),
            new(new[] { "endpoint:code_coverage" }),
            new(new[] { "endpoint:code_coverage", "rq_compressed:true" }),
            // endpoint_payload.requests_errors, index = 149
            new(new[] { "endpoint:test_cycle", "error_type:timeout" }),
            new(new[] { "endpoint:test_cycle", "error_type:network" }),
            new(new[] { "endpoint:test_cycle", "error_type:status_code" }),
            new(new[] { "endpoint:test_cycle", "error_type:status_code_4xx_response" }),
            new(new[] { "endpoint:test_cycle", "error_type:status_code_5xx_response" }),
            new(new[] { "endpoint:test_cycle", "error_type:status_code_4xx_response", "status_code:400" }),
            new(new[] { "endpoint:test_cycle", "error_type:status_code_4xx_response", "status_code:401" }),
            new(new[] { "endpoint:test_cycle", "error_type:status_code_4xx_response", "status_code:403" }),
            new(new[] { "endpoint:test_cycle", "error_type:status_code_4xx_response", "status_code:404" }),
            new(new[] { "endpoint:test_cycle", "error_type:status_code_4xx_response", "status_code:408" }),
            new(new[] { "endpoint:test_cycle", "error_type:status_code_4xx_response", "status_code:429" }),
            new(new[] { "endpoint:code_coverage", "error_type:timeout" }),
            new(new[] { "endpoint:code_coverage", "error_type:network" }),
            new(new[] { "endpoint:code_coverage", "error_type:status_code" }),
            new(new[] { "endpoint:code_coverage", "error_type:status_code_4xx_response" }),
            new(new[] { "endpoint:code_coverage", "error_type:status_code_5xx_response" }),
            new(new[] { "endpoint:code_coverage", "error_type:status_code_4xx_response", "status_code:400" }),
            new(new[] { "endpoint:code_coverage", "error_type:status_code_4xx_response", "status_code:401" }),
            new(new[] { "endpoint:code_coverage", "error_type:status_code_4xx_response", "status_code:403" }),
            new(new[] { "endpoint:code_coverage", "error_type:status_code_4xx_response", "status_code:404" }),
            new(new[] { "endpoint:code_coverage", "error_type:status_code_4xx_response", "status_code:408" }),
            new(new[] { "endpoint:code_coverage", "error_type:status_code_4xx_response", "status_code:429" }),
            // endpoint_payload.dropped, index = 171
            new(new[] { "endpoint:test_cycle" }),
            new(new[] { "endpoint:code_coverage" }),
            // git.command, index = 173
            new(new[] { "command:get_repository" }),
            new(new[] { "command:get_branch" }),
            new(new[] { "command:get_remote" }),
            new(new[] { "command:get_head" }),
            new(new[] { "command:check_shallow" }),
            new(new[] { "command:unshallow" }),
            new(new[] { "command:get_local_commits" }),
            new(new[] { "command:get_objects" }),
            new(new[] { "command:pack_objects" }),
            // git.command_errors, index = 182
            new(new[] { "command:get_repository", "exit_code:missing" }),
            new(new[] { "command:get_repository", "exit_code:unknown" }),
            new(new[] { "command:get_repository", "exit_code:-1" }),
            new(new[] { "command:get_repository", "exit_code:1" }),
            new(new[] { "command:get_repository", "exit_code:2" }),
            new(new[] { "command:get_repository", "exit_code:127" }),
            new(new[] { "command:get_repository", "exit_code:128" }),
            new(new[] { "command:get_repository", "exit_code:129" }),
            new(new[] { "command:get_branch", "exit_code:missing" }),
            new(new[] { "command:get_branch", "exit_code:unknown" }),
            new(new[] { "command:get_branch", "exit_code:-1" }),
            new(new[] { "command:get_branch", "exit_code:1" }),
            new(new[] { "command:get_branch", "exit_code:2" }),
            new(new[] { "command:get_branch", "exit_code:127" }),
            new(new[] { "command:get_branch", "exit_code:128" }),
            new(new[] { "command:get_branch", "exit_code:129" }),
            new(new[] { "command:get_remote", "exit_code:missing" }),
            new(new[] { "command:get_remote", "exit_code:unknown" }),
            new(new[] { "command:get_remote", "exit_code:-1" }),
            new(new[] { "command:get_remote", "exit_code:1" }),
            new(new[] { "command:get_remote", "exit_code:2" }),
            new(new[] { "command:get_remote", "exit_code:127" }),
            new(new[] { "command:get_remote", "exit_code:128" }),
            new(new[] { "command:get_remote", "exit_code:129" }),
            new(new[] { "command:get_head", "exit_code:missing" }),
            new(new[] { "command:get_head", "exit_code:unknown" }),
            new(new[] { "command:get_head", "exit_code:-1" }),
            new(new[] { "command:get_head", "exit_code:1" }),
            new(new[] { "command:get_head", "exit_code:2" }),
            new(new[] { "command:get_head", "exit_code:127" }),
            new(new[] { "command:get_head", "exit_code:128" }),
            new(new[] { "command:get_head", "exit_code:129" }),
            new(new[] { "command:check_shallow", "exit_code:missing" }),
            new(new[] { "command:check_shallow", "exit_code:unknown" }),
            new(new[] { "command:check_shallow", "exit_code:-1" }),
            new(new[] { "command:check_shallow", "exit_code:1" }),
            new(new[] { "command:check_shallow", "exit_code:2" }),
            new(new[] { "command:check_shallow", "exit_code:127" }),
            new(new[] { "command:check_shallow", "exit_code:128" }),
            new(new[] { "command:check_shallow", "exit_code:129" }),
            new(new[] { "command:unshallow", "exit_code:missing" }),
            new(new[] { "command:unshallow", "exit_code:unknown" }),
            new(new[] { "command:unshallow", "exit_code:-1" }),
            new(new[] { "command:unshallow", "exit_code:1" }),
            new(new[] { "command:unshallow", "exit_code:2" }),
            new(new[] { "command:unshallow", "exit_code:127" }),
            new(new[] { "command:unshallow", "exit_code:128" }),
            new(new[] { "command:unshallow", "exit_code:129" }),
            new(new[] { "command:get_local_commits", "exit_code:missing" }),
            new(new[] { "command:get_local_commits", "exit_code:unknown" }),
            new(new[] { "command:get_local_commits", "exit_code:-1" }),
            new(new[] { "command:get_local_commits", "exit_code:1" }),
            new(new[] { "command:get_local_commits", "exit_code:2" }),
            new(new[] { "command:get_local_commits", "exit_code:127" }),
            new(new[] { "command:get_local_commits", "exit_code:128" }),
            new(new[] { "command:get_local_commits", "exit_code:129" }),
            new(new[] { "command:get_objects", "exit_code:missing" }),
            new(new[] { "command:get_objects", "exit_code:unknown" }),
            new(new[] { "command:get_objects", "exit_code:-1" }),
            new(new[] { "command:get_objects", "exit_code:1" }),
            new(new[] { "command:get_objects", "exit_code:2" }),
            new(new[] { "command:get_objects", "exit_code:127" }),
            new(new[] { "command:get_objects", "exit_code:128" }),
            new(new[] { "command:get_objects", "exit_code:129" }),
            new(new[] { "command:pack_objects", "exit_code:missing" }),
            new(new[] { "command:pack_objects", "exit_code:unknown" }),
            new(new[] { "command:pack_objects", "exit_code:-1" }),
            new(new[] { "command:pack_objects", "exit_code:1" }),
            new(new[] { "command:pack_objects", "exit_code:2" }),
            new(new[] { "command:pack_objects", "exit_code:127" }),
            new(new[] { "command:pack_objects", "exit_code:128" }),
            new(new[] { "command:pack_objects", "exit_code:129" }),
            // git_requests.search_commits, index = 254
            new(null),
            new(new[] { "rq_compressed:true" }),
            // git_requests.search_commits_errors, index = 256
            new(new[] { "error_type:timeout" }),
            new(new[] { "error_type:network" }),
            new(new[] { "error_type:status_code" }),
            new(new[] { "error_type:status_code_4xx_response" }),
            new(new[] { "error_type:status_code_5xx_response" }),
            new(new[] { "error_type:status_code_4xx_response", "status_code:400" }),
            new(new[] { "error_type:status_code_4xx_response", "status_code:401" }),
            new(new[] { "error_type:status_code_4xx_response", "status_code:403" }),
            new(new[] { "error_type:status_code_4xx_response", "status_code:404" }),
            new(new[] { "error_type:status_code_4xx_response", "status_code:408" }),
            new(new[] { "error_type:status_code_4xx_response", "status_code:429" }),
            // git_requests.objects_pack, index = 267
            new(null),
            new(new[] { "rq_compressed:true" }),
            // git_requests.objects_pack_errors, index = 269
            new(new[] { "error_type:timeout" }),
            new(new[] { "error_type:network" }),
            new(new[] { "error_type:status_code" }),
            new(new[] { "error_type:status_code_4xx_response" }),
            new(new[] { "error_type:status_code_5xx_response" }),
            new(new[] { "error_type:status_code_4xx_response", "status_code:400" }),
            new(new[] { "error_type:status_code_4xx_response", "status_code:401" }),
            new(new[] { "error_type:status_code_4xx_response", "status_code:403" }),
            new(new[] { "error_type:status_code_4xx_response", "status_code:404" }),
            new(new[] { "error_type:status_code_4xx_response", "status_code:408" }),
            new(new[] { "error_type:status_code_4xx_response", "status_code:429" }),
            // git_requests.settings, index = 280
            new(null),
            new(new[] { "rq_compressed:true" }),
            // git_requests.settings_errors, index = 282
            new(new[] { "error_type:timeout" }),
            new(new[] { "error_type:network" }),
            new(new[] { "error_type:status_code" }),
            new(new[] { "error_type:status_code_4xx_response" }),
            new(new[] { "error_type:status_code_5xx_response" }),
            new(new[] { "error_type:status_code_4xx_response", "status_code:400" }),
            new(new[] { "error_type:status_code_4xx_response", "status_code:401" }),
            new(new[] { "error_type:status_code_4xx_response", "status_code:403" }),
            new(new[] { "error_type:status_code_4xx_response", "status_code:404" }),
            new(new[] { "error_type:status_code_4xx_response", "status_code:408" }),
            new(new[] { "error_type:status_code_4xx_response", "status_code:429" }),
            // git_requests.settings_response, index = 293
            new(null),
            new(new[] { "coverage_enabled" }),
            new(new[] { "itrskip_enabled" }),
            new(new[] { "coverage_enabled", "itrskip_enabled" }),
            new(new[] { "early_flake_detection_enabled:true" }),
            new(new[] { "coverage_enabled", "early_flake_detection_enabled:true" }),
            new(new[] { "itrskip_enabled", "early_flake_detection_enabled:true" }),
            new(new[] { "coverage_enabled", "itrskip_enabled", "early_flake_detection_enabled:true" }),
            // itr_skippable_tests.request, index = 301
            new(null),
            new(new[] { "rq_compressed:true" }),
            // itr_skippable_tests.request_errors, index = 303
            new(new[] { "error_type:timeout" }),
            new(new[] { "error_type:network" }),
            new(new[] { "error_type:status_code" }),
            new(new[] { "error_type:status_code_4xx_response" }),
            new(new[] { "error_type:status_code_5xx_response" }),
            new(new[] { "error_type:status_code_4xx_response", "status_code:400" }),
            new(new[] { "error_type:status_code_4xx_response", "status_code:401" }),
            new(new[] { "error_type:status_code_4xx_response", "status_code:403" }),
            new(new[] { "error_type:status_code_4xx_response", "status_code:404" }),
            new(new[] { "error_type:status_code_4xx_response", "status_code:408" }),
            new(new[] { "error_type:status_code_4xx_response", "status_code:429" }),
            // itr_skippable_tests.response_tests, index = 314
            new(null),
            // itr_skippable_tests.response_suites, index = 315
            new(null),
            // itr_skipped, index = 316
            new(new[] { "event_type:test" }),
            new(new[] { "event_type:suite" }),
            new(new[] { "event_type:module" }),
            new(new[] { "event_type:session" }),
            // itr_unskippable, index = 320
            new(new[] { "event_type:test" }),
            new(new[] { "event_type:suite" }),
            new(new[] { "event_type:module" }),
            new(new[] { "event_type:session" }),
            // itr_forced_run, index = 324
            new(new[] { "event_type:test" }),
            new(new[] { "event_type:suite" }),
            new(new[] { "event_type:module" }),
            new(new[] { "event_type:session" }),
            // code_coverage.is_empty, index = 328
            new(null),
            // code_coverage.errors, index = 329
            new(null),
            // early_flake_detection.request, index = 330
            new(null),
            new(new[] { "rq_compressed:true" }),
            // early_flake_detection.request_errors, index = 332
            new(new[] { "error_type:timeout" }),
            new(new[] { "error_type:network" }),
            new(new[] { "error_type:status_code" }),
            new(new[] { "error_type:status_code_4xx_response" }),
            new(new[] { "error_type:status_code_5xx_response" }),
            new(new[] { "error_type:status_code_4xx_response", "status_code:400" }),
            new(new[] { "error_type:status_code_4xx_response", "status_code:401" }),
            new(new[] { "error_type:status_code_4xx_response", "status_code:403" }),
            new(new[] { "error_type:status_code_4xx_response", "status_code:404" }),
            new(new[] { "error_type:status_code_4xx_response", "status_code:408" }),
            new(new[] { "error_type:status_code_4xx_response", "status_code:429" }),
        };

    /// <summary>
    /// Gets an array of metric counts, indexed by integer value of the <see cref="Datadog.Trace.Telemetry.Metrics.CountCIVisibility" />.
    /// Each value represents the number of unique entries in the buffer returned by <see cref="GetCountCIVisibilityBuffer()" />
    /// It is equal to the cardinality of the tag combinations (or 1 if there are no tags)
    /// </summary>
    private static int[] CountCIVisibilityEntryCounts { get; }
        = new int[]{ 40, 80, 10, 10, 4, 1, 4, 22, 2, 9, 72, 2, 11, 2, 11, 2, 11, 8, 2, 11, 1, 1, 4, 4, 4, 1, 1, 2, 11, };

    public void RecordCountCIVisibilityEventCreated(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityTestFramework tag1, Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityTestingEventTypeWithCodeOwnerAndSupportedCiAndBenchmark tag2, int increment = 1)
    {
        var index = 0 + ((int)tag1 * 8) + (int)tag2;
        Interlocked.Add(ref _buffer.CountCIVisibility[index], increment);
    }

    public void RecordCountCIVisibilityEventFinished(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityTestFramework tag1, Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityTestingEventTypeWithCodeOwnerAndSupportedCiAndBenchmarkAndEarlyFlakeDetectionAndRum tag2, int increment = 1)
    {
        var index = 40 + ((int)tag1 * 16) + (int)tag2;
        Interlocked.Add(ref _buffer.CountCIVisibility[index], increment);
    }

    public void RecordCountCIVisibilityCodeCoverageStarted(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityTestFramework tag1, Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityCoverageLibrary tag2, int increment = 1)
    {
        var index = 120 + ((int)tag1 * 2) + (int)tag2;
        Interlocked.Add(ref _buffer.CountCIVisibility[index], increment);
    }

    public void RecordCountCIVisibilityCodeCoverageFinished(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityTestFramework tag1, Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityCoverageLibrary tag2, int increment = 1)
    {
        var index = 130 + ((int)tag1 * 2) + (int)tag2;
        Interlocked.Add(ref _buffer.CountCIVisibility[index], increment);
    }

    public void RecordCountCIVisibilityManualApiEvent(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityTestingEventType tag, int increment = 1)
    {
        var index = 140 + (int)tag;
        Interlocked.Add(ref _buffer.CountCIVisibility[index], increment);
    }

    public void RecordCountCIVisibilityEventsEnqueueForSerialization(int increment = 1)
    {
        Interlocked.Add(ref _buffer.CountCIVisibility[144], increment);
    }

    public void RecordCountCIVisibilityEndpointPayloadRequests(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityEndpointAndCompression tag, int increment = 1)
    {
        var index = 145 + (int)tag;
        Interlocked.Add(ref _buffer.CountCIVisibility[index], increment);
    }

    public void RecordCountCIVisibilityEndpointPayloadRequestsErrors(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityEndpoints tag1, Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityErrorType tag2, int increment = 1)
    {
        var index = 149 + ((int)tag1 * 11) + (int)tag2;
        Interlocked.Add(ref _buffer.CountCIVisibility[index], increment);
    }

    public void RecordCountCIVisibilityEndpointPayloadDropped(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityEndpoints tag, int increment = 1)
    {
        var index = 171 + (int)tag;
        Interlocked.Add(ref _buffer.CountCIVisibility[index], increment);
    }

    public void RecordCountCIVisibilityGitCommand(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityCommands tag, int increment = 1)
    {
        var index = 173 + (int)tag;
        Interlocked.Add(ref _buffer.CountCIVisibility[index], increment);
    }

    public void RecordCountCIVisibilityGitCommandErrors(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityCommands tag1, Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityExitCodes tag2, int increment = 1)
    {
        var index = 182 + ((int)tag1 * 8) + (int)tag2;
        Interlocked.Add(ref _buffer.CountCIVisibility[index], increment);
    }

    public void RecordCountCIVisibilityGitRequestsSearchCommits(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityRequestCompressed tag, int increment = 1)
    {
        var index = 254 + (int)tag;
        Interlocked.Add(ref _buffer.CountCIVisibility[index], increment);
    }

    public void RecordCountCIVisibilityGitRequestsSearchCommitsErrors(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityErrorType tag, int increment = 1)
    {
        var index = 256 + (int)tag;
        Interlocked.Add(ref _buffer.CountCIVisibility[index], increment);
    }

    public void RecordCountCIVisibilityGitRequestsObjectsPack(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityRequestCompressed tag, int increment = 1)
    {
        var index = 267 + (int)tag;
        Interlocked.Add(ref _buffer.CountCIVisibility[index], increment);
    }

    public void RecordCountCIVisibilityGitRequestsObjectsPackErrors(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityErrorType tag, int increment = 1)
    {
        var index = 269 + (int)tag;
        Interlocked.Add(ref _buffer.CountCIVisibility[index], increment);
    }

    public void RecordCountCIVisibilityGitRequestsSettings(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityRequestCompressed tag, int increment = 1)
    {
        var index = 280 + (int)tag;
        Interlocked.Add(ref _buffer.CountCIVisibility[index], increment);
    }

    public void RecordCountCIVisibilityGitRequestsSettingsErrors(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityErrorType tag, int increment = 1)
    {
        var index = 282 + (int)tag;
        Interlocked.Add(ref _buffer.CountCIVisibility[index], increment);
    }

    public void RecordCountCIVisibilityGitRequestsSettingsResponse(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityITRSettingsResponse tag, int increment = 1)
    {
        var index = 293 + (int)tag;
        Interlocked.Add(ref _buffer.CountCIVisibility[index], increment);
    }

    public void RecordCountCIVisibilityITRSkippableTestsRequest(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityRequestCompressed tag, int increment = 1)
    {
        var index = 301 + (int)tag;
        Interlocked.Add(ref _buffer.CountCIVisibility[index], increment);
    }

    public void RecordCountCIVisibilityITRSkippableTestsRequestErrors(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityErrorType tag, int increment = 1)
    {
        var index = 303 + (int)tag;
        Interlocked.Add(ref _buffer.CountCIVisibility[index], increment);
    }

    public void RecordCountCIVisibilityITRSkippableTestsResponseTests(int increment = 1)
    {
        Interlocked.Add(ref _buffer.CountCIVisibility[314], increment);
    }

    public void RecordCountCIVisibilityITRSkippableTestsResponseSuites(int increment = 1)
    {
        Interlocked.Add(ref _buffer.CountCIVisibility[315], increment);
    }

    public void RecordCountCIVisibilityITRSkipped(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityTestingEventType tag, int increment = 1)
    {
        var index = 316 + (int)tag;
        Interlocked.Add(ref _buffer.CountCIVisibility[index], increment);
    }

    public void RecordCountCIVisibilityITRUnskippable(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityTestingEventType tag, int increment = 1)
    {
        var index = 320 + (int)tag;
        Interlocked.Add(ref _buffer.CountCIVisibility[index], increment);
    }

    public void RecordCountCIVisibilityITRForcedRun(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityTestingEventType tag, int increment = 1)
    {
        var index = 324 + (int)tag;
        Interlocked.Add(ref _buffer.CountCIVisibility[index], increment);
    }

    public void RecordCountCIVisibilityCodeCoverageIsEmpty(int increment = 1)
    {
        Interlocked.Add(ref _buffer.CountCIVisibility[328], increment);
    }

    public void RecordCountCIVisibilityCodeCoverageErrors(int increment = 1)
    {
        Interlocked.Add(ref _buffer.CountCIVisibility[329], increment);
    }

    public void RecordCountCIVisibilityEarlyFlakeDetectionRequest(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityRequestCompressed tag, int increment = 1)
    {
        var index = 330 + (int)tag;
        Interlocked.Add(ref _buffer.CountCIVisibility[index], increment);
    }

    public void RecordCountCIVisibilityEarlyFlakeDetectionRequestErrors(Datadog.Trace.Telemetry.Metrics.MetricTags.CIVisibilityErrorType tag, int increment = 1)
    {
        var index = 332 + (int)tag;
        Interlocked.Add(ref _buffer.CountCIVisibility[index], increment);
    }
}