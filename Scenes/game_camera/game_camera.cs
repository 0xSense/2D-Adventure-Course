using Godot;
using System;
using System.Linq;

public partial class GameCamera : Camera2D
{
	// Called when the node enters the scene tree for the first time.
	Variant target_position = Vector2.Zero;
	public override void _Ready()
	{
		MakeCurrent();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		AcquireTarget();
	}

	public void AcquireTarget()
	{
		var player_nodes = GetTree().GetNodesInGroup("player");
		if (player_nodes.Count > 0)
		{
			var player = player_nodes[0] as Node2D;
			target_position = player.GlobalPosition;
		}
		
	}
}
