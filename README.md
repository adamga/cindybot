# CindyBot: A Chatbot with Azure Integration

CindyBot is a sophisticated chatbot application that leverages the power of Azure services to provide an interactive chat experience. It utilizes a Node.js-based front end with React for the chat interface, a .NET Core and C# server-side API for chat response functionality, and integrates with CosmosDB for chat history storage. Additionally, it employs the Azure OpenAI service for generating chat responses, ensuring a dynamic and engaging user experience.

## Features

- **Front End Web Application**: Built with React, providing a seamless chat interface.
- **Server Side API**: Developed using .NET Core and C#, responsible for chat response functionality.
- **CosmosDB Integration**: For storing chat history, ensuring data persistence.
- **Azure OpenAI Service**: Utilized for generating intelligent chat responses.
- **Azure Resources**: Defined and managed using Terraform, for easy deployment and scalability.
- **Security**: Deployment in secure VNets with appropriate connections and security measures.
- **Telemetry**: Integration with Application Insights and Azure Monitor for comprehensive monitoring.

## Getting Started

### Prerequisites

- Node.js
- .NET Core SDK
- Azure CLI
- Terraform

### Setup

1. Clone the repository to your local machine.
2. Navigate to the `frontend` directory and run `npm install` to install dependencies.
3. In the `api` directory, restore .NET Core packages.
4. Set up Azure resources using the Terraform scripts located in the `terraform` directory.

### Running the Application

1. Start the front end application by running `npm start` in the `frontend` directory.
2. Launch the server side API by executing `dotnet run` in the `api` directory.
3. Access the chatbot interface through the web browser at the specified localhost port.

## Azure Resources Setup with Terraform

The Terraform scripts in the `terraform` directory allow for the easy setup of necessary Azure resources, including CosmosDB, Azure OpenAI service, and networking components. Follow the instructions within the directory to initialize and apply the Terraform configuration.

## Documentation

For more detailed information on the setup and configuration of CindyBot, refer to the documentation provided in the respective directories (`frontend`, `api`, `terraform`).

## Security and Telemetry

CindyBot employs Azure Key Vault for secure storage of sensitive data, such as connection strings. It also integrates with Application Insights and Azure Monitor for telemetry, ensuring robust monitoring and diagnostics capabilities.

