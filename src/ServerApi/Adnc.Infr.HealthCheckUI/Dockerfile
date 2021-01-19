   FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
COPY . /publish
WORKDIR /publish

 #暴露80端口
ENV ASPNETCORE_URLS=http://*:80
EXPOSE 80
#设置ASPNETCORE_ENVIRONMENT
ENV ASPNETCORE_ENVIRONMENT production
#设置时区为东八区
ENV TZ Asia/Shanghai
ENTRYPOINT ["dotnet", "Adnc.Infr.HealthCheckUI.dll"]
 
# server_port@8666@
 

  
  