﻿using DotNetLaunchDashboard.Models.Responses;

namespace DotNetLaunchDashboard.Builders.EndpointBuilders
{
    public class RawBuilder : TelemetryParametersBuilderBase<RawResponse>
    {
        protected override string Endpoint { get; set; } = "raw";

        public RawBuilder(string company) : base(company)
        {

        }
    }
}