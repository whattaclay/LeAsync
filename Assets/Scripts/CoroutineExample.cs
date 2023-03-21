using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class CoroutineExample : MonoBehaviour
{
  private void Start()
  {
    StartCoroutine(TextLoader());
  }

  private IEnumerator TextLoader()
  {
    var text =System.IO.File.ReadAllText(@"C:\Games\ExampleText.txt");
    Debug.Log(text);
    yield break;
  }
}

