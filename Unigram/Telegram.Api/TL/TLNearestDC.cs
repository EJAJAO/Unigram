// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLNearestDC : TLObject 
	{
		public String Country { get; set; }
		public Int32 ThisDC { get; set; }
		public Int32 NearestDC { get; set; }

		public TLNearestDC() { }
		public TLNearestDC(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.NearestDC; } }

		public override void Read(TLBinaryReader from)
		{
			Country = from.ReadString();
			ThisDC = from.ReadInt32();
			NearestDC = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x8E1A1775);
			to.Write(Country);
			to.Write(ThisDC);
			to.Write(NearestDC);
		}
	}
}