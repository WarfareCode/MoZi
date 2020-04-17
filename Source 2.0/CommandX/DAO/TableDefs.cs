using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;


namespace DAO
{
    [DefaultMember("Item"), CompilerGenerated, Guid("0000004B-0000-0010-8000-00AA006D2EA4"), TypeIdentifier]
    [ComImport]
    public interface TableDefs : IEnumerable, _DynaCollection, _Collection
    {
        void _VtblGap1_1();

        [DispId(-4)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(EnumeratorToEnumVariantMarshaler))]
        IEnumerator GetEnumerator();

        [DispId(1610743810)]
        void Refresh();
    }

    internal class EnumeratorToEnumVariantMarshaler
    {
    }
}
