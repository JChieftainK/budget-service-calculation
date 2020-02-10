# Overview

![Master Build](https://github.com/JChieftainK/budget-service-calculation/workflows/Master%20Build/badge.svg)

**Description:** This web service calculates a simple budget given a set of information as input.

## Use Cases
**Description:** This section will explain the use cases for this web service.

### \***Not Implemented**\* Retrieve A Budget
- An endpoint that given an id will provide that monthly budget from storage

### \***Not Implemented**\* Create A Budget
- An endpoint will be provided that will take in details then respond with a proposed monthly budget

### \***Not Implemented**\* Update A Budget
- An endpoint that given an id and updated fields, will update the budget with the appropriate information

### \***Not Implemented**\* Delete A Budget
- An endpoint that given an id will expire a budget in storage
- Expired budgets will not return when requested by id through a retrieve call

# Prerequisities
- Dotnet core 3.1 installed
- The repository cloned to your local
    - `git clone https://github.com/JChieftainK/budget-service-calculation.git`

# Command Line Instructions
**Description:** This section will describe how to setup your local environment and run the web service using the command line.

## Setup
- Set your **command line interface** to the folder location of the project

## Run
- Run the command `dotnet run` (NEED TO TEST)

# Visual Studio Code Instructions
**Description:** This section will describe how to setup your VSCode for running and debgging the web service.

## Prerequisites
- Have **Visual Studio Code** installed locally
    - Version `1.42.0` was used when writing this document
- Have the **C# Plugin** installed and enabled
    - [C# Plugin Link](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp)

## Setup
1. Open the folder location using **VSCode**
1. A dialog may pop up to restore the project, select **Yes** 
1. **VSCodes** `launch.json` will contain configuration needed for running in debug

> Note: Envrionment properties are set under `../Properties/launchsettings.json`

## Debug
1. Make sure the correct configuration is selected
1. Click **Run**

## Testing

### Unit Testing

### Integration Testing

# Frequently Asked Questions
