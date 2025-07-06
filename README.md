<h1 align="center">Caspnetti</h1>

![splash-image](./docs/assets/caspnetti-splash.jpg)

<blockquote align="center">"Mom's caspnetti"</blockquote>

## Purpose

This repository serves as a foundation for creating new projects. It provides:
- Extendable modules, base classes, and templates
- Commonly used tools and config
- Documentation and scripts to speed up development

## Getting Started

Download [docker](https://docs.docker.com/) then run the following:

```
git clone git@github.com:ramity/caspnetti.git
cd caspnetti
./scripts/copy_env.sh
docker compose up -d
```

> It's that shrimple 🦐 See [docs/](docs/) for more details!

## Features

- 🚄 Stupid fast performance capable of handling [15,000+ requests/second](https://github.com/ramity/caspnetti/blob/master/docs/simple-benchmark.md)
- 🐋 Fully [dockerized](https://www.docker.com/) environment
- 📝 Code-first SQL [migrations](https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/managing?tabs=dotnet-core-cli) using [entity framework](https://learn.microsoft.com/en-us/ef/core/cli/dotnet)
- ⚖️ A controller, entity, service, and test abstraction pattern built for any scale
- 🔍 [Adminer](https://www.adminer.org/en/) for easy database viewing
- 👋 [Hey](https://github.com/rakyll/hey) for convient saturation testing
- 😎 [Swagger](https://learn.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-8.0&viewFallbackFrom=aspnetcore-9.0) for living documentation and testing
- ⏺️ Custom docker container monitoring
- ✌️ [Vue.js](https://vuejs.org/) frontend
- 🅱️ [Bootstrap](https://getbootstrap.com/)
- 📺 Development and production ready services

## Rationale

After using aspnet core in a commercial setting and slowly comming around to the framework, I wanted a good boilerplate to be able to create other projects with. This project provides many of the developer comforts I've come accustomed to having with other frameworks.

Here's an incomplete list of things I prioritize in a web stack:
- performance
- package manager and support
- easy importing
- module/package approach for dividing code into logical units: controller, entity, service at the very least
- thin controller, fat service paradigm
- ORM support
- code first SQL generation approach (usually referred to as migration(s) by different frameworks)
- automated and reversible migrations and fixtures to seed the database with values
- automated unit testing

What I'm willing to give up:
- type juggling
- automatic memory management/garbage collector
- premade middleware
- hot reload
- debugger/breakpoints/stepping over code/inspection of variables
