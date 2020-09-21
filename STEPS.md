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

## Branch add-basic-versioning

1. Versionierungs-Funktionalität zum Startup hinzugefügt und dem Standard-Controller über ein Attribut die Version 1.0 zugewiesen.
2. Zwei neue Beispiel-Controller hinzugefügt mit einem versionierten Endpunkt. 
3. Neuer Controller mit zwei unterschiedlichen Versionen des gleichen Endpunkts hinzugefügt.

## Branch configure-versioning

1. ReportApiVersions anschalten, um Informationen zur Version auszugeben.
2. Versionsauswahl ändern auf Media Type.
3. Versionsauswahl ändern auf Url-Teil.
4. Eine Version als veraltet markieren.

## Branch advanced-customization

1. WeatherForecast Controller in einen unversionierten Zustand zurück bringen und Standard-Version hinzufügen.
2. Endpunkt aus der Versionierung ausnehmen.
3. Versionsauswahl individuell anpassen.
