using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dispose
{
    class Class1 : IDisposable
    {
        private bool disposed = false;
        public void Dispose()
        {
            Dispose(true);

            //通知CLR不要调用该对象的析构函数，因为清除工作已经完成
            GC.SuppressFinalize(this);
        }

        ~Class1()
        {
            //如果代码忘了调用Dispose，析构的时候调用它，并释放资源
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed == false)
            {
                if (disposing)
                {
                    //释放托管资源
                }

                //释放非托管资源
            }

            disposed = true;
        }
    }
}
