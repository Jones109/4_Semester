using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace tcp
{
	class file_client
    {
        private NetworkStream serverStream;

        /// <summary>
        /// The PORT.
        /// </summary>
        const int PORT = 9000;
		/// <summary>
		/// The BUFSIZE.
		/// </summary>
		const int BUFSIZE = 1000;

		const string server = "10.0.0.1";

		/// <summary>
		/// Initializes a new instance of the <see cref="file_client"/> class.
		/// </summary>
		/// <param name='args'>
		/// The command-line arguments. First ip-adress of the server. Second the filename
		/// </param>
		private file_client (string[] args)
        {
			try{
				TcpClient client = new System.Net.Sockets.TcpClient(server, PORT);

                Console.WriteLine("ClientSocket connected");
				NetworkStream stream = client.GetStream();
				client.Close();
				
			}catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }


        }

		/// <summary>
		/// Receives the file.
		/// </summary>
		/// <param name='fileName'>
		/// File name.
		/// </param>
		/// <param name='io'>
		/// Network stream for reading from the server
		/// </param>
		private void receiveFile (String fileName, NetworkStream stream)
        {
			Byte[] data = System.Text.Encoding.ASCII.GetBytes(fileName);

			stream.Write(data, 0, data.Length);
			Console.WriteLine("Sent: {0}", fileName);

			stream.Close();
        }

		/// <summary>
		/// The entry point of the program, where the program control starts and ends.
		/// </summary>
		/// <param name='args'>
		/// The command-line arguments.
		/// </param>
		public static void Main (string[] args)
		{
			Console.WriteLine ("Client starts...");
			new file_client(args);

		}
	}
}
