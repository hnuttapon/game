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
        walk = GetComponent<Animator>();
       // walk.runtimeAnimatorController = Resources.Load("Assets/Kevin Iglesias/Basic Motions Pack/AnimationControllers/BasicMotions@Run.controller") as RuntimeAnimatorController;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.hasChanged)
        {
            // walk.runtimeAnimatorController = Resources.Load("Assets/Kevin Iglesias/Basic Motions Pack/AnimationControllers/BasicMotions@Run") as RuntimeAnimatorController;
            walk.SetTrigger("Play");
            StartCoroutine(Wait());

        }
        else if(!transform.hasChanged)
        {
            walk.SetTrigger("Stop");


        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1f);
        transform.hasChanged = false;
    }
}
