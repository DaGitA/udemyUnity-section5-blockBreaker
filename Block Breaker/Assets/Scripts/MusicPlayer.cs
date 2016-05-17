using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour
{
    static  GameObject instance;

	// Use this for initialization
	void Start ()
	{
	    if (instance != null)
	    {
	        Destroy(gameObject);
	    }
	    else
	    {
            instance = gameObject;
            GameObject.DontDestroyOnLoad(instance);
        }
    }
}
