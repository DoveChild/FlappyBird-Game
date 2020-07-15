using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class TubeSpawnerControl : MonoBehaviour
{
    private float maxTime = 2.0f;
    private float timer = 0;
    public GameObject tube;
    private float height = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
		{
            GameObject newTube = Instantiate(tube);
            newTube.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newTube, 14);
            timer = 0;
		}
        timer += Time.deltaTime;
    }
}
