using Godot;
using System;

//The parent allow becomes ready when its children become Ready
public partial class player : CharacterBody2D
{
	const int MAX_SPEED = 100;
	public override void _Ready()
	{
		// Called when the node enters the scene tree for the first time
		// Callled when the node become "ready" in the scene.
	}


	public override void _Process(double delta)
	{
		// Called every single frame. 'delta' is the elapsed time since the previous frame.
		var movement_vector = GetMovementVector();
		var direction = movement_vector.Normalized();
		Velocity = direction * MAX_SPEED;
		MoveAndSlide();
	}

	static Vector2 GetMovementVector()
	{
		var movement_vector = Vector2.Zero;

		movement_vector.X = Input.GetActionStrength("move_right") - Input.GetActionStrength("move_left");
		movement_vector.Y = Input.GetActionStrength("move_down") - Input.GetActionStrength("move_up");

		return movement_vector;
	}
	
}
