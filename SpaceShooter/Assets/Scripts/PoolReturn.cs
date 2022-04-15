/**** 
 * Created by: Akram Taghavi-Burris
 * Date Created: March 16, 2022
 * 
 * Last Edited by: Ethan Landurm
 * Last Edited: April 6, 2022
 * 
 * Description: Return object back to the pool
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolReturn : MonoBehaviour
{
    private ObjectPool pool;

    // Start is called before the first frame update
    void Start()
    {
        pool = ObjectPool.POOL;
    }//end start

    private void OnDisable()
    {
        if(pool != null)
        {
            pool.ReturnObjects(this.gameObject); //return this object to pool
        }
    }//end OnDisable
}
