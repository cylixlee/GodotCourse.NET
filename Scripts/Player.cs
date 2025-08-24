using Godot;

public partial class Player : Sprite2D
{
    public override void _PhysicsProcess(double delta)
    {
        base._PhysicsProcess(delta);
        if (Input.IsActionPressed("ui_right"))
        {
            // var enemies = GetTree().GetNodesInGroup("Enemy");
            // foreach (var enemy in enemies)
            // {
            //     enemy.QueueFree();
            // }
            GetTree().CallGroup("Enemy", Node.MethodName.QueueFree);
        }
    }
}
