using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using UnityEngine;

namespace JyFramework
{
    public class JySocketClient
    {
        protected Socket _client;

        private AddressFamily _address;
        private SocketType _socketType;
        private ProtocolType _protoType;

        private string _ip;
        private int _port;

        public JySocketClient(string ip, int port)
        {
            _ip = ip;
            _port = port;

            _protoType = ProtocolType.Tcp;
            _socketType = SocketType.Stream;
            _address = AddressFamily.InterNetwork;

            _client = new Socket(_address, _socketType, _protoType);
        }

        public void Connect()
        {            
            _client.BeginConnect(_ip, _port, OnAccpetMsg, null);
        }

        public void OnAccpetMsg(IAsyncResult ar)
        {
            _client.EndConnect(ar);

            byte[] buffer = new byte[1024];
            try
            {
                _client.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, callBack => {
                    int length = _client.EndReceive(callBack);
                    ReadMsg(buffer, length);
                    OnAccpetMsg(callBack);
                }, null);
            }
            catch(Exception e)
            {
                Debug.Log(e);
            }
            
        }

        public void OnDisconnet()
        {

        }

        

        public void OnReciveMsg()
        {

        }

        public void ReadMsg(byte[] data, int len)
        {

        }

        public void SendMsg()
        {

        }

        public void CloseConnect()
        {
            _client.Dispose();
            _client.BeginDisconnect(false, callBack => {
                _client.EndDisconnect(callBack);
            }, null);
        }
    }
}
