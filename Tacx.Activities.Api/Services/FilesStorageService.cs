using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Tacx.Activities.Api.Services
{
    public class FilesStorageService
    {
        public FilesStorageService()
        {

        }

        public bool SaveFile(Stream file, string fileName, bool overwrite = false)
        {
            return true;
        }
    }
}
