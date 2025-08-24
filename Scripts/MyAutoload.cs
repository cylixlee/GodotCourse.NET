using Godot;

public partial class MyAutoload : Node
{
    int counter = 0;

    public void SayCount()
    {
        GD.Print($"[MyAutoload] counter: {counter++}");
    }

    public override void _Input(InputEvent @event)
    {
        base._Input(@event);
        if (@event.IsActionPressed("ui_accept"))
        {
            GD.Print("[MyAutoload] ui_accept pressed");
        }
    }
}
