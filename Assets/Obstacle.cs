using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

public float speed = 0;
public float switchTime = 2;

	
void Start () {

	GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;

	}
	

	void Update () {
	
	}
}
