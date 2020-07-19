using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Animator walk;

    int animate;
    // Start is called before the first frame update
    void Start()
    {
        //comment
        walk = GetComponent<Animator>();
        // walk.runtimeAnimatorController = Resources.Load("Assets/Kevin Iglesias/Basic Motions Pack/AnimationControllers/BasicMotions@Run.controller") as RuntimeAnimatorController;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        bool run = x != walk.transform.position.x || z != walk.transform.position.z;
        
        if (transform.hasChanged)
        {
            // if (run) { 
            walk.SetBool("isWalking", run);
            // walk.runtimeAnimatorController = Resources.Load("Assets/Kevin Iglesias/Basic Motions Pack/AnimationControllers/BasicMotions@Run") as RuntimeAnimatorController;
            walk.SetTrigger("Play");
            StartCoroutine(Wait());
            //}
            print("change");
        }
        else if (!transform.hasChanged)
        {
            //if(run != true)
            print("n");
            walk.SetTrigger("Stop");

            
        }

    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1f);
        transform.hasChanged = false;
    }
}
