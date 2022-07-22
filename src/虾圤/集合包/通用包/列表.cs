using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 虾圤核心包.集合包.通用包
{
    public class 列表<T> : List<T>
    {
        public void 添加(T t)
        {
            Add(t);
        }

        public void 移除(T t)
        {
            Remove(t);
        }

        public int 数量 => Count;

        public int 容量 => Capacity;
    }
}
