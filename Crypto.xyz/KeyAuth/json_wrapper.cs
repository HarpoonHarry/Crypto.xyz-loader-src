using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace KeyAuth
{
	// Token: 0x02000007 RID: 7
	public class json_wrapper
	{
		// Token: 0x0600002F RID: 47 RVA: 0x001AA149 File Offset: 0x001A3D49
		public static bool is_serializable(Type to_check)
		{
			return to_check.IsSerializable || to_check.IsDefined(typeof(DataContractAttribute), true);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x001AC60C File Offset: 0x001A620C
		public json_wrapper(object obj_to_work_with)
		{
			this.current_object = obj_to_work_with;
			Type type = this.current_object.GetType();
			this.serializer = new DataContractJsonSerializer(type);
			if (!json_wrapper.is_serializable(type))
			{
				throw new Exception(string.Format("the object {0} isn't a serializable", this.current_object));
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x001AC678 File Offset: 0x001A6278
		public object string_to_object(string json)
		{
			object result;
			using (MemoryStream memoryStream = new MemoryStream(Encoding.Default.GetBytes(json)))
			{
				result = this.serializer.ReadObject(memoryStream);
			}
			return result;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x001AA174 File Offset: 0x001A3D74
		public T string_to_generic<T>(string json)
		{
			return (T)((object)this.string_to_object(json));
		}

		// Token: 0x04000015 RID: 21
		private DataContractJsonSerializer serializer;

		// Token: 0x04000016 RID: 22
		private object current_object;
	}
}
