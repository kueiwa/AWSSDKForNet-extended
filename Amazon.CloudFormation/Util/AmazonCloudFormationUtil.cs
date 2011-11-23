﻿using System;
using System.IO;
using System.Text;
using System.Net;
using System.Reflection;
using System.Web;

using Amazon.Util;

namespace Amazon.CloudFormation.Util
{
    public class AmazonCloudFormationUtil
    {
        /// <summary>
        /// This method will signal to the CloudFormation the status of a wait condition.
        /// </summary>
        /// <param name="presignedURL">The URL returned from the creation of a WaitHandle in a CloudFormation Stack</param>
        /// <param name="status">SUCCESS or FAILURE for the status of a stack</param>
        /// <param name="reason">The reason for the status</param>
        /// <param name="uniqueId">A unique identifier for the signal.  Using <c>Guid.NewGuid().ToString()</c>can be used for this.</param>
        /// <param name="data">Data to be passed back for later use in the template.</param>
        public static void SignalWaitCondition(string presignedURL, string status, string reason, string uniqueId, string data)
        {
            string requestBody = string.Format(
                "{{" +
                  "\"Status\" : \"{0}\"," +
                  "\"Reason\" : \"{1}\"," +
                  "\"UniqueId\" : \"{2}\"," +
                  "\"Data\" : \"{3}\"" +
                "}}", status, reason, uniqueId, data);

            Uri uri = new Uri(presignedURL);
            AWSSDKUtils.ForceCanonicalPathAndQuery(uri);
            HttpWebRequest httpRequest = WebRequest.Create(uri) as HttpWebRequest;
            httpRequest.Method = "PUT";
            httpRequest.ContentType = "";
            httpRequest.ContentLength = requestBody.Length;

            using (var stream = new StreamWriter(httpRequest.GetRequestStream()))
            {
                stream.Write(requestBody);
            }

            var response = httpRequest.GetResponse();
            response.Close();
        }
    }
}
