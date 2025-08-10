using Godot;

public partial class Root : Node
{
    public override void _Process(double delta)
    {
        base._Process(delta);
        if (Input.IsActionJustPressed("Jump"))
        {
            GD.Print("<Jump> pressed");
        }

        /* THIS IS NOISY! */
        // if (Input.IsActionPressed("Jump"))
        // {
        //     GD.Print("<Jump> hold");
        // }

        if (Input.IsActionJustReleased("Jump"))
        {
            GD.Print("<Jump> released");
        }

        /* Get Action Strength */
        // GD.Print("Action Strength: ", Input.GetActionStrength("Jump"));

        /* Get Axis (Left & Right || Up & Down) */
        // float axis = Input.GetAxis("Left", "Right");

        /* Get Vector (Left & Right && Up & Down) */
        // Vector2 vector = Input.GetVector("Left", "Right", "Up", "Down");
    }
}
