using Godot;

public partial class SceneChanger : Node
{
    [Export]
    public string Path;

    [Export]
    public PackedScene SubScene;

    public override void _PhysicsProcess(double delta)
    {
        base._PhysicsProcess(delta);
        if (Input.IsActionJustPressed("ui_accept"))
        {
            GetTree().ChangeSceneToFile(Path);
        }

        if (Input.IsActionJustPressed("ui_cancel"))
        {
            GetTree().CurrentScene.AddChild(SubScene.Instantiate());
        }
    }
}
