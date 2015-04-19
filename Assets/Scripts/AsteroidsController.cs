using UnityEngine;
using System.Collections;

// Class that reacts to the collisions of the asteroids
public class AsteroidsController : MonoBehaviour {

	// Keep track of the amount of collisions
	public int collisionCount = 0;

	// Notify collisions to UI
	public delegate void CollisionEntered();
	public event CollisionEntered OnCollisionEntered;

	// The collision starts NOW
	void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.GetComponent<PlanetController>() != null){
			// We are colliding with a planet
			IncreaseCollisionCount();
		}
	}

	void IncreaseCollisionCount ()
	{
		// Normal increment
		collisionCount ++;

		// We notify the listeners
		if (OnCollisionEntered != null)
			OnCollisionEntered();
	}
}
