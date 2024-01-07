using System;
using System.Collections;

namespace OpenMeteoApi.Helpers;

internal static class VariablesHelper
{
    public static string[] GetAllVariables(Type type)
    {
        var fields = type.GetFields();
        var arrayList = new ArrayList();
        foreach(var field in fields)
        {
            if (field.FieldType != typeof(string) || !field.IsStatic) continue;
            arrayList.Add(field.GetRawConstantValue());
        }
        return (string[])arrayList.ToArray(typeof(string));
    }
}