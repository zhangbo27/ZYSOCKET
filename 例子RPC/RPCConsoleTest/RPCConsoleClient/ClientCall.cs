﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZYSocket.RPC.Client;

namespace RPCConsoleClient
{
    public class ClientCall:RPCClientObj
    {
        public DateTime GetClientDateTime()
        {
            return DateTime.Now;
        }

        public long Add(long a, long b)
        {
            Console.WriteLine("服务器请求计算" + a + "+" + b + "=?");
           
            return a + b;
        }

        public int RecComputer(int i)
        {
            if (i < 2)
                return i;

            i--;

            var rpc = GetCurrentRPObj();
            i= rpc.GetRPC<ServerClass>().RecComputer(i);
           

            return i;

        }

        public float RecComputer2(float i)
        {
            if (i < 2)
                return i;

            i--;

            var rpc = GetCurrentRPObj();
            i = rpc.RPC_Call.GetRPC<ServerClass>().RecComputer2(i);

            return i;

        }
       

        public void ShowMsg(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
