using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonBehavior : IMonsterBehavior
{
	public int Attack(int attackPoint, MonsterBehaviorState state)
	{
		switch (state)
		{
			case MonsterBehaviorState.Fire:
				return (int)(attackPoint * 3);
			case MonsterBehaviorState.Cold:
				return (int)(attackPoint * 0.8);
		}

		return attackPoint;
	}

	public int DamegeAmount(int received, MonsterBehaviorState state)
	{
		switch (state)
		{
			case MonsterBehaviorState.Fire:
				return 0;
			case MonsterBehaviorState.Cold:
				break;
		}

		return received;
	}

}
