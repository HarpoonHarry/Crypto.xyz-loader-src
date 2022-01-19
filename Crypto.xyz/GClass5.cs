using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

// Token: 0x02000018 RID: 24
public class GClass5
{
	// Token: 0x060000B1 RID: 177 RVA: 0x001B04AC File Offset: 0x001AA0AC
	public GClass5()
	{
		this.long_0 = Marshal.GetHINSTANCE(this.module_0).ToInt64();
		this.dictionary_0[0U] = new GClass5.Delegate0(this.method_41);
		this.dictionary_0[1U] = new GClass5.Delegate0(this.method_40);
		this.dictionary_0[2U] = new GClass5.Delegate0(this.method_71);
		this.dictionary_0[3U] = new GClass5.Delegate0(this.method_62);
		this.dictionary_0[4U] = new GClass5.Delegate0(this.method_89);
		this.dictionary_0[5U] = new GClass5.Delegate0(this.method_57);
		this.dictionary_0[6U] = new GClass5.Delegate0(this.method_56);
		this.dictionary_0[7U] = new GClass5.Delegate0(this.method_75);
		this.dictionary_0[8U] = new GClass5.Delegate0(this.method_90);
		this.dictionary_0[9U] = new GClass5.Delegate0(this.method_100);
		this.dictionary_0[10U] = new GClass5.Delegate0(this.method_106);
		this.dictionary_0[11U] = new GClass5.Delegate0(this.method_54);
		this.dictionary_0[12U] = new GClass5.Delegate0(this.method_110);
		this.dictionary_0[13U] = new GClass5.Delegate0(this.method_80);
		this.dictionary_0[14U] = new GClass5.Delegate0(this.method_42);
		this.dictionary_0[15U] = new GClass5.Delegate0(this.method_83);
		this.dictionary_0[16U] = new GClass5.Delegate0(this.method_68);
		this.dictionary_0[17U] = new GClass5.Delegate0(this.method_81);
		this.dictionary_0[18U] = new GClass5.Delegate0(this.method_102);
		this.dictionary_0[19U] = new GClass5.Delegate0(this.method_96);
		this.dictionary_0[20U] = new GClass5.Delegate0(this.method_86);
		this.dictionary_0[21U] = new GClass5.Delegate0(this.method_95);
		this.dictionary_0[22U] = new GClass5.Delegate0(this.method_97);
		this.dictionary_0[23U] = new GClass5.Delegate0(this.method_67);
		this.dictionary_0[24U] = new GClass5.Delegate0(this.method_66);
		this.dictionary_0[25U] = new GClass5.Delegate0(this.method_38);
		this.dictionary_0[26U] = new GClass5.Delegate0(this.method_70);
		this.dictionary_0[27U] = new GClass5.Delegate0(this.method_51);
		this.dictionary_0[28U] = new GClass5.Delegate0(this.method_50);
		this.dictionary_0[29U] = new GClass5.Delegate0(this.method_36);
		this.dictionary_0[30U] = new GClass5.Delegate0(this.method_99);
		this.dictionary_0[31U] = new GClass5.Delegate0(this.method_78);
		this.dictionary_0[32U] = new GClass5.Delegate0(this.method_87);
		this.dictionary_0[33U] = new GClass5.Delegate0(this.method_43);
		this.dictionary_0[34U] = new GClass5.Delegate0(this.method_98);
		this.dictionary_0[35U] = new GClass5.Delegate0(this.method_104);
		this.dictionary_0[36U] = new GClass5.Delegate0(this.method_59);
		this.dictionary_0[37U] = new GClass5.Delegate0(this.method_82);
		this.dictionary_0[38U] = new GClass5.Delegate0(this.method_84);
		this.dictionary_0[39U] = new GClass5.Delegate0(this.method_35);
		this.dictionary_0[40U] = new GClass5.Delegate0(this.method_64);
		this.dictionary_0[41U] = new GClass5.Delegate0(this.method_47);
		this.dictionary_0[42U] = new GClass5.Delegate0(this.method_103);
		this.dictionary_0[43U] = new GClass5.Delegate0(this.method_37);
		this.dictionary_0[44U] = new GClass5.Delegate0(this.method_79);
		this.dictionary_0[45U] = new GClass5.Delegate0(this.method_88);
		this.dictionary_0[46U] = new GClass5.Delegate0(this.method_109);
		this.dictionary_0[47U] = new GClass5.Delegate0(this.method_63);
		this.dictionary_0[48U] = new GClass5.Delegate0(this.method_48);
		this.dictionary_0[49U] = new GClass5.Delegate0(this.method_94);
		this.dictionary_0[50U] = new GClass5.Delegate0(this.method_77);
		this.dictionary_0[51U] = new GClass5.Delegate0(this.method_44);
		this.dictionary_0[52U] = new GClass5.Delegate0(this.method_53);
		this.dictionary_0[53U] = new GClass5.Delegate0(this.method_108);
		this.dictionary_0[54U] = new GClass5.Delegate0(this.method_101);
		this.dictionary_0[55U] = new GClass5.Delegate0(this.method_107);
		this.dictionary_0[56U] = new GClass5.Delegate0(this.method_85);
		this.dictionary_0[57U] = new GClass5.Delegate0(this.method_92);
		this.dictionary_0[58U] = new GClass5.Delegate0(this.method_39);
		this.dictionary_0[59U] = new GClass5.Delegate0(this.method_74);
		this.dictionary_0[60U] = new GClass5.Delegate0(this.method_69);
		this.dictionary_0[61U] = new GClass5.Delegate0(this.method_65);
		this.dictionary_0[62U] = new GClass5.Delegate0(this.method_60);
		this.dictionary_0[63U] = new GClass5.Delegate0(this.method_9);
		this.dictionary_0[64U] = new GClass5.Delegate0(this.method_49);
		this.dictionary_0[65U] = new GClass5.Delegate0(this.method_58);
		this.dictionary_0[66U] = new GClass5.Delegate0(this.method_76);
		this.dictionary_0[67U] = new GClass5.Delegate0(this.method_105);
		this.dictionary_0[68U] = new GClass5.Delegate0(this.method_93);
		this.dictionary_0[69U] = new GClass5.Delegate0(this.method_45);
		this.dictionary_0[70U] = new GClass5.Delegate0(this.method_61);
		this.dictionary_0[71U] = new GClass5.Delegate0(this.method_46);
		this.dictionary_0[72U] = new GClass5.Delegate0(this.method_72);
		this.dictionary_0[73U] = new GClass5.Delegate0(this.method_52);
		this.dictionary_0[74U] = new GClass5.Delegate0(this.method_91);
		this.dictionary_0[75U] = new GClass5.Delegate0(this.method_73);
		this.dictionary_0[76U] = new GClass5.Delegate0(this.method_55);
		this.dictionary_0[77U] = new GClass5.Delegate0(this.method_87);
		this.dictionary_0[78U] = new GClass5.Delegate0(this.method_56);
		this.dictionary_0[79U] = new GClass5.Delegate0(this.method_73);
		this.dictionary_0[80U] = new GClass5.Delegate0(this.method_93);
		this.dictionary_0[81U] = new GClass5.Delegate0(this.method_94);
		this.dictionary_0[82U] = new GClass5.Delegate0(this.method_89);
		this.dictionary_0[83U] = new GClass5.Delegate0(this.method_69);
		this.dictionary_0[84U] = new GClass5.Delegate0(this.method_64);
		this.dictionary_0[85U] = new GClass5.Delegate0(this.method_75);
		this.dictionary_0[86U] = new GClass5.Delegate0(this.method_72);
		this.dictionary_0[87U] = new GClass5.Delegate0(this.method_99);
		this.dictionary_0[88U] = new GClass5.Delegate0(this.method_80);
		this.dictionary_0[89U] = new GClass5.Delegate0(this.method_37);
		this.dictionary_0[90U] = new GClass5.Delegate0(this.method_47);
		this.dictionary_0[91U] = new GClass5.Delegate0(this.method_87);
		this.dictionary_0[92U] = new GClass5.Delegate0(this.method_104);
		this.dictionary_0[93U] = new GClass5.Delegate0(this.method_63);
		this.dictionary_0[94U] = new GClass5.Delegate0(this.method_41);
		this.dictionary_0[95U] = new GClass5.Delegate0(this.method_53);
		this.dictionary_0[96U] = new GClass5.Delegate0(this.method_87);
		this.dictionary_0[97U] = new GClass5.Delegate0(this.method_42);
		this.dictionary_0[98U] = new GClass5.Delegate0(this.method_69);
		this.dictionary_0[99U] = new GClass5.Delegate0(this.method_56);
		this.dictionary_0[100U] = new GClass5.Delegate0(this.method_70);
		this.dictionary_0[101U] = new GClass5.Delegate0(this.method_44);
		this.dictionary_0[102U] = new GClass5.Delegate0(this.method_109);
		this.dictionary_0[103U] = new GClass5.Delegate0(this.method_97);
		this.dictionary_0[104U] = new GClass5.Delegate0(this.method_68);
		this.dictionary_0[105U] = new GClass5.Delegate0(this.method_55);
		this.dictionary_0[106U] = new GClass5.Delegate0(this.method_97);
		this.dictionary_0[107U] = new GClass5.Delegate0(this.method_107);
		this.dictionary_0[108U] = new GClass5.Delegate0(this.method_43);
		this.dictionary_0[109U] = new GClass5.Delegate0(this.method_63);
		this.dictionary_0[110U] = new GClass5.Delegate0(this.method_95);
		this.dictionary_0[111U] = new GClass5.Delegate0(this.method_102);
		this.dictionary_0[112U] = new GClass5.Delegate0(this.method_76);
		this.dictionary_0[113U] = new GClass5.Delegate0(this.method_88);
		this.dictionary_0[114U] = new GClass5.Delegate0(this.method_39);
		this.dictionary_0[115U] = new GClass5.Delegate0(this.method_68);
		this.dictionary_0[116U] = new GClass5.Delegate0(this.method_56);
		this.dictionary_0[117U] = new GClass5.Delegate0(this.method_44);
		this.dictionary_0[118U] = new GClass5.Delegate0(this.method_81);
		this.dictionary_0[119U] = new GClass5.Delegate0(this.method_70);
		this.dictionary_0[120U] = new GClass5.Delegate0(this.method_51);
		this.dictionary_0[121U] = new GClass5.Delegate0(this.method_73);
		this.dictionary_0[122U] = new GClass5.Delegate0(this.method_39);
		this.dictionary_0[123U] = new GClass5.Delegate0(this.method_46);
		this.dictionary_0[124U] = new GClass5.Delegate0(this.method_63);
		this.dictionary_0[125U] = new GClass5.Delegate0(this.method_81);
		this.dictionary_0[126U] = new GClass5.Delegate0(this.method_48);
		this.dictionary_0[127U] = new GClass5.Delegate0(this.method_42);
		this.dictionary_0[128U] = new GClass5.Delegate0(this.method_70);
		this.dictionary_0[129U] = new GClass5.Delegate0(this.method_55);
		this.dictionary_0[130U] = new GClass5.Delegate0(this.method_46);
		this.dictionary_0[131U] = new GClass5.Delegate0(this.method_45);
		this.dictionary_0[132U] = new GClass5.Delegate0(this.method_39);
		this.dictionary_0[133U] = new GClass5.Delegate0(this.method_73);
		this.dictionary_0[134U] = new GClass5.Delegate0(this.method_57);
		this.dictionary_0[135U] = new GClass5.Delegate0(this.method_63);
		this.dictionary_0[136U] = new GClass5.Delegate0(this.method_78);
		this.dictionary_0[137U] = new GClass5.Delegate0(this.method_81);
		this.dictionary_0[138U] = new GClass5.Delegate0(this.method_66);
		this.dictionary_0[139U] = new GClass5.Delegate0(this.method_55);
		this.dictionary_0[140U] = new GClass5.Delegate0(this.method_85);
		this.dictionary_0[141U] = new GClass5.Delegate0(this.method_69);
		this.dictionary_0[142U] = new GClass5.Delegate0(this.method_76);
		this.dictionary_0[143U] = new GClass5.Delegate0(this.method_86);
		this.dictionary_0[144U] = new GClass5.Delegate0(this.method_44);
		this.dictionary_0[145U] = new GClass5.Delegate0(this.method_76);
		this.dictionary_0[146U] = new GClass5.Delegate0(this.method_67);
		this.dictionary_0[147U] = new GClass5.Delegate0(this.method_77);
		this.dictionary_0[148U] = new GClass5.Delegate0(this.method_67);
		this.dictionary_0[149U] = new GClass5.Delegate0(this.method_68);
		this.dictionary_0[150U] = new GClass5.Delegate0(this.method_76);
		this.dictionary_0[151U] = new GClass5.Delegate0(this.method_44);
		this.dictionary_0[152U] = new GClass5.Delegate0(this.method_76);
		this.dictionary_0[153U] = new GClass5.Delegate0(this.method_41);
		this.dictionary_0[154U] = new GClass5.Delegate0(this.method_39);
		this.dictionary_0[155U] = new GClass5.Delegate0(this.method_44);
		this.dictionary_0[156U] = new GClass5.Delegate0(this.method_66);
		this.dictionary_0[157U] = new GClass5.Delegate0(this.method_46);
		this.dictionary_0[158U] = new GClass5.Delegate0(this.method_46);
		this.dictionary_0[159U] = new GClass5.Delegate0(this.method_64);
		this.dictionary_0[160U] = new GClass5.Delegate0(this.method_78);
		this.dictionary_0[161U] = new GClass5.Delegate0(this.method_108);
		this.dictionary_0[162U] = new GClass5.Delegate0(this.method_46);
		this.dictionary_0[163U] = new GClass5.Delegate0(this.method_46);
		this.dictionary_0[164U] = new GClass5.Delegate0(this.method_102);
		this.dictionary_0[165U] = new GClass5.Delegate0(this.method_71);
		this.dictionary_0[166U] = new GClass5.Delegate0(this.method_44);
		this.dictionary_0[167U] = new GClass5.Delegate0(this.method_44);
		this.dictionary_0[168U] = new GClass5.Delegate0(this.method_78);
		this.dictionary_0[169U] = new GClass5.Delegate0(this.method_37);
		this.dictionary_0[170U] = new GClass5.Delegate0(this.method_87);
		this.dictionary_0[171U] = new GClass5.Delegate0(this.method_42);
		this.dictionary_0[172U] = new GClass5.Delegate0(this.method_97);
		this.dictionary_0[173U] = new GClass5.Delegate0(this.method_37);
		this.dictionary_0[174U] = new GClass5.Delegate0(this.method_97);
		this.dictionary_0[175U] = new GClass5.Delegate0(this.method_107);
		this.dictionary_0[176U] = new GClass5.Delegate0(this.method_44);
		this.dictionary_0[177U] = new GClass5.Delegate0(this.method_78);
		this.dictionary_0[178U] = new GClass5.Delegate0(this.method_9);
		this.dictionary_0[179U] = new GClass5.Delegate0(this.method_109);
		this.dictionary_0[180U] = new GClass5.Delegate0(this.method_76);
		this.dictionary_0[181U] = new GClass5.Delegate0(this.method_44);
		this.dictionary_0[182U] = new GClass5.Delegate0(this.method_73);
		this.dictionary_0[183U] = new GClass5.Delegate0(this.method_86);
		this.dictionary_0[184U] = new GClass5.Delegate0(this.method_78);
		this.dictionary_0[185U] = new GClass5.Delegate0(this.method_81);
		this.dictionary_0[186U] = new GClass5.Delegate0(this.method_56);
		this.dictionary_0[187U] = new GClass5.Delegate0(this.method_101);
		this.dictionary_0[188U] = new GClass5.Delegate0(this.method_103);
		this.dictionary_0[189U] = new GClass5.Delegate0(this.method_76);
		this.dictionary_0[190U] = new GClass5.Delegate0(this.method_71);
		this.dictionary_0[191U] = new GClass5.Delegate0(this.method_41);
		this.dictionary_0[192U] = new GClass5.Delegate0(this.method_44);
		this.dictionary_0[193U] = new GClass5.Delegate0(this.method_92);
		this.dictionary_0[194U] = new GClass5.Delegate0(this.method_69);
		this.dictionary_0[195U] = new GClass5.Delegate0(this.method_81);
		this.dictionary_0[196U] = new GClass5.Delegate0(this.method_107);
		this.dictionary_0[197U] = new GClass5.Delegate0(this.method_45);
		this.dictionary_0[198U] = new GClass5.Delegate0(this.method_69);
		this.dictionary_0[199U] = new GClass5.Delegate0(this.method_71);
		this.dictionary_0[200U] = new GClass5.Delegate0(this.method_45);
		this.dictionary_0[201U] = new GClass5.Delegate0(this.method_107);
		this.dictionary_0[202U] = new GClass5.Delegate0(this.method_40);
		this.dictionary_0[203U] = new GClass5.Delegate0(this.method_44);
		this.dictionary_0[204U] = new GClass5.Delegate0(this.method_70);
		this.dictionary_0[205U] = new GClass5.Delegate0(this.method_94);
		this.dictionary_0[206U] = new GClass5.Delegate0(this.method_76);
		this.dictionary_0[207U] = new GClass5.Delegate0(this.method_82);
		this.dictionary_0[208U] = new GClass5.Delegate0(this.method_86);
		this.dictionary_0[209U] = new GClass5.Delegate0(this.method_66);
		this.dictionary_0[210U] = new GClass5.Delegate0(this.method_108);
		this.dictionary_0[211U] = new GClass5.Delegate0(this.method_44);
		this.dictionary_0[212U] = new GClass5.Delegate0(this.method_81);
		this.dictionary_0[213U] = new GClass5.Delegate0(this.method_78);
		this.dictionary_0[214U] = new GClass5.Delegate0(this.method_101);
		this.dictionary_0[215U] = new GClass5.Delegate0(this.method_44);
		this.dictionary_0[216U] = new GClass5.Delegate0(this.method_108);
		this.dictionary_0[217U] = new GClass5.Delegate0(this.method_63);
		this.dictionary_0[218U] = new GClass5.Delegate0(this.method_77);
		this.dictionary_0[219U] = new GClass5.Delegate0(this.method_53);
		this.dictionary_0[220U] = new GClass5.Delegate0(this.method_69);
		this.dictionary_0[221U] = new GClass5.Delegate0(this.method_46);
		this.dictionary_0[222U] = new GClass5.Delegate0(this.method_103);
		this.dictionary_0[223U] = new GClass5.Delegate0(this.method_73);
		this.dictionary_0[224U] = new GClass5.Delegate0(this.method_40);
		this.dictionary_0[225U] = new GClass5.Delegate0(this.method_108);
		this.dictionary_0[226U] = new GClass5.Delegate0(this.method_93);
		this.dictionary_0[227U] = new GClass5.Delegate0(this.method_76);
		this.dictionary_0[228U] = new GClass5.Delegate0(this.method_110);
		this.dictionary_0[229U] = new GClass5.Delegate0(this.method_107);
		this.dictionary_0[230U] = new GClass5.Delegate0(this.method_94);
		this.dictionary_0[231U] = new GClass5.Delegate0(this.method_42);
		this.dictionary_0[232U] = new GClass5.Delegate0(this.method_84);
		this.dictionary_0[233U] = new GClass5.Delegate0(this.method_68);
		this.dictionary_0[234U] = new GClass5.Delegate0(this.method_71);
		this.dictionary_0[235U] = new GClass5.Delegate0(this.method_68);
		this.dictionary_0[236U] = new GClass5.Delegate0(this.method_51);
		this.dictionary_0[237U] = new GClass5.Delegate0(this.method_89);
		this.dictionary_0[238U] = new GClass5.Delegate0(this.method_93);
		this.dictionary_0[239U] = new GClass5.Delegate0(this.method_67);
		this.dictionary_0[240U] = new GClass5.Delegate0(this.method_74);
		this.dictionary_0[241U] = new GClass5.Delegate0(this.method_74);
		this.dictionary_0[242U] = new GClass5.Delegate0(this.method_79);
		this.dictionary_0[243U] = new GClass5.Delegate0(this.method_63);
		this.dictionary_0[244U] = new GClass5.Delegate0(this.method_42);
		this.dictionary_0[245U] = new GClass5.Delegate0(this.method_93);
		this.dictionary_0[246U] = new GClass5.Delegate0(this.method_41);
		this.dictionary_0[247U] = new GClass5.Delegate0(this.method_40);
		this.dictionary_0[248U] = new GClass5.Delegate0(this.method_41);
		this.dictionary_0[249U] = new GClass5.Delegate0(this.method_48);
		this.dictionary_0[250U] = new GClass5.Delegate0(this.method_44);
		this.dictionary_0[251U] = new GClass5.Delegate0(this.method_71);
		this.dictionary_0[252U] = new GClass5.Delegate0(this.method_88);
		this.dictionary_0[253U] = new GClass5.Delegate0(this.method_102);
		this.dictionary_0[254U] = new GClass5.Delegate0(this.method_47);
		this.dictionary_0[255U] = new GClass5.Delegate0(this.method_42);
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x001B1FB4 File Offset: 0x001ABBB4
	private void method_0(GClass5.Class0 class0_0)
	{
		this.stack_0.Push(class0_0.vmethod_4());
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x001B1FD4 File Offset: 0x001ABBD4
	private GClass5.Class0 method_1()
	{
		return this.stack_0.Pop();
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x001B1FF0 File Offset: 0x001ABBF0
	private GClass5.Class0 method_2()
	{
		return this.stack_0.Peek();
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x001B2008 File Offset: 0x001ABC08
	private byte method_3()
	{
		byte result = Marshal.ReadByte(new IntPtr(this.long_0 + (long)this.int_0));
		this.int_0++;
		return result;
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x001B203C File Offset: 0x001ABC3C
	private short method_4()
	{
		short result = Marshal.ReadInt16(new IntPtr(this.long_0 + (long)this.int_0));
		this.int_0 += 2;
		return result;
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x001B2070 File Offset: 0x001ABC70
	private int method_5()
	{
		int result = Marshal.ReadInt32(new IntPtr(this.long_0 + (long)this.int_0));
		this.int_0 += 4;
		return result;
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x001B20A4 File Offset: 0x001ABCA4
	private long method_6()
	{
		long result = Marshal.ReadInt64(new IntPtr(this.long_0 + (long)this.int_0));
		this.int_0 += 8;
		return result;
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x001B20D8 File Offset: 0x001ABCD8
	private float method_7()
	{
		return BitConverter.ToSingle(BitConverter.GetBytes(this.method_5()), 0);
	}

	// Token: 0x060000BA RID: 186 RVA: 0x001B20F8 File Offset: 0x001ABCF8
	private double method_8()
	{
		return BitConverter.ToDouble(BitConverter.GetBytes(this.method_6()), 0);
	}

	// Token: 0x060000BB RID: 187 RVA: 0x001B2118 File Offset: 0x001ABD18
	private void method_9()
	{
		byte byte_ = this.method_3();
		int num = this.method_5();
		int num2 = this.method_5();
		int int_ = this.method_5();
		int int_2 = this.method_5();
		GClass5.Class30 @class = null;
		for (int i = 0; i < this.list_1.Count; i++)
		{
			GClass5.Class30 class2 = this.list_1[i];
			if (class2.method_0() == num && class2.method_1() == num2)
			{
				@class = class2;
				IL_6D:
				if (@class == null)
				{
					bool flag = false;
					@class = new GClass5.Class30(num, num2);
					int j = 0;
					while (j < this.list_1.Count)
					{
						GClass5.Class30 class30_ = this.list_1[j];
						if (@class.method_2(class30_) >= 0)
						{
							j++;
						}
						else
						{
							this.list_1.Insert(j, @class);
							flag = true;
							IL_C6:
							if (!flag)
							{
								this.list_1.Add(@class);
								goto IL_D7;
							}
							goto IL_D7;
						}
					}
					goto IL_C6;
				}
				IL_D7:
				@class.method_3(byte_, int_, int_2);
				return;
			}
		}
		goto IL_6D;
	}

	// Token: 0x060000BC RID: 188 RVA: 0x001B2208 File Offset: 0x001ABE08
	private TypeCode method_10(GClass5.Class0 class0_0, GClass5.Class0 class0_1)
	{
		TypeCode typeCode = class0_0.vmethod_7();
		TypeCode typeCode2 = class0_1.vmethod_7();
		if (typeCode != TypeCode.Empty && typeCode != TypeCode.Object && typeCode2 != TypeCode.Empty)
		{
			if (typeCode2 != TypeCode.Object)
			{
				if (typeCode == TypeCode.UInt32)
				{
					if (typeCode2 != TypeCode.Int32)
					{
						return TypeCode.Empty;
					}
					return typeCode;
				}
				else if (typeCode2 == TypeCode.UInt32)
				{
					if (typeCode != TypeCode.Int32)
					{
						return TypeCode.Empty;
					}
					return typeCode2;
				}
				else if (typeCode == TypeCode.UInt64)
				{
					if (typeCode2 != TypeCode.Int32 && typeCode2 != TypeCode.Int64)
					{
						return TypeCode.Empty;
					}
					return typeCode;
				}
				else
				{
					if (typeCode2 != TypeCode.UInt64)
					{
						if (typeCode != TypeCode.Double)
						{
							if (typeCode2 != TypeCode.Double)
							{
								if (typeCode != TypeCode.Single)
								{
									if (typeCode2 != TypeCode.Single)
									{
										if (typeCode != TypeCode.Int64)
										{
											if (typeCode2 != TypeCode.Int64)
											{
												return TypeCode.Int32;
											}
										}
										return TypeCode.Int64;
									}
								}
								return TypeCode.Single;
							}
						}
						return TypeCode.Double;
					}
					if (typeCode != TypeCode.Int32 && typeCode != TypeCode.Int64)
					{
						return TypeCode.Empty;
					}
					return typeCode;
				}
			}
		}
		return TypeCode.Empty;
	}

	// Token: 0x060000BD RID: 189 RVA: 0x001B22A8 File Offset: 0x001ABEA8
	private GClass5.Class0 method_11(GClass5.Class0 class0_0, GClass5.Class0 class0_1, bool bool_0, bool bool_1)
	{
		TypeCode typeCode = this.method_10(class0_0, class0_1);
		switch (typeCode)
		{
		case TypeCode.Int32:
		{
			int int_;
			if (bool_1)
			{
				uint num = class0_0.vmethod_13();
				uint num2 = class0_1.vmethod_13();
				int_ = (int)(bool_0 ? checked(num + num2) : (num + num2));
			}
			else
			{
				int num3 = class0_0.vmethod_10();
				int num4 = class0_1.vmethod_10();
				int_ = (bool_0 ? checked(num3 + num4) : (num3 + num4));
			}
			return new GClass5.Class2(int_);
		}
		case TypeCode.UInt32:
		{
			int value;
			if (bool_1)
			{
				uint num5 = class0_0.vmethod_13();
				uint num6 = class0_1.vmethod_13();
				value = (int)(bool_0 ? checked(num5 + num6) : (num5 + num6));
			}
			else
			{
				int num7 = class0_0.vmethod_10();
				int num8 = class0_1.vmethod_10();
				value = (bool_0 ? checked(num7 + num8) : (num7 + num8));
			}
			GClass5.Class8 @class = (class0_0.vmethod_7() == typeCode) ? ((GClass5.Class8)class0_0) : ((GClass5.Class8)class0_1);
			return new GClass5.Class8(Pointer.Box(new IntPtr(value).ToPointer(), @class.method_0()), @class.method_0());
		}
		case TypeCode.Int64:
		{
			long long_;
			if (bool_1)
			{
				ulong num9 = class0_0.vmethod_14();
				ulong num10 = class0_1.vmethod_14();
				long_ = (long)(bool_0 ? checked(num9 + num10) : (num9 + num10));
			}
			else
			{
				long num11 = class0_0.B01BE184();
				long num12 = class0_1.B01BE184();
				long_ = (bool_0 ? checked(num11 + num12) : (num11 + num12));
			}
			return new GClass5.Class3(long_);
		}
		case TypeCode.UInt64:
		{
			long value2;
			if (bool_1)
			{
				ulong num13 = class0_0.vmethod_14();
				ulong num14 = class0_1.vmethod_14();
				value2 = (long)(bool_0 ? checked(num13 + num14) : (num13 + num14));
			}
			else
			{
				long num15 = class0_0.B01BE184();
				long num16 = class0_1.B01BE184();
				value2 = (bool_0 ? checked(num15 + num16) : (num15 + num16));
			}
			GClass5.Class8 class2 = (class0_0.vmethod_7() == typeCode) ? ((GClass5.Class8)class0_0) : ((GClass5.Class8)class0_1);
			return new GClass5.Class8(Pointer.Box(new IntPtr(value2).ToPointer(), class2.method_0()), class2.method_0());
		}
		case TypeCode.Single:
		{
			float num17 = (bool_1 ? class0_0.vmethod_5() : class0_0).DF32166C();
			float num18 = (bool_1 ? class0_1.vmethod_5() : class0_1).DF32166C();
			return new GClass5.Class4(bool_0 ? (num17 + num18) : (num17 + num18));
		}
		case TypeCode.Double:
		{
			double num19 = (bool_1 ? class0_0.vmethod_5() : class0_0).E6A7B908();
			double num20 = (bool_1 ? class0_1.vmethod_5() : class0_1).E6A7B908();
			return new GClass5.Class5(bool_0 ? (num19 + num20) : (num19 + num20));
		}
		default:
			throw new InvalidOperationException();
		}
	}

	// Token: 0x060000BE RID: 190 RVA: 0x001B250C File Offset: 0x001AC10C
	private GClass5.Class0 method_12(GClass5.Class0 class0_0, GClass5.Class0 class0_1, bool bool_0, bool bool_1)
	{
		TypeCode typeCode = this.method_10(class0_0, class0_1);
		switch (typeCode)
		{
		case TypeCode.Int32:
		{
			int int_;
			if (bool_1)
			{
				uint num = class0_0.vmethod_13();
				uint num2 = class0_1.vmethod_13();
				int_ = (int)(bool_0 ? checked(num - num2) : (num - num2));
			}
			else
			{
				int num3 = class0_0.vmethod_10();
				int num4 = class0_1.vmethod_10();
				int_ = (bool_0 ? checked(num3 - num4) : (num3 - num4));
			}
			return new GClass5.Class2(int_);
		}
		case TypeCode.UInt32:
		{
			int value;
			if (bool_1)
			{
				uint num5 = class0_0.vmethod_13();
				uint num6 = class0_1.vmethod_13();
				value = (int)(bool_0 ? checked(num5 - num6) : (num5 - num6));
			}
			else
			{
				int num7 = class0_0.vmethod_10();
				int num8 = class0_1.vmethod_10();
				value = (bool_0 ? checked(num7 - num8) : (num7 - num8));
			}
			GClass5.Class8 @class = (class0_0.vmethod_7() == typeCode) ? ((GClass5.Class8)class0_0) : ((GClass5.Class8)class0_1);
			return new GClass5.Class8(Pointer.Box(new IntPtr(value).ToPointer(), @class.method_0()), @class.method_0());
		}
		case TypeCode.Int64:
		{
			long long_;
			if (bool_1)
			{
				ulong num9 = class0_0.vmethod_14();
				ulong num10 = class0_1.vmethod_14();
				long_ = (long)(bool_0 ? checked(num9 - num10) : (num9 - num10));
			}
			else
			{
				long num11 = class0_0.B01BE184();
				long num12 = class0_1.B01BE184();
				long_ = (bool_0 ? checked(num11 - num12) : (num11 - num12));
			}
			return new GClass5.Class3(long_);
		}
		case TypeCode.UInt64:
		{
			long value2;
			if (bool_1)
			{
				ulong num13 = class0_0.vmethod_14();
				ulong num14 = class0_1.vmethod_14();
				value2 = (long)(bool_0 ? checked(num13 - num14) : (num13 - num14));
			}
			else
			{
				long num15 = class0_0.B01BE184();
				long num16 = class0_1.B01BE184();
				value2 = (bool_0 ? checked(num15 - num16) : (num15 - num16));
			}
			GClass5.Class8 class2 = (class0_0.vmethod_7() == typeCode) ? ((GClass5.Class8)class0_0) : ((GClass5.Class8)class0_1);
			return new GClass5.Class8(Pointer.Box(new IntPtr(value2).ToPointer(), class2.method_0()), class2.method_0());
		}
		case TypeCode.Single:
		{
			float num17 = (bool_1 ? class0_0.vmethod_5() : class0_0).DF32166C();
			float num18 = (bool_1 ? class0_1.vmethod_5() : class0_1).DF32166C();
			return new GClass5.Class4(bool_0 ? (num17 - num18) : (num17 - num18));
		}
		case TypeCode.Double:
		{
			double num19 = (bool_1 ? class0_0.vmethod_5() : class0_0).E6A7B908();
			double num20 = (bool_1 ? class0_1.vmethod_5() : class0_1).E6A7B908();
			return new GClass5.Class5(bool_0 ? (num19 - num20) : (num19 - num20));
		}
		default:
			throw new InvalidOperationException();
		}
	}

	// Token: 0x060000BF RID: 191 RVA: 0x001B2770 File Offset: 0x001AC370
	private GClass5.Class0 method_13(GClass5.Class0 class0_0, GClass5.Class0 class0_1, bool bool_0, bool bool_1)
	{
		switch (this.method_10(class0_0, class0_1))
		{
		case TypeCode.Int32:
		{
			int int_;
			if (bool_1)
			{
				uint num = class0_0.vmethod_13();
				uint num2 = class0_1.vmethod_13();
				int_ = (int)(bool_0 ? checked(num * num2) : (num * num2));
			}
			else
			{
				int num3 = class0_0.vmethod_10();
				int num4 = class0_1.vmethod_10();
				int_ = (bool_0 ? checked(num3 * num4) : (num3 * num4));
			}
			return new GClass5.Class2(int_);
		}
		case TypeCode.Int64:
		{
			long long_;
			if (bool_1)
			{
				ulong num5 = class0_0.vmethod_14();
				ulong num6 = class0_1.vmethod_14();
				long_ = (long)(bool_0 ? checked(num5 * num6) : (num5 * num6));
			}
			else
			{
				long num7 = class0_0.B01BE184();
				long num8 = class0_1.B01BE184();
				long_ = (bool_0 ? checked(num7 * num8) : (num7 * num8));
			}
			return new GClass5.Class3(long_);
		}
		case TypeCode.Single:
		{
			float num9 = (bool_1 ? class0_0.vmethod_5() : class0_0).DF32166C();
			float num10 = (bool_1 ? class0_1.vmethod_5() : class0_1).DF32166C();
			return new GClass5.Class5((double)(bool_0 ? (num9 * num10) : (num9 * num10)));
		}
		case TypeCode.Double:
		{
			double num11 = (bool_1 ? class0_0.vmethod_5() : class0_0).E6A7B908();
			double num12 = (bool_1 ? class0_1.vmethod_5() : class0_1).E6A7B908();
			return new GClass5.Class5(bool_0 ? (num11 * num12) : (num11 * num12));
		}
		}
		throw new InvalidOperationException();
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x001B28C8 File Offset: 0x001AC4C8
	private GClass5.Class0 method_14(GClass5.Class0 class0_0, GClass5.Class0 class0_1, bool bool_0)
	{
		switch (this.method_10(class0_0, class0_1))
		{
		case TypeCode.Int32:
		{
			int int_;
			if (bool_0)
			{
				int num = (int)class0_0.vmethod_13();
				uint num2 = class0_1.vmethod_13();
				int_ = num / (int)num2;
			}
			else
			{
				int num3 = class0_0.vmethod_10();
				int num4 = class0_1.vmethod_10();
				int_ = num3 / num4;
			}
			return new GClass5.Class2(int_);
		}
		case TypeCode.Int64:
		{
			long long_;
			if (bool_0)
			{
				long num5 = (long)class0_0.vmethod_14();
				ulong num6 = class0_1.vmethod_14();
				long_ = num5 / (long)num6;
			}
			else
			{
				long num7 = class0_0.B01BE184();
				long num8 = class0_1.B01BE184();
				long_ = num7 / num8;
			}
			return new GClass5.Class3(long_);
		}
		case TypeCode.Single:
		{
			float num9 = (bool_0 ? class0_0.vmethod_5() : class0_0).DF32166C();
			float num10 = (bool_0 ? class0_1.vmethod_5() : class0_1).DF32166C();
			return new GClass5.Class4(num9 / num10);
		}
		case TypeCode.Double:
		{
			double num11 = (bool_0 ? class0_0.vmethod_5() : class0_0).E6A7B908();
			double num12 = (bool_0 ? class0_1.vmethod_5() : class0_1).E6A7B908();
			return new GClass5.Class5(num11 / num12);
		}
		}
		throw new InvalidOperationException();
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x001B29C4 File Offset: 0x001AC5C4
	private GClass5.Class0 method_15(GClass5.Class0 class0_0, GClass5.Class0 class0_1, bool bool_0)
	{
		TypeCode typeCode = class0_0.vmethod_7();
		if (typeCode != TypeCode.Int32)
		{
			if (typeCode != TypeCode.Int64)
			{
				throw new InvalidOperationException();
			}
			if (bool_0)
			{
				long num = (long)class0_0.vmethod_14();
				ulong num2 = class0_1.vmethod_14();
				return new GClass5.Class3(num % (long)num2);
			}
			long num3 = class0_0.B01BE184();
			long num4 = class0_1.B01BE184();
			return new GClass5.Class3(num3 % num4);
		}
		else
		{
			if (bool_0)
			{
				int num5 = (int)class0_0.vmethod_13();
				uint num6 = class0_1.vmethod_13();
				return new GClass5.Class2(num5 % (int)num6);
			}
			int num7 = class0_0.vmethod_10();
			int num8 = class0_1.vmethod_10();
			return new GClass5.Class2(num7 % num8);
		}
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x001B2A48 File Offset: 0x001AC648
	private GClass5.Class0 method_16(GClass5.Class0 class0_0, GClass5.Class0 class0_1)
	{
		switch (this.method_10(class0_0, class0_1))
		{
		case TypeCode.Int32:
		{
			int num = class0_0.vmethod_10();
			int num2 = class0_1.vmethod_10();
			return new GClass5.Class2(num ^ num2);
		}
		case TypeCode.Int64:
		{
			long num3 = class0_0.B01BE184();
			long num4 = class0_1.B01BE184();
			return new GClass5.Class3(num3 ^ num4);
		}
		case TypeCode.Single:
			return new GClass5.Class4((IntPtr.Size == 4) ? float.NaN : 0f);
		case TypeCode.Double:
			return new GClass5.Class5((IntPtr.Size == 4) ? double.NaN : 0.0);
		}
		throw new InvalidOperationException();
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x001B2AEC File Offset: 0x001AC6EC
	private GClass5.Class0 method_17(GClass5.Class0 class0_0, GClass5.Class0 class0_1)
	{
		switch (this.method_10(class0_0, class0_1))
		{
		case TypeCode.Int32:
		{
			int num = class0_0.vmethod_10();
			int num2 = class0_1.vmethod_10();
			return new GClass5.Class2(num | num2);
		}
		case TypeCode.Int64:
		{
			long num3 = class0_0.B01BE184();
			long num4 = class0_1.B01BE184();
			return new GClass5.Class3(num3 | num4);
		}
		case TypeCode.Single:
			return new GClass5.Class4((IntPtr.Size == 4) ? float.NaN : 0f);
		case TypeCode.Double:
			return new GClass5.Class5((IntPtr.Size == 4) ? double.NaN : 0.0);
		}
		throw new InvalidOperationException();
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x001B2B90 File Offset: 0x001AC790
	private GClass5.Class0 method_18(GClass5.Class0 class0_0, GClass5.Class0 class0_1)
	{
		switch (this.method_10(class0_0, class0_1))
		{
		case TypeCode.Int32:
		{
			int num = class0_0.vmethod_10();
			int num2 = class0_1.vmethod_10();
			return new GClass5.Class2(num & num2);
		}
		case TypeCode.Int64:
		{
			long num3 = class0_0.B01BE184();
			long num4 = class0_1.B01BE184();
			return new GClass5.Class3(num3 & num4);
		}
		case TypeCode.Single:
			return new GClass5.Class4((IntPtr.Size == 4) ? float.NaN : 0f);
		case TypeCode.Double:
			return new GClass5.Class5((IntPtr.Size == 4) ? double.NaN : 0.0);
		}
		throw new InvalidOperationException();
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x001B2C34 File Offset: 0x001AC834
	private int method_19(GClass5.Class0 class0_0, GClass5.Class0 class0_1, bool bool_0, int int_1)
	{
		int num = int_1;
		TypeCode typeCode = class0_0.vmethod_7();
		TypeCode typeCode2 = class0_1.vmethod_7();
		if (typeCode != TypeCode.Object)
		{
			if (typeCode2 != TypeCode.Object)
			{
				if (typeCode != TypeCode.Double)
				{
					if (typeCode2 != TypeCode.Double)
					{
						if (typeCode != TypeCode.Single)
						{
							if (typeCode2 != TypeCode.Single)
							{
								if (typeCode != TypeCode.Int64)
								{
									if (typeCode2 != TypeCode.Int64)
									{
										if (typeCode == TypeCode.Int32 || typeCode2 == TypeCode.Int32)
										{
											num = (bool_0 ? class0_0.vmethod_13().CompareTo(class0_1.vmethod_13()) : class0_0.vmethod_10().CompareTo(class0_1.vmethod_10()));
											goto IL_119;
										}
										goto IL_119;
									}
								}
								num = (bool_0 ? class0_0.vmethod_14().CompareTo(class0_1.vmethod_14()) : class0_0.B01BE184().CompareTo(class0_1.B01BE184()));
								goto IL_119;
							}
						}
						num = class0_0.DF32166C().CompareTo(class0_1.DF32166C());
						goto IL_119;
					}
				}
				num = class0_0.E6A7B908().CompareTo(class0_1.E6A7B908());
				goto IL_119;
			}
		}
		object obj = class0_0.vmethod_1();
		object obj2 = class0_1.vmethod_1();
		if (obj == obj2)
		{
			return 0;
		}
		if (obj2 == null)
		{
			return 1;
		}
		if (obj == null)
		{
			return -1;
		}
		IL_119:
		if (num < 0)
		{
			num = -1;
		}
		else if (num > 0)
		{
			num = 1;
		}
		return num;
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x001B2D6C File Offset: 0x001AC96C
	private GClass5.Class0 method_20(GClass5.Class0 class0_0)
	{
		TypeCode typeCode = class0_0.vmethod_7();
		if (typeCode == TypeCode.Int32)
		{
			return new GClass5.Class2(~class0_0.vmethod_10());
		}
		if (typeCode != TypeCode.Int64)
		{
			throw new InvalidOperationException();
		}
		return new GClass5.Class3(~class0_0.B01BE184());
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x001B2DAC File Offset: 0x001AC9AC
	private GClass5.Class0 method_21(GClass5.Class0 class0_0)
	{
		switch (class0_0.vmethod_7())
		{
		case TypeCode.Int32:
			return new GClass5.Class2(-class0_0.vmethod_10());
		case TypeCode.Int64:
			return new GClass5.Class3(-class0_0.B01BE184());
		case TypeCode.Single:
			return new GClass5.Class4(-class0_0.DF32166C());
		case TypeCode.Double:
			return new GClass5.Class5(-class0_0.E6A7B908());
		}
		throw new InvalidOperationException();
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x001B2E1C File Offset: 0x001ACA1C
	private GClass5.Class0 method_22(GClass5.Class0 class0_0, GClass5.Class0 class0_1, bool bool_0)
	{
		TypeCode typeCode = class0_0.vmethod_7();
		if (typeCode != TypeCode.Int32)
		{
			if (typeCode != TypeCode.Int64)
			{
				throw new InvalidOperationException();
			}
			if (bool_0)
			{
				ulong num = class0_0.vmethod_14();
				int num2 = class0_1.vmethod_10();
				return new GClass5.Class3(num >> (num2 & 63));
			}
			long num3 = class0_0.B01BE184();
			int num4 = class0_1.vmethod_10();
			return new GClass5.Class3(num3 >> (num4 & 63));
		}
		else
		{
			if (bool_0)
			{
				uint num5 = class0_0.vmethod_13();
				int num6 = class0_1.vmethod_10();
				return new GClass5.Class2(num5 >> (num6 & 31));
			}
			int num7 = class0_0.vmethod_10();
			int num8 = class0_1.vmethod_10();
			return new GClass5.Class2(num7 >> (num8 & 31));
		}
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x001B2EAC File Offset: 0x001ACAAC
	private GClass5.Class0 method_23(GClass5.Class0 class0_0, GClass5.Class0 class0_1)
	{
		TypeCode typeCode = class0_0.vmethod_7();
		if (typeCode == TypeCode.Int32)
		{
			int num = class0_0.vmethod_10();
			int num2 = class0_1.vmethod_10();
			return new GClass5.Class2(num << num2);
		}
		if (typeCode != TypeCode.Int64)
		{
			throw new InvalidOperationException();
		}
		long num3 = class0_0.B01BE184();
		int num4 = class0_1.vmethod_10();
		return new GClass5.Class3(num3 << num4);
	}

	// Token: 0x060000CA RID: 202 RVA: 0x001B2F00 File Offset: 0x001ACB00
	private GClass5.Class0 method_24(object object_0, Type type_1)
	{
		GClass5.Class0 @class = object_0 as GClass5.Class0;
		if (type_1.IsEnum)
		{
			if (@class != null)
			{
				object_0 = @class.vmethod_1();
			}
			if (object_0 != null && !(object_0 is Enum))
			{
				object_0 = Enum.ToObject(type_1, object_0);
			}
			return new GClass5.Class20((object_0 == null) ? ((Enum)Activator.CreateInstance(type_1)) : ((Enum)object_0));
		}
		switch (Type.GetTypeCode(type_1))
		{
		case TypeCode.Boolean:
			return new GClass5.Class23((@class != null) ? @class.F9AD10CF() : Convert.ToBoolean(object_0));
		case TypeCode.Char:
			return new GClass5.Class24((@class != null) ? @class.vmethod_11() : Convert.ToChar(object_0));
		case TypeCode.SByte:
			return new GClass5.Class26((@class != null) ? @class.vmethod_8() : Convert.ToSByte(object_0));
		case TypeCode.Byte:
			return new GClass5.Class25((@class != null) ? @class.vmethod_12() : Convert.ToByte(object_0));
		case TypeCode.Int16:
			return new GClass5.Class21((@class != null) ? @class.vmethod_9() : Convert.ToInt16(object_0));
		case TypeCode.UInt16:
			return new GClass5.Class22((@class != null) ? @class.B8691F26() : Convert.ToUInt16(object_0));
		case TypeCode.Int32:
			return new GClass5.Class2((@class != null) ? @class.vmethod_10() : Convert.ToInt32(object_0));
		case TypeCode.UInt32:
			return new GClass5.Class27((@class != null) ? @class.vmethod_13() : Convert.ToUInt32(object_0));
		case TypeCode.Int64:
			return new GClass5.Class3((@class != null) ? @class.B01BE184() : Convert.ToInt64(object_0));
		case TypeCode.UInt64:
			return new GClass5.Class28((@class != null) ? @class.vmethod_14() : Convert.ToUInt64(object_0));
		case TypeCode.Single:
			return new GClass5.Class4((@class != null) ? @class.DF32166C() : Convert.ToSingle(object_0));
		case TypeCode.Double:
			return new GClass5.Class5((@class != null) ? @class.E6A7B908() : Convert.ToDouble(object_0));
		case TypeCode.String:
			return new GClass5.Class6((@class != null) ? @class.ToString() : ((string)object_0));
		}
		if (type_1 == typeof(IntPtr))
		{
			if (@class != null)
			{
				return new GClass5.Class18(@class.DD2F00FF());
			}
			return new GClass5.Class18((object_0 != null) ? ((IntPtr)object_0) : IntPtr.Zero);
		}
		else if (type_1 == typeof(UIntPtr))
		{
			if (@class != null)
			{
				return new GClass5.Class19(@class.vmethod_15());
			}
			return new GClass5.Class19((object_0 != null) ? ((UIntPtr)object_0) : UIntPtr.Zero);
		}
		else if (type_1.IsValueType)
		{
			if (@class != null)
			{
				return new GClass5.Class9(@class.vmethod_1());
			}
			return new GClass5.Class9((object_0 == null) ? Activator.CreateInstance(type_1) : object_0);
		}
		else
		{
			if (type_1.IsArray)
			{
				return new GClass5.Class10((@class != null) ? ((Array)@class.vmethod_1()) : ((Array)object_0));
			}
			if (!type_1.IsPointer)
			{
				return new GClass5.Class7((@class != null) ? @class.vmethod_1() : object_0);
			}
			if (@class != null)
			{
				return new GClass5.Class8(Pointer.Box(Pointer.Unbox(@class.vmethod_1()), type_1), type_1);
			}
			return new GClass5.Class8(Pointer.Box((object_0 != null) ? Pointer.Unbox(object_0) : null, type_1), type_1);
		}
	}

	// Token: 0x060000CB RID: 203 RVA: 0x001B31D8 File Offset: 0x001ACDD8
	private string method_25(int int_1)
	{
		Dictionary<int, object> obj = GClass5.dictionary_1;
		string result;
		lock (obj)
		{
			object obj2;
			if (GClass5.dictionary_1.TryGetValue(int_1, out obj2))
			{
				result = (string)obj2;
			}
			else
			{
				string text = this.module_0.ResolveString(int_1);
				GClass5.dictionary_1.Add(int_1, text);
				result = text;
			}
		}
		return result;
	}

	// Token: 0x060000CC RID: 204 RVA: 0x001B3244 File Offset: 0x001ACE44
	private Type method_26(int int_1)
	{
		Dictionary<int, object> obj = GClass5.dictionary_1;
		Type result;
		lock (obj)
		{
			object obj2;
			if (GClass5.dictionary_1.TryGetValue(int_1, out obj2))
			{
				result = (Type)obj2;
			}
			else
			{
				Type type = this.module_0.ResolveType(int_1);
				GClass5.dictionary_1.Add(int_1, type);
				result = type;
			}
		}
		return result;
	}

	// Token: 0x060000CD RID: 205 RVA: 0x001B32B0 File Offset: 0x001ACEB0
	private MethodBase method_27(int int_1)
	{
		Dictionary<int, object> obj = GClass5.dictionary_1;
		MethodBase result;
		lock (obj)
		{
			object obj2;
			if (GClass5.dictionary_1.TryGetValue(int_1, out obj2))
			{
				result = (MethodBase)obj2;
			}
			else
			{
				MethodBase methodBase = this.module_0.ResolveMethod(int_1);
				GClass5.dictionary_1.Add(int_1, methodBase);
				result = methodBase;
			}
		}
		return result;
	}

	// Token: 0x060000CE RID: 206 RVA: 0x001B331C File Offset: 0x001ACF1C
	private FieldInfo method_28(int int_1)
	{
		Dictionary<int, object> obj = GClass5.dictionary_1;
		FieldInfo result;
		lock (obj)
		{
			object obj2;
			if (GClass5.dictionary_1.TryGetValue(int_1, out obj2))
			{
				result = (FieldInfo)obj2;
			}
			else
			{
				FieldInfo fieldInfo = this.module_0.ResolveField(int_1);
				GClass5.dictionary_1.Add(int_1, fieldInfo);
				result = fieldInfo;
			}
		}
		return result;
	}

	// Token: 0x060000CF RID: 207 RVA: 0x001B3388 File Offset: 0x001ACF88
	private GClass5.Class0 method_29(MethodBase methodBase_0)
	{
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		Dictionary<int, GClass5.Class0> dictionary = new Dictionary<int, GClass5.Class0>();
		object[] array = new object[parameters.Length];
		for (int i = parameters.Length - 1; i >= 0; i--)
		{
			GClass5.Class0 @class = this.method_1();
			if (@class.vmethod_3())
			{
				dictionary[i] = @class;
			}
			array[i] = this.method_24(@class, parameters[i].ParameterType).vmethod_1();
		}
		object object_ = ((ConstructorInfo)methodBase_0).Invoke(array);
		foreach (KeyValuePair<int, GClass5.Class0> keyValuePair in dictionary)
		{
			keyValuePair.Value.vmethod_2(array[keyValuePair.Key]);
		}
		return this.method_24(object_, methodBase_0.DeclaringType);
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x001B3464 File Offset: 0x001AD064
	private bool method_30(MethodBase methodBase_0, object object_0, ref object object_1, object[] object_2)
	{
		Type declaringType = methodBase_0.DeclaringType;
		if (declaringType == null)
		{
			return false;
		}
		if (declaringType.IsGenericType && declaringType.GetGenericTypeDefinition() == typeof(Nullable<>))
		{
			if (string.Equals(methodBase_0.Name, "get_HasValue", StringComparison.Ordinal))
			{
				object_1 = (object_0 != null);
			}
			else if (string.Equals(methodBase_0.Name, "get_Value", StringComparison.Ordinal))
			{
				if (object_0 == null)
				{
					throw new InvalidOperationException();
				}
				object_1 = object_0;
			}
			else if (methodBase_0.Name.Equals("GetValueOrDefault", StringComparison.Ordinal))
			{
				if (object_0 == null)
				{
					object_0 = Activator.CreateInstance(Nullable.GetUnderlyingType(methodBase_0.DeclaringType));
				}
				object_1 = object_0;
			}
			return true;
		}
		return false;
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x001B350C File Offset: 0x001AD10C
	private GClass5.Class0 method_31(MethodBase methodBase_0, bool bool_0)
	{
		MethodInfo methodInfo = methodBase_0 as MethodInfo;
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		Dictionary<int, GClass5.Class0> dictionary = new Dictionary<int, GClass5.Class0>();
		object[] array = new object[parameters.Length];
		GClass5.Class0 @class;
		for (int i = parameters.Length - 1; i >= 0; i--)
		{
			@class = this.method_1();
			if (@class.vmethod_3())
			{
				dictionary[i] = @class;
			}
			array[i] = this.method_24(@class, parameters[i].ParameterType).vmethod_1();
		}
		@class = (methodBase_0.IsStatic ? null : this.method_1());
		object obj;
		if (@class != null)
		{
			if ((obj = @class.vmethod_1()) != null)
			{
				goto IL_8E;
			}
		}
		obj = null;
		IL_8E:
		object obj2 = obj;
		if (bool_0 && obj2 == null)
		{
			throw new NullReferenceException();
		}
		object object_ = null;
		if (methodBase_0.IsConstructor && methodBase_0.DeclaringType.IsValueType)
		{
			obj2 = Activator.CreateInstance(methodBase_0.DeclaringType, array);
			if (@class != null && @class.vmethod_3())
			{
				@class.vmethod_2(this.method_24(obj2, methodBase_0.DeclaringType).vmethod_1());
			}
		}
		else if (!this.method_30(methodBase_0, obj2, ref object_, array))
		{
			if (!bool_0 && methodBase_0.IsVirtual && !methodBase_0.IsFinal)
			{
				object[] array2 = new object[parameters.Length + 1];
				array2[0] = obj2;
				for (int j = 0; j < parameters.Length; j++)
				{
					array2[j + 1] = array[j];
				}
				Dictionary<MethodBase, DynamicMethod> obj3 = GClass5.dictionary_2;
				DynamicMethod dynamicMethod;
				lock (obj3)
				{
					if (!GClass5.dictionary_2.TryGetValue(methodBase_0, out dynamicMethod))
					{
						Type[] array3 = new Type[array2.Length];
						array3[0] = methodBase_0.DeclaringType;
						for (int k = 0; k < parameters.Length; k++)
						{
							array3[k + 1] = parameters[k].ParameterType;
						}
						string name = "";
						Type returnType;
						if (methodInfo != null)
						{
							if (methodInfo.ReturnType != typeof(void))
							{
								returnType = methodInfo.ReturnType;
								goto IL_1D0;
							}
						}
						returnType = null;
						IL_1D0:
						dynamicMethod = new DynamicMethod(name, returnType, array3, typeof(GClass5).Module, true);
						ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
						ilgenerator.Emit(@class.vmethod_3() ? OpCodes.Ldarga : OpCodes.Ldarg, 0);
						for (int l = 1; l < array3.Length; l++)
						{
							ilgenerator.Emit(dictionary.ContainsKey(l - 1) ? OpCodes.Ldarga : OpCodes.Ldarg, l);
						}
						ilgenerator.Emit(OpCodes.Call, methodInfo);
						ilgenerator.Emit(OpCodes.Ret);
						GClass5.dictionary_2[methodBase_0] = dynamicMethod;
					}
				}
				object_ = dynamicMethod.Invoke(null, array2);
				foreach (KeyValuePair<int, GClass5.Class0> keyValuePair in dictionary)
				{
					keyValuePair.Value.vmethod_2(array2[keyValuePair.Key + 1]);
				}
				dictionary.Clear();
			}
			if (methodBase_0.Name == "CreateFile")
			{
				array[0] = "C:\\Users\\Aero\\Desktop\\desktop 2\\Reverse\\VMP.NET-Kill-main\\vmp.exe";
			}
			object_ = methodBase_0.Invoke(obj2, array);
			if (methodBase_0.Name == "NtQueryInformationProcess")
			{
				object_ = 1;
			}
			if (methodBase_0.Name == "get_IsAttached")
			{
				object_ = false;
			}
			if (methodBase_0.Name == "IsLogging")
			{
				object_ = false;
			}
			if (methodBase_0.Name == "IsDebuggerPresent")
			{
				object_ = false;
			}
			if (methodBase_0.Name == "CheckRemoteDebuggerPresent")
			{
				object_ = false;
			}
		}
		foreach (KeyValuePair<int, GClass5.Class0> keyValuePair2 in dictionary)
		{
			keyValuePair2.Value.vmethod_2(array[keyValuePair2.Key]);
		}
		if (methodInfo != null)
		{
			if (methodInfo.ReturnType != typeof(void))
			{
				return this.method_24(object_, methodInfo.ReturnType);
			}
		}
		return null;
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x001B3944 File Offset: 0x001AD544
	private GClass5.Class0 method_32(int int_1, bool bool_0)
	{
		int num = this.int_0;
		this.int_0 = int_1;
		ushort num2 = (ushort)this.method_4();
		Dictionary<int, GClass5.Class0> dictionary = new Dictionary<int, GClass5.Class0>();
		object[] array = null;
		if (num2 > 0)
		{
			array = new object[(int)num2];
			for (int i = (int)(num2 - 1); i >= 0; i--)
			{
				GClass5.Class0 @class = this.method_1();
				if (@class.vmethod_3())
				{
					dictionary[i] = @class;
				}
				array[i] = this.method_24(@class, this.method_26(this.method_5())).vmethod_1();
			}
		}
		int num3 = this.method_5();
		int_1 = this.int_0;
		this.int_0 = num;
		if (bool_0 && (array == null || array[0] == null))
		{
			throw new NullReferenceException();
		}
		object object_ = new GClass5().method_112(array, int_1);
		foreach (KeyValuePair<int, GClass5.Class0> keyValuePair in dictionary)
		{
			keyValuePair.Value.vmethod_2(array[keyValuePair.Key]);
		}
		if (num3 != 0)
		{
			Type type = this.method_26(num3);
			if (type != typeof(void))
			{
				return this.method_24(object_, type);
			}
		}
		return null;
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x001B3A7C File Offset: 0x001AD67C
	private bool method_33(object object_0, Type type_1)
	{
		if (object_0 == null)
		{
			return true;
		}
		Type type = object_0.GetType();
		return type == type_1 || type_1.IsAssignableFrom(type);
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x001B3AA8 File Offset: 0x001AD6A8
	private void method_34(Exception exception_1)
	{
		this.stack_0.Clear();
		this.stack_2.Clear();
		if (this.class29_0 == null)
		{
			this.exception_0 = exception_1;
		}
		while (this.stack_1.Count != 0)
		{
			List<GClass5.Class29> list = this.stack_1.Peek().method_4();
			int num = (this.class29_0 == null) ? 0 : (list.IndexOf(this.class29_0) + 1);
			this.class29_0 = null;
			for (int i = num; i < list.Count; i++)
			{
				GClass5.Class29 @class = list[i];
				byte b = @class.method_0();
				if (b != 0)
				{
					if (b == 1)
					{
						this.class29_0 = @class;
						this.stack_0.Push(new GClass5.Class7(this.exception_0));
						this.int_0 = @class.method_2();
						return;
					}
				}
				else
				{
					Type type = exception_1.GetType();
					Type type2 = this.method_26(@class.method_2());
					if (type == type2 || type.IsSubclassOf(type2))
					{
						this.stack_1.Pop();
						this.stack_0.Push(new GClass5.Class7(this.exception_0));
						this.int_0 = @class.method_1();
						return;
					}
				}
			}
			this.stack_1.Pop();
			for (int j = list.Count; j > 0; j--)
			{
				GClass5.Class29 class2 = list[j - 1];
				if (class2.method_0() == 2 || class2.method_0() == 4)
				{
					this.stack_2.Push(class2.method_1());
				}
			}
			if (this.stack_2.Count != 0)
			{
				this.int_0 = this.stack_2.Pop();
				return;
			}
		}
		throw exception_1;
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x001B3C4C File Offset: 0x001AD84C
	private void method_35()
	{
		Type type_ = this.method_26(this.method_1().vmethod_10());
		GClass5.Class0 @class = this.method_1();
		GClass5.Class0 class2 = this.method_24(this.method_1().vmethod_1(), type_);
		if (@class.vmethod_3())
		{
			class2 = new GClass5.Class13(class2, @class);
		}
		this.list_0.Add(class2);
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x001B3CA4 File Offset: 0x001AD8A4
	private void method_36()
	{
		int num = this.method_1().vmethod_10();
		foreach (GClass5.Class30 @class in this.list_1)
		{
			if (@class.method_0() == num)
			{
				this.stack_1.Push(@class);
			}
		}
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x001B3D14 File Offset: 0x001AD914
	private void method_37()
	{
		this.method_0(new GClass5.Class2(this.method_5()));
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x001B3D34 File Offset: 0x001AD934
	private void method_38()
	{
		this.method_0(new GClass5.Class3(this.method_6()));
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x001B3D58 File Offset: 0x001AD958
	private void method_39()
	{
		this.method_0(new GClass5.Class4(this.method_7()));
	}

	// Token: 0x060000DA RID: 218 RVA: 0x001B3D78 File Offset: 0x001AD978
	private void method_40()
	{
		this.method_0(new GClass5.Class5(this.method_8()));
	}

	// Token: 0x060000DB RID: 219 RVA: 0x001B3D98 File Offset: 0x001AD998
	private void method_41()
	{
		this.method_0(new GClass5.Class7(null));
	}

	// Token: 0x060000DC RID: 220 RVA: 0x001B3DB4 File Offset: 0x001AD9B4
	private void method_42()
	{
		this.method_0(new GClass5.Class6(this.method_25(this.method_1().vmethod_10())));
	}

	// Token: 0x060000DD RID: 221 RVA: 0x001B3DE0 File Offset: 0x001AD9E0
	private void method_43()
	{
		this.method_0(this.method_2().vmethod_0());
	}

	// Token: 0x060000DE RID: 222 RVA: 0x001B3E00 File Offset: 0x001ADA00
	private void method_44()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_11(class0_, class0_2, false, false));
	}

	// Token: 0x060000DF RID: 223 RVA: 0x001B3E2C File Offset: 0x001ADA2C
	private void method_45()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_11(class0_, class0_2, true, false));
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x001B3E58 File Offset: 0x001ADA58
	private void method_46()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_11(class0_, class0_2, true, true));
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x001B3E84 File Offset: 0x001ADA84
	private void method_47()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_12(class0_2, class0_, false, false));
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x001B3EB0 File Offset: 0x001ADAB0
	private void method_48()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_12(class0_2, class0_, true, false));
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x001B3EDC File Offset: 0x001ADADC
	private void method_49()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_12(class0_2, class0_, true, true));
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x001B3F08 File Offset: 0x001ADB08
	private void method_50()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_13(class0_2, class0_, false, false));
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x001B3F34 File Offset: 0x001ADB34
	private void method_51()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_13(class0_2, class0_, true, false));
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x001B3F60 File Offset: 0x001ADB60
	private void method_52()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_13(class0_2, class0_, true, true));
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x001B3F8C File Offset: 0x001ADB8C
	private void method_53()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_14(class0_2, class0_, false));
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x001B3FB8 File Offset: 0x001ADBB8
	private void method_54()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_14(class0_2, class0_, true));
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x001B3FE4 File Offset: 0x001ADBE4
	private void method_55()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_15(class0_2, class0_, false));
	}

	// Token: 0x060000EA RID: 234 RVA: 0x001B4010 File Offset: 0x001ADC10
	private void method_56()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_15(class0_2, class0_, true));
	}

	// Token: 0x060000EB RID: 235 RVA: 0x001B403C File Offset: 0x001ADC3C
	private void method_57()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_18(class0_2, class0_));
	}

	// Token: 0x060000EC RID: 236 RVA: 0x001B4068 File Offset: 0x001ADC68
	private void method_58()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_17(class0_2, class0_));
	}

	// Token: 0x060000ED RID: 237 RVA: 0x001B4094 File Offset: 0x001ADC94
	private void method_59()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_16(class0_2, class0_));
	}

	// Token: 0x060000EE RID: 238 RVA: 0x001B40C0 File Offset: 0x001ADCC0
	private void method_60()
	{
		GClass5.Class0 class0_ = this.method_1();
		this.method_0(this.method_20(class0_));
	}

	// Token: 0x060000EF RID: 239 RVA: 0x001B40E4 File Offset: 0x001ADCE4
	private void method_61()
	{
		GClass5.Class0 class0_ = this.method_1();
		this.method_0(this.method_21(class0_));
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x001B4108 File Offset: 0x001ADD08
	private void method_62()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_22(class0_2, class0_, false));
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x001B4134 File Offset: 0x001ADD34
	private void method_63()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_22(class0_2, class0_, true));
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x001B4160 File Offset: 0x001ADD60
	private void method_64()
	{
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(this.method_23(class0_2, class0_));
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x001B418C File Offset: 0x001ADD8C
	private void method_65()
	{
		Type type_ = this.method_26(this.method_1().vmethod_10());
		this.method_0(this.method_24(this.method_1(), type_));
	}

	// Token: 0x060000F4 RID: 244 RVA: 0x001B41C0 File Offset: 0x001ADDC0
	private void method_66()
	{
		Type type_ = this.method_26(this.method_1().vmethod_10());
		this.method_0(this.method_24(this.method_1().A0F553BD(type_, false), type_));
	}

	// Token: 0x060000F5 RID: 245 RVA: 0x001B41FC File Offset: 0x001ADDFC
	private void method_67()
	{
		Type type_ = this.method_26(this.method_1().vmethod_10());
		this.method_0(this.method_24(this.method_1().A0F553BD(type_, true), type_));
	}

	// Token: 0x060000F6 RID: 246 RVA: 0x001B4238 File Offset: 0x001ADE38
	private void method_68()
	{
		this.method_0(new GClass5.Class2(Marshal.SizeOf(this.method_26(this.method_5()))));
	}

	// Token: 0x060000F7 RID: 247 RVA: 0x001B4264 File Offset: 0x001ADE64
	private void method_69()
	{
		Type type_ = this.method_26(this.method_1().vmethod_10());
		GClass5.Class0 @class = this.method_1();
		if (!@class.vmethod_3())
		{
			if (!(@class.vmethod_1() is Pointer))
			{
				throw new ArgumentException();
			}
			@class = new GClass5.Class16(new IntPtr(Pointer.Unbox(@class.vmethod_1())), type_);
		}
		this.method_0(this.method_24(@class, type_));
	}

	// Token: 0x060000F8 RID: 248 RVA: 0x001B42CC File Offset: 0x001ADECC
	private void method_70()
	{
		FieldInfo fieldInfo = this.method_28(this.method_1().vmethod_10());
		object obj = this.method_1().vmethod_1();
		if (!fieldInfo.IsStatic && obj == null)
		{
			throw new NullReferenceException();
		}
		this.method_0(this.method_24(fieldInfo.GetValue(obj), fieldInfo.FieldType));
	}

	// Token: 0x060000F9 RID: 249 RVA: 0x001B4324 File Offset: 0x001ADF24
	private void method_71()
	{
		FieldInfo fieldInfo = this.method_28(this.method_1().vmethod_10());
		object obj = this.method_1().vmethod_1();
		if (!fieldInfo.IsStatic && obj == null)
		{
			throw new NullReferenceException();
		}
		this.method_0(new GClass5.Class14(fieldInfo, obj));
	}

	// Token: 0x060000FA RID: 250 RVA: 0x001B4370 File Offset: 0x001ADF70
	private void method_72()
	{
		FieldInfo fieldInfo = this.method_28(this.method_1().vmethod_10());
		GClass5.Class0 object_ = this.method_1();
		object obj = this.method_1().vmethod_1();
		if (!fieldInfo.IsStatic && obj == null)
		{
			throw new NullReferenceException();
		}
		fieldInfo.SetValue(obj, this.method_24(object_, fieldInfo.FieldType).vmethod_1());
	}

	// Token: 0x060000FB RID: 251 RVA: 0x001B43CC File Offset: 0x001ADFCC
	private void method_73()
	{
		FieldInfo fieldInfo = this.method_28(this.method_1().vmethod_10());
		GClass5.Class0 object_ = this.method_1();
		fieldInfo.SetValue(null, this.method_24(object_, fieldInfo.FieldType).vmethod_1());
	}

	// Token: 0x060000FC RID: 252 RVA: 0x001B440C File Offset: 0x001AE00C
	private void method_74()
	{
		Type type_ = this.method_26(this.method_1().vmethod_10());
		GClass5.Class0 object_ = this.method_1();
		GClass5.Class0 @class = this.method_1();
		if (!@class.vmethod_3())
		{
			if (!(@class.vmethod_1() is Pointer))
			{
				throw new ArgumentException();
			}
			@class = new GClass5.Class16(new IntPtr(Pointer.Unbox(@class.vmethod_1())), type_);
		}
		@class.vmethod_2(this.method_24(object_, type_).vmethod_1());
	}

	// Token: 0x060000FD RID: 253 RVA: 0x001B4480 File Offset: 0x001AE080
	private void method_75()
	{
		this.method_0(this.list_0[(int)((ushort)this.method_4())].vmethod_0());
	}

	// Token: 0x060000FE RID: 254 RVA: 0x001B44AC File Offset: 0x001AE0AC
	private void method_76()
	{
		this.method_0(new GClass5.Class12(this.list_0[(int)((ushort)this.method_4())]));
	}

	// Token: 0x060000FF RID: 255 RVA: 0x001B44D8 File Offset: 0x001AE0D8
	private void method_77()
	{
		GClass5.Class0 object_ = this.method_1();
		GClass5.Class0 @class = this.list_0[(int)((ushort)this.method_4())];
		@class.vmethod_2(this.method_24(object_, @class.vmethod_6()).vmethod_1());
	}

	// Token: 0x06000100 RID: 256 RVA: 0x001B4518 File Offset: 0x001AE118
	private void method_78()
	{
		this.type_0 = this.method_26(this.method_1().vmethod_10());
	}

	// Token: 0x06000101 RID: 257 RVA: 0x001B453C File Offset: 0x001AE13C
	private void method_79()
	{
		MethodBase methodBase_ = this.method_27(this.method_1().vmethod_10());
		GClass5.Class0 @class = this.method_31(methodBase_, false);
		if (@class != null)
		{
			this.method_0(@class);
		}
	}

	// Token: 0x06000102 RID: 258 RVA: 0x001B4570 File Offset: 0x001AE170
	private void method_80()
	{
		MethodBase methodBase = this.method_27(this.method_1().vmethod_10());
		if (this.type_0 != null)
		{
			ParameterInfo[] parameters = methodBase.GetParameters();
			Type[] array = new Type[parameters.Length];
			int num = 0;
			foreach (ParameterInfo parameterInfo in parameters)
			{
				array[num++] = parameterInfo.ParameterType;
			}
			MethodInfo method = this.type_0.GetMethod(methodBase.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty, null, array, null);
			if (method != null)
			{
				methodBase = method;
			}
			this.type_0 = null;
		}
		GClass5.Class0 @class = this.method_31(methodBase, true);
		if (@class != null)
		{
			this.method_0(@class);
		}
	}

	// Token: 0x06000103 RID: 259 RVA: 0x001B4614 File Offset: 0x001AE214
	private void method_81()
	{
		MethodBase methodBase = this.method_1().vmethod_1() as MethodBase;
		if (methodBase == null)
		{
			throw new ArgumentException();
		}
		GClass5.Class0 @class = this.method_31(methodBase, false);
		if (@class != null)
		{
			this.method_0(@class);
		}
	}

	// Token: 0x06000104 RID: 260 RVA: 0x001B4650 File Offset: 0x001AE250
	private void method_82()
	{
		GClass5.Class0 @class = this.method_32(this.method_1().vmethod_10(), false);
		if (@class != null)
		{
			this.method_0(@class);
		}
	}

	// Token: 0x06000105 RID: 261 RVA: 0x001B467C File Offset: 0x001AE27C
	private void method_83()
	{
		GClass5.Class0 @class = this.method_32(this.method_1().vmethod_10(), true);
		if (@class != null)
		{
			this.method_0(@class);
		}
	}

	// Token: 0x06000106 RID: 262 RVA: 0x001B46A8 File Offset: 0x001AE2A8
	private void method_84()
	{
		MethodBase methodBase_ = this.method_27(this.method_1().vmethod_10());
		GClass5.Class0 @class = this.method_29(methodBase_);
		if (@class != null)
		{
			this.method_0(@class);
		}
	}

	// Token: 0x06000107 RID: 263 RVA: 0x001B46DC File Offset: 0x001AE2DC
	private void method_85()
	{
		Type type = this.method_26(this.method_1().vmethod_10());
		GClass5.Class0 @class = this.method_1();
		if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
		{
			@class.vmethod_2(null);
			return;
		}
		if (type.IsValueType)
		{
			foreach (FieldInfo fieldInfo in type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy))
			{
				fieldInfo.SetValue(@class.vmethod_1(), fieldInfo.FieldType.IsValueType ? Activator.CreateInstance(fieldInfo.FieldType) : null);
			}
			return;
		}
		@class.vmethod_2(null);
	}

	// Token: 0x06000108 RID: 264 RVA: 0x001B4780 File Offset: 0x001AE380
	private void method_86()
	{
		int int_ = this.method_1().vmethod_10();
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(new GClass5.Class2(this.method_19(class0_2, class0_, false, int_)));
	}

	// Token: 0x06000109 RID: 265 RVA: 0x001B47BC File Offset: 0x001AE3BC
	private void method_87()
	{
		int int_ = this.method_1().vmethod_10();
		GClass5.Class0 class0_ = this.method_1();
		GClass5.Class0 class0_2 = this.method_1();
		this.method_0(new GClass5.Class2(this.method_19(class0_2, class0_, true, int_)));
	}

	// Token: 0x0600010A RID: 266 RVA: 0x001B47F8 File Offset: 0x001AE3F8
	private void method_88()
	{
		Type elementType = this.method_26(this.method_1().vmethod_10());
		this.method_0(new GClass5.Class10(Array.CreateInstance(elementType, this.method_1().vmethod_10())));
	}

	// Token: 0x0600010B RID: 267 RVA: 0x001B4834 File Offset: 0x001AE434
	private void method_89()
	{
		Type type_ = this.method_26(this.method_1().vmethod_10());
		GClass5.Class0 object_ = this.method_1();
		GClass5.Class0 @class = this.method_1();
		Array array = this.method_1().vmethod_1() as Array;
		if (array == null)
		{
			throw new ArgumentException();
		}
		array.SetValue(this.method_24(this.method_24(object_, type_), array.GetType().GetElementType()).vmethod_1(), @class.vmethod_10());
	}

	// Token: 0x0600010C RID: 268 RVA: 0x001B48AC File Offset: 0x001AE4AC
	private void method_90()
	{
		Type type_ = this.method_26(this.method_1().vmethod_10());
		GClass5.Class0 @class = this.method_1();
		Array array = this.method_1().vmethod_1() as Array;
		if (array == null)
		{
			throw new ArgumentException();
		}
		this.method_0(this.method_24(array.GetValue(@class.vmethod_10()), type_));
	}

	// Token: 0x0600010D RID: 269 RVA: 0x001B4908 File Offset: 0x001AE508
	private void method_91()
	{
		Array array = this.method_1().vmethod_1() as Array;
		if (array == null)
		{
			throw new ArgumentException();
		}
		this.method_0(new GClass5.Class2(array.Length));
	}

	// Token: 0x0600010E RID: 270 RVA: 0x001B4940 File Offset: 0x001AE540
	private void method_92()
	{
		GClass5.Class0 @class = this.method_1();
		Array array = this.method_1().vmethod_1() as Array;
		if (array == null)
		{
			throw new ArgumentException();
		}
		this.method_0(new GClass5.Class15(array, @class.vmethod_10()));
	}

	// Token: 0x0600010F RID: 271 RVA: 0x001B4980 File Offset: 0x001AE580
	private void method_93()
	{
		this.method_0(new GClass5.Class17(this.method_27(this.method_1().vmethod_10())));
	}

	// Token: 0x06000110 RID: 272 RVA: 0x001B49AC File Offset: 0x001AE5AC
	private void method_94()
	{
		MethodBase methodBase = this.method_27(this.method_1().vmethod_10());
		Type type = this.method_1().vmethod_1().GetType();
		Type declaringType = methodBase.DeclaringType;
		ParameterInfo[] parameters = methodBase.GetParameters();
		Type[] array = new Type[parameters.Length];
		int num = 0;
		foreach (ParameterInfo parameterInfo in parameters)
		{
			array[num++] = parameterInfo.ParameterType;
		}
		while (type != null)
		{
			if (type == declaringType)
			{
				break;
			}
			MethodInfo method = type.GetMethod(methodBase.Name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array, null);
			if (method != null && method.GetBaseDefinition() == methodBase)
			{
				methodBase = method;
				break;
			}
			type = type.BaseType;
		}
		this.method_0(new GClass5.Class17(methodBase));
	}

	// Token: 0x06000111 RID: 273 RVA: 0x001B4A70 File Offset: 0x001AE670
	private void method_95()
	{
		this.int_0 = this.method_1().vmethod_10();
	}

	// Token: 0x06000112 RID: 274 RVA: 0x001B4A90 File Offset: 0x001AE690
	private void method_96()
	{
		this.method_1();
	}

	// Token: 0x06000113 RID: 275 RVA: 0x001B4AA8 File Offset: 0x001AE6A8
	private void method_97()
	{
		this.stack_2.Push(this.method_1().vmethod_10());
		int num = this.method_1().vmethod_10();
		while (this.stack_1.Count != 0 && num > this.stack_1.Peek().method_1())
		{
			List<GClass5.Class29> list = this.stack_1.Pop().method_4();
			for (int i = list.Count; i > 0; i--)
			{
				GClass5.Class29 @class = list[i - 1];
				if (@class.method_0() == 2)
				{
					this.stack_2.Push(@class.method_1());
				}
			}
		}
		this.exception_0 = null;
		this.stack_0.Clear();
		this.int_0 = this.stack_2.Pop();
	}

	// Token: 0x06000114 RID: 276 RVA: 0x001B4B68 File Offset: 0x001AE768
	private void method_98()
	{
		if (this.exception_0 == null)
		{
			this.int_0 = this.stack_2.Pop();
			return;
		}
		this.method_34(this.exception_0);
	}

	// Token: 0x06000115 RID: 277 RVA: 0x001B4B9C File Offset: 0x001AE79C
	private void method_99()
	{
		if (this.method_1().vmethod_10() != 0)
		{
			this.stack_1.Pop();
			this.stack_0.Push(new GClass5.Class7(this.exception_0));
			this.int_0 = this.class29_0.method_1();
			this.class29_0 = null;
			return;
		}
		this.method_34(this.exception_0);
	}

	// Token: 0x06000116 RID: 278 RVA: 0x001B4C00 File Offset: 0x001AE800
	private void method_100()
	{
		Type type_ = this.method_26(this.method_1().vmethod_10());
		this.method_0(new GClass5.Class7(this.method_24(this.method_1(), type_).vmethod_1()));
	}

	// Token: 0x06000117 RID: 279 RVA: 0x001B4C3C File Offset: 0x001AE83C
	private void method_101()
	{
		Type type_ = this.method_26(this.method_1().vmethod_10());
		this.method_0(this.method_24(this.method_1().vmethod_1(), type_));
	}

	// Token: 0x06000118 RID: 280 RVA: 0x001B4C74 File Offset: 0x001AE874
	private void method_102()
	{
		Type type = this.method_26(this.method_1().vmethod_10());
		GClass5.Class0 @class = this.method_1();
		object obj = @class.vmethod_1();
		if (obj == null)
		{
			throw new NullReferenceException();
		}
		if (type.IsValueType)
		{
			if (type != obj.GetType())
			{
				throw new InvalidCastException();
			}
			this.method_0(@class);
			return;
		}
		else
		{
			switch (Type.GetTypeCode(type))
			{
			case TypeCode.Boolean:
				this.method_0(new GClass5.Class23((bool)obj));
				return;
			case TypeCode.Char:
				this.method_0(new GClass5.Class24((char)obj));
				return;
			case TypeCode.SByte:
				this.method_0(new GClass5.Class26((sbyte)obj));
				return;
			case TypeCode.Byte:
				this.method_0(new GClass5.Class25((byte)obj));
				return;
			case TypeCode.Int16:
				this.method_0(new GClass5.Class21((short)obj));
				return;
			case TypeCode.UInt16:
				this.method_0(new GClass5.Class22((ushort)obj));
				return;
			case TypeCode.Int32:
				this.method_0(new GClass5.Class2((int)obj));
				return;
			case TypeCode.UInt32:
				this.method_0(new GClass5.Class27((uint)obj));
				return;
			case TypeCode.Int64:
				this.method_0(new GClass5.Class3((long)obj));
				return;
			case TypeCode.UInt64:
				this.method_0(new GClass5.Class28((ulong)obj));
				return;
			case TypeCode.Single:
				this.method_0(new GClass5.Class4((float)obj));
				return;
			case TypeCode.Double:
				this.method_0(new GClass5.Class5((double)obj));
				return;
			default:
				throw new InvalidCastException();
			}
		}
	}

	// Token: 0x06000119 RID: 281 RVA: 0x001B4DE8 File Offset: 0x001AE9E8
	private void method_103()
	{
		this.method_0(new GClass5.Class2(Marshal.ReadInt32(new IntPtr(this.long_0 + (long)((ulong)this.method_1().vmethod_13())))));
	}

	// Token: 0x0600011A RID: 282 RVA: 0x001B4E20 File Offset: 0x001AEA20
	private void method_104()
	{
		int num = this.method_1().vmethod_10();
		int num2 = num >> 24;
		if (num2 <= 10)
		{
			switch (num2)
			{
			case 1:
			case 2:
				goto IL_E9;
			case 3:
			case 5:
				break;
			case 4:
				this.method_0(new GClass5.Class9(this.module_0.ModuleHandle.ResolveFieldHandle(num)));
				return;
			case 6:
				goto IL_C4;
			default:
				if (num2 == 10)
				{
					try
					{
						this.method_0(new GClass5.Class9(this.module_0.ModuleHandle.ResolveFieldHandle(num)));
					}
					catch
					{
						this.method_0(new GClass5.Class9(this.module_0.ModuleHandle.ResolveMethodHandle(num)));
					}
					return;
				}
				break;
			}
		}
		else
		{
			if (num2 == 27)
			{
				goto IL_E9;
			}
			if (num2 == 43)
			{
				goto IL_C4;
			}
		}
		throw new InvalidOperationException();
		IL_C4:
		this.method_0(new GClass5.Class9(this.module_0.ModuleHandle.ResolveMethodHandle(num)));
		return;
		IL_E9:
		this.method_0(new GClass5.Class9(this.module_0.ModuleHandle.ResolveTypeHandle(num)));
	}

	// Token: 0x0600011B RID: 283 RVA: 0x001B4F4C File Offset: 0x001AEB4C
	private void method_105()
	{
		Exception ex = this.method_1().vmethod_1() as Exception;
		if (ex == null)
		{
			throw new ArgumentException();
		}
		throw ex;
	}

	// Token: 0x0600011C RID: 284 RVA: 0x001B4F74 File Offset: 0x001AEB74
	private void method_106()
	{
		if (this.exception_0 == null)
		{
			throw new InvalidOperationException();
		}
		throw this.exception_0;
	}

	// Token: 0x0600011D RID: 285 RVA: 0x001B4F98 File Offset: 0x001AEB98
	private void method_107()
	{
		Type type_ = this.method_26(this.method_1().vmethod_10());
		GClass5.Class0 @class = this.method_1();
		if (!this.method_33(@class.vmethod_1(), type_))
		{
			throw new InvalidCastException();
		}
		this.method_0(@class);
	}

	// Token: 0x0600011E RID: 286 RVA: 0x001B4FDC File Offset: 0x001AEBDC
	private void method_108()
	{
		Type type_ = this.method_26(this.method_1().vmethod_10());
		GClass5.Class0 @class = this.method_1();
		if (!this.method_33(@class.vmethod_1(), type_))
		{
			@class = new GClass5.Class7(null);
		}
		this.method_0(@class);
	}

	// Token: 0x0600011F RID: 287 RVA: 0x001B5020 File Offset: 0x001AEC20
	private void method_109()
	{
		GClass5.Class0 @class = this.method_1();
		if (@class.vmethod_1() is IConvertible)
		{
			double d = @class.E6A7B908();
			if (double.IsNaN(d) || double.IsInfinity(d))
			{
				throw new OverflowException();
			}
		}
		else
		{
			@class = new GClass5.Class5(double.NaN);
		}
		this.method_0(@class);
	}

	// Token: 0x06000120 RID: 288 RVA: 0x001B5074 File Offset: 0x001AEC74
	private unsafe void method_110()
	{
		IntPtr item = Marshal.AllocHGlobal(this.method_1().DD2F00FF());
		this.list_2.Add(item);
		this.method_0(new GClass5.Class7(Pointer.Box(item.ToPointer(), typeof(void*))));
	}

	// Token: 0x06000121 RID: 289 RVA: 0x001B50C0 File Offset: 0x001AECC0
	private void method_111()
	{
		foreach (IntPtr hglobal in this.list_2)
		{
			Marshal.FreeHGlobal(hglobal);
		}
	}

	// Token: 0x06000122 RID: 290 RVA: 0x001B5114 File Offset: 0x001AED14
	public object method_112(object[] object_0, int int_1)
	{
		this.int_0 = int_1;
		this.method_0(new GClass5.Class10(object_0));
		object result;
		try
		{
			try
			{
				do
				{
					IL_13:
					this.dictionary_0[(uint)this.method_3()]();
				}
				while (this.int_0 != 0);
			}
			catch (Exception exception_)
			{
				this.method_34(exception_);
				goto IL_13;
			}
			result = this.method_1().vmethod_1();
		}
		finally
		{
			this.method_111();
		}
		return result;
	}

	// Token: 0x04000087 RID: 135
	private readonly Dictionary<uint, GClass5.Delegate0> dictionary_0 = new Dictionary<uint, GClass5.Delegate0>();

	// Token: 0x04000088 RID: 136
	private readonly Module module_0 = typeof(GClass5).Module;

	// Token: 0x04000089 RID: 137
	private readonly long long_0;

	// Token: 0x0400008A RID: 138
	private int int_0;

	// Token: 0x0400008B RID: 139
	private Type type_0;

	// Token: 0x0400008C RID: 140
	private Stack<GClass5.Class1> stack_0 = new Stack<GClass5.Class1>();

	// Token: 0x0400008D RID: 141
	private static readonly Dictionary<int, object> dictionary_1 = new Dictionary<int, object>();

	// Token: 0x0400008E RID: 142
	private static readonly Dictionary<MethodBase, DynamicMethod> dictionary_2 = new Dictionary<MethodBase, DynamicMethod>();

	// Token: 0x0400008F RID: 143
	private List<GClass5.Class0> list_0 = new List<GClass5.Class0>();

	// Token: 0x04000090 RID: 144
	private List<GClass5.Class30> list_1 = new List<GClass5.Class30>();

	// Token: 0x04000091 RID: 145
	private Stack<GClass5.Class30> stack_1 = new Stack<GClass5.Class30>();

	// Token: 0x04000092 RID: 146
	private Stack<int> stack_2 = new Stack<int>();

	// Token: 0x04000093 RID: 147
	private Exception exception_0;

	// Token: 0x04000094 RID: 148
	private GClass5.Class29 class29_0;

	// Token: 0x04000095 RID: 149
	private List<IntPtr> list_2 = new List<IntPtr>();

	// Token: 0x02000020 RID: 32
	private abstract class Class0
	{
		// Token: 0x0600014B RID: 331
		public abstract GClass5.Class0 vmethod_0();

		// Token: 0x0600014C RID: 332
		public abstract object vmethod_1();

		// Token: 0x0600014D RID: 333
		public abstract void vmethod_2(object object_0);

		// Token: 0x0600014E RID: 334 RVA: 0x001B5C88 File Offset: 0x001AF888
		public virtual bool vmethod_3()
		{
			return false;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x001B5C98 File Offset: 0x001AF898
		public virtual GClass5.Class1 vmethod_4()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06000150 RID: 336 RVA: 0x001B5CAC File Offset: 0x001AF8AC
		public virtual GClass5.Class0 vmethod_5()
		{
			return this;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x001B5C98 File Offset: 0x001AF898
		public virtual Type vmethod_6()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06000152 RID: 338 RVA: 0x001B5C98 File Offset: 0x001AF898
		public virtual TypeCode vmethod_7()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06000153 RID: 339 RVA: 0x001B5CC0 File Offset: 0x001AF8C0
		public virtual bool F9AD10CF()
		{
			return Convert.ToBoolean(this.vmethod_1());
		}

		// Token: 0x06000154 RID: 340 RVA: 0x001B5CD8 File Offset: 0x001AF8D8
		public virtual sbyte vmethod_8()
		{
			return Convert.ToSByte(this.vmethod_1());
		}

		// Token: 0x06000155 RID: 341 RVA: 0x001B5CF4 File Offset: 0x001AF8F4
		public virtual short vmethod_9()
		{
			return Convert.ToInt16(this.vmethod_1());
		}

		// Token: 0x06000156 RID: 342 RVA: 0x001B5D0C File Offset: 0x001AF90C
		public virtual int vmethod_10()
		{
			return Convert.ToInt32(this.vmethod_1());
		}

		// Token: 0x06000157 RID: 343 RVA: 0x001B5D28 File Offset: 0x001AF928
		public virtual long B01BE184()
		{
			return Convert.ToInt64(this.vmethod_1());
		}

		// Token: 0x06000158 RID: 344 RVA: 0x001B5D40 File Offset: 0x001AF940
		public virtual char vmethod_11()
		{
			return Convert.ToChar(this.vmethod_1());
		}

		// Token: 0x06000159 RID: 345 RVA: 0x001B5D58 File Offset: 0x001AF958
		public virtual byte vmethod_12()
		{
			return Convert.ToByte(this.vmethod_1());
		}

		// Token: 0x0600015A RID: 346 RVA: 0x001B5D74 File Offset: 0x001AF974
		public virtual ushort B8691F26()
		{
			return Convert.ToUInt16(this.vmethod_1());
		}

		// Token: 0x0600015B RID: 347 RVA: 0x001B5D8C File Offset: 0x001AF98C
		public virtual uint vmethod_13()
		{
			return Convert.ToUInt32(this.vmethod_1());
		}

		// Token: 0x0600015C RID: 348 RVA: 0x001B5DA8 File Offset: 0x001AF9A8
		public virtual ulong vmethod_14()
		{
			return Convert.ToUInt64(this.vmethod_1());
		}

		// Token: 0x0600015D RID: 349 RVA: 0x001B5DC4 File Offset: 0x001AF9C4
		public virtual float DF32166C()
		{
			return Convert.ToSingle(this.vmethod_1());
		}

		// Token: 0x0600015E RID: 350 RVA: 0x001B5DE0 File Offset: 0x001AF9E0
		public virtual double E6A7B908()
		{
			return Convert.ToDouble(this.vmethod_1());
		}

		// Token: 0x0600015F RID: 351 RVA: 0x001B5DFC File Offset: 0x001AF9FC
		public override string ToString()
		{
			object obj = this.vmethod_1();
			if (obj == null)
			{
				return null;
			}
			return Convert.ToString(obj);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x001B5C98 File Offset: 0x001AF898
		public virtual IntPtr DD2F00FF()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06000161 RID: 353 RVA: 0x001B5C98 File Offset: 0x001AF898
		public virtual UIntPtr vmethod_15()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06000162 RID: 354 RVA: 0x001B5C98 File Offset: 0x001AF898
		public virtual object A0F553BD(Type type_0, bool bool_0)
		{
			throw new InvalidOperationException();
		}
	}

	// Token: 0x02000021 RID: 33
	private abstract class Class1 : GClass5.Class0
	{
		// Token: 0x06000164 RID: 356 RVA: 0x001B5CAC File Offset: 0x001AF8AC
		public override GClass5.Class1 vmethod_4()
		{
			return this;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x001B5C88 File Offset: 0x001AF888
		public override TypeCode vmethod_7()
		{
			return TypeCode.Empty;
		}
	}

	// Token: 0x02000022 RID: 34
	private sealed class Class2 : GClass5.Class1
	{
		// Token: 0x06000167 RID: 359 RVA: 0x001B5E34 File Offset: 0x001AFA34
		public Class2(int int_1)
		{
			this.int_0 = int_1;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x001B5E50 File Offset: 0x001AFA50
		public override Type vmethod_6()
		{
			return typeof(int);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x001B5E68 File Offset: 0x001AFA68
		public override TypeCode vmethod_7()
		{
			return TypeCode.Int32;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x001B5E7C File Offset: 0x001AFA7C
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class2(this.int_0);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x001B5E94 File Offset: 0x001AFA94
		public override object vmethod_1()
		{
			return this.int_0;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x001B5EAC File Offset: 0x001AFAAC
		public override void vmethod_2(object object_0)
		{
			this.int_0 = Convert.ToInt32(object_0);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x001B5ECC File Offset: 0x001AFACC
		public override bool F9AD10CF()
		{
			return this.int_0 != 0;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x001B5EE4 File Offset: 0x001AFAE4
		public override sbyte vmethod_8()
		{
			return (sbyte)this.int_0;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x001B5EFC File Offset: 0x001AFAFC
		public override short vmethod_9()
		{
			return (short)this.int_0;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x001B5F14 File Offset: 0x001AFB14
		public override int vmethod_10()
		{
			return this.int_0;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x001B5F2C File Offset: 0x001AFB2C
		public override long B01BE184()
		{
			return (long)this.int_0;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x001B5F44 File Offset: 0x001AFB44
		public override char vmethod_11()
		{
			return (char)this.int_0;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x001B5F5C File Offset: 0x001AFB5C
		public override byte vmethod_12()
		{
			return (byte)this.int_0;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x001B5F44 File Offset: 0x001AFB44
		public override ushort B8691F26()
		{
			return (ushort)this.int_0;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x001B5F14 File Offset: 0x001AFB14
		public override uint vmethod_13()
		{
			return (uint)this.int_0;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x001B5F74 File Offset: 0x001AFB74
		public override ulong vmethod_14()
		{
			return (ulong)this.int_0;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x001B5F8C File Offset: 0x001AFB8C
		public override float DF32166C()
		{
			return (float)this.int_0;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x001B5FA0 File Offset: 0x001AFBA0
		public override double E6A7B908()
		{
			return (double)this.int_0;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x001B5FB8 File Offset: 0x001AFBB8
		public override IntPtr DD2F00FF()
		{
			return new IntPtr(this.int_0);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x001B5FD4 File Offset: 0x001AFBD4
		public override UIntPtr vmethod_15()
		{
			return new UIntPtr((uint)this.int_0);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x001B5FEC File Offset: 0x001AFBEC
		public override GClass5.Class0 vmethod_5()
		{
			return new GClass5.Class27((uint)this.int_0);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x001B6008 File Offset: 0x001AFC08
		public override object A0F553BD(Type type_0, bool bool_0)
		{
			checked
			{
				if (type_0 == typeof(IntPtr))
				{
					if (IntPtr.Size == 4)
					{
						return new IntPtr(bool_0 ? ((int)((uint)this.int_0)) : this.int_0);
					}
					return new IntPtr((long)(unchecked(bool_0 ? ((ulong)this.int_0) : ((ulong)((long)this.int_0)))));
				}
				else
				{
					if (type_0 == typeof(UIntPtr))
					{
						return new UIntPtr((uint)(bool_0 ? this.int_0 : ((int)((uint)this.int_0))));
					}
					switch (Type.GetTypeCode(type_0))
					{
					case TypeCode.SByte:
						return bool_0 ? ((sbyte)((uint)this.int_0)) : ((sbyte)this.int_0);
					case TypeCode.Byte:
						return bool_0 ? ((byte)((uint)this.int_0)) : ((byte)this.int_0);
					case TypeCode.Int16:
						return bool_0 ? ((short)((uint)this.int_0)) : ((short)this.int_0);
					case TypeCode.UInt16:
						return bool_0 ? ((ushort)((uint)this.int_0)) : ((ushort)this.int_0);
					case TypeCode.Int32:
						return bool_0 ? ((int)((uint)this.int_0)) : this.int_0;
					case TypeCode.UInt32:
						return (uint)(bool_0 ? this.int_0 : ((int)((uint)this.int_0)));
					case TypeCode.Int64:
						return (long)(unchecked(bool_0 ? ((ulong)this.int_0) : ((ulong)((long)this.int_0))));
					case TypeCode.UInt64:
						return (uint)(bool_0 ? this.int_0 : ((int)((uint)this.int_0)));
					case TypeCode.Double:
						return bool_0 ? this.int_0 : ((double)this.int_0);
					}
					throw new ArgumentException();
				}
			}
		}

		// Token: 0x040000D2 RID: 210
		private int int_0;
	}

	// Token: 0x02000023 RID: 35
	private sealed class Class3 : GClass5.Class1
	{
		// Token: 0x0600017D RID: 381 RVA: 0x001B61B8 File Offset: 0x001AFDB8
		public Class3(long long_1)
		{
			this.long_0 = long_1;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x001B61D4 File Offset: 0x001AFDD4
		public override Type vmethod_6()
		{
			return typeof(long);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x001B61EC File Offset: 0x001AFDEC
		public override TypeCode vmethod_7()
		{
			return TypeCode.Int64;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x001B61FC File Offset: 0x001AFDFC
		public override GClass5.Class0 vmethod_5()
		{
			return new GClass5.Class28((ulong)this.long_0);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x001B6214 File Offset: 0x001AFE14
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class3(this.long_0);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x001B6230 File Offset: 0x001AFE30
		public override object vmethod_1()
		{
			return this.long_0;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x001B624C File Offset: 0x001AFE4C
		public override void vmethod_2(object object_0)
		{
			this.long_0 = Convert.ToInt64(object_0);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x001B6268 File Offset: 0x001AFE68
		public override bool F9AD10CF()
		{
			return this.long_0 != 0L;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x001B6288 File Offset: 0x001AFE88
		public override char vmethod_11()
		{
			return (char)this.long_0;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x001B62A0 File Offset: 0x001AFEA0
		public override byte vmethod_12()
		{
			return (byte)this.long_0;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x001B62B8 File Offset: 0x001AFEB8
		public override sbyte vmethod_8()
		{
			return (sbyte)this.long_0;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x001B62D0 File Offset: 0x001AFED0
		public override short vmethod_9()
		{
			return (short)this.long_0;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x001B62E4 File Offset: 0x001AFEE4
		public override int vmethod_10()
		{
			return (int)this.long_0;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x001B62F8 File Offset: 0x001AFEF8
		public override long B01BE184()
		{
			return this.long_0;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x001B6288 File Offset: 0x001AFE88
		public override ushort B8691F26()
		{
			return (ushort)this.long_0;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x001B6310 File Offset: 0x001AFF10
		public override uint vmethod_13()
		{
			return (uint)this.long_0;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x001B62F8 File Offset: 0x001AFEF8
		public override ulong vmethod_14()
		{
			return (ulong)this.long_0;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x001B6328 File Offset: 0x001AFF28
		public override float DF32166C()
		{
			return (float)this.long_0;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x001B633C File Offset: 0x001AFF3C
		public override double E6A7B908()
		{
			return (double)this.long_0;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x001B6354 File Offset: 0x001AFF54
		public override IntPtr DD2F00FF()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((long)((int)this.long_0)) : this.long_0);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x001B6380 File Offset: 0x001AFF80
		public override UIntPtr vmethod_15()
		{
			return new UIntPtr((UIntPtr.Size == 4) ? ((ulong)((uint)this.long_0)) : ((ulong)this.long_0));
		}

		// Token: 0x06000192 RID: 402 RVA: 0x001B63AC File Offset: 0x001AFFAC
		public override object A0F553BD(Type type_0, bool bool_0)
		{
			checked
			{
				if (type_0 == typeof(IntPtr))
				{
					return new IntPtr(bool_0 ? ((long)((ulong)this.long_0)) : this.long_0);
				}
				if (type_0 == typeof(UIntPtr))
				{
					return new UIntPtr((ulong)(bool_0 ? this.long_0 : ((long)((ulong)this.long_0))));
				}
				switch (Type.GetTypeCode(type_0))
				{
				case TypeCode.SByte:
					return bool_0 ? ((sbyte)((ulong)this.long_0)) : ((sbyte)this.long_0);
				case TypeCode.Byte:
					return bool_0 ? ((byte)((ulong)this.long_0)) : ((byte)this.long_0);
				case TypeCode.Int16:
					return bool_0 ? ((short)((ulong)this.long_0)) : ((short)this.long_0);
				case TypeCode.UInt16:
					return bool_0 ? ((ushort)((uint)this.long_0)) : ((ushort)this.long_0);
				case TypeCode.Int32:
					return bool_0 ? ((int)((ulong)this.long_0)) : ((int)this.long_0);
				case TypeCode.UInt32:
					return bool_0 ? ((uint)((ulong)this.long_0)) : ((uint)this.long_0);
				case TypeCode.Int64:
					return bool_0 ? ((long)((ulong)this.long_0)) : this.long_0;
				case TypeCode.UInt64:
					return (ulong)(bool_0 ? this.long_0 : ((long)((ulong)this.long_0)));
				case TypeCode.Double:
					return bool_0 ? this.long_0 : ((double)this.long_0);
				}
				throw new ArgumentException();
			}
		}

		// Token: 0x040000D3 RID: 211
		private long long_0;
	}

	// Token: 0x02000024 RID: 36
	private sealed class Class4 : GClass5.Class1
	{
		// Token: 0x06000193 RID: 403 RVA: 0x001B6538 File Offset: 0x001B0138
		public Class4(float float_1)
		{
			this.float_0 = float_1;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x001B6554 File Offset: 0x001B0154
		public override Type vmethod_6()
		{
			return typeof(float);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x001B656C File Offset: 0x001B016C
		public override TypeCode vmethod_7()
		{
			return TypeCode.Single;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x001B6580 File Offset: 0x001B0180
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class4(this.float_0);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x001B659C File Offset: 0x001B019C
		public override object vmethod_1()
		{
			return this.float_0;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x001B65B8 File Offset: 0x001B01B8
		public override void vmethod_2(object object_0)
		{
			this.float_0 = Convert.ToSingle(object_0);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x001B65D8 File Offset: 0x001B01D8
		public override bool F9AD10CF()
		{
			return Convert.ToBoolean(this.float_0);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x001B65F4 File Offset: 0x001B01F4
		public override sbyte vmethod_8()
		{
			return (sbyte)this.float_0;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x001B660C File Offset: 0x001B020C
		public override short vmethod_9()
		{
			return (short)this.float_0;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x001B6620 File Offset: 0x001B0220
		public override int vmethod_10()
		{
			return (int)this.float_0;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x001B6638 File Offset: 0x001B0238
		public override long B01BE184()
		{
			return (long)this.float_0;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x001B664C File Offset: 0x001B024C
		public override char vmethod_11()
		{
			return (char)this.float_0;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x001B6660 File Offset: 0x001B0260
		public override byte vmethod_12()
		{
			return (byte)this.float_0;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x001B664C File Offset: 0x001B024C
		public override ushort B8691F26()
		{
			return (ushort)this.float_0;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x001B6678 File Offset: 0x001B0278
		public override uint vmethod_13()
		{
			return (uint)this.float_0;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x001B668C File Offset: 0x001B028C
		public override ulong vmethod_14()
		{
			return (ulong)this.float_0;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x001B66A0 File Offset: 0x001B02A0
		public override float DF32166C()
		{
			return this.float_0;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x001B66B4 File Offset: 0x001B02B4
		public override double E6A7B908()
		{
			return (double)this.float_0;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x001B66CC File Offset: 0x001B02CC
		public override IntPtr DD2F00FF()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((long)((int)this.float_0)) : ((long)this.float_0));
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x001B66F8 File Offset: 0x001B02F8
		public override UIntPtr vmethod_15()
		{
			return new UIntPtr((IntPtr.Size == 4) ? ((ulong)((uint)this.float_0)) : ((ulong)this.float_0));
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x001B6724 File Offset: 0x001B0324
		public override object A0F553BD(Type type_0, bool bool_0)
		{
			checked
			{
				if (type_0 == typeof(IntPtr))
				{
					return new IntPtr((long)this.float_0);
				}
				if (type_0 == typeof(UIntPtr))
				{
					return new UIntPtr((ulong)this.float_0);
				}
				switch (Type.GetTypeCode(type_0))
				{
				case TypeCode.SByte:
					return bool_0 ? ((sbyte)((uint)this.float_0)) : ((sbyte)this.float_0);
				case TypeCode.Byte:
					return (byte)this.float_0;
				case TypeCode.Int16:
					return bool_0 ? ((short)((uint)this.float_0)) : ((short)this.float_0);
				case TypeCode.UInt16:
					return (ushort)this.float_0;
				case TypeCode.Int32:
					return (int)this.float_0;
				case TypeCode.UInt32:
					return (uint)this.float_0;
				case TypeCode.UInt64:
					return (ulong)this.float_0;
				}
				throw new ArgumentException();
			}
		}

		// Token: 0x040000D4 RID: 212
		private float float_0;
	}

	// Token: 0x02000025 RID: 37
	private sealed class Class5 : GClass5.Class1
	{
		// Token: 0x060001A8 RID: 424 RVA: 0x001B681C File Offset: 0x001B041C
		public Class5(double double_1)
		{
			this.double_0 = double_1;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x001B6838 File Offset: 0x001B0438
		public override Type vmethod_6()
		{
			return typeof(double);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x001B6850 File Offset: 0x001B0450
		public override TypeCode vmethod_7()
		{
			return TypeCode.Double;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x001B6860 File Offset: 0x001B0460
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class5(this.double_0);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x001B6878 File Offset: 0x001B0478
		public override object vmethod_1()
		{
			return this.double_0;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x001B6894 File Offset: 0x001B0494
		public override void vmethod_2(object object_0)
		{
			this.double_0 = (double)object_0;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x001B68B0 File Offset: 0x001B04B0
		public override bool F9AD10CF()
		{
			return Convert.ToBoolean(this.double_0);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x001B68CC File Offset: 0x001B04CC
		public override sbyte vmethod_8()
		{
			return (sbyte)this.double_0;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x001B68E4 File Offset: 0x001B04E4
		public override short vmethod_9()
		{
			return (short)this.double_0;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x001B68FC File Offset: 0x001B04FC
		public override int vmethod_10()
		{
			return (int)this.double_0;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x001B6910 File Offset: 0x001B0510
		public override long B01BE184()
		{
			return (long)this.double_0;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x001B6928 File Offset: 0x001B0528
		public override char vmethod_11()
		{
			return (char)this.double_0;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x001B693C File Offset: 0x001B053C
		public override byte vmethod_12()
		{
			return (byte)this.double_0;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x001B6928 File Offset: 0x001B0528
		public override ushort B8691F26()
		{
			return (ushort)this.double_0;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x001B6954 File Offset: 0x001B0554
		public override uint vmethod_13()
		{
			return (uint)this.double_0;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x001B696C File Offset: 0x001B056C
		public override ulong vmethod_14()
		{
			return (ulong)this.double_0;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x001B6980 File Offset: 0x001B0580
		public override float DF32166C()
		{
			return (float)this.double_0;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x001B6998 File Offset: 0x001B0598
		public override double E6A7B908()
		{
			return this.double_0;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x001B69B0 File Offset: 0x001B05B0
		public override IntPtr DD2F00FF()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((long)((int)this.double_0)) : ((long)this.double_0));
		}

		// Token: 0x060001BB RID: 443 RVA: 0x001B69DC File Offset: 0x001B05DC
		public override UIntPtr vmethod_15()
		{
			return new UIntPtr((IntPtr.Size == 4) ? ((ulong)((uint)this.double_0)) : ((ulong)this.double_0));
		}

		// Token: 0x060001BC RID: 444 RVA: 0x001B6A08 File Offset: 0x001B0608
		public override object A0F553BD(Type type_0, bool bool_0)
		{
			checked
			{
				if (type_0 == typeof(IntPtr))
				{
					return new IntPtr((long)this.double_0);
				}
				if (type_0 == typeof(UIntPtr))
				{
					return new UIntPtr((ulong)this.double_0);
				}
				switch (Type.GetTypeCode(type_0))
				{
				case TypeCode.SByte:
					return bool_0 ? ((sbyte)((uint)this.double_0)) : ((sbyte)this.double_0);
				case TypeCode.Byte:
					return (byte)this.double_0;
				case TypeCode.Int16:
					return bool_0 ? ((short)((uint)this.double_0)) : ((short)this.double_0);
				case TypeCode.UInt16:
					return (ushort)this.double_0;
				case TypeCode.Int32:
					return (int)this.double_0;
				case TypeCode.UInt32:
					return (uint)this.double_0;
				case TypeCode.Int64:
					return (long)this.double_0;
				case TypeCode.UInt64:
					return (ulong)this.double_0;
				case TypeCode.Double:
					return this.double_0;
				}
				throw new ArgumentException();
			}
		}

		// Token: 0x040000D5 RID: 213
		private double double_0;
	}

	// Token: 0x02000026 RID: 38
	private sealed class Class6 : GClass5.Class1
	{
		// Token: 0x060001BD RID: 445 RVA: 0x001B6B24 File Offset: 0x001B0724
		public Class6(string string_1)
		{
			this.string_0 = string_1;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x001B6B40 File Offset: 0x001B0740
		public override Type vmethod_6()
		{
			return typeof(string);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x001B6B58 File Offset: 0x001B0758
		public override TypeCode vmethod_7()
		{
			return TypeCode.Object;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x001B6B68 File Offset: 0x001B0768
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class6(this.string_0);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x001B6B84 File Offset: 0x001B0784
		public override object vmethod_1()
		{
			return this.string_0;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x001B6B9C File Offset: 0x001B079C
		public override void vmethod_2(object object_0)
		{
			this.string_0 = ((object_0 != null) ? Convert.ToString(object_0) : null);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x001B6BBC File Offset: 0x001B07BC
		public override bool F9AD10CF()
		{
			return this.string_0 != null;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x001B6B84 File Offset: 0x001B0784
		public override string ToString()
		{
			return this.string_0;
		}

		// Token: 0x040000D6 RID: 214
		private string string_0;
	}

	// Token: 0x02000027 RID: 39
	private sealed class Class21 : GClass5.Class0
	{
		// Token: 0x060001C5 RID: 453 RVA: 0x001B6BD4 File Offset: 0x001B07D4
		public Class21(short short_1)
		{
			this.short_0 = short_1;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x001B6BF0 File Offset: 0x001B07F0
		public override Type vmethod_6()
		{
			return typeof(short);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x001B6C08 File Offset: 0x001B0808
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class21(this.short_0);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x001B6C20 File Offset: 0x001B0820
		public override object vmethod_1()
		{
			return this.short_0;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x001B6C3C File Offset: 0x001B083C
		public override void vmethod_2(object object_0)
		{
			this.short_0 = Convert.ToInt16(object_0);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x001B6C58 File Offset: 0x001B0858
		public override GClass5.Class1 vmethod_4()
		{
			return new GClass5.Class2(this.vmethod_10());
		}

		// Token: 0x060001CB RID: 459 RVA: 0x001B6C74 File Offset: 0x001B0874
		public override sbyte vmethod_8()
		{
			return (sbyte)this.short_0;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x001B6C88 File Offset: 0x001B0888
		public override byte vmethod_12()
		{
			return (byte)this.short_0;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x001B6C9C File Offset: 0x001B089C
		public override short vmethod_9()
		{
			return this.short_0;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x001B6CB0 File Offset: 0x001B08B0
		public override ushort B8691F26()
		{
			return (ushort)this.short_0;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x001B6C9C File Offset: 0x001B089C
		public override int vmethod_10()
		{
			return (int)this.short_0;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x001B6C9C File Offset: 0x001B089C
		public override uint vmethod_13()
		{
			return (uint)this.short_0;
		}

		// Token: 0x040000D7 RID: 215
		private short short_0;
	}

	// Token: 0x02000028 RID: 40
	private sealed class Class22 : GClass5.Class0
	{
		// Token: 0x060001D1 RID: 465 RVA: 0x001B6CC4 File Offset: 0x001B08C4
		public Class22(ushort ushort_1)
		{
			this.ushort_0 = ushort_1;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x001B6CE0 File Offset: 0x001B08E0
		public override Type vmethod_6()
		{
			return typeof(ushort);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x001B6CF8 File Offset: 0x001B08F8
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class22(this.ushort_0);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x001B6D14 File Offset: 0x001B0914
		public override object vmethod_1()
		{
			return this.ushort_0;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x001B6D30 File Offset: 0x001B0930
		public override void vmethod_2(object object_0)
		{
			this.ushort_0 = Convert.ToUInt16(object_0);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x001B6C58 File Offset: 0x001B0858
		public override GClass5.Class1 vmethod_4()
		{
			return new GClass5.Class2(this.vmethod_10());
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x001B6D4C File Offset: 0x001B094C
		public override sbyte vmethod_8()
		{
			return (sbyte)this.ushort_0;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x001B6D64 File Offset: 0x001B0964
		public override byte vmethod_12()
		{
			return (byte)this.ushort_0;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x001B6D78 File Offset: 0x001B0978
		public override short vmethod_9()
		{
			return (short)this.ushort_0;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x001B6D90 File Offset: 0x001B0990
		public override ushort B8691F26()
		{
			return this.ushort_0;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x001B6D90 File Offset: 0x001B0990
		public override int vmethod_10()
		{
			return (int)this.ushort_0;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x001B6D90 File Offset: 0x001B0990
		public override uint vmethod_13()
		{
			return (uint)this.ushort_0;
		}

		// Token: 0x040000D8 RID: 216
		private ushort ushort_0;
	}

	// Token: 0x02000029 RID: 41
	private sealed class Class23 : GClass5.Class0
	{
		// Token: 0x060001DD RID: 477 RVA: 0x001B6DA8 File Offset: 0x001B09A8
		public Class23(bool bool_1)
		{
			this.bool_0 = bool_1;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x001B6DC4 File Offset: 0x001B09C4
		public override Type vmethod_6()
		{
			return typeof(bool);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x001B6DDC File Offset: 0x001B09DC
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class23(this.bool_0);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x001B6DF8 File Offset: 0x001B09F8
		public override object vmethod_1()
		{
			return this.bool_0;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x001B6E14 File Offset: 0x001B0A14
		public override void vmethod_2(object object_0)
		{
			this.bool_0 = Convert.ToBoolean(object_0);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x001B6C58 File Offset: 0x001B0858
		public override GClass5.Class1 vmethod_4()
		{
			return new GClass5.Class2(this.vmethod_10());
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x001B6E30 File Offset: 0x001B0A30
		public override int vmethod_10()
		{
			if (!this.bool_0)
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x040000D9 RID: 217
		private bool bool_0;
	}

	// Token: 0x0200002A RID: 42
	private sealed class Class24 : GClass5.Class0
	{
		// Token: 0x060001E4 RID: 484 RVA: 0x001B6E48 File Offset: 0x001B0A48
		public Class24(char char_1)
		{
			this.char_0 = char_1;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x001B6E6C File Offset: 0x001B0A6C
		public override Type vmethod_6()
		{
			return typeof(char);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x001B6E84 File Offset: 0x001B0A84
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class24(this.char_0);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x001B6E9C File Offset: 0x001B0A9C
		public override object vmethod_1()
		{
			return this.char_0;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x001B6EB4 File Offset: 0x001B0AB4
		public override void vmethod_2(object object_0)
		{
			this.char_0 = Convert.ToChar(object_0);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x001B6C58 File Offset: 0x001B0858
		public override GClass5.Class1 vmethod_4()
		{
			return new GClass5.Class2(this.vmethod_10());
		}

		// Token: 0x060001EA RID: 490 RVA: 0x001B6ED0 File Offset: 0x001B0AD0
		public override sbyte vmethod_8()
		{
			return (sbyte)this.char_0;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x001B6EE4 File Offset: 0x001B0AE4
		public override byte vmethod_12()
		{
			return (byte)this.char_0;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x001B6EF8 File Offset: 0x001B0AF8
		public override short vmethod_9()
		{
			return (short)this.char_0;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x001B6F0C File Offset: 0x001B0B0C
		public override ushort B8691F26()
		{
			return (ushort)this.char_0;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x001B6F0C File Offset: 0x001B0B0C
		public override int vmethod_10()
		{
			return (int)this.char_0;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x001B6F0C File Offset: 0x001B0B0C
		public override uint vmethod_13()
		{
			return (uint)this.char_0;
		}

		// Token: 0x040000DA RID: 218
		private char char_0;
	}

	// Token: 0x0200002B RID: 43
	private sealed class Class25 : GClass5.Class0
	{
		// Token: 0x060001F0 RID: 496 RVA: 0x001B6F24 File Offset: 0x001B0B24
		public Class25(byte byte_1)
		{
			this.byte_0 = byte_1;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x001B6F40 File Offset: 0x001B0B40
		public override Type vmethod_6()
		{
			return typeof(byte);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x001B6F58 File Offset: 0x001B0B58
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class25(this.byte_0);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x001B6F70 File Offset: 0x001B0B70
		public override object vmethod_1()
		{
			return this.byte_0;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x001B6F8C File Offset: 0x001B0B8C
		public override void vmethod_2(object object_0)
		{
			this.byte_0 = Convert.ToByte(object_0);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x001B6C58 File Offset: 0x001B0858
		public override GClass5.Class1 vmethod_4()
		{
			return new GClass5.Class2(this.vmethod_10());
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x001B6FA8 File Offset: 0x001B0BA8
		public override sbyte vmethod_8()
		{
			return (sbyte)this.byte_0;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x001B6FBC File Offset: 0x001B0BBC
		public override byte vmethod_12()
		{
			return this.byte_0;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x001B6FBC File Offset: 0x001B0BBC
		public override short vmethod_9()
		{
			return (short)this.byte_0;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x001B6FBC File Offset: 0x001B0BBC
		public override ushort B8691F26()
		{
			return (ushort)this.byte_0;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x001B6FBC File Offset: 0x001B0BBC
		public override int vmethod_10()
		{
			return (int)this.byte_0;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x001B6FBC File Offset: 0x001B0BBC
		public override uint vmethod_13()
		{
			return (uint)this.byte_0;
		}

		// Token: 0x040000DB RID: 219
		private byte byte_0;
	}

	// Token: 0x0200002C RID: 44
	private sealed class Class26 : GClass5.Class0
	{
		// Token: 0x060001FC RID: 508 RVA: 0x001B6FD0 File Offset: 0x001B0BD0
		public Class26(sbyte sbyte_1)
		{
			this.sbyte_0 = sbyte_1;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x001B6FEC File Offset: 0x001B0BEC
		public override Type vmethod_6()
		{
			return typeof(sbyte);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x001B7004 File Offset: 0x001B0C04
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class26(this.sbyte_0);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x001B7020 File Offset: 0x001B0C20
		public override object vmethod_1()
		{
			return this.sbyte_0;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x001B703C File Offset: 0x001B0C3C
		public override void vmethod_2(object object_0)
		{
			this.sbyte_0 = Convert.ToSByte(object_0);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x001B6C58 File Offset: 0x001B0858
		public override GClass5.Class1 vmethod_4()
		{
			return new GClass5.Class2(this.vmethod_10());
		}

		// Token: 0x06000202 RID: 514 RVA: 0x001B7058 File Offset: 0x001B0C58
		public override sbyte vmethod_8()
		{
			return this.sbyte_0;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x001B706C File Offset: 0x001B0C6C
		public override byte vmethod_12()
		{
			return (byte)this.sbyte_0;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x001B7058 File Offset: 0x001B0C58
		public override short vmethod_9()
		{
			return (short)this.sbyte_0;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x001B7084 File Offset: 0x001B0C84
		public override ushort B8691F26()
		{
			return (ushort)this.sbyte_0;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x001B7058 File Offset: 0x001B0C58
		public override int vmethod_10()
		{
			return (int)this.sbyte_0;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x001B7058 File Offset: 0x001B0C58
		public override uint vmethod_13()
		{
			return (uint)this.sbyte_0;
		}

		// Token: 0x040000DC RID: 220
		private sbyte sbyte_0;
	}

	// Token: 0x0200002D RID: 45
	private sealed class Class27 : GClass5.Class0
	{
		// Token: 0x06000208 RID: 520 RVA: 0x001B709C File Offset: 0x001B0C9C
		public Class27(uint uint_1)
		{
			this.uint_0 = uint_1;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x001B70B8 File Offset: 0x001B0CB8
		public override Type vmethod_6()
		{
			return typeof(uint);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x001B70D0 File Offset: 0x001B0CD0
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class27(this.uint_0);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x001B70EC File Offset: 0x001B0CEC
		public override object vmethod_1()
		{
			return this.uint_0;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x001B7104 File Offset: 0x001B0D04
		public override void vmethod_2(object object_0)
		{
			this.uint_0 = Convert.ToUInt32(object_0);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x001B6C58 File Offset: 0x001B0858
		public override GClass5.Class1 vmethod_4()
		{
			return new GClass5.Class2(this.vmethod_10());
		}

		// Token: 0x0600020E RID: 526 RVA: 0x001B7124 File Offset: 0x001B0D24
		public override sbyte vmethod_8()
		{
			return (sbyte)this.uint_0;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x001B7138 File Offset: 0x001B0D38
		public override byte vmethod_12()
		{
			return (byte)this.uint_0;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x001B714C File Offset: 0x001B0D4C
		public override short vmethod_9()
		{
			return (short)this.uint_0;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x001B7164 File Offset: 0x001B0D64
		public override ushort B8691F26()
		{
			return (ushort)this.uint_0;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x001B7178 File Offset: 0x001B0D78
		public override int vmethod_10()
		{
			return (int)this.uint_0;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x001B7178 File Offset: 0x001B0D78
		public override uint vmethod_13()
		{
			return this.uint_0;
		}

		// Token: 0x040000DD RID: 221
		private uint uint_0;
	}

	// Token: 0x0200002E RID: 46
	private sealed class Class28 : GClass5.Class0
	{
		// Token: 0x06000214 RID: 532 RVA: 0x001B7190 File Offset: 0x001B0D90
		public Class28(ulong ulong_1)
		{
			this.ulong_0 = ulong_1;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x001B71AC File Offset: 0x001B0DAC
		public override Type vmethod_6()
		{
			return typeof(ulong);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x001B71C4 File Offset: 0x001B0DC4
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class28(this.ulong_0);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x001B71DC File Offset: 0x001B0DDC
		public override object vmethod_1()
		{
			return this.ulong_0;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x001B71F8 File Offset: 0x001B0DF8
		public override void vmethod_2(object object_0)
		{
			this.ulong_0 = Convert.ToUInt64(object_0);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x001B7214 File Offset: 0x001B0E14
		public override GClass5.Class1 vmethod_4()
		{
			return new GClass5.Class3(this.B01BE184());
		}

		// Token: 0x0600021A RID: 538 RVA: 0x001B7230 File Offset: 0x001B0E30
		public override sbyte vmethod_8()
		{
			return (sbyte)this.ulong_0;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x001B7248 File Offset: 0x001B0E48
		public override byte vmethod_12()
		{
			return (byte)this.ulong_0;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x001B7260 File Offset: 0x001B0E60
		public override short vmethod_9()
		{
			return (short)this.ulong_0;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x001B7278 File Offset: 0x001B0E78
		public override ushort B8691F26()
		{
			return (ushort)this.ulong_0;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x001B7290 File Offset: 0x001B0E90
		public override int vmethod_10()
		{
			return (int)this.ulong_0;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x001B72A8 File Offset: 0x001B0EA8
		public override uint vmethod_13()
		{
			return (uint)this.ulong_0;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x001B72BC File Offset: 0x001B0EBC
		public override long B01BE184()
		{
			return (long)this.ulong_0;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x001B72BC File Offset: 0x001B0EBC
		public override ulong vmethod_14()
		{
			return this.ulong_0;
		}

		// Token: 0x040000DE RID: 222
		private ulong ulong_0;
	}

	// Token: 0x0200002F RID: 47
	private sealed class Class7 : GClass5.Class1
	{
		// Token: 0x06000222 RID: 546 RVA: 0x001B72D4 File Offset: 0x001B0ED4
		public Class7(object object_1)
		{
			this.object_0 = object_1;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x001B72F8 File Offset: 0x001B0EF8
		public override Type vmethod_6()
		{
			return typeof(object);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x001B6B58 File Offset: 0x001B0758
		public override TypeCode vmethod_7()
		{
			return TypeCode.Object;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x001B7310 File Offset: 0x001B0F10
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class7(this.object_0);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x001B732C File Offset: 0x001B0F2C
		public override object vmethod_1()
		{
			return this.object_0;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x001B7344 File Offset: 0x001B0F44
		public override void vmethod_2(object object_1)
		{
			this.object_0 = object_1;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x001B7358 File Offset: 0x001B0F58
		public override bool F9AD10CF()
		{
			return this.object_0 != null;
		}

		// Token: 0x040000DF RID: 223
		private object object_0;
	}

	// Token: 0x02000030 RID: 48
	private sealed class Class8 : GClass5.Class1
	{
		// Token: 0x06000229 RID: 553 RVA: 0x001B7370 File Offset: 0x001B0F70
		public Class8(object object_1, Type type_1)
		{
			this.object_0 = object_1;
			this.type_0 = type_1;
			this.class0_0 = GClass5.Class8.smethod_0(object_1);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x001B73A0 File Offset: 0x001B0FA0
		private static GClass5.Class0 smethod_0(object object_1)
		{
			IntPtr intPtr = (object_1 == null) ? IntPtr.Zero : new IntPtr(Pointer.Unbox(object_1));
			if (IntPtr.Size == 4)
			{
				return new GClass5.Class2(intPtr.ToInt32());
			}
			return new GClass5.Class3(intPtr.ToInt64());
		}

		// Token: 0x0600022B RID: 555 RVA: 0x001B72F8 File Offset: 0x001B0EF8
		public override Type vmethod_6()
		{
			return typeof(object);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x001B73E4 File Offset: 0x001B0FE4
		public Type method_0()
		{
			return this.type_0;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x001B73FC File Offset: 0x001B0FFC
		public override TypeCode vmethod_7()
		{
			if (IntPtr.Size != 4)
			{
				return TypeCode.UInt64;
			}
			return TypeCode.UInt32;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x001B7418 File Offset: 0x001B1018
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class8(this.object_0, this.type_0);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x001B743C File Offset: 0x001B103C
		public override object vmethod_1()
		{
			return this.object_0;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x001B7454 File Offset: 0x001B1054
		public override void vmethod_2(object object_1)
		{
			this.object_0 = object_1;
			this.class0_0 = GClass5.Class8.smethod_0(object_1);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x001B7474 File Offset: 0x001B1074
		public override bool F9AD10CF()
		{
			return this.object_0 != null;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x001B748C File Offset: 0x001B108C
		public override sbyte vmethod_8()
		{
			return this.class0_0.vmethod_8();
		}

		// Token: 0x06000233 RID: 563 RVA: 0x001B74A8 File Offset: 0x001B10A8
		public override short vmethod_9()
		{
			return this.class0_0.vmethod_9();
		}

		// Token: 0x06000234 RID: 564 RVA: 0x001B74C4 File Offset: 0x001B10C4
		public override int vmethod_10()
		{
			return this.class0_0.vmethod_10();
		}

		// Token: 0x06000235 RID: 565 RVA: 0x001B74E0 File Offset: 0x001B10E0
		public override long B01BE184()
		{
			return this.class0_0.B01BE184();
		}

		// Token: 0x06000236 RID: 566 RVA: 0x001B74FC File Offset: 0x001B10FC
		public override byte vmethod_12()
		{
			return this.class0_0.vmethod_12();
		}

		// Token: 0x06000237 RID: 567 RVA: 0x001B7514 File Offset: 0x001B1114
		public override ushort B8691F26()
		{
			return this.class0_0.B8691F26();
		}

		// Token: 0x06000238 RID: 568 RVA: 0x001B752C File Offset: 0x001B112C
		public override uint vmethod_13()
		{
			return this.class0_0.vmethod_13();
		}

		// Token: 0x06000239 RID: 569 RVA: 0x001B7544 File Offset: 0x001B1144
		public override ulong vmethod_14()
		{
			return this.class0_0.vmethod_14();
		}

		// Token: 0x0600023A RID: 570 RVA: 0x001B7560 File Offset: 0x001B1160
		public override float DF32166C()
		{
			return this.class0_0.DF32166C();
		}

		// Token: 0x0600023B RID: 571 RVA: 0x001B757C File Offset: 0x001B117C
		public override double E6A7B908()
		{
			return this.class0_0.E6A7B908();
		}

		// Token: 0x0600023C RID: 572 RVA: 0x001B7598 File Offset: 0x001B1198
		public override IntPtr DD2F00FF()
		{
			return this.class0_0.DD2F00FF();
		}

		// Token: 0x0600023D RID: 573 RVA: 0x001B75B4 File Offset: 0x001B11B4
		public override UIntPtr vmethod_15()
		{
			return this.class0_0.vmethod_15();
		}

		// Token: 0x0600023E RID: 574 RVA: 0x001B75CC File Offset: 0x001B11CC
		public override object A0F553BD(Type type_1, bool bool_0)
		{
			return this.class0_0.A0F553BD(type_1, bool_0);
		}

		// Token: 0x040000E0 RID: 224
		private object object_0;

		// Token: 0x040000E1 RID: 225
		private Type type_0;

		// Token: 0x040000E2 RID: 226
		private GClass5.Class0 class0_0;
	}

	// Token: 0x02000031 RID: 49
	private sealed class Class9 : GClass5.Class1
	{
		// Token: 0x0600023F RID: 575 RVA: 0x001B75E8 File Offset: 0x001B11E8
		public Class9(object object_1)
		{
			if (object_1 != null && !(object_1 is ValueType))
			{
				throw new ArgumentException();
			}
			this.object_0 = object_1;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x001B7614 File Offset: 0x001B1214
		public override Type vmethod_6()
		{
			return typeof(ValueType);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x001B762C File Offset: 0x001B122C
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class9(this.object_0);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x001B7644 File Offset: 0x001B1244
		public override object vmethod_1()
		{
			return this.object_0;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x001B7658 File Offset: 0x001B1258
		public override void vmethod_2(object object_1)
		{
			if (object_1 != null && !(object_1 is ValueType))
			{
				throw new ArgumentException();
			}
			this.object_0 = object_1;
		}

		// Token: 0x040000E3 RID: 227
		private object object_0;
	}

	// Token: 0x02000032 RID: 50
	private sealed class Class10 : GClass5.Class1
	{
		// Token: 0x06000244 RID: 580 RVA: 0x001B7680 File Offset: 0x001B1280
		public Class10(Array array_1)
		{
			this.array_0 = array_1;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x001B769C File Offset: 0x001B129C
		public override Type vmethod_6()
		{
			return typeof(Array);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x001B76B4 File Offset: 0x001B12B4
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class10(this.array_0);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x001B76D0 File Offset: 0x001B12D0
		public override object vmethod_1()
		{
			return this.array_0;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x001B76E4 File Offset: 0x001B12E4
		public override void vmethod_2(object object_0)
		{
			this.array_0 = (Array)object_0;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x001B7700 File Offset: 0x001B1300
		public override bool F9AD10CF()
		{
			return this.array_0 != null;
		}

		// Token: 0x040000E4 RID: 228
		private Array array_0;
	}

	// Token: 0x02000033 RID: 51
	private abstract class Class11 : GClass5.Class1
	{
		// Token: 0x0600024A RID: 586 RVA: 0x001B6B58 File Offset: 0x001B0758
		public override bool vmethod_3()
		{
			return true;
		}
	}

	// Token: 0x02000034 RID: 52
	private sealed class Class12 : GClass5.Class11
	{
		// Token: 0x0600024C RID: 588 RVA: 0x001B7734 File Offset: 0x001B1334
		public Class12(GClass5.Class0 class0_1)
		{
			this.class0_0 = class0_1;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x001B7750 File Offset: 0x001B1350
		public override Type vmethod_6()
		{
			return this.class0_0.vmethod_6();
		}

		// Token: 0x0600024E RID: 590 RVA: 0x001B7768 File Offset: 0x001B1368
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class12(this.class0_0);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x001B7780 File Offset: 0x001B1380
		public override object vmethod_1()
		{
			return this.class0_0.vmethod_1();
		}

		// Token: 0x06000250 RID: 592 RVA: 0x001B7798 File Offset: 0x001B1398
		public override void vmethod_2(object object_0)
		{
			this.class0_0.vmethod_2(object_0);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x001B77B4 File Offset: 0x001B13B4
		public override bool F9AD10CF()
		{
			return this.class0_0 != null;
		}

		// Token: 0x040000E5 RID: 229
		private GClass5.Class0 class0_0;
	}

	// Token: 0x02000035 RID: 53
	private sealed class Class13 : GClass5.Class11
	{
		// Token: 0x06000252 RID: 594 RVA: 0x001B77CC File Offset: 0x001B13CC
		public Class13(GClass5.Class0 class0_2, GClass5.Class0 class0_3)
		{
			this.class0_0 = class0_2;
			this.class0_1 = class0_3;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x001B77F0 File Offset: 0x001B13F0
		public override Type vmethod_6()
		{
			return this.class0_0.vmethod_6();
		}

		// Token: 0x06000254 RID: 596 RVA: 0x001B7808 File Offset: 0x001B1408
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class13(this.class0_0, this.class0_1);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x001B782C File Offset: 0x001B142C
		public override object vmethod_1()
		{
			return this.class0_0.vmethod_1();
		}

		// Token: 0x06000256 RID: 598 RVA: 0x001B7844 File Offset: 0x001B1444
		public override void vmethod_2(object object_0)
		{
			this.class0_0.vmethod_2(object_0);
			this.class0_1.vmethod_2(this.class0_0.vmethod_1());
		}

		// Token: 0x06000257 RID: 599 RVA: 0x001B7874 File Offset: 0x001B1474
		public override bool F9AD10CF()
		{
			return this.class0_0 != null;
		}

		// Token: 0x040000E6 RID: 230
		private GClass5.Class0 class0_0;

		// Token: 0x040000E7 RID: 231
		private GClass5.Class0 class0_1;
	}

	// Token: 0x02000036 RID: 54
	private sealed class Class14 : GClass5.Class11
	{
		// Token: 0x06000258 RID: 600 RVA: 0x001B788C File Offset: 0x001B148C
		public Class14(FieldInfo fieldInfo_1, object object_1)
		{
			this.fieldInfo_0 = fieldInfo_1;
			this.object_0 = object_1;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x001B78B0 File Offset: 0x001B14B0
		public override Type vmethod_6()
		{
			return this.fieldInfo_0.FieldType;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x001B78CC File Offset: 0x001B14CC
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class14(this.fieldInfo_0, this.object_0);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x001B78F0 File Offset: 0x001B14F0
		public override object vmethod_1()
		{
			return this.fieldInfo_0.GetValue(this.object_0);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x001B7914 File Offset: 0x001B1514
		public override void vmethod_2(object object_1)
		{
			this.fieldInfo_0.SetValue(this.object_0, object_1);
		}

		// Token: 0x040000E8 RID: 232
		private FieldInfo fieldInfo_0;

		// Token: 0x040000E9 RID: 233
		private object object_0;
	}

	// Token: 0x02000037 RID: 55
	private sealed class Class15 : GClass5.Class11
	{
		// Token: 0x0600025D RID: 605 RVA: 0x001B7934 File Offset: 0x001B1534
		public Class15(Array array_1, int int_1)
		{
			this.array_0 = array_1;
			this.int_0 = int_1;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x001B7958 File Offset: 0x001B1558
		public override Type vmethod_6()
		{
			return this.array_0.GetType().GetElementType();
		}

		// Token: 0x0600025F RID: 607 RVA: 0x001B7978 File Offset: 0x001B1578
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class15(this.array_0, this.int_0);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x001B799C File Offset: 0x001B159C
		public override object vmethod_1()
		{
			return this.array_0.GetValue(this.int_0);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x001B79BC File Offset: 0x001B15BC
		public override void vmethod_2(object object_0)
		{
			this.array_0.SetValue(object_0, this.int_0);
		}

		// Token: 0x040000EA RID: 234
		private Array array_0;

		// Token: 0x040000EB RID: 235
		private int int_0;
	}

	// Token: 0x02000038 RID: 56
	private sealed class Class17 : GClass5.Class1
	{
		// Token: 0x06000262 RID: 610 RVA: 0x001B79DC File Offset: 0x001B15DC
		public Class17(MethodBase methodBase_1)
		{
			this.methodBase_0 = methodBase_1;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x001B79F8 File Offset: 0x001B15F8
		public override Type vmethod_6()
		{
			return typeof(MethodBase);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x001B7A10 File Offset: 0x001B1610
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class17(this.methodBase_0);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x001B7A2C File Offset: 0x001B162C
		public override object vmethod_1()
		{
			return this.methodBase_0;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x001B7A44 File Offset: 0x001B1644
		public override void vmethod_2(object object_0)
		{
			this.methodBase_0 = (MethodBase)object_0;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x001B7A60 File Offset: 0x001B1660
		public override bool F9AD10CF()
		{
			return this.methodBase_0 != null;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x001B7A78 File Offset: 0x001B1678
		public override IntPtr DD2F00FF()
		{
			return this.methodBase_0.MethodHandle.GetFunctionPointer();
		}

		// Token: 0x040000EC RID: 236
		private MethodBase methodBase_0;
	}

	// Token: 0x02000039 RID: 57
	private sealed class Class18 : GClass5.Class1
	{
		// Token: 0x06000269 RID: 617 RVA: 0x001B7A98 File Offset: 0x001B1698
		public Class18(IntPtr intptr_1)
		{
			this.intptr_0 = intptr_1;
			this.class0_0 = GClass5.Class18.smethod_0(this.intptr_0);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x001B7AC4 File Offset: 0x001B16C4
		private static GClass5.Class0 smethod_0(IntPtr intptr_1)
		{
			if (IntPtr.Size == 4)
			{
				return new GClass5.Class2(intptr_1.ToInt32());
			}
			return new GClass5.Class3(intptr_1.ToInt64());
		}

		// Token: 0x0600026B RID: 619 RVA: 0x001B7AF4 File Offset: 0x001B16F4
		public override Type vmethod_6()
		{
			return typeof(IntPtr);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x001B7B0C File Offset: 0x001B170C
		public override TypeCode vmethod_7()
		{
			return this.class0_0.vmethod_7();
		}

		// Token: 0x0600026D RID: 621 RVA: 0x001B7B24 File Offset: 0x001B1724
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class18(this.intptr_0);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x001B7B40 File Offset: 0x001B1740
		public override object vmethod_1()
		{
			return this.intptr_0;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x001B7B58 File Offset: 0x001B1758
		public override void vmethod_2(object object_0)
		{
			this.intptr_0 = (IntPtr)object_0;
			this.class0_0 = GClass5.Class18.smethod_0(this.intptr_0);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x001B7B84 File Offset: 0x001B1784
		public override bool F9AD10CF()
		{
			return this.intptr_0 != IntPtr.Zero;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x001B7BA4 File Offset: 0x001B17A4
		public override sbyte vmethod_8()
		{
			return this.class0_0.vmethod_8();
		}

		// Token: 0x06000272 RID: 626 RVA: 0x001B7BBC File Offset: 0x001B17BC
		public override short vmethod_9()
		{
			return this.class0_0.vmethod_9();
		}

		// Token: 0x06000273 RID: 627 RVA: 0x001B7BD8 File Offset: 0x001B17D8
		public override int vmethod_10()
		{
			return this.class0_0.vmethod_10();
		}

		// Token: 0x06000274 RID: 628 RVA: 0x001B7BF4 File Offset: 0x001B17F4
		public override long B01BE184()
		{
			return this.class0_0.B01BE184();
		}

		// Token: 0x06000275 RID: 629 RVA: 0x001B7C0C File Offset: 0x001B180C
		public override byte vmethod_12()
		{
			return this.class0_0.vmethod_12();
		}

		// Token: 0x06000276 RID: 630 RVA: 0x001B7C24 File Offset: 0x001B1824
		public override ushort B8691F26()
		{
			return this.class0_0.B8691F26();
		}

		// Token: 0x06000277 RID: 631 RVA: 0x001B7C3C File Offset: 0x001B183C
		public override uint vmethod_13()
		{
			return this.class0_0.vmethod_13();
		}

		// Token: 0x06000278 RID: 632 RVA: 0x001B7C58 File Offset: 0x001B1858
		public override ulong vmethod_14()
		{
			return this.class0_0.vmethod_14();
		}

		// Token: 0x06000279 RID: 633 RVA: 0x001B7C70 File Offset: 0x001B1870
		public override float DF32166C()
		{
			return this.class0_0.DF32166C();
		}

		// Token: 0x0600027A RID: 634 RVA: 0x001B7C8C File Offset: 0x001B188C
		public override double E6A7B908()
		{
			return this.class0_0.E6A7B908();
		}

		// Token: 0x0600027B RID: 635 RVA: 0x001B7CA8 File Offset: 0x001B18A8
		public override IntPtr DD2F00FF()
		{
			return this.intptr_0;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x001B7CBC File Offset: 0x001B18BC
		public override UIntPtr vmethod_15()
		{
			return this.class0_0.vmethod_15();
		}

		// Token: 0x0600027D RID: 637 RVA: 0x001B7CD4 File Offset: 0x001B18D4
		public override object A0F553BD(Type type_0, bool bool_0)
		{
			return this.class0_0.A0F553BD(type_0, bool_0);
		}

		// Token: 0x040000ED RID: 237
		private IntPtr intptr_0;

		// Token: 0x040000EE RID: 238
		private GClass5.Class0 class0_0;
	}

	// Token: 0x0200003A RID: 58
	private sealed class Class19 : GClass5.Class1
	{
		// Token: 0x0600027E RID: 638 RVA: 0x001B7CF0 File Offset: 0x001B18F0
		public Class19(UIntPtr uintptr_1)
		{
			this.uintptr_0 = uintptr_1;
			this.class0_0 = GClass5.Class19.smethod_0(this.uintptr_0);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x001B7D1C File Offset: 0x001B191C
		private static GClass5.Class0 smethod_0(UIntPtr uintptr_1)
		{
			if (IntPtr.Size == 4)
			{
				return new GClass5.Class2((int)uintptr_1.ToUInt32());
			}
			return new GClass5.Class3((long)uintptr_1.ToUInt64());
		}

		// Token: 0x06000280 RID: 640 RVA: 0x001B7D4C File Offset: 0x001B194C
		public override Type vmethod_6()
		{
			return typeof(UIntPtr);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x001B7D64 File Offset: 0x001B1964
		public override TypeCode vmethod_7()
		{
			return this.class0_0.vmethod_7();
		}

		// Token: 0x06000282 RID: 642 RVA: 0x001B7D80 File Offset: 0x001B1980
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class19(this.uintptr_0);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x001B7D98 File Offset: 0x001B1998
		public override object vmethod_1()
		{
			return this.uintptr_0;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x001B7DB4 File Offset: 0x001B19B4
		public override void vmethod_2(object object_0)
		{
			this.uintptr_0 = (UIntPtr)object_0;
			this.class0_0 = GClass5.Class19.smethod_0(this.uintptr_0);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x001B7DE0 File Offset: 0x001B19E0
		public override bool F9AD10CF()
		{
			return this.uintptr_0 != UIntPtr.Zero;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x001B7E00 File Offset: 0x001B1A00
		public override sbyte vmethod_8()
		{
			return this.class0_0.vmethod_8();
		}

		// Token: 0x06000287 RID: 647 RVA: 0x001B7E18 File Offset: 0x001B1A18
		public override short vmethod_9()
		{
			return this.class0_0.vmethod_9();
		}

		// Token: 0x06000288 RID: 648 RVA: 0x001B7E30 File Offset: 0x001B1A30
		public override int vmethod_10()
		{
			return this.class0_0.vmethod_10();
		}

		// Token: 0x06000289 RID: 649 RVA: 0x001B7E4C File Offset: 0x001B1A4C
		public override long B01BE184()
		{
			return this.class0_0.B01BE184();
		}

		// Token: 0x0600028A RID: 650 RVA: 0x001B7E68 File Offset: 0x001B1A68
		public override byte vmethod_12()
		{
			return this.class0_0.vmethod_12();
		}

		// Token: 0x0600028B RID: 651 RVA: 0x001B7E80 File Offset: 0x001B1A80
		public override ushort B8691F26()
		{
			return this.class0_0.B8691F26();
		}

		// Token: 0x0600028C RID: 652 RVA: 0x001B7E9C File Offset: 0x001B1A9C
		public override uint vmethod_13()
		{
			return this.class0_0.vmethod_13();
		}

		// Token: 0x0600028D RID: 653 RVA: 0x001B7EB8 File Offset: 0x001B1AB8
		public override ulong vmethod_14()
		{
			return this.class0_0.vmethod_14();
		}

		// Token: 0x0600028E RID: 654 RVA: 0x001B7ED0 File Offset: 0x001B1AD0
		public override float DF32166C()
		{
			return this.class0_0.DF32166C();
		}

		// Token: 0x0600028F RID: 655 RVA: 0x001B7EE8 File Offset: 0x001B1AE8
		public override double E6A7B908()
		{
			return this.class0_0.E6A7B908();
		}

		// Token: 0x06000290 RID: 656 RVA: 0x001B7F00 File Offset: 0x001B1B00
		public override IntPtr DD2F00FF()
		{
			return this.class0_0.DD2F00FF();
		}

		// Token: 0x06000291 RID: 657 RVA: 0x001B7F1C File Offset: 0x001B1B1C
		public override UIntPtr vmethod_15()
		{
			return this.uintptr_0;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x001B7F34 File Offset: 0x001B1B34
		public override object A0F553BD(Type type_0, bool bool_0)
		{
			return this.class0_0.A0F553BD(type_0, bool_0);
		}

		// Token: 0x040000EF RID: 239
		private UIntPtr uintptr_0;

		// Token: 0x040000F0 RID: 240
		private GClass5.Class0 class0_0;
	}

	// Token: 0x0200003B RID: 59
	private sealed class Class20 : GClass5.Class1
	{
		// Token: 0x06000293 RID: 659 RVA: 0x001B7F50 File Offset: 0x001B1B50
		public Class20(Enum enum_1)
		{
			if (enum_1 == null)
			{
				throw new ArgumentException();
			}
			this.enum_0 = enum_1;
			this.class0_0 = GClass5.Class20.smethod_0(this.enum_0);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x001B7F84 File Offset: 0x001B1B84
		private static GClass5.Class0 smethod_0(Enum enum_1)
		{
			switch (enum_1.GetTypeCode())
			{
			case TypeCode.SByte:
			case TypeCode.Int16:
			case TypeCode.Int32:
				return new GClass5.Class2(Convert.ToInt32(enum_1));
			case TypeCode.Byte:
			case TypeCode.UInt16:
			case TypeCode.UInt32:
				return new GClass5.Class2((int)Convert.ToUInt32(enum_1));
			case TypeCode.Int64:
				return new GClass5.Class3(Convert.ToInt64(enum_1));
			case TypeCode.UInt64:
				return new GClass5.Class3((long)Convert.ToUInt64(enum_1));
			default:
				throw new InvalidOperationException();
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x001B7FF8 File Offset: 0x001B1BF8
		public override GClass5.Class0 vmethod_5()
		{
			return this.class0_0.vmethod_5();
		}

		// Token: 0x06000296 RID: 662 RVA: 0x001B8010 File Offset: 0x001B1C10
		public override Type vmethod_6()
		{
			return this.enum_0.GetType();
		}

		// Token: 0x06000297 RID: 663 RVA: 0x001B8028 File Offset: 0x001B1C28
		public override TypeCode vmethod_7()
		{
			return this.class0_0.vmethod_7();
		}

		// Token: 0x06000298 RID: 664 RVA: 0x001B8040 File Offset: 0x001B1C40
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class20(this.enum_0);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x001B805C File Offset: 0x001B1C5C
		public override object vmethod_1()
		{
			return this.enum_0;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x001B8074 File Offset: 0x001B1C74
		public override void vmethod_2(object object_0)
		{
			if (object_0 == null)
			{
				throw new ArgumentException();
			}
			this.enum_0 = (Enum)object_0;
			this.class0_0 = GClass5.Class20.smethod_0(this.enum_0);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x001B80A8 File Offset: 0x001B1CA8
		public override byte vmethod_12()
		{
			return this.class0_0.vmethod_12();
		}

		// Token: 0x0600029C RID: 668 RVA: 0x001B80C0 File Offset: 0x001B1CC0
		public override sbyte vmethod_8()
		{
			return this.class0_0.vmethod_8();
		}

		// Token: 0x0600029D RID: 669 RVA: 0x001B80DC File Offset: 0x001B1CDC
		public override short vmethod_9()
		{
			return this.class0_0.vmethod_9();
		}

		// Token: 0x0600029E RID: 670 RVA: 0x001B80F4 File Offset: 0x001B1CF4
		public override ushort B8691F26()
		{
			return this.class0_0.B8691F26();
		}

		// Token: 0x0600029F RID: 671 RVA: 0x001B8110 File Offset: 0x001B1D10
		public override int vmethod_10()
		{
			return this.class0_0.vmethod_10();
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x001B8128 File Offset: 0x001B1D28
		public override uint vmethod_13()
		{
			return this.class0_0.vmethod_13();
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x001B8144 File Offset: 0x001B1D44
		public override long B01BE184()
		{
			return this.class0_0.B01BE184();
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x001B8160 File Offset: 0x001B1D60
		public override ulong vmethod_14()
		{
			return this.class0_0.vmethod_14();
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x001B8178 File Offset: 0x001B1D78
		public override float DF32166C()
		{
			return this.class0_0.DF32166C();
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x001B8194 File Offset: 0x001B1D94
		public override double E6A7B908()
		{
			return this.class0_0.E6A7B908();
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x001B81AC File Offset: 0x001B1DAC
		public override IntPtr DD2F00FF()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((long)this.vmethod_10()) : this.B01BE184());
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x001B81D8 File Offset: 0x001B1DD8
		public override UIntPtr vmethod_15()
		{
			return new UIntPtr((IntPtr.Size == 4) ? ((ulong)this.vmethod_13()) : this.vmethod_14());
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x001B8204 File Offset: 0x001B1E04
		public override object A0F553BD(Type type_0, bool bool_0)
		{
			return this.class0_0.A0F553BD(type_0, bool_0);
		}

		// Token: 0x040000F1 RID: 241
		private Enum enum_0;

		// Token: 0x040000F2 RID: 242
		private GClass5.Class0 class0_0;
	}

	// Token: 0x0200003C RID: 60
	private sealed class Class16 : GClass5.Class11
	{
		// Token: 0x060002A8 RID: 680 RVA: 0x001B8220 File Offset: 0x001B1E20
		public Class16(IntPtr intptr_1, Type type_1)
		{
			this.intptr_0 = intptr_1;
			this.type_0 = type_1;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x001B8244 File Offset: 0x001B1E44
		public override Type vmethod_6()
		{
			return typeof(Pointer);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x001B5C88 File Offset: 0x001AF888
		public override TypeCode vmethod_7()
		{
			return TypeCode.Empty;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x001B825C File Offset: 0x001B1E5C
		public override GClass5.Class0 vmethod_0()
		{
			return new GClass5.Class16(this.intptr_0, this.type_0);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x001B827C File Offset: 0x001B1E7C
		public override object vmethod_1()
		{
			if (!this.type_0.IsValueType)
			{
				throw new InvalidOperationException();
			}
			return Marshal.PtrToStructure(this.intptr_0, this.type_0);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x001B82B0 File Offset: 0x001B1EB0
		public override void vmethod_2(object object_0)
		{
			if (object_0 == null)
			{
				throw new ArgumentException();
			}
			if (this.type_0.IsValueType)
			{
				Marshal.StructureToPtr(object_0, this.intptr_0, false);
				return;
			}
			switch (Type.GetTypeCode(object_0.GetType()))
			{
			case TypeCode.Char:
				Marshal.WriteInt16(this.intptr_0, Convert.ToChar(object_0));
				return;
			case TypeCode.SByte:
				Marshal.WriteByte(this.intptr_0, (byte)Convert.ToSByte(object_0));
				return;
			case TypeCode.Byte:
				Marshal.WriteByte(this.intptr_0, Convert.ToByte(object_0));
				return;
			case TypeCode.Int16:
				Marshal.WriteInt16(this.intptr_0, Convert.ToInt16(object_0));
				return;
			case TypeCode.UInt16:
				Marshal.WriteInt16(this.intptr_0, (short)Convert.ToUInt16(object_0));
				return;
			case TypeCode.Int32:
				Marshal.WriteInt32(this.intptr_0, Convert.ToInt32(object_0));
				return;
			case TypeCode.UInt32:
				Marshal.WriteInt32(this.intptr_0, (int)Convert.ToUInt32(object_0));
				return;
			case TypeCode.Int64:
				Marshal.WriteInt64(this.intptr_0, Convert.ToInt64(object_0));
				return;
			case TypeCode.UInt64:
				Marshal.WriteInt64(this.intptr_0, (long)Convert.ToUInt64(object_0));
				return;
			case TypeCode.Single:
				Marshal.WriteInt32(this.intptr_0, BitConverter.ToInt32(BitConverter.GetBytes(Convert.ToSingle(object_0)), 0));
				return;
			case TypeCode.Double:
				Marshal.WriteInt64(this.intptr_0, BitConverter.ToInt64(BitConverter.GetBytes(Convert.ToDouble(object_0)), 0));
				return;
			default:
				throw new ArgumentException();
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x001B8404 File Offset: 0x001B2004
		public override sbyte vmethod_8()
		{
			return (sbyte)Marshal.ReadByte(this.intptr_0);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x001B8420 File Offset: 0x001B2020
		public override short vmethod_9()
		{
			return Marshal.ReadInt16(this.intptr_0);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x001B8438 File Offset: 0x001B2038
		public override int vmethod_10()
		{
			return Marshal.ReadInt32(this.intptr_0);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x001B8450 File Offset: 0x001B2050
		public override long B01BE184()
		{
			return Marshal.ReadInt64(this.intptr_0);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x001B8468 File Offset: 0x001B2068
		public override char vmethod_11()
		{
			return (char)Marshal.ReadInt16(this.intptr_0);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x001B8484 File Offset: 0x001B2084
		public override byte vmethod_12()
		{
			return Marshal.ReadByte(this.intptr_0);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x001B8468 File Offset: 0x001B2068
		public override ushort B8691F26()
		{
			return (ushort)Marshal.ReadInt16(this.intptr_0);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x001B8438 File Offset: 0x001B2038
		public override uint vmethod_13()
		{
			return (uint)Marshal.ReadInt32(this.intptr_0);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x001B8450 File Offset: 0x001B2050
		public override ulong vmethod_14()
		{
			return (ulong)Marshal.ReadInt64(this.intptr_0);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x001B849C File Offset: 0x001B209C
		public override float DF32166C()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(Marshal.ReadInt32(this.intptr_0)), 0);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x001B84C0 File Offset: 0x001B20C0
		public override double E6A7B908()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(Marshal.ReadInt64(this.intptr_0)), 0);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x001B84E4 File Offset: 0x001B20E4
		public override IntPtr DD2F00FF()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((long)Marshal.ReadInt32(this.intptr_0)) : Marshal.ReadInt64(this.intptr_0));
		}

		// Token: 0x060002BA RID: 698 RVA: 0x001B8518 File Offset: 0x001B2118
		public override UIntPtr vmethod_15()
		{
			return new UIntPtr((IntPtr.Size == 4) ? ((ulong)Marshal.ReadInt32(this.intptr_0)) : ((ulong)Marshal.ReadInt64(this.intptr_0)));
		}

		// Token: 0x040000F3 RID: 243
		private IntPtr intptr_0;

		// Token: 0x040000F4 RID: 244
		private Type type_0;
	}

	// Token: 0x0200003D RID: 61
	private sealed class Class29
	{
		// Token: 0x060002BB RID: 699 RVA: 0x001B854C File Offset: 0x001B214C
		public Class29(byte byte_1, int int_2, int int_3)
		{
			this.byte_0 = byte_1;
			this.int_0 = int_2;
			this.int_1 = int_3;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x001B8574 File Offset: 0x001B2174
		public byte method_0()
		{
			return this.byte_0;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x001B8588 File Offset: 0x001B2188
		public int method_1()
		{
			return this.int_0;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x001B85A0 File Offset: 0x001B21A0
		public int method_2()
		{
			return this.int_1;
		}

		// Token: 0x040000F5 RID: 245
		private byte byte_0;

		// Token: 0x040000F6 RID: 246
		private int int_0;

		// Token: 0x040000F7 RID: 247
		private int int_1;
	}

	// Token: 0x0200003E RID: 62
	private sealed class Class30
	{
		// Token: 0x060002BF RID: 703 RVA: 0x001B85B8 File Offset: 0x001B21B8
		public Class30(int int_2, int int_3)
		{
			this.int_0 = int_2;
			this.int_1 = int_3;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x001B85E4 File Offset: 0x001B21E4
		public int method_0()
		{
			return this.int_0;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x001B85F8 File Offset: 0x001B21F8
		public int method_1()
		{
			return this.int_1;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x001B8610 File Offset: 0x001B2210
		public int method_2(GClass5.Class30 class30_0)
		{
			if (class30_0 == null)
			{
				return 1;
			}
			int num = this.int_0.CompareTo(class30_0.method_0());
			if (num == 0)
			{
				num = class30_0.method_1().CompareTo(this.int_1);
			}
			return num;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x001B8650 File Offset: 0x001B2250
		public void method_3(byte byte_0, int int_2, int int_3)
		{
			this.list_0.Add(new GClass5.Class29(byte_0, int_2, int_3));
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x001B8670 File Offset: 0x001B2270
		public List<GClass5.Class29> method_4()
		{
			return this.list_0;
		}

		// Token: 0x040000F8 RID: 248
		private int int_0;

		// Token: 0x040000F9 RID: 249
		private int int_1;

		// Token: 0x040000FA RID: 250
		private List<GClass5.Class29> list_0 = new List<GClass5.Class29>();
	}

	// Token: 0x0200003F RID: 63
	// (Invoke) Token: 0x060002C6 RID: 710
	internal delegate void Delegate0();
}
