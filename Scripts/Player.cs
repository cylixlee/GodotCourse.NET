using Godot;

public partial class Player : Sprite2D
{
    public void OnMySignal()
    {
        Rotate(0.05f);
    }
}
