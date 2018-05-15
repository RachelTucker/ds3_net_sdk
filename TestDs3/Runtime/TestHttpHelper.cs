﻿/*
 * ******************************************************************************
 *   Copyright 2014-2017 Spectra Logic Corporation. All Rights Reserved.
 *   Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *   this file except in compliance with the License. A copy of the License is located at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 *   or in the "license" file accompanying this file.
 *   This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *   CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *   specific language governing permissions and limitations under the License.
 * ****************************************************************************
 */

using Ds3.Runtime;
using NUnit.Framework;
using System;
using System.Text.RegularExpressions;

namespace TestDs3.Runtime
{
    [TestFixture]
    public class TestHttpHelper
    {
        private static readonly string _encodedPatternParam = @"^[a-zA-Z0-9-\-!$&'()*+,=._~:@/?%]*$";
        private static readonly string _encodedPatternPath = @"^[a-zA-Z0-9-\-!$&'()*+,=._~:@/%]*$";

        private static readonly string _symbols = "1234567890-!@#$%^&*()_+`~[]\\{}|;':\"./<>?∞πϊφϠ,=";

        private static bool IsEncodedSafeParam(string str)
        {
            return Regex.Match(str, _encodedPatternParam).Success;
        }

        private static bool IsEncodedSafePath(string str)
        {
            return Regex.Match(str, _encodedPatternPath).Success;
        }

        [Test]
        public void TestUrlEncode()
        {
            Assert.AreEqual("abc%20/%E4%BB%BD", HttpHelper.PercentEncodePath("abc /份"));
        }

        [Test]
        public void TestPercentEncodePathSymbols()
        {
            string result = HttpHelper.PercentEncodePath(_symbols);
            Console.WriteLine(result);
            Assert.IsTrue(IsEncodedSafePath(result));
        }

        [Test]
        public void TestPercentEncodeParamSymbols()
        {
            string result = HttpHelper.PercentEncodeQuery(_symbols);
            Assert.IsTrue(IsEncodedSafeParam(result));
        }

        [Test]
        public void TestPercentEncodeColon()
        {
            Assert.AreEqual("c:/test1", HttpHelper.PercentEncodePath("c:/test1"));
        }
        [Test]
        public void TestPercentEncodeKoreanChars()
        {
            Assert.AreEqual("c:/%ED%85%8C%EC%8A%A4%ED%8A%B8", HttpHelper.PercentEncodePath("c:/테스트"));
            Assert.AreEqual("c:/%ED%85%8C%EC%8A%A4%ED%8A%B8!", HttpHelper.PercentEncodePath("c:/테스트!"));
        }
    }
}