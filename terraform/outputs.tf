output "resource_group_name" {
  value = azurerm_resource_group.rg.name
  description = "The name of the resource group"
}

output "cosmosdb_account_endpoint" {
  value = azurerm_cosmosdb_account.cosmosdb.endpoint
  description = "The endpoint of the CosmosDB account"
}

output "cosmosdb_account_primary_key" {
  value = azurerm_cosmosdb_account.cosmosdb.primary_master_key
  description = "The primary key for the CosmosDB account"
}

output "openai_account_endpoint" {
  value = azurerm_cognitive_account.openai.endpoint
  description = "The endpoint of the Azure OpenAI account"
}

output "vnet_id" {
  value = azurerm_virtual_network.vnet.id
  description = "The ID of the virtual network"
}

output "subnet_id" {
  value = azurerm_subnet.subnet.id
  description = "The ID of the subnet"
}

output "nsg_id" {
  value = azurerm_network_security_group.nsg.id
  description = "The ID of the network security group"
}
