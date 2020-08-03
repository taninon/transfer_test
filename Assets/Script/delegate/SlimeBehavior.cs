using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeBehavior : IMonsterBehavior
{
	public int Attack(int attackPoint,MonsterBehaviorState state)
	{
		switch (state)
		{
			case MonsterBehaviorState.Fire:
				break;
			case MonsterBehaviorState.Cold:
				return (int)(attackPoint * 1.5);
		}

		return attackPoint;
	}

	public int DamegeAmount(int received, MonsterBehaviorState state)
	{
		switch (state)
		{
			case MonsterBehaviorState.Fire:
				return received * 2;
			case MonsterBehaviorState.Cold:
				break;
		}

		return received;
	}

}
