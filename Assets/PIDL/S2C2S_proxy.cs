﻿




// Generated by PIDL compiler.
// Do not modify this file, but modify the source .pidl file.

using System;
using System.Net;

namespace S2C2S
{
	internal class Proxy:Nettention.Proud.RmiProxy
	{
public bool RequestLogin(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, System.String id, System.String password)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.RequestLogin;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, id);
		Nettention.Proud.Marshaler.Write(__msg, password);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_RequestLogin, Common.RequestLogin);
}

public bool RequestLogin(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, System.String id, System.String password)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.RequestLogin;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, id);
Nettention.Proud.Marshaler.Write(__msg, password);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_RequestLogin, Common.RequestLogin);
}
public bool NotifyLoginSuccess(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.NotifyLoginSuccess;
		__msg.Write(__msgid);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_NotifyLoginSuccess, Common.NotifyLoginSuccess);
}

public bool NotifyLoginSuccess(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.NotifyLoginSuccess;
__msg.Write(__msgid);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_NotifyLoginSuccess, Common.NotifyLoginSuccess);
}
public bool NotifyLoginFailed(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, System.String reason)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.NotifyLoginFailed;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, reason);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_NotifyLoginFailed, Common.NotifyLoginFailed);
}

public bool NotifyLoginFailed(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, System.String reason)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.NotifyLoginFailed;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, reason);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_NotifyLoginFailed, Common.NotifyLoginFailed);
}
public bool JoinGameRoom(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int character_num)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.JoinGameRoom;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, character_num);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_JoinGameRoom, Common.JoinGameRoom);
}

public bool JoinGameRoom(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, int character_num)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.JoinGameRoom;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, character_num);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_JoinGameRoom, Common.JoinGameRoom);
}
public bool Room_Appear(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int hostID, System.String id, int character_num, System.String team_color, int team_num)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.Room_Appear;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, hostID);
		Nettention.Proud.Marshaler.Write(__msg, id);
		Nettention.Proud.Marshaler.Write(__msg, character_num);
		Nettention.Proud.Marshaler.Write(__msg, team_color);
		Nettention.Proud.Marshaler.Write(__msg, team_num);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_Room_Appear, Common.Room_Appear);
}

public bool Room_Appear(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, int hostID, System.String id, int character_num, System.String team_color, int team_num)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.Room_Appear;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, hostID);
Nettention.Proud.Marshaler.Write(__msg, id);
Nettention.Proud.Marshaler.Write(__msg, character_num);
Nettention.Proud.Marshaler.Write(__msg, team_color);
Nettention.Proud.Marshaler.Write(__msg, team_num);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_Room_Appear, Common.Room_Appear);
}
public bool Room_Disappear(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int hostID)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.Room_Disappear;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, hostID);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_Room_Disappear, Common.Room_Disappear);
}

public bool Room_Disappear(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, int hostID)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.Room_Disappear;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, hostID);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_Room_Disappear, Common.Room_Disappear);
}
#if USE_RMI_NAME_STRING
// RMI name declaration.
// It is the unique pointer that indicates RMI name such as RMI profiler.
public const string RmiName_RequestLogin="RequestLogin";
public const string RmiName_NotifyLoginSuccess="NotifyLoginSuccess";
public const string RmiName_NotifyLoginFailed="NotifyLoginFailed";
public const string RmiName_JoinGameRoom="JoinGameRoom";
public const string RmiName_Room_Appear="Room_Appear";
public const string RmiName_Room_Disappear="Room_Disappear";
       
public const string RmiName_First = RmiName_RequestLogin;
#else
// RMI name declaration.
// It is the unique pointer that indicates RMI name such as RMI profiler.
public const string RmiName_RequestLogin="";
public const string RmiName_NotifyLoginSuccess="";
public const string RmiName_NotifyLoginFailed="";
public const string RmiName_JoinGameRoom="";
public const string RmiName_Room_Appear="";
public const string RmiName_Room_Disappear="";
       
public const string RmiName_First = "";
#endif
		public override Nettention.Proud.RmiID[] GetRmiIDList() { return Common.RmiIDList; } 
	}
}

