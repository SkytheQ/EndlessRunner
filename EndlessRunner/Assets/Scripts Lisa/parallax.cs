using UnityEngine;
using System.Collections;

public class parallax : MonoBehaviour {

    public float parralax;

    // Update is called once per frame
    void Update()
    {
        SpriteRenderer mr = GetComponent<SpriteRenderer>();
        Material mat = mr.material;
        Vector2 offset = mat.mainTextureOffset;
        offset.x = transform.position.x / transform.localScale.x / parralax;
        mat.mainTextureOffset = offset;
    }
}
