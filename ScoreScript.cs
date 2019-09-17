using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public static int iPlunder = 0;

    static bool bHasBeenCreated = false;

    // Start is called before the first frame update
    void Start()
    {
        if (!bHasBeenCreated)
        {
            DontDestroyOnLoad(this.gameObject);
            bHasBeenCreated = true;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(iPlunder);
    }
}
