// Copyright (c) coherence ApS.
// For all coherence generated code, the coherence SDK license terms apply. See the license file in the coherence Package root folder for more information.

// <auto-generated>
// Generated file. DO NOT EDIT!
// </auto-generated>
namespace Coherence.Generated
{
	using Coherence.ProtocolDef;
	using Coherence.Serializer;
	using Coherence.SimulationFrame;
	using Coherence.Entity;
	using Coherence.Utils;
	using Coherence.Brook;
	using Coherence.Toolkit;
	using UnityEngine;

	public struct RobotArm_id4_UnityEngine__char_46_Transform_3110171900669979710 : ICoherenceComponentData
	{
		public Quaternion rotation;

		public override string ToString()
		{
			return $"RobotArm_id4_UnityEngine__char_46_Transform_3110171900669979710(rotation: {rotation})";
		}

		public uint GetComponentType() => Definition.InternalRobotArm_id4_UnityEngine__char_46_Transform_3110171900669979710;

		public const int order = 0;

		public int GetComponentOrder() => order;

		public AbsoluteSimulationFrame Frame;
	

		public void SetSimulationFrame(AbsoluteSimulationFrame frame)
		{
			Frame = frame;
		}

		public AbsoluteSimulationFrame GetSimulationFrame() => Frame;

		public ICoherenceComponentData MergeWith(ICoherenceComponentData data, uint mask)
		{
			var other = (RobotArm_id4_UnityEngine__char_46_Transform_3110171900669979710)data;
			if ((mask & 0x01) != 0)
			{
				Frame = other.Frame;
				rotation = other.rotation;
			}
			mask >>= 1;
			return this;
		}

		public uint DiffWith(ICoherenceComponentData data)
		{
			throw new System.NotSupportedException($"{nameof(DiffWith)} is not supported in Unity");

		}

		public static void Serialize(RobotArm_id4_UnityEngine__char_46_Transform_3110171900669979710 data, uint mask, IOutProtocolBitStream bitStream)
		{
			if (bitStream.WriteMask((mask & 0x01) != 0))
			{
				bitStream.WriteQuaternion((data.rotation.ToCoreQuaternion()), 12);
			}
			mask >>= 1;
		}

		public static (RobotArm_id4_UnityEngine__char_46_Transform_3110171900669979710, uint, uint?) Deserialize(InProtocolBitStream bitStream)
		{
			var mask = (uint)0;
			var val = new RobotArm_id4_UnityEngine__char_46_Transform_3110171900669979710();
	
			if (bitStream.ReadMask())
			{
				val.rotation = (bitStream.ReadQuaternion(12)).ToUnityQuaternion();
				mask |= 0b00000000000000000000000000000001;
			}
			return (val, mask, null);
		}
		public static (RobotArm_id4_UnityEngine__char_46_Transform_3110171900669979710, uint, uint?) DeserializeArchetypeRobotArm_aa7ea8e0044f0964eb9c782a689ca1b1_RobotArm_id4_UnityEngine__char_46_Transform_3110171900669979710_LOD0(InProtocolBitStream bitStream)
		{
			var mask = (uint)0;
			var val = new RobotArm_id4_UnityEngine__char_46_Transform_3110171900669979710();
			if (bitStream.ReadMask())
			{
				val.rotation = (bitStream.ReadQuaternion(12)).ToUnityQuaternion();
				mask |= 0b00000000000000000000000000000001;
			}

			return (val, mask, 0);
		}

		/// <summary>
		/// Resets byte array references to the local array instance that is kept in the lastSentData.
		/// If the array content has changed but remains of same length, the new content is copied into the local array instance.
		/// If the array length has changed, the array is cloned and overwrites the local instance.
		/// If the array has not changed, the reference is reset to the local array instance.
		/// Otherwise, changes to other fields on the component might cause the local array instance reference to become permanently lost.
		/// </summary>
		public void ResetByteArrays(ICoherenceComponentData lastSent, uint mask)
		{
			var last = lastSent as RobotArm_id4_UnityEngine__char_46_Transform_3110171900669979710?;
	
		}
	}
}