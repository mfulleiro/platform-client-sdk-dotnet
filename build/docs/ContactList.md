---
title: ContactList
---
## ININ.PureCloudApi.Model.ContactList

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **DateCreated** | **DateTime?** | Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
| **ColumnNames** | **List&lt;string&gt;** | The names of the contact data columns. | |
| **PhoneColumns** | [**List&lt;ContactPhoneNumberColumn&gt;**](ContactPhoneNumberColumn.html) | Indicates which columns are phone numbers. | |
| **ImportStatus** | [**ImportStatus**](ImportStatus.html) | The status of the import process. | [optional] |
| **PreviewModeColumnName** | **string** | A column to check if a contact should always be dialed in preview mode. | [optional] |
| **PreviewModeAcceptedValues** | **List&lt;string&gt;** | The values in the previewModeColumnName column that indicate a contact should always be dialed in preview mode. | [optional] |
| **Size** | **long?** | The number of contacts in the ContactList. | [optional] |
| **AttemptLimits** | [**UriReference**](UriReference.html) | AttemptLimits for this ContactList | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


