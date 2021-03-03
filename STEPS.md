# Einzelschritte / Steps

## Branch start-new-project

Deutsch:

Erzeuge ein neues WebApi Projekt, und installiere die notwendigen Abhängigkeiten von NuGet. Zur Nachvollziehbarkeit werden die SDK Version und alle Paket Versionen fest gepinnt.

Commandline:

```shell
dotnet new global --sdk-version 5.0.103
dotnet new webapi -n ApiVersioning
cd ApiVersioning
dotnet add package Microsoft.AspNetCore.Mvc.Versioning -v 5.0.0
dotnet add package Microsoft.AspNetCore.Mvc.Versioning.ApiExplorer -v 5.0.0
```
