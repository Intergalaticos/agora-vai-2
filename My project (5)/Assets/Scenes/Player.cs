using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   

	public float speed;

	private Rigidbody2D rig;
	private Vector2 direction;


	private void Update()
	{
		direction = new Vector2(Input. GetAxisRaw("Horizontal"))
	}
}
