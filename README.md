### asp.net core template
## 参考资料
 - DemoDapper [深入理解dapper](https://www.cnblogs.com/ITWeiHan/p/11614704.html)
 - DemoMongoDB [使用 MongoDB 的 Web API](https://docs.microsoft.com/zh-cn/aspnet/core/tutorials/first-mongo-app?view=aspnetcore-3.1&tabs=visual-studio)
 - DemoSignalR [使用 JavaScript 的 SignalR](https://docs.microsoft.com/zh-cn/aspnet/core/tutorials/signalr?view=aspnetcore-3.1&tabs=visual-studio)
 - DemoGrpc [使用c#的grpc](https://docs.microsoft.com/zh-cn/aspnet/core/grpc/basics?view=aspnetcore-3.1)
- [Web API 约定](https://docs.microsoft.com/zh-cn/aspnet/core/web-api/advanced/conventions?view=aspnetcore-2.2#create-web-api-conventions)
- [session 实现原理](https://www.cnblogs.com/emrys5/p/aspnet-core-session.html)
 ## .NET Core 学习资料精选
.NET历史、开源之路、基础、路由、依赖注入DI、HttpContext、cookie|session、HttpClient、gRPC、单元测试、发布部署等等。
 ### [官方文档](https://docs.microsoft.com/zh-cn/aspnet/core/?view=aspnetcore-3.0)
- [VS2019自带 反编译 与 Reflector 反编译工具比较](https://www.cnblogs.com/cjm123/p/10908910.html)
- VS和.NET Core安装
  - [完整构建VSCode开发调试环境](https://www.cnblogs.com/tianqing/p/11874558.html)
- 基础
  - [后端开发术语大全](https://mp.weixin.qq.com/s/i4MAVUnDbP1tsdxaQpkjAQ)
  - [一文读懂QPS、TPS、PV、UV、GMV、IP、RPS](https://www.citrons.cn/jishu/226.html)
  - [.NET Core 命令行接口 (CLI) 工具](https://docs.microsoft.com/zh-cn/dotnet/core/tools/?tabs=netcore2x)
  - [内置中间件](https://docs.microsoft.com/zh-cn/aspnet/core/fundamentals/middleware/index?view=aspnetcore-2.2)
  - [.NET Core 3.0 新的 System.Text.Json API](https://www.cnblogs.com/waku/p/11026630.html)
  - [ASP.NET Core Razor 配置：预编译，动态编译，混合编译](http://www.zkea.net/codesnippet/detail/razor-compilation.html)
  - [静态文件](https://docs.microsoft.com/zh-cn/aspnet/core/fundamentals/static-files)
  - [HttpContext](https://docs.microsoft.com/zh-cn/aspnet/core/fundamentals/http-context)
  - [选项卡IOptions、IOptionsMonitor、IOptionsSnapshot的区别](https://github.com/jacklmjie/aspnetcoreboilerplate/blob/master/examples/ConfigrationDemo/TestConfigration/Controllers/HomeController.cs)
- ASP.NET Core WebAPI
  - [ASP.Net Core WebAPI 几种版本控制对比](https://www.cnblogs.com/runningsmallguo/p/7484954.html)
  - [Restful风格的接口](https://docs.microsoft.com/zh-cn/aspnet/core/web-api/advanced/conventions)
  - [使用 Web API 分析器告警缺失的约定](https://docs.microsoft.com/zh-cn/aspnet/core/web-api/advanced/analyzers)
- 方案
  - [高性能短链设计 nginx+openRestry](https://www.cnblogs.com/xiekun/p/12500822.html)
  - [开源netcore前后端分离,前端服务端渲染方案](https://mp.weixin.qq.com/s/ZthEnKru9FjGOcCWcqiEgA)
  - [推荐一个很棒的开源工作流elsa-core](https://mp.weixin.qq.com/s/FKsmTpFxODQBRbSoWa3IwQ)
- 2019年学习
  - [大话设计模式](https://github.com/jacklmjie/aspnetcoreboilerplate/tree/master/demo/DemoDesign)
  - [dapper深入学习](https://github.com/jacklmjie/aspnetcoreboilerplate/tree/master/demo/DemoDapper)
  - [JESSE老师的ASP.NET Core分布式微服务项目实战](https://github.com/jacklmjie/microservices)
- 2020年学习
  - [Puppeteer 图片生成解决方案](/docs/Puppeteer服务生成图片.md)
  - 虚拟机
    - [学习linux命令，看这篇2w多字的linux命令详解](https://www.cnblogs.com/zhonglongbo/p/12115548.html)
    - [Windows10下安装centos7.0虚拟机环境](https://www.cnblogs.com/shengChristine/p/9284969.html)
    - [hyper-v虚拟机centos7网络配置](https://jingyan.baidu.com/album/91f5db1b0279bd1c7e05e377.html?picindex=6)
      - ip a s 查看ip，并用putty登录,WinSCP传送文件
  - docker
    - [docker中文文档](https://yeasy.gitbooks.io/docker_practice/content/kubernetes/kubectl/)
    - [Docker基础](https://www.cnblogs.com/edisonchou/p/aspnet_core_k8s_artcles_index.html)
      - [Docker常用流行镜像仓库的搭建harbor](https://www.cnblogs.com/edisonchou/p/docker_registry_repository_setup_introduction.html)
        - [centos8.0安装docker](https://www.cnblogs.com/ding2016/p/11592999.html)
        - [postgres连接不上 1.更改主机名](https://ywnz.com/linux/6051.html)
        - [postgres连接不上 2.postgres配置](https://stackoverflow.com/questions/31611674/cant-connect-to-postgres-server)
     - [Harbor1.9+Nginx高可用集群仓库](https://juejin.im/post/5d973e246fb9a04dfa0963fb)
     - [Docker容器监控工具与方案Prometheus](https://www.cnblogs.com/edisonchou/p/docker_monitor_introduction_part3.html)
     - [Docker开源日志管理方案 ELK/EFK](https://www.cnblogs.com/edisonchou/p/docker_logs_study_summary_part2.html)
  - Kubernetes
    - [Windows docker k8s asp.net core](https://www.cnblogs.com/majiang/p/11328730.html)
    - [K8S基础知识与集群搭建](https://www.cnblogs.com/edisonchou/p/aspnet_core_on_k8s_deepstudy_part1.html)
      - [部署过程记录及问题解决](https://blog.csdn.net/weixin_44723434/article/details/94583457)
      - [节点无法加入问题汇总](https://www.cnblogs.com/liuyi778/p/12229416.html)
    - [部署过程解析与Dashboard](https://www.cnblogs.com/edisonchou/p/aspnet_core_on_k8s_deepstudy_part2.html)
      - [部署 dashboard 插件.yaml文件](https://github.com/opsnull/follow-me-install-kubernetes-cluster/blob/master/08-3.dashboard%E6%8F%92%E4%BB%B6.md)
      - [解决Google浏览器不能打开kubernetes dashboard方法](https://www.jianshu.com/p/8021285cc37d)
    - [Deployment和yaml语法](https://www.cnblogs.com/edisonchou/p/aspnet_core_on_k8s_deepstudy_part3_1.html)
    - [k8s系列总目录 接触运维的比较少等后续再学习](https://www.cnblogs.com/edisonchou/p/aspnet_core_k8s_artcles_index.html)
  - grpc
    - [ASP.NET Core gRPC 入门全家桶](https://www.cnblogs.com/stulzq/p/11897704.html)
    - [真实环境 内网一般都使用的是http](https://www.cnblogs.com/stulzq/p/11697269.html)
    - [demo 地址](/demo)
  - 移动端
    - [Xamarin 入门](https://docs.microsoft.com/zh-cn/xamarin/get-started/)
