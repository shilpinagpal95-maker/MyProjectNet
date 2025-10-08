# CSharp API Project

## Overview
C# API test automation project using .NET 8, NUnit, and RestSharp/HttpClient.

## Setup
1. Clone repo
2. Open solution in Visual Studio 2022 or VS Code
3. Configure API URL and token in `Config/appsettings.json` or environment variables

## Running Tests
- Run via Visual Studio Test Explorer
- Or CLI: `dotnet test`

## Endpoints Tested
- PATCH /resource/{id} with positive & negative test cases

## Reports
- NUnit XML reports in `Reports/`
- CI/CD test results in GitHub Actions artifacts

## CI/CD
- GitHub Actions workflow included in `.github/workflows/ci.yml`