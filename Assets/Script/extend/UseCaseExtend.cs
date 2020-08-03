using System.Collections;
using UnityEngine;

public class UseCaseExtend : MonoBehaviour
{
	[SerializeField] private MonsterBase monsterA;
	[SerializeField] private MonsterBase monsterB;

	// Start is called before the first frame update
	private void Start()
	{
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

	// Update is called once per frame
	private void Update()
	{

	}
}
