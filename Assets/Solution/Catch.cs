using UnityEngine;
using System.Collections;

public class Catch : MonoBehaviour
{
	void OnCollisionEnter(Collision c)
	{
		if (c.gameObject.name == "MewPokemon")
		{
			c.gameObject.SetActive(false);
			transform.gameObject.SetActive(false);
		}
	}
}
