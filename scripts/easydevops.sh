#!/bin/bash
# 1. Update het systeem
echo "Systeem updaten..."
sudo apt-get update && sudo apt-get upgrade -y

# 2. Installeer .NET 8 SDK
echo ".NET 8 SDK installeren..."
sudo apt-get install -y dotnet-sdk-8.0

# 3. Installeer Git
echo "Git installeren..."
sudo apt-get install -y git

# 4. Clone de repository
# Vervang de URL door jouw eigen GitHub repo URL
echo "EasyDevOps repository clonen..."
git clone https://github.com/DavidSmit-git/EasyDevOps-ITM.git
cd EasyDevOps-ITM/frontend

# 5. Build en Run de applicatie
echo "EasyDevOps app starten..."
dotnet run --urls "http://0.0.0.0:5000"