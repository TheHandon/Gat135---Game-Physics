using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BroadPhase
{
	public abstract void Build(AABB aabb, List<Body> bodies);
	public abstract void Query(AABB aabb, List<Body> bodies);
	public abstract void Query(Body body, List<Body> bodies);
	public abstract void Draw();

	protected int potentialCollisionCount;

	public static int numberOfTests { get; set; } = 0;
	public static Color[] colors = { Color.white, Color.red, Color.green, Color.blue, Color.yellow, Color.magenta, Color.cyan };
}
