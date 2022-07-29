using System;
namespace adv.topics
{
    class _indexers
    {
            public int a;
            public string b;
            public int c;
        public _indexers()
        {
            this.a = 10;
            this.b = "chetan";
            this.c = 20;
        }
            public object this[int index]
            {
            get
            {
                if(index == 0)
                {
                    return a;
                }else if(index == 1)
                {
                    return b;
                }else if(index == 2)
                {
                    return c;
                }
                return null;
            }
            set
            {
                 if(index ==0)
                {
                    this.a = (int)value;
                }else if(index == 1)
                {
                    this.b= (string)value;
                }else if (index == 2)
                {
                    this.c = (int)value;
                }
                
            }
            }
        static void Main()
        {
            _indexers obj = new _indexers();
            obj[1] = "CK";
            Console.WriteLine(obj[1]);
        }
    }
}