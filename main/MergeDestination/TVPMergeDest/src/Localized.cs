// WARNING:
// This file was generated by the Microsoft DataWarehouse String Resource Tool 1.33.0.0
// from information in Localized.strings.
// DO NOT MODIFY THIS FILE'S CONTENTS, THEY WILL BE OVERWRITTEN
// 
namespace Microsoft.SqlServer.Dts.Pipeline
{
	using System;
	using System.Resources;
	using System.Globalization;
	
	
	[System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
	internal class Localized
	{
		
		protected Localized()
		{
		}
		
		public static CultureInfo Culture
		{
			get
			{
				return Keys.Culture;
			}
			set
			{
				Keys.Culture = value;
			}
		}
		
		public static string ConnectionDescription
		{
			get
			{
				return Keys.GetString(Keys.ConnectionDescription);
			}
		}
		
		public static string ComponentName
		{
			get
			{
				return Keys.GetString(Keys.ComponentName);
			}
		}
		
		public static string ComponentDisplayName
		{
			get
			{
				return Keys.GetString(Keys.ComponentDisplayName);
			}
		}
		
		public static string ComponentDescription
		{
			get
			{
				return Keys.GetString(Keys.ComponentDescription);
			}
		}
		
		public static string ReadTimeoutDescription
		{
			get
			{
				return Keys.GetString(Keys.ReadTimeoutDescription);
			}
		}
		
		public static string InputName
		{
			get
			{
				return Keys.GetString(Keys.InputName);
			}
		}
		
		public static string ContactInfo1
		{
			get
			{
				return Keys.GetString(Keys.ContactInfo1);
			}
		}
		
		public static string ContactInfo2
		{
			get
			{
				return Keys.GetString(Keys.ContactInfo2);
			}
		}
		
		public static string ErrorOutputName
		{
			get
			{
				return Keys.GetString(Keys.ErrorOutputName);
			}
		}
		
		public static string TableName
		{
			get
			{
				return Keys.GetString(Keys.TableName);
			}
		}
		
		public static string TableNameDescription
		{
			get
			{
				return Keys.GetString(Keys.TableNameDescription);
			}
		}
		
		public static string BatchSizeDescription
		{
			get
			{
				return Keys.GetString(Keys.BatchSizeDescription);
			}
		}
		
		public static string CommandTimeoutDescription
		{
			get
			{
				return Keys.GetString(Keys.CommandTimeoutDescription);
			}
		}
		
		public static string FailureConvertTable
		{
			get
			{
				return Keys.GetString(Keys.FailureConvertTable);
			}
		}
		
		public static string SelectReturnEmptyTable
		{
			get
			{
				return Keys.GetString(Keys.SelectReturnEmptyTable);
			}
		}
		
		public static string TypeAssemblyInfo(string info)
		{
			return Keys.GetString(Keys.TypeAssemblyInfo, info);
		}
		
		public static string DiagnosticPre(string externalRequest)
		{
			return Keys.GetString(Keys.DiagnosticPre, externalRequest);
		}
		
		public static string DiagnosticPost(string externalRequest)
		{
			return Keys.GetString(Keys.DiagnosticPost, externalRequest);
		}
		
		public static string FailureToLoadSchema(string path, string connection)
		{
			return Keys.GetString(Keys.FailureToLoadSchema, path, connection);
		}
		
		public static string ConnectionReturnedNullSchema(string connType, string tableName)
		{
			return Keys.GetString(Keys.ConnectionReturnedNullSchema, connType, tableName);
		}
		
		public static string ColumnnameDescriptorInvalid(string path, string descriptorname)
		{
			return Keys.GetString(Keys.ColumnnameDescriptorInvalid, path, descriptorname);
		}
		
		public static string DatatypeDescriptorInvalid(string path, string descriptorname)
		{
			return Keys.GetString(Keys.DatatypeDescriptorInvalid, path, descriptorname);
		}
		
		public static string ColunsizeDescriptorInvalid(string path, string descriptorname)
		{
			return Keys.GetString(Keys.ColunsizeDescriptorInvalid, path, descriptorname);
		}
		
		public static string NumericPrecisionDescriptorInvalid(string path, string descriptorname)
		{
			return Keys.GetString(Keys.NumericPrecisionDescriptorInvalid, path, descriptorname);
		}
		
		public static string NumericaScaleInvalid(string path, string descriptorname)
		{
			return Keys.GetString(Keys.NumericaScaleInvalid, path, descriptorname);
		}
		
		public static string FailureGetMetadataTableByConnection(string message)
		{
			return Keys.GetString(Keys.FailureGetMetadataTableByConnection, message);
		}
		
		public static string FailureGetMetadataTableByCommand(string message)
		{
			return Keys.GetString(Keys.FailureGetMetadataTableByCommand, message);
		}
		
		public static string UnableToLoadProviderInfos_DirectoryDoesntExist(string dir)
		{
			return Keys.GetString(Keys.UnableToLoadProviderInfos_DirectoryDoesntExist, dir);
		}
		
		public static string UnableToLoadProviderInfos_FileMissing(string fileName)
		{
			return Keys.GetString(Keys.UnableToLoadProviderInfos_FileMissing, fileName);
		}
		
		public static string UnableToLoadProviderInfos_UnableToDeserializeFile(string message)
		{
			return Keys.GetString(Keys.UnableToLoadProviderInfos_UnableToDeserializeFile, message);
		}
		
		public static string UnableToLoadMappingFile_UnableToCreateSerializer(string type, string message)
		{
			return Keys.GetString(Keys.UnableToLoadMappingFile_UnableToCreateSerializer, type, message);
		}
		
		public static string UnableToLoadMappingFile_UnableToCreateFileStreamForOpen(string message)
		{
			return Keys.GetString(Keys.UnableToLoadMappingFile_UnableToCreateFileStreamForOpen, message);
		}
		
		public static string UnableToLoadMappingFile_UnableToCreateValidatingReader(string message)
		{
			return Keys.GetString(Keys.UnableToLoadMappingFile_UnableToCreateValidatingReader, message);
		}
		
		public static string UnableToLoadMappingFile_UnableToReadSchema(string message)
		{
			return Keys.GetString(Keys.UnableToLoadMappingFile_UnableToReadSchema, message);
		}
		
		public static string UnableToLoadMappingFile_UnableToDeserializeFile(string message)
		{
			return Keys.GetString(Keys.UnableToLoadMappingFile_UnableToDeserializeFile, message);
		}
		
		[System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
		public class Keys
		{
			
			static ResourceManager resourceManager = new ResourceManager(typeof(Localized).FullName, typeof(Localized).Module.Assembly);
			
			static CultureInfo _culture = null;
			
			public const string ConnectionDescription = "ConnectionDescription";
			
			public const string ComponentName = "ComponentName";
			
			public const string ComponentDisplayName = "ComponentDisplayName";
			
			public const string ComponentDescription = "ComponentDescription";
			
			public const string ReadTimeoutDescription = "ReadTimeoutDescription";
			
			public const string InputName = "InputName";
			
			public const string ContactInfo1 = "ContactInfo1";
			
			public const string ContactInfo2 = "ContactInfo2";
			
			public const string TypeAssemblyInfo = "TypeAssemblyInfo";
			
			public const string DiagnosticPre = "DiagnosticPre";
			
			public const string DiagnosticPost = "DiagnosticPost";
			
			public const string ErrorOutputName = "ErrorOutputName";
			
			public const string TableName = "TableName";
			
			public const string TableNameDescription = "TableNameDescription";
			
			public const string BatchSizeDescription = "BatchSizeDescription";
			
			public const string CommandTimeoutDescription = "CommandTimeoutDescription";
			
			public const string FailureToLoadSchema = "FailureToLoadSchema";
			
			public const string ConnectionReturnedNullSchema = "ConnectionReturnedNullSchema";
			
			public const string ColumnnameDescriptorInvalid = "ColumnnameDescriptorInvalid";
			
			public const string DatatypeDescriptorInvalid = "DatatypeDescriptorInvalid";
			
			public const string ColunsizeDescriptorInvalid = "ColunsizeDescriptorInvalid";
			
			public const string NumericPrecisionDescriptorInvalid = "NumericPrecisionDescriptorInvalid";
			
			public const string NumericaScaleInvalid = "NumericaScaleInvalid";
			
			public const string FailureConvertTable = "FailureConvertTable";
			
			public const string FailureGetMetadataTableByConnection = "FailureGetMetadataTableByConnection";
			
			public const string FailureGetMetadataTableByCommand = "FailureGetMetadataTableByCommand";
			
			public const string SelectReturnEmptyTable = "SelectReturnEmptyTable";
			
			public const string UnableToLoadProviderInfos_DirectoryDoesntExist = "UnableToLoadProviderInfos_DirectoryDoesntExist";
			
			public const string UnableToLoadProviderInfos_FileMissing = "UnableToLoadProviderInfos_FileMissing";
			
			public const string UnableToLoadProviderInfos_UnableToDeserializeFile = "UnableToLoadProviderInfos_UnableToDeserializeFile";
			
			public const string UnableToLoadMappingFile_UnableToCreateSerializer = "UnableToLoadMappingFile_UnableToCreateSerializer";
			
			public const string UnableToLoadMappingFile_UnableToCreateFileStreamForOpen = "UnableToLoadMappingFile_UnableToCreateFileStreamForOpen";
			
			public const string UnableToLoadMappingFile_UnableToCreateValidatingReader = "UnableToLoadMappingFile_UnableToCreateValidatingReader";
			
			public const string UnableToLoadMappingFile_UnableToReadSchema = "UnableToLoadMappingFile_UnableToReadSchema";
			
			public const string UnableToLoadMappingFile_UnableToDeserializeFile = "UnableToLoadMappingFile_UnableToDeserializeFile";
			
			private Keys()
			{
			}
			
			public static CultureInfo Culture
			{
				get
				{
					return _culture;
				}
				set
				{
					_culture = value;
				}
			}
			
			public static string GetString(string key)
			{
				return resourceManager.GetString(key, _culture);
			}
			
			public static string GetString(string key, object arg0)
			{
				return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, resourceManager.GetString(key, _culture), arg0);
			}
			
			public static string GetString(string key, object arg0, object arg1)
			{
				return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, resourceManager.GetString(key, _culture), arg0, arg1);
			}
		}
	}
}