using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace reflection_demo
{
    public class EventTypeAttribute : Attribute
    {
        public int index;
        public String name;
        public String desc;
        public String templateNo;
        public String type;
        public EventTypeAttribute(int index, string name, string desc, string templateNo, string type)
        {
            this.index = index;
            this.name = name;
            this.desc = desc;
            this.templateNo = templateNo;
            this.type = type;
        }
    }
    public class EventType
    {
        /// <summary>
        /// 缓存数据
        /// </summary>
        public static readonly List<EventTypeAttribute> Values;
        static EventType()
        {
            Values = InitData();
        }
        public static List<EventTypeAttribute> InitData()
        {
            List<EventTypeAttribute> res = null;
            Type t = typeof(EventType);
            FieldInfo[] fieldInfoList = t.GetFields();
            if (fieldInfoList != null && fieldInfoList.Any())
            {
                res = new List<EventTypeAttribute>();
                EventTypeAttribute temp = null;
                foreach (FieldInfo fieldInfo in fieldInfoList)
                {
                    temp = fieldInfo.GetValue(t) as EventTypeAttribute;
                    if (temp!=null)
                    {
                        res.Add(temp);
                    }                    
                }
            }
            return res;
        }
        /// <summary>
        /// 支付失败,sms
        /// </summary>
        //public static EventTypeAttribute SMS_TEMPLATE_PAY_FAIL = new EventTypeAttribute(-1, "payFailure", "支付失败", "1234", "sms");

        /// <summary>
        /// 支付成功,sms
        /// </summary>
        //public static EventTypeAttribute SMS_TEMPLATE_PAY_SUCCESS = new EventTypeAttribute(1, "paySuccess", "支付成功", "5678", "sms");
    }
    class Program
    {
        static void Main(string[] args)
        {
            var EventTypeAttribute = EventType.Values?.Find(x => x.index.ToString() == "11" && x.type == "sms");
        }
    }
}
