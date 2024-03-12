using WowPacketParser.Misc;
using WowPacketParser.Store.Objects.UpdateFields;

// This file is automatically generated, DO NOT EDIT

namespace WowPacketParserModule.V4_4_0_53627.UpdateFields.V4_4_0_53627
{
    public class CorpseData : ICorpseData
    {
        public System.Nullable<uint> DynamicFlags { get; set; }
        public WowGuid Owner { get; set; }
        public WowGuid PartyGUID { get; set; }
        public WowGuid GuildGUID { get; set; }
        public System.Nullable<uint> DisplayID { get; set; }
        public System.Nullable<uint>[] Items { get; } = new System.Nullable<uint>[19];
        public System.Nullable<byte> RaceID { get; set; }
        public System.Nullable<byte> Sex { get; set; }
        public System.Nullable<byte> Class { get; set; }
        public System.Nullable<uint> Flags { get; set; }
        public System.Nullable<int> FactionTemplate { get; set; }
        public DynamicUpdateField<IChrCustomizationChoice> Customizations { get; } = new DynamicUpdateField<IChrCustomizationChoice>();
    }
}

