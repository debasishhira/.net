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

	public struct RobotArm_aa7ea8e0044f0964eb9c782a689ca1b1_UnityEngine__char_46_Animator__char_46_SetTrigger_d935ef02_354c_46c2_bdb5_dc4086cefeb7 : IEntityCommand
	{
		public string name;

		public MessageTarget Routing => MessageTarget.All;
		public uint GetComponentType() => Definition.InternalRobotArm_aa7ea8e0044f0964eb9c782a689ca1b1_UnityEngine__char_46_Animator__char_46_SetTrigger_d935ef02_354c_46c2_bdb5_dc4086cefeb7;

		public RobotArm_aa7ea8e0044f0964eb9c782a689ca1b1_UnityEngine__char_46_Animator__char_46_SetTrigger_d935ef02_354c_46c2_bdb5_dc4086cefeb7
		(
			string dataname
		)
		{
			name = dataname;
		}

		public static void Serialize(RobotArm_aa7ea8e0044f0964eb9c782a689ca1b1_UnityEngine__char_46_Animator__char_46_SetTrigger_d935ef02_354c_46c2_bdb5_dc4086cefeb7 commandData, IOutProtocolBitStream bitStream)
		{
			bitStream.WriteShortString(commandData.name);
		}

		public static RobotArm_aa7ea8e0044f0964eb9c782a689ca1b1_UnityEngine__char_46_Animator__char_46_SetTrigger_d935ef02_354c_46c2_bdb5_dc4086cefeb7 Deserialize(IInProtocolBitStream bitStream)
		{
			var dataname = bitStream.ReadShortString();

			return new RobotArm_aa7ea8e0044f0964eb9c782a689ca1b1_UnityEngine__char_46_Animator__char_46_SetTrigger_d935ef02_354c_46c2_bdb5_dc4086cefeb7
			(
				dataname
			){};
		}
	}
}