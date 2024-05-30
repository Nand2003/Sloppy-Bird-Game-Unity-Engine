using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    [SerializeField] GameObject pipes;

    int timer = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer ++;
        if(timer >= 100){
            timer = 0;
            GameObject pipe = Instantiate(pipes, new Vector2(transform.position.x,transform.position.y + Random.Range(-2, 2)),transform.rotation);
            Destroy(pipe, 5);
        }
    }
}
