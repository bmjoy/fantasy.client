﻿using System;
using Pb;
using Google.Protobuf;

public class Parser
{

    public static byte[] EncodeMassage(int id, byte[] data)
    {

        byte[] newBuffer = null; //id + data

        using (AppMemoryStream ms = new AppMemoryStream())
        {
            ms.WriteUShort((ushort)id);

            ms.Write(data, 0, data.Length);

            newBuffer = ms.ToArray();
        }

        byte[] newData = null; //newBuffer.length + id + data

        using (AppMemoryStream ms = new AppMemoryStream())
        {
            ms.WriteUShort((ushort)(newBuffer.Length));

            ms.Write(newBuffer, 0, newBuffer.Length);

            newData = ms.ToArray();
        }

        return newData;
    }

    public static void DecodeMessage(byte[] data)
    {
        //解析收到的数据messge
        byte[] body = new byte[data.Length - 2];

        ushort protoCode = 0;

        using (AppMemoryStream ms = new AppMemoryStream(data))
        {
            protoCode = ms.ReadUShort();

            ms.Read(body, 0, body.Length);
        }

        Type protoType = MessageDefine.GetProtoTypeByProtoId(protoCode);

        MessageParser messageParser = MessageDefine.GetMessageParser(protoType.TypeHandle);

        object toc = messageParser.ParseFrom(body);

        Message msg = toc as Message;

        byte[] msgBody = msg.Body.ToByteArray();

        //解析messgeBody
        ushort msgId = 0;

        byte[] msgData = new byte[msgBody.Length - 2];

        using (AppMemoryStream ms1 = new AppMemoryStream(msgBody))
        {
            msgId = ms1.ReadUShort();

            ms1.Read(msgData, 0, msgData.Length);
        }

        {
            Type msgType = MessageDefine.GetProtoTypeByProtoId(msgId);

            MessageParser messageParser1 = MessageDefine.GetMessageParser(msgType.TypeHandle);

            object toc1 = messageParser1.ParseFrom(msgData);

            //派发事件
            SocketEvent.Instance.Dispatch(msgId, toc1);
        }
    }
}
