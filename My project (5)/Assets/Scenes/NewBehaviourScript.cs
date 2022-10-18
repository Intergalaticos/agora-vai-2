using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
  [SerializeField] private bool detectingPlayer;
   [SerializeField] private ink waterValue
   
   private PlayerItems player;

   // Start is called before the furst frame update
   void Start()
   {
	player = FindObjectOfTipe<PlayerItems>();
   }

   // Update is called once per frame
   void Update()
   {
		if(detectingPlayer && Imput.GetKeyDown(KeyCode.E))
		{
			Player.WaterLimit(waterValue);
		}
	}	

	void Oncoasting
	{
		int randowValue = Random.Range(1, 100);

		if(randomValue < percentage)
		{
			//conseguiu pescar o peixe
			Debug.Log("pescou!")
		}
		else
		{
			//pescou vento
			Debug.Log("não pescou!")
		}
	}

	Private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.CompareTag("Player"))
		{
			detectingPlayer = true;
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if(collision.CompareTag("Player"))
		{
			detectingPlayer = true;
		}
	}
