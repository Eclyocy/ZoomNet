using Newtonsoft.Json;
using System;

namespace ZoomNet.Models
{
	/// <summary>
	/// Metrics of a participant.
	/// </summary>
	public class ReportMeetingParticipant : ReportParticipant
	{
		/// <summary>
		/// Gets or sets the RegistrantID of the participant.
		/// </summary>
		/// <value>
		/// The RegistrantID of the participant.  Only returned if registrant_id is included in the include_fields query parameter.
		/// </value>
		[JsonProperty(PropertyName = "registrant_id")]
		public string RegistrantID { get; set; }
	}
}
