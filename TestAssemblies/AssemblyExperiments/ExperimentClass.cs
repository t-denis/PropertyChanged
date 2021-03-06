﻿using System.ComponentModel;

public class Experiment :INotifyPropertyChanged
{
    string statusMessage;

    public Experiment()
    {
        StatusMessage = "...";
    }

    public string StatusMessage
    {
        get { return statusMessage; }
        set
        {
            statusMessage = value;
            OnPropertyChanged("StatusMessage"); 
        }
    }

    public static bool IsChanged { get; set; }
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        var handler = PropertyChanged;
        if (handler != null)
        {
            handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}