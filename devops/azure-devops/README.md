# Azure DevOps Setup Guide

This comprehensive guide will walk you through setting up Azure DevOps for your project, including creating an organization, configuring pipelines, and deploying your applications.

## Table of Contents

1. [Create an Azure DevOps Organization](#create-an-azure-devops-organization)
2. [Create a Project](#create-a-project)
3. [Configure Organization Settings](#configure-organization-settings)
4. [Build Pipelines](#build-pipelines)
   - [Prerequisites: Request Increased Parallelism](#prerequisites-request-increased-parallelism)
   - [Create a Build Pipeline](#create-a-build-pipeline)
   - [Python Application](#build-pipeline-for-python-application)
   - [.NET Application](#build-pipeline-for-net-application)
   - [Frontend Application](#build-pipeline-for-frontend-application)
5. [Run Build Pipelines](#run-build-pipelines)
6. [Release Pipelines](#release-pipelines)
   - [.NET Release Pipeline](#net-release-pipeline)
   - [Frontend Release Pipeline](#frontend-release-pipeline)
   - [Python Release Pipeline](#python-release-pipeline)
7. [Find Deployed Applications URL](#find-deployed-applications-url)
8. [Bonus: SpecFlow Testing Framework Build Pipeline](#bonus-specflow-testing-framework-build-pipeline)

## Create an Azure DevOps Organization

Follow the [official Microsoft documentation](https://learn.microsoft.com/en-us/azure/devops/organizations/accounts/create-organization?view=azure-devops) to create your Azure DevOps organization.

![Creating an Azure DevOps organization](images/image-1.png)

## Create a Project

Create a new project following the [Microsoft guidelines](https://learn.microsoft.com/en-us/azure/devops/organizations/projects/create-project?view=azure-devops&tabs=browser).

> ❗ **Important:**
> Ensure that the project is set to private for security reasons.

![Creating a new project](images/image-2.png)

<details>
  <summary>Optional: Switch to Dark Theme</summary>

![Switching to dark theme](images/image-3.png)

</details>

## Configure Organization Settings

1. Navigate back to your organization's main page.

   ![Returning to organization page](images/image-6.png)

2. Access the organization settings.

   ![Accessing organization settings](images/image-7.png)

3. Locate and disable the following two settings to be able to create Classic Build and Release Pipelines:

   ![Disabling specific settings](images/image-8.png)

## Build Pipelines

### Prerequisites: Request Increased Parallelism

Before creating pipelines, you need to request a free agent from Microsoft to run your pipelines.

1. Fill out the [request form](https://forms.office.com/pages/responsepage.aspx?id=v4j5cvGGr0GRqy180BHbR5zsR558741CrNi6q8iTpANURUhKMVA3WE4wMFhHRExTVlpET1BEMlZSTCQlQCN0PWcu&route=shorturl).
2. Provide the following information:
   - The name associated with your Azure account
   - The names of your newly created organization and project

![Request form example](images/image-5.png)

### Create a Build Pipeline

While waiting for free agents, you can set up your build pipelines:

1. Navigate to `Pipelines`.

   ![Accessing Pipelines](images/image-4.png)

2. Choose `Other Git`.

   ![Selecting Git source](images/image-9.png)

3. Add a service connection.

   ![Adding service connection](images/image-10.png)

4. Configure the connection:

   - Enter your GitLab project URL
   - Provide your Personal Access Token for private projects

   ![Configuring service connection](images/image-11.png)

   > ❗ **Important:**
   > Use the URL from the address bar, not from the `Clone` menu.
   > ![Correct URL location](images/image-12.png)

   For more information on GitLab projects and Personal Access Tokens, refer to:

   - [GitLab Projects Documentation](https://docs.gitlab.com/ee/user/project/index.html)
   - [Personal Access Tokens Guide](https://docs.gitlab.com/ee/user/profile/personal_access_tokens.html)

5. Specify the default branch name (you can modify this later) and proceed.

   ![Specifying branch](images/image-13.png)

6. Start with an empty job.

   ![Selecting empty job](images/image-14.png)

### Build Pipeline for Python Application

1. Name your pipeline and select `ubuntu-latest` as the Agent Specification.

   ![Naming pipeline and selecting agent](images/image-15.png)

2. Name the job, ensure `Agent pool` is set to `<Inherit from pipeline>`, and add a new task.

   ![Configuring job](images/image-16.png)

3. Add an Archive task:

   - Search for "archive" and add the task.

   ![Adding Archive task](images/image-17.png)

4. Add a Publish task:

   - Search for "publish" and add the task.

   ![Adding Publish task](images/image-18.png)

5. Link the archive path variable in the Archive task.

   ![Linking archive path](images/image-19.png)

6. Copy the variable name.

   ![Copying variable name](images/image-20.png)

7. Link the path of the artifact to publish in the Publish task.

   ![Linking publish path](images/image-21.png)

8. Enter previously copied variable name.

   ![Using the same variable](images/image-22.png)

9. Save the pipeline.

   ![Saving pipeline](images/image-23.png)

### Build Pipeline for .NET Application

1. Return to pipelines and initiate a new pipeline.

   ![Creating new pipeline](images/image-24.png)

2. Create a new Git service connection (for security reasons, by default service connection is available for single pipeline).

3. Create an empty job.

4. Name the pipeline, select `ubuntu-latest` as the agent OS.

5. Add a .NET Core task:

   ![Adding .NET Core task](images/image-25.png)

6. Configure the restore command:

   Select `restore` command

   ![Configuring restore command](images/image-33.png)

   Set the path to your .NET solution and link the variable:

   ![Setting solution path](images/image-30.png)

   Select the default Azure Artifact Feed of the project:

   ![Selecting Azure Artifact Feed](images/image-31.png)

7. Clone the task for build, test, and publish steps:

   ![Cloning task](images/image-32.png)

8. Configure each cloned task:

   Build:

   ![Configuring build task](images/image-64.png)

   Test:

   ![Configuring test task](images/image-65.png)

   ![Configuring test task](images/image-35.png)

   Publish:

   ![Configuring publish task](images/image-36.png)

9. Add a Publish Pipeline Artifacts task:

   ![Adding Publish Pipeline Artifacts task](images/image-37.png)

   ![Configuring Publish Pipeline Artifacts task](images/image-38.png)

### Build Pipeline for Frontend Application

1. Create a new pipeline, name it, select Ubuntu as the OS, and name the job.

2. Add a Node.js tool installer task:

   ![Adding Node.js tool installer](images/image-39.png)

   ![Configuring Node.js version](images/image-40.png)

3. Add an npm task:

   ![Adding npm task](images/image-41.png)

   ![Npm install](images/image-68.png)

   Set the `working folder` and link the variable:

   ![Configuring npm working folder](images/image-42.png)

4. Clone the npm task and configure it for build:

   ![Configuring npm build task](images/image-43.png)

5. Get the project name from `package.json` and set the `project.name` variable:

   ![Setting project name variable](images/image-69.png)

6. Add a Publish Pipeline Artifacts task:

   ![Configuring Publish Pipeline Artifacts for frontend](images/image-44.png)

## Run Build Pipelines

> 💡**NOTE:**
> Before running build pipelines or proceeding to release pipelines, ensure Microsoft has provided you with a free agent.
> Check the `Agent pool` setting in `Project settings` -> `Pipelines` -> `Agent pools` or your email.

Choose a pipeline and click on it.

![Selecting a pipeline](images/image-74.png)

Locate the `Run pipeline` button and click on it.

![Running a pipeline](images/image-75.png)

Before running, you can change some parameters of the pipeline. Then click on `Run`:

![Configuring pipeline run](images/image-77.png)

You will see the pipeline running. Click on the job to see more details.

![Viewing pipeline run details](images/image-78.png)

If you get an error, click on the task to see the logs:

![Viewing task logs](images/image-80.png)

If the pipeline runs successfully, an artifact will be created and you will be able to use it in _Release Pipelines_.

Run the other Build Pipelines and proceed to the next step.

## Release Pipelines

To create your first release pipeline:

![Checking agent availability](images/image-47.png)

### .NET Release Pipeline

1. Start with an empty job.

   ![Starting .NET release pipeline](images/image-48.png)

2. Name the stage.

   ![Naming .NET release stage](images/image-49.png)

3. Add an artifact from the build pipeline run.

   ![Adding artifact](images/image-70.png)
   ![Selecting build pipeline](images/image-71.png)

4. Enable Continuous Deployment trigger:

   ![Enabling CD trigger](images/image-72.png)
   ![Configuring CD trigger](images/image-73.png)

5. Navigate to the `Tasks` tab and configure the job.

   ![Configuring .NET release job](images/image-51.png)

6. Add an Azure App Service Deploy task.

   ![Adding Azure App Service Deploy task](images/image-52.png)

   - Select your Azure subscription
   - Choose the previously created App Service for .NET
   - Make sure everything else is the same as in the screenshot

7. Save the pipeline and press `Create release`.

You can see the status and logs here:

![Viewing release status and logs](images/image-81.png)

### Frontend Release Pipeline

1. Create an empty job, name the stage, select the artifact.

2. Add an **Azure File Copy task**.

   ![Adding Azure File Copy task](images/image-57.png)

3. Configure the source:

   Find the `browser` folder in the artifact and add an `*` wildcard:

   ![Configuring source for Azure File Copy](images/image-55.png)

   ![Adding wildcard for source](images/image-56.png)

4. Select your **Azure subscription**

5. Set Destination Type to **Azure Blob**

   ![Setting destination type](images/image-58.png)

6. Choose the **Storage account** created earlier.

   ![Selecting storage account](images/image-60.png)

7. Set **Container name** to `$web`

   ![Setting container name](images/image-53.png)

8. Enable the **Clean target** option.

   ![Enabling clean target option](images/image-61.png)

9. Save the pipeline and create a **release**.

### Python Release Pipeline

1. Create an empty job, name the stage, select the artifact.

2. Add an **Azure App Service Deploy** task and configure it:

   ![Configuring Python release pipeline](images/image-62.png)

   - Package or folder: Select the Python Application archive, replace its name with `*` wildcard
   - Startup command:
     ```bash
     pip install --no-cache-dir --upgrade -r requirements.txt && cd pet-project || exit && gunicorn main:main_app
     ```

3. Save the pipeline and create a **release**.

## Find Deployed Applications URL

After successful release pipeline runs, you can find URLs of deployed applications in the release logs:

![Finding deployed application URLs](images/image-82.png)

For the frontend application, you can find out the URL by running the following command:

```bash
az storage account show -n <storage-account-name> --query "primaryEndpoints.web" --output tsv
```

## Bonus: SpecFlow Testing Framework Build Pipeline

> 💡 **NOTE:**
> This is an optional step, but it is crucial to test the application.

For implementing SpecFlow tests, refer to these resources:

- [SpecFlow LivingDoc Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/)
- [Azure DevOps Pipelines Documentation](https://learn.microsoft.com/en-us/azure/devops/pipelines/?view=azure-devops)
- Utilize a Large Language Model (LLM) of your choice for additional assistance

Pipeline configuration:

![SpecFlow pipeline settings](images/image-63.png)

Tasks overview:

![SpecFlow tasks preview 1](images/image-66.png)

![SpecFlow tasks preview 2](images/image-67.png)

Variables configuration:

![SpecFlow variables preview](images/image-59.png)

The YAML pipeline that needs to be converted to a classic pipeline can be found [here](specflow-ci/specflow-CI.yml).

Good luck! 😊
