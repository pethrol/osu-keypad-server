using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;

namespace osu_keypad_server {

    class Server {
        private class State {
            public byte[] buffer = new byte[4];
        }
        private Server() { }
        private static Server _instance;
        public static Server GetInstance() {
            if (_instance == null) {
                _instance = new Server();
            }
            return _instance;
        }


        private bool running = false;
        public bool isRunning() {
            return running;
        }

        private State state;
        private Socket _socket;
        private IPEndPoint endPoint;
        private EndPoint endPointFrom = new IPEndPoint(IPAddress.Any, 9121);
        private AsyncCallback recv = null;

        public void Start(IPAddress ip) {
            state = new State();
            
            
            endPoint = new IPEndPoint(ip, 9121);

            try {
                _socket = new Socket(ip.AddressFamily, SocketType.Dgram, ProtocolType.Udp);
                _socket.Bind(endPoint);
            }
            catch(Exception) {
                MessageBox.Show("Cannot bind socket, check if the ip is correct and port 9121 is free. Code: 201");
            }

            if(!_socket.IsBound) {
                return;
            }
            running = true;
            //MessageBox.Show("Server started on "+ ip + " and port 9121");
            Task.Run(() => Receive());
        }

        private void Receive() {
            _socket.BeginReceiveFrom(state.buffer, 0, 4, SocketFlags.None, ref endPointFrom, recv = (ar) => {
                State so = (State)ar.AsyncState;
                try {
                    int bytes = _socket.EndReceiveFrom(ar, ref endPointFrom);
                    _socket.BeginReceiveFrom(so.buffer, 0, 4, SocketFlags.None, ref endPointFrom, recv, so);

                    DoClick(BitConverter.ToInt32(so.buffer, 0));
                } catch(Exception) {
                    //MessageBox.Show("Server went off");
                }
                
            }, state);

        }

        public void Dispose() {
            try {
                _socket.Shutdown(SocketShutdown.Both);
                _socket.Close();
                running = false;
            } catch(Exception) {
                MessageBox.Show("Cannot shutdown");

            }
            
        }

        private static InputSimulator inputSimulator = new InputSimulator();
        private static void DoClick(int whichKey) {
            WindowsInput.Native.VirtualKeyCode vcKeyA = (WindowsInput.Native.VirtualKeyCode)MainForm.keyA;

            WindowsInput.Native.VirtualKeyCode vcKeyB = (WindowsInput.Native.VirtualKeyCode)MainForm.keyB;


            //Console.WriteLine(whichKey);
            if (whichKey == 0) {//a down
                inputSimulator.Keyboard.KeyDown(vcKeyA);
            }
            else if (whichKey == 1) {//a up
                inputSimulator.Keyboard.KeyUp(vcKeyA);
            }
            else if (whichKey == 2) {//b down
                inputSimulator.Keyboard.KeyDown(vcKeyB);
            }
            else if (whichKey == 3) {//b up
                inputSimulator.Keyboard.KeyUp(vcKeyB);
            }
        }
    }





}
