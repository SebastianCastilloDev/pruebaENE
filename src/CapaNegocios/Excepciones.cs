using System;

namespace CapaNegocios
{
    public class RutException : Exception
    {
        public RutException(string message) : base(message)
        {

        }
    }

    public class HorasTrabajadasException : Exception
    {
        public HorasTrabajadasException(string message) : base(message)
        {

        }
    }
    public class HorasExtraException : Exception
    {
        public HorasExtraException(string message) : base(message)
        {

        }
    }

    public class AfpException : Exception
    {
        public AfpException(string message) : base(message)
        {

        }
    }

    public class SaludException : Exception
    {
        public SaludException(string message) : base(message)
        {

        }
    }

}
