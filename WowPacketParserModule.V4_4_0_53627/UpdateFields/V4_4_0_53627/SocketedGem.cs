using WowPacketParser.Misc;
using WowPacketParser.Store.Objects.UpdateFields;

// This file is automatically generated, DO NOT EDIT

namespace WowPacketParserModule.V4_4_0_53627.UpdateFields.V4_4_0_53627
{
    public class SocketedGem : ISocketedGem
    {
        public System.Nullable<int> ItemID { get; set; }
        public System.Nullable<ushort>[] BonusListIDs { get; } = new System.Nullable<ushort>[16];
        public System.Nullable<byte> Context { get; set; }
    }
}

