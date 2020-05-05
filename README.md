# Uni Set Text Interface

テキスト設定時の GC Alloc を減らすことを目的としたインターフェイス

## 使用例

```cs
using UniSetTextInterface;
using UnityEngine.UI;

public class NameUI : ITextSetter
{
    public Text m_textUI;

    public void SetText( string text )
    {
        m_textUI.text = text;
    }
}
```

```cs
using UniSetTextInterface;
using UnityEngine;

public class Test : MonoBehaviour
{
    public NameUI m_nameUI;

    private void Start()
    {
        m_nameUI.SetText( 25 );
        m_nameUI.SetText( 25u );
        m_nameUI.SetText( 25f );
        m_nameUI.SetText( "{0}/{1}", 25, 151 );
    }
}
```
