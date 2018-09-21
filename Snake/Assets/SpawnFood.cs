using UnityEngine;
public class SpawnFood : MonoBehaviour
{
	public GameObject foodPrefab;
	public Transform borderTop;
	public Transform borderBottom;
	public Transform borderRight;
	public Transform borderLeft;
	void Start ()
	{
		InvokeRepeating("Spawn", 3, 4);
	}
	void Update ()
	{
		
	}
	void Spawn()
	{
		int x = (int)Random.Range(borderLeft.position.x, borderRight.position.x);
		int y = (int)Random.Range(borderBottom.position.y, borderTop.position.y);
		Instantiate(foodPrefab, new Vector2(x, y), Quaternion.identity);
	}
}
