using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

	public Transform target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collidor other) {

		if (other.gameObject.CompareTag("Death")){
			this.transform.position = target.position;
	}
}
