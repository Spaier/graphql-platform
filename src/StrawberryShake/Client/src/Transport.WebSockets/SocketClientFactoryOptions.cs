using System;
using System.Collections.Generic;
using System.Net.WebSockets;

namespace StrawberryShake.Transport.WebSockets
{
    public class SocketClientFactoryOptions
    {
        /// <summary>
        /// Gets a list of operations used to configure an <see cref="ClientWebSocket"/>.
        /// </summary>
        public IList<Action<ISocketClient>> WebSocketClientActions { get; } =
            new List<Action<ISocketClient>>();

        public IList<ISocketProtocol> Protocols { get; } = new List<ISocketProtocol>();
    }
}
