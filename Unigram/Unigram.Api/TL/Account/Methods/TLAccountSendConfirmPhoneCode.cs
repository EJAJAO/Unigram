// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Account.Methods
{
	/// <summary>
	/// RCP method account.sendConfirmPhoneCode.
	/// Returns <see cref="Telegram.Api.TL.TLAuthSentCode"/>
	/// </summary>
	public partial class TLAccountSendConfirmPhoneCode : TLObject
	{
		[Flags]
		public enum Flag : Int32
		{
			AllowFlashcall = (1 << 0),
			CurrentNumber = (1 << 0),
		}

		public bool IsAllowFlashcall { get { return Flags.HasFlag(Flag.AllowFlashcall); } set { Flags = value ? (Flags | Flag.AllowFlashcall) : (Flags & ~Flag.AllowFlashcall); } }
		public bool HasCurrentNumber { get { return Flags.HasFlag(Flag.CurrentNumber); } set { Flags = value ? (Flags | Flag.CurrentNumber) : (Flags & ~Flag.CurrentNumber); } }

		public Flag Flags { get; set; }
		public String Hash { get; set; }
		public Boolean? CurrentNumber { get; set; }

		public TLAccountSendConfirmPhoneCode() { }
		public TLAccountSendConfirmPhoneCode(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AccountSendConfirmPhoneCode; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			Hash = from.ReadString();
			if (HasCurrentNumber) CurrentNumber = from.ReadBoolean();
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.WriteInt32((Int32)Flags);
			to.WriteString(Hash ?? string.Empty);
			if (HasCurrentNumber) to.WriteBoolean(CurrentNumber.Value);
		}

		private void UpdateFlags()
		{
			HasCurrentNumber = CurrentNumber != null;
		}
	}
}