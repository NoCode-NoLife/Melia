FROM ubuntu:22.04
ARG DEBIAN_FRONTEND=noninteractive

WORKDIR /

RUN apt update -y && apt upgrade -y && apt install -y dotnet-sdk-8.0 aspnetcore-runtime-8.0 git php libapache2-mod-php php-cgi php-mysql vim

WORKDIR /melia

CMD ["./start", "Debug", "BarracksServer"]
