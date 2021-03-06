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
using Aliyun.Acs.Dds.Model.V20151201;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeBackupsResponseUnmarshaller
    {
        public static DescribeBackupsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeBackupsResponse describeBackupsResponse = new DescribeBackupsResponse();

			describeBackupsResponse.HttpResponse = context.HttpResponse;
			describeBackupsResponse.RequestId = context.StringValue("DescribeBackups.RequestId");
			describeBackupsResponse.PageNumber = context.IntegerValue("DescribeBackups.PageNumber");
			describeBackupsResponse.PageSize = context.IntegerValue("DescribeBackups.PageSize");
			describeBackupsResponse.TotalCount = context.IntegerValue("DescribeBackups.TotalCount");

			List<DescribeBackupsResponse.DescribeBackups_Backup> describeBackupsResponse_backups = new List<DescribeBackupsResponse.DescribeBackups_Backup>();
			for (int i = 0; i < context.Length("DescribeBackups.Backups.Length"); i++) {
				DescribeBackupsResponse.DescribeBackups_Backup backup = new DescribeBackupsResponse.DescribeBackups_Backup();
				backup.BackupDBNames = context.StringValue("DescribeBackups.Backups["+ i +"].BackupDBNames");
				backup.BackupId = context.IntegerValue("DescribeBackups.Backups["+ i +"].BackupId");
				backup.BackupStatus = context.StringValue("DescribeBackups.Backups["+ i +"].BackupStatus");
				backup.BackupStartTime = context.StringValue("DescribeBackups.Backups["+ i +"].BackupStartTime");
				backup.BackupEndTime = context.StringValue("DescribeBackups.Backups["+ i +"].BackupEndTime");
				backup.BackupType = context.StringValue("DescribeBackups.Backups["+ i +"].BackupType");
				backup.BackupMode = context.StringValue("DescribeBackups.Backups["+ i +"].BackupMode");
				backup.BackupMethod = context.StringValue("DescribeBackups.Backups["+ i +"].BackupMethod");
				backup.BackupDownloadURL = context.StringValue("DescribeBackups.Backups["+ i +"].BackupDownloadURL");
				backup.BackupIntranetDownloadURL = context.StringValue("DescribeBackups.Backups["+ i +"].BackupIntranetDownloadURL");
				backup.BackupSize = context.LongValue("DescribeBackups.Backups["+ i +"].BackupSize");

				describeBackupsResponse_backups.Add(backup);
			}
			describeBackupsResponse.Backups = describeBackupsResponse_backups;
        
			return describeBackupsResponse;
        }
    }
}
