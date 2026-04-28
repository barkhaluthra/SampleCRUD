using SampleCRUD.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleCRUD.Interfaces
{
    public interface IDocumentProcessor
    {
        Stats Analyze(string document);
    }
}
