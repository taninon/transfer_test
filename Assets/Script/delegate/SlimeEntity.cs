using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeEntity : MonsterEntity
{
	// Start is called before the first frame update
	void Awake()
    {
		monsterBehavior = new SlimeBehavior();
	}

}
