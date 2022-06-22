FROM mcr.microsoft.com/dotnet/sdk:6.0

WORKDIR /app

ENV DOTNET_CLI_TELEMETRY_OPTOUT=1
ENV PATH="$PATH:/root/.dotnet/tools"

COPY . .

ENTRYPOINT ["/bin/bash", "./linter/entrypoint.sh" ]