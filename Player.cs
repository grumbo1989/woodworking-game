using Godot;
using System;
using static System.Math;

public partial class Player : CharacterBody3D
{
    const double MouseSensitivity = 0.002;

    private Camera3D camera;

    public override void _Ready()
    {
        base._Ready();
        Input.MouseMode = Input.MouseModeEnum.Captured;
        camera = (Camera3D) GetNode("Camera3D");
    }


    public override void _Input(InputEvent @event)
    {
        base._Input(@event);
        if (@event is InputEventMouseMotion && Input.MouseMode == Input.MouseModeEnum.Captured)
        {
            InputEventMouseMotion mouseEvent = (InputEventMouseMotion)@event;
            RotateY(-mouseEvent.Relative.X * (float)MouseSensitivity);
            camera.RotateX(-mouseEvent.Relative.Y * (float)MouseSensitivity);
            camera.Rotation = camera.Rotation with { X = Clamp(camera.Rotation.X, -Mathf.DegToRad(70), Mathf.DegToRad(70))};
        }
    }
}
