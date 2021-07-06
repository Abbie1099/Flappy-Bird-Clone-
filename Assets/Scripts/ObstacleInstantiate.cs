using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleInstantiate : MonoBehaviour
{
    public GameObject prefab;
    private float Delay = 2.0f;
    public Vector2 delayRange = new Vector2(1, 2);
    // Start is called before the first frame update
    void Start()
    {
        resetDelay();
        StartCoroutine(Generator());
    }

    // Update is called once per frame
    IEnumerator Generator()
    {
        yield return new WaitForSeconds(Delay);
        GameObject ob = Instantiate(prefab);
        prefab.transform.position = new Vector3(5.0f, Random.Range(-1.0f, 1.0f), 0f);
        
        resetDelay();
        StartCoroutine(Generator());
        Destroy(ob, 6.0f);
        
    }
    void resetDelay()
    {
        Delay = Random.Range(delayRange.x, delayRange.y);
    }

}
