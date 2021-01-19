   FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
COPY . /publish
WORKDIR /publish

 #暴露80端口
# ENV ASPNETCORE_URLS=http://*:80
# EXPOSE 80
ENV ASPNETCORE_URLS=http://*:80
EXPOSE 80
#设置ASPNETCORE_ENVIRONMENT
ENV ASPNETCORE_ENVIRONMENT production
#配置本服务在skywalking名称
ENV SKYWALKING__SERVICENAME=adnc-usr-webapi
#skywalking接管的意思，除了adnc_health不需要配置，其他4个必须配置
ENV ASPNETCORE_HOSTINGSTARTUPASSEMBLIES=SkyAPM.Agent.AspNetCore
#设置时区为东八区
ENV TZ Asia/Shanghai
ENTRYPOINT ["dotnet", "Adnc.Usr.WebApi.dll"]
 
 
 
# server_port@7010@
 