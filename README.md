# Xcalibur.Weather.Models

[![.NET 10](https://img.shields.io/badge/.NET-10.0-blue.svg)](https://dotnet.microsoft.com/)
[![NuGet](https://img.shields.io/nuget/v/Xcalibur.Weather.Models.svg)](https://www.nuget.org/packages/Xcalibur.Weather.Models/)
[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](LICENSE-2.0.txt)

A .NET 10 model library for weather, air quality, geocoding, and astronomy applications. It provides strongly-typed DTOs and domain models used to deserialize provider responses and represent current, hourly, and daily forecast data in a consistent way.

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
- Support integration with multiple provider APIs including Open-Meteo, Geocodio, OpenStreetMap, IpGeo, and SunriseSunset.io
- Deliver strongly-typed DTOs for current weather, hourly forecasts, daily forecasts, air quality, geocoding, and astronomy data
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

### Provider Models

The library includes DTOs for the following providers:

- **Open-Meteo**: Current weather, hourly weather, daily weather, weather units, and air quality response models
- **Geocodio**: Input, response, result, and address component models for geocoding workflows
- **OpenStreetMap / Nominatim**: Search result and nested address models for location lookup scenarios
- **IpGeo Astronomy**: Astronomy, location, morning/evening, and sun/moon response models
- **SunriseSunset.io**: Response and result models for sunrise, sunset, twilight, moonrise, moonset, azimuth, and illumination data

### Utilities and Preferences

- **AqiValueHelper**: Maps AQI values to readable descriptions and health guidance
- **SecurityHelper**: Shared security-oriented helper functionality
- **Preferences enums**: Theme, temperature, soil moisture, time format, and distance units

### Included Types

- Core models:
  - `AddressLocationModel`
  - `AirQualityPoint`
  - `CurrentForecastPoint`
  - `DailyForecastPoint`
  - `DoubleRange`
  - `HourlyForecastPoint`
  - `PrecipitationTile`
  - `SunMoonPoint`
- Base model:
  - `BaseForecastPoint`
- Preference enums:
  - `ThemeSelections`
  - `TemperatureUnits`
  - `SoilMoistureUnits`
  - `TimeFormatUnits`
  - `DistanceUnits`
- Provider model groups:
  - `WeatherProvider.OpenMeteo.*`
  - `WeatherProvider.Geocodio.*`
  - `WeatherProvider.OpenStreetMap.*`
  - `WeatherProvider.IpGeo.Astronomy.*`
  - `WeatherProvider.SunriseSunset.*`

## Technology

- **Target Framework**: .NET 10
- **Current Package Version**: 1.0.2
- **Dependencies**:
  - Xcalibur.Extensions.MVVM.V2 (v1.0.4)
- **Features**:
  - Implicit usings enabled
  - Nullable reference types enabled
  - JSON serialization support
  - NuGet package generation on Release build
  - README, license, icon, and symbols package support

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
<PackageReference Include="Xcalibur.Weather.Models" Version="1.0.2" />
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
├── Base/                          # Base classes for forecast models
├── WeatherProvider/               # Provider-specific DTOs
│   ├── Geocodio/                  # Geocodio models
│   ├── IpGeo/                     # IpGeo astronomy models
│   ├── OpenMeteo/                 # Open-Meteo models
│   │   ├── CurrentWeather/
│   │   ├── HourlyWeather/
│   │   ├── DailyWeather/
│   │   └── CurrentAirQuality/
│   ├── OpenStreetMap/             # OpenStreetMap / Nominatim models
│   └── SunriseSunset/             # SunriseSunset.io models
├── Helpers/                       # Utility and helper classes
├── Preferences.cs                 # Shared preference enums
└── [Core Models]                  # Forecast and location models
```

## Latest Updates

- Updated package version to **1.0.2**
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
