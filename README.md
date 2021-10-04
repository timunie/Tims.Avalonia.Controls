# Tims.Avalonia.Controls
Some additional controls and helper for AvaloniaUI 

# ! PLEASE NOTE !
This library is just a collection of controls and helper I find useful. There is and most likely will be no stable release. Use this library on your own risk. Instead of creating another library I'd like to transfer useful controls to any other existing library, for example Aura.UI. If you have a usecase for any of my controls please constact me. 

# Converter
## ObjectEqualsToBooleanConverter

This converter takes the value of a binding and compares it to a given `ConverterParameter`. You can also use the `Inverter`- property to get the invert compare value.

Usage: 
1. Add the needed namespace
```xaml
xmlns:conv="using:TimsAvaloniaControls.Converters"
```
2. Add the converter inside your `Binding`. There are two build in Instances, so you are not forced to add it to your `Resources`-section, while you still can do so:
```xaml
{Binding MyText, Converter={x:Static conv:ObjectEqualsToBooleanConverter.InstanceInverted}, ConverterParameter='Test'}
```
 