---
title: CallbackMediaParticipant
---
## ININ.PureCloudApi.Model.CallbackMediaParticipant

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The unique participant ID. | [optional] |
| **Name** | **string** | The display friendly name of the participant. | [optional] |
| **Address** | **string** | The participant address. | [optional] |
| **StartTime** | **DateTime?** | The time when this participant first joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **ConnectedTime** | **DateTime?** | The time when this participant went connected for this media (eg: video connected time). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **EndTime** | **DateTime?** | The time when this participant went disconnected for this media (eg: video disconnected time). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **StartHoldTime** | **DateTime?** | The time when this participant&#39;s hold started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
| **Purpose** | **string** | The participant&#39;s purpose.  Values can be: &#39;agent&#39;, &#39;user&#39;, &#39;customer&#39;, &#39;external&#39;, &#39;acd&#39;, &#39;ivr | [optional] |
| **State** | **string** | The participant&#39;s state.  Values can be: &#39;alerting&#39;, &#39;connected&#39;, &#39;disconnected&#39;, &#39;dialing&#39;, &#39;contacting | [optional] |
| **Direction** | **string** | The participant&#39;s direction.  Values can be: &#39;inbound&#39; or &#39;outbound&#39; | [optional] |
| **DisconnectType** | **string** | The reason the participant was disconnected from the conversation. | [optional] |
| **Held** | **bool?** | Value is true when the participant is on hold. | [optional] |
| **WrapupRequired** | **bool?** | Value is true when the participant requires wrap-up. | [optional] |
| **WrapupPrompt** | **string** | The wrap-up prompt indicating the type of wrap-up to be performed. | [optional] |
| **User** | [**UriReference**](UriReference.html) | The PureCloud user for this participant. | [optional] |
| **Queue** | [**UriReference**](UriReference.html) | The PureCloud queue for this participant. | [optional] |
| **Attributes** | **Dictionary&lt;string, string&gt;** | A list of ad-hoc attributes for the participant. | [optional] |
| **ErrorInfo** | [**ErrorBody**](ErrorBody.html) | If the conversation ends in error, contains additional error details. | [optional] |
| **Script** | [**UriReference**](UriReference.html) | The Engage script that should be used by this participant. | [optional] |
| **WrapupTimeoutMs** | **int?** | The amount of time the participant has to complete wrap-up. | [optional] |
| **WrapupSkipped** | **bool?** | Value is true when the participant has skipped wrap-up. | [optional] |
| **Provider** | **string** | The source provider for the communication. | [optional] |
| **ExternalContact** | [**UriReference**](UriReference.html) | If this participant represents an external contact, then this will be the reference for the external contact. | [optional] |
| **ExternalOrganization** | [**UriReference**](UriReference.html) | If this participant represents an external org, then this will be the reference for the external org. | [optional] |
| **Wrapup** | [**Wrapup**](Wrapup.html) | Wrapup for this participant, if it has been applied. | [optional] |
| **Peer** | **string** | The peer communication corresponding to a matching leg for this communication. | [optional] |
| **OutboundPreview** | [**DialerPreview**](DialerPreview.html) | The outbound preview associated with this callback. | [optional] |
| **Voicemail** | [**Voicemail**](Voicemail.html) | The voicemail associated with this callback. | [optional] |
| **CallbackNumbers** | **List&lt;string&gt;** | The list of phone number to use for this callback. | [optional] |
| **CallbackUserName** | **string** | The name of the callback target. | [optional] |
| **SkipEnabled** | **bool?** | If true, the callback can be skipped | [optional] |
| **TimeoutSeconds** | **int?** | Duration in seconds before the callback will be auto-dialed. | [optional] |
| **AutomatedCallbackConfigId** | **string** | The id of the config for automatically placing the callback (and handling the disposition). If absent, the callback will not be placed automatically but routed to an agent as per normal. | [optional] |
| **CallbackScheduledTime** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ | [optional] |
{: class="table table-striped"}


