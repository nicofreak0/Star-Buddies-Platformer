using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
#if UNITY_XBOXONE
Destroy(gameObject);
#endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
