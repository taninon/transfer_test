using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonsterBase
{
	public override int Attack()
	{
		switch (state)
		{
			case State.Fire:
				return (int)(attackPoint * 3);
			case State.Cold:
				return (int)(attackPoint * 0.8);
		}

		return base.Attack();
	}

	internal override int DamegeAmount(int received)
	{
		switch (state)
		{
			case State.Fire:
				return 0;
			case State.Cold:
				break;
		}

		return base.DamegeAmount(received);
	}
}
