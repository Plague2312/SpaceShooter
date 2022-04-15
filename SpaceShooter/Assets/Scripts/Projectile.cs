/**** 
 * Created by: Akram Taghavi-Burris
 * Date Created: March 16, 2022
 * 
 * Last Edited by: Ethan Landurm
 * Last Edited: April 6, 2022
 * 
 * Description: Projectile Behaviors
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    /*** Variables ***/
    private BoundsCheck bndCheck; //reference to the bounds check

    void Awake()
    {
        bndCheck = GetComponent<BoundsCheck>();
    }//end awake

    // Update is called once per frame
    void Update()
    {
        if (bndCheck.offUp)
        {
            gameObject.SetActive(false);
            bndCheck.offUp = false;
        }
    }//end update
}
