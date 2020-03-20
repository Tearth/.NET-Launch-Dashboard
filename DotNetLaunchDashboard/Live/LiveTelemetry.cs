using System;
using DotNetLaunchDashboard.Models;
using Newtonsoft.Json;
using SocketIOClient;
using SocketIOClient.Arguments;

namespace DotNetLaunchDashboard.Live
{
    /// <summary>
    /// Core of the live telemetry, use this class to receive data in real time.
    /// </summary>
    public class LiveTelemetry : IDisposable
    {
        /// <summary>
        /// An event fired when the client has been connected to the server.
        /// </summary>
        public event EventHandler<EventArgs> OnConnected;

        /// <summary>
        /// An event fired when the client has closed connection with the server (intentionally or not).
        /// </summary>
        public event EventHandler<ServerCloseReason> OnClosed;

        /// <summary>
        /// An event fired when there was some error during communication between the client and server.
        /// </summary>
        public event EventHandler<ResponseArgs> OnError;

        /// <summary>
        /// An event fired when the client has received a chunk of the raw telemetry.
        /// </summary>
        public event EventHandler<TelemetryChunkModel> OnRawTelemetry;

        /// <summary>
        /// An event fired when the client has received a chunk of the analysed telemetry.
        /// </summary>
        public event EventHandler<AnalysedTelemetryChunkModel> OnAnalysedTelemetry;

        private readonly SocketIO _socket;

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveTelemetry"/> class.
        /// </summary>
        public LiveTelemetry()
        {
            _socket = new SocketIO(Configuration.BaseApiAddress);
            _socket.OnConnected += SocketOnConnected;
            _socket.OnClosed += SocketOnClosed;
            _socket.OnError += SocketOnError;

            _socket.On("raw", HandleRawTelemetry);
            _socket.On("analysed", HandleAnalysedTelemetry);
        }

        /// <summary>
        /// Connects to the server and initializes communication. After complete call, you should start receiving telemetry from
        /// the server. If you want to stop it, use <see cref="Stop"/> method.
        /// </summary>
        public async void Start()
        {
            await _socket.ConnectAsync();
            await _socket.EmitAsync("join", (object) new[] {"raw", "analysed"});
        }

        /// <summary>
        /// Disconnects from the server. You won't receive any telemetry after call. If you want to resume, use <see cref="Start"/> method.
        /// </summary>
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

        private void SocketOnError(ResponseArgs args)
        {
            OnError?.Invoke(this, args);
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
