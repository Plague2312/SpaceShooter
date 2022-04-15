/**** 
 * Created by: Akram Taghavi-Burris
 * Date Created: March 16, 2022
 * 
 * Last Edited by: Ethan Landurm
 * Last Edited: April 14, 2022
 * 
 * Description: Return object back to the pool
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialScroller : MonoBehaviour
{
    /***Variables***/
    public Vector2 scrollSpeed = new Vector2(0, 0f);

    private Renderer goRenderer;
    private Material goMat;

    private Vector2 offset;

    // Start is called before the first frame update
    void Start()
    {
        goRenderer = GetComponent<Renderer>();
        goMat = goRenderer.material;
    }

    // Update is called once per frame
    void Update()
    {
        offset = (scrollSpeed * Time.deltaTime);
        goMat.mainTextureOffset += offset;
    }
}
