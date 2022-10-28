# IaC Scripts

This document contains provisioning details for the infra around the Tailwind Traders app.

## Provisioning the resource group

The first step is to create the resource group: `tailwind-traders-rg`.

```bash
az deployment sub create --location {LOCATION} --template-file .\createResourceGroup.bicep
```

> You can specify any location for `{LOCATION}`. It's the region where the deployment metadata will be stored, and not where the resource groups will be deployed.

## Provisioning the Azure resources

Then, we'll deploy the Azure resources to the resource group `tailwind-traders-rg` created above. The deployed resources include storage accounts, function apps, app services cosmos db, and service bus etc.

```bash
 az deployment group create -g tailwind-traders-rg --template-file .\createResources.bicep
```
