# ReviewManagement

[![ABP version](https://img.shields.io/badge/dynamic/xml?style=flat-square&color=yellow&label=abp&query=%2F%2FProject%2FPropertyGroup%2FAbpVersion&url=https%3A%2F%2Fraw.githubusercontent.com%2FEasyAbp%2FReviewManagement%2Fmain%2FDirectory.Build.props)](https://abp.io)
[![NuGet](https://img.shields.io/nuget/v/EasyAbp.ReviewManagement.Domain.Shared.svg?style=flat-square)](https://www.nuget.org/packages/EasyAbp.ReviewManagement.Domain.Shared)
[![NuGet Download](https://img.shields.io/nuget/dt/EasyAbp.ReviewManagement.Domain.Shared.svg?style=flat-square)](https://www.nuget.org/packages/EasyAbp.ReviewManagement.Domain.Shared)
[![GitHub stars](https://img.shields.io/github/stars/EasyAbp/ReviewManagement?style=social)](https://www.github.com/EasyAbp/ReviewManagement)

An abp application module that provides general user review service. For example, a user can review a product he has bought with text, pictures and star-rating.

## Online Demo

We have launched an online demo for this module: [https://review.samples.easyabp.io](https://review.samples.easyabp.io)

## Installation

1. Install the following NuGet packages. ([see how](https://github.com/EasyAbp/EasyAbpGuide/blob/master/docs/How-To.md#add-nuget-packages))

    * EasyAbp.ReviewManagement.Application
    * EasyAbp.ReviewManagement.Application.Contracts
    * EasyAbp.ReviewManagement.Domain
    * EasyAbp.ReviewManagement.Domain.Shared
    * EasyAbp.ReviewManagement.EntityFrameworkCore
    * EasyAbp.ReviewManagement.HttpApi
    * EasyAbp.ReviewManagement.HttpApi.Client
    * (Optional) EasyAbp.ReviewManagement.MongoDB
    * (Optional) EasyAbp.ReviewManagement.Web

1. Add `DependsOn(typeof(ReviewManagementXxxModule))` attribute to configure the module dependencies. ([see how](https://github.com/EasyAbp/EasyAbpGuide/blob/master/docs/How-To.md#add-module-dependencies))

1. Add `builder.ConfigureReviewManagement();` to the `OnModelCreating()` method in **MyProjectMigrationsDbContext.cs**.

1. Add EF Core migrations and update your database. See: [ABP document](https://docs.abp.io/en/abp/latest/Tutorials/Part-1?UI=MVC&DB=EF#add-database-migration).

## Usage

1. Add permissions to the roles you want.

1. Create authorization handlers for a type of entity that needs user's reviews. (see the product entity review creation authorization handler [sample](https://github.com/EasyAbp/ReviewManagement/blob/main/host/EasyAbp.ReviewManagement.Web.Unified/EasyAbp/ReviewManagement/CreateProductReviewAuthorizationHandler.cs))

1. Try to create a review.

![Reviews](/docs/images/Reviews.png)
![Creation](/docs/images/Creation.png)

## Road map

- [ ] More friendly UI.
- [ ] Unit tests.
