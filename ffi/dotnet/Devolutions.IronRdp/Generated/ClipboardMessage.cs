// <auto-generated/> by Diplomat

#pragma warning disable 0105
using System;
using System.Runtime.InteropServices;

using Devolutions.IronRdp.Diplomat;
#pragma warning restore 0105

namespace Devolutions.IronRdp;

#nullable enable

public partial class ClipboardMessage: IDisposable
{
    private unsafe Raw.ClipboardMessage* _inner;

    public ClipboardMessageType MessageType
    {
        get
        {
            return GetMessageType();
        }
    }

    public FormatDataResponse? SendFormatData
    {
        get
        {
            return GetSendFormatData();
        }
    }

    public ClipboardFormatIterator? SendInitiateCopy
    {
        get
        {
            return GetSendInitiateCopy();
        }
    }

    public ClipboardFormatId? SendInitiatePaste
    {
        get
        {
            return GetSendInitiatePaste();
        }
    }

    /// <summary>
    /// Creates a managed <c>ClipboardMessage</c> from a raw handle.
    /// </summary>
    /// <remarks>
    /// Safety: you should not build two managed objects using the same raw handle (may causes use-after-free and double-free).
    /// <br/>
    /// This constructor assumes the raw struct is allocated on Rust side.
    /// If implemented, the custom Drop implementation on Rust side WILL run on destruction.
    /// </remarks>
    public unsafe ClipboardMessage(Raw.ClipboardMessage* handle)
    {
        _inner = handle;
    }

    /// <returns>
    /// A <c>ClipboardMessageType</c> allocated on C# side.
    /// </returns>
    public ClipboardMessageType GetMessageType()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("ClipboardMessage");
            }
            Raw.ClipboardMessageType retVal = Raw.ClipboardMessage.GetMessageType(_inner);
            return (ClipboardMessageType)retVal;
        }
    }

    /// <returns>
    /// A <c>ClipboardFormatIterator</c> allocated on Rust side.
    /// </returns>
    public ClipboardFormatIterator? GetSendInitiateCopy()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("ClipboardMessage");
            }
            Raw.ClipboardFormatIterator* retVal = Raw.ClipboardMessage.GetSendInitiateCopy(_inner);
            if (retVal == null)
            {
                return null;
            }
            return new ClipboardFormatIterator(retVal);
        }
    }

    /// <returns>
    /// A <c>FormatDataResponse</c> allocated on Rust side.
    /// </returns>
    public FormatDataResponse? GetSendFormatData()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("ClipboardMessage");
            }
            Raw.FormatDataResponse* retVal = Raw.ClipboardMessage.GetSendFormatData(_inner);
            if (retVal == null)
            {
                return null;
            }
            return new FormatDataResponse(retVal);
        }
    }

    /// <returns>
    /// A <c>ClipboardFormatId</c> allocated on Rust side.
    /// </returns>
    public ClipboardFormatId? GetSendInitiatePaste()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("ClipboardMessage");
            }
            Raw.ClipboardFormatId* retVal = Raw.ClipboardMessage.GetSendInitiatePaste(_inner);
            if (retVal == null)
            {
                return null;
            }
            return new ClipboardFormatId(retVal);
        }
    }

    /// <summary>
    /// Returns the underlying raw handle.
    /// </summary>
    public unsafe Raw.ClipboardMessage* AsFFI()
    {
        return _inner;
    }

    /// <summary>
    /// Destroys the underlying object immediately.
    /// </summary>
    public void Dispose()
    {
        unsafe
        {
            if (_inner == null)
            {
                return;
            }

            Raw.ClipboardMessage.Destroy(_inner);
            _inner = null;

            GC.SuppressFinalize(this);
        }
    }

    ~ClipboardMessage()
    {
        Dispose();
    }
}