using Godot;

public partial class Root : Node2D
{
    public override void _Process(double delta)
    {
        base._Process(delta);
        if (Input.IsActionJustPressed("ui_cancel"))
        {
            var anotherChild = FindChild("AnotherChild", owned: false);
            if (anotherChild != null)
            {
                return;
            }
            anotherChild = new Node
            {
                Name = "AnotherChild"
            };
            AddChild(anotherChild);
        }
    }
}
