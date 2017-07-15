// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLKeyboardButtonGame : TLKeyboardButtonBase 
	{
		public TLKeyboardButtonGame() { }
		public TLKeyboardButtonGame(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.KeyboardButtonGame; } }

		public override void Read(TLBinaryReader from)
		{
			Text = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x50F41CCF);
			to.Write(Text);
		}
	}
}