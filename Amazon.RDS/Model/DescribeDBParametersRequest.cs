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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDBParameters operation.
    /// <para> This API returns the detailed parameter list for a particular
    /// DBParameterGroup. </para>
    /// </summary>
    /// <seealso cref="Amazon.RDS.AmazonRDS.DescribeDBParameters"/>
    public class DescribeDBParametersRequest : AmazonWebServiceRequest
    {
        private string dBParameterGroupName;
        private string source;
        private int? maxRecords;
        private string marker;

        /// <summary>
        /// The name of a specific database parameter group to return details for.
        ///  
        /// </summary>
        public string DBParameterGroupName
        {
            get { return this.dBParameterGroupName; }
            set { this.dBParameterGroupName = value; }
        }

        /// <summary>
        /// Sets the DBParameterGroupName property
        /// </summary>
        /// <param name="dBParameterGroupName">The value to set for the DBParameterGroupName property </param>
        /// <returns>this instance</returns>
        public DescribeDBParametersRequest WithDBParameterGroupName(string dBParameterGroupName)
        {
            this.dBParameterGroupName = dBParameterGroupName;
            return this;
        }
            
        // Check to see if DBParameterGroupName property is set
        internal bool IsSetDBParameterGroupName()
        {
            return this.dBParameterGroupName != null;       
        }

        /// <summary>
        /// The parameter types to return.
        ///  
        /// </summary>
        public string Source
        {
            get { return this.source; }
            set { this.source = value; }
        }

        /// <summary>
        /// Sets the Source property
        /// </summary>
        /// <param name="source">The value to set for the Source property </param>
        /// <returns>this instance</returns>
        public DescribeDBParametersRequest WithSource(string source)
        {
            this.source = source;
            return this;
        }
            
        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this.source != null;         
        }

        /// <summary>
        /// The maximum number of records to include in the response. If more
        /// records exist than the specified <i>MaxRecords</i> value, a marker is
        /// included in the response so that the remaining results may be
        /// retrieved.
        ///  
        /// </summary>
        public int MaxRecords
        {
            get { return this.maxRecords ?? default(int); }
            set { this.maxRecords = value; }
        }

        /// <summary>
        /// Sets the MaxRecords property
        /// </summary>
        /// <param name="maxRecords">The value to set for the MaxRecords property </param>
        /// <returns>this instance</returns>
        public DescribeDBParametersRequest WithMaxRecords(int maxRecords)
        {
            this.maxRecords = maxRecords;
            return this;
        }
            
        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this.maxRecords.HasValue;        
        }

        /// <summary>
        /// An optional marker provided in the previous DescribeDBInstances
        /// request. If this parameter is specified, the response includes only
        /// records beyond the marker, up to the value specified by
        /// <i>MaxRecords</i>.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        public DescribeDBParametersRequest WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            
        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;         
        }
    }
}
    
