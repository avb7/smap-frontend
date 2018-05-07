# SMAP.Frontend

Welcome to the Smap's front-end repository. The purpose of the README is to establish some core ideas and principles with which we'll be building the front-end. 

# About

We're going to be using Xamarin.Forms to build the front-end for both iOS and Android. Here's a few links that will assist you with the development

- Xamarin Documentation https://docs.microsoft.com/en-us/xamarin/
  
 ## Project Layout
 - ### SMAP (Core)
    The class library which contains all the shared code (Views, Controller/ViewModel)
 - ### SMAP.iOS
    iOS Specific code for package integration, etc.
 - ### SMAP.Droid
    Droid Specific code for package integration, etc.

  
 ## Layered Architecture 
 We'll be using the Prism MVVM package to build the MVVM layered architecture. Please refer to this document to understand how we're going to set it up. 
 
 - Prism MVVM for .NET
 https://prismlibrary.github.io/docs/xamarin-forms/Getting-Started.html
 - Extensive guide for Prism MVVM
 https://xamgirl.com/prism-in-xamarin-forms-step-by-step-part-1/


## Mapbox SDK for Xamarin Forms 
Please read the documentation here 
https://github.com/NAXAM/mapbox-xamarin-forms
