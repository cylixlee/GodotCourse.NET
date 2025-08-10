using Godot;

public partial class LifetimeGuard : Node2D
{
    // Called when the node enters the scene tree for the first time.
    //
    // Note this time the children does not enter the scene tree.
    public override void _EnterTree()
    {
        base._EnterTree();
        GD.Print($"{Name} entered");
    }

    // Called when the node is prepared.
    //
    // That is, all of its children have entered the tree and are ready.
    public override void _Ready()
    {
        base._Ready();
        GD.Print($"{Name} ready");
        QueueFree();
    }

    public override void _ExitTree()
    {
        base._ExitTree();
        GD.Print($"{Name} exited");
    }
}
