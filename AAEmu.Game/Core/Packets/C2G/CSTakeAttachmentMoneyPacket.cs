using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSTakeAttachmentMoneyPacket : GamePacket
    {
        public CSTakeAttachmentMoneyPacket() : base(CSOffsets.CSTakeAttachmentMoneyPacket, 5)
        {
        }

        public override void Read(PacketStream stream)
        {
            var mailId = stream.ReadInt64();
            _log.Debug("TakeAttachmentMoney, mailId: {0}", mailId);
        }
    }
}
