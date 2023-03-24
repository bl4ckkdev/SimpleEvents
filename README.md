# Introduction
Simple Events is a Unity asset meant for simple UI event handling such as detecting clicks. It was made because the built-in IPointer interface can be buggy at times. With that 
being said, it's a very simple alternative but it offers almost the same amount of features reliably.

# Getting Started
To get started, download the unity package over at https://u3d.as/32NA and import the C# Scripts. That's it!

# How To Use
Make a new script and make the class implement ```bl4ckdev.events``` 
(bl4ckdev.events inherits MonoBehaviour by default, so you will still have your MonoBehaviour functions!)
```csharp
public class Script : bl4ckdev.Events
{

}
```

Next up, we'll need to update event handling every frame
```csharp
public class Script : bl4ckdev.Events
{
    public void Update()
    {
        UpdateEvents(); // Updates event handling every frame.
    }
}
```

From there, there are 5 event functions that can be used
```csharp
public class Script : bl4ckdev.Events
{
    public void Update()
    {
        UpdateEvents(); // Updates event handling every frame.
    }
    
    public override void Over()
    {
        // Runs whenever the mouse pointer is over this object
    }
    
    public override void Hold()
    {
        // Runs whenever the mouse pointer is holding this object
    }
    
    public override void Down()
    {
        // Runs whenever the mouse pointer is over this object and clicks down
    }
    
    public override void Exit()
    {
        // Runs whenever the mouse pointer is over this object and clicks up
    }
    
    public override void Exit()
    {
        // Runs whenever the mouse pointer goes out of this object
    }
}
