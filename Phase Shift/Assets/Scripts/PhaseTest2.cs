using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseTest2 : MonoBehaviour
{
	[SerializeField]
	private GameObject player1Controller;
	[SerializeField]
	private GameObject player2Controller;
	[SerializeField]
	private GameObject player1BController;
	[SerializeField]
	private GameObject player2BController;
	[SerializeField]
	private bool toDimension1;
	[SerializeField]
	private bool toDimension2;
	[SerializeField]
	private bool backToDimension1;
	[SerializeField]
	private bool backToDimension2;

	private void OnTriggerEnter(Collider other)
	{
		if (toDimension1 == true)
		{
			if(backToDimension2 == true)
			{
				player2Controller.SetActive(false);
				player2BController.SetActive(true);
			}
			else
			{
				player1BController.SetActive(false);
				player2Controller.SetActive(true);
			}
		}
		else if (toDimension2 == true)
		{
			if (backToDimension1 == true)
			{
				player1Controller.SetActive(false);
				player1BController.SetActive(true);
			}
			else
			{
				player1Controller.SetActive(false);
				player1BController.SetActive(true);
			}
		}
	}
}
