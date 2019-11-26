﻿// Copyright (c) Philipp Wagner. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using ApacheJenaSample.Exporter.Extensions;
using System;
using System.Xml;

namespace ApacheJenaSample.Exporter.Dto
{
    public class AirportDto
    {
        public Uri Uri => UriHelper.SetFragment(Constants.NsAviationAirport, XmlConvert.EncodeName($"airport_{IATA}"));

        public string AirportId { get; set; }

        public string IATA { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }
    }
}