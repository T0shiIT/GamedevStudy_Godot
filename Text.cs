using Godot;
using System;

public partial class Text : Node2D
{
	public override void _Ready()
    {
        GD.Print("Hello world");
    }

	public override void _Process(double delta)
	{
	}
}
