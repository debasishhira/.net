// Copyright (c) coherence ApS.
// For all coherence generated code, the coherence SDK license terms apply. See the license file in the coherence Package root folder for more information.

// <auto-generated>
// Generated file. DO NOT EDIT!
// </auto-generated>
namespace Coherence.Generated
{
	using Coherence.ProtocolDef;
	using Coherence.Serializer;
	using Coherence.Brook;
	using UnityEngine;
	using Coherence.Entity;

	public struct FlowersCounter_id3_Counter__char_46_ResetToZero_2f75e994_88a8_4da2_aebe_765c3648d9d8 : IEntityCommand
	{

		public MessageTarget Routing => MessageTarget.All;
		public uint GetComponentType() => Definition.InternalFlowersCounter_id3_Counter__char_46_ResetToZero_2f75e994_88a8_4da2_aebe_765c3648d9d8;

		public static void Serialize(FlowersCounter_id3_Counter__char_46_ResetToZero_2f75e994_88a8_4da2_aebe_765c3648d9d8 commandData, IOutProtocolBitStream bitStream)
		{
		}

		public static FlowersCounter_id3_Counter__char_46_ResetToZero_2f75e994_88a8_4da2_aebe_765c3648d9d8 Deserialize(IInProtocolBitStream bitStream)
		{

			return new FlowersCounter_id3_Counter__char_46_ResetToZero_2f75e994_88a8_4da2_aebe_765c3648d9d8
			(
			){};
		}
	}
}