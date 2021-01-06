using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class Util
    {
        /// <summary>
        /// DataTable转List
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static IList<T> ConvertTo<T>(DataTable dt) where T : new()
        {
            // 定义集合    
            IList<T> ts = new List<T>();

            foreach (DataRow dr in dt.Rows)
            {
                T t = new T();
                // 获得此模型的公共属性      
                PropertyInfo[] propertys = t.GetType().GetProperties();
                foreach (PropertyInfo pi in propertys)
                {

                    Type type = pi.PropertyType;
                    //if判断就是解决办法
                    if (type.IsGenericType && type.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))//判断convertsionType是否为nullable泛型类  
                    {
                        //如果type为nullable类，声明一个NullableConverter类，该类提供从Nullable类到基础基元类型的转换  
                        System.ComponentModel.NullableConverter nullableConverter = new System.ComponentModel.NullableConverter(type);
                        //将type转换为nullable对的基础基元类型  
                        type = nullableConverter.UnderlyingType;
                    }
                    if (dr.Table.Columns.Contains(pi.Name.ToUpper()))
                    {
                        object value = dr[pi.Name.ToUpper()];
                        if (value != DBNull.Value)
                            pi.SetValue(t, Convert.ChangeType(value, type), null);
                    }


                    //prop.SetValue(obj, value, null);

                    //tempName = pi.Name;  // 检查DataTable是否包含此列    

                    //if (dt.Columns.Contains(tempName))
                    //{
                    //    // 判断此属性是否有Setter      
                    //    if (!pi.CanWrite) continue;

                    //    object value = dr[tempName];
                    //    if (value != DBNull.Value)
                    //        pi.SetValue(t, value, null);
                    //}
                }
                ts.Add(t);
            }
            return ts;
        }
    }
}
