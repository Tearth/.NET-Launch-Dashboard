using System;
using DotNetLaunchDashboard.Models;
using SocketIOClient;
using SocketIOClient.Arguments;
using EventHandler = SocketIOClient.EventHandler;

namespace DotNetLaunchDashboard.Live
{
    public class LiveTelemetry
    {
        public event EventHandler<EventArgs> OnConnected;
        public event EventHandler<ServerCloseReason> OnClosed;
        public event EventHandler<ResponseArgs> OnError;
        public event EventHandler<TelemetryChunkModel> OnRawTelemetry;
        public event EventHandler<AnalysedTelemetryChunkModel> OnAnalysedTelemetry;

        private readonly SocketIO _socket;

        public LiveTelemetry()
        {
            _socket = new SocketIO(Configuration.BaseApiAddress);
            _socket.OnConnected += SocketOnConnected;
            _socket.OnClosed += SocketOnClosed;
            _socket.OnError += SocketOnError;
        }

        public async void Start()
        {
            await _socket.ConnectAsync();
        }

        public async void Stop()
        {
            await _socket.CloseAsync();
        }

        private void SocketOnConnected()
        {
            OnConnected?.Invoke(this, null);
        }

        private void SocketOnClosed(ServerCloseReason reason)
        {
            OnClosed?.Invoke(this, reason);
        }

        private void SocketOnError(ResponseArgs obj)
        {
            OnError?.Invoke(this, obj);
        }
    }
}
