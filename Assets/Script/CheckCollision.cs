using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class CheckCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin")
        {
            Instantiate(AssetDatabase.LoadAssetAtPath("Assets/Standard Assets/ParticleSystems/Prefabs/Fireworks.prefab", typeof(GameObject)), other.gameObject.transform.position, Quaternion.Euler(-90, 0, 0));
            GameManager.Score += 10;
            Destroy(other.gameObject);
        }

        if(other.gameObject.layer == LayerMask.NameToLayer("Water"))
        {
            SceneManager.LoadScene("GameLoseScene");
        }
    }
}
