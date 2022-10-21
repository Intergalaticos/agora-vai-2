using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casting : MonoBehaviour
{
   [SerializeField] private ink porcentage; //porcentagem de chance de pescar um peixe a cada tentativa
   
   private PlayerItems player;
   private Playeranim playeranim;
   private bool detectingPlayer

   // Start is called before the furst frame update
   void Start()
   {
	player = FindObjectOfTipe<PlayerItems>();
	PlayerAnim = GetComponent<PlayerAnim>()/
   }

   // Update is called once per frame
   void Update()
   {
		if(detectingPlayer && Imput.GetKeyDown(KeyCode.E))
		{
			playerAnim.OnCastingStarted();
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
