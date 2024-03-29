using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class TestGlobalRef : MonoBehaviour
{
    public bool SetGlobalRef = false;

    // Update is called once per frame
    void Update()
    {
        if(SetGlobalRef)
        {
            SetGlobalRef = false;
            SP.GlobalOrigin.setTransform(gameObject.transform);
            SP.GlobalOrigin.setRot(gameObject.transform.rotation);

            print(SP.TransformConversions.posRelativeTo(SP.GlobalOrigin.getTransform(), gameObject.transform));
        }
    }
}
