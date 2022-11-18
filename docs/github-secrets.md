# Github secrets required

On the github repository, go to the `Settings` tab > `Secrets` > `Actions` and create these necessary secrets:

| Secret Name                                    | Secret Value                                             |
| ---------------------------------------------- | -------------------------------------------------------- |
| `CONTOSOTRADERS_SUFFIX`                       | Six-digit lab suffix specified during bicep provisioning |
| `CONTOSOTRADERS_ACR_PASSWORD`                 | Admin password for your Azure Container Registry         |
| `CONTOSOTRADERS_PRODUCTSDB_CONNECTION_STRING` | Connection string for ProductsDB (SQL Azure)             |
| `CONTOSOTRADERS_TESTING_SERVICEPRINCIPAL`     | See details below                                        |

The value of the `CONTOSOTRADERS_TESTING_SERVICEPRINCIPAL` secret above needs to have the following format:

```json
{
  "clientId": "zzzzzzzz-zzzz-zzzz-zzzz-zzzzzzzzzzzz",
  "clientSecret": "your-client-secret",
  "tenantId": "zzzzzzzz-zzzz-zzzz-zzzz-zzzzzzzzzzzz",
  "subscriptionId": "zzzzzzzz-zzzz-zzzz-zzzz-zzzzzzzzzzzz"
}
```
