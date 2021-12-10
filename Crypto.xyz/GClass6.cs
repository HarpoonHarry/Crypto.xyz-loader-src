using System;
using System.IO;

// Token: 0x02000020 RID: 32
public class GClass6
{
	// Token: 0x06000142 RID: 322 RVA: 0x0018F648 File Offset: 0x0018A448
	public GClass6()
	{
		this.uint_1 = uint.MaxValue;
		int num = 0;
		while ((long)num < 4L)
		{
			this.struct3_0[num] = new Struct3(6);
			num++;
		}
	}

	// Token: 0x06000143 RID: 323 RVA: 0x0018F7B0 File Offset: 0x0018A5B0
	private void method_0(uint uint_4)
	{
		if (this.uint_1 != uint_4)
		{
			this.uint_1 = uint_4;
			this.uint_2 = Math.Max(this.uint_1, 1U);
			uint uint_5 = Math.Max(this.uint_2, 4096U);
			this.gclass7_0.method_0(uint_5);
		}
	}

	// Token: 0x06000144 RID: 324 RVA: 0x0018F820 File Offset: 0x0018A620
	private void method_1(int int_0, int int_1)
	{
		if (int_0 > 8)
		{
			throw new ArgumentException("lp > 8");
		}
		if (int_1 > 8)
		{
			throw new ArgumentException("lc > 8");
		}
		this.class34_0.method_0(int_0, int_1);
	}

	// Token: 0x06000145 RID: 325 RVA: 0x0018F870 File Offset: 0x0018A670
	private void method_2(int int_0)
	{
		if (int_0 > 4)
		{
			throw new ArgumentException("pb > Base.KNumPosStatesBitsMax");
		}
		uint num = 1U << int_0;
		this.class33_0.method_0(num);
		this.class33_1.method_0(num);
		this.uint_3 = num - 1U;
	}

	// Token: 0x06000146 RID: 326 RVA: 0x0018F8E0 File Offset: 0x0018A6E0
	private void method_3(Stream stream_0, Stream stream_1)
	{
		this.class35_0.method_0(stream_0);
		this.gclass7_0.method_1(stream_1, false);
		for (;;)
		{
			for (uint num = 0U; num <= this.uint_3; num += 1U)
			{
				uint num2 = 0U + num;
				this.struct2_0[(int)num2].method_0();
				this.struct2_5[(int)num2].method_0();
			}
			this.struct2_1[0].method_0();
			this.struct2_2[0].method_0();
			this.struct2_3[0].method_0();
			this.struct2_4[0].method_0();
		}
	}

	// Token: 0x06000147 RID: 327 RVA: 0x0018440B File Offset: 0x0017F20B
	public void method_4(Stream stream_0, Stream stream_1, long long_0)
	{
	}

	// Token: 0x06000148 RID: 328 RVA: 0x0018F984 File Offset: 0x0018A784
	public void method_5(byte[] byte_0)
	{
		if (byte_0.Length < 5)
		{
			throw new ArgumentException("properties.Length < 5");
		}
		int int_ = (int)(byte_0[0] % 9);
		byte b = byte_0[0] / 9;
		int int_2 = (int)(b % 5);
		int num = (int)(b / 5);
		if (num > 4)
		{
			throw new ArgumentException("pb > Base.kNumPosStatesBitsMax");
		}
		uint num2 = 0U;
		for (int i = 0; i < 4; i++)
		{
			num2 += (uint)((uint)byte_0[1 + i] << i * 8);
		}
		this.method_0(num2);
		this.method_1(int_2, int_);
		this.method_2(num);
	}

	// Token: 0x040000AB RID: 171
	private uint uint_0 = 1U;

	// Token: 0x040000AC RID: 172
	private readonly GClass7 gclass7_0 = new GClass7();

	// Token: 0x040000AD RID: 173
	private readonly Class35 class35_0 = new Class35();

	// Token: 0x040000AE RID: 174
	private readonly Struct2[] struct2_0 = new Struct2[192];

	// Token: 0x040000AF RID: 175
	private readonly Struct2[] struct2_1 = new Struct2[12];

	// Token: 0x040000B0 RID: 176
	private readonly Struct2[] struct2_2 = new Struct2[12];

	// Token: 0x040000B1 RID: 177
	private readonly Struct2[] struct2_3 = new Struct2[12];

	// Token: 0x040000B2 RID: 178
	private readonly Struct2[] struct2_4 = new Struct2[12];

	// Token: 0x040000B3 RID: 179
	private readonly Struct2[] struct2_5 = new Struct2[192];

	// Token: 0x040000B4 RID: 180
	private readonly Struct3[] struct3_0 = new Struct3[4];

	// Token: 0x040000B5 RID: 181
	private readonly Struct2[] struct2_6 = new Struct2[114];

	// Token: 0x040000B6 RID: 182
	private Struct3 struct3_1 = new Struct3(4);

	// Token: 0x040000B7 RID: 183
	private readonly GClass6.Class33 class33_0 = new GClass6.Class33();

	// Token: 0x040000B8 RID: 184
	private readonly GClass6.Class33 class33_1 = new GClass6.Class33();

	// Token: 0x040000B9 RID: 185
	private readonly GClass6.Class34 class34_0 = new GClass6.Class34();

	// Token: 0x040000BA RID: 186
	private uint uint_1;

	// Token: 0x040000BB RID: 187
	private uint uint_2;

	// Token: 0x040000BC RID: 188
	private uint uint_3;

	// Token: 0x02000048 RID: 72
	private class Class33
	{
		// Token: 0x060002E0 RID: 736 RVA: 0x00192B64 File Offset: 0x0018D964
		public void method_0(uint uint_1)
		{
			for (uint num = this.uint_0; num < uint_1; num += 1U)
			{
				this.struct3_0[(int)num] = new Struct3(3);
				this.struct3_1[(int)num] = new Struct3(3);
			}
			this.uint_0 = uint_1;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00192BE0 File Offset: 0x0018D9E0
		public void method_1()
		{
			this.struct2_0.method_0();
			while (0U < this.uint_0)
			{
				this.struct3_0[0].method_0();
				this.struct3_1[0].method_0();
			}
			this.struct2_1.method_0();
			this.struct3_2.method_0();
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00192C3C File Offset: 0x0018DA3C
		public uint method_2(Class35 class35_0, uint uint_1)
		{
			if (this.struct2_0.method_1(class35_0) == 0U)
			{
				return this.struct3_0[(int)uint_1].method_1(class35_0);
			}
			uint num = 8U;
			if (this.struct2_1.method_1(class35_0) == 0U)
			{
				num += this.struct3_1[(int)uint_1].method_1(class35_0);
			}
			else
			{
				num += 8U;
				num += this.struct3_2.method_1(class35_0);
			}
			return num;
		}

		// Token: 0x04000107 RID: 263
		private Struct2 struct2_0;

		// Token: 0x04000108 RID: 264
		private Struct2 struct2_1;

		// Token: 0x04000109 RID: 265
		private readonly Struct3[] struct3_0 = new Struct3[16];

		// Token: 0x0400010A RID: 266
		private readonly Struct3[] struct3_1 = new Struct3[16];

		// Token: 0x0400010B RID: 267
		private Struct3 struct3_2 = new Struct3(8);

		// Token: 0x0400010C RID: 268
		private uint uint_0;
	}

	// Token: 0x02000049 RID: 73
	private class Class34
	{
		// Token: 0x060002E4 RID: 740 RVA: 0x00192D3C File Offset: 0x0018DB3C
		public void method_0(int int_2, int int_3)
		{
			if (this.struct1_0 != null && this.int_0 == int_3 && this.int_1 == int_2)
			{
				return;
			}
			this.int_1 = int_2;
			this.uint_1 = (1U << int_2) - 1U;
			this.int_0 = int_3;
			uint num = 1U << this.int_0 + this.int_1;
			this.struct1_0 = new GClass6.Class34.Struct1[num];
			for (uint num2 = 0U; num2 < num; num2 += 1U)
			{
				this.struct1_0[(int)num2].method_0();
			}
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00192DC4 File Offset: 0x0018DBC4
		public void method_1()
		{
			uint num = 1U << this.int_0 + this.int_1;
			while (0U < num)
			{
				this.struct1_0[0].method_1();
			}
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00184B43 File Offset: 0x0017F943
		private uint method_2(uint uint_2, byte byte_0)
		{
			return ((uint_2 & this.uint_1) << this.int_0) + (uint)(byte_0 >> 8 - this.int_0);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00184B7E File Offset: 0x0017F97E
		public byte method_3(Class35 class35_0, uint uint_2, byte byte_0)
		{
			return this.struct1_0[(int)this.method_2(uint_2, byte_0)].method_2(class35_0);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00184BA8 File Offset: 0x0017F9A8
		public byte method_4(Class35 class35_0, uint uint_2, byte byte_0, byte byte_1)
		{
			return this.struct1_0[(int)this.method_2(uint_2, byte_0)].method_3(class35_0, byte_1);
		}

		// Token: 0x0400010D RID: 269
		private uint uint_0 = 1U;

		// Token: 0x0400010E RID: 270
		private GClass6.Class34.Struct1[] struct1_0;

		// Token: 0x0400010F RID: 271
		private int int_0;

		// Token: 0x04000110 RID: 272
		private int int_1;

		// Token: 0x04000111 RID: 273
		private uint uint_1;

		// Token: 0x0200004A RID: 74
		private struct Struct1
		{
			// Token: 0x060002EA RID: 746 RVA: 0x00184BEF File Offset: 0x0017F9EF
			public void method_0()
			{
				this.struct2_0 = new Struct2[768];
			}

			// Token: 0x060002EB RID: 747 RVA: 0x00192DFC File Offset: 0x0018DBFC
			public void method_1()
			{
				for (int i = 0; i < 768; i++)
				{
					this.struct2_0[i].method_0();
				}
			}

			// Token: 0x060002EC RID: 748 RVA: 0x00192E44 File Offset: 0x0018DC44
			public byte method_2(Class35 class35_0)
			{
				uint num = 1U;
				do
				{
					num = (num << 1 | this.struct2_0[(int)num].method_1(class35_0));
				}
				while (num < 256U);
				return (byte)num;
			}

			// Token: 0x060002ED RID: 749 RVA: 0x00192E94 File Offset: 0x0018DC94
			public byte method_3(Class35 class35_0, byte byte_0)
			{
				uint num = 1U;
				for (;;)
				{
					uint num2 = (uint)(byte_0 >> 7 & 1);
					byte_0 = (byte)(byte_0 << 1);
					uint num3 = this.struct2_0[(int)((1U + num2 << 8) + num)].method_1(class35_0);
					num = (num << 1 | num3);
					if (num2 != num3)
					{
						break;
					}
					if (num >= 256U)
					{
						goto IL_C0;
					}
				}
				while (num < 256U)
				{
					num = (num << 1 | this.struct2_0[(int)num].method_1(class35_0));
				}
				IL_C0:
				return (byte)num;
			}

			// Token: 0x04000112 RID: 274
			private Struct2[] struct2_0;
		}
	}
}
