# HTMLComponents
- This is a collection of custom Html components and services I find useful. 

## Demo
- The local 'Sandbox' project contains a demo on using the components
- A demo of this and some of my other NuGet packages can be found [here](https://github.com/marqdouj/BlazorSandbox)

## NuGet Package
- https://www.nuget.org/packages/Marqdouj.HtmlComponents/

## Components
- **CircleImage**: Displays an image(photo) in a circle (i.e. Avatar).
- **SlideShow**: Displays a list of images (i.e. Banner/Carousel).

## Services
- **ResizeObserverService** Scoped service to monitor html element resizing.

## Release Notes
**8.0.2**
- Added missing ResizeObserverService:IAsyncDisposable

**8.0.1**
- Added ResizeObserverService
  - `builder.Services.AddScoped<IResizeObserverService, ResizeObserverService>();`

**8.0.0**
- Added CircleImage component
- Added SlideShow component
- Created Package
