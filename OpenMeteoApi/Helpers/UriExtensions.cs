using System.Text;
using System.Web;
using System;
using System.Linq;

namespace OpenMeteoApi.Helpers;

public static class UriExtensions
{
    public static UriBuilder AddQuery(this UriBuilder ub, string name, string[] value)
    {
        var sb = new StringBuilder(ub.Query);
        sb.Append(sb.Length is 0 ? "?" : "&");
        sb.Append(name);
        sb.Append("=");
        sb.Append(string.Join(",", value));
        ub.Query = sb.ToString();
        return ub;
    }
    public static UriBuilder AddQuery(this UriBuilder ub, string name, string value)
    {
        var sb = new StringBuilder(ub.Query);
        sb.Append(sb.Length is 0 ? "?" : "&");
        sb.Append(name);
        sb.Append("=");
        sb.Append(value);
        ub.Query = sb.ToString();
        return ub;
    }

}