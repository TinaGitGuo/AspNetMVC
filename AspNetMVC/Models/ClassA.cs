using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace AspNetMVC.Models
{
    public static class ClassA
    {
        public static t field<t>(this IDataRecord record, string fieldname)
        {
            t fieldvalue = default(t);
            for (int i = 0; i < record.FieldCount; i++)
            {
                if (string.Equals(record.GetName(i), fieldname, StringComparison.OrdinalIgnoreCase))
                {
                    if (record[i] != DBNull.Value)
                    {
                        fieldvalue = (t)record[fieldname];
                    }
                }
            }
            return fieldvalue;
        }
        //        呵呵，这个idatarecord的扩展有点像linq to dataset中得到字段值的操作了。另外idatareader是继承了idatarecord所以这个扩展方法idatareader也可以使用。
        //有个上面的两个扩展方法之后，还需要一个对idatareader的扩展，代码如下：
        public static IEnumerable<t> getenumerator<t>(this IDataReader reader,
        Func<IDataRecord, t> generator)
        {
            while (reader.Read())

                yield return generator(reader);
        }
        //        实现都很简单，下面看看如何使

        //        此文来自: 马开东博客 转载请注明出处 网址： http://www.makaidong.com 
        //用（代码片段）：
    }
}