﻿using System.IO;
using System.Net;
using System.Xml;
using System.Xml.Serialization;
using Redmine.Net.Api;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Redmine.Net.Api.Types;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Web;

namespace Test
{
    /// <summary>
    ///This is a test class for RedmineManagerTest and is intended
    ///to contain all RedmineManagerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RedmineManagerTest
    {
        /// <summary>
        ///A test for CreateObject
        ///</summary>
        public void CreateObjectTestHelper<T>()
            where T : class
        {
           
            RedmineManager target = new RedmineManager(host, apiKey); // TODO: Initialize to an appropriate value
            var obj = new Issue(); // TODO: Initialize to an appropriate value
            obj.Subject = "test subject issue";
            obj.Project = new IdentifiableName {Id = 25};
            obj.Priority = new IdentifiableName {Id = 1};
            target.CreateObject<Issue>(obj);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void CreateObjectTest()
        {
            CreateObjectTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for DeleteObject
        ///</summary>
        public void DeleteObjectTestHelper<T>()
            where T : class
        {
           
            RedmineManager target = new RedmineManager(host, apiKey); // TODO: Initialize to an appropriate value
            string id = string.Empty; // TODO: Initialize to an appropriate value
            NameValueCollection parameters = null; // TODO: Initialize to an appropriate value
            target.DeleteObject<Issue>(id, parameters);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void DeleteObjectTest()
        {
            DeleteObjectTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetObject
        ///</summary>
        public void GetObjectTestHelper<T>()
            where T : class
        {
         
            RedmineManager target = new RedmineManager(host, apiKey); // TODO: Initialize to an appropriate value
            string id = string.Empty; // TODO: Initialize to an appropriate value
            NameValueCollection parameters = null; // TODO: Initialize to an appropriate value
            T expected = null; // TODO: Initialize to an appropriate value
            T actual;
            actual = target.GetObject<T>(id, parameters);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void GetObjectTest()
        {
            GetObjectTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetObjectList
        ///</summary>
        public void GetObjectListTestHelper<T>()
            where T : class
        {
          
            RedmineManager target = new RedmineManager(host, apiKey); // TODO: Initialize to an appropriate value
            NameValueCollection parameters = null; // TODO: Initialize to an appropriate value
            IList<T> expected = null; // TODO: Initialize to an appropriate value
            IList<T> actual;
            actual = target.GetObjectList<T>(parameters);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void GetObjectListTest()
        {
            GetObjectListTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for UpdateObject
        ///</summary>
        public void UpdateObjectTestHelper<T>()
            where T : class
        {
          
            RedmineManager target = new RedmineManager(host, apiKey); // TODO: Initialize to an appropriate value
            string id = "90"; // TODO: Initialize to an appropriate value
            var obj = new Issue(); // TODO: Initialize to an appropriate value
            obj.Subject = "test subject issue";
            obj.Project = new IdentifiableName { Id = 25 };
            obj.Priority = new IdentifiableName { Id = 1 };
            target.UpdateObject<Issue>(id, obj);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void UpdateObjectTest()
        {
            UpdateObjectTestHelper<GenericParameterHelper>();
        }
    }
}