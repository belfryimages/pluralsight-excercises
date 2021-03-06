﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Aspects;

namespace InterceptEvent
{
    [Serializable]
    public class LoggingEventInterceptionAspect : EventInterceptionAspect
    {
        public override void OnAddHandler(EventInterceptionArgs args)
        {
            base.OnAddHandler(args);
            Console.WriteLine("handler added");
        }
        public override void OnRemoveHandler(EventInterceptionArgs args)
        {
            base.OnRemoveHandler(args);
            Console.WriteLine("handler removed");
        }

        public override void OnInvokeHandler(EventInterceptionArgs args)
        {
            try
            {
                base.OnInvokeHandler(args);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Handler threw an exception: {0}", ex.Message);
            }
            Console.WriteLine("handler invoked");
        }
    }
}
