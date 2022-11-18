# Instructions

## Setting up ContosoTraders

1. Git clone this repository to your machine.
2. Create the `CONTOSOTRADERS_TESTING_SERVICEPRINCIPAL` github secret ([instructions here](./github-secrets.md)).
3. Next, provision the infrastructure on Azure by running the `contoso-traders-infra-provisioning` github workflow. You can do this by going to the github repo's `Actions` tab, selecting the workflow, and clicking on the `Run workflow` button.
4. Next, create the rest of the github secrets ([instructions here](./github-secrets.md)).
5. Next, deploy the apps, by running the `contoso-traders-app-deployment` workflow.

## Setting up ContosoTraders in a lab

Same steps as above. But you have to create and use a fork of this github repository (instead of using this original repository); one fork per lab.
