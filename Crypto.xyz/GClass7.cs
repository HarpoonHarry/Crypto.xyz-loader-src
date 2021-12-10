using System;
using System.IO;

// Token: 0x02000024 RID: 36
public class GClass7
{
	// Token: 0x06000154 RID: 340 RVA: 0x0018FE50 File Offset: 0x0018AC50
	public void method_0(uint uint_5)
	{
		if (this.uint_1 != uint_5)
		{
			this.byte_0 = new byte[uint_5];
		}
		this.uint_1 = uint_5;
		this.uint_0 = 0U;
		this.uint_2 = 0U;
	}

	// Token: 0x06000155 RID: 341 RVA: 0x0018FEA8 File Offset: 0x0018ACA8
	public void method_1(Stream stream_1, bool bool_0)
	{
		this.method_2();
		this.stream_0 = stream_1;
		if (!bool_0)
		{
			this.uint_2 = 0U;
			this.uint_0 = 0U;
			this.uint_4 = 0U;
		}
	}

	// Token: 0x06000156 RID: 342 RVA: 0x00184A7E File Offset: 0x0017F87E
	public void method_2()
	{
		this.method_3();
		this.stream_0 = null;
	}

	// Token: 0x06000157 RID: 343 RVA: 0x0018FEFC File Offset: 0x0018ACFC
	public void method_3()
	{
		uint num = this.uint_0 - this.uint_2;
		if (num == 0U)
		{
			return;
		}
		this.stream_0.Write(this.byte_0, (int)this.uint_2, (int)num);
		if (this.uint_0 >= this.uint_1)
		{
			this.uint_0 = 0U;
		}
		this.uint_2 = this.uint_0;
	}

	// Token: 0x06000158 RID: 344 RVA: 0x0018FF80 File Offset: 0x0018AD80
	public void method_4(uint uint_5, uint uint_6)
	{
		uint num = this.uint_0 - uint_5 - 1U;
		if (num >= this.uint_1)
		{
			num += this.uint_1;
		}
		while (uint_6 > 0U)
		{
			if (num >= this.uint_1)
			{
				num = 0U;
			}
			byte[] array = this.byte_0;
			uint num2 = this.uint_0;
			this.uint_0 = num2 + 1U;
			array[(int)num2] = this.byte_0[(int)num++];
			if (this.uint_0 >= this.uint_1)
			{
				this.method_3();
			}
			uint_6 -= 1U;
		}
	}

	// Token: 0x06000159 RID: 345 RVA: 0x00190068 File Offset: 0x0018AE68
	public void method_5(byte byte_1)
	{
		byte[] array = this.byte_0;
		uint num = this.uint_0;
		this.uint_0 = num + 1U;
		array[(int)num] = byte_1;
		if (this.uint_0 >= this.uint_1)
		{
			this.method_3();
		}
	}

	// Token: 0x0600015A RID: 346 RVA: 0x001900C4 File Offset: 0x0018AEC4
	public byte method_6(uint uint_5)
	{
		uint num = this.uint_0 - uint_5 - 1U;
		if (num >= this.uint_1)
		{
			num += this.uint_1;
		}
		return this.byte_0[(int)num];
	}

	// Token: 0x040000C8 RID: 200
	private byte[] byte_0;

	// Token: 0x040000C9 RID: 201
	private uint uint_0;

	// Token: 0x040000CA RID: 202
	private uint uint_1;

	// Token: 0x040000CB RID: 203
	private uint uint_2;

	// Token: 0x040000CC RID: 204
	private Stream stream_0;

	// Token: 0x040000CD RID: 205
	private uint uint_3 = 1U;

	// Token: 0x040000CE RID: 206
	public uint uint_4;
}
