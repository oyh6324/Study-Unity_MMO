using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputManager : MonoBehaviour
{
    public Action KeyAction = null;

    public void OnUpdate()
    {
        if (Input.anyKey == false)
            return;

        if (KeyAction != null)
            KeyAction.Invoke();
    }

    //이렇게 해 놓으면 KeyAction을 실행하는 것은 한 곳이라 인풋 오류가 났을 때
    // 16줄에 브레이크를 걸고 안에 무슨 함수가 들었는지 확인할 수 있음
}
