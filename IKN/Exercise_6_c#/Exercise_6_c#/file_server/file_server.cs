using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace tcp
{
	class file_server
	{
		/// <summary>
		/// The PORT
		/// </summary>
		const int PORT = 9000;
		/// <summary>
		/// The BUFSIZE
		/// </summary>
		const int BUFSIZE = 1000;

        private int requestCount = 0;

        private TcpClient clientSocket;
        private TcpListener serverSocket;


        /// <summary>
        /// Initializes a new instance of the <see cref="file_server"/> class.
        /// Opretter en socket.
        /// Venter på en connect fra en klient.
        /// Modtager filnavn
        /// Finder filstørrelsen
        /// Kalder metoden sendFile
        /// Lukker socketen og programmet
        /// </summary>
        private file_server ()
		{
            serverSocket = new TcpListener(8888);
            requestCount = 0;
            clientSocket = default(TcpClient);
            serverSocket.Start();
            Console.WriteLine("Server started");
            clientSocket = serverSocket.AcceptTcpClient();
            Console.WriteLine("Accepted connection from client");
            requestCount = 0;
        }

		/// <summary>
		/// Sends the file.
		/// </summary>
		/// <param name='fileName'>
		/// The filename.
		/// </param>
		/// <param name='fileSize'>
		/// The filesize.
		/// </param>
		/// <param name='io'>
		/// Network stream for writing to the client.
		/// </param>
		private void sendFile (String fileName, long fileSize, NetworkStream io)
        {
            requestCount += 1;
            NetworkStream networkStream = clientSocket.GetStream();
            byte[] bytesFrom = new byte[10025];
            networkStream.Read(bytesFrom, 0, (int) clientSocket.ReceiveBufferSize);
            string dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
            dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
            Console.WriteLine(" >> Data from client - " + dataFromClient);

            string serverResponse = "Last Message from client" + dataFromClient;
            Byte[] sendBytes = Encoding.ASCII.GetBytes(serverResponse);
            networkStream.Write(sendBytes, 0, sendBytes.Length);
            networkStream.Flush();
            Console.WriteLine(" >> " + serverResponse);

            clientSocket.Close();
            serverSocket.Stop();
            Console.WriteLine("Exit");
        }

		/// <summary>
		/// The entry point of the program, where the program control starts and ends.
		/// </summary>
		/// <param name='args'>
		/// The command-line arguments.
		/// </param>
		public static void Main (string[] args)
		{
			Console.WriteLine ("Server starts...");
			new file_server();
		}
	}
}