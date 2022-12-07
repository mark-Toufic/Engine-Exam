using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Hat : MonoBehaviour
{
	public abstract string Name { get; }

	public abstract GameObject Create(GameObject prefab, Transform playerHead);
}

public class GreenHat : Hat
{
	public override string Name => "Green Hat";

	public override GameObject Create(GameObject prefab, Transform playerHead)
	{
		Destroy(GameObject.FindGameObjectWithTag("Hat"));
		GameObject hat = Instantiate(prefab, playerHead);
		Debug.Log("Green hat is created");
		return hat;
	}
}

public class PinkHat : Hat
{
	public override string Name => "Pink Hat";

	public override GameObject Create(GameObject prefab, Transform playerHead)
	{
		Destroy(GameObject.FindGameObjectWithTag("Hat"));
		GameObject hat = Instantiate(prefab, playerHead);
		Debug.Log("Pink Hat is created");
		return hat;
	}
}
class BlueHat : Hat
{
	public override string Name => "Blue Hat";

	public override GameObject Create(GameObject prefab, Transform playerHead)
	{
		Destroy(GameObject.FindGameObjectWithTag("Hat"));
		GameObject hat = Instantiate(prefab, playerHead);
		Debug.Log("Blue Hat is created");
		return hat;
	}
}
