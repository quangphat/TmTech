using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tmtech.CoreMain
{
    public interface IA { }
    public interface IB { }
    public class A : IA { public override string ToString() => "A"; }
    public class B : IB { public override string ToString() => "B"; }
}
