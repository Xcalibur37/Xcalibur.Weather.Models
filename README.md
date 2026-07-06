# Xcalibur.Weather.Models

[![.NET 10](https://img.shields.io/badge/.NET-10.0-blue.svg)](https://dotnet.microsoft.com/)
[![NuGet](https://img.shields.io/nuget/v/Xcalibur.Weather.Models.svg)](https://www.nuget.org/packages/Xcalibur.Weather.Models/)
[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](LICENSE-2.0.txt)

A .NET 10 model library for weather, air quality, geocoding, astronomy, pollen, and weather alerts applications. It provides strongly-typed DTOs and domain models used to deserialize provider responses and represent current, hourly, and daily forecast data in a consistent way.

**Created by**: Joshua Arzt | **Company**: Xcalibur Systems, LLC.

## 📋 Table of Contents

- [Purpose](#purpose)
- [Key Features](#key-features)
  - [Forecast and Domain Models](#forecast-and-domain-models)
  - [Provider Models](#provider-models)
  - [Utilities and Preferences](#utilities-and-preferences)
  - [Included Types](#included-types)
- [Technology](#technology)
- [Use Cases](#use-cases)
- [Installation](#-installation)
- [Project Structure](#project-structure)
- [License](#-license)
- [Related Projects](#-related-projects)

## Purpose

**Xcalibur.Weather.Models** is designed to:

- Provide standardized data models for weather applications
- Support integration with multiple provider APIs including Open-Meteo, Geocodio, OpenStreetMap, Astronomy services (IpGeo, SunriseSunset.io), Atmospore (pollen), and weather alert services (Meteoalarm, NWS, GDACS, Environment Canada, BOM, EMSC, DWD)
- Deliver strongly-typed DTOs for current weather, hourly forecasts, daily forecasts, air quality, geocoding, astronomy, pollen, and multi-source weather alert data
- Provide reusable forecast point models for application-level weather presentation
- Offer location and address models for forward geocoding and lookup scenarios
- Centralize weather-related preference enums and helper methods

## Key Features

### Forecast and Domain Models

- **CurrentForecastPoint**: Real-time conditions including temperature, humidity, apparent temperature, precipitation, wind, and related metrics
- **HourlyForecastPoint**: Hourly forecast data for temperature, dew point, humidity, precipitation, wind, and cloud coverage
- **DailyForecastPoint**: Daily forecast summaries including high/low temperatures, precipitation probability, and daily conditions
- **AirQualityPoint**: Air quality measurements and AQI-oriented values for display and analysis
- **SunMoonPoint**: Sun and moon-related data for astronomy and daylight features
- **AddressLocationModel**: Application-facing location model for resolved addresses and coordinates
- **PrecipitationTile** and **DoubleRange**: Supporting models for precipitation display and value ranges
- **PollenInformation**: App-facing pollen forecast from Atmospore including daily breakdowns, pollen species counts, and location data
- **WeatherAlertInformation**: App-facing weather alert data from Google Weather Alerts API
- **CombinedWeatherAlertInformation**: Unified weather alert data from multiple sources (Meteoalarm, NWS, GDACS, Environment Canada, BOM, EMSC, DWD)

### Provider Models

The library includes DTOs for the following providers:

- **Open-Meteo**: Current weather, hourly weather, daily weather, weather units, and air quality response models
- **Geocodio**: Input, response, result, and address component models for geocoding workflows
- **OpenStreetMap / Nominatim**: Search result and nested address models for location lookup scenarios
- **Astronomy Services**: IpGeo and SunriseSunset.io models for astronomy data, sunrise/sunset, twilight, moonrise, moonset, azimuth, and illumination
- **Atmospore**: Pollen forecast response models including species-level counts, location data, and metadata
- **Weather Alert Services**: 
  - **Meteoalarm**: European severe weather warnings
  - **NWS (National Weather Service)**: US weather alerts and warnings
  - **GDACS**: Global Disaster Alert and Coordination System
  - **Environment Canada**: Canadian weather alerts (CAP format)
  - **BOM**: Australian Bureau of Meteorology warnings
  - **EMSC**: European-Mediterranean Seismological Centre earthquake data
  - **DWD**: German Weather Service (Deutscher Wetterdienst) alerts
- **Google Weather Alerts API**: Alert response, alert model, alert title, and data source models

### Utilities and Preferences

- **AqiValueHelper**: Maps AQI values to readable descriptions and health guidance
- **SecurityHelper**: Shared security-oriented helper functionality
- **Preferences enums**: Theme, temperature, soil moisture, time format, and distance units

### Included Types

- Core models:
  - `AddressLocationModel`
  - `AirQualityPoint`
  - `DetailedForecastPoint`
  - `DailyForecastPoint`
  - `DoubleRange`
  - `GridpointExtractedValues`
  - `HourlyForecastPoint`
  - `PollenDailyEntry`
  - `PollenInformation`
  - `PollenItem`
  - `PrecipitationTile`
  - `SunMoonPoint`
  - `CombinedWeatherAlertInformation`
  - `WeatherAlertInformation`
  - `WeatherAlertItem`
- Base model:
  - `BaseForecastPoint`
- Preference enums:
  - `ThemeSelections`
  - `TemperatureUnits`
  - `SoilMoistureUnits`
  - `TimeFormatUnits`
  - `DistanceUnits`
- Service model groups:
  - `Services.OpenMeteo.*`
  - `Services.Geocodio.*`
  - `Services.OpenStreetMap.*`
  - `Services.Astronomy.*`
  - `Services.Atmospore.Response.*`
  - `Services.GoogleWeatherAlerts.Response.*`
  - `Services.WeatherAlert.Bom.*`
  - `Services.WeatherAlert.Dwd.*`
  - `Services.WeatherAlert.Emsc.*`
  - `Services.WeatherAlert.EnvironmentCanada.*`
  - `Services.WeatherAlert.Gdacs.*`
  - `Services.WeatherAlert.Meteoalarm.*`
  - `Services.WeatherAlert.Nws.*`

## Technology

- **Target Framework**: .NET 10
- **Current Package Version**: 1.0.12
- **Dependencies**:
  - Xcalibur.Extensions.MVVM.V2 (v1.0.5)
- **Features**:
  - Implicit usings enabled
  - Nullable reference types enabled
  - JSON serialization support
  - NuGet package generation on Release build
  - README, license, icon, and symbols package support
  - High-performance regex optimizations using source-generated patterns

## 📦 Installation

Install via NuGet Package Manager:

```bash
dotnet add package Xcalibur.Weather.Models
```

Or via Package Manager Console:

```powershell
Install-Package Xcalibur.Weather.Models
```

Or add to your project file:

```xml
<PackageReference Include="Xcalibur.Weather.Models" Version="1.0.12" />
```

## Use Cases

This library is ideal for:

- Weather forecast applications
- Shared model packages for weather service layers and client apps
- Geocoding and location-aware weather applications
- Air quality monitoring dashboards
- Astronomy, daylight, and sun/moon tracking features
- Smart home, environmental, and agricultural solutions

## Project Structure

```
Xcalibur.Weather.Models/
├── Implementation/                # App-facing models
│   ├── AirQuality/               # Air quality models
│   ├── Base/                     # Base forecast classes
│   ├── Geocoding/                # Address and location models
│   ├── Pollen/                   # Pollen information models
│   ├── Precipitation/            # Precipitation tile models
│   ├── SunMoon/                  # Sun and moon data models
│   ├── WeatherAlerts/            # Alert information models
│   ├── WeatherForecast/          # Forecast point models
│   └── Preferences.cs            # Preference enums
├── Services/                      # Provider-specific DTOs
│   ├── Astronomy/                # Astronomy response models
│   ├── Atmospore/                # Atmospore pollen API
│   ├── Geocodio/                 # Geocodio geocoding
│   ├── GoogleWeatherAlerts/      # Google Weather Alerts API
│   ├── OpenMeteo/                # Open-Meteo weather API
│   ├── OpenStreetMap/            # OpenStreetMap / Nominatim
│   └── WeatherAlert/             # Multi-source weather alerts
│       ├── Bom/                  # Australian BOM
│       ├── Dwd/                  # German DWD
│       ├── Emsc/                 # EMSC earthquakes
│       ├── EnvironmentCanada/    # Canadian alerts
│       ├── Gdacs/                # GDACS global disasters
│       ├── Meteoalarm/           # European Meteoalarm
│       └── Nws/                  # US National Weather Service
├── Helpers/                       # Utility and helper classes
└── Testing/                       # Testing utilities
```

## Latest Updates

### v1.0.12
- **Breaking Change**: Retired `WeatherCode` property for multi-language compatibility
  - Weather code descriptions are language-specific and should be handled by localization services
  - Consumers should use raw weather code values with their own localization
- Improved model flexibility for international applications

### v1.0.11
- **Performance Optimizations** for `AlertMapper` helper class:
  - Migrated all regex patterns to source-generated `[GeneratedRegex]` (41 patterns)
  - Replaced `ToUpperInvariant()` with `StringComparison.OrdinalIgnoreCase` for zero-allocation comparisons
  - Removed redundant `Contains()` calls in favor of exact `Equals()` matching
  - Optimized `MapCategory` to prioritize exact matches before fallback substring matching
  - **Performance improvements**: ~10-100x faster regex matching, ~20-40% faster string comparisons, reduced GC pressure
- Updated alert mapping methods for CAP (Common Alerting Protocol) standard compliance
- Enhanced property descriptions for weather alert models

### v1.0.10
- Additional property descriptions and documentation improvements

### v1.0.9
- Minor bug fixes and refinements

### v1.0.8
- Internal improvements and updates

### v1.0.7
- Added multi-source weather alert aggregation support
- Introduced `CombinedWeatherAlertInformation` for unified alert handling across multiple providers
- Enhanced alert service provider coverage

### v1.0.6
- **Major Refactoring**: Reorganized project structure
  - Moved app-facing models to `Implementation/` namespace
  - Moved provider DTOs to `Services/` namespace
- **Added Atmospore Pollen API**: Replaced Google Pollen with Atmospore
  - `PollenResponse`
  - `PollenEntryResponse`
  - `PollenSpeciesEntryResponse`
  - `PollenMetaResponse`
  - `PollenLocationResponse`
- **Added Multiple Weather Alert Services**:
  - **Meteoalarm**: European severe weather alerts
  - **NWS (National Weather Service)**: US alerts with CAP format
  - **GDACS**: Global disaster coordination system
  - **Environment Canada**: Canadian weather alerts (CAP/XML)
  - **BOM**: Australian Bureau of Meteorology warnings
  - **EMSC**: European-Mediterranean earthquake data
  - **DWD**: German Weather Service alerts
- **New Implementation Models**:
  - `CombinedWeatherAlertInformation`: Unified multi-source alerts
  - `DetailedForecastPoint`: Enhanced forecast details
  - `GridpointExtractedValues`: Gridpoint data extraction
  - Refactored pollen models: `PollenDailyEntry`, `PollenItem`
- **Removed Legacy Models**: Google Pollen API models removed in favor of Atmospore

### v1.0.5
- Added **Google Weather Alerts API** provider models:
  - `WeatherAlertsResponse`
  - `WeatherAlertModel`
  - `AlertTitleModel`
  - `AlertDataSourceModel`
- Added app-facing alert models:
  - `WeatherAlertInformation`
  - `WeatherAlertItem`
- Bumped `Xcalibur.Extensions.MVVM.V2` dependency to **v1.0.5**

### v1.0.4
- Added app-facing pollen models:
  - `PollenInformation`
  - `PollenDailyInformation`
  - `PollenTypeInformation`
  - `PollenPlantInformation`

### v1.0.3
- Added **Google Pollen API** forecast models:
  - `PollenForecastResponse`
  - `DailyInfoModel`
  - `ForecastDateModel`
  - `IndexInfoModel`
  - `PlantDescriptionModel`
  - `PlantInfoModel`
  - `PollenTypeInfoModel`
  - `ColorModel`

### v1.0.2
- Added **SunriseSunset.io** response models:
  - `SunriseSunsetResponse`
  - `SunriseSunsetResultModel`
- Added **OpenStreetMap / Nominatim** models:
  - `OpenStreetMapResult`
  - `OpenStreetMapAddress`
- Updated NuGet packaging metadata for README, license, icon, symbols, and Release build package generation

## 📄 License

This project is licensed under the Apache License 2.0. See the `LICENSE-2.0.txt` file included with the package for details.

Copyright © 2006 - 2026, Xcalibur Systems, LLC - All Rights Reserved

## 🔗 Related Projects

- **[Xcalibur.Weather.Services](https://www.nuget.org/packages/Xcalibur.Weather.Services/)** - HTTP client services for weather APIs ([GitHub](https://github.com/Xcalibur37/Xcalibur.Weather.Services))
- **[Xcalibur.Weather.Helpers](https://www.nuget.org/packages/Xcalibur.Weather.Helpers/)** - Utility functions and conversion helpers ([GitHub](https://github.com/Xcalibur37/Xcalibur.Weather.Helpers))

*Part of the Xcalibur Weather ecosystem for comprehensive weather data integration.*

Contributions are welcome! Please feel free to submit issues or pull requests to improve the library.

## Author

**Joshua Arzt**  
Xcalibur Systems, LLC
