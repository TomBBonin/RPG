using UnityEngine;
using System.Collections;

public class MobileApp : MonoBehaviour
{
    void Start()
    {
        DoLoaded();
    }

    private void DoLoaded() { GetComponent<Animator>().SetTrigger("DoLoaded"); }
}
