using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SimplifierSoftware.DuplicateTabHandler
{
    class Tab : ITab
    {
        public string FullyJustifiedFileName
        {
            get;
            set;
        }

        private IEnumerable<string> DirectoryList
        {
            get
            {
                if(string.IsNullOrWhiteSpace( FullyJustifiedFileName ))
                    return new string[]{};
                return Path.GetDirectoryName( FullyJustifiedFileName )
                    .Split(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar)
                    .Where(directory => !string.IsNullOrWhiteSpace(directory));
            }
        }

        private int FullyJustifiedFileNameDirectoryCount
        {
            get
            {
                return FullyJustifiedFileName.Split( Path.DirectorySeparatorChar ).Length - 1;
            }
        }
        public string VisibleTabName
        {
            get;
            set;
        }

        private int VisibleDirectoryCount
        {
            get
            {
                return VisibleTabName.Split( Path.DirectorySeparatorChar ).Length - 1;
            }
        }

        public bool ExpandTabName()
        {
            if( FullyJustifiedFileNameDirectoryCount <= VisibleDirectoryCount )
            {
                return false;
            }

            VisibleTabName = DirectoryList
                .Reverse()
                .ElementAt( VisibleDirectoryCount ) + Path.DirectorySeparatorChar + VisibleTabName;
            
            return true;
        }

    }
}
