// Decompiled with JetBrains decompiler
// Type: TransmissionLine.My.InternalXmlHelper
// Assembly: TransmissionLine, Version=3.6.3.5, Culture=neutral, PublicKeyToken=null
// MVID: 92E11920-ED50-4C1F-99A1-3CFB7DCC3364
// Assembly location: C:\Users\Home\AppData\Local\Apps\2.0\477AE5HX.86E\PEE3MCH4.84B\tran..tion_127a55d62cc03faa_0003.0006_03fd5c6fef0309f2\TransmissionLine.exe

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace TransmissionLine.My
{
  [CompilerGenerated]
  [DebuggerNonUserCode]
  [EditorBrowsable(EditorBrowsableState.Never)]
  internal sealed class InternalXmlHelper
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    private InternalXmlHelper()
    {
    }

    public static string get_Value(IEnumerable<XElement> source)
    {
      IEnumerator<XElement> enumerator = null;
      try
      {
        enumerator = source.GetEnumerator();
        if (enumerator.MoveNext())
          return enumerator.Current.Value;
      }
      finally
      {
        enumerator?.Dispose();
      }
      return (string) null;
    }

    public static void set_Value(IEnumerable<XElement> source, string value)
    {
      IEnumerator<XElement> enumerator = null;
      try
      {
        enumerator = source.GetEnumerator();
        if (!enumerator.MoveNext())
          return;
        enumerator.Current.Value = value;
      }
      finally
      {
        enumerator?.Dispose();
      }
    }

    public static string get_AttributeValue(IEnumerable<XElement> source, XName name)
    {
      IEnumerator<XElement> enumerator = null;
      try
      {
        enumerator = source.GetEnumerator();
        if (enumerator.MoveNext())
          return (string) enumerator.Current.Attribute(name);
      }
      finally
      {
        enumerator?.Dispose();
      }
      return (string) null;
    }

    public static void set_AttributeValue(IEnumerable<XElement> source, XName name, string value)
    {
      IEnumerator<XElement> enumerator = null;
      try
      {
        enumerator = source.GetEnumerator();
        if (!enumerator.MoveNext())
          return;
        enumerator.Current.SetAttributeValue(name, (object) value);
      }
      finally
      {
        enumerator?.Dispose();
      }
    }

    public static string get_AttributeValue(XElement source, XName name) => (string) source.Attribute(name);

    public static void set_AttributeValue(XElement source, XName name, string value) => source.SetAttributeValue(name, (object) value);

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static XAttribute CreateAttribute(XName name, object value) => value == null ? (XAttribute) null : new XAttribute(name, RuntimeHelpers.GetObjectValue(value));

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static XAttribute CreateNamespaceAttribute(XName name, XNamespace ns)
    {
      XAttribute namespaceAttribute = new XAttribute(name, (object) ns.NamespaceName);
      namespaceAttribute.AddAnnotation((object) ns);
      return namespaceAttribute;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static object RemoveNamespaceAttributes(
      string[] inScopePrefixes,
      XNamespace[] inScopeNs,
      List<XAttribute> attributes,
      object obj)
    {
      switch (obj)
      {
        case XElement e:
          // ISSUE: reference to a compiler-generated method
          return (object) InternalXmlHelper.RemoveNamespaceAttributes(inScopePrefixes, inScopeNs, attributes, e);
        case IEnumerable enumerable:
          // ISSUE: reference to a compiler-generated method
          return (object) InternalXmlHelper.RemoveNamespaceAttributes(inScopePrefixes, inScopeNs, attributes, enumerable);
        default:
          return obj;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static IEnumerable RemoveNamespaceAttributes(
      string[] inScopePrefixes,
      XNamespace[] inScopeNs,
      List<XAttribute> attributes,
      IEnumerable obj)
    {
      if (obj == null)
        return obj;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: reference to a compiler-generated method
      return obj is IEnumerable<XElement> source ? (IEnumerable) source.Select<XElement, XElement>(new Func<XElement, XElement>(new InternalXmlHelper.RemoveNamespaceAttributesClosure(inScopePrefixes, inScopeNs, attributes).ProcessXElement)) : (IEnumerable) obj.Cast<object>().Select<object, object>(new Func<object, object>(new InternalXmlHelper.RemoveNamespaceAttributesClosure(inScopePrefixes, inScopeNs, attributes).ProcessObject));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static XElement RemoveNamespaceAttributes(
      string[] inScopePrefixes,
      XNamespace[] inScopeNs,
      List<XAttribute> attributes,
      XElement e)
    {
      XAttribute nextAttribute;
      if (e != null)
      {
        for (XAttribute xattribute = e.FirstAttribute; xattribute != null; xattribute = nextAttribute)
        {
          nextAttribute = xattribute.NextAttribute;
          if (xattribute.IsNamespaceDeclaration)
          {
            XNamespace xnamespace1 = xattribute.Annotation<XNamespace>();
            string localName1 = xattribute.Name.LocalName;
            if ((object) xnamespace1 != null)
            {
              if (inScopePrefixes != null && inScopeNs != null)
              {
                int num = checked (inScopePrefixes.Length - 1);
                int index = 0;
                while (index <= num)
                {
                  string inScopePrefix = inScopePrefixes[index];
                  XNamespace inScopeN = inScopeNs[index];
                  if (localName1.Equals(inScopePrefix))
                  {
                    if (xnamespace1 == inScopeN)
                      xattribute.Remove();
                    xattribute = (XAttribute) null;
                    break;
                  }
                  checked { ++index; }
                }
              }
              if (xattribute != null)
              {
                if (attributes != null)
                {
                  int num = checked (attributes.Count - 1);
                  int index = 0;
                  while (index <= num)
                  {
                    XAttribute attribute = attributes[index];
                    string localName2 = attribute.Name.LocalName;
                    XNamespace xnamespace2 = attribute.Annotation<XNamespace>();
                    if ((object) xnamespace2 != null && localName1.Equals(localName2))
                    {
                      if (xnamespace1 == xnamespace2)
                        xattribute.Remove();
                      xattribute = (XAttribute) null;
                      break;
                    }
                    checked { ++index; }
                  }
                }
                if (xattribute != null)
                {
                  xattribute.Remove();
                  attributes.Add(xattribute);
                }
              }
            }
          }
        }
      }
      return e;
    }

    // Type RemoveNamespaceAttributesClosure with token 02000009
    [/*Attribute with token 0C00002F*/DebuggerNonUserCode]
    [/*Attribute with token 0C000030*/CompilerGenerated]
    [/*Attribute with token 0C000031*/EditorBrowsable(EditorBrowsableState.Never)]
    private sealed class RemoveNamespaceAttributesClosure {
        // Field m_inScopePrefixes with token 0400000C
        private readonly string[] m_inScopePrefixes;
        // Field m_inScopeNs with token 0400000D
        private readonly XNamespace[] m_inScopeNs;
        // Field m_attributes with token 0400000E
        private readonly List<XAttribute> m_attributes;

        // Method .ctor with token 06000030
        [/*Attribute with token 0C000090*/EditorBrowsable(EditorBrowsableState.Never)]
        internal RemoveNamespaceAttributesClosure(
            /*Parameter with token 08000029*/string[] inScopePrefixes,
            /*Parameter with token 0800002A*/XNamespace[] inScopeNs,
            /*Parameter with token 0800002B*/List<XAttribute> attributes)
        {
            this.m_inScopePrefixes = inScopePrefixes;
            this.m_inScopeNs = inScopeNs;
            this.m_attributes = attributes;
        }

        // Method ProcessXElement with token 06000031
        [/*Attribute with token 0C000092*/EditorBrowsable(EditorBrowsableState.Never)]
        internal XElement ProcessXElement(/*Parameter with token 0800002C*/XElement elem) {
            return InternalXmlHelper.RemoveNamespaceAttributes(this.m_inScopePrefixes, this.m_inScopeNs, this.m_attributes, elem);
        }

        // Method ProcessObject with token 06000032
        [/*Attribute with token 0C000093*/EditorBrowsable(EditorBrowsableState.Never)]
        internal object ProcessObject(/*Parameter with token 0800002D*/object obj) {
            if (obj is XElement e)
                return (object) InternalXmlHelper.RemoveNamespaceAttributes(this.m_inScopePrefixes, this.m_inScopeNs, this.m_attributes, e);
            return obj;
        }
    }
  }


}
