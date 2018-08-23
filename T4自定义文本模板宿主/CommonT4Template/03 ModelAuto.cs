

using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class __efmigrationshistory
	{
		#region Constructor
		public __efmigrationshistory() { }

		public __efmigrationshistory(String migrationId,String productVersion)
		{
			this.migrationId = migrationId;
			this.productVersion = productVersion;
		}
		#endregion

		#region Attributes
		private String migrationId;

		public String MigrationId
		{
			get { return migrationId; }
			set { migrationId = value; }
		}
		private String productVersion;

		public String ProductVersion
		{
			get { return productVersion; }
			set { productVersion = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (string.IsNullOrEmpty(this.MigrationId))
			{
				validatorResult = false;
				this.ErrorList.Add("The MigrationId should not be empty!");
			}
			if (this.MigrationId != null && 95 < this.MigrationId.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of MigrationId should not be greater then 95!");
			}
			if (string.IsNullOrEmpty(this.ProductVersion))
			{
				validatorResult = false;
				this.ErrorList.Add("The ProductVersion should not be empty!");
			}
			if (this.ProductVersion != null && 32 < this.ProductVersion.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of ProductVersion should not be greater then 32!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class abpauditlogs
	{
		#region Constructor
		public abpauditlogs() { }

		public abpauditlogs(Int64 id,String browserInfo,String clientIpAddress,String clientName,String customData,String exception,Int32 executionDuration,DateTime executionTime,Int32 impersonatorTenantId,Int64 impersonatorUserId,String methodName,String parameters,String serviceName,Int32 tenantId,Int64 userId)
		{
			this.id = id;
			this.browserInfo = browserInfo;
			this.clientIpAddress = clientIpAddress;
			this.clientName = clientName;
			this.customData = customData;
			this.exception = exception;
			this.executionDuration = executionDuration;
			this.executionTime = executionTime;
			this.impersonatorTenantId = impersonatorTenantId;
			this.impersonatorUserId = impersonatorUserId;
			this.methodName = methodName;
			this.parameters = parameters;
			this.serviceName = serviceName;
			this.tenantId = tenantId;
			this.userId = userId;
		}
		#endregion

		#region Attributes
		private Int64 id;

		public Int64 Id
		{
			get { return id; }
			set { id = value; }
		}
		private String browserInfo;

		public String BrowserInfo
		{
			get { return browserInfo; }
			set { browserInfo = value; }
		}
		private String clientIpAddress;

		public String ClientIpAddress
		{
			get { return clientIpAddress; }
			set { clientIpAddress = value; }
		}
		private String clientName;

		public String ClientName
		{
			get { return clientName; }
			set { clientName = value; }
		}
		private String customData;

		public String CustomData
		{
			get { return customData; }
			set { customData = value; }
		}
		private String exception;

		public String Exception
		{
			get { return exception; }
			set { exception = value; }
		}
		private Int32 executionDuration;

		public Int32 ExecutionDuration
		{
			get { return executionDuration; }
			set { executionDuration = value; }
		}
		private DateTime? executionTime;

		public DateTime? ExecutionTime
		{
			get { return executionTime; }
			set { executionTime = value; }
		}
		private Int32 impersonatorTenantId;

		public Int32 ImpersonatorTenantId
		{
			get { return impersonatorTenantId; }
			set { impersonatorTenantId = value; }
		}
		private Int64 impersonatorUserId;

		public Int64 ImpersonatorUserId
		{
			get { return impersonatorUserId; }
			set { impersonatorUserId = value; }
		}
		private String methodName;

		public String MethodName
		{
			get { return methodName; }
			set { methodName = value; }
		}
		private String parameters;

		public String Parameters
		{
			get { return parameters; }
			set { parameters = value; }
		}
		private String serviceName;

		public String ServiceName
		{
			get { return serviceName; }
			set { serviceName = value; }
		}
		private Int32 tenantId;

		public Int32 TenantId
		{
			get { return tenantId; }
			set { tenantId = value; }
		}
		private Int64 userId;

		public Int64 UserId
		{
			get { return userId; }
			set { userId = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (this.BrowserInfo != null && 512 < this.BrowserInfo.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of BrowserInfo should not be greater then 512!");
			}
			if (this.ClientIpAddress != null && 64 < this.ClientIpAddress.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of ClientIpAddress should not be greater then 64!");
			}
			if (this.ClientName != null && 128 < this.ClientName.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of ClientName should not be greater then 128!");
			}
			if (this.CustomData != null && 2000 < this.CustomData.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of CustomData should not be greater then 2000!");
			}
			if (this.Exception != null && 2000 < this.Exception.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Exception should not be greater then 2000!");
			}
			if (this.ExecutionTime==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The ExecutionTime should not be empty!");
			}
			if (this.MethodName != null && 256 < this.MethodName.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of MethodName should not be greater then 256!");
			}
			if (this.Parameters != null && 1024 < this.Parameters.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Parameters should not be greater then 1024!");
			}
			if (this.ServiceName != null && 256 < this.ServiceName.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of ServiceName should not be greater then 256!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class abpbackgroundjobs
	{
		#region Constructor
		public abpbackgroundjobs() { }

		public abpbackgroundjobs(Int64 id,DateTime creationTime,Int64 creatorUserId,UInt64 isAbandoned,String jobArgs,String jobType,DateTime lastTryTime,DateTime nextTryTime,Byte priority,Int16 tryCount)
		{
			this.id = id;
			this.creationTime = creationTime;
			this.creatorUserId = creatorUserId;
			this.isAbandoned = isAbandoned;
			this.jobArgs = jobArgs;
			this.jobType = jobType;
			this.lastTryTime = lastTryTime;
			this.nextTryTime = nextTryTime;
			this.priority = priority;
			this.tryCount = tryCount;
		}
		#endregion

		#region Attributes
		private Int64 id;

		public Int64 Id
		{
			get { return id; }
			set { id = value; }
		}
		private DateTime? creationTime;

		public DateTime? CreationTime
		{
			get { return creationTime; }
			set { creationTime = value; }
		}
		private Int64 creatorUserId;

		public Int64 CreatorUserId
		{
			get { return creatorUserId; }
			set { creatorUserId = value; }
		}
		private UInt64 isAbandoned;

		public UInt64 IsAbandoned
		{
			get { return isAbandoned; }
			set { isAbandoned = value; }
		}
		private String jobArgs;

		public String JobArgs
		{
			get { return jobArgs; }
			set { jobArgs = value; }
		}
		private String jobType;

		public String JobType
		{
			get { return jobType; }
			set { jobType = value; }
		}
		private DateTime? lastTryTime;

		public DateTime? LastTryTime
		{
			get { return lastTryTime; }
			set { lastTryTime = value; }
		}
		private DateTime? nextTryTime;

		public DateTime? NextTryTime
		{
			get { return nextTryTime; }
			set { nextTryTime = value; }
		}
		private Byte priority;

		public Byte Priority
		{
			get { return priority; }
			set { priority = value; }
		}
		private Int16 tryCount;

		public Int16 TryCount
		{
			get { return tryCount; }
			set { tryCount = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (this.CreationTime==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The CreationTime should not be empty!");
			}
			if (string.IsNullOrEmpty(this.JobArgs))
			{
				validatorResult = false;
				this.ErrorList.Add("The JobArgs should not be empty!");
			}
			if (this.JobArgs != null && -1 < this.JobArgs.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of JobArgs should not be greater then -1!");
			}
			if (string.IsNullOrEmpty(this.JobType))
			{
				validatorResult = false;
				this.ErrorList.Add("The JobType should not be empty!");
			}
			if (this.JobType != null && 512 < this.JobType.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of JobType should not be greater then 512!");
			}
			if (this.NextTryTime==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The NextTryTime should not be empty!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class abpeditions
	{
		#region Constructor
		public abpeditions() { }

		public abpeditions(Int32 id,DateTime creationTime,Int64 creatorUserId,Int64 deleterUserId,DateTime deletionTime,String displayName,UInt64 isDeleted,DateTime lastModificationTime,Int64 lastModifierUserId,String name)
		{
			this.id = id;
			this.creationTime = creationTime;
			this.creatorUserId = creatorUserId;
			this.deleterUserId = deleterUserId;
			this.deletionTime = deletionTime;
			this.displayName = displayName;
			this.isDeleted = isDeleted;
			this.lastModificationTime = lastModificationTime;
			this.lastModifierUserId = lastModifierUserId;
			this.name = name;
		}
		#endregion

		#region Attributes
		private Int32 id;

		public Int32 Id
		{
			get { return id; }
			set { id = value; }
		}
		private DateTime? creationTime;

		public DateTime? CreationTime
		{
			get { return creationTime; }
			set { creationTime = value; }
		}
		private Int64 creatorUserId;

		public Int64 CreatorUserId
		{
			get { return creatorUserId; }
			set { creatorUserId = value; }
		}
		private Int64 deleterUserId;

		public Int64 DeleterUserId
		{
			get { return deleterUserId; }
			set { deleterUserId = value; }
		}
		private DateTime? deletionTime;

		public DateTime? DeletionTime
		{
			get { return deletionTime; }
			set { deletionTime = value; }
		}
		private String displayName;

		public String DisplayName
		{
			get { return displayName; }
			set { displayName = value; }
		}
		private UInt64 isDeleted;

		public UInt64 IsDeleted
		{
			get { return isDeleted; }
			set { isDeleted = value; }
		}
		private DateTime? lastModificationTime;

		public DateTime? LastModificationTime
		{
			get { return lastModificationTime; }
			set { lastModificationTime = value; }
		}
		private Int64 lastModifierUserId;

		public Int64 LastModifierUserId
		{
			get { return lastModifierUserId; }
			set { lastModifierUserId = value; }
		}
		private String name;

		public String Name
		{
			get { return name; }
			set { name = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (this.CreationTime==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The CreationTime should not be empty!");
			}
			if (string.IsNullOrEmpty(this.DisplayName))
			{
				validatorResult = false;
				this.ErrorList.Add("The DisplayName should not be empty!");
			}
			if (this.DisplayName != null && 64 < this.DisplayName.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of DisplayName should not be greater then 64!");
			}
			if (string.IsNullOrEmpty(this.Name))
			{
				validatorResult = false;
				this.ErrorList.Add("The Name should not be empty!");
			}
			if (this.Name != null && 32 < this.Name.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Name should not be greater then 32!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class abpentitychanges
	{
		#region Constructor
		public abpentitychanges() { }

		public abpentitychanges(Int64 id,DateTime changeTime,Byte changeType,Int64 entityChangeSetId,String entityId,String entityTypeFullName,Int32 tenantId)
		{
			this.id = id;
			this.changeTime = changeTime;
			this.changeType = changeType;
			this.entityChangeSetId = entityChangeSetId;
			this.entityId = entityId;
			this.entityTypeFullName = entityTypeFullName;
			this.tenantId = tenantId;
		}
		#endregion

		#region Attributes
		private Int64 id;

		public Int64 Id
		{
			get { return id; }
			set { id = value; }
		}
		private DateTime? changeTime;

		public DateTime? ChangeTime
		{
			get { return changeTime; }
			set { changeTime = value; }
		}
		private Byte changeType;

		public Byte ChangeType
		{
			get { return changeType; }
			set { changeType = value; }
		}
		private Int64 entityChangeSetId;

		public Int64 EntityChangeSetId
		{
			get { return entityChangeSetId; }
			set { entityChangeSetId = value; }
		}
		private String entityId;

		public String EntityId
		{
			get { return entityId; }
			set { entityId = value; }
		}
		private String entityTypeFullName;

		public String EntityTypeFullName
		{
			get { return entityTypeFullName; }
			set { entityTypeFullName = value; }
		}
		private Int32 tenantId;

		public Int32 TenantId
		{
			get { return tenantId; }
			set { tenantId = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (this.ChangeTime==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The ChangeTime should not be empty!");
			}
			if (this.EntityId != null && 48 < this.EntityId.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of EntityId should not be greater then 48!");
			}
			if (this.EntityTypeFullName != null && 192 < this.EntityTypeFullName.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of EntityTypeFullName should not be greater then 192!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class abpentitychangesets
	{
		#region Constructor
		public abpentitychangesets() { }

		public abpentitychangesets(Int64 id,String browserInfo,String clientIpAddress,String clientName,DateTime creationTime,String extensionData,Int32 impersonatorTenantId,Int64 impersonatorUserId,String reason,Int32 tenantId,Int64 userId)
		{
			this.id = id;
			this.browserInfo = browserInfo;
			this.clientIpAddress = clientIpAddress;
			this.clientName = clientName;
			this.creationTime = creationTime;
			this.extensionData = extensionData;
			this.impersonatorTenantId = impersonatorTenantId;
			this.impersonatorUserId = impersonatorUserId;
			this.reason = reason;
			this.tenantId = tenantId;
			this.userId = userId;
		}
		#endregion

		#region Attributes
		private Int64 id;

		public Int64 Id
		{
			get { return id; }
			set { id = value; }
		}
		private String browserInfo;

		public String BrowserInfo
		{
			get { return browserInfo; }
			set { browserInfo = value; }
		}
		private String clientIpAddress;

		public String ClientIpAddress
		{
			get { return clientIpAddress; }
			set { clientIpAddress = value; }
		}
		private String clientName;

		public String ClientName
		{
			get { return clientName; }
			set { clientName = value; }
		}
		private DateTime? creationTime;

		public DateTime? CreationTime
		{
			get { return creationTime; }
			set { creationTime = value; }
		}
		private String extensionData;

		public String ExtensionData
		{
			get { return extensionData; }
			set { extensionData = value; }
		}
		private Int32 impersonatorTenantId;

		public Int32 ImpersonatorTenantId
		{
			get { return impersonatorTenantId; }
			set { impersonatorTenantId = value; }
		}
		private Int64 impersonatorUserId;

		public Int64 ImpersonatorUserId
		{
			get { return impersonatorUserId; }
			set { impersonatorUserId = value; }
		}
		private String reason;

		public String Reason
		{
			get { return reason; }
			set { reason = value; }
		}
		private Int32 tenantId;

		public Int32 TenantId
		{
			get { return tenantId; }
			set { tenantId = value; }
		}
		private Int64 userId;

		public Int64 UserId
		{
			get { return userId; }
			set { userId = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (this.BrowserInfo != null && 512 < this.BrowserInfo.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of BrowserInfo should not be greater then 512!");
			}
			if (this.ClientIpAddress != null && 64 < this.ClientIpAddress.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of ClientIpAddress should not be greater then 64!");
			}
			if (this.ClientName != null && 128 < this.ClientName.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of ClientName should not be greater then 128!");
			}
			if (this.CreationTime==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The CreationTime should not be empty!");
			}
			if (this.ExtensionData != null && -1 < this.ExtensionData.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of ExtensionData should not be greater then -1!");
			}
			if (this.Reason != null && 256 < this.Reason.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Reason should not be greater then 256!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class abpentitypropertychanges
	{
		#region Constructor
		public abpentitypropertychanges() { }

		public abpentitypropertychanges(Int64 id,Int64 entityChangeId,String newValue,String originalValue,String propertyName,String propertyTypeFullName,Int32 tenantId)
		{
			this.id = id;
			this.entityChangeId = entityChangeId;
			this.newValue = newValue;
			this.originalValue = originalValue;
			this.propertyName = propertyName;
			this.propertyTypeFullName = propertyTypeFullName;
			this.tenantId = tenantId;
		}
		#endregion

		#region Attributes
		private Int64 id;

		public Int64 Id
		{
			get { return id; }
			set { id = value; }
		}
		private Int64 entityChangeId;

		public Int64 EntityChangeId
		{
			get { return entityChangeId; }
			set { entityChangeId = value; }
		}
		private String newValue;

		public String NewValue
		{
			get { return newValue; }
			set { newValue = value; }
		}
		private String originalValue;

		public String OriginalValue
		{
			get { return originalValue; }
			set { originalValue = value; }
		}
		private String propertyName;

		public String PropertyName
		{
			get { return propertyName; }
			set { propertyName = value; }
		}
		private String propertyTypeFullName;

		public String PropertyTypeFullName
		{
			get { return propertyTypeFullName; }
			set { propertyTypeFullName = value; }
		}
		private Int32 tenantId;

		public Int32 TenantId
		{
			get { return tenantId; }
			set { tenantId = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (this.NewValue != null && 512 < this.NewValue.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NewValue should not be greater then 512!");
			}
			if (this.OriginalValue != null && 512 < this.OriginalValue.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of OriginalValue should not be greater then 512!");
			}
			if (this.PropertyName != null && 96 < this.PropertyName.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of PropertyName should not be greater then 96!");
			}
			if (this.PropertyTypeFullName != null && 192 < this.PropertyTypeFullName.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of PropertyTypeFullName should not be greater then 192!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class abpfeatures
	{
		#region Constructor
		public abpfeatures() { }

		public abpfeatures(Int32 editionId,Int64 id,DateTime creationTime,Int64 creatorUserId,String discriminator,String name,Int32 tenantId,String value)
		{
			this.editionId = editionId;
			this.id = id;
			this.creationTime = creationTime;
			this.creatorUserId = creatorUserId;
			this.discriminator = discriminator;
			this.name = name;
			this.tenantId = tenantId;
			this.value = value;
		}
		#endregion

		#region Attributes
		private Int32 editionId;

		public Int32 EditionId
		{
			get { return editionId; }
			set { editionId = value; }
		}
		private Int64 id;

		public Int64 Id
		{
			get { return id; }
			set { id = value; }
		}
		private DateTime? creationTime;

		public DateTime? CreationTime
		{
			get { return creationTime; }
			set { creationTime = value; }
		}
		private Int64 creatorUserId;

		public Int64 CreatorUserId
		{
			get { return creatorUserId; }
			set { creatorUserId = value; }
		}
		private String discriminator;

		public String Discriminator
		{
			get { return discriminator; }
			set { discriminator = value; }
		}
		private String name;

		public String Name
		{
			get { return name; }
			set { name = value; }
		}
		private Int32 tenantId;

		public Int32 TenantId
		{
			get { return tenantId; }
			set { tenantId = value; }
		}
		private String value;

		public String Value
		{
			get { return value; }
			set { value = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (this.CreationTime==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The CreationTime should not be empty!");
			}
			if (string.IsNullOrEmpty(this.Discriminator))
			{
				validatorResult = false;
				this.ErrorList.Add("The Discriminator should not be empty!");
			}
			if (this.Discriminator != null && -1 < this.Discriminator.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Discriminator should not be greater then -1!");
			}
			if (string.IsNullOrEmpty(this.Name))
			{
				validatorResult = false;
				this.ErrorList.Add("The Name should not be empty!");
			}
			if (this.Name != null && 128 < this.Name.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Name should not be greater then 128!");
			}
			if (string.IsNullOrEmpty(this.Value))
			{
				validatorResult = false;
				this.ErrorList.Add("The Value should not be empty!");
			}
			if (this.Value != null && 2000 < this.Value.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Value should not be greater then 2000!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class abplanguages
	{
		#region Constructor
		public abplanguages() { }

		public abplanguages(Int32 id,DateTime creationTime,Int64 creatorUserId,Int64 deleterUserId,DateTime deletionTime,String displayName,String icon,UInt64 isDeleted,UInt64 isDisabled,DateTime lastModificationTime,Int64 lastModifierUserId,String name,Int32 tenantId)
		{
			this.id = id;
			this.creationTime = creationTime;
			this.creatorUserId = creatorUserId;
			this.deleterUserId = deleterUserId;
			this.deletionTime = deletionTime;
			this.displayName = displayName;
			this.icon = icon;
			this.isDeleted = isDeleted;
			this.isDisabled = isDisabled;
			this.lastModificationTime = lastModificationTime;
			this.lastModifierUserId = lastModifierUserId;
			this.name = name;
			this.tenantId = tenantId;
		}
		#endregion

		#region Attributes
		private Int32 id;

		public Int32 Id
		{
			get { return id; }
			set { id = value; }
		}
		private DateTime? creationTime;

		public DateTime? CreationTime
		{
			get { return creationTime; }
			set { creationTime = value; }
		}
		private Int64 creatorUserId;

		public Int64 CreatorUserId
		{
			get { return creatorUserId; }
			set { creatorUserId = value; }
		}
		private Int64 deleterUserId;

		public Int64 DeleterUserId
		{
			get { return deleterUserId; }
			set { deleterUserId = value; }
		}
		private DateTime? deletionTime;

		public DateTime? DeletionTime
		{
			get { return deletionTime; }
			set { deletionTime = value; }
		}
		private String displayName;

		public String DisplayName
		{
			get { return displayName; }
			set { displayName = value; }
		}
		private String icon;

		public String Icon
		{
			get { return icon; }
			set { icon = value; }
		}
		private UInt64 isDeleted;

		public UInt64 IsDeleted
		{
			get { return isDeleted; }
			set { isDeleted = value; }
		}
		private UInt64 isDisabled;

		public UInt64 IsDisabled
		{
			get { return isDisabled; }
			set { isDisabled = value; }
		}
		private DateTime? lastModificationTime;

		public DateTime? LastModificationTime
		{
			get { return lastModificationTime; }
			set { lastModificationTime = value; }
		}
		private Int64 lastModifierUserId;

		public Int64 LastModifierUserId
		{
			get { return lastModifierUserId; }
			set { lastModifierUserId = value; }
		}
		private String name;

		public String Name
		{
			get { return name; }
			set { name = value; }
		}
		private Int32 tenantId;

		public Int32 TenantId
		{
			get { return tenantId; }
			set { tenantId = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (this.CreationTime==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The CreationTime should not be empty!");
			}
			if (string.IsNullOrEmpty(this.DisplayName))
			{
				validatorResult = false;
				this.ErrorList.Add("The DisplayName should not be empty!");
			}
			if (this.DisplayName != null && 64 < this.DisplayName.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of DisplayName should not be greater then 64!");
			}
			if (this.Icon != null && 128 < this.Icon.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Icon should not be greater then 128!");
			}
			if (string.IsNullOrEmpty(this.Name))
			{
				validatorResult = false;
				this.ErrorList.Add("The Name should not be empty!");
			}
			if (this.Name != null && 10 < this.Name.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Name should not be greater then 10!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class abplanguagetexts
	{
		#region Constructor
		public abplanguagetexts() { }

		public abplanguagetexts(Int64 id,DateTime creationTime,Int64 creatorUserId,String key,String languageName,DateTime lastModificationTime,Int64 lastModifierUserId,String source,Int32 tenantId,String value)
		{
			this.id = id;
			this.creationTime = creationTime;
			this.creatorUserId = creatorUserId;
			this.key = key;
			this.languageName = languageName;
			this.lastModificationTime = lastModificationTime;
			this.lastModifierUserId = lastModifierUserId;
			this.source = source;
			this.tenantId = tenantId;
			this.value = value;
		}
		#endregion

		#region Attributes
		private Int64 id;

		public Int64 Id
		{
			get { return id; }
			set { id = value; }
		}
		private DateTime? creationTime;

		public DateTime? CreationTime
		{
			get { return creationTime; }
			set { creationTime = value; }
		}
		private Int64 creatorUserId;

		public Int64 CreatorUserId
		{
			get { return creatorUserId; }
			set { creatorUserId = value; }
		}
		private String key;

		public String Key
		{
			get { return key; }
			set { key = value; }
		}
		private String languageName;

		public String LanguageName
		{
			get { return languageName; }
			set { languageName = value; }
		}
		private DateTime? lastModificationTime;

		public DateTime? LastModificationTime
		{
			get { return lastModificationTime; }
			set { lastModificationTime = value; }
		}
		private Int64 lastModifierUserId;

		public Int64 LastModifierUserId
		{
			get { return lastModifierUserId; }
			set { lastModifierUserId = value; }
		}
		private String source;

		public String Source
		{
			get { return source; }
			set { source = value; }
		}
		private Int32 tenantId;

		public Int32 TenantId
		{
			get { return tenantId; }
			set { tenantId = value; }
		}
		private String value;

		public String Value
		{
			get { return value; }
			set { value = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (this.CreationTime==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The CreationTime should not be empty!");
			}
			if (string.IsNullOrEmpty(this.Key))
			{
				validatorResult = false;
				this.ErrorList.Add("The Key should not be empty!");
			}
			if (this.Key != null && 256 < this.Key.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Key should not be greater then 256!");
			}
			if (string.IsNullOrEmpty(this.LanguageName))
			{
				validatorResult = false;
				this.ErrorList.Add("The LanguageName should not be empty!");
			}
			if (this.LanguageName != null && 10 < this.LanguageName.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of LanguageName should not be greater then 10!");
			}
			if (string.IsNullOrEmpty(this.Source))
			{
				validatorResult = false;
				this.ErrorList.Add("The Source should not be empty!");
			}
			if (this.Source != null && 128 < this.Source.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Source should not be greater then 128!");
			}
			if (string.IsNullOrEmpty(this.Value))
			{
				validatorResult = false;
				this.ErrorList.Add("The Value should not be empty!");
			}
			if (this.Value != null && -1 < this.Value.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Value should not be greater then -1!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class abpnotifications
	{
		#region Constructor
		public abpnotifications() { }

		public abpnotifications(String id,DateTime creationTime,Int64 creatorUserId,String data,String dataTypeName,String entityId,String entityTypeAssemblyQualifiedName,String entityTypeName,String excludedUserIds,String notificationName,Byte severity,String tenantIds,String userIds)
		{
			this.id = id;
			this.creationTime = creationTime;
			this.creatorUserId = creatorUserId;
			this.data = data;
			this.dataTypeName = dataTypeName;
			this.entityId = entityId;
			this.entityTypeAssemblyQualifiedName = entityTypeAssemblyQualifiedName;
			this.entityTypeName = entityTypeName;
			this.excludedUserIds = excludedUserIds;
			this.notificationName = notificationName;
			this.severity = severity;
			this.tenantIds = tenantIds;
			this.userIds = userIds;
		}
		#endregion

		#region Attributes
		private String id;

		public String Id
		{
			get { return id; }
			set { id = value; }
		}
		private DateTime? creationTime;

		public DateTime? CreationTime
		{
			get { return creationTime; }
			set { creationTime = value; }
		}
		private Int64 creatorUserId;

		public Int64 CreatorUserId
		{
			get { return creatorUserId; }
			set { creatorUserId = value; }
		}
		private String data;

		public String Data
		{
			get { return data; }
			set { data = value; }
		}
		private String dataTypeName;

		public String DataTypeName
		{
			get { return dataTypeName; }
			set { dataTypeName = value; }
		}
		private String entityId;

		public String EntityId
		{
			get { return entityId; }
			set { entityId = value; }
		}
		private String entityTypeAssemblyQualifiedName;

		public String EntityTypeAssemblyQualifiedName
		{
			get { return entityTypeAssemblyQualifiedName; }
			set { entityTypeAssemblyQualifiedName = value; }
		}
		private String entityTypeName;

		public String EntityTypeName
		{
			get { return entityTypeName; }
			set { entityTypeName = value; }
		}
		private String excludedUserIds;

		public String ExcludedUserIds
		{
			get { return excludedUserIds; }
			set { excludedUserIds = value; }
		}
		private String notificationName;

		public String NotificationName
		{
			get { return notificationName; }
			set { notificationName = value; }
		}
		private Byte severity;

		public Byte Severity
		{
			get { return severity; }
			set { severity = value; }
		}
		private String tenantIds;

		public String TenantIds
		{
			get { return tenantIds; }
			set { tenantIds = value; }
		}
		private String userIds;

		public String UserIds
		{
			get { return userIds; }
			set { userIds = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (string.IsNullOrEmpty(this.Id))
			{
				validatorResult = false;
				this.ErrorList.Add("The Id should not be empty!");
			}
			if (this.Id != null && -1 < this.Id.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Id should not be greater then -1!");
			}
			if (this.CreationTime==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The CreationTime should not be empty!");
			}
			if (this.Data != null && -1 < this.Data.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Data should not be greater then -1!");
			}
			if (this.DataTypeName != null && 512 < this.DataTypeName.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of DataTypeName should not be greater then 512!");
			}
			if (this.EntityId != null && 96 < this.EntityId.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of EntityId should not be greater then 96!");
			}
			if (this.EntityTypeAssemblyQualifiedName != null && 512 < this.EntityTypeAssemblyQualifiedName.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of EntityTypeAssemblyQualifiedName should not be greater then 512!");
			}
			if (this.EntityTypeName != null && 250 < this.EntityTypeName.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of EntityTypeName should not be greater then 250!");
			}
			if (this.ExcludedUserIds != null && -1 < this.ExcludedUserIds.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of ExcludedUserIds should not be greater then -1!");
			}
			if (string.IsNullOrEmpty(this.NotificationName))
			{
				validatorResult = false;
				this.ErrorList.Add("The NotificationName should not be empty!");
			}
			if (this.NotificationName != null && 96 < this.NotificationName.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NotificationName should not be greater then 96!");
			}
			if (this.TenantIds != null && -1 < this.TenantIds.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of TenantIds should not be greater then -1!");
			}
			if (this.UserIds != null && -1 < this.UserIds.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of UserIds should not be greater then -1!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class abpnotificationsubscriptions
	{
		#region Constructor
		public abpnotificationsubscriptions() { }

		public abpnotificationsubscriptions(String id,DateTime creationTime,Int64 creatorUserId,String entityId,String entityTypeAssemblyQualifiedName,String entityTypeName,String notificationName,Int32 tenantId,Int64 userId)
		{
			this.id = id;
			this.creationTime = creationTime;
			this.creatorUserId = creatorUserId;
			this.entityId = entityId;
			this.entityTypeAssemblyQualifiedName = entityTypeAssemblyQualifiedName;
			this.entityTypeName = entityTypeName;
			this.notificationName = notificationName;
			this.tenantId = tenantId;
			this.userId = userId;
		}
		#endregion

		#region Attributes
		private String id;

		public String Id
		{
			get { return id; }
			set { id = value; }
		}
		private DateTime? creationTime;

		public DateTime? CreationTime
		{
			get { return creationTime; }
			set { creationTime = value; }
		}
		private Int64 creatorUserId;

		public Int64 CreatorUserId
		{
			get { return creatorUserId; }
			set { creatorUserId = value; }
		}
		private String entityId;

		public String EntityId
		{
			get { return entityId; }
			set { entityId = value; }
		}
		private String entityTypeAssemblyQualifiedName;

		public String EntityTypeAssemblyQualifiedName
		{
			get { return entityTypeAssemblyQualifiedName; }
			set { entityTypeAssemblyQualifiedName = value; }
		}
		private String entityTypeName;

		public String EntityTypeName
		{
			get { return entityTypeName; }
			set { entityTypeName = value; }
		}
		private String notificationName;

		public String NotificationName
		{
			get { return notificationName; }
			set { notificationName = value; }
		}
		private Int32 tenantId;

		public Int32 TenantId
		{
			get { return tenantId; }
			set { tenantId = value; }
		}
		private Int64 userId;

		public Int64 UserId
		{
			get { return userId; }
			set { userId = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (string.IsNullOrEmpty(this.Id))
			{
				validatorResult = false;
				this.ErrorList.Add("The Id should not be empty!");
			}
			if (this.Id != null && -1 < this.Id.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Id should not be greater then -1!");
			}
			if (this.CreationTime==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The CreationTime should not be empty!");
			}
			if (this.EntityId != null && 96 < this.EntityId.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of EntityId should not be greater then 96!");
			}
			if (this.EntityTypeAssemblyQualifiedName != null && 512 < this.EntityTypeAssemblyQualifiedName.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of EntityTypeAssemblyQualifiedName should not be greater then 512!");
			}
			if (this.EntityTypeName != null && 250 < this.EntityTypeName.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of EntityTypeName should not be greater then 250!");
			}
			if (this.NotificationName != null && 96 < this.NotificationName.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NotificationName should not be greater then 96!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class abporganizationunits
	{
		#region Constructor
		public abporganizationunits() { }

		public abporganizationunits(Int64 id,String code,DateTime creationTime,Int64 creatorUserId,Int64 deleterUserId,DateTime deletionTime,String displayName,UInt64 isDeleted,DateTime lastModificationTime,Int64 lastModifierUserId,Int64 parentId,Int32 tenantId)
		{
			this.id = id;
			this.code = code;
			this.creationTime = creationTime;
			this.creatorUserId = creatorUserId;
			this.deleterUserId = deleterUserId;
			this.deletionTime = deletionTime;
			this.displayName = displayName;
			this.isDeleted = isDeleted;
			this.lastModificationTime = lastModificationTime;
			this.lastModifierUserId = lastModifierUserId;
			this.parentId = parentId;
			this.tenantId = tenantId;
		}
		#endregion

		#region Attributes
		private Int64 id;

		public Int64 Id
		{
			get { return id; }
			set { id = value; }
		}
		private String code;

		public String Code
		{
			get { return code; }
			set { code = value; }
		}
		private DateTime? creationTime;

		public DateTime? CreationTime
		{
			get { return creationTime; }
			set { creationTime = value; }
		}
		private Int64 creatorUserId;

		public Int64 CreatorUserId
		{
			get { return creatorUserId; }
			set { creatorUserId = value; }
		}
		private Int64 deleterUserId;

		public Int64 DeleterUserId
		{
			get { return deleterUserId; }
			set { deleterUserId = value; }
		}
		private DateTime? deletionTime;

		public DateTime? DeletionTime
		{
			get { return deletionTime; }
			set { deletionTime = value; }
		}
		private String displayName;

		public String DisplayName
		{
			get { return displayName; }
			set { displayName = value; }
		}
		private UInt64 isDeleted;

		public UInt64 IsDeleted
		{
			get { return isDeleted; }
			set { isDeleted = value; }
		}
		private DateTime? lastModificationTime;

		public DateTime? LastModificationTime
		{
			get { return lastModificationTime; }
			set { lastModificationTime = value; }
		}
		private Int64 lastModifierUserId;

		public Int64 LastModifierUserId
		{
			get { return lastModifierUserId; }
			set { lastModifierUserId = value; }
		}
		private Int64 parentId;

		public Int64 ParentId
		{
			get { return parentId; }
			set { parentId = value; }
		}
		private Int32 tenantId;

		public Int32 TenantId
		{
			get { return tenantId; }
			set { tenantId = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (string.IsNullOrEmpty(this.Code))
			{
				validatorResult = false;
				this.ErrorList.Add("The Code should not be empty!");
			}
			if (this.Code != null && 95 < this.Code.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Code should not be greater then 95!");
			}
			if (this.CreationTime==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The CreationTime should not be empty!");
			}
			if (string.IsNullOrEmpty(this.DisplayName))
			{
				validatorResult = false;
				this.ErrorList.Add("The DisplayName should not be empty!");
			}
			if (this.DisplayName != null && 128 < this.DisplayName.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of DisplayName should not be greater then 128!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class abppermissions
	{
		#region Constructor
		public abppermissions() { }

		public abppermissions(Int64 id,DateTime creationTime,Int64 creatorUserId,String discriminator,UInt64 isGranted,String name,Int32 tenantId,Int32 roleId,Int64 userId)
		{
			this.id = id;
			this.creationTime = creationTime;
			this.creatorUserId = creatorUserId;
			this.discriminator = discriminator;
			this.isGranted = isGranted;
			this.name = name;
			this.tenantId = tenantId;
			this.roleId = roleId;
			this.userId = userId;
		}
		#endregion

		#region Attributes
		private Int64 id;

		public Int64 Id
		{
			get { return id; }
			set { id = value; }
		}
		private DateTime? creationTime;

		public DateTime? CreationTime
		{
			get { return creationTime; }
			set { creationTime = value; }
		}
		private Int64 creatorUserId;

		public Int64 CreatorUserId
		{
			get { return creatorUserId; }
			set { creatorUserId = value; }
		}
		private String discriminator;

		public String Discriminator
		{
			get { return discriminator; }
			set { discriminator = value; }
		}
		private UInt64 isGranted;

		public UInt64 IsGranted
		{
			get { return isGranted; }
			set { isGranted = value; }
		}
		private String name;

		public String Name
		{
			get { return name; }
			set { name = value; }
		}
		private Int32 tenantId;

		public Int32 TenantId
		{
			get { return tenantId; }
			set { tenantId = value; }
		}
		private Int32 roleId;

		public Int32 RoleId
		{
			get { return roleId; }
			set { roleId = value; }
		}
		private Int64 userId;

		public Int64 UserId
		{
			get { return userId; }
			set { userId = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (this.CreationTime==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The CreationTime should not be empty!");
			}
			if (string.IsNullOrEmpty(this.Discriminator))
			{
				validatorResult = false;
				this.ErrorList.Add("The Discriminator should not be empty!");
			}
			if (this.Discriminator != null && -1 < this.Discriminator.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Discriminator should not be greater then -1!");
			}
			if (string.IsNullOrEmpty(this.Name))
			{
				validatorResult = false;
				this.ErrorList.Add("The Name should not be empty!");
			}
			if (this.Name != null && 128 < this.Name.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Name should not be greater then 128!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class abproleclaims
	{
		#region Constructor
		public abproleclaims() { }

		public abproleclaims(Int64 id,String claimType,String claimValue,DateTime creationTime,Int64 creatorUserId,Int32 roleId,Int32 tenantId)
		{
			this.id = id;
			this.claimType = claimType;
			this.claimValue = claimValue;
			this.creationTime = creationTime;
			this.creatorUserId = creatorUserId;
			this.roleId = roleId;
			this.tenantId = tenantId;
		}
		#endregion

		#region Attributes
		private Int64 id;

		public Int64 Id
		{
			get { return id; }
			set { id = value; }
		}
		private String claimType;

		public String ClaimType
		{
			get { return claimType; }
			set { claimType = value; }
		}
		private String claimValue;

		public String ClaimValue
		{
			get { return claimValue; }
			set { claimValue = value; }
		}
		private DateTime? creationTime;

		public DateTime? CreationTime
		{
			get { return creationTime; }
			set { creationTime = value; }
		}
		private Int64 creatorUserId;

		public Int64 CreatorUserId
		{
			get { return creatorUserId; }
			set { creatorUserId = value; }
		}
		private Int32 roleId;

		public Int32 RoleId
		{
			get { return roleId; }
			set { roleId = value; }
		}
		private Int32 tenantId;

		public Int32 TenantId
		{
			get { return tenantId; }
			set { tenantId = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (this.ClaimType != null && 256 < this.ClaimType.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of ClaimType should not be greater then 256!");
			}
			if (this.ClaimValue != null && -1 < this.ClaimValue.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of ClaimValue should not be greater then -1!");
			}
			if (this.CreationTime==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The CreationTime should not be empty!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class abproles
	{
		#region Constructor
		public abproles() { }

		public abproles(Int32 id,String concurrencyStamp,DateTime creationTime,Int64 creatorUserId,Int64 deleterUserId,DateTime deletionTime,String description,String displayName,UInt64 isDefault,UInt64 isDeleted,UInt64 isStatic,DateTime lastModificationTime,Int64 lastModifierUserId,String name,String normalizedName,Int32 tenantId)
		{
			this.id = id;
			this.concurrencyStamp = concurrencyStamp;
			this.creationTime = creationTime;
			this.creatorUserId = creatorUserId;
			this.deleterUserId = deleterUserId;
			this.deletionTime = deletionTime;
			this.description = description;
			this.displayName = displayName;
			this.isDefault = isDefault;
			this.isDeleted = isDeleted;
			this.isStatic = isStatic;
			this.lastModificationTime = lastModificationTime;
			this.lastModifierUserId = lastModifierUserId;
			this.name = name;
			this.normalizedName = normalizedName;
			this.tenantId = tenantId;
		}
		#endregion

		#region Attributes
		private Int32 id;

		public Int32 Id
		{
			get { return id; }
			set { id = value; }
		}
		private String concurrencyStamp;

		public String ConcurrencyStamp
		{
			get { return concurrencyStamp; }
			set { concurrencyStamp = value; }
		}
		private DateTime? creationTime;

		public DateTime? CreationTime
		{
			get { return creationTime; }
			set { creationTime = value; }
		}
		private Int64 creatorUserId;

		public Int64 CreatorUserId
		{
			get { return creatorUserId; }
			set { creatorUserId = value; }
		}
		private Int64 deleterUserId;

		public Int64 DeleterUserId
		{
			get { return deleterUserId; }
			set { deleterUserId = value; }
		}
		private DateTime? deletionTime;

		public DateTime? DeletionTime
		{
			get { return deletionTime; }
			set { deletionTime = value; }
		}
		private String description;

		public String Description
		{
			get { return description; }
			set { description = value; }
		}
		private String displayName;

		public String DisplayName
		{
			get { return displayName; }
			set { displayName = value; }
		}
		private UInt64 isDefault;

		public UInt64 IsDefault
		{
			get { return isDefault; }
			set { isDefault = value; }
		}
		private UInt64 isDeleted;

		public UInt64 IsDeleted
		{
			get { return isDeleted; }
			set { isDeleted = value; }
		}
		private UInt64 isStatic;

		public UInt64 IsStatic
		{
			get { return isStatic; }
			set { isStatic = value; }
		}
		private DateTime? lastModificationTime;

		public DateTime? LastModificationTime
		{
			get { return lastModificationTime; }
			set { lastModificationTime = value; }
		}
		private Int64 lastModifierUserId;

		public Int64 LastModifierUserId
		{
			get { return lastModifierUserId; }
			set { lastModifierUserId = value; }
		}
		private String name;

		public String Name
		{
			get { return name; }
			set { name = value; }
		}
		private String normalizedName;

		public String NormalizedName
		{
			get { return normalizedName; }
			set { normalizedName = value; }
		}
		private Int32 tenantId;

		public Int32 TenantId
		{
			get { return tenantId; }
			set { tenantId = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (this.ConcurrencyStamp != null && 128 < this.ConcurrencyStamp.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of ConcurrencyStamp should not be greater then 128!");
			}
			if (this.CreationTime==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The CreationTime should not be empty!");
			}
			if (this.Description != null && 5000 < this.Description.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Description should not be greater then 5000!");
			}
			if (string.IsNullOrEmpty(this.DisplayName))
			{
				validatorResult = false;
				this.ErrorList.Add("The DisplayName should not be empty!");
			}
			if (this.DisplayName != null && 64 < this.DisplayName.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of DisplayName should not be greater then 64!");
			}
			if (string.IsNullOrEmpty(this.Name))
			{
				validatorResult = false;
				this.ErrorList.Add("The Name should not be empty!");
			}
			if (this.Name != null && 32 < this.Name.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Name should not be greater then 32!");
			}
			if (string.IsNullOrEmpty(this.NormalizedName))
			{
				validatorResult = false;
				this.ErrorList.Add("The NormalizedName should not be empty!");
			}
			if (this.NormalizedName != null && 32 < this.NormalizedName.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NormalizedName should not be greater then 32!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class abpsettings
	{
		#region Constructor
		public abpsettings() { }

		public abpsettings(Int64 id,DateTime creationTime,Int64 creatorUserId,DateTime lastModificationTime,Int64 lastModifierUserId,String name,Int32 tenantId,Int64 userId,String value)
		{
			this.id = id;
			this.creationTime = creationTime;
			this.creatorUserId = creatorUserId;
			this.lastModificationTime = lastModificationTime;
			this.lastModifierUserId = lastModifierUserId;
			this.name = name;
			this.tenantId = tenantId;
			this.userId = userId;
			this.value = value;
		}
		#endregion

		#region Attributes
		private Int64 id;

		public Int64 Id
		{
			get { return id; }
			set { id = value; }
		}
		private DateTime? creationTime;

		public DateTime? CreationTime
		{
			get { return creationTime; }
			set { creationTime = value; }
		}
		private Int64 creatorUserId;

		public Int64 CreatorUserId
		{
			get { return creatorUserId; }
			set { creatorUserId = value; }
		}
		private DateTime? lastModificationTime;

		public DateTime? LastModificationTime
		{
			get { return lastModificationTime; }
			set { lastModificationTime = value; }
		}
		private Int64 lastModifierUserId;

		public Int64 LastModifierUserId
		{
			get { return lastModifierUserId; }
			set { lastModifierUserId = value; }
		}
		private String name;

		public String Name
		{
			get { return name; }
			set { name = value; }
		}
		private Int32 tenantId;

		public Int32 TenantId
		{
			get { return tenantId; }
			set { tenantId = value; }
		}
		private Int64 userId;

		public Int64 UserId
		{
			get { return userId; }
			set { userId = value; }
		}
		private String value;

		public String Value
		{
			get { return value; }
			set { value = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (this.CreationTime==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The CreationTime should not be empty!");
			}
			if (string.IsNullOrEmpty(this.Name))
			{
				validatorResult = false;
				this.ErrorList.Add("The Name should not be empty!");
			}
			if (this.Name != null && 256 < this.Name.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Name should not be greater then 256!");
			}
			if (this.Value != null && 2000 < this.Value.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Value should not be greater then 2000!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class abptenantnotifications
	{
		#region Constructor
		public abptenantnotifications() { }

		public abptenantnotifications(String id,DateTime creationTime,Int64 creatorUserId,String data,String dataTypeName,String entityId,String entityTypeAssemblyQualifiedName,String entityTypeName,String notificationName,Byte severity,Int32 tenantId)
		{
			this.id = id;
			this.creationTime = creationTime;
			this.creatorUserId = creatorUserId;
			this.data = data;
			this.dataTypeName = dataTypeName;
			this.entityId = entityId;
			this.entityTypeAssemblyQualifiedName = entityTypeAssemblyQualifiedName;
			this.entityTypeName = entityTypeName;
			this.notificationName = notificationName;
			this.severity = severity;
			this.tenantId = tenantId;
		}
		#endregion

		#region Attributes
		private String id;

		public String Id
		{
			get { return id; }
			set { id = value; }
		}
		private DateTime? creationTime;

		public DateTime? CreationTime
		{
			get { return creationTime; }
			set { creationTime = value; }
		}
		private Int64 creatorUserId;

		public Int64 CreatorUserId
		{
			get { return creatorUserId; }
			set { creatorUserId = value; }
		}
		private String data;

		public String Data
		{
			get { return data; }
			set { data = value; }
		}
		private String dataTypeName;

		public String DataTypeName
		{
			get { return dataTypeName; }
			set { dataTypeName = value; }
		}
		private String entityId;

		public String EntityId
		{
			get { return entityId; }
			set { entityId = value; }
		}
		private String entityTypeAssemblyQualifiedName;

		public String EntityTypeAssemblyQualifiedName
		{
			get { return entityTypeAssemblyQualifiedName; }
			set { entityTypeAssemblyQualifiedName = value; }
		}
		private String entityTypeName;

		public String EntityTypeName
		{
			get { return entityTypeName; }
			set { entityTypeName = value; }
		}
		private String notificationName;

		public String NotificationName
		{
			get { return notificationName; }
			set { notificationName = value; }
		}
		private Byte severity;

		public Byte Severity
		{
			get { return severity; }
			set { severity = value; }
		}
		private Int32 tenantId;

		public Int32 TenantId
		{
			get { return tenantId; }
			set { tenantId = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (string.IsNullOrEmpty(this.Id))
			{
				validatorResult = false;
				this.ErrorList.Add("The Id should not be empty!");
			}
			if (this.Id != null && -1 < this.Id.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Id should not be greater then -1!");
			}
			if (this.CreationTime==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The CreationTime should not be empty!");
			}
			if (this.Data != null && -1 < this.Data.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Data should not be greater then -1!");
			}
			if (this.DataTypeName != null && 512 < this.DataTypeName.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of DataTypeName should not be greater then 512!");
			}
			if (this.EntityId != null && 96 < this.EntityId.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of EntityId should not be greater then 96!");
			}
			if (this.EntityTypeAssemblyQualifiedName != null && 512 < this.EntityTypeAssemblyQualifiedName.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of EntityTypeAssemblyQualifiedName should not be greater then 512!");
			}
			if (this.EntityTypeName != null && 250 < this.EntityTypeName.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of EntityTypeName should not be greater then 250!");
			}
			if (string.IsNullOrEmpty(this.NotificationName))
			{
				validatorResult = false;
				this.ErrorList.Add("The NotificationName should not be empty!");
			}
			if (this.NotificationName != null && 96 < this.NotificationName.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NotificationName should not be greater then 96!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class abptenants
	{
		#region Constructor
		public abptenants() { }

		public abptenants(Int32 id,String connectionString,DateTime creationTime,Int64 creatorUserId,Int64 deleterUserId,DateTime deletionTime,Int32 editionId,UInt64 isActive,UInt64 isDeleted,DateTime lastModificationTime,Int64 lastModifierUserId,String name,String tenancyName)
		{
			this.id = id;
			this.connectionString = connectionString;
			this.creationTime = creationTime;
			this.creatorUserId = creatorUserId;
			this.deleterUserId = deleterUserId;
			this.deletionTime = deletionTime;
			this.editionId = editionId;
			this.isActive = isActive;
			this.isDeleted = isDeleted;
			this.lastModificationTime = lastModificationTime;
			this.lastModifierUserId = lastModifierUserId;
			this.name = name;
			this.tenancyName = tenancyName;
		}
		#endregion

		#region Attributes
		private Int32 id;

		public Int32 Id
		{
			get { return id; }
			set { id = value; }
		}
		private String connectionString;

		public String ConnectionString
		{
			get { return connectionString; }
			set { connectionString = value; }
		}
		private DateTime? creationTime;

		public DateTime? CreationTime
		{
			get { return creationTime; }
			set { creationTime = value; }
		}
		private Int64 creatorUserId;

		public Int64 CreatorUserId
		{
			get { return creatorUserId; }
			set { creatorUserId = value; }
		}
		private Int64 deleterUserId;

		public Int64 DeleterUserId
		{
			get { return deleterUserId; }
			set { deleterUserId = value; }
		}
		private DateTime? deletionTime;

		public DateTime? DeletionTime
		{
			get { return deletionTime; }
			set { deletionTime = value; }
		}
		private Int32 editionId;

		public Int32 EditionId
		{
			get { return editionId; }
			set { editionId = value; }
		}
		private UInt64 isActive;

		public UInt64 IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}
		private UInt64 isDeleted;

		public UInt64 IsDeleted
		{
			get { return isDeleted; }
			set { isDeleted = value; }
		}
		private DateTime? lastModificationTime;

		public DateTime? LastModificationTime
		{
			get { return lastModificationTime; }
			set { lastModificationTime = value; }
		}
		private Int64 lastModifierUserId;

		public Int64 LastModifierUserId
		{
			get { return lastModifierUserId; }
			set { lastModifierUserId = value; }
		}
		private String name;

		public String Name
		{
			get { return name; }
			set { name = value; }
		}
		private String tenancyName;

		public String TenancyName
		{
			get { return tenancyName; }
			set { tenancyName = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (this.ConnectionString != null && 1024 < this.ConnectionString.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of ConnectionString should not be greater then 1024!");
			}
			if (this.CreationTime==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The CreationTime should not be empty!");
			}
			if (string.IsNullOrEmpty(this.Name))
			{
				validatorResult = false;
				this.ErrorList.Add("The Name should not be empty!");
			}
			if (this.Name != null && 128 < this.Name.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Name should not be greater then 128!");
			}
			if (string.IsNullOrEmpty(this.TenancyName))
			{
				validatorResult = false;
				this.ErrorList.Add("The TenancyName should not be empty!");
			}
			if (this.TenancyName != null && 64 < this.TenancyName.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of TenancyName should not be greater then 64!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class abpuseraccounts
	{
		#region Constructor
		public abpuseraccounts() { }

		public abpuseraccounts(Int64 id,DateTime creationTime,Int64 creatorUserId,Int64 deleterUserId,DateTime deletionTime,String emailAddress,UInt64 isDeleted,DateTime lastLoginTime,DateTime lastModificationTime,Int64 lastModifierUserId,Int32 tenantId,Int64 userId,Int64 userLinkId,String userName)
		{
			this.id = id;
			this.creationTime = creationTime;
			this.creatorUserId = creatorUserId;
			this.deleterUserId = deleterUserId;
			this.deletionTime = deletionTime;
			this.emailAddress = emailAddress;
			this.isDeleted = isDeleted;
			this.lastLoginTime = lastLoginTime;
			this.lastModificationTime = lastModificationTime;
			this.lastModifierUserId = lastModifierUserId;
			this.tenantId = tenantId;
			this.userId = userId;
			this.userLinkId = userLinkId;
			this.userName = userName;
		}
		#endregion

		#region Attributes
		private Int64 id;

		public Int64 Id
		{
			get { return id; }
			set { id = value; }
		}
		private DateTime? creationTime;

		public DateTime? CreationTime
		{
			get { return creationTime; }
			set { creationTime = value; }
		}
		private Int64 creatorUserId;

		public Int64 CreatorUserId
		{
			get { return creatorUserId; }
			set { creatorUserId = value; }
		}
		private Int64 deleterUserId;

		public Int64 DeleterUserId
		{
			get { return deleterUserId; }
			set { deleterUserId = value; }
		}
		private DateTime? deletionTime;

		public DateTime? DeletionTime
		{
			get { return deletionTime; }
			set { deletionTime = value; }
		}
		private String emailAddress;

		public String EmailAddress
		{
			get { return emailAddress; }
			set { emailAddress = value; }
		}
		private UInt64 isDeleted;

		public UInt64 IsDeleted
		{
			get { return isDeleted; }
			set { isDeleted = value; }
		}
		private DateTime? lastLoginTime;

		public DateTime? LastLoginTime
		{
			get { return lastLoginTime; }
			set { lastLoginTime = value; }
		}
		private DateTime? lastModificationTime;

		public DateTime? LastModificationTime
		{
			get { return lastModificationTime; }
			set { lastModificationTime = value; }
		}
		private Int64 lastModifierUserId;

		public Int64 LastModifierUserId
		{
			get { return lastModifierUserId; }
			set { lastModifierUserId = value; }
		}
		private Int32 tenantId;

		public Int32 TenantId
		{
			get { return tenantId; }
			set { tenantId = value; }
		}
		private Int64 userId;

		public Int64 UserId
		{
			get { return userId; }
			set { userId = value; }
		}
		private Int64 userLinkId;

		public Int64 UserLinkId
		{
			get { return userLinkId; }
			set { userLinkId = value; }
		}
		private String userName;

		public String UserName
		{
			get { return userName; }
			set { userName = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (this.CreationTime==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The CreationTime should not be empty!");
			}
			if (this.EmailAddress != null && 256 < this.EmailAddress.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of EmailAddress should not be greater then 256!");
			}
			if (this.UserName != null && 32 < this.UserName.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of UserName should not be greater then 32!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class abpuserclaims
	{
		#region Constructor
		public abpuserclaims() { }

		public abpuserclaims(Int64 id,String claimType,String claimValue,DateTime creationTime,Int64 creatorUserId,Int32 tenantId,Int64 userId)
		{
			this.id = id;
			this.claimType = claimType;
			this.claimValue = claimValue;
			this.creationTime = creationTime;
			this.creatorUserId = creatorUserId;
			this.tenantId = tenantId;
			this.userId = userId;
		}
		#endregion

		#region Attributes
		private Int64 id;

		public Int64 Id
		{
			get { return id; }
			set { id = value; }
		}
		private String claimType;

		public String ClaimType
		{
			get { return claimType; }
			set { claimType = value; }
		}
		private String claimValue;

		public String ClaimValue
		{
			get { return claimValue; }
			set { claimValue = value; }
		}
		private DateTime? creationTime;

		public DateTime? CreationTime
		{
			get { return creationTime; }
			set { creationTime = value; }
		}
		private Int64 creatorUserId;

		public Int64 CreatorUserId
		{
			get { return creatorUserId; }
			set { creatorUserId = value; }
		}
		private Int32 tenantId;

		public Int32 TenantId
		{
			get { return tenantId; }
			set { tenantId = value; }
		}
		private Int64 userId;

		public Int64 UserId
		{
			get { return userId; }
			set { userId = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (this.ClaimType != null && 256 < this.ClaimType.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of ClaimType should not be greater then 256!");
			}
			if (this.ClaimValue != null && -1 < this.ClaimValue.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of ClaimValue should not be greater then -1!");
			}
			if (this.CreationTime==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The CreationTime should not be empty!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class abpuserloginattempts
	{
		#region Constructor
		public abpuserloginattempts() { }

		public abpuserloginattempts(Int64 id,String browserInfo,String clientIpAddress,String clientName,DateTime creationTime,Byte result,String tenancyName,Int32 tenantId,Int64 userId,String userNameOrEmailAddress)
		{
			this.id = id;
			this.browserInfo = browserInfo;
			this.clientIpAddress = clientIpAddress;
			this.clientName = clientName;
			this.creationTime = creationTime;
			this.result = result;
			this.tenancyName = tenancyName;
			this.tenantId = tenantId;
			this.userId = userId;
			this.userNameOrEmailAddress = userNameOrEmailAddress;
		}
		#endregion

		#region Attributes
		private Int64 id;

		public Int64 Id
		{
			get { return id; }
			set { id = value; }
		}
		private String browserInfo;

		public String BrowserInfo
		{
			get { return browserInfo; }
			set { browserInfo = value; }
		}
		private String clientIpAddress;

		public String ClientIpAddress
		{
			get { return clientIpAddress; }
			set { clientIpAddress = value; }
		}
		private String clientName;

		public String ClientName
		{
			get { return clientName; }
			set { clientName = value; }
		}
		private DateTime? creationTime;

		public DateTime? CreationTime
		{
			get { return creationTime; }
			set { creationTime = value; }
		}
		private Byte result;

		public Byte Result
		{
			get { return result; }
			set { result = value; }
		}
		private String tenancyName;

		public String TenancyName
		{
			get { return tenancyName; }
			set { tenancyName = value; }
		}
		private Int32 tenantId;

		public Int32 TenantId
		{
			get { return tenantId; }
			set { tenantId = value; }
		}
		private Int64 userId;

		public Int64 UserId
		{
			get { return userId; }
			set { userId = value; }
		}
		private String userNameOrEmailAddress;

		public String UserNameOrEmailAddress
		{
			get { return userNameOrEmailAddress; }
			set { userNameOrEmailAddress = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (this.BrowserInfo != null && 512 < this.BrowserInfo.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of BrowserInfo should not be greater then 512!");
			}
			if (this.ClientIpAddress != null && 64 < this.ClientIpAddress.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of ClientIpAddress should not be greater then 64!");
			}
			if (this.ClientName != null && 128 < this.ClientName.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of ClientName should not be greater then 128!");
			}
			if (this.CreationTime==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The CreationTime should not be empty!");
			}
			if (this.TenancyName != null && 64 < this.TenancyName.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of TenancyName should not be greater then 64!");
			}
			if (this.UserNameOrEmailAddress != null && 255 < this.UserNameOrEmailAddress.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of UserNameOrEmailAddress should not be greater then 255!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class abpuserlogins
	{
		#region Constructor
		public abpuserlogins() { }

		public abpuserlogins(Int64 id,String loginProvider,String providerKey,Int32 tenantId,Int64 userId)
		{
			this.id = id;
			this.loginProvider = loginProvider;
			this.providerKey = providerKey;
			this.tenantId = tenantId;
			this.userId = userId;
		}
		#endregion

		#region Attributes
		private Int64 id;

		public Int64 Id
		{
			get { return id; }
			set { id = value; }
		}
		private String loginProvider;

		public String LoginProvider
		{
			get { return loginProvider; }
			set { loginProvider = value; }
		}
		private String providerKey;

		public String ProviderKey
		{
			get { return providerKey; }
			set { providerKey = value; }
		}
		private Int32 tenantId;

		public Int32 TenantId
		{
			get { return tenantId; }
			set { tenantId = value; }
		}
		private Int64 userId;

		public Int64 UserId
		{
			get { return userId; }
			set { userId = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (string.IsNullOrEmpty(this.LoginProvider))
			{
				validatorResult = false;
				this.ErrorList.Add("The LoginProvider should not be empty!");
			}
			if (this.LoginProvider != null && 128 < this.LoginProvider.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of LoginProvider should not be greater then 128!");
			}
			if (string.IsNullOrEmpty(this.ProviderKey))
			{
				validatorResult = false;
				this.ErrorList.Add("The ProviderKey should not be empty!");
			}
			if (this.ProviderKey != null && 256 < this.ProviderKey.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of ProviderKey should not be greater then 256!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class abpusernotifications
	{
		#region Constructor
		public abpusernotifications() { }

		public abpusernotifications(String id,DateTime creationTime,Int32 state,Int32 tenantId,String tenantNotificationId,Int64 userId)
		{
			this.id = id;
			this.creationTime = creationTime;
			this.state = state;
			this.tenantId = tenantId;
			this.tenantNotificationId = tenantNotificationId;
			this.userId = userId;
		}
		#endregion

		#region Attributes
		private String id;

		public String Id
		{
			get { return id; }
			set { id = value; }
		}
		private DateTime? creationTime;

		public DateTime? CreationTime
		{
			get { return creationTime; }
			set { creationTime = value; }
		}
		private Int32 state;

		public Int32 State
		{
			get { return state; }
			set { state = value; }
		}
		private Int32 tenantId;

		public Int32 TenantId
		{
			get { return tenantId; }
			set { tenantId = value; }
		}
		private String tenantNotificationId;

		public String TenantNotificationId
		{
			get { return tenantNotificationId; }
			set { tenantNotificationId = value; }
		}
		private Int64 userId;

		public Int64 UserId
		{
			get { return userId; }
			set { userId = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (string.IsNullOrEmpty(this.Id))
			{
				validatorResult = false;
				this.ErrorList.Add("The Id should not be empty!");
			}
			if (this.Id != null && -1 < this.Id.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Id should not be greater then -1!");
			}
			if (this.CreationTime==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The CreationTime should not be empty!");
			}
			if (string.IsNullOrEmpty(this.TenantNotificationId))
			{
				validatorResult = false;
				this.ErrorList.Add("The TenantNotificationId should not be empty!");
			}
			if (this.TenantNotificationId != null && -1 < this.TenantNotificationId.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of TenantNotificationId should not be greater then -1!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class abpuserorganizationunits
	{
		#region Constructor
		public abpuserorganizationunits() { }

		public abpuserorganizationunits(Int64 id,DateTime creationTime,Int64 creatorUserId,UInt64 isDeleted,Int64 organizationUnitId,Int32 tenantId,Int64 userId)
		{
			this.id = id;
			this.creationTime = creationTime;
			this.creatorUserId = creatorUserId;
			this.isDeleted = isDeleted;
			this.organizationUnitId = organizationUnitId;
			this.tenantId = tenantId;
			this.userId = userId;
		}
		#endregion

		#region Attributes
		private Int64 id;

		public Int64 Id
		{
			get { return id; }
			set { id = value; }
		}
		private DateTime? creationTime;

		public DateTime? CreationTime
		{
			get { return creationTime; }
			set { creationTime = value; }
		}
		private Int64 creatorUserId;

		public Int64 CreatorUserId
		{
			get { return creatorUserId; }
			set { creatorUserId = value; }
		}
		private UInt64 isDeleted;

		public UInt64 IsDeleted
		{
			get { return isDeleted; }
			set { isDeleted = value; }
		}
		private Int64 organizationUnitId;

		public Int64 OrganizationUnitId
		{
			get { return organizationUnitId; }
			set { organizationUnitId = value; }
		}
		private Int32 tenantId;

		public Int32 TenantId
		{
			get { return tenantId; }
			set { tenantId = value; }
		}
		private Int64 userId;

		public Int64 UserId
		{
			get { return userId; }
			set { userId = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (this.CreationTime==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The CreationTime should not be empty!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class abpuserroles
	{
		#region Constructor
		public abpuserroles() { }

		public abpuserroles(Int64 id,DateTime creationTime,Int64 creatorUserId,Int32 roleId,Int32 tenantId,Int64 userId)
		{
			this.id = id;
			this.creationTime = creationTime;
			this.creatorUserId = creatorUserId;
			this.roleId = roleId;
			this.tenantId = tenantId;
			this.userId = userId;
		}
		#endregion

		#region Attributes
		private Int64 id;

		public Int64 Id
		{
			get { return id; }
			set { id = value; }
		}
		private DateTime? creationTime;

		public DateTime? CreationTime
		{
			get { return creationTime; }
			set { creationTime = value; }
		}
		private Int64 creatorUserId;

		public Int64 CreatorUserId
		{
			get { return creatorUserId; }
			set { creatorUserId = value; }
		}
		private Int32 roleId;

		public Int32 RoleId
		{
			get { return roleId; }
			set { roleId = value; }
		}
		private Int32 tenantId;

		public Int32 TenantId
		{
			get { return tenantId; }
			set { tenantId = value; }
		}
		private Int64 userId;

		public Int64 UserId
		{
			get { return userId; }
			set { userId = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (this.CreationTime==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The CreationTime should not be empty!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class abpusers
	{
		#region Constructor
		public abpusers() { }

		public abpusers(Int64 id,Int32 accessFailedCount,String authenticationSource,String concurrencyStamp,DateTime creationTime,Int64 creatorUserId,Int64 deleterUserId,DateTime deletionTime,String emailAddress,String emailConfirmationCode,UInt64 isActive,UInt64 isDeleted,UInt64 isEmailConfirmed,UInt64 isLockoutEnabled,UInt64 isPhoneNumberConfirmed,UInt64 isTwoFactorEnabled,DateTime lastLoginTime,DateTime lastModificationTime,Int64 lastModifierUserId,DateTime lockoutEndDateUtc,String name,String normalizedEmailAddress,String normalizedUserName,String password,String passwordResetCode,String phoneNumber,String securityStamp,String surname,Int32 tenantId,String userName)
		{
			this.id = id;
			this.accessFailedCount = accessFailedCount;
			this.authenticationSource = authenticationSource;
			this.concurrencyStamp = concurrencyStamp;
			this.creationTime = creationTime;
			this.creatorUserId = creatorUserId;
			this.deleterUserId = deleterUserId;
			this.deletionTime = deletionTime;
			this.emailAddress = emailAddress;
			this.emailConfirmationCode = emailConfirmationCode;
			this.isActive = isActive;
			this.isDeleted = isDeleted;
			this.isEmailConfirmed = isEmailConfirmed;
			this.isLockoutEnabled = isLockoutEnabled;
			this.isPhoneNumberConfirmed = isPhoneNumberConfirmed;
			this.isTwoFactorEnabled = isTwoFactorEnabled;
			this.lastLoginTime = lastLoginTime;
			this.lastModificationTime = lastModificationTime;
			this.lastModifierUserId = lastModifierUserId;
			this.lockoutEndDateUtc = lockoutEndDateUtc;
			this.name = name;
			this.normalizedEmailAddress = normalizedEmailAddress;
			this.normalizedUserName = normalizedUserName;
			this.password = password;
			this.passwordResetCode = passwordResetCode;
			this.phoneNumber = phoneNumber;
			this.securityStamp = securityStamp;
			this.surname = surname;
			this.tenantId = tenantId;
			this.userName = userName;
		}
		#endregion

		#region Attributes
		private Int64 id;

		public Int64 Id
		{
			get { return id; }
			set { id = value; }
		}
		private Int32 accessFailedCount;

		public Int32 AccessFailedCount
		{
			get { return accessFailedCount; }
			set { accessFailedCount = value; }
		}
		private String authenticationSource;

		public String AuthenticationSource
		{
			get { return authenticationSource; }
			set { authenticationSource = value; }
		}
		private String concurrencyStamp;

		public String ConcurrencyStamp
		{
			get { return concurrencyStamp; }
			set { concurrencyStamp = value; }
		}
		private DateTime? creationTime;

		public DateTime? CreationTime
		{
			get { return creationTime; }
			set { creationTime = value; }
		}
		private Int64 creatorUserId;

		public Int64 CreatorUserId
		{
			get { return creatorUserId; }
			set { creatorUserId = value; }
		}
		private Int64 deleterUserId;

		public Int64 DeleterUserId
		{
			get { return deleterUserId; }
			set { deleterUserId = value; }
		}
		private DateTime? deletionTime;

		public DateTime? DeletionTime
		{
			get { return deletionTime; }
			set { deletionTime = value; }
		}
		private String emailAddress;

		public String EmailAddress
		{
			get { return emailAddress; }
			set { emailAddress = value; }
		}
		private String emailConfirmationCode;

		public String EmailConfirmationCode
		{
			get { return emailConfirmationCode; }
			set { emailConfirmationCode = value; }
		}
		private UInt64 isActive;

		public UInt64 IsActive
		{
			get { return isActive; }
			set { isActive = value; }
		}
		private UInt64 isDeleted;

		public UInt64 IsDeleted
		{
			get { return isDeleted; }
			set { isDeleted = value; }
		}
		private UInt64 isEmailConfirmed;

		public UInt64 IsEmailConfirmed
		{
			get { return isEmailConfirmed; }
			set { isEmailConfirmed = value; }
		}
		private UInt64 isLockoutEnabled;

		public UInt64 IsLockoutEnabled
		{
			get { return isLockoutEnabled; }
			set { isLockoutEnabled = value; }
		}
		private UInt64 isPhoneNumberConfirmed;

		public UInt64 IsPhoneNumberConfirmed
		{
			get { return isPhoneNumberConfirmed; }
			set { isPhoneNumberConfirmed = value; }
		}
		private UInt64 isTwoFactorEnabled;

		public UInt64 IsTwoFactorEnabled
		{
			get { return isTwoFactorEnabled; }
			set { isTwoFactorEnabled = value; }
		}
		private DateTime? lastLoginTime;

		public DateTime? LastLoginTime
		{
			get { return lastLoginTime; }
			set { lastLoginTime = value; }
		}
		private DateTime? lastModificationTime;

		public DateTime? LastModificationTime
		{
			get { return lastModificationTime; }
			set { lastModificationTime = value; }
		}
		private Int64 lastModifierUserId;

		public Int64 LastModifierUserId
		{
			get { return lastModifierUserId; }
			set { lastModifierUserId = value; }
		}
		private DateTime? lockoutEndDateUtc;

		public DateTime? LockoutEndDateUtc
		{
			get { return lockoutEndDateUtc; }
			set { lockoutEndDateUtc = value; }
		}
		private String name;

		public String Name
		{
			get { return name; }
			set { name = value; }
		}
		private String normalizedEmailAddress;

		public String NormalizedEmailAddress
		{
			get { return normalizedEmailAddress; }
			set { normalizedEmailAddress = value; }
		}
		private String normalizedUserName;

		public String NormalizedUserName
		{
			get { return normalizedUserName; }
			set { normalizedUserName = value; }
		}
		private String password;

		public String Password
		{
			get { return password; }
			set { password = value; }
		}
		private String passwordResetCode;

		public String PasswordResetCode
		{
			get { return passwordResetCode; }
			set { passwordResetCode = value; }
		}
		private String phoneNumber;

		public String PhoneNumber
		{
			get { return phoneNumber; }
			set { phoneNumber = value; }
		}
		private String securityStamp;

		public String SecurityStamp
		{
			get { return securityStamp; }
			set { securityStamp = value; }
		}
		private String surname;

		public String Surname
		{
			get { return surname; }
			set { surname = value; }
		}
		private Int32 tenantId;

		public Int32 TenantId
		{
			get { return tenantId; }
			set { tenantId = value; }
		}
		private String userName;

		public String UserName
		{
			get { return userName; }
			set { userName = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (this.AuthenticationSource != null && 64 < this.AuthenticationSource.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of AuthenticationSource should not be greater then 64!");
			}
			if (this.ConcurrencyStamp != null && 128 < this.ConcurrencyStamp.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of ConcurrencyStamp should not be greater then 128!");
			}
			if (this.CreationTime==null)
			{
				validatorResult = false;
				this.ErrorList.Add("The CreationTime should not be empty!");
			}
			if (string.IsNullOrEmpty(this.EmailAddress))
			{
				validatorResult = false;
				this.ErrorList.Add("The EmailAddress should not be empty!");
			}
			if (this.EmailAddress != null && 256 < this.EmailAddress.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of EmailAddress should not be greater then 256!");
			}
			if (this.EmailConfirmationCode != null && 328 < this.EmailConfirmationCode.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of EmailConfirmationCode should not be greater then 328!");
			}
			if (string.IsNullOrEmpty(this.Name))
			{
				validatorResult = false;
				this.ErrorList.Add("The Name should not be empty!");
			}
			if (this.Name != null && 32 < this.Name.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Name should not be greater then 32!");
			}
			if (string.IsNullOrEmpty(this.NormalizedEmailAddress))
			{
				validatorResult = false;
				this.ErrorList.Add("The NormalizedEmailAddress should not be empty!");
			}
			if (this.NormalizedEmailAddress != null && 256 < this.NormalizedEmailAddress.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NormalizedEmailAddress should not be greater then 256!");
			}
			if (string.IsNullOrEmpty(this.NormalizedUserName))
			{
				validatorResult = false;
				this.ErrorList.Add("The NormalizedUserName should not be empty!");
			}
			if (this.NormalizedUserName != null && 32 < this.NormalizedUserName.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of NormalizedUserName should not be greater then 32!");
			}
			if (string.IsNullOrEmpty(this.Password))
			{
				validatorResult = false;
				this.ErrorList.Add("The Password should not be empty!");
			}
			if (this.Password != null && 128 < this.Password.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Password should not be greater then 128!");
			}
			if (this.PasswordResetCode != null && 328 < this.PasswordResetCode.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of PasswordResetCode should not be greater then 328!");
			}
			if (this.PhoneNumber != null && 32 < this.PhoneNumber.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of PhoneNumber should not be greater then 32!");
			}
			if (this.SecurityStamp != null && 128 < this.SecurityStamp.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of SecurityStamp should not be greater then 128!");
			}
			if (string.IsNullOrEmpty(this.Surname))
			{
				validatorResult = false;
				this.ErrorList.Add("The Surname should not be empty!");
			}
			if (this.Surname != null && 32 < this.Surname.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Surname should not be greater then 32!");
			}
			if (string.IsNullOrEmpty(this.UserName))
			{
				validatorResult = false;
				this.ErrorList.Add("The UserName should not be empty!");
			}
			if (this.UserName != null && 32 < this.UserName.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of UserName should not be greater then 32!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Model
{
	[Serializable]
	public class abpusertokens
	{
		#region Constructor
		public abpusertokens() { }

		public abpusertokens(Int64 id,String loginProvider,String name,Int32 tenantId,Int64 userId,String value)
		{
			this.id = id;
			this.loginProvider = loginProvider;
			this.name = name;
			this.tenantId = tenantId;
			this.userId = userId;
			this.value = value;
		}
		#endregion

		#region Attributes
		private Int64 id;

		public Int64 Id
		{
			get { return id; }
			set { id = value; }
		}
		private String loginProvider;

		public String LoginProvider
		{
			get { return loginProvider; }
			set { loginProvider = value; }
		}
		private String name;

		public String Name
		{
			get { return name; }
			set { name = value; }
		}
		private Int32 tenantId;

		public Int32 TenantId
		{
			get { return tenantId; }
			set { tenantId = value; }
		}
		private Int64 userId;

		public Int64 UserId
		{
			get { return userId; }
			set { userId = value; }
		}
		private String value;

		public String Value
		{
			get { return value; }
			set { value = value; }
		}
		#endregion

		#region Validator
		public List<string> ErrorList = new List<string>();
		private bool Validator()
		{	
			bool validatorResult = true;
			if (this.LoginProvider != null && 64 < this.LoginProvider.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of LoginProvider should not be greater then 64!");
			}
			if (this.Name != null && 128 < this.Name.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Name should not be greater then 128!");
			}
			if (this.Value != null && 512 < this.Value.Length)
			{
				validatorResult = false;
				this.ErrorList.Add("The length of Value should not be greater then 512!");
			}
			return validatorResult;
		}	
		#endregion
	}
}
