#!/bin/bash
set -e

curl -sSL https://dot.net/v1/dotnet-install.sh | bash /dev/stdin --channel 10.0
export DOTNET_ROOT="$HOME/.dotnet"
export PATH="$DOTNET_ROOT:$PATH"

npm --prefix LanguageProjector ci
npm --prefix LanguageProjector run css
dotnet publish LanguageProjector/LanguageProjector.csproj -c Release -o publish