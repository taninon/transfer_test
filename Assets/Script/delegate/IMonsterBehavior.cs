using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IMonsterBehavior
{
	int Attack(int attackPoint,MonsterBehaviorState state);
	int DamegeAmount(int received, MonsterBehaviorState state);
}

public enum MonsterBehaviorState
{
	None,
	Fire,
	Cold,
}
