// <auto-generated>
// DO NOT EDIT
// </auto-generated>

using System.CodeDom.Compiler;
using WowPacketParser.Misc;
using WowPacketParser.Store.Objects.UpdateFields;

namespace WowPacketParserModule.V10_0_0_46181.UpdateFields.V10_2_7_54577
{
    [GeneratedCode("UpdateFieldCodeGenerator.Formats.WowPacketParserHandler", "1.0.0.0")]
    public class AzeriteItemData : IAzeriteItemData
    {
        public System.Nullable<ulong> Xp { get; set; }
        public System.Nullable<uint> Level { get; set; }
        public System.Nullable<uint> AuraLevel { get; set; }
        public System.Nullable<uint> KnowledgeLevel { get; set; }
        public System.Nullable<int> DEBUGknowledgeWeek { get; set; }
        public DynamicUpdateField<IUnlockedAzeriteEssence> UnlockedEssences { get; } = new DynamicUpdateField<IUnlockedAzeriteEssence>();
        public DynamicUpdateField<System.Nullable<uint>> UnlockedEssenceMilestones { get; } = new DynamicUpdateField<System.Nullable<uint>>();
        public System.Nullable<bool> Enabled { get; set; }
        public DynamicUpdateField<ISelectedAzeriteEssences> SelectedEssences { get; } = new DynamicUpdateField<ISelectedAzeriteEssences>();
    }
}

