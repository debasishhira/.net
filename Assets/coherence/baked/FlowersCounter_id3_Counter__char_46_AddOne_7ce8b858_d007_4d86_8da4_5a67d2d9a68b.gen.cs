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

	public struct FlowersCounter_id3_Counter__char_46_AddOne_7ce8b858_d007_4d86_8da4_5a67d2d9a68b : IEntityCommand
	{

		public MessageTarget Routing => MessageTarget.All;
		public uint GetComponentType() => Definition.InternalFlowersCounter_id3_Counter__char_46_AddOne_7ce8b858_d007_4d86_8da4_5a67d2d9a68b;

		public static void Serialize(FlowersCounter_id3_Counter__char_46_AddOne_7ce8b858_d007_4d86_8da4_5a67d2d9a68b commandData, IOutProtocolBitStream bitStream)
		{
		}

		public static FlowersCounter_id3_Counter__char_46_AddOne_7ce8b858_d007_4d86_8da4_5a67d2d9a68b Deserialize(IInProtocolBitStream bitStream)
		{

			return new FlowersCounter_id3_Counter__char_46_AddOne_7ce8b858_d007_4d86_8da4_5a67d2d9a68b
			(
			){};
		}
	}
}
