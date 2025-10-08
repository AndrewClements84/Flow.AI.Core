<p align="center">
  <img src="https://github.com/AndrewClements84/Flow.AI.Core/blob/master/assets/logo.png?raw=true" alt="Flow.AI.Core" width="500"/>
</p>

# 🧱 Flow.AI.Core

[![Build](https://github.com/AndrewClements84/Flow.AI.Core/actions/workflows/dotnet.yml/badge.svg)](https://github.com/AndrewClements84/Flow.AI.Core/actions/workflows/dotnet.yml)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](LICENSE)
[![NuGet](https://img.shields.io/nuget/v/Flow.AI.Core.svg)](https://www.nuget.org/packages/Flow.AI.Core/)

Core contracts and shared models for the **Flow.AI** ecosystem.  
Used by TokenFlow.AI, PromptFlow.AI, ChatFlow.AI, and ReasonFlow.AI.

---

## ✨ Purpose

Defines common interfaces and DTOs that allow all Flow components to speak a shared language.

```csharp
using Flow.AI.Core.Interfaces;

ITokenFlowProvider provider = ...;
int tokenCount = provider.CountTokens("gpt-4o-mini", "Hello world!");
```

---

## 🧭 Project Usage

| Layer | Project | Description |
|-------|----------|--------------|
| 🔗 Shared | **Flow.AI.Core** | Core contracts, DTOs, interfaces |
| ⚙️ Engine | **TokenFlow.AI** | Tokenization logic |
| 🧩 Cockpit | **PromptFlow.AI** | Prompt composition |
| 💬 Interaction | **ChatFlow.AI** | Chat orchestration |
| 🧠 Reasoning | **ReasonFlow.AI** | Chain-of-thought orchestration |
