using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Common
{
   public static class ObjectReflectionClone
    {
        public static T CloneModel<T>(this T oModel)
        {
            var oRes = default(T);
            var oType = typeof(T);

            //得到新的对象对象
            oRes = (T)Activator.CreateInstance(oType);

            //给新的对象复制
            var lstPro = oType.GetProperties();
            foreach (var oPro in lstPro)
            {
                //从旧对象里面取值
                var oValue = oPro.GetValue(oModel);

                //复制给新的对象
                if (oPro.CanWrite)
                {
                    oPro.SetValue(oRes, oValue);
                }
            }

            return oRes;
        }


        /// <summary>
        /// 深克隆
        /// </summary>
        /// <param name="obj">原始版本对象</param>
        /// <returns>深克隆后的对象</returns>
        public static T DepthClone<T>(this T obj) where T : class
        {
            T clone = Activator.CreateInstance<T>();
            using (Stream stream = new MemoryStream())
            {
                IFormatter formatter = new BinaryFormatter();
                try
                {
                    formatter.Serialize(stream, obj);
                    stream.Seek(0, SeekOrigin.Begin);
                    clone = (T)formatter.Deserialize(stream);
                }
                catch (SerializationException e)
                {
                    Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                    throw;
                }
            }
            return clone;
        }
    }
}
