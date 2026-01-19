#!/bin/bash
# 1. Installeer .NET 8 SDK
echo ".NET 8 SDK installeren..."
sudo apt-get install -y dotnet-sdk-8.0

# 2. Installeer Git
echo "Git installeren..."
sudo apt-get install -y git

# 3. Clone de repository

echo "EasyDevOps repository clonen..."
git clone https://github.com/DavidSmit-git/EasyDevOps-ITM.git
cd EasyDevOps-ITM/frontend

# 4. Build en Run de applicatie
echo "EasyDevOps app starten..."
dotnet run --urls "http://0.0.0.0:5000"