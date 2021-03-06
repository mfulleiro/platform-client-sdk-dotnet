---
title: ContactListFilter
---
## ININ.PureCloudApi.Model.ContactListFilter

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the list. | |
| **DateCreated** | **DateTime?** | Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **DateModified** | **DateTime?** | Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Version** | **int?** | Required for updates, must match the version number of the most recent update | [optional] |
| **ContactList** | [**UriReference**](UriReference.html) | The contact list the filter is based on. | |
| **Clauses** | [**List&lt;ContactListFilterClause&gt;**](ContactListFilterClause.html) | Groups of conditions to filter the contacts by. | [optional] |
| **FilterType** | **string** | How to join clauses together. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


