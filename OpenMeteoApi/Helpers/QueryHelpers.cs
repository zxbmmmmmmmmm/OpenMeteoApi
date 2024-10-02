// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
namespace OpenMeteoApi.Helpers;


/// <summary>
/// Provides methods for parsing and manipulating query strings.
/// </summary>
public static class QueryHelpers
{
    /// <summary>
    /// Append the given query key and value to the URI.
    /// </summary>
    /// <param name="uri">The base URI.</param>
    /// <param name="name">The name of the query key.</param>
    /// <param name="value">The query value.</param>
    /// <returns>The combined result.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="uri"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentNullException"><paramref name="name"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentNullException"><paramref name="value"/> is <c>null</c>.</exception>
    public static string AddQueryString(string uri, string name, string value)
    {
        //ArgumentNullException.ThrowIfNull(uri);
        //ArgumentNullException.ThrowIfNull(name);
        //ArgumentNullException.ThrowIfNull(value);

        return AddQueryString(
            uri, new[] { new KeyValuePair<string, string>(name, value) });
    }

    /// <summary>
    /// Append the given query keys and values to the URI.
    /// </summary>
    /// <param name="uri">The base URI.</param>
    /// <param name="queryString">A dictionary of query keys and values to append.</param>
    /// <returns>The combined result.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="uri"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentNullException"><paramref name="queryString"/> is <c>null</c>.</exception>
    public static string AddQueryString(string uri, IDictionary<string, string> queryString)
    {
        //ArgumentNullException.ThrowIfNull(uri);
        //ArgumentNullException.ThrowIfNull(queryString);

        return AddQueryString(uri, (IEnumerable<KeyValuePair<string, string>>)queryString);
    }


    /// <summary>
    /// Append the given query keys and values to the URI.
    /// </summary>
    /// <param name="uri">The base URI.</param>
    /// <param name="queryString">A collection of name value query pairs to append.</param>
    /// <returns>The combined result.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="uri"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentNullException"><paramref name="queryString"/> is <c>null</c>.</exception>
    public static string AddQueryString(
        string uri,
        IEnumerable<KeyValuePair<string, string>> queryString)
    {
        //ArgumentNullException.ThrowIfNull(uri);
        //ArgumentNullException.ThrowIfNull(queryString);

        var anchorIndex = uri.IndexOf('#');
        var uriToBeAppended = uri.AsSpan();
        var anchorText = ReadOnlySpan<char>.Empty;
        // If there is an anchor, then the query string must be inserted before its first occurrence.
        if (anchorIndex != -1)
        {
            anchorText = uriToBeAppended.Slice(anchorIndex);
            uriToBeAppended = uriToBeAppended.Slice(0, anchorIndex);
        }

        var queryIndex = uriToBeAppended.IndexOf('?');
        var hasQuery = queryIndex != -1;

        var sb = new StringBuilder();
        sb.Append(uriToBeAppended.ToString());
        foreach (var parameter in queryString)
        {
            if (parameter.Value == null)
            {
                continue;
            }

            sb.Append(hasQuery ? '&' : '?');
            sb.Append(UrlEncoder.Default.Encode(parameter.Key));
            sb.Append('=');
            sb.Append(UrlEncoder.Default.Encode(parameter.Value));
            hasQuery = true;
        }

        sb.Append(anchorText.ToString());
        return sb.ToString();
    }

}
