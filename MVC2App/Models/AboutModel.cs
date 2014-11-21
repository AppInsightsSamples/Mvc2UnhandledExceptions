using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC2App.Models
{
    public class AboutModel
    {
        public void saySomething()
        {
            try
            {
                sayNothing();
            }
            catch (Exception e)
            {
                throw new NotFiniteNumberException("not finite number", e);
            }
        }

        private void sayNothing()
        {
            throw new DivideByZeroException();
        }
    }
}