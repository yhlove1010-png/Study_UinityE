using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject targetPrefab;
    //public Transform spawnPosition; //스폰 위치 지정할 때

    public void SpawnTarget()
    {
        Instantiate(targetPrefab, transform.position, Quaternion.identity);

    }
}
