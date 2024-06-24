variable "resource_group_name" {
  description = "The name of the resource group"
  type        = string
}

variable "location" {
  description = "The Azure region where resources will be created"
  type        = string
}

variable "cosmosdb_account_name" {
  description = "The name of the CosmosDB account"
  type        = string
}

variable "cosmosdb_sql_database_name" {
  description = "The name of the CosmosDB SQL database"
  type        = string
}

variable "openai_account_name" {
  description = "The name of the Azure OpenAI account"
  type        = string
}

variable "vnet_name" {
  description = "The name of the virtual network"
  type        = string
}

variable "subnet_name" {
  description = "The name of the subnet within the virtual network"
  type        = string
}

variable "nsg_name" {
  description = "The name of the network security group"
  type        = string
}
