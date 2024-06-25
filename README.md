# Desafio UBC Backend .NET6

## Rodar localmente
 1. Em DesafioUBC.Backend.API, rode setJwtKey.bat para setar a private key do JWT (user-secrets)
 2. Em DesafioUBC.Backend.Data, rode EFCore-Database-Update.bat para inicializar o banco e efetuar o initial seed
 3. Em DesafioUBC.Backend.API, no terminal execute o comando dotnet run

![image](https://github.com/lucasmrthomaz/DesafioUBC.Backend/assets/11547508/86998c4f-d2b3-4c59-8439-7dcb7b43b3aa)
 
## Obtendo token jwt

POST /api/Auth/login
```
{
  "username": "ubc",
  "password": "123456"
}
```

Usuario padrao
- Usuario: ubc
- Senha: 123456

![image](https://github.com/lucasmrthomaz/DesafioUBC.Backend/assets/11547508/b1efe381-4a8e-4b07-ab78-691c520c9ade)
