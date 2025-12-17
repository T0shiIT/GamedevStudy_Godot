using Godot;
using System;

public partial class Text : Node2D
{
	public override void _Ready()
    {
        GD.Print("My name is Andrey");
    }

	public override void _Process(double delta)
	{
	}
}
