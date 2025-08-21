using Godot;

public partial class Child : Node
{
    public override void _Ready()
    {
        base._Ready();
        var parent = GetParent<Root>();
        parent.CallDeferred(Node.MethodName.AddChild, new Node2D
        {
            Name = "ChildRequestedChild"
        });
    }

    public override void _Process(double delta)
    {
        base._Process(delta);

        if (Input.IsActionJustPressed("ui_accept"))
        {
            var root = GetTree().CurrentScene; // The root node.

            // var self = root.FindChild("Child");
            // self.QueueFree();

            var grandSon = root.FindChild("Grandson");
            GD.Print("Grandson: " + (grandSon != null));
            if (grandSon == null)
            {
                return;
            }
            root.RemoveChild(grandSon);
            AddChild(grandSon);
        }
    }
}
