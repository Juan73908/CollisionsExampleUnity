using UnityEngine;
using System.Collections;

// Template for all kind of variables and methods related with 3D and 2D collisions
public class AllCollisionsTemplate: MonoBehaviour {

	// 3D Collisions variables
	public Collider generalCollider;
	public BoxCollider boxCollider;
	public SphereCollider sphereCollider;
	public MeshCollider meshCollider;

	// 2D Collisions variables
	public Collider2D generalCollider2D;
	public BoxCollider2D boxCollider2D;
	public CircleCollider2D circleCollider2D;
	public PolygonCollider2D polygonCollider2D;

	/// <summary>
	/// Collisions in 3D with another collider
	/// </summary>
	void OnCollisionEnter(Collision collision) {
		Debug.Log("OnCollisionEnter with GO: " + collision.gameObject.name, this);
	}
	
	void OnCollisionStay(Collision collision) {
		Debug.Log("OnCollisionStay with GO: " + collision.gameObject.name, this);
	}
	
	void OnCollisionExit(Collision collision) {
		Debug.Log("OnCollisionExit with GO: " + collision.gameObject.name, this);
	}

	/// <summary>
	/// Collisions in 3D with a Trigger collider
	/// </summary>
	void OnTriggerEnter(Collider collider) {
		Debug.Log("OnTriggerEnter with GO: " + collider.name, this);
	}

	void OnTriggerStay(Collider collider) {
		Debug.Log("OnTriggerStay with GO: " + collider.name, this);
	}

	void OnTriggerExit(Collider collider) {
		Debug.Log("OnTriggerExit with GO: " + collider.name, this);
	}

	/// <summary>
	/// Collisions in 2D with another collider
	/// </summary>
	void OnCollisionEnter2D(Collision2D collision) {
		Debug.Log("OnCollisionEnter2D with GO: " + collision.gameObject.name, this);
	}
	
	void OnCollisionStay2D(Collision2D collision) {
		Debug.Log("OnCollisionStay2D with GO: " + collision.gameObject.name, this);
	}
	
	void OnCollisionExit2D(Collision2D collision) {
		Debug.Log("OnCollisionExit2D with GO: " + collision.gameObject.name, this);
	}
	
	/// <summary>
	/// Collisions in 2D with a Trigger collider
	/// </summary>
	void OnTriggerEnter2D(Collider2D collider) {
		Debug.Log("OnTriggerEnter2D with GO: " + collider.name, this);
	}
	
	void OnTriggerStay2D(Collider2D collider) {
		Debug.Log("OnTriggerStay2D with GO: " + collider.name, this);
	}
	
	void OnTriggerExit2D(Collider2D collider) {
		Debug.Log("OnTriggerExit2D with GO: " + collider.name, this);
	}
}
