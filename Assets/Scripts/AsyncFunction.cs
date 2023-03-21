using System;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

public class AsyncFunction : MonoBehaviour
{   
    private static async Task TextLoader()
    {
        var text = await System.IO.File.ReadAllTextAsync(@"C:\Games\ExampleText.txt");
        Debug.Log(text);
        
    }

    private async Task Start()
    {
        await TextLoader();
    }
}
