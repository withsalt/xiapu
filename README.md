
# 虾圤中文编程语言


## 啊！！！我是友军！！！

### 特色

**虾圤，第一款开源、跨平台、高性能的中文编程语言！**  

### 案例  
```
using 虾圤.系统包;
using 虾圤核心包.集合包.通用包;

namespace 案例
{
    class 程序
    {
        public static void 开始(字符串[] args)
        {
            字符串 字符串1 = "你好，世界！";
            控制台.打印(字符串1);
            控制台.打印();

            //
            测试列表();
        }

        private static void 测试列表()
        {
            列表<整型> 列表1 = new();
            for(整型 临时变量 = 0; 临时变量 < 10; 临时变量++)
            {
                列表1.添加(临时变量);
            }
            控制台.打印($"列表1中的元素个数：{列表1.数量}");
        }
    }
}

```

除了少数几个关键词而外，全中文编程语法。
<details>

| | | | | | | |
| ----- | ----- | ----- | ----- | ----- | ----- | ----- |
|abstract|base|as|bool|break|catch|case|
|byte|char|checked|class|const|continue|decimal|
|private|protected|public|return|readonly|ref|sbyte|
|explicit|extern|FALSE|finally|fixed|float|for|
|foreach|goto|if|implicit|in|in (generic modifier)|int|
|ulong|ushort|unchecked|using|unsafe|virtual|void|
|null|object|operator|out|out (generic modifier)|override|params|
|default|delegate|do|double|else|enum|event|
|sealed|short|sizeof|stackalloc|static|string|struct|
|switch|this|throw|TRUE|try|typeof|uint|
|abstract|base|as|bool|break|catch|case|
|volatile|while|\-|\-|\-|\-|\-|

</details>
