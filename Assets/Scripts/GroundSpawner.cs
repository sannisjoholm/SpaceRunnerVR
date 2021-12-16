using UnityEngine;


public class GroundSpawner : MonoBehaviour
{
    public GameObject groundTile;
    Vector3 nextspawnPoint;
    
    public void SpawnTile()
    {
        GameObject temp = Instantiate(groundTile, nextspawnPoint, Quaternion.identity);
        nextspawnPoint = temp.transform.GetChild(1).transform.position;
    }
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            SpawnTile();
        }
    }
}