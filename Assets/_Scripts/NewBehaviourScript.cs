using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	public CharacterController MyController;
	public float speed = 3f;
	// Use this for initialization
	void Update () 
	{
		
		float x = 3f;
		float y = 2f;
		float z = 1f;
		Vector3 MyVector = new Vector3 (0, 0, 0); 
		MyVector.x = Input.GetAxis ("Horizontal");
		MyVector.z = Input.GetAxis ("Vertical");
		MyVector += speed;

		MyController.SimpleMove (MyVector);
	}
	

}
