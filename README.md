# Proyecto StackStudents DevOps
StackStudents

## ¿Qué es el proyecto?
Un proyecto que ayude a la comunidad estudiantil de la Universidad Tecnológica de Nezahualcóyotl, usando (STAGING, PRODUCTION, ETC).

```
{
  "enviroment": "Development",
  "releaseDate": "2022-11-27T18:56:50.1707389Z"
}
```

## Comandos usados
```
az login

az extension add --name aks-preview
az extension update --name aks-preview

az feature register --name WindowsPreview --namespace Microsoft.ContainerService
az provider register --namespace Microsoft.ContainerService

az aks create --resource-group stagaksstackstudents --name StagWinAKS --node-count 1 --kubernetes-version 1.15.7 --generate-ssh-keys --windows-admin-password P@sa5trttrw0rd123 --windows-admin-username azureuser --vm-set-type VirtualMachineScaleSets --load-balancer-sku standard --network-plugin azure

az aks create --resource-group prodaksstackstudents --name ProdWinAKS --node-count 1 --kubernetes-version 1.15.7 --generate-ssh-keys --windows-admin-password P@sa5trttrw0rd123 --windows-admin-username azureuser --vm-set-type VirtualMachineScaleSets --load-balancer-sku standard --network-plugin azure

az aks install-cli

az aks get-credentials --resource-group stagaksstackstudents --name StagWinAKS
az aks get-credentials --resource-group prodaksstackstudents --name ProdWinAKS

kubectl create clusterrolebinding kubernetes-dashboard -n kube-system --clusterrole=cluster-admin --serviceaccount=kube-system:kubernetes-dashboard

az aks browse --resource-group stagaksstackstudents --name StagWinAKS
az aks browse --resource-group prodaksstackstudents --name ProdWinAKS
```

## StackStudents Producción
El recurso esta disponible a través del siguiente link https://stackstudents.desarrolladorferizamart.com/
User: demo  
Pass: demo1234