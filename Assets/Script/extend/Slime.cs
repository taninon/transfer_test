using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonsterBase
{
	public override int Attack()
	{
		switch (state)
		{
			case State.Fire:
				break;
			case State.Cold:
				return (int)(attackPoint * 1.5);
		}

		return base.Attack();
	}

	internal override int DamegeAmount(int received)
	{
		switch (state)
		{
			case State.Fire:
				return (int)(base.DamegeAmount(received * 2));
			case State.Cold:
				break;
		}

		return base.DamegeAmount(received);
	}
}
