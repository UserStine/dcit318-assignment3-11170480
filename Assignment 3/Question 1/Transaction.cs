using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public record Transaction(int Id, DateTime Date, decimal Amount, string Category);

}
