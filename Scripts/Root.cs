using Godot;

public partial class Root : Node
{
    public override void _Process(double delta)
    {
        base._Process(delta);
        // if (Input.IsKeyPressed(Key.A))
        // {
        //     GD.Print("[A] pressed");
        // }
    }

    public override void _Input(InputEvent @event)
    {
        base._Input(@event);
        if (@event is InputEventKey key)
        {
            if (key.Keycode == Key.A)
            {
                if (key.IsEcho())
                {
                    GD.Print("[A] echo");
                }
                else if (key.IsPressed())
                {
                    GD.Print("[A] pressed");
                }
                else if (key.IsReleased())
                {
                    GD.Print("[A] released");
                }
            }
        }
    }
}
