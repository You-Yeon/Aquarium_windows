﻿ 





// Generated by PIDL compiler.
// Do not modify this file, but modify the source .pidl file.

using System;
namespace S2C2S
{
	internal class Common
	{
		// Message ID that replies to each RMI method. 
			public const Nettention.Proud.RmiID RequestLogin = (Nettention.Proud.RmiID)1000+1;
			public const Nettention.Proud.RmiID NotifyLoginSuccess = (Nettention.Proud.RmiID)1000+2;
			public const Nettention.Proud.RmiID NotifyLoginFailed = (Nettention.Proud.RmiID)1000+3;
			public const Nettention.Proud.RmiID JoinGameRoom = (Nettention.Proud.RmiID)1000+4;
			public const Nettention.Proud.RmiID Room_Appear = (Nettention.Proud.RmiID)1000+5;
			public const Nettention.Proud.RmiID Room_Disappear = (Nettention.Proud.RmiID)1000+6;
		// List that has RMI ID.
		public static Nettention.Proud.RmiID[] RmiIDList = new Nettention.Proud.RmiID[] {
			RequestLogin,
			NotifyLoginSuccess,
			NotifyLoginFailed,
			JoinGameRoom,
			Room_Appear,
			Room_Disappear,
		};
	}
}

				 
