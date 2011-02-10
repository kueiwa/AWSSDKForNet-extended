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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// <para>Describes the status of the job flow.</para>
    /// </summary>
    public class JobFlowExecutionStatusDetail  
    {
        
        private string state;
        private DateTime? creationDateTime;
        private DateTime? startDateTime;
        private DateTime? readyDateTime;
        private DateTime? endDateTime;
        private string lastStateChangeReason;

        /// <summary>
        /// The state of the job flow.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>COMPLETED, FAILED, TERMINATED, RUNNING, SHUTTING_DOWN, STARTING, WAITING, BOOTSTRAPPING</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        /// <summary>
        /// Sets the State property
        /// </summary>
        /// <param name="state">The value to set for the State property </param>
        /// <returns>this instance</returns>
        public JobFlowExecutionStatusDetail WithState(string state)
        {
            this.state = state;
            return this;
        }
            
        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this.state != null;      
        }

        /// <summary>
        /// The creation date and time of the job flow.
        ///  
        /// </summary>
        public DateTime CreationDateTime
        {
            get { return this.creationDateTime ?? default(DateTime); }
            set { this.creationDateTime = value; }
        }

        /// <summary>
        /// Sets the CreationDateTime property
        /// </summary>
        /// <param name="creationDateTime">The value to set for the CreationDateTime property </param>
        /// <returns>this instance</returns>
        public JobFlowExecutionStatusDetail WithCreationDateTime(DateTime creationDateTime)
        {
            this.creationDateTime = creationDateTime;
            return this;
        }
            
        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this.creationDateTime.HasValue;      
        }

        /// <summary>
        /// The start date and time of the job flow.
        ///  
        /// </summary>
        public DateTime StartDateTime
        {
            get { return this.startDateTime ?? default(DateTime); }
            set { this.startDateTime = value; }
        }

        /// <summary>
        /// Sets the StartDateTime property
        /// </summary>
        /// <param name="startDateTime">The value to set for the StartDateTime property </param>
        /// <returns>this instance</returns>
        public JobFlowExecutionStatusDetail WithStartDateTime(DateTime startDateTime)
        {
            this.startDateTime = startDateTime;
            return this;
        }
            
        // Check to see if StartDateTime property is set
        internal bool IsSetStartDateTime()
        {
            return this.startDateTime.HasValue;         
        }

        /// <summary>
        /// The date and time when the job flow was ready to start running
        /// bootstrap actions.
        ///  
        /// </summary>
        public DateTime ReadyDateTime
        {
            get { return this.readyDateTime ?? default(DateTime); }
            set { this.readyDateTime = value; }
        }

        /// <summary>
        /// Sets the ReadyDateTime property
        /// </summary>
        /// <param name="readyDateTime">The value to set for the ReadyDateTime property </param>
        /// <returns>this instance</returns>
        public JobFlowExecutionStatusDetail WithReadyDateTime(DateTime readyDateTime)
        {
            this.readyDateTime = readyDateTime;
            return this;
        }
            
        // Check to see if ReadyDateTime property is set
        internal bool IsSetReadyDateTime()
        {
            return this.readyDateTime.HasValue;         
        }

        /// <summary>
        /// The completion date and time of the job flow.
        ///  
        /// </summary>
        public DateTime EndDateTime
        {
            get { return this.endDateTime ?? default(DateTime); }
            set { this.endDateTime = value; }
        }

        /// <summary>
        /// Sets the EndDateTime property
        /// </summary>
        /// <param name="endDateTime">The value to set for the EndDateTime property </param>
        /// <returns>this instance</returns>
        public JobFlowExecutionStatusDetail WithEndDateTime(DateTime endDateTime)
        {
            this.endDateTime = endDateTime;
            return this;
        }
            
        // Check to see if EndDateTime property is set
        internal bool IsSetEndDateTime()
        {
            return this.endDateTime.HasValue;       
        }

        /// <summary>
        /// Description of the job flow last changed state.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 10280</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string LastStateChangeReason
        {
            get { return this.lastStateChangeReason; }
            set { this.lastStateChangeReason = value; }
        }

        /// <summary>
        /// Sets the LastStateChangeReason property
        /// </summary>
        /// <param name="lastStateChangeReason">The value to set for the LastStateChangeReason property </param>
        /// <returns>this instance</returns>
        public JobFlowExecutionStatusDetail WithLastStateChangeReason(string lastStateChangeReason)
        {
            this.lastStateChangeReason = lastStateChangeReason;
            return this;
        }
            
        // Check to see if LastStateChangeReason property is set
        internal bool IsSetLastStateChangeReason()
        {
            return this.lastStateChangeReason != null;      
        }
    }
}
