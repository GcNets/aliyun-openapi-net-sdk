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
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.OnsMqtt.Transform;
using Aliyun.Acs.OnsMqtt.Transform.V20191211;

namespace Aliyun.Acs.OnsMqtt.Model.V20191211
{
    public class SendMessageRequest : RpcAcsRequest<SendMessageResponse>
    {
        public SendMessageRequest()
            : base("OnsMqtt", "2019-12-11", "SendMessage", "onsmqtt", "openAPI")
        {
			Method = MethodType.POST;
        }

		private bool? noPersistFlag;

		private string mqttTopic;

		private string instanceId;

		private string payload;

		private string receiptId;

		public bool? NoPersistFlag
		{
			get
			{
				return noPersistFlag;
			}
			set	
			{
				noPersistFlag = value;
				DictionaryUtil.Add(QueryParameters, "NoPersistFlag", value.ToString());
			}
		}

		public string MqttTopic
		{
			get
			{
				return mqttTopic;
			}
			set	
			{
				mqttTopic = value;
				DictionaryUtil.Add(QueryParameters, "MqttTopic", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string Payload
		{
			get
			{
				return payload;
			}
			set	
			{
				payload = value;
				DictionaryUtil.Add(QueryParameters, "Payload", value);
			}
		}

		public string ReceiptId
		{
			get
			{
				return receiptId;
			}
			set	
			{
				receiptId = value;
				DictionaryUtil.Add(QueryParameters, "ReceiptId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SendMessageResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SendMessageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
