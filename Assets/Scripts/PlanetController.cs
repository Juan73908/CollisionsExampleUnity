using UnityEngine;
using System.Collections;

// Class that reacts to the collisions of the planet
public class PlanetController : MonoBehaviour {
	
	// prefab variables
	public GameObject collisionPrefab;

	// The collision starts NOW
	void OnCollisionEnter2D(Collision2D collision) {
		//if (collision.gameObject.GetComponent<PlanetController>() != null){
			// We are colliding with another planet
			Instantiate(collisionPrefab, GetMiddlePoint (collision.contacts), Quaternion.identity);
		//}
	}

	// Helper method to find the middle point of the contacts
	// In this example this should not be neccesary as contacts.Lenght should be equal 1 always
	public Vector2 GetMiddlePoint (ContactPoint2D[] contacts){
		// We follow the centroid method: http://en.wikipedia.org/wiki/Centroid
		Vector2 centroid = Vector2.zero;
		foreach (ContactPoint2D contact in contacts) {
			centroid += contact.point;
		}
		centroid = (centroid / contacts.Length);

		return centroid;
	}
}
