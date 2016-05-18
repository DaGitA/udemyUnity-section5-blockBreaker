using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour
{
    public LevelManager levelManager;

    public void OnTriggerEnter2D(Collider2D collision)
        {
            levelManager.loadLevel("lose");
        }
}
