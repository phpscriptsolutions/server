﻿using Common.Model.Server;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginServer.Network.GameServer.Recv
{
    public class GSResUserOnlineCount : GSARecvPacket
    {
        protected internal override void Read()
        {
            int len = ReadH();
            using (var ms = new MemoryStream(ReadB(len)))
            {
                LoginServer.ServerList = Serializer.Deserialize<List<ServerStruct>>(ms);
            }
        }

        protected internal override void Run()
        {
            
        }
    }
}