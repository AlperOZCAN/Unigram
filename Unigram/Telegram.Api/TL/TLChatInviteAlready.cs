// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLChatInviteAlready : TLChatInviteBase 
	{
		public TLChatBase Chat { get; set; }

		public TLChatInviteAlready() { }
		public TLChatInviteAlready(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ChatInviteAlready; } }

		public override void Read(TLBinaryReader from)
		{
			Chat = TLFactory.Read<TLChatBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x5A686D7C);
			to.WriteObject(Chat);
		}
	}
}