using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonEntity : MonsterEntity
{
    // Start is called before the first frame update
    void Awake()
    {
		monsterBehavior = new DragonBehavior();
	}

}
