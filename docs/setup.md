# Instructions

## Setting up TailwindTraders

1. Git clone this repository to your machine.
2. Create the necessary github secrets ([instructions here](../.github/workflows/secrets.md)).
3. First, provision the infrastructure on Azure by running the `tailwind-traders-infra-provisioning` github workflow. You can do this by going to the github repo's `Actions` tab, selecting the workflow, and clicking on the `Run workflow` button.
4. Next, deploy the apps, by running the rest of the github workflows.

## Setting up TailwindTraders in a lab

Same steps as above. But you have to create and use a fork of this github repository (instead of using this original repository); one fork per lab.
