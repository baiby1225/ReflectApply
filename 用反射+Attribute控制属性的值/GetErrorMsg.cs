using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace 用反射_Attribute控制属性的值
{
    public static class GetErrorMsg
    {
        public static string Check<T>(T t)
        {
            string errMsg = "";
            PropertyInfo[] propers = t.GetType().GetProperties();
            foreach (var item in propers)
            {
                CheckAttribute[] personcheckattr = (CheckAttribute[])item.GetCustomAttributes(typeof(CheckAttribute), false);
                foreach (CheckAttribute item1 in personcheckattr)
                {
                    if (item1.CheckEmpty)
                    {
                        //CheckEmpyt 可以打在 int类型或者 string类型的字段上，
                        //如果打在int类型的字段上，不给该字段赋值，那么toString()后=0 所以加上catch
                        try
                        {
                            int obj = int.Parse(item.GetValue(t, null).ToString());
                            if (obj == 0)
                            {
                                errMsg += Environment.NewLine + string.Format("{0} 不可为空！", item.Name);
                            }
                        }
                        catch
                        {
                            string obj = item.GetValue(t, null).ToString();
                            if (string.IsNullOrEmpty(obj))
                            {
                                errMsg += Environment.NewLine + string.Format("{0} 不可为空！", item.Name);
                            }
                        }

                    }
                    if (item1.CheckNumberArea)
                    {
                        int obj = int.Parse(item.GetValue(t, null).ToString());
                        if (!obj.BetWeenNumber(item1.MaxNumber, item1.MinNumber))
                        {
                            errMsg += Environment.NewLine + string.Format("{0} 大小不在有效的范围内", item.Name);
                        }
                    }
                    if (item1.CheckLengthArea)
                    {
                        string obj = item.GetValue(t, null).ToString();
                        if (!obj.BetWeenLength(item1.MaxLength, item1.MinNumber))
                        {
                            errMsg += Environment.NewLine + string.Format("{0} 长度不在有效的范围内", item.Name);
                        }
                    }
                    if (item1.CheckRegex)
                    {
                        string obj = item.GetValue(t, null).ToString();
                        if (!System.Text.RegularExpressions.Regex.IsMatch(obj, item1.Regex))
                        {
                            errMsg += Environment.NewLine + string.Format("{0} 格式不正确", item.Name);
                        }
                    }
                }

            }
            return errMsg;
        }
    }
}
