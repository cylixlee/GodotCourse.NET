using Godot;

public partial class SceneChanger : Node
{
    [Export]
    public string Path;

    public override void _PhysicsProcess(double delta)
    {
        base._PhysicsProcess(delta);
        if (Input.IsActionJustPressed("ui_accept"))
        {
            GetTree().ChangeSceneToFile(Path);
        }

        if (Input.IsActionJustPressed("ui_cancel"))
        {
            GetNode<MyAutoload>("/root/MyAutoload").SayCount();
        }
    }
}
