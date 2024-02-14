using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{   

    private float SpawnRate = 1.0f;
    public TextMeshProUGUI scoretext;
    public List<GameObject> targets;

    private int score;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTarget());
        score = 0;
        scoretext.text = "Score :" + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator SpawnTarget(){
        while (true) {
            yield return new WaitForSeconds(SpawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }

}
