using System;

// Token: 0x0200001A RID: 26
internal abstract class Class32
{
	// Token: 0x0600012F RID: 303 RVA: 0x001AA8BD File Offset: 0x001A44BD
	public static uint smethod_0(uint uint_9)
	{
		uint_9 -= 2U;
		if (uint_9 < 4U)
		{
			return uint_9;
		}
		return 3U;
	}

	// Token: 0x0400009E RID: 158
	public const uint uint_0 = 12U;

	// Token: 0x0400009F RID: 159
	public const int int_0 = 6;

	// Token: 0x040000A0 RID: 160
	private const int int_1 = 2;

	// Token: 0x040000A1 RID: 161
	public const uint uint_1 = 4U;

	// Token: 0x040000A2 RID: 162
	public const uint uint_2 = 2U;

	// Token: 0x040000A3 RID: 163
	public const int int_2 = 4;

	// Token: 0x040000A4 RID: 164
	public const uint uint_3 = 4U;

	// Token: 0x040000A5 RID: 165
	public const uint uint_4 = 14U;

	// Token: 0x040000A6 RID: 166
	public const uint uint_5 = 128U;

	// Token: 0x040000A7 RID: 167
	public const int int_3 = 4;

	// Token: 0x040000A8 RID: 168
	public const uint uint_6 = 16U;

	// Token: 0x040000A9 RID: 169
	public const int int_4 = 3;

	// Token: 0x040000AA RID: 170
	public const int int_5 = 3;

	// Token: 0x040000AB RID: 171
	public const int int_6 = 8;

	// Token: 0x040000AC RID: 172
	public const uint uint_7 = 8U;

	// Token: 0x040000AD RID: 173
	public const uint uint_8 = 8U;

	// Token: 0x02000042 RID: 66
	public struct Struct0
	{
		// Token: 0x060002C9 RID: 713 RVA: 0x001AA972 File Offset: 0x001A4572
		public void method_0()
		{
			this.uint_0 = 0U;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x001B8688 File Offset: 0x001B2288
		public void method_1()
		{
			if (this.uint_0 < 4U)
			{
				this.uint_0 = 0U;
				return;
			}
			if (this.uint_0 < 10U)
			{
				this.uint_0 -= 3U;
				return;
			}
			this.uint_0 -= 6U;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x001AA982 File Offset: 0x001A4582
		public void method_2()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 7U : 10U);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x001AA9A9 File Offset: 0x001A45A9
		public void method_3()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 8U : 11U);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x001AA9D0 File Offset: 0x001A45D0
		public void method_4()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 9U : 11U);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x001AA9F7 File Offset: 0x001A45F7
		public bool method_5()
		{
			return this.uint_0 < 7U;
		}

		// Token: 0x04000109 RID: 265
		public uint uint_0;
	}
}
