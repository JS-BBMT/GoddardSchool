/*
 * Goddard.FMS.SchoolEvents
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using FranchiseePortal.SchoolEventsWebApiClient.Client;
using FranchiseePortal.SchoolEventsWebApiClient.Api;
// uncomment below to import models
//using FranchiseePortal.SchoolEventsWebApiClient.Model;

namespace FranchiseePortal.SchoolEventsWebApiClient.Test.Api
{
    /// <summary>
    ///  Class for testing EventTemplatesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class EventTemplatesApiTests : IDisposable
    {
        private EventTemplatesApi instance;

        public EventTemplatesApiTests()
        {
            instance = new EventTemplatesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EventTemplatesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' EventTemplatesApi
            //Assert.IsType<EventTemplatesApi>(instance);
        }

        /// <summary>
        /// Test ApiV1EventTemplateGet
        /// </summary>
        [Fact]
        public void ApiV1EventTemplateGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? templateId = null;
            //var response = instance.ApiV1EventTemplateGet(templateId);
            //Assert.IsType<EventTemplate>(response);
        }

        /// <summary>
        /// Test ApiV1EventTemplatePost
        /// </summary>
        [Fact]
        public void ApiV1EventTemplatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PostEventTemplate postEventTemplate = null;
            //var response = instance.ApiV1EventTemplatePost(postEventTemplate);
            //Assert.IsType<EventTemplate>(response);
        }

        /// <summary>
        /// Test ApiV1EventTemplatePut
        /// </summary>
        [Fact]
        public void ApiV1EventTemplatePutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? templateId = null;
            //PostEventTemplate postEventTemplate = null;
            //var response = instance.ApiV1EventTemplatePut(templateId, postEventTemplate);
            //Assert.IsType<EventTemplate>(response);
        }

        /// <summary>
        /// Test ApiV1EventTemplatesGet
        /// </summary>
        [Fact]
        public void ApiV1EventTemplatesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? fmsSchoolId = null;
            //var response = instance.ApiV1EventTemplatesGet(fmsSchoolId);
            //Assert.IsType<List<EventTemplate>>(response);
        }
    }
}