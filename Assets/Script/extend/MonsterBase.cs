using UnityEngine;

public class MonsterBase : MonoBehaviour
{
	[SerializeField] internal int hitPoint;
	[SerializeField] internal int attackPoint;
	[SerializeField] internal int defencePoint;

	[SerializeField] internal string properName;
	
	public enum State
	{
		None,
		Fire,
		Cold,
	}

	public State state;

	public virtual int Attack()
	{
		return attackPoint;
	}

	internal virtual int DamegeAmount(int received) {
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
		Debug.Log(properName + "は" + damage +"のダメージをうけた");
		hitPoint -= damage;
		Debug.Log(properName + "のHpは" + hitPoint);
	}
}
