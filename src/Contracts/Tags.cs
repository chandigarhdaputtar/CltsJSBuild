using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public class Tags
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Types Type { get; set; }
        public List<string> Aliases { get; set; }
        public Func<string, Func<string>> Functionality { get; set; }
        public Predicate<Func<string>> RegisterTask { get; set; }
    }

    #region Enums
    public enum Types
    {
        Build,
        Path,
        Input
    }
    #endregion
}
