using System;
using DotNetLaunchDashboard.Models;
using Newtonsoft.Json;
using SocketIOClient;
using SocketIOClient.Arguments;

namespace DotNetLaunchDashboard.Live
{
    public class LiveTelemetry : IDisposable
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

            _socket.On("raw", HandleRawTelemetry);
            _socket.On("analysed", HandleAnalysedTelemetry);
        }

        public async void Start()
        {
            await _socket.ConnectAsync();
            await _socket.EmitAsync("join", (object) new[] {"raw", "analysed"});
        }

        public async void Stop()
        {
            await _socket.CloseAsync();
        }

        /// <inheritdoc />
        public void Dispose()
        {
            _socket?.Dispose();
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

        private void HandleRawTelemetry(ResponseArgs args)
        {
            var deserializedArgs = JsonConvert.DeserializeObject<TelemetryChunkModel>(args.Text);
            OnRawTelemetry?.Invoke(this, deserializedArgs);
        }

        private void HandleAnalysedTelemetry(ResponseArgs args)
        {
            var deserializedArgs = JsonConvert.DeserializeObject<AnalysedTelemetryChunkModel>(args.Text);
            OnAnalysedTelemetry?.Invoke(this, deserializedArgs);
        }
    }
}
