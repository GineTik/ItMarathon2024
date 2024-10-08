#!/bin/bash
GRAFANA_URL=$1
GRAFANA_USER=$2
GRAFANA_PASSWORD=$3
API_KEY_NAME=$4
API_KEY_FILE=$5

# Generate API key
API_KEY=$(curl -s -X POST -H 'Content-Type: application/json' -d "{\"name\":\"$API_KEY_NAME\",\"role\":\"Admin\"}" -u "$GRAFANA_USER:$GRAFANA_PASSWORD" "$GRAFANA_URL/api/auth/keys" | jq -r .key)

# Check if API key was generated
if [ -z "$API_KEY" ]; then
    echo "Failed to generate API key."
    exit 1
fi

# Append API key to file with a timestamp
TIMESTAMP=$(date +"%Y%m%d%H%M%S")
echo "$TIMESTAMP: $API_KEY" >> "$API_KEY_FILE"
echo "API key saved to $API_KEY_FILE with timestamp $TIMESTAMP"
