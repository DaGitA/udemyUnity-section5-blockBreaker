using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour
{
    static  GameObject instance;

	// Use this for initialization
	void Awake ()
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
