/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Net;

using Amazon.IdentityManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.IdentityManagement.Model.Transform
{
    /// <summary>
    ///    Response Unmarshaller for ListVirtualMFADevices operation
    /// </summary>
    internal class ListVirtualMFADevicesResponseUnmarshaller : IResponseUnmarshaller<ListVirtualMFADevicesResponse, UnmarshallerContext> {

        public ListVirtualMFADevicesResponse Unmarshall(UnmarshallerContext context) 
        {
            ListVirtualMFADevicesResponse response = new ListVirtualMFADevicesResponse();

            while (context.Read())
            {
                if (context.IsStartElement)
                {
                    if(context.TestExpression("ListVirtualMFADevicesResult", 2))
                    {
                        response.ListVirtualMFADevicesResult = ListVirtualMFADevicesResultUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ResponseMetadata", 2))
                    {
                        response.ResponseMetadata = ResponseMetadataUnmarshaller.GetInstance().Unmarshall(context);
                    }
                }
            }

            return response;
        }
        
        
        public AmazonServiceException UnmarshallException(UnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            
            return new AmazonIdentityManagementServiceException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        
        private static ListVirtualMFADevicesResponseUnmarshaller instance;

        public static ListVirtualMFADevicesResponseUnmarshaller GetInstance()
        {
            if (instance == null) 
            {
               instance = new ListVirtualMFADevicesResponseUnmarshaller();
            }
            return instance;
        }
    
    }
}
    
