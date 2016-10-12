/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// The result of a DeleteTrust request.
    /// </summary>
    public partial class DeleteTrustResponse : AmazonWebServiceResponse
    {
        private string _trustId;

        /// <summary>
        /// Gets and sets the property TrustId. 
        /// <para>
        /// The Trust ID of the trust relationship that was deleted.
        /// </para>
        /// </summary>
        public string TrustId
        {
            get { return this._trustId; }
            set { this._trustId = value; }
        }

        // Check to see if TrustId property is set
        internal bool IsSetTrustId()
        {
            return this._trustId != null;
        }

    }
}