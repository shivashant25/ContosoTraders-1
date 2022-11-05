# Github secrets required

On the github repository, go to the `Settings` tab > `Secrets` > `Actions` and create these necessary secrets:

| Secret Name                                    | Secret Value                                             |
| ---------------------------------------------- | -------------------------------------------------------- |
| `TAILWINDTRADERS_SUFFIX`                       | Six-digit lab suffix specified during bicep provisioning |
| `TAILWINDTRADERS_ACR_PASSWORD`                 | Admin password for your Azure Container Registry         |
| `TAILWINDTRADERS_PRODUCTSDB_CONNECTION_STRING` | Connection string for ProductsDB (SQL Azure)             |
| `TAILWINDTRADERS_TESTING_SERVICEPRINCIPAL`     | See details below                                        |

The value of the `TAILWINDTRADERS_TESTING_SERVICEPRINCIPAL` secret above needs to have the following format:

```json
{
  "clientId": "zzzzzzzz-zzzz-zzzz-zzzz-zzzzzzzzzzzz",
  "clientSecret": "your-client-secret",
  "tenantId": "zzzzzzzz-zzzz-zzzz-zzzz-zzzzzzzzzzzz",
  "subscriptionId": "zzzzzzzz-zzzz-zzzz-zzzz-zzzzzzzzzzzz",
}
```
