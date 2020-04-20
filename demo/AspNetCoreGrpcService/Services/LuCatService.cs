﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;

namespace AspNetCoreGrpcService.Services
{
    public class LuCatService : LuCat.LuCatBase
    {
        private readonly ILogger<LuCatService> _logger;
        private static readonly Random Rand = new Random(DateTime.Now.Millisecond);
        private static readonly List<string> Cats = new List<string>() { "英短银渐层", "英短金渐层", "美短", "蓝猫", "狸花猫", "橘猫" };
        public LuCatService(ILogger<LuCatService> logger)
        {
            _logger = logger;
        }

        //需要授权
        //[Authorize] 
        public override Task<SuckingCatResult> SuckingCat(Empty request, ServerCallContext context)
        {
            return Task.FromResult(new SuckingCatResult()
            {
                Message = $"您吸了一只{Cats[Rand.Next(0, Cats.Count)]}"
            });
        }

        public override async Task BathTheCat(IAsyncStreamReader<BathTheCatReq> requestStream, IServerStreamWriter<BathTheCatResp> responseStream, ServerCallContext context)
        {
            var bathQueue = new Queue<int>();
            while (await requestStream.MoveNext())
            {
                //将要洗澡的猫加入队列
                bathQueue.Enqueue(requestStream.Current.Id);

                _logger.LogInformation($"Cat {requestStream.Current.Id} Enqueue.");
            }

            //遍历队列开始洗澡
            //判断是否取消了
            while (!context.CancellationToken.IsCancellationRequested && bathQueue.TryDequeue(out var catId))
            {
                await responseStream.WriteAsync(new BathTheCatResp() { Message = $"铲屎的成功给一只{Cats[catId]}洗了澡！" });

                await Task.Delay(500);//此处主要是为了方便客户端能看出流调用的效果
            }
        }

        public override Task<CountCatResult> Count(Empty request, ServerCallContext context)
        {
            return Task.FromResult(new CountCatResult()
            {
                Count = Cats.Count
            });
        }
    }
}
