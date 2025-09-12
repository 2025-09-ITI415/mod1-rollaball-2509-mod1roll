using UnityEngine;
using System.Collections;

public class Rotator2 : MonoBehaviour {

	public float howFast = -1;

	// Before rendering each frame..
	void Update () 
	{
		// Rotate the game object that this script is attached to by 15 in the X axis,
		// 30 in the Y axis and 450in the Z axis, multiplied by deltaTime in order to make it per second
		// rather than per frame.
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
		LeftnRight2();

	}

	void LeftnRight2()
{
	Vector3 pos = transform.position; 
	pos.x += howFast * Time.deltaTime;
	transform.position = pos;
	
	if ( pos.x < -10f ) { 
	howFast = Mathf.Abs(howFast); 
	} else if ( pos.x > 10f ) {
		howFast = -Mathf.Abs(howFast); 
		}
}	
}