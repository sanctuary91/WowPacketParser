using WowPacketParser.Messages.CliChat;
using WowPacketParser.Messages.Submessages;

namespace WowPacketParser.Messages.Client
{
    public unsafe struct ClientSceneObjectEvent
    {
        public CliSceneObjectEvent SceneEvent;
        public ulong SceneObjectGUID;
    }
}