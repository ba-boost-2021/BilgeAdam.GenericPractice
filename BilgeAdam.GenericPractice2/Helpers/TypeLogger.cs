using System.Text;

namespace BilgeAdam.GenericPractice2.Helpers
{
    public class TypeLogger
    {
        public string GetTypeProperties<T>()
        {
            var type = typeof(T);
            var str = new StringBuilder();
            str.Append(type.FullName + ",");
            str.Append(type.Name + ",");
            if (type.IsClass) str.Append("Class,");
            if (type.IsEnum) str.Append("Enum,");
            if (type.IsInterface) str.Append("Interface,");
            if (type.IsAbstract) str.Append("Abstract,");
            if (type.IsPrimitive) str.Append("Primitive,");
            if (type.IsValueType) str.Append("ValueType,");
            var interfaces = type.GetInterfaces();
            if (interfaces.Any())
            {
                foreach (var _interface in interfaces)
                {
                    str.Append(_interface.Name + ",");
                }
            }
            //var type = typeof(T);
            //var strList = new List<string>();
            //strList.Add(type.FullName);
            //strList.Add(type.Name);
            //strList.Add(type.FullName);
            //strList.Add(type.FullName);
            //strList.Add(type.FullName);
            //if (type.IsClass) strList.Add("Class");
            //var interfaces = type.GetInterfaces();
            //if (interfaces.Any())
            //{
            //    foreach (var _interface in interfaces)
            //    {
            //        strList.Add(_interface.Name);
            //    }
            //}

            //return string.Join(',', strList);
            return str.ToString();
        }
    }
}