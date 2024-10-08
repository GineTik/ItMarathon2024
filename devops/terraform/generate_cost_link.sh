az rest --method post --uri "https://management.azure.com/subscriptions/${subscription_id}/providers/Microsoft.CostManagement/query?api-version=2023-11-01" --body '{
  "type": "Usage",
  "timeframe": "Custom",
  "timePeriod": {
    "from": "2024-08-01",
    "to": "2024-08-31"
  },
  "dataset": {
    "granularity": "None",
    "aggregation": {
      "totalCost": {
        "name": "Cost",
        "function": "Sum"
      }
    },
    "grouping": [
      {
        "type": "Dimension",
        "name": "ServiceName"
      }
    ]
  }
}'
