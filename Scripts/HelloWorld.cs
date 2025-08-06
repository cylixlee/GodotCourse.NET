using Godot;

public partial class HelloWorld : Node
{
    public override void _Ready()
    {
        base._Ready();
        GD.Print("[GodotCourse.NET]:: Hello World!");
    }
}
