// <auto-generated/> by Diplomat

#pragma warning disable 0105
using System;
using System.Runtime.InteropServices;

using Devolutions.IronRdp.Diplomat;
#pragma warning restore 0105

namespace Devolutions.IronRdp.Raw;

#nullable enable

[StructLayout(LayoutKind.Sequential)]
public partial struct InclusiveRectangle
{
    private const string NativeLib = "DevolutionsIronRdp";

    [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "InclusiveRectangle_get_left", ExactSpelling = true)]
    public static unsafe extern ushort GetLeft(InclusiveRectangle* self);

    [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "InclusiveRectangle_get_top", ExactSpelling = true)]
    public static unsafe extern ushort GetTop(InclusiveRectangle* self);

    [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "InclusiveRectangle_get_right", ExactSpelling = true)]
    public static unsafe extern ushort GetRight(InclusiveRectangle* self);

    [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "InclusiveRectangle_get_bottom", ExactSpelling = true)]
    public static unsafe extern ushort GetBottom(InclusiveRectangle* self);

    [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "InclusiveRectangle_get_width", ExactSpelling = true)]
    public static unsafe extern ushort GetWidth(InclusiveRectangle* self);

    [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "InclusiveRectangle_get_height", ExactSpelling = true)]
    public static unsafe extern ushort GetHeight(InclusiveRectangle* self);

    [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "InclusiveRectangle_destroy", ExactSpelling = true)]
    public static unsafe extern void Destroy(InclusiveRectangle* self);
}
