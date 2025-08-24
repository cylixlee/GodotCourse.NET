using Godot;

public partial class Root : Node2D
{
    [Signal]
    public delegate void MySignalEventHandler();

    Sprite2D? player;

    public override void _Ready()
    {
        base._Ready();
        player = GetNode<Sprite2D>("Player");
    }

    public override void _Input(InputEvent @event)
    {
        base._Input(@event);
        if (@event.IsActionPressed("ui_accept", allowEcho: true))
        {
            EmitSignal("MySignal");
        }
    }

    public void Disappear()
    {
        if (player != null)
        {
            player.QueueFree();
            player = null;
        }
    }
}
