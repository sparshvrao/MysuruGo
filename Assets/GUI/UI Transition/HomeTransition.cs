using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeTransition : MonoBehaviour
{
    public void SceneTranstion()
    {
        List<GameObject> list = new List<GameObject>();
        list.Add(gameObject);
        SceneTransitionManager.Instance.GoToScene(MysoreGoConstant.SCENE_WORLD, list);

    }
}
