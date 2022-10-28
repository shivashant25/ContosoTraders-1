# Manual steps

While our infra provisioning will be fully-automated to the greatest extent possible, there are some manual steps that will be needed. These steps are not part of the provisioning process, but are required to complete the deployment:

## SQL Server

1. Add user's IP address to the firewall rules for the SQL Server instance. This is required to allow the user to connect to the database via SMSS etc (for local development).
2. @TODO
