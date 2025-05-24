using Godot;
using System;

public partial class World : Node3D
{
    public override void _Input(InputEvent @event)
    {
        base._Input(@event);
        if (@event.IsActionPressed("ui_cancel"))
        {
            Input.MouseMode = Input.MouseModeEnum.Visible;
        }
    }

}
