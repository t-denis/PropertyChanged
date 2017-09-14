This branch adds an ability to explicitly specify tracked properties.
Because a code based on naming conventions only may become too fragile.

```cs
public class Person : INotifyPropertyChanged
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    [OnPropertyChanged(nameof(FirstName), nameof(LastName))]
    public void OnNameChanged()
    {
    }

    public event PropertyChangedEventHandler PropertyChanged;
}
```

## This is an add-in for [Fody](https://github.com/Fody/Fody/) 

![Icon](https://raw.github.com/Fody/PropertyChanged/master/Icons/package_icon.png)

Injects [INotifyPropertyChanged](http://msdn.microsoft.com/en-us/library/system.componentmodel.inotifypropertychanged.aspx)  code into properties at compile time.

[Introduction to Fody](http://github.com/Fody/Fody/wiki/SampleUsage) 

## More Info

* [PropertyChanged](https://github.com/Fody/PropertyChanged)
