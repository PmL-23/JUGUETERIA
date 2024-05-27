﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Exceptions
{
    public class BusinessException : Exception
    {
        private string _message;

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }


        public BusinessException(string text)
        {
            this.Message = text;
        }

    }
}
