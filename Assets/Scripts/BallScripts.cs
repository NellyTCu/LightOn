using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BallScripts : MonoBehaviour {
	public int  Number_Ball=10;
	public GameObject ball;
	public GameObject[] balls;
	public float moveSpeed = 10f;
	// Use this for initialization
	public float spawnWait=2f;
	void Start () {
		
		StartCoroutine (Spawn());
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);

	}
	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Square") {
			Destroy (gameObject);
		}
	}
	IEnumerator Spawn(){
		for (int i = 0; i <= Number_Ball; i++){
			GameObject ball= GameObject.FindWithTag("Ball");
			GameObject Ball = Instantiate (ball);
			Ball.SetActive (false);
			balls[i]=Ball;
			yield return new WaitForSeconds (spawnWait);
			Debug.Log (i);
		}
	}
}
