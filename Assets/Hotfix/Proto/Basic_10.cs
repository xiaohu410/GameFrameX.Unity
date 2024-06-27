﻿using System;
using ProtoBuf;
using System.Collections.Generic;
using GameFrameX.Network.Runtime;

namespace Hotfix.Proto
{
	/// <summary>
	/// 请求心跳
	/// </summary>
	[ProtoContract]
	[MessageTypeHandler(655361)]
	public sealed class ReqHeartBeat : MessageObject, IRequestMessage
	{
		/// <summary>
		/// 时间戳
		/// </summary>
		[ProtoMember(1)]
		public long Timestamp { get; set; }

	}

	/// <summary>
	/// 返回心跳
	/// </summary>
	[ProtoContract]
	[MessageTypeHandler(655362)]
	public sealed class RespHeartBeat : MessageObject, IResponseMessage
	{
		/// <summary>
		/// 时间戳
		/// </summary>
		[ProtoMember(1)]
		public long Timestamp { get; set; }

		/// <summary>
		/// 返回的错误码
		/// </summary>
		[ProtoMember(888)]
		public int ErrorCode { get; set; }

	}

}