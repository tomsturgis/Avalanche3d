using UnityEngine;
using System.Collections;

[System.Serializable]
public class IcicleBehavior : MonoBehaviour {
	public float speed;
	private Rigidbody rb;

	// Use this for initialization
	public void Start () {
		rb = GetComponent<Rigidbody>();
	}

	void onCollisionEnter (Collision col)
	{
		Debug.Log("hello");
	}
		
	// Update is called once per frame
	void FixedUpdate () {
		moveDown();
	}

	public void moveDown() {
		rb.velocity = getVelocity(speed);
	}

	public Vector2 getVelocity(float speed) {
		Vector2 movement = new Vector2(0f, -speed);
		return movement * speed;
	}
}
