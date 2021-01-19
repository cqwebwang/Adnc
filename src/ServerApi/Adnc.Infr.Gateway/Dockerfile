  FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
COPY . /publish
WORKDIR /publish

 #±©Â¶80¶Ë¿Ú
ENV ASPNETCORE_URLS=http://*:80
EXPOSE 80

ENV ASPNETCORE_ENVIRONMENT production
# ENV SKYWALKING__SERVICENAME=adnc-gateway
ENV ASPNETCORE_HOSTINGSTARTUPASSEMBLIES=SkyAPM.Agent.AspNetCore
ENV TZ Asia/Shanghai
ENTRYPOINT ["dotnet", "Adnc.Infr.Gateway.dll"]
 
 
# server_port@8888@
VOLUME ["/wydata/gateway/Config","/publish/Config"]
