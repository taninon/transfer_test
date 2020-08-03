using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterEntity :MonoBehaviour
{
	[SerializeField] internal int hitPoint;
	[SerializeField] internal int attackPoint;
	[SerializeField] internal int defencePoint;

	[SerializeField] internal string properName;

	internal IMonsterBehavior monsterBehavior;
	public MonsterBehaviorState state;

	public int Attack()
	{
		return monsterBehavior.Attack(attackPoint,state);
	}

	private int DamegeAmount(int received)
	{
		return DamegeCalculation(monsterBehavior.DamegeAmount(received, state));
	}

	internal int DamegeCalculation(int received)
	{
		var amount = received - defencePoint;

		if (amount < 0)
		{
			amount = 0;
		}

		return amount;
	}

	public void Damege(int received)
	{
		var damage = DamegeAmount(received);
		Debug.Log(properName + "は" + damage + "のダメージをうけた");
		hitPoint -= damage;
		Debug.Log(properName + "のHpは" + hitPoint);
	}
}
