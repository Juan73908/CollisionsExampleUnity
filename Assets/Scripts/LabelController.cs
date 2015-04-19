using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LabelController : MonoBehaviour {

	public AsteroidsController asteroids;

	public Text label;
	public string labelBase = "Collisions = ";

	// Use this for initialization
	void Start () {
		if (asteroids == null)
			asteroids = GameObject.FindObjectOfType<AsteroidsController>();

		asteroids.OnCollisionEntered += UpdateCount;
		
		if (label == null)
			label = GameObject.FindObjectOfType<Text>();
	}
	
	// Update is called once per frame
	void UpdateCount () {
		label.text = labelBase + asteroids.collisionCount.ToString();
	}
}
