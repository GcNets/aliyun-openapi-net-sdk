/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class RunInstancesResponseUnmarshaller
    {
        public static RunInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			RunInstancesResponse runInstancesResponse = new RunInstancesResponse();

			runInstancesResponse.HttpResponse = context.HttpResponse;
			runInstancesResponse.RequestId = context.StringValue("RunInstances.RequestId");
			runInstancesResponse.TradePrice = context.FloatValue("RunInstances.TradePrice");

			List<string> runInstancesResponse_instanceIdSets = new List<string>();
			for (int i = 0; i < context.Length("RunInstances.InstanceIdSets.Length"); i++) {
				runInstancesResponse_instanceIdSets.Add(context.StringValue("RunInstances.InstanceIdSets["+ i +"]"));
			}
			runInstancesResponse.InstanceIdSets = runInstancesResponse_instanceIdSets;
        
			return runInstancesResponse;
        }
    }
}
