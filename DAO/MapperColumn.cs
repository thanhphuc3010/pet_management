﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DAO
{
    public class MapperColumn
    {
        public CustomPropertyTypeMap GetMap<T>()
        {
            var map = new CustomPropertyTypeMap(
                typeof(T), (type, columnName) => 
                    type.GetProperties().FirstOrDefault(prop => 
                        GetDescriptionFromAttribute(prop) == columnName.ToLower()));
            return map;
        }

        static string GetDescriptionFromAttribute(MemberInfo member)
        {
            if (member == null) return null;

            var attrib = (DescriptionAttribute)Attribute.GetCustomAttribute(member, typeof(DescriptionAttribute), false);
            return (attrib?.Description ?? member.Name).ToLower();
        }
    }
}
