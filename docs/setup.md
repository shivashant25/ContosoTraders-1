# Instructions

## Setting up TailwindTraders

1. Git clone this repository to your machine.
2. Run the bicep scripts to provision the resources on Azure ([instructions here](../iac/readme.md)).
3. On the github repository, go to the `Settings` tab > `Secrets` > `Actions` and create the secrets as mentioned in [the Github Secrets section below](#github-secrets).
4. To deploy the apps, run all the github workflows. You can do this by going to the github repo's `Actions` tab, selecting a workflow, and clicking on the `Run workflow` button.

## Setting up TailwindTraders in a lab

1. Create a fork of this [TailwindTraders github repository](https://github.com/CloudLabs-AI/TailwindTraders); one fork per lab.
2. Git clone the forked repository to your lab VM.
3. Run the bicep scripts to provision the resources on Azure ([instructions here](../iac/readme.md)).
4. On your github repository fork, go to the `Settings` tab > `Secrets` > `Actions` and create the secrets as mentioned in [the Github Secrets section below](#github-secrets).
5. To deploy the apps, run all the github workflows. You can do this by going to the github repo's `Actions` tab, selecting a workflow, and clicking on the `Run workflow` button.

## Github Secrets

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
