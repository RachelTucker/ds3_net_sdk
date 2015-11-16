﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Ds3;
using Ds3.Helpers;
using System.IO;

namespace IntegrationTestDS3
{
    [TestFixture]
    class DataIntegrity
    {

        private IDs3Client _client;
        private IDs3ClientHelpers _helpers;
        private List<string> tempFiles = new List<string>();

        [SetUp]
        public void Setup()
        {
            /*
             * Ds3Builder builder = Ds3Builder.FromEnv();
             * this._client = builder.Build();
             * 
             */
            string _endpoint = "http://192.168.56.102:8080";
            string accesskey = "c3BlY3RyYQ==";
            string secretkey = "womvedQo";
            string _proxy = "http://192.168.56.1:9090";
            //string _proxy = "";
            var _credentials = new Credentials(accesskey, secretkey);
            Ds3Builder builder = new Ds3Builder(_endpoint, _credentials);
            if (!string.IsNullOrEmpty(_proxy))
            {
                builder.WithProxy(new Uri(_proxy));
            }
            this._client = builder.Build();
            this._helpers = new Ds3ClientHelpers(this._client);
        }

        [TearDown]
        public void Teardown()
        {
            foreach (string file in tempFiles)
            {
                File.Delete(file);
            }
        }

        [Test]
        public void SingleObjectGet()
        {
            string bucketName = "integrityBucket";

            try
            {
                Ds3TestUtils.LoadTestData(_client, "integrityBucket");

                string file = Ds3TestUtils.GetSingleObject(_client, bucketName, "beowulf.txt");
                tempFiles.Add(file);

                string sha1 = Ds3TestUtils.ComputeSha1(file);

                Assert.AreEqual("jtpN/ZmICOS8pWseFd0+MX2CII0=", sha1);
            }
            finally
            {
                Ds3TestUtils.DeleteBucket(_client, bucketName);
            }
        }
    }
}
