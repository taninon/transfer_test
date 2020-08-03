using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseCaseDelegate : MonoBehaviour
{

	[SerializeField] private MonsterEntity monsterA;
	[SerializeField] private MonsterEntity monsterB;

	[SerializeField] MonsterBehaviorState state;    // Start is called before the first frame update
	private void Start()
	{
		monsterA.state = state;
		monsterB.state = state;

		Debug.Log("バトルスタート");
		StartCoroutine(Battle());
	}

	private IEnumerator Battle()
	{
		while (monsterA.hitPoint > 0 && monsterB.hitPoint > 0)
		{
			monsterB.Damege(monsterA.Attack());
			yield return null;
			monsterA.Damege(monsterB.Attack());
			yield return null;
		}
		Debug.Log("バトル終了");

	}
}
