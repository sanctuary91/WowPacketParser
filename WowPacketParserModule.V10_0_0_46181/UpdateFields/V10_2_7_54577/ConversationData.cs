// <auto-generated>
// DO NOT EDIT
// </auto-generated>

using System.CodeDom.Compiler;
using WowPacketParser.Misc;
using WowPacketParser.Store.Objects.UpdateFields;

namespace WowPacketParserModule.V10_0_0_46181.UpdateFields.V10_2_7_54577
{
    [GeneratedCode("UpdateFieldCodeGenerator.Formats.WowPacketParserHandler", "1.0.0.0")]
    public class ConversationData : IMutableConversationData
    {
        public System.Nullable<int> LastLineEndTime { get; set; }
        public System.Nullable<uint> Progress { get; set; }
        public IConversationLine[] Lines { get; set; }
        public System.Nullable<uint> Flags { get; set; }
        public System.Nullable<bool> DontPlayBroadcastTextSounds { get; set; }
        public DynamicUpdateField<IConversationActor> Actors { get; } = new DynamicUpdateField<IConversationActor>();
    }
}

