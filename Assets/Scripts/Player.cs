using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

public float velocidade;
public float alturaPulo;
	// Use this for initialization
	void Start () {
		transform.Translate(Vector2.right * velocidade * Time.deltaTime);
		transform.eulerAngles = new Vector2(0,0);
	}
	
	// Update is called once per frame
	void Update () {
		Movimentar();
	}

	void Movimentar() {
			transform.Translate(Vector2.right * velocidade * Time.deltaTime);
			transform.eulerAngles = new Vector2(0,0);	

		   
	}
}
