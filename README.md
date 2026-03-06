# Xcalibur.Weather.Models

[![.NET 10](https://img.shields.io/badge/.NET-10.0-blue.svg)](https://dotnet.microsoft.com/)
[![NuGet](https://img.shields.io/nuget/v/Xcalibur.Weather.Models.svg)](https://www.nuget.org/packages/Xcalibur.Weather.Models/)
[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](LICENSE-2.0.txt)

A comprehensive .NET library providing data models and DTOs for weather-related applications. This library serves as the foundation for weather data management, supporting multiple weather service providers and offering strongly-typed models for weather forecasting, air quality monitoring, and astronomical data.

**Created by**: Joshua Arzt | **Company**: Xcalibur Systems, LLC.

## Purpose

**Xcalibur.Weather.Models** is designed to:

- Provide standardized data models for weather applications
- Support integration with multiple weather service providers (OpenMeteo, Geocodio, IpGeo)
- Deliver strongly-typed DTOs for current weather, hourly forecasts, daily forecasts, and air quality data
- Enable astronomical data handling including sunrise/sunset, moon phases, and solar information
- Offer location and geocoding model support for address-based weather lookups
- Facilitate unit conversions and preference management for weather data presentation

## Key Features

### Weather Data Models

- **Current Weather**: Real-time weather conditions including temperature, humidity, wind speed, and more
- **Hourly Forecasts**: Hour-by-hour weather predictions with detailed atmospheric data
- **Daily Forecasts**: Day-by-day weather outlooks with high/low temperatures and precipitation probability
- **Air Quality Monitoring**: Air Quality Index (AQI) data with health impact descriptions

### Provider Support

The library includes comprehensive DTOs for:

- **OpenMeteo API**: Current weather, hourly weather, daily weather, and air quality endpoints
- **Geocodio API**: Address geocoding and reverse geocoding with detailed location components
- **IpGeo API**: Astronomical data including sunrise/sunset times and celestial events

### Utilities & Helpers

- **AQI Value Helper**: Converts raw air quality index values to human-readable descriptions and health advisories
- **Security Helper**: Utilities for secure API interactions
- **Unit Preferences**: Support for temperature (Fahrenheit/Celsius), distance (Imperial/Metric), time format (12h/24h), and soil moisture units

### Data Types

- `CurrentForecastPoint`: Current weather conditions
- `HourlyForecastPoint`: Hourly weather forecast data
- `DailyForecastPoint`: Daily weather forecast data
- `AirQualityPoint`: Air quality measurements and indices
- `SunMoonPoint`: Astronomical data for sun and moon
- `AddressLocationModel`: Location and address information with geocoding support
- `PrecipitationTile`: Precipitation data visualization support

## Technology

- **Target Framework**: .NET 10
- **Dependencies**: 
  - Xcalibur.Extensions.MVVM.V2 (v1.0.4)
- **Features**: 
  - Implicit usings enabled
  - Nullable reference types enabled
  - JSON serialization support

## Use Cases

This library is ideal for:

- Weather forecast applications (desktop, web, or mobile)
- Smart home systems with weather integration
- Agricultural applications requiring soil moisture and weather tracking
- Environmental monitoring systems
- Location-based weather services
- Air quality monitoring applications
- Astronomy and celestial event tracking

## Project Structure

```
Xcalibur.Weather.Models/
├── Base/                          # Base classes for forecast models
├── WeatherProvider/               # Provider-specific implementations
│   ├── OpenMeteo/                # OpenMeteo API models
│   │   ├── CurrentWeather/
│   │   ├── HourlyWeather/
│   │   ├── DailyWeather/
│   │   └── CurrentAirQuality/
│   ├── Geocodio/                 # Geocodio geocoding models
│   └── IpGeo/                    # IpGeo astronomy models
├── Helpers/                       # Utility and helper classes
└── [Core Models]                  # Main forecast and data point models
```

## Related Projects

- **Xcalibur.Weather.Models** - Core weather data models and enumerations
- **Xcalibur.Weather.Services** - HTTP client services for weather APIs

## License

Copyright © 2006 - 2026, Xcalibur Systems, LLC - All Rights Reserved

Licensed under the Apache License, Version 2.0. See [LICENSE-2.0.txt](LICENSE-2.0.txt) for details.

## Author

**Joshua Arzt**  
Xcalibur Systems, LLC

---

*Part of the Xcalibur Weather ecosystem for comprehensive weather data integration.*

