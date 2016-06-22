﻿using UnityEngine;
using System.Collections;

public class PhysicalFade : MonoBehaviour {

	float original;
	float stepSize = 0.025f;
	float maxDistance = 8f;
	// Use this for initialization
	void Start () {
		 original = this.transform.localScale.y;
	}

	// Update is called once per frame
	void Update () {

		float xVal = Mathf.Min (Mathf.Abs(this.transform.position.x), maxDistance);
		//float steps =  this.transform.position.x / stepSize ;
		float factor = (maxDistance - xVal) / maxDistance ;

//		if (factor < 0.1f)
//			factor = 0.1f;
		//print (this.transform.localScale.y * factor);
		this.transform.localScale = new Vector3(this.transform.localScale.x, original * factor * 2, this.transform.localScale.z);
	}
}
