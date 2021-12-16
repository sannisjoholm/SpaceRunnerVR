using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheCow : MonoBehaviour
{
    float speed = 50f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Cow>() != null)
        {
            Destroy(gameObject);
            return;
        }
        if (other.gameObject.name != "Player")
        {
            return;
        }
        GameManager.inst.ScoreOutPut();
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
