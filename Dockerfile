FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

COPY . .
ENV NODE_VERSION=18
ENV NVM_DIR="/app/.nvm"
RUN mkdir .nvm
RUN curl -o- https://raw.githubusercontent.com/nvm-sh/nvm/v0.39.0/install.sh | bash
RUN [ -s "$NVM_DIR/nvm.sh" ] && \. "$NVM_DIR/nvm.sh" && \
npm install &&\
npm run build

# Build runtime image
FROM node:18
WORKDIR /app
COPY --from=build-env /app/public ./public
RUN npm i -g serve@14
CMD ["npx", "serve", "public"]