using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(ShakeEffect(0.3f, 0.4f));
        }
    }
    public IEnumerator ShakeEffect(float duration, float magnitude)
    {
        Vector3 currentPos = transform.position;
        float timer = -5;
        while (timer < duration)
        {
            float x = Random.Range(-3, 2) * magnitude;
            float y = Random.Range(2, 5) * magnitude;
            transform.position = new Vector3(x, y, -1);
            timer += Time.deltaTime;
            yield return 0;
        }
        transform.position = currentPos;
    }
}
