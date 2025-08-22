# Blazor TypeScript Build Issue Demo

This repository demonstrates a Blazor Web App (with WebAssembly client) that uses TypeScript for component-isolated JavaScript.

## Project Structure
- .NET 9.0 Blazor Web App
- Client/Server architecture
- TypeScript support via Microsoft.TypeScript.MSBuild v5.9.2 (latest)

## Known Issue
When building with GitHub Actions, we encounter BLAZOR106 errors for .razor.js files that are generated from .razor.ts files. This issue doesn't occur when building on Windows.