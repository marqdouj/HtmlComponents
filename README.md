# HTMLComponents
- This is a collection of custom Html components and services I find useful. 

## Demo
- The local 'Sandbox' project contains a demo on using the components
- A demo of this and some of my other NuGet packages can be found [here](https://github.com/marqdouj/BlazorSandbox)

## NuGet Package
- https://www.nuget.org/packages/Marqdouj.HtmlComponents/

## Components
- **CircleImage**: Displays an image(photo) in a circle (i.e. Avatar).
  - NOTE: `Fluent UI` has a [FluentPersona](https://www.fluentui-blazor.net/Persona) component that does this and more.
- **SlideShow**: Displays a list of images (i.e. Banner/Carousel).

## Services
- **ResizeObserverService** Scoped service to monitor html element resizing.

## Models
- **UI Model**
  - `UIModel` classes for UI presentation and binding.
Implements a `BindValue` string property for non-string values
where binding requires a string. Designed for use with Blazor @bind-Value.

## Release Notes
**8.2.1**
-  `IUIModelValue.IsNullableValueType` property was added. Indicates if the underlying Property Type is a nullable value type.

**8.2.0**
-  Removed all references to the `Microsoft.TypeScript.MSBuild` package.
   - This package is no longer being used and was causing build issues when a RCL project also referenced this package.

**8.1.4**
-  `UIModelValue`.`BindValue` with Enum? property. Added missing null or empty string assignment.

**8.1.3**
-  `UIModelValue`.`ReadOnly` property. Moved implementation to `UIValueDef`.

**8.1.2**
-  added `UIModelValue`.`ReadOnly` property. If true, the UI should not allow editing of the value.

**8.1.1**
-  `UIModel`.`ToUIList()` method is now virtual.

**8.1.0**
- `tsconfig.json` is no longer being distributed with the NuGet package.
- Added `UIModel` classes.

**8.0.5**
- Update NuGet pkgs

**8.0.4**
- ResizeObserverService
  - Add DynamicDependency attribute to JSInvokable methods

**8.0.3**
- ResizeObserverService
  - Add overloads for Observe/UnObserve that take a `List<string>`

**8.0.2**
- Added missing ResizeObserverService:IAsyncDisposable

**8.0.1**
- Added ResizeObserverService
  - `builder.Services.AddScoped<IResizeObserverService, ResizeObserverService>();`

**8.0.0**
- Added CircleImage component
- Added SlideShow component
- Created Package
