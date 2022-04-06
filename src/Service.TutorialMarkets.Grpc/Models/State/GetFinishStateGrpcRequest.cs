using System;
using System.Runtime.Serialization;

namespace Service.TutorialMarkets.Grpc.Models.State
{
	[DataContract]
	public class GetFinishStateGrpcRequest
	{
		[DataMember(Order = 1)]
		public string UserId { get; set; }

		[DataMember(Order = 2)]
		public int? Unit { get; set; }
	}
}
