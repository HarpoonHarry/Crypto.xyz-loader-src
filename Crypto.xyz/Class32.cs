using System;

// Token: 0x0200001F RID: 31
internal abstract class Class32
{
	// Token: 0x06000140 RID: 320 RVA: 0x001849F7 File Offset: 0x0017F7F7
	public static uint smethod_0(uint uint_9)
	{
		uint_9 -= 2U;
		if (uint_9 < 4U)
		{
			return uint_9;
		}
		return 3U;
	}

	// Token: 0x0400009B RID: 155
	public const uint uint_0 = 12U;

	// Token: 0x0400009C RID: 156
	public const int int_0 = 6;

	// Token: 0x0400009D RID: 157
	private const int int_1 = 2;

	// Token: 0x0400009E RID: 158
	public const uint uint_1 = 4U;

	// Token: 0x0400009F RID: 159
	public const uint uint_2 = 2U;

	// Token: 0x040000A0 RID: 160
	public const int int_2 = 4;

	// Token: 0x040000A1 RID: 161
	public const uint uint_3 = 4U;

	// Token: 0x040000A2 RID: 162
	public const uint uint_4 = 14U;

	// Token: 0x040000A3 RID: 163
	public const uint uint_5 = 128U;

	// Token: 0x040000A4 RID: 164
	public const int int_3 = 4;

	// Token: 0x040000A5 RID: 165
	public const uint uint_6 = 16U;

	// Token: 0x040000A6 RID: 166
	public const int int_4 = 3;

	// Token: 0x040000A7 RID: 167
	public const int int_5 = 3;

	// Token: 0x040000A8 RID: 168
	public const int int_6 = 8;

	// Token: 0x040000A9 RID: 169
	public const uint uint_7 = 8U;

	// Token: 0x040000AA RID: 170
	public const uint uint_8 = 8U;

	// Token: 0x02000047 RID: 71
	public struct Struct0
	{
		// Token: 0x060002DA RID: 730 RVA: 0x00184AAC File Offset: 0x0017F8AC
		public void method_0()
		{
			this.uint_0 = 0U;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00192AF4 File Offset: 0x0018D8F4
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

		// Token: 0x060002DC RID: 732 RVA: 0x00184ABC File Offset: 0x0017F8BC
		public void method_2()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 7U : 10U);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00184AE3 File Offset: 0x0017F8E3
		public void method_3()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 8U : 11U);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00184B0A File Offset: 0x0017F90A
		public void method_4()
		{
			this.uint_0 = ((this.uint_0 < 7U) ? 9U : 11U);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00184B31 File Offset: 0x0017F931
		public bool method_5()
		{
			return this.uint_0 < 7U;
		}

		// Token: 0x04000106 RID: 262
		public uint uint_0;
	}
}
