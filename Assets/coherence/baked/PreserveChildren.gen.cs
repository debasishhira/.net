// Copyright (c) coherence ApS.
// For all coherence generated code, the coherence SDK license terms apply. See the license file in the coherence Package root folder for more information.

// <auto-generated>
// Generated file. DO NOT EDIT!
// </auto-generated>
namespace Coherence.Generated
{
    using System.Collections.Generic;
    using Coherence.ProtocolDef;
    using Coherence.Serializer;
    using Coherence.SimulationFrame;
    using Coherence.Entities;
    using Coherence.Utils;
    using Coherence.Brook;
    using Logger = Coherence.Log.Logger;
    using UnityEngine;
    using Coherence.Toolkit;
    
    public struct PreserveChildren : ICoherenceComponentData
    {
        
        public uint FieldsMask { get; set; }
        public uint StoppedMask { get; set; }
        public uint GetComponentType() => 14;
        public int PriorityLevel() => 100;
        public const int order = 0;
        public uint InitialFieldsMask() => 0b00000000000000000000000000000000;
        public bool HasFields() => false;
        public bool HasRefFields() => false;
        
        public HashSet<Entity> GetEntityRefs()
        {
            return default;
        }
        
        public IEntityMapper.Error MapToAbsolute(IEntityMapper mapper)
        {
            return IEntityMapper.Error.None;  
        }
        
        public IEntityMapper.Error MapToRelative(IEntityMapper mapper)
        {
            return IEntityMapper.Error.None;   
        }
        
        public ICoherenceComponentData Clone() => this;
        public int GetComponentOrder() => order;
        public bool IsSendOrdered() => false;
        public AbsoluteSimulationFrame Frame;
        
    
        public void SetSimulationFrame(AbsoluteSimulationFrame frame)
        {
            Frame = frame;
        }
        
        public AbsoluteSimulationFrame GetSimulationFrame() => Frame;
        
        public ICoherenceComponentData MergeWith(ICoherenceComponentData data, uint mask)
        {
            var other = (PreserveChildren)data;

            FieldsMask |= mask;
            StoppedMask &= ~(mask);

            StoppedMask |= other.StoppedMask;

            return this;
        }
        
        public uint DiffWith(ICoherenceComponentData data)
        {
            throw new System.NotSupportedException($"{nameof(DiffWith)} is not supported in Unity");
        }
        
        public static uint Serialize(PreserveChildren data, uint mask, IOutProtocolBitStream bitStream, Logger logger)
        {
            if (bitStream.WriteMask(data.StoppedMask != 0))
            {
                bitStream.WriteMaskBits(data.StoppedMask, 0);
            }

          
            return mask;
        }
        
        public static (PreserveChildren, uint) Deserialize(InProtocolBitStream bitStream)
        {
            var stoppedMask = (uint)0;
            if (bitStream.ReadMask())
            {
                stoppedMask = bitStream.ReadMaskBits(0);
            }

            var mask = (uint)0;
            var val = new PreserveChildren();
                    
            val.FieldsMask = mask;
            val.StoppedMask = stoppedMask;

            return (val, mask);
        }
        
        
        public void ResetByteArrays(ICoherenceComponentData lastSent, uint mask)
        {
            var last = lastSent as PreserveChildren?;
            
        }

        public override string ToString()
        {
            return $"PreserveChildren(Mask: {System.Convert.ToString(FieldsMask, 2).PadLeft(0, '0')}), Stopped: {System.Convert.ToString(StoppedMask, 2).PadLeft(0, '0')})";
        }
    }
    

}