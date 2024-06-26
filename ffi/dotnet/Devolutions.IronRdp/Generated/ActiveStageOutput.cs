// <auto-generated/> by Diplomat

#pragma warning disable 0105
using System;
using System.Runtime.InteropServices;

using Devolutions.IronRdp.Diplomat;
#pragma warning restore 0105

namespace Devolutions.IronRdp;

#nullable enable

public partial class ActiveStageOutput: IDisposable
{
    private unsafe Raw.ActiveStageOutput* _inner;

    public ConnectionActivationSequence DeactivateAll
    {
        get
        {
            return GetDeactivateAll();
        }
    }

    public ActiveStageOutputType EnumType
    {
        get
        {
            return GetEnumType();
        }
    }

    public InclusiveRectangle GraphicsUpdate
    {
        get
        {
            return GetGraphicsUpdate();
        }
    }

    public DecodedPointer PointerBitmap
    {
        get
        {
            return GetPointerBitmap();
        }
    }

    public Position PointerPosition
    {
        get
        {
            return GetPointerPosition();
        }
    }

    public BytesSlice ResponseFrame
    {
        get
        {
            return GetResponseFrame();
        }
    }

    public GracefulDisconnectReason Terminate
    {
        get
        {
            return GetTerminate();
        }
    }

    /// <summary>
    /// Creates a managed <c>ActiveStageOutput</c> from a raw handle.
    /// </summary>
    /// <remarks>
    /// Safety: you should not build two managed objects using the same raw handle (may causes use-after-free and double-free).
    /// <br/>
    /// This constructor assumes the raw struct is allocated on Rust side.
    /// If implemented, the custom Drop implementation on Rust side WILL run on destruction.
    /// </remarks>
    public unsafe ActiveStageOutput(Raw.ActiveStageOutput* handle)
    {
        _inner = handle;
    }

    /// <returns>
    /// A <c>ActiveStageOutputType</c> allocated on C# side.
    /// </returns>
    public ActiveStageOutputType GetEnumType()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("ActiveStageOutput");
            }
            Raw.ActiveStageOutputType retVal = Raw.ActiveStageOutput.GetEnumType(_inner);
            return (ActiveStageOutputType)retVal;
        }
    }

    /// <exception cref="IronRdpException"></exception>
    /// <returns>
    /// A <c>BytesSlice</c> allocated on Rust side.
    /// </returns>
    public BytesSlice GetResponseFrame()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("ActiveStageOutput");
            }
            Raw.SessionFfiResultBoxBytesSliceBoxIronRdpError result = Raw.ActiveStageOutput.GetResponseFrame(_inner);
            if (!result.isOk)
            {
                throw new IronRdpException(new IronRdpError(result.Err));
            }
            Raw.BytesSlice* retVal = result.Ok;
            return new BytesSlice(retVal);
        }
    }

    /// <exception cref="IronRdpException"></exception>
    /// <returns>
    /// A <c>InclusiveRectangle</c> allocated on Rust side.
    /// </returns>
    public InclusiveRectangle GetGraphicsUpdate()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("ActiveStageOutput");
            }
            Raw.SessionFfiResultBoxInclusiveRectangleBoxIronRdpError result = Raw.ActiveStageOutput.GetGraphicsUpdate(_inner);
            if (!result.isOk)
            {
                throw new IronRdpException(new IronRdpError(result.Err));
            }
            Raw.InclusiveRectangle* retVal = result.Ok;
            return new InclusiveRectangle(retVal);
        }
    }

    /// <exception cref="IronRdpException"></exception>
    /// <returns>
    /// A <c>Position</c> allocated on C# side.
    /// </returns>
    public Position GetPointerPosition()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("ActiveStageOutput");
            }
            Raw.SessionFfiResultPositionBoxIronRdpError result = Raw.ActiveStageOutput.GetPointerPosition(_inner);
            if (!result.isOk)
            {
                throw new IronRdpException(new IronRdpError(result.Err));
            }
            Raw.Position retVal = result.Ok;
            return new Position(retVal);
        }
    }

    /// <exception cref="IronRdpException"></exception>
    /// <returns>
    /// A <c>DecodedPointer</c> allocated on Rust side.
    /// </returns>
    public DecodedPointer GetPointerBitmap()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("ActiveStageOutput");
            }
            Raw.SessionFfiResultBoxDecodedPointerBoxIronRdpError result = Raw.ActiveStageOutput.GetPointerBitmap(_inner);
            if (!result.isOk)
            {
                throw new IronRdpException(new IronRdpError(result.Err));
            }
            Raw.DecodedPointer* retVal = result.Ok;
            return new DecodedPointer(retVal);
        }
    }

    /// <exception cref="IronRdpException"></exception>
    /// <returns>
    /// A <c>GracefulDisconnectReason</c> allocated on Rust side.
    /// </returns>
    public GracefulDisconnectReason GetTerminate()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("ActiveStageOutput");
            }
            Raw.SessionFfiResultBoxGracefulDisconnectReasonBoxIronRdpError result = Raw.ActiveStageOutput.GetTerminate(_inner);
            if (!result.isOk)
            {
                throw new IronRdpException(new IronRdpError(result.Err));
            }
            Raw.GracefulDisconnectReason* retVal = result.Ok;
            return new GracefulDisconnectReason(retVal);
        }
    }

    /// <exception cref="IronRdpException"></exception>
    /// <returns>
    /// A <c>ConnectionActivationSequence</c> allocated on Rust side.
    /// </returns>
    public ConnectionActivationSequence GetDeactivateAll()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("ActiveStageOutput");
            }
            Raw.SessionFfiResultBoxConnectionActivationSequenceBoxIronRdpError result = Raw.ActiveStageOutput.GetDeactivateAll(_inner);
            if (!result.isOk)
            {
                throw new IronRdpException(new IronRdpError(result.Err));
            }
            Raw.ConnectionActivationSequence* retVal = result.Ok;
            return new ConnectionActivationSequence(retVal);
        }
    }

    /// <summary>
    /// Returns the underlying raw handle.
    /// </summary>
    public unsafe Raw.ActiveStageOutput* AsFFI()
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

            Raw.ActiveStageOutput.Destroy(_inner);
            _inner = null;

            GC.SuppressFinalize(this);
        }
    }

    ~ActiveStageOutput()
    {
        Dispose();
    }
}
