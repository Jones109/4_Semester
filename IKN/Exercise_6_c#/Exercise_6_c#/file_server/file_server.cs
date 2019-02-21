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

		System.Net.IPAddress ipaddress = System.Net.IPAddress.Parse("10.0.0.1");


		/// <summary>
		/// Initializes a new instance of the <see cref="file_server"/> class.
		/// Opretter en socket.
		/// Venter på en connect fra en klient.
		/// Modtager filnavn
		/// Finder filstørrelsen
		/// Kalder metoden sendFile
		/// Lukker socketen og programmet
		/// </summary>
		private file_server()
		{
			TcpListener serverSocket = new TcpListener(ipaddress, PORT);
			serverSocket.Start();

			Byte[] bytes = new byte[BUFSIZE];
			String data = null;

			while (true)
			{
				try
				{
					Console.WriteLine("Waiting for a connection");

					TcpClient client = serverSocket.AcceptTcpClient();
					Console.WriteLine("Connected with client");

					NetworkStream stream = client.GetStream();

					int i;
					while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
					{
						// Translate data bytes to a ASCII string.
						data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
						Console.WriteLine("Received: {0}", data);

					}
					client.Close();

				}
				catch (Exception e)
				{

					Console.WriteLine(e.ToString());
				}

			}
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
				byte[] msg = System.Text.Encoding.ASCII.GetBytes(fileName);

				io.Write(msg, 0, msg.Length);

				Console.WriteLine("Sent: {0}", fileName);
        }

		/// <summary>
		/// The entry point of the program, where the program control starts and ends.
		/// </summary>
		/// <param name='args'>
		/// The command-line arguments.
		/// </param>
			public static void Main(string[] args)
            {
                Console.WriteLine("Server starts...");
                new file_server();

            }
	}
}
