using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SaraAlertApi
{
    public class ColumnAttribute : Attribute
    {
        public ColumnAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }

    public class PropertyMetadata
    {
        public Type PropertyType { get; set; }
        public PropertyInfo PropertyInfo { get; set; }
        public string PropertyName { get; set; }
        public string ColumnName { get; set; }
    }
}
