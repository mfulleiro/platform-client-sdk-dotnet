using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// ConversationNotificationDialerPreview
    /// </summary>
    [DataContract]
    public partial class ConversationNotificationDialerPreview :  IEquatable<ConversationNotificationDialerPreview>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationNotificationDialerPreview" /> class.
        /// </summary>
        
        
        /// <param name="Id">Id.</param>
        
        
        
        /// <param name="ContactId">ContactId.</param>
        
        
        
        /// <param name="ContactListId">ContactListId.</param>
        
        
        
        /// <param name="CampaignId">CampaignId.</param>
        
        
        
        /// <param name="PhoneNumberColumns">PhoneNumberColumns.</param>
        
        
        
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        
        
        public ConversationNotificationDialerPreview(string Id = null, string ContactId = null, string ContactListId = null, string CampaignId = null, List<CampaignNotificationPhoneColumns> PhoneNumberColumns = null, Object AdditionalProperties = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Id = Id;
            
            
            
            
            
            
            
            
this.ContactId = ContactId;
            
            
            
            
            
            
            
            
this.ContactListId = ContactListId;
            
            
            
            
            
            
            
            
this.CampaignId = CampaignId;
            
            
            
            
            
            
            
            
this.PhoneNumberColumns = PhoneNumberColumns;
            
            
            
            
            
            
            
            
this.AdditionalProperties = AdditionalProperties;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ContactId
        /// </summary>
        [DataMember(Name="contactId", EmitDefaultValue=false)]
        public string ContactId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets ContactListId
        /// </summary>
        [DataMember(Name="contactListId", EmitDefaultValue=false)]
        public string ContactListId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets CampaignId
        /// </summary>
        [DataMember(Name="campaignId", EmitDefaultValue=false)]
        public string CampaignId { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets PhoneNumberColumns
        /// </summary>
        [DataMember(Name="phoneNumberColumns", EmitDefaultValue=false)]
        public List<CampaignNotificationPhoneColumns> PhoneNumberColumns { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Object AdditionalProperties { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationNotificationDialerPreview {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  ContactId: ").Append(ContactId).Append("\n");
            
            sb.Append("  ContactListId: ").Append(ContactListId).Append("\n");
            
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            
            sb.Append("  PhoneNumberColumns: ").Append(PhoneNumberColumns).Append("\n");
            
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ConversationNotificationDialerPreview);
        }

        /// <summary>
        /// Returns true if ConversationNotificationDialerPreview instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationNotificationDialerPreview to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationNotificationDialerPreview other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.ContactId == other.ContactId ||
                    this.ContactId != null &&
                    this.ContactId.Equals(other.ContactId)
                ) &&
                (
                    this.ContactListId == other.ContactListId ||
                    this.ContactListId != null &&
                    this.ContactListId.Equals(other.ContactListId)
                ) &&
                (
                    this.CampaignId == other.CampaignId ||
                    this.CampaignId != null &&
                    this.CampaignId.Equals(other.CampaignId)
                ) &&
                (
                    this.PhoneNumberColumns == other.PhoneNumberColumns ||
                    this.PhoneNumberColumns != null &&
                    this.PhoneNumberColumns.SequenceEqual(other.PhoneNumberColumns)
                ) &&
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.Equals(other.AdditionalProperties)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.ContactId != null)
                    hash = hash * 59 + this.ContactId.GetHashCode();
                
                if (this.ContactListId != null)
                    hash = hash * 59 + this.ContactListId.GetHashCode();
                
                if (this.CampaignId != null)
                    hash = hash * 59 + this.CampaignId.GetHashCode();
                
                if (this.PhoneNumberColumns != null)
                    hash = hash * 59 + this.PhoneNumberColumns.GetHashCode();
                
                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();
                
                return hash;
            }
        }
    }

}
