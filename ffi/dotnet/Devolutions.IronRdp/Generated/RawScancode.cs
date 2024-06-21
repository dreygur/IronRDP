// <auto-generated/> by Diplomat

#pragma warning disable 0105
using System;
using System.Runtime.InteropServices;

using Devolutions.IronRdp.Diplomat;
#pragma warning restore 0105

namespace Devolutions.IronRdp.Raw;

#nullable enable

[StructLayout(LayoutKind.Sequential)]
public partial struct Scancode
{
    private const string NativeLib = "DevolutionsIronRdp";

    [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Scancode_from_u8", ExactSpelling = true)]
    public static unsafe extern Scancode* FromU8([MarshalAs(UnmanagedType.U1)] bool extended, byte code);

    [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Scancode_from_u16", ExactSpelling = true)]
    public static unsafe extern Scancode* FromU16(ushort code);

    [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Scancode_as_operation_key_pressed", ExactSpelling = true)]
    public static unsafe extern Operation* AsOperationKeyPressed(Scancode* self);

    [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Scancode_as_operation_key_released", ExactSpelling = true)]
    public static unsafe extern Operation* AsOperationKeyReleased(Scancode* self);

    [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Scancode_destroy", ExactSpelling = true)]
    public static unsafe extern void Destroy(Scancode* self);
}
